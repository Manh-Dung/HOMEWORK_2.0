namespace FormLogin
{
    partial class FMon
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTimM = new System.Windows.Forms.TextBox();
            this.btnTimM = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRefreshM = new System.Windows.Forms.Button();
            this.btnXoaM = new System.Windows.Forms.Button();
            this.btnSuaM = new System.Windows.Forms.Button();
            this.btnThemM = new System.Windows.Forms.Button();
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTenKhoa = new System.Windows.Forms.ComboBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.maMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTimM);
            this.groupBox5.Controls.Add(this.btnTimM);
            this.groupBox5.Location = new System.Drawing.Point(527, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(350, 55);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm";
            // 
            // txtTimM
            // 
            this.txtTimM.Location = new System.Drawing.Point(113, 20);
            this.txtTimM.Name = "txtTimM";
            this.txtTimM.Size = new System.Drawing.Size(231, 27);
            this.txtTimM.TabIndex = 0;
            // 
            // btnTimM
            // 
            this.btnTimM.Location = new System.Drawing.Point(8, 21);
            this.btnTimM.Name = "btnTimM";
            this.btnTimM.Size = new System.Drawing.Size(99, 28);
            this.btnTimM.TabIndex = 6;
            this.btnTimM.Text = "Tìm kiếm";
            this.btnTimM.UseVisualStyleBackColor = true;
            this.btnTimM.Click += new System.EventHandler(this.btnTimM_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnRefreshM);
            this.groupBox6.Controls.Add(this.btnXoaM);
            this.groupBox6.Controls.Add(this.btnSuaM);
            this.groupBox6.Controls.Add(this.btnThemM);
            this.groupBox6.Location = new System.Drawing.Point(23, 34);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(497, 55);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng";
            // 
            // btnRefreshM
            // 
            this.btnRefreshM.Location = new System.Drawing.Point(374, 21);
            this.btnRefreshM.Name = "btnRefreshM";
            this.btnRefreshM.Size = new System.Drawing.Size(117, 28);
            this.btnRefreshM.TabIndex = 2;
            this.btnRefreshM.Text = "Refresh";
            this.btnRefreshM.UseVisualStyleBackColor = true;
            this.btnRefreshM.Click += new System.EventHandler(this.btnRefreshM_Click);
            // 
            // btnXoaM
            // 
            this.btnXoaM.Location = new System.Drawing.Point(127, 21);
            this.btnXoaM.Name = "btnXoaM";
            this.btnXoaM.Size = new System.Drawing.Size(117, 28);
            this.btnXoaM.TabIndex = 4;
            this.btnXoaM.Text = "Xóa";
            this.btnXoaM.UseVisualStyleBackColor = true;
            this.btnXoaM.Click += new System.EventHandler(this.btnXoaM_Click);
            // 
            // btnSuaM
            // 
            this.btnSuaM.Location = new System.Drawing.Point(251, 21);
            this.btnSuaM.Name = "btnSuaM";
            this.btnSuaM.Size = new System.Drawing.Size(117, 28);
            this.btnSuaM.TabIndex = 3;
            this.btnSuaM.Text = "Sửa";
            this.btnSuaM.UseVisualStyleBackColor = true;
            this.btnSuaM.Click += new System.EventHandler(this.btnSuaM_Click);
            // 
            // btnThemM
            // 
            this.btnThemM.Location = new System.Drawing.Point(4, 21);
            this.btnThemM.Name = "btnThemM";
            this.btnThemM.Size = new System.Drawing.Size(117, 28);
            this.btnThemM.TabIndex = 5;
            this.btnThemM.Text = "Thêm";
            this.btnThemM.UseVisualStyleBackColor = true;
            this.btnThemM.Click += new System.EventHandler(this.btnThemM_Click);
            // 
            // dgvMon
            // 
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonHoc,
            this.tenMonHoc,
            this.maKhoa});
            this.dgvMon.Location = new System.Drawing.Point(23, 95);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.RowHeadersWidth = 51;
            this.dgvMon.RowTemplate.Height = 24;
            this.dgvMon.Size = new System.Drawing.Size(497, 406);
            this.dgvMon.TabIndex = 15;
            this.dgvMon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMon_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Khoa";
            // 
            // cboTenKhoa
            // 
            this.cboTenKhoa.FormattingEnabled = true;
            this.cboTenKhoa.Location = new System.Drawing.Point(640, 190);
            this.cboTenKhoa.Name = "cboTenKhoa";
            this.cboTenKhoa.Size = new System.Drawing.Size(231, 27);
            this.cboTenKhoa.TabIndex = 19;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(640, 123);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(231, 27);
            this.txtMaMH.TabIndex = 0;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(640, 156);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(231, 27);
            this.txtTenMH.TabIndex = 0;
            // 
            // maMonHoc
            // 
            this.maMonHoc.DataPropertyName = "maMonHoc";
            this.maMonHoc.HeaderText = "Mã MH";
            this.maMonHoc.MinimumWidth = 6;
            this.maMonHoc.Name = "maMonHoc";
            // 
            // tenMonHoc
            // 
            this.tenMonHoc.DataPropertyName = "tenMonHoc";
            this.tenMonHoc.HeaderText = "Tên môn học";
            this.tenMonHoc.MinimumWidth = 6;
            this.tenMonHoc.Name = "tenMonHoc";
            this.tenMonHoc.Width = 200;
            // 
            // maKhoa
            // 
            this.maKhoa.DataPropertyName = "maKhoa";
            this.maKhoa.HeaderText = "Mã khoa";
            this.maKhoa.MinimumWidth = 6;
            this.maKhoa.Name = "maKhoa";
            this.maKhoa.Width = 140;
            // 
            // FMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.cboTenKhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dgvMon);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FMon";
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.FMon_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTimM;
        private System.Windows.Forms.Button btnTimM;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRefreshM;
        private System.Windows.Forms.Button btnXoaM;
        private System.Windows.Forms.Button btnSuaM;
        private System.Windows.Forms.Button btnThemM;
        private System.Windows.Forms.DataGridView dgvMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTenKhoa;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoa;
    }
}