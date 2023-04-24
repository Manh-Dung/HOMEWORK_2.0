namespace FormLogin
{
    partial class FCreNewAccAd
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
            this.btnCreNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReMatKhau = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.rdoNguoiDung = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCreNew
            // 
            this.btnCreNew.Location = new System.Drawing.Point(308, 213);
            this.btnCreNew.Name = "btnCreNew";
            this.btnCreNew.Size = new System.Drawing.Size(146, 33);
            this.btnCreNew.TabIndex = 11;
            this.btnCreNew.Text = "Tạo tài khoản mới";
            this.btnCreNew.UseVisualStyleBackColor = true;
            this.btnCreNew.Click += new System.EventHandler(this.btnCreNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập tài khoản";
            // 
            // txtReMatKhau
            // 
            this.txtReMatKhau.Location = new System.Drawing.Point(199, 126);
            this.txtReMatKhau.Name = "txtReMatKhau";
            this.txtReMatKhau.Size = new System.Drawing.Size(255, 27);
            this.txtReMatKhau.TabIndex = 10;
            this.txtReMatKhau.UseSystemPasswordChar = true;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(199, 79);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(255, 27);
            this.txtMatKhau.TabIndex = 9;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(199, 35);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(255, 27);
            this.txtTaiKhoan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quyền hạn";
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Location = new System.Drawing.Point(199, 177);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(117, 23);
            this.rdoAdmin.TabIndex = 12;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "Quản trị viên";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // rdoNguoiDung
            // 
            this.rdoNguoiDung.AutoSize = true;
            this.rdoNguoiDung.Location = new System.Drawing.Point(345, 177);
            this.rdoNguoiDung.Name = "rdoNguoiDung";
            this.rdoNguoiDung.Size = new System.Drawing.Size(109, 23);
            this.rdoNguoiDung.TabIndex = 12;
            this.rdoNguoiDung.TabStop = true;
            this.rdoNguoiDung.Text = "Người dùng";
            this.rdoNguoiDung.UseVisualStyleBackColor = true;
            // 
            // FCreNewAccAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 270);
            this.Controls.Add(this.rdoNguoiDung);
            this.Controls.Add(this.rdoAdmin);
            this.Controls.Add(this.btnCreNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FCreNewAccAd";
            this.Text = "FCreNewAccAd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.RadioButton rdoNguoiDung;
    }
}