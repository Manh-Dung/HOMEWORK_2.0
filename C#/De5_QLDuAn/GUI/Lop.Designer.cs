namespace GUI
{
    partial class Lop
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimK = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshK = new System.Windows.Forms.Button();
            this.btnSuaK = new System.Windows.Forms.Button();
            this.btnXoaK = new System.Windows.Forms.Button();
            this.btnThemK = new System.Windows.Forms.Button();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.maLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTenKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGiangVien = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimK);
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Location = new System.Drawing.Point(530, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 55);
            this.groupBox2.TabIndex = 23;
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
            this.txtTim.Size = new System.Drawing.Size(231, 27);
            this.txtTim.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshK);
            this.groupBox1.Controls.Add(this.btnSuaK);
            this.groupBox1.Controls.Add(this.btnXoaK);
            this.groupBox1.Controls.Add(this.btnThemK);
            this.groupBox1.Location = new System.Drawing.Point(12, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 55);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnRefreshK
            // 
            this.btnRefreshK.Location = new System.Drawing.Point(374, 20);
            this.btnRefreshK.Name = "btnRefreshK";
            this.btnRefreshK.Size = new System.Drawing.Size(117, 27);
            this.btnRefreshK.TabIndex = 0;
            this.btnRefreshK.Text = "Refresh";
            this.btnRefreshK.UseVisualStyleBackColor = true;
            this.btnRefreshK.Click += new System.EventHandler(this.btnRefreshK_Click);
            // 
            // btnSuaK
            // 
            this.btnSuaK.Location = new System.Drawing.Point(251, 20);
            this.btnSuaK.Name = "btnSuaK";
            this.btnSuaK.Size = new System.Drawing.Size(117, 27);
            this.btnSuaK.TabIndex = 0;
            this.btnSuaK.Text = "Sửa";
            this.btnSuaK.UseVisualStyleBackColor = true;
            this.btnSuaK.Click += new System.EventHandler(this.btnSuaK_Click);
            // 
            // btnXoaK
            // 
            this.btnXoaK.Location = new System.Drawing.Point(127, 20);
            this.btnXoaK.Name = "btnXoaK";
            this.btnXoaK.Size = new System.Drawing.Size(117, 27);
            this.btnXoaK.TabIndex = 0;
            this.btnXoaK.Text = "Xóa";
            this.btnXoaK.UseVisualStyleBackColor = true;
            this.btnXoaK.Click += new System.EventHandler(this.btnXoaK_Click);
            // 
            // btnThemK
            // 
            this.btnThemK.Location = new System.Drawing.Point(4, 20);
            this.btnThemK.Name = "btnThemK";
            this.btnThemK.Size = new System.Drawing.Size(117, 27);
            this.btnThemK.TabIndex = 0;
            this.btnThemK.Text = "Thêm";
            this.btnThemK.UseVisualStyleBackColor = true;
            this.btnThemK.Click += new System.EventHandler(this.btnThemK_Click);
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLop,
            this.tenLop,
            this.maKhoa,
            this.maGV});
            this.dgvLop.Location = new System.Drawing.Point(12, 12);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(862, 303);
            this.dgvLop.TabIndex = 26;
            this.dgvLop.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_RowEnter);
            // 
            // maLop
            // 
            this.maLop.DataPropertyName = "maLop";
            this.maLop.HeaderText = "Mã lớp";
            this.maLop.MinimumWidth = 6;
            this.maLop.Name = "maLop";
            this.maLop.Width = 90;
            // 
            // tenLop
            // 
            this.tenLop.DataPropertyName = "tenLop";
            this.tenLop.HeaderText = "Tên lớp";
            this.tenLop.MinimumWidth = 6;
            this.tenLop.Name = "tenLop";
            this.tenLop.Width = 150;
            // 
            // maKhoa
            // 
            this.maKhoa.DataPropertyName = "maKhoa";
            this.maKhoa.HeaderText = "Mã khoa";
            this.maKhoa.MinimumWidth = 6;
            this.maKhoa.Name = "maKhoa";
            this.maKhoa.Width = 80;
            // 
            // maGV
            // 
            this.maGV.DataPropertyName = "maGV";
            this.maGV.HeaderText = "Giảng viên";
            this.maGV.MinimumWidth = 6;
            this.maGV.Name = "maGV";
            this.maGV.Width = 60;
            // 
            // cboTenKhoa
            // 
            this.cboTenKhoa.FormattingEnabled = true;
            this.cboTenKhoa.Location = new System.Drawing.Point(641, 447);
            this.cboTenKhoa.Name = "cboTenKhoa";
            this.cboTenKhoa.Size = new System.Drawing.Size(233, 27);
            this.cboTenKhoa.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã lớp";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(117, 444);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(233, 27);
            this.txtTenLop.TabIndex = 28;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(117, 401);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(233, 27);
            this.txtMaLop.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Giảng viên";
            // 
            // cboGiangVien
            // 
            this.cboGiangVien.FormattingEnabled = true;
            this.cboGiangVien.Location = new System.Drawing.Point(641, 401);
            this.cboGiangVien.Name = "cboGiangVien";
            this.cboGiangVien.Size = new System.Drawing.Size(233, 27);
            this.cboGiangVien.TabIndex = 34;
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.cboGiangVien);
            this.Controls.Add(this.cboTenKhoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Lop";
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.Lop_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimK;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshK;
        private System.Windows.Forms.Button btnSuaK;
        private System.Windows.Forms.Button btnXoaK;
        private System.Windows.Forms.Button btnThemK;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.ComboBox cboTenKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGV;
        private System.Windows.Forms.ComboBox cboGiangVien;
    }
}