namespace Bai1
{
    partial class GiaiPtBac2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.butGiaiPt = new System.Windows.Forms.Button();
            this.butThoat = new System.Windows.Forms.Button();
            this.txtNghiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "b = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "c = ";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(490, 93);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(233, 30);
            this.txtA.TabIndex = 3;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(490, 184);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(233, 30);
            this.txtC.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(490, 138);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(233, 30);
            this.txtB.TabIndex = 5;
            // 
            // butGiaiPt
            // 
            this.butGiaiPt.Location = new System.Drawing.Point(370, 298);
            this.butGiaiPt.Name = "butGiaiPt";
            this.butGiaiPt.Size = new System.Drawing.Size(160, 37);
            this.butGiaiPt.TabIndex = 6;
            this.butGiaiPt.Text = "Giải phương trình";
            this.butGiaiPt.UseVisualStyleBackColor = true;
            this.butGiaiPt.Click += new System.EventHandler(this.butGiaiPt_Click);
            // 
            // butThoat
            // 
            this.butThoat.Location = new System.Drawing.Point(579, 298);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(144, 37);
            this.butThoat.TabIndex = 7;
            this.butThoat.Text = "Thoát";
            this.butThoat.UseVisualStyleBackColor = true;
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click);
            // 
            // txtNghiem
            // 
            this.txtNghiem.Location = new System.Drawing.Point(490, 228);
            this.txtNghiem.Name = "txtNghiem";
            this.txtNghiem.Size = new System.Drawing.Size(233, 30);
            this.txtNghiem.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nghiệm";
            // 
            // GiaiPtBac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.txtNghiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butThoat);
            this.Controls.Add(this.butGiaiPt);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GiaiPtBac2";
            this.Text = "Giải phương trình bậc 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button butGiaiPt;
        private System.Windows.Forms.Button butThoat;
        private System.Windows.Forms.TextBox txtNghiem;
        private System.Windows.Forms.Label label4;
    }
}