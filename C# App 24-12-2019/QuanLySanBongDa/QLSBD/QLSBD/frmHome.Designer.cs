using System.ComponentModel;

namespace QLSBD
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnReloadFormPitchList = new System.Windows.Forms.Button();
            this.btnDeletePitch = new System.Windows.Forms.Button();
            this.btnEditPitch = new System.Windows.Forms.Button();
            this.btnAddNewPitch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPitchIntroduction = new System.Windows.Forms.TextBox();
            this.tbPitchAddress = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.cbbTypeOfPitch = new System.Windows.Forms.ComboBox();
            this.tbPitchName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvPitchList = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.end_time = new System.Windows.Forms.TextBox();
            this.start_time = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbCreater = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbPitchPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbPitchName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNewBooking = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvPitchInfo = new System.Windows.Forms.DataGridView();
            this.tabPage2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitchList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitchInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dgvPitchList);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1168, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "THÔNG TIN SÂN";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.btnReloadFormPitchList);
            this.panel7.Controls.Add(this.btnDeletePitch);
            this.panel7.Controls.Add(this.btnEditPitch);
            this.panel7.Controls.Add(this.btnAddNewPitch);
            this.panel7.Location = new System.Drawing.Point(8, 176);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(553, 84);
            this.panel7.TabIndex = 5;
            // 
            // btnReloadFormPitchList
            // 
            this.btnReloadFormPitchList.BackColor = System.Drawing.Color.White;
            this.btnReloadFormPitchList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReloadFormPitchList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReloadFormPitchList.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadFormPitchList.Image")));
            this.btnReloadFormPitchList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReloadFormPitchList.Location = new System.Drawing.Point(430, 21);
            this.btnReloadFormPitchList.Name = "btnReloadFormPitchList";
            this.btnReloadFormPitchList.Padding = new System.Windows.Forms.Padding(5);
            this.btnReloadFormPitchList.Size = new System.Drawing.Size(101, 43);
            this.btnReloadFormPitchList.TabIndex = 8;
            this.btnReloadFormPitchList.Text = "Làm mới";
            this.btnReloadFormPitchList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReloadFormPitchList.UseVisualStyleBackColor = false;
            this.btnReloadFormPitchList.Click += new System.EventHandler(this.btnReloadFormPitchList_Click);
            // 
            // btnDeletePitch
            // 
            this.btnDeletePitch.BackColor = System.Drawing.Color.White;
            this.btnDeletePitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeletePitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePitch.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePitch.Image")));
            this.btnDeletePitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePitch.Location = new System.Drawing.Point(296, 21);
            this.btnDeletePitch.Name = "btnDeletePitch";
            this.btnDeletePitch.Padding = new System.Windows.Forms.Padding(5);
            this.btnDeletePitch.Size = new System.Drawing.Size(90, 43);
            this.btnDeletePitch.TabIndex = 7;
            this.btnDeletePitch.Text = "Xoá";
            this.btnDeletePitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletePitch.UseVisualStyleBackColor = false;
            this.btnDeletePitch.Click += new System.EventHandler(this.btnDeletePitch_Click);
            // 
            // btnEditPitch
            // 
            this.btnEditPitch.BackColor = System.Drawing.Color.White;
            this.btnEditPitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditPitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditPitch.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPitch.Image")));
            this.btnEditPitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPitch.Location = new System.Drawing.Point(160, 21);
            this.btnEditPitch.Name = "btnEditPitch";
            this.btnEditPitch.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditPitch.Size = new System.Drawing.Size(85, 43);
            this.btnEditPitch.TabIndex = 6;
            this.btnEditPitch.Text = "Sửa";
            this.btnEditPitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditPitch.UseVisualStyleBackColor = false;
            this.btnEditPitch.Click += new System.EventHandler(this.btnEditPitch_Click);
            // 
            // btnAddNewPitch
            // 
            this.btnAddNewPitch.BackColor = System.Drawing.Color.White;
            this.btnAddNewPitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddNewPitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewPitch.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewPitch.Image")));
            this.btnAddNewPitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewPitch.Location = new System.Drawing.Point(27, 21);
            this.btnAddNewPitch.Name = "btnAddNewPitch";
            this.btnAddNewPitch.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddNewPitch.Size = new System.Drawing.Size(88, 43);
            this.btnAddNewPitch.TabIndex = 5;
            this.btnAddNewPitch.Text = "Thêm";
            this.btnAddNewPitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewPitch.UseVisualStyleBackColor = false;
            this.btnAddNewPitch.Click += new System.EventHandler(this.btnAddNewPitch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 164);
            this.panel1.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.tbPitchIntroduction);
            this.panel8.Controls.Add(this.tbPitchAddress);
            this.panel8.Location = new System.Drawing.Point(635, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(500, 153);
            this.panel8.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giới thiệu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Địa chỉ";
            // 
            // tbPitchIntroduction
            // 
            this.tbPitchIntroduction.Location = new System.Drawing.Point(72, 34);
            this.tbPitchIntroduction.Multiline = true;
            this.tbPitchIntroduction.Name = "tbPitchIntroduction";
            this.tbPitchIntroduction.Size = new System.Drawing.Size(409, 100);
            this.tbPitchIntroduction.TabIndex = 4;
            // 
            // tbPitchAddress
            // 
            this.tbPitchAddress.Location = new System.Drawing.Point(72, 8);
            this.tbPitchAddress.Name = "tbPitchAddress";
            this.tbPitchAddress.Size = new System.Drawing.Size(409, 20);
            this.tbPitchAddress.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnAddNewCategory);
            this.panel10.Controls.Add(this.cbbTypeOfPitch);
            this.panel10.Controls.Add(this.tbPitchName);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Location = new System.Drawing.Point(0, 1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(535, 93);
            this.panel10.TabIndex = 6;
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCategory.Location = new System.Drawing.Point(392, 38);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(97, 23);
            this.btnAddNewCategory.TabIndex = 8;
            this.btnAddNewCategory.Text = "THÊM LOẠI";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // cbbTypeOfPitch
            // 
            this.cbbTypeOfPitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeOfPitch.FormattingEnabled = true;
            this.cbbTypeOfPitch.Location = new System.Drawing.Point(126, 39);
            this.cbbTypeOfPitch.Name = "cbbTypeOfPitch";
            this.cbbTypeOfPitch.Size = new System.Drawing.Size(260, 21);
            this.cbbTypeOfPitch.TabIndex = 2;
            // 
            // tbPitchName
            // 
            this.tbPitchName.Location = new System.Drawing.Point(126, 11);
            this.tbPitchName.Name = "tbPitchName";
            this.tbPitchName.Size = new System.Drawing.Size(363, 20);
            this.tbPitchName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Loại sân";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên sân bóng";
            // 
            // dgvPitchList
            // 
            this.dgvPitchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPitchList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPitchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPitchList.Location = new System.Drawing.Point(8, 266);
            this.dgvPitchList.Name = "dgvPitchList";
            this.dgvPitchList.RowHeadersWidth = 51;
            this.dgvPitchList.Size = new System.Drawing.Size(1135, 253);
            this.dgvPitchList.TabIndex = 9;
            this.dgvPitchList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPitchList_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(30, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 612);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1168, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ĐẶT SÂN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Location = new System.Drawing.Point(9, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 199);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txttrangthai);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.end_time);
            this.panel3.Controls.Add(this.start_time);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpBookingDate);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbbCreater);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(637, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 147);
            this.panel3.TabIndex = 4;
            // 
            // txttrangthai
            // 
            this.txttrangthai.Location = new System.Drawing.Point(129, 83);
            this.txttrangthai.Margin = new System.Windows.Forms.Padding(2);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(44, 20);
            this.txttrangthai.TabIndex = 6;
            this.txttrangthai.Text = "1";
            this.txttrangthai.MouseLeave += new System.EventHandler(this.txttrangthai_MouseLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Trạng Thái";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "h";
            // 
            // end_time
            // 
            this.end_time.Location = new System.Drawing.Point(305, 46);
            this.end_time.Margin = new System.Windows.Forms.Padding(2);
            this.end_time.Name = "end_time";
            this.end_time.Size = new System.Drawing.Size(44, 20);
            this.end_time.TabIndex = 5;
            this.end_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.end_time_KeyPress);
            this.end_time.Validated += new System.EventHandler(this.end_time_Validated);
            // 
            // start_time
            // 
            this.start_time.Location = new System.Drawing.Point(129, 46);
            this.start_time.Margin = new System.Windows.Forms.Padding(2);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(44, 20);
            this.start_time.TabIndex = 4;
            this.start_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.start_time_KeyPress);
            this.start_time.Validated += new System.EventHandler(this.start_time_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Thời gian kết thúc";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingDate.Location = new System.Drawing.Point(129, 9);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(96, 20);
            this.dtpBookingDate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày đặt sân";
            // 
            // cbbCreater
            // 
            this.cbbCreater.Enabled = false;
            this.cbbCreater.FormattingEnabled = true;
            this.cbbCreater.Location = new System.Drawing.Point(129, 119);
            this.cbbCreater.Name = "cbbCreater";
            this.cbbCreater.Size = new System.Drawing.Size(352, 21);
            this.cbbCreater.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhân viên lập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thời gian bắt đầu";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbPitchPrice);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.cbbPitchName);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.tbNote);
            this.panel9.Location = new System.Drawing.Point(4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(562, 174);
            this.panel9.TabIndex = 3;
            // 
            // tbPitchPrice
            // 
            this.tbPitchPrice.Location = new System.Drawing.Point(128, 61);
            this.tbPitchPrice.Name = "tbPitchPrice";
            this.tbPitchPrice.Size = new System.Drawing.Size(362, 20);
            this.tbPitchPrice.TabIndex = 1;
            this.tbPitchPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPitchPrice_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Giá sân ( theo tiếng )";
            // 
            // cbbPitchName
            // 
            this.cbbPitchName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPitchName.FormattingEnabled = true;
            this.cbbPitchName.Location = new System.Drawing.Point(128, 21);
            this.cbbPitchName.Name = "cbbPitchName";
            this.cbbPitchName.Size = new System.Drawing.Size(363, 21);
            this.cbbPitchName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên sân bóng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ghi chú";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(128, 119);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(362, 41);
            this.tbNote.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(8, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1136, 315);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Controls.Add(this.btnAddNewBooking);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(563, 84);
            this.panel5.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(435, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Size = new System.Drawing.Size(101, 43);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(290, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btnDelete.Size = new System.Drawing.Size(101, 43);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Hủy Đơn";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(165, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(5);
            this.btnEdit.Size = new System.Drawing.Size(85, 43);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNewBooking
            // 
            this.btnAddNewBooking.BackColor = System.Drawing.Color.White;
            this.btnAddNewBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewBooking.Image")));
            this.btnAddNewBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewBooking.Location = new System.Drawing.Point(32, 17);
            this.btnAddNewBooking.Name = "btnAddNewBooking";
            this.btnAddNewBooking.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddNewBooking.Size = new System.Drawing.Size(88, 43);
            this.btnAddNewBooking.TabIndex = 8;
            this.btnAddNewBooking.Text = "Thêm";
            this.btnAddNewBooking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewBooking.UseVisualStyleBackColor = false;
            this.btnAddNewBooking.Click += new System.EventHandler(this.btnAddNewBooking_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvPitchInfo);
            this.panel6.Location = new System.Drawing.Point(3, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1130, 218);
            this.panel6.TabIndex = 1;
            // 
            // dgvPitchInfo
            // 
            this.dgvPitchInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPitchInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvPitchInfo.CausesValidation = false;
            this.dgvPitchInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPitchInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvPitchInfo.Name = "dgvPitchInfo";
            this.dgvPitchInfo.ReadOnly = true;
            this.dgvPitchInfo.RowHeadersWidth = 51;
            this.dgvPitchInfo.Size = new System.Drawing.Size(1127, 212);
            this.dgvPitchInfo.TabIndex = 12;
            this.dgvPitchInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPitchInfo_CellClick);
            // 
            // frmHome
            // 
            this.AcceptButton = this.btnAddNewBooking;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 567);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SÂN BÓNG";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.tabPage2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitchList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitchInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPitchList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbCreater;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbbPitchName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNewBooking;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvPitchInfo;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnReloadFormPitchList;
        private System.Windows.Forms.Button btnDeletePitch;
        private System.Windows.Forms.Button btnEditPitch;
        private System.Windows.Forms.Button btnAddNewPitch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPitchIntroduction;
        private System.Windows.Forms.TextBox tbPitchAddress;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cbbTypeOfPitch;
        private System.Windows.Forms.TextBox tbPitchName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.TextBox tbPitchPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox end_time;
        private System.Windows.Forms.TextBox start_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttrangthai;
    }
}