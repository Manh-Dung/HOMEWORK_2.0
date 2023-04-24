namespace GUI
{
    partial class AdNewAcc
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permission = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rdoUser = new System.Windows.Forms.RadioButton();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.btnDelAcc = new System.Windows.Forms.Button();
            this.btnNewAcc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(22, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "*";
            // 
            // dgvAccount
            // 
            this.dgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.passWord,
            this.permission});
            this.dgvAccount.Location = new System.Drawing.Point(477, 23);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(398, 273);
            this.dgvAccount.TabIndex = 36;
            this.dgvAccount.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_RowEnter);
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "Tài khoản";
            this.userName.MinimumWidth = 6;
            this.userName.Name = "userName";
            this.userName.Width = 125;
            // 
            // passWord
            // 
            this.passWord.DataPropertyName = "passWord";
            this.passWord.HeaderText = "Mật khẩu";
            this.passWord.MinimumWidth = 6;
            this.passWord.Name = "passWord";
            this.passWord.Width = 125;
            // 
            // permission
            // 
            this.permission.DataPropertyName = "permission";
            this.permission.HeaderText = "Quyền hạn";
            this.permission.MinimumWidth = 6;
            this.permission.Name = "permission";
            this.permission.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.permission.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.permission.Width = 125;
            // 
            // rdoUser
            // 
            this.rdoUser.AutoSize = true;
            this.rdoUser.Location = new System.Drawing.Point(338, 192);
            this.rdoUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoUser.Name = "rdoUser";
            this.rdoUser.Size = new System.Drawing.Size(109, 23);
            this.rdoUser.TabIndex = 4;
            this.rdoUser.TabStop = true;
            this.rdoUser.Text = "Người dùng";
            this.rdoUser.UseVisualStyleBackColor = true;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Location = new System.Drawing.Point(173, 192);
            this.rdoAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(117, 23);
            this.rdoAdmin.TabIndex = 3;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "Quản trị viên";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // btnDelAcc
            // 
            this.btnDelAcc.Location = new System.Drawing.Point(316, 267);
            this.btnDelAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelAcc.Name = "btnDelAcc";
            this.btnDelAcc.Size = new System.Drawing.Size(143, 29);
            this.btnDelAcc.TabIndex = 6;
            this.btnDelAcc.Text = "Xóa tài khoản";
            this.btnDelAcc.UseVisualStyleBackColor = true;
            this.btnDelAcc.Click += new System.EventHandler(this.btnDelAcc_Click);
            // 
            // btnNewAcc
            // 
            this.btnNewAcc.Location = new System.Drawing.Point(171, 267);
            this.btnNewAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewAcc.Name = "btnNewAcc";
            this.btnNewAcc.Size = new System.Drawing.Size(139, 29);
            this.btnNewAcc.TabIndex = 5;
            this.btnNewAcc.Text = "Tạo tài khoản mới";
            this.btnNewAcc.UseVisualStyleBackColor = true;
            this.btnNewAcc.Click += new System.EventHandler(this.btnNewAcc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Quyền hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nhập mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nhập tài khoản";
            // 
            // txtConfPass
            // 
            this.txtConfPass.Location = new System.Drawing.Point(173, 132);
            this.txtConfPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.Size = new System.Drawing.Size(286, 27);
            this.txtConfPass.TabIndex = 2;
            this.txtConfPass.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(173, 76);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(286, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(173, 23);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(286, 27);
            this.txtUsername.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(36, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Checked: Admin";
            // 
            // AdNewAcc
            // 
            this.AcceptButton = this.btnNewAcc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 323);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.rdoUser);
            this.Controls.Add(this.rdoAdmin);
            this.Controls.Add(this.btnDelAcc);
            this.Controls.Add(this.btnNewAcc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdNewAcc";
            this.Text = "Thêm tài khoản";
            this.Load += new System.EventHandler(this.AdNewAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.RadioButton rdoUser;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.Button btnDelAcc;
        private System.Windows.Forms.Button btnNewAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWord;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permission;
        private System.Windows.Forms.Label label7;
    }
}