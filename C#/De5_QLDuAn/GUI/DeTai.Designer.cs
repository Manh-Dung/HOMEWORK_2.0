namespace GUI
{
    partial class DeTai
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
            this.txtTimK = new System.Windows.Forms.TextBox();
            this.txtTenDT = new System.Windows.Forms.TextBox();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshK = new System.Windows.Forms.Button();
            this.btnSuaK = new System.Windows.Forms.Button();
            this.btnXoaK = new System.Windows.Forms.Button();
            this.btnThemK = new System.Windows.Forms.Button();
            this.dgvDeTai = new System.Windows.Forms.DataGridView();
            this.maDeTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDeTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeTai)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên đề tài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã đề tài";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimK);
            this.groupBox2.Controls.Add(this.txtTimK);
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
            // txtTimK
            // 
            this.txtTimK.Location = new System.Drawing.Point(113, 20);
            this.txtTimK.Name = "txtTimK";
            this.txtTimK.Size = new System.Drawing.Size(231, 27);
            this.txtTimK.TabIndex = 0;
            // 
            // txtTenDT
            // 
            this.txtTenDT.Location = new System.Drawing.Point(120, 417);
            this.txtTenDT.Name = "txtTenDT";
            this.txtTenDT.Size = new System.Drawing.Size(231, 27);
            this.txtTenDT.TabIndex = 19;
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(120, 382);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.Size = new System.Drawing.Size(231, 27);
            this.txtMaDT.TabIndex = 20;
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
            // dgvDeTai
            // 
            this.dgvDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeTai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDeTai,
            this.tenDeTai});
            this.dgvDeTai.Location = new System.Drawing.Point(12, 12);
            this.dgvDeTai.Name = "dgvDeTai";
            this.dgvDeTai.RowHeadersWidth = 51;
            this.dgvDeTai.RowTemplate.Height = 24;
            this.dgvDeTai.Size = new System.Drawing.Size(868, 293);
            this.dgvDeTai.TabIndex = 21;
            this.dgvDeTai.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeTai_RowEnter);
            // 
            // maDeTai
            // 
            this.maDeTai.DataPropertyName = "maDeTai";
            this.maDeTai.HeaderText = "Mã đề tài";
            this.maDeTai.MinimumWidth = 6;
            this.maDeTai.Name = "maDeTai";
            this.maDeTai.Width = 200;
            // 
            // tenDeTai
            // 
            this.tenDeTai.DataPropertyName = "tenDeTai";
            this.tenDeTai.HeaderText = "Tên đề tài";
            this.tenDeTai.MinimumWidth = 6;
            this.tenDeTai.Name = "tenDeTai";
            this.tenDeTai.Width = 300;
            // 
            // DeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTenDT);
            this.Controls.Add(this.txtMaDT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDeTai);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeTai";
            this.Text = "Đề tài";
            this.Load += new System.EventHandler(this.DeTai_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeTai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimK;
        private System.Windows.Forms.TextBox txtTimK;
        private System.Windows.Forms.TextBox txtTenDT;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshK;
        private System.Windows.Forms.Button btnSuaK;
        private System.Windows.Forms.Button btnXoaK;
        private System.Windows.Forms.Button btnThemK;
        private System.Windows.Forms.DataGridView dgvDeTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDeTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDeTai;
    }
}