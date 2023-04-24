namespace Vidu1
{
    partial class radioButton
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoDaKetHon = new System.Windows.Forms.RadioButton();
            this.rdoChuaKetHon = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.chkBongDa = new System.Windows.Forms.CheckBox();
            this.chkBoiLoi = new System.Windows.Forms.CheckBox();
            this.chkAmNhac = new System.Windows.Forms.CheckBox();
            this.chkLeoNui = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkLeoNui);
            this.panel1.Controls.Add(this.chkAmNhac);
            this.panel1.Controls.Add(this.chkBoiLoi);
            this.panel1.Controls.Add(this.chkBongDa);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lstDanhSach);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 437);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoDaKetHon);
            this.groupBox2.Controls.Add(this.rdoChuaKetHon);
            this.groupBox2.Location = new System.Drawing.Point(39, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 95);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tình trạng hôn nhân";
            // 
            // rdoDaKetHon
            // 
            this.rdoDaKetHon.AutoSize = true;
            this.rdoDaKetHon.Location = new System.Drawing.Point(7, 56);
            this.rdoDaKetHon.Name = "rdoDaKetHon";
            this.rdoDaKetHon.Size = new System.Drawing.Size(103, 23);
            this.rdoDaKetHon.TabIndex = 3;
            this.rdoDaKetHon.TabStop = true;
            this.rdoDaKetHon.Text = "Đã kết hôn";
            this.rdoDaKetHon.UseVisualStyleBackColor = true;
            // 
            // rdoChuaKetHon
            // 
            this.rdoChuaKetHon.AutoSize = true;
            this.rdoChuaKetHon.Location = new System.Drawing.Point(7, 26);
            this.rdoChuaKetHon.Name = "rdoChuaKetHon";
            this.rdoChuaKetHon.Size = new System.Drawing.Size(119, 23);
            this.rdoChuaKetHon.TabIndex = 2;
            this.rdoChuaKetHon.TabStop = true;
            this.rdoChuaKetHon.Text = "Chưa kết hôn";
            this.rdoChuaKetHon.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNu);
            this.groupBox1.Controls.Add(this.rdoNam);
            this.groupBox1.Location = new System.Drawing.Point(39, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(7, 57);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(51, 23);
            this.rdoNu.TabIndex = 1;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(7, 27);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(62, 23);
            this.rdoNam.TabIndex = 0;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 19;
            this.lstDanhSach.Location = new System.Drawing.Point(303, 37);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(461, 365);
            this.lstDanhSach.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 27);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(618, 487);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 35);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(728, 487);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 35);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // chkBongDa
            // 
            this.chkBongDa.AutoSize = true;
            this.chkBongDa.Location = new System.Drawing.Point(46, 290);
            this.chkBongDa.Name = "chkBongDa";
            this.chkBongDa.Size = new System.Drawing.Size(87, 23);
            this.chkBongDa.TabIndex = 5;
            this.chkBongDa.Text = "Bóng đá";
            this.chkBongDa.UseVisualStyleBackColor = true;
            // 
            // chkBoiLoi
            // 
            this.chkBoiLoi.AutoSize = true;
            this.chkBoiLoi.Location = new System.Drawing.Point(46, 319);
            this.chkBoiLoi.Name = "chkBoiLoi";
            this.chkBoiLoi.Size = new System.Drawing.Size(79, 23);
            this.chkBoiLoi.TabIndex = 6;
            this.chkBoiLoi.Text = "Bơi lội";
            this.chkBoiLoi.UseVisualStyleBackColor = true;
            // 
            // chkAmNhac
            // 
            this.chkAmNhac.AutoSize = true;
            this.chkAmNhac.Location = new System.Drawing.Point(46, 350);
            this.chkAmNhac.Name = "chkAmNhac";
            this.chkAmNhac.Size = new System.Drawing.Size(90, 23);
            this.chkAmNhac.TabIndex = 7;
            this.chkAmNhac.Text = "Âm nhạc";
            this.chkAmNhac.UseVisualStyleBackColor = true;
            // 
            // chkLeoNui
            // 
            this.chkLeoNui.AutoSize = true;
            this.chkLeoNui.Location = new System.Drawing.Point(46, 379);
            this.chkLeoNui.Name = "chkLeoNui";
            this.chkLeoNui.Size = new System.Drawing.Size(83, 23);
            this.chkLeoNui.TabIndex = 8;
            this.chkLeoNui.Text = "Leo núi";
            this.chkLeoNui.UseVisualStyleBackColor = true;
            // 
            // radioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "radioButton";
            this.Text = "checkBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoDaKetHon;
        private System.Windows.Forms.RadioButton rdoChuaKetHon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox chkLeoNui;
        private System.Windows.Forms.CheckBox chkAmNhac;
        private System.Windows.Forms.CheckBox chkBoiLoi;
        private System.Windows.Forms.CheckBox chkBongDa;
    }
}