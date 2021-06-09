using System;
using System.Windows.Forms;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;

namespace QLSBD
{
    public partial class frmHome : Form
    {
        QLSBDataContext db = new QLSBDataContext();
        public string recentAccount;
        public frmHome()
        {
            InitializeComponent();
        }
        // Hàm show MessageConfirm
        public DialogResult messageConfirm(String message)
        {
            var confirmResult = MessageBox.Show(message,
                                     "Thông báo",
                                     MessageBoxButtons.YesNo);
            return confirmResult;
        }
        // Hàm get tất cả dữ liệu từ db đổ ra form
        private void loadDataToForm()
        {
            this.showDgvPitchInfo();
            this.showCbbEmployees();
            this.showCbbCategory(cbbTypeOfPitch);
            this.showDgvPitchList();
            this.showCbbPitchName();
            this.setEnableTextBox(this.end_time, false);
            this.setEnableTextBox(this.txttrangthai, false);
        }
        // Disable textbox thời gian kết thúc
        private void setEnableTextBox(TextBox tb, bool t)
        {
            tb.Enabled = t;
        }
        // Hàm so sánh giá trị từ db với textbox
        private bool comparitionBookingTable()
        {
            int pitch_id = Convert.ToInt32(cbbCreater.SelectedValue);
            int st = Convert.ToInt32(start_time.Text);
            int et = Convert.ToInt32(end_time.Text);
            string booking_day = dtpBookingDate.Value.ToString("d");
            var query = from booking in db.bookings
                        where booking.id_pitch == pitch_id &&
                        booking.start_time == st &&
                        booking.end_time == et
                        select booking;
            List<booking> list_booking = query.ToList();
            //
            int count = 0;
            foreach (var item in list_booking)
            {
                if (booking_day == item.book_day.ToString("d"))
                {
                    count++;
                }
            }
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Hiện datagridview bảng booking(join 3 bảng booking, pitch, admin)
        private void showCbbPitchName()
        {
            var query = from pitch in db.pitches
                        select pitch;
            cbbPitchName.DataSource = query;
            cbbPitchName.DisplayMember = "name";
            cbbPitchName.ValueMember = "id";
        }
        private void showDgvPitchInfo()
        {

            var query = from booking in db.bookings
                        where booking.status == 1
                        join pitch in db.pitches on booking.id_pitch equals pitch.id
                        select new
                        {
                            STT = booking.id,
                            Tên_sân = pitch.name,
                            Ngày_Đặt = booking.book_day,
                            Thời_Gian_Bắt_Đầu = booking.start_time,
                            Thời_Gian_Kết_Thúc = booking.end_time,
                            Giá = booking.price,
                            Ghi_chú = booking.message,
                            Trạng_Thái = booking.status,
                        };
            dgvPitchInfo.DataSource = query;
        }
        // Hiện datagridview các sân bên tab Thông tin sân
        private void showDgvPitchList()
        {
            var query = from pitch in db.pitches
                        join category in db.categories on pitch.id_category equals category.id
                        select new
                        {
                            STT = pitch.id,
                            Tên_sân = pitch.name,
                            Loại_sân = category.category1,
                            Giới_thiệu = pitch.introduction,
                            Địa_chỉ = pitch.address,
                            Trạng_thái = pitch.status
                        };
            this.dgvPitchList.DataSource = query;
        }
        // Hàm khi click vào cel; của datagridview
        private void dgvPitchInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbPitchName.Text = dgvPitchInfo.CurrentRow.Cells["Tên_sân"].Value.ToString();
            tbPitchPrice.Text = dgvPitchInfo.CurrentRow.Cells["Giá"].Value.ToString();
            tbNote.Text = dgvPitchInfo.CurrentRow.Cells["Ghi_chú"].Value.ToString();
            dtpBookingDate.Text = dgvPitchInfo.CurrentRow.Cells["Ngày_Đặt"].Value.ToString();
            start_time.Text = dgvPitchInfo.CurrentRow.Cells["Thời_Gian_Bắt_Đầu"].Value.ToString();
            end_time.Text = dgvPitchInfo.CurrentRow.Cells["Thời_Gian_Kết_Thúc"].Value.ToString();
            txttrangthai.Text = dgvPitchInfo.CurrentRow.Cells["Trạng_Thái"].Value.ToString();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        // Hàm lấy giá trị từ bảng admin đẩy ra combobox
        private void showCbbEmployees()
        {
            var query = from admin in db.admins
                        select admin;
            cbbCreater.DataSource = query.ToList();
            cbbCreater.DisplayMember = "username";
            cbbCreater.ValueMember = "id";
        }
        // Hàm hlấy giá trị từ bảng category đẩy ra combobox
        private void showCbbCategory(System.Windows.Forms.ComboBox cbbCategory)
        {
            var query = from category in db.categories
                        select category;
            cbbCategory.DataSource = query.ToList();
            cbbCategory.DisplayMember = "category1";
            cbbCategory.ValueMember = "id";
        }

        // Hàm làm click làm mới form
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.loadDataToForm();
        }
        // Hàm load tất cả dữ liệu từ db
        private void frmHome_Load(object sender, EventArgs e)
        {
            this.btnEditPitch.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            this.loadDataToForm();

        }

