namespace GUI
{
    partial class GiangVien
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimK = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshK = new System.Windows.Forms.Button();
            this.btnSuaK = new System.Windows.Forms.Button();
            this.btnXoaK = new System.Windows.Forms.Button();
            this.btnThemK = new System.Windows.Forms.Button();
            this.dgvGV = new System.Windows.Forms.DataGridView();
            this.maGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDTGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSDTGV = new System.Windows.Forms.TextBox();
            this.txtEmailGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên giảng viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã giảng viên";
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
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(128, 417);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(231, 27);
            this.txtTenGV.TabIndex = 19;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(128, 382);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(231, 27);
            this.txtMaGV.TabIndex = 20;
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
            // dgvGV
            // 
            this.dgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGV,
            this.tenGV,
            this.soDTGV,
            this.emailGV});
            this.dgvGV.Location = new System.Drawing.Point(12, 12);
            this.dgvGV.Name = "dgvGV";
            this.dgvGV.RowHeadersWidth = 51;
            this.dgvGV.RowTemplate.Height = 24;
            this.dgvGV.Size = new System.Drawing.Size(868, 293);
            this.dgvGV.TabIndex = 21;
            this.dgvGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGV_RowEnter);
            // 
            // maGV
            // 
            this.maGV.DataPropertyName = "maGV";
            this.maGV.HeaderText = "Mã giảng viên";
            this.maGV.MinimumWidth = 6;
            this.maGV.Name = "maGV";
            this.maGV.Width = 200;
            // 
            // tenGV
            // 
            this.tenGV.DataPropertyName = "tenGV";
            this.tenGV.HeaderText = "Tên giảng viên";
            this.tenGV.MinimumWidth = 6;
            this.tenGV.Name = "tenGV";
            this.tenGV.Width = 300;
            // 
            // soDTGV
            // 
            this.soDTGV.DataPropertyName = "soDTGV";
            this.soDTGV.HeaderText = "Số điện thoại";
            this.soDTGV.MinimumWidth = 6;
            this.soDTGV.Name = "soDTGV";
            this.soDTGV.Width = 125;
            // 
            // emailGV
            // 
            this.emailGV.DataPropertyName = "emailGV";
            this.emailGV.HeaderText = "Email";
            this.emailGV.MinimumWidth = 6;
            this.emailGV.Name = "emailGV";
            this.emailGV.Width = 125;
            // 
            // txtSDTGV
            // 
            this.txtSDTGV.Location = new System.Drawing.Point(649, 382);
            this.txtSDTGV.Name = "txtSDTGV";
            this.txtSDTGV.Size = new System.Drawing.Size(231, 27);
            this.txtSDTGV.TabIndex = 20;
            // 
            // txtEmailGV
            // 
            this.txtEmailGV.Location = new System.Drawing.Point(649, 417);
            this.txtEmailGV.Name = "txtEmailGV";
            this.txtEmailGV.Size = new System.Drawing.Size(231, 27);
            this.txtEmailGV.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email";
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtEmailGV);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.txtSDTGV);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGV);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GiangVien";
            this.Text = "GiangVien";
            this.Load += new System.EventHandler(this.GiangVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimK;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshK;
        private System.Windows.Forms.Button btnSuaK;
        private System.Windows.Forms.Button btnXoaK;
        private System.Windows.Forms.Button btnThemK;
        private System.Windows.Forms.DataGridView dgvGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDTGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailGV;
        private System.Windows.Forms.TextBox txtSDTGV;
        private System.Windows.Forms.TextBox txtEmailGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}