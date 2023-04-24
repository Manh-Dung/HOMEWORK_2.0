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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Account = new System.Windows.Forms.ToolStripMenuItem();
            this.addAcc = new System.Windows.Forms.ToolStripMenuItem();
            this.changePass = new System.Windows.Forms.ToolStripMenuItem();
            this.logOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTourMau = new System.Windows.Forms.DataGridView();
            this.maTourMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanhTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoangCach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.txtKhoangCach = new System.Windows.Forms.TextBox();
            this.txtHanhTrinh = new System.Windows.Forms.TextBox();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourMau)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Account,
            this.quanLy,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1437, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Account
            // 
            this.Account.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAcc,
            this.changePass,
            this.logOut,
            this.toolStripSeparator1,
            this.exit});
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(85, 24);
            this.Account.Text = "Tài khoản";
            // 
            // addAcc
            // 
            this.addAcc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.addAcc.Enabled = false;
            this.addAcc.Name = "addAcc";
            this.addAcc.Size = new System.Drawing.Size(214, 26);
            this.addAcc.Text = "Thêm tài khoản";
            this.addAcc.Click += new System.EventHandler(this.addAcc_Click);
            // 
            // changePass
            // 
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(214, 26);
            this.changePass.Text = "Thay đổi mật khẩu";
            this.changePass.Click += new System.EventHandler(this.changePass_Click);
            // 
            // logOut
            // 
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(214, 26);
            this.logOut.Text = "Đăng xuất";
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.ShortcutKeyDisplayString = "Alt + X";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exit.Size = new System.Drawing.Size(214, 26);
            this.exit.Text = "Thoát";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // quanLy
            // 
            this.quanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lớpToolStripMenuItem});
            this.quanLy.Name = "quanLy";
            this.quanLy.Size = new System.Drawing.Size(90, 24);
            this.quanLy.Text = "Danh mục";
            // 
            // lớpToolStripMenuItem
            // 
            this.lớpToolStripMenuItem.Name = "lớpToolStripMenuItem";
            this.lớpToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.lớpToolStripMenuItem.Text = "Điểm đến";
            this.lớpToolStripMenuItem.Click += new System.EventHandler(this.lớpToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.trợGiúpToolStripMenuItem.Text = "Báo cáo";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã tour mẫu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoảng cách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên tour mẫu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chi phí";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hành trình";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "> Để xóa, chọn dòng muốn xóa rồi ấn phím Delete";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(433, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "> Để sửa, Click vào ô cần sửa rồi sửa sau đó nhấn phím Update";
            // 
            // dgvTourMau
            // 
            this.dgvTourMau.BackgroundColor = System.Drawing.Color.White;
            this.dgvTourMau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourMau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTourMau,
            this.tenTour,
            this.hanhTrinh,
            this.khoangCach,
            this.chiPhi});
            this.dgvTourMau.Location = new System.Drawing.Point(12, 384);
            this.dgvTourMau.Name = "dgvTourMau";
            this.dgvTourMau.RowHeadersWidth = 51;
            this.dgvTourMau.RowTemplate.Height = 24;
            this.dgvTourMau.Size = new System.Drawing.Size(1413, 584);
            this.dgvTourMau.TabIndex = 7;
            this.dgvTourMau.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTourMau_RowEnter);
            // 
            // maTourMau
            // 
            this.maTourMau.DataPropertyName = "maTourMau";
            this.maTourMau.FillWeight = 55.14706F;
            this.maTourMau.HeaderText = "Mã tour mẫu";
            this.maTourMau.MinimumWidth = 6;
            this.maTourMau.Name = "maTourMau";
            this.maTourMau.Width = 125;
            // 
            // tenTour
            // 
            this.tenTour.DataPropertyName = "tenTour";
            this.tenTour.FillWeight = 49.08259F;
            this.tenTour.HeaderText = "Tên tour mẫu";
            this.tenTour.MinimumWidth = 6;
            this.tenTour.Name = "tenTour";
            this.tenTour.Width = 300;
            // 
            // hanhTrinh
            // 
            this.hanhTrinh.DataPropertyName = "hanhTrinh";
            this.hanhTrinh.FillWeight = 145.6233F;
            this.hanhTrinh.HeaderText = "Hành trình";
            this.hanhTrinh.MinimumWidth = 6;
            this.hanhTrinh.Name = "hanhTrinh";
            this.hanhTrinh.Width = 700;
            // 
            // khoangCach
            // 
            this.khoangCach.DataPropertyName = "khoangCach";
            this.khoangCach.FillWeight = 127.1862F;
            this.khoangCach.HeaderText = "Khoảng cách (Km)";
            this.khoangCach.MinimumWidth = 6;
            this.khoangCach.Name = "khoangCach";
            this.khoangCach.Width = 125;
            // 
            // chiPhi
            // 
            this.chiPhi.DataPropertyName = "chiPhi";
            this.chiPhi.FillWeight = 122.9609F;
            this.chiPhi.HeaderText = "Chi phí (VND)";
            this.chiPhi.MinimumWidth = 6;
            this.chiPhi.Name = "chiPhi";
            this.chiPhi.Width = 163;
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(156, 96);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(388, 27);
            this.txtMaTour.TabIndex = 0;
            // 
            // txtKhoangCach
            // 
            this.txtKhoangCach.Location = new System.Drawing.Point(156, 134);
            this.txtKhoangCach.Name = "txtKhoangCach";
            this.txtKhoangCach.Size = new System.Drawing.Size(388, 27);
            this.txtKhoangCach.TabIndex = 2;
            // 
            // txtHanhTrinh
            // 
            this.txtHanhTrinh.Location = new System.Drawing.Point(156, 174);
            this.txtHanhTrinh.Multiline = true;
            this.txtHanhTrinh.Name = "txtHanhTrinh";
            this.txtHanhTrinh.Size = new System.Drawing.Size(1213, 124);
            this.txtHanhTrinh.TabIndex = 4;
            // 
            // txtTenTour
            // 
            this.txtTenTour.Location = new System.Drawing.Point(682, 96);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(687, 27);
            this.txtTenTour.TabIndex = 1;
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(682, 136);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(687, 27);
            this.txtChiPhi.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(507, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(213, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(726, 307);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(208, 29);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(940, 307);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(216, 29);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1162, 307);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(207, 29);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(507, 338);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(213, 29);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(726, 340);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(643, 27);
            this.txtSearch.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Danh mục Tour mẫu";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 980);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtChiPhi);
            this.Controls.Add(this.txtTenTour);
            this.Controls.Add(this.txtHanhTrinh);
            this.Controls.Add(this.txtKhoangCach);
            this.Controls.Add(this.txtMaTour);
            this.Controls.Add(this.dgvTourMau);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourMau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem Account;
        public System.Windows.Forms.ToolStripMenuItem addAcc;
        private System.Windows.Forms.ToolStripMenuItem changePass;
        private System.Windows.Forms.ToolStripMenuItem logOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exit;
        public System.Windows.Forms.ToolStripMenuItem quanLy;
        private System.Windows.Forms.ToolStripMenuItem lớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTourMau;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.TextBox txtKhoangCach;
        private System.Windows.Forms.TextBox txtHanhTrinh;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTourMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanhTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoangCach;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiPhi;
    }
}