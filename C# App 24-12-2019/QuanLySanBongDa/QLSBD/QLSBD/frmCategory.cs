using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSBD
{
    public partial class frmCategory : Form
    {
        QLSBDataContext db = new QLSBDataContext();
        public frmCategory()
        {
            InitializeComponent();
        }
        private void addNewCategory()
        {
            if (tbCategoryName.Text == "")
            {
                this.lbError.Text = "Bạn phải nhập vào trường này !";
                this.lbError.Visible = true;
            }
            else
            {
                string categoryName1 = tbCategoryName.Text;
                var query = from category in db.categories
                            where category.category1 == categoryName1
                            select category;
                int totalRecord = query.ToList().Count;
                if (totalRecord > 0)
                {
                    this.lbError.Text = "Tên loại sân này đã tồn tại";
                }
                else
                {
                    category category = new category();
                    category.category1 = tbCategoryName.Text;
                    db.categories.InsertOnSubmit(category);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm mới thành công");
                }
            }
        }
        private void showDgvCategory()
        {
            var query = from category in db.categories
                        select new
                        {
                            STT = category.id,
                            Tên = category.category1,
                        };
            dgvCategory.DataSource = query;
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            this.showDgvCategory();
            this.setBtnEditCategoryDisable();
        }
        private void setBtnEditCategoryDisable()
        {
            this.btnEditCategory.Enabled = false;
        }
        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            this.addNewCategory();
            this.showDgvCategory();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEditCategory.Enabled = true;
            tbCategoryName.Text = dgvCategory.CurrentRow.Cells["Tên"].Value.ToString();
        }
        private void reloadFrmCategory()
        {
            this.tbCategoryName.Text = "";
            this.setBtnEditCategoryDisable();
            this.showDgvCategory();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {

            if (new frmHome().messageConfirm("Bạn muốn sửa chứ ?") == DialogResult.Yes)
            {
                if (tbCategoryName.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập vào các truờng");
                }
                else
                {
                    int id1 = Convert.ToInt32(dgvCategory.CurrentRow.Cells["STT"].Value.ToString());
                    string categoryName = tbCategoryName.Text;
                    var query = from category in db.categories
                                where category.id == id1
                                select category;
                    foreach (category category in query)
                    {
                        category.category1 = categoryName;
                    }
                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công");
                        this.reloadFrmCategory();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi !!!");
                    }
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCategory.CurrentRow.Cells["STT"].Value.ToString());
            var query = (from category in db.categories
                         where category.id == id
                         select category).FirstOrDefault();
            if (query != null)
            {
                var confirm = new frmHome().messageConfirm("Bạn muốn xoá sân này chứ ?");
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        db.categories.DeleteOnSubmit(query);
                        db.SubmitChanges();
                        this.reloadFrmCategory();
                        MessageBox.Show("Thành công !");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Loại sân này đang được sử dụng! Xoá hết các sân đang sử dụng và thử lại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lỗi ! Xin thử lại");
            }
        }
    }
}
