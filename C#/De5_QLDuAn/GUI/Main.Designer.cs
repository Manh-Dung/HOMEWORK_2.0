namespace GUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.taiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.themTK = new System.Windows.Forms.ToolStripMenuItem();
            this.thayDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDeTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboDeTai = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimK = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshK = new System.Windows.Forms.Button();
            this.btnSuaK = new System.Windows.Forms.Button();
            this.btnXoaK = new System.Windows.Forms.Button();
            this.btnThemK = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taiKhoan
            // 
            this.taiKhoan.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.taiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themTK,
            this.thayDoiMK,
            this.dangXuat,
            this.toolStripSeparator1,
            this.thoátToolStripMenuItem});
            this.taiKhoan.Name = "taiKhoan";
            this.taiKhoan.Size = new System.Drawing.Size(85, 24);
            this.taiKhoan.Text = "Tài khoản";
            // 
            // themTK
            // 
            this.themTK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.themTK.Enabled = false;
            this.themTK.Name = "themTK";
            this.themTK.Size = new System.Drawing.Size(214, 26);
            this.themTK.Text = "Thêm tài khoản";
            this.themTK.Click += new System.EventHandler(this.themTK_Click);
            // 
            // thayDoiMK
            // 
            this.thayDoiMK.Name = "thayDoiMK";
            this.thayDoiMK.Size = new System.Drawing.Size(214, 26);
            this.thayDoiMK.Text = "Thay đổi mật khẩu";
            this.thayDoiMK.Click += new System.EventHandler(this.thayDoiMK_Click);
            // 
            // dangXuat
            // 
            this.dangXuat.Name = "dangXuat";
            this.dangXuat.Size = new System.Drawing.Size(214, 26);
            this.dangXuat.Text = "Đăng xuất";
            this.dangXuat.Click += new System.EventHandler(this.dangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeyDisplayString = "Alt + X";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quanLy
            // 
            this.quanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khoaToolStripMenuItem,
            this.lớpToolStripMenuItem,
            this.mônHọcToolStripMenuItem,
            this.sinhViênToolStripMenuItem});
            this.quanLy.Enabled = false;
            this.quanLy.Name = "quanLy";
            this.quanLy.Size = new System.Drawing.Size(73, 24);
            this.quanLy.Text = "Quản lý";
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.khoaToolStripMenuItem.Text = "Khoa";
            this.khoaToolStripMenuItem.Click += new System.EventHandler(this.khoaToolStripMenuItem_Click);
            // 
            // lớpToolStripMenuItem
            // 
            this.lớpToolStripMenuItem.Name = "lớpToolStripMenuItem";
            this.lớpToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.lớpToolStripMenuItem.Text = "Lớp";
            this.lớpToolStripMenuItem.Click += new System.EventHandler(this.lớpToolStripMenuItem_Click);
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.mônHọcToolStripMenuItem.Text = "Giảng viên";
            this.mônHọcToolStripMenuItem.Click += new System.EventHandler(this.mônHọcToolStripMenuItem_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.sinhViênToolStripMenuItem.Text = "Đề tài";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.trợGiúpToolStripMenuItem.Text = "Báo cáo";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // trợGiúpToolStripMenuItem1
            // 
            this.trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            this.trợGiúpToolStripMenuItem1.Size = new System.Drawing.Size(78, 24);
            this.trợGiúpToolStripMenuItem1.Text = "Trợ giúp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taiKhoan,
            this.quanLy,
            this.trợGiúpToolStripMenuItem,
            this.hệThốngToolStripMenuItem,
            this.trợGiúpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.tenSV,
            this.ngaySinh,
            this.soDT,
            this.email,
            this.queQuan,
            this.maLop,
            this.maDeTai});
            this.dgvSinhVien.Location = new System.Drawing.Point(13, 63);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(1229, 312);
            this.dgvSinhVien.TabIndex = 2;
            this.dgvSinhVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_RowEnter);
            // 
            // maSV
            // 
            this.maSV.DataPropertyName = "maSV";
            this.maSV.HeaderText = "Mã sinh viên";
            this.maSV.MinimumWidth = 6;
            this.maSV.Name = "maSV";
            // 
            // tenSV
            // 
            this.tenSV.DataPropertyName = "tenSV";
            this.tenSV.HeaderText = "Tên sinh viên";
            this.tenSV.MinimumWidth = 6;
            this.tenSV.Name = "tenSV";
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            // 
            // soDT
            // 
            this.soDT.DataPropertyName = "soDT";
            this.soDT.HeaderText = "Số điện thoại";
            this.soDT.MinimumWidth = 6;
            this.soDT.Name = "soDT";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // queQuan
            // 
            this.queQuan.DataPropertyName = "queQuan";
            this.queQuan.HeaderText = "Quê quán";
            this.queQuan.MinimumWidth = 6;
            this.queQuan.Name = "queQuan";
            // 
            // maLop
            // 
            this.maLop.DataPropertyName = "maLop";
            this.maLop.HeaderText = "Mã lớp";
            this.maLop.MinimumWidth = 6;
            this.maLop.Name = "maLop";
            // 
            // maDeTai
            // 
            this.maDeTai.DataPropertyName = "maDeTai";
            this.maDeTai.HeaderText = "Mã đề tài";
            this.maDeTai.MinimumWidth = 6;
            this.maDeTai.Name = "maDeTai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã sinh viên";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(113, 398);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(471, 27);
            this.txtMaSinhVien.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sinh viên";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(113, 431);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(471, 27);
            this.txtTenSV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(113, 464);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(471, 27);
            this.txtNgaySinh.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(113, 497);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(471, 27);
            this.txtSDT.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(740, 398);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(500, 27);
            this.txtEmail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(668, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Quê quán";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(740, 431);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(500, 27);
            this.txtQueQuan.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lớp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Đề tài";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(740, 464);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(500, 27);
            this.cboLop.TabIndex = 5;
            // 
            // cboDeTai
            // 
            this.cboDeTai.FormattingEnabled = true;
            this.cboDeTai.Location = new System.Drawing.Point(740, 497);
            this.cboDeTai.Name = "cboDeTai";
            this.cboDeTai.Size = new System.Drawing.Size(500, 27);
            this.cboDeTai.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimK);
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Location = new System.Drawing.Point(660, 530);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 55);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnTimK
            // 
            this.btnTimK.Location = new System.Drawing.Point(6, 20);
            this.btnTimK.Name = "btnTimK";
            this.btnTimK.Size = new System.Drawing.Size(101, 27);
            this.btnTimK.TabIndex = 1;
            this.btnTimK.Text = "Tìm kiếm";
            this.btnTimK.UseVisualStyleBackColor = true;
            this.btnTimK.Click += new System.EventHandler(this.btnTimK_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(113, 20);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(461, 27);
            this.txtTim.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshK);
            this.groupBox1.Controls.Add(this.btnSuaK);
            this.groupBox1.Controls.Add(this.btnXoaK);
            this.groupBox1.Controls.Add(this.btnThemK);
            this.groupBox1.Location = new System.Drawing.Point(12, 530);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 55);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnRefreshK
            // 
            this.btnRefreshK.Location = new System.Drawing.Point(422, 20);
            this.btnRefreshK.Name = "btnRefreshK";
            this.btnRefreshK.Size = new System.Drawing.Size(144, 27);
            this.btnRefreshK.TabIndex = 0;
            this.btnRefreshK.Text = "Refresh";
            this.btnRefreshK.UseVisualStyleBackColor = true;
            this.btnRefreshK.Click += new System.EventHandler(this.btnRefreshK_Click);
            // 
            // btnSuaK
            // 
            this.btnSuaK.Location = new System.Drawing.Point(276, 20);
            this.btnSuaK.Name = "btnSuaK";
            this.btnSuaK.Size = new System.Drawing.Size(140, 27);
            this.btnSuaK.TabIndex = 0;
            this.btnSuaK.Text = "Sửa";
            this.btnSuaK.UseVisualStyleBackColor = true;
            this.btnSuaK.Click += new System.EventHandler(this.btnSuaK_Click);
            // 
            // btnXoaK
            // 
            this.btnXoaK.Location = new System.Drawing.Point(138, 20);
            this.btnXoaK.Name = "btnXoaK";
            this.btnXoaK.Size = new System.Drawing.Size(132, 27);
            this.btnXoaK.TabIndex = 0;
            this.btnXoaK.Text = "Xóa";
            this.btnXoaK.UseVisualStyleBackColor = true;
            this.btnXoaK.Click += new System.EventHandler(this.btnXoaK_Click);
            // 
            // btnThemK
            // 
            this.btnThemK.Location = new System.Drawing.Point(4, 20);
            this.btnThemK.Name = "btnThemK";
            this.btnThemK.Size = new System.Drawing.Size(128, 27);
            this.btnThemK.TabIndex = 0;
            this.btnThemK.Text = "Thêm";
            this.btnThemK.UseVisualStyleBackColor = true;
            this.btnThemK.Click += new System.EventHandler(this.btnThemK_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(540, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Danh sách sinh viên";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 594);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboDeTai);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripMenuItem taiKhoan;
        public System.Windows.Forms.ToolStripMenuItem themTK;
        private System.Windows.Forms.ToolStripMenuItem thayDoiMK;
        private System.Windows.Forms.ToolStripMenuItem dangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem quanLy;
        private System.Windows.Forms.ToolStripMenuItem khoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDeTai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboDeTai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimK;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshK;
        private System.Windows.Forms.Button btnSuaK;
        private System.Windows.Forms.Button btnXoaK;
        private System.Windows.Forms.Button btnThemK;
        private System.Windows.Forms.Label label9;
    }
}