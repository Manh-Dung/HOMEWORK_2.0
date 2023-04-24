﻿namespace GUI
{
    partial class Restaurant
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
            this.cboDiemDen = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maNhaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoaiNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDiemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDiemDen
            // 
            this.cboDiemDen.FormattingEnabled = true;
            this.cboDiemDen.Location = new System.Drawing.Point(462, 120);
            this.cboDiemDen.Name = "cboDiemDen";
            this.cboDiemDen.Size = new System.Drawing.Size(375, 27);
            this.cboDiemDen.TabIndex = 55;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhaHang,
            this.tenKhachSan,
            this.diaChiNH,
            this.dienThoaiNH,
            this.emailNH,
            this.ghiChuNH,
            this.maDiemDen});
            this.dgv.Location = new System.Drawing.Point(12, 294);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(876, 231);
            this.dgv.TabIndex = 70;
            this.dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowEnter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(623, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 30);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(733, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 30);
            this.btnExit.TabIndex = 59;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(623, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 30);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(733, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 30);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(462, 54);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(375, 27);
            this.txtTen.TabIndex = 53;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(153, 153);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(684, 66);
            this.txtGhiChu.TabIndex = 54;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(462, 87);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(375, 27);
            this.txtDienThoai.TabIndex = 52;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(155, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 27);
            this.txtEmail.TabIndex = 51;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(155, 87);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(192, 27);
            this.txtDiaChi.TabIndex = 49;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(155, 54);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(192, 27);
            this.txtMa.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 61;
            this.label4.Text = "Nhà hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(433, 19);
            this.label8.TabIndex = 62;
            this.label8.Text = "> Để sửa, Click vào ô cần sửa rồi sửa sau đó nhấn phím Update";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 67;
            this.label10.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 19);
            this.label7.TabIndex = 63;
            this.label7.Text = "> Để xóa, chọn dòng muốn xóa rồi ấn phím Delete";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 68;
            this.label9.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 64;
            this.label6.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 69;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 65;
            this.label3.Text = "Điểm đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Mã nhà hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 60;
            this.label1.Text = "Danh mục nhà hàng";
            // 
            // maNhaHang
            // 
            this.maNhaHang.DataPropertyName = "maNhaHang";
            this.maNhaHang.HeaderText = "Mã nhà hàng";
            this.maNhaHang.MinimumWidth = 6;
            this.maNhaHang.Name = "maNhaHang";
            // 
            // tenKhachSan
            // 
            this.tenKhachSan.DataPropertyName = "tenNhaHang";
            this.tenKhachSan.HeaderText = "Nhà hàng";
            this.tenKhachSan.MinimumWidth = 6;
            this.tenKhachSan.Name = "tenKhachSan";
            // 
            // diaChiNH
            // 
            this.diaChiNH.DataPropertyName = "diaChiNH";
            this.diaChiNH.HeaderText = "Địa chỉ";
            this.diaChiNH.MinimumWidth = 6;
            this.diaChiNH.Name = "diaChiNH";
            // 
            // dienThoaiNH
            // 
            this.dienThoaiNH.DataPropertyName = "dienThoaiNH";
            this.dienThoaiNH.HeaderText = "Điện thoại";
            this.dienThoaiNH.MinimumWidth = 6;
            this.dienThoaiNH.Name = "dienThoaiNH";
            // 
            // emailNH
            // 
            this.emailNH.DataPropertyName = "emailNH";
            this.emailNH.HeaderText = "Email";
            this.emailNH.MinimumWidth = 6;
            this.emailNH.Name = "emailNH";
            // 
            // ghiChuNH
            // 
            this.ghiChuNH.DataPropertyName = "ghiChuNH";
            this.ghiChuNH.HeaderText = "Ghi chú";
            this.ghiChuNH.MinimumWidth = 6;
            this.ghiChuNH.Name = "ghiChuNH";
            // 
            // maDiemDen
            // 
            this.maDiemDen.DataPropertyName = "maDiemDen";
            this.maDiemDen.HeaderText = "Mã điểm đến";
            this.maDiemDen.MinimumWidth = 6;
            this.maDiemDen.Name = "maDiemDen";
            // 
            // Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.cboDiemDen);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Restaurant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà hàng";
            this.Load += new System.EventHandler(this.Restaurant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDiemDen;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDiemDen;
    }
}