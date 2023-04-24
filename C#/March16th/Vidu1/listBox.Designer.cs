namespace Vidu1
{
    partial class listBox
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
            this.danhSach = new System.Windows.Forms.ListBox();
            this.sachDaChon = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.themToanBo = new System.Windows.Forms.Button();
            this.xoaDonLe = new System.Windows.Forms.Button();
            this.themDonLe = new System.Windows.Forms.Button();
            this.xoaToanBo = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // danhSach
            // 
            this.danhSach.FormattingEnabled = true;
            this.danhSach.ItemHeight = 20;
            this.danhSach.Location = new System.Drawing.Point(75, 51);
            this.danhSach.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.danhSach.Name = "danhSach";
            this.danhSach.Size = new System.Drawing.Size(379, 464);
            this.danhSach.Sorted = true;
            this.danhSach.TabIndex = 0;
            this.danhSach.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // sachDaChon
            // 
            this.sachDaChon.FormattingEnabled = true;
            this.sachDaChon.ItemHeight = 20;
            this.sachDaChon.Location = new System.Drawing.Point(540, 51);
            this.sachDaChon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sachDaChon.Name = "sachDaChon";
            this.sachDaChon.Size = new System.Drawing.Size(381, 464);
            this.sachDaChon.Sorted = true;
            this.sachDaChon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sách đã chọn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // themToanBo
            // 
            this.themToanBo.Location = new System.Drawing.Point(465, 254);
            this.themToanBo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.themToanBo.Name = "themToanBo";
            this.themToanBo.Size = new System.Drawing.Size(67, 29);
            this.themToanBo.TabIndex = 4;
            this.themToanBo.Text = ">>";
            this.themToanBo.UseVisualStyleBackColor = true;
            this.themToanBo.Click += new System.EventHandler(this.themToanBo_Click);
            // 
            // xoaDonLe
            // 
            this.xoaDonLe.Location = new System.Drawing.Point(465, 291);
            this.xoaDonLe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.xoaDonLe.Name = "xoaDonLe";
            this.xoaDonLe.Size = new System.Drawing.Size(67, 29);
            this.xoaDonLe.TabIndex = 5;
            this.xoaDonLe.Text = "<";
            this.xoaDonLe.UseVisualStyleBackColor = true;
            this.xoaDonLe.Click += new System.EventHandler(this.xoaDonLe_Click);
            // 
            // themDonLe
            // 
            this.themDonLe.Location = new System.Drawing.Point(465, 217);
            this.themDonLe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.themDonLe.Name = "themDonLe";
            this.themDonLe.Size = new System.Drawing.Size(67, 29);
            this.themDonLe.TabIndex = 6;
            this.themDonLe.Text = ">";
            this.themDonLe.UseVisualStyleBackColor = true;
            this.themDonLe.Click += new System.EventHandler(this.themDonLe_Click);
            // 
            // xoaToanBo
            // 
            this.xoaToanBo.Location = new System.Drawing.Point(465, 326);
            this.xoaToanBo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.xoaToanBo.Name = "xoaToanBo";
            this.xoaToanBo.Size = new System.Drawing.Size(67, 29);
            this.xoaToanBo.TabIndex = 7;
            this.xoaToanBo.Text = "<<";
            this.xoaToanBo.UseVisualStyleBackColor = true;
            this.xoaToanBo.Click += new System.EventHandler(this.xoaToanBo_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(885, 525);
            this.thoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(95, 29);
            this.thoat.TabIndex = 8;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // listBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 563);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoaToanBo);
            this.Controls.Add(this.themDonLe);
            this.Controls.Add(this.xoaDonLe);
            this.Controls.Add(this.themToanBo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sachDaChon);
            this.Controls.Add(this.danhSach);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "listBox";
            this.Text = "Danh sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox danhSach;
        private System.Windows.Forms.ListBox sachDaChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button themToanBo;
        private System.Windows.Forms.Button xoaDonLe;
        private System.Windows.Forms.Button themDonLe;
        private System.Windows.Forms.Button xoaToanBo;
        private System.Windows.Forms.Button thoat;
    }
}