        // Hàm tải lại đặt sân
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            this.reloadTabBookingList();
        }
        private void reloadTabBookingList()
        {
            cbbPitchName.SelectedIndex = 0;
            tbPitchPrice.Text = "";
            tbNote.Text = "";
            dtpBookingDate.Text = "";
            start_time.Text = "";
            end_time.Text = "";
            txttrangthai.Text = "";
            this.showDgvPitchInfo();
        }
        //  Thêm booking
        private void btnAddNewBooking_Click(object sender, EventArgs e)
        {
            // Khai báo biến đếm
            // Xác nhận và Insert vào csdl
            var confirmResult = this.messageConfirm("Bạn muốn thêm sân bóng này chứ ?");
            if (confirmResult == DialogResult.Yes)
            {
                if (tbPitchPrice.Text == "" || start_time.Text == "" || end_time.Text == "" || txttrangthai.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập vào các truờng");
                }
                // Sửa 
                else if (this.comparitionBookingTable())
                {
                    MessageBox.Show("Sân này hiện tại đã có người đặt");
                }
                else
                {
                    booking booking = new booking();
                    booking.price = float.Parse(tbPitchPrice.Text.ToString());
                    booking.book_day = Convert.ToDateTime(dtpBookingDate.Value.ToString());
                    booking.start_time = Convert.ToInt32(start_time.Text.ToString());
                    booking.end_time = Convert.ToInt32(end_time.Text.ToString());
                    booking.status = Convert.ToInt32(txttrangthai.Text.ToString());
                    booking.id_user = Convert.ToInt32(cbbCreater.SelectedValue);
                    booking.id_pitch = Convert.ToInt32(cbbPitchName.SelectedValue);
                    booking.message = tbNote.Text;
                    db.bookings.InsertOnSubmit(booking);
                    db.SubmitChanges();
                    // reload trang
                    this.reloadTabBookingList();
                }
            }
        }
        //Sửa Sân Bóng
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.messageConfirm("Bạn muốn sửa chứ ?") == DialogResult.Yes)
            {
                if (tbPitchPrice.Text == "" || dtpBookingDate.Text == "" || start_time.Text == "" || end_time.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập vào các truờng");
                }
                else
                {
                    int id = Convert.ToInt32(dgvPitchInfo.CurrentRow.Cells["STT"].Value.ToString());
                    var query = from booking in db.bookings
                                where booking.id == id
                                select booking;
                    foreach (booking booking in query)
                    {
                        booking.price = Convert.ToInt32(tbPitchPrice.Text.ToString());
                        booking.message = tbNote.Text.ToString();
                        booking.book_day = Convert.ToDateTime(dtpBookingDate.Value.ToString());
                        booking.start_time = Convert.ToInt32(start_time.Text.ToString());
                        booking.end_time = Convert.ToInt32(end_time.Text.ToString());
                        booking.status = Convert.ToInt32(txttrangthai.Text.ToString());

                        // pitch.status = 0;
                    }
                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công");
                        this.reloadTabBookingList();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi !!!");
                    }
                }
            }
        }
        //hủy đơn 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.messageConfirm("Bạn chắc chắn muốn hủy đơn chứ?") == DialogResult.Yes)
            {
                if (txttrangthai.Text == "")
                {
                    MessageBox.Show("trạng thái này rỗng ");
                }
                else if (Convert.ToInt32(txttrangthai.Text.ToString()) == 0)
                {
                    MessageBox.Show("Đơn Hàng đang trong trạng thái hủy");
                }

                else
                {
                    int id = Convert.ToInt32(dgvPitchInfo.CurrentRow.Cells["STT"].Value.ToString());
                    var query = from booking in db.bookings
                                where booking.id == id
                                select booking;
                    foreach (booking booking in query)
                    {
                        booking.status = 0;
                    }
                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Hủy Đơn Thành Công");
                        this.reloadTabBookingList();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi !!!");
                    }
                }
            }

        }


        //validate thời gian bắt đầu và thời gian kết thúc
        private void start_time_Validation()
        {
            int st = Convert.ToInt32(start_time.Text);
            if (st < 1)
            {
                MessageBox.Show("Thời Gian Bắt đầu phải lớn hơn 1h ");
                start_time.Focus();
            }

            else if (st > 24)
            {
                MessageBox.Show("Thời Gian Bắt đầu phải nhỏ hơn 24h ");
                start_time.Focus();
            }
            else if (st >= Convert.ToInt32(end_time.Text))
            {
                MessageBox.Show("Thời Gian Bắt đầu phải nhỏ hơn thời gian kết thúc");
                start_time.Focus();
            }
        }

        private void end_time_Validated(object sender, EventArgs e)
        {
            if (end_time.Text == "")
            {
                MessageBox.Show("Mời nhập vào trường này !");
                end_time.Focus();
            }
            else
            {
                this.start_time_Validation();
                int et = Convert.ToInt32(end_time.Text);
                if (et < 1)
                {
                    MessageBox.Show("Thời Gian Kết Thúc phải lớn hơn 1h ");
                    end_time.Focus();
                    this.end_time.Text = "";
                }
                else if (et > 24)
                {
                    MessageBox.Show("Thời Gian Kết Thúc phải nhỏ hơn 24h ");
                    end_time.Focus();
                    this.end_time.Text = "";
                }
                else if (et <= Convert.ToInt32(start_time.Text))
                {
                    MessageBox.Show("Thời Gian kết thúc phải lớn hơn thời gian bắt đầu");
                    this.start_time.Focus();
                    this.end_time.Text = "";

                }

                //
                this.setEnableTextBox(end_time, false);
            }

        }
        // validate , giờ bắt đầu , kết thúc , giá tiền
        private void start_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void end_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPitchPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Hàm thêm sân bóng bên tabPanel thông tin sân
        private void btnAddNewPitch_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu các ô còn trốgn thì không cho phép insert

            string pitchName = tbPitchName.Text;
            int pitchType = Convert.ToInt32(cbbTypeOfPitch.SelectedValue.ToString());
            string pitchAddress = tbPitchAddress.Text;
            string pitchIntroduction = tbPitchIntroduction.Text;

            // Khởi tạo đối tượng
            pitch pitch = new pitch();
            pitch.name = pitchName;
            pitch.introduction = pitchIntroduction;
            pitch.id_category = pitchType;
            pitch.address = pitchAddress;
            pitch.status = 1;
            // Xác nhận và Insert vào csdl
            var confirmResult = this.messageConfirm("Bạn muốn thêm sân bóng này chứ ?");
            if (confirmResult == DialogResult.Yes)
            {
                if (tbPitchAddress.Text == "" || tbPitchIntroduction.Text == "" || tbPitchName.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập vào các truờng");
                }
                else
                {
                    db.pitches.InsertOnSubmit(pitch);
                    db.SubmitChanges();
                    // reload trang
                    this.reloadTabPitchList();
                }
            }
        }

        // Hàm tải lại thông tin sân
        private void reloadTabPitchList()
        {
            tbPitchName.Text = "";
            cbbTypeOfPitch.SelectedIndex = 0;
            tbPitchAddress.Text = "";
            tbPitchIntroduction.Text = "";
            this.showDgvPitchList();
            this.showCbbCategory(cbbTypeOfPitch);
        }

        // Phần này là phần bên thông tin sân(đang làm)
        private void btnReloadFormPitchList_Click(object sender, EventArgs e)
        {
            this.reloadTabPitchList();
        }

        private void btnEditPitch_Click(object sender, EventArgs e)
        {
            if (this.messageConfirm("Bạn muốn sửa chứ ?") == DialogResult.Yes)
            {
                if (tbPitchAddress.Text == "" || tbPitchIntroduction.Text == "" || tbPitchName.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập vào các truờng");
                }
                else
                {
                    int id = Convert.ToInt32(dgvPitchList.CurrentRow.Cells["STT"].Value.ToString());
                    var query = from pitch in db.pitches
                                where pitch.id == id
                                select pitch;
                    foreach (pitch pitch in query)
                    {
                        pitch.id_category = Convert.ToInt32(cbbTypeOfPitch.SelectedValue.ToString());
                        pitch.name = tbPitchName.Text.ToString();
                        pitch.introduction = tbPitchIntroduction.Text.ToString();
                        pitch.address = tbPitchAddress.Text.ToString();
                    }
                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công");
                        this.reloadTabPitchList();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi !!!");
                    }
                }
            }



        }

        private void dgvPitchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPitchName.Text = dgvPitchList.CurrentRow.Cells["Tên_sân"].Value.ToString();
            tbPitchIntroduction.Text = dgvPitchList.CurrentRow.Cells["Giới_thiệu"].Value.ToString();
            tbPitchName.Text = dgvPitchList.CurrentRow.Cells["Tên_sân"].Value.ToString();
            tbPitchAddress.Text = dgvPitchList.CurrentRow.Cells["Địa_chỉ"].Value.ToString();
            btnEditPitch.Enabled = true;
        }

        private void btnDeletePitch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvPitchList.CurrentRow.Cells["STT"].Value.ToString());
            var query = (from pitch in db.pitches
                         where pitch.id == id
                         select pitch).FirstOrDefault();
            if (query != null)
            {
                var confirm = this.messageConfirm("Bạn muốn xoá sân này chứ ?");
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        db.pitches.DeleteOnSubmit(query);
                        db.SubmitChanges();
                        this.reloadTabPitchList();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi !!!");
                    }

                }

            }
            else
            {
                MessageBox.Show("Lỗi ! Xin thử lại");
            }
        }

        private void btnOpenFormAddNewCategory_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            frmCategory.Show();
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            frmCategory.ShowDialog();
        }

        private void start_time_Validated(object sender, EventArgs e)
        {
            if (start_time.Text == "")
            {
                MessageBox.Show("Mời nhập vào trường này !");
                start_time.Focus();
            }
            else
            {
                this.setEnableTextBox(end_time, true);
                this.end_time.Focus();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.setEnableTextBox(txttrangthai, true);
        }

        private void txttrangthai_MouseLeave(object sender, EventArgs e)
        {
            this.setEnableTextBox(txttrangthai, false);
        }
    }
}