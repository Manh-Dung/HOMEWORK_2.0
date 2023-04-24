namespace FormLogin
{
    partial class FLop
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
            this.cboTenKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimL = new System.Windows.Forms.Button();
            this.txtTimL = new System.Windows.Forms.TextBox();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRefreshL = new System.Windows.Forms.Button();
            this.btnSuaL = new System.Windows.Forms.Button();
            this.btnXoaL = new System.Windows.Forms.Button();
            this.btnThemL = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.maLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTenKhoa
            // 
            this.cboTenKhoa.FormattingEnabled = true;
            this.cboTenKhoa.Location = new System.Drawing.Point(638, 251);
            this.cboTenKhoa.Name = "cboTenKhoa";
            this.cboTenKhoa.Size = new System.Drawing.Size(233, 27);
            this.cboTenKhoa.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sĩ số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã lớp";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTimL);
            this.groupBox3.Controls.Add(this.txtTimL);
            this.groupBox3.Location = new System.Drawing.Point(527, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 55);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btnTimL
            // 
            this.btnTimL.Location = new System.Drawing.Point(6, 20);
            this.btnTimL.Name = "btnTimL";
            this.btnTimL.Size = new System.Drawing.Size(99, 28);
            this.btnTimL.TabIndex = 7;
            this.btnTimL.Text = "Tìm kiếm";
            this.btnTimL.UseVisualStyleBackColor = true;
            this.btnTimL.Click += new System.EventHandler(this.btnTimL_Click_1);
            // 
            // txtTimL
            // 
            this.txtTimL.Location = new System.Drawing.Point(111, 20);
            this.txtTimL.Name = "txtTimL";
            this.txtTimL.Size = new System.Drawing.Size(233, 27);
            this.txtTimL.TabIndex = 0;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(638, 205);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(233, 27);
            this.txtSiSo.TabIndex = 13;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(638, 161);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(233, 27);
            this.txtTenLop.TabIndex = 14;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(638, 118);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(233, 27);
            this.txtMaLop.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRefreshL);
            this.groupBox4.Controls.Add(this.btnSuaL);
            this.groupBox4.Controls.Add(this.btnXoaL);
            this.groupBox4.Controls.Add(this.btnThemL);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Location = new System.Drawing.Point(23, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(497, 55);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnRefreshL
            // 
            this.btnRefreshL.Location = new System.Drawing.Point(374, 20);
            this.btnRefreshL.Name = "btnRefreshL";
            this.btnRefreshL.Size = new System.Drawing.Size(117, 28);
            this.btnRefreshL.TabIndex = 2;
            this.btnRefreshL.Text = "Refresh";
            this.btnRefreshL.UseVisualStyleBackColor = true;
            this.btnRefreshL.Click += new System.EventHandler(this.btnRefreshL_Click_1);
            // 
            // btnSuaL
            // 
            this.btnSuaL.Location = new System.Drawing.Point(251, 20);
            this.btnSuaL.Name = "btnSuaL";
            this.btnSuaL.Size = new System.Drawing.Size(117, 28);
            this.btnSuaL.TabIndex = 3;
            this.btnSuaL.Text = "Sửa";
            this.btnSuaL.UseVisualStyleBackColor = true;
            this.btnSuaL.Click += new System.EventHandler(this.btnSuaL_Click_1);
            // 
            // btnXoaL
            // 
            this.btnXoaL.Location = new System.Drawing.Point(127, 20);
            this.btnXoaL.Name = "btnXoaL";
            this.btnXoaL.Size = new System.Drawing.Size(117, 28);
            this.btnXoaL.TabIndex = 4;
            this.btnXoaL.Text = "Xóa";
            this.btnXoaL.UseVisualStyleBackColor = true;
            this.btnXoaL.Click += new System.EventHandler(this.btnXoaL_Click_1);
            // 
            // btnThemL
            // 
            this.btnThemL.Location = new System.Drawing.Point(4, 20);
            this.btnThemL.Name = "btnThemL";
            this.btnThemL.Size = new System.Drawing.Size(117, 28);
            this.btnThemL.TabIndex = 0;
            this.btnThemL.Text = "Thêm";
            this.btnThemL.UseVisualStyleBackColor = true;
            this.btnThemL.Click += new System.EventHandler(this.btnThemL_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 28);
            this.button5.TabIndex = 6;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLop,
            this.tenLop,
            this.siSo,
            this.maKhoa});
            this.dgvLop.Location = new System.Drawing.Point(23, 95);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(497, 406);
            this.dgvLop.TabIndex = 16;
            this.dgvLop.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_RowEnter_1);
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
            // siSo
            // 
            this.siSo.DataPropertyName = "siSo";
            this.siSo.HeaderText = "Sĩ số";
            this.siSo.MinimumWidth = 6;
            this.siSo.Name = "siSo";
            this.siSo.Width = 60;
            // 
            // maKhoa
            // 
            this.maKhoa.DataPropertyName = "maKhoa";
            this.maKhoa.HeaderText = "Mã khoa";
            this.maKhoa.MinimumWidth = 6;
            this.maKhoa.Name = "maKhoa";
            this.maKhoa.Width = 80;
            // 
            // FLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.cboTenKhoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtSiSo);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvLop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FLop";
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.FLop_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTenKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTimL;
        private System.Windows.Forms.TextBox txtTimL;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRefreshL;
        private System.Windows.Forms.Button btnSuaL;
        private System.Windows.Forms.Button btnXoaL;
        private System.Windows.Forms.Button btnThemL;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoa;
    }
}