namespace GUI
{
    partial class Sight
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.maDiemThamQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDiemThamQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDTQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDiemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDiemDen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDiemThamQuan,
            this.tenDiemThamQuan,
            this.ghiChuDTQ,
            this.maDiemDen});
            this.dgv.Location = new System.Drawing.Point(12, 196);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(876, 329);
            this.dgv.TabIndex = 32;
            this.dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowEnter);
            // 
            // maDiemThamQuan
            // 
            this.maDiemThamQuan.DataPropertyName = "maDiemThamQuan";
            this.maDiemThamQuan.HeaderText = "Mã điểm tham quan";
            this.maDiemThamQuan.MinimumWidth = 6;
            this.maDiemThamQuan.Name = "maDiemThamQuan";
            // 
            // tenDiemThamQuan
            // 
            this.tenDiemThamQuan.DataPropertyName = "tenDiemThamQuan";
            this.tenDiemThamQuan.HeaderText = "Điểm tham quan";
            this.tenDiemThamQuan.MinimumWidth = 6;
            this.tenDiemThamQuan.Name = "tenDiemThamQuan";
            // 
            // ghiChuDTQ
            // 
            this.ghiChuDTQ.DataPropertyName = "ghiChuDTQ";
            this.ghiChuDTQ.HeaderText = "Ghi chú";
            this.ghiChuDTQ.MinimumWidth = 6;
            this.ghiChuDTQ.Name = "ghiChuDTQ";
            // 
            // maDiemDen
            // 
            this.maDiemDen.DataPropertyName = "maDiemDen";
            this.maDiemDen.HeaderText = "Mã điểm đến";
            this.maDiemDen.MinimumWidth = 6;
            this.maDiemDen.Name = "maDiemDen";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(623, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(733, 160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(623, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(733, 130);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(504, 54);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(333, 27);
            this.txtTen.TabIndex = 1;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(197, 87);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(149, 27);
            this.txtGhiChu.TabIndex = 2;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(197, 54);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(149, 27);
            this.txtMa.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tên điểm tham quan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(433, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "> Để sửa, Click vào ô cần sửa rồi sửa sau đó nhấn phím Update";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "> Để xóa, chọn dòng muốn xóa rồi ấn phím Delete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã điểm tham quan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Danh mục điểm tham quan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Điểm đến";
            // 
            // cboDiemDen
            // 
            this.cboDiemDen.FormattingEnabled = true;
            this.cboDiemDen.Location = new System.Drawing.Point(504, 90);
            this.cboDiemDen.Name = "cboDiemDen";
            this.cboDiemDen.Size = new System.Drawing.Size(333, 27);
            this.cboDiemDen.TabIndex = 3;
            // 
            // Sight
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
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm tham quan";
            this.Load += new System.EventHandler(this.Sight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDiemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDiemThamQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDiemThamQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDTQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDiemDen;
    }
}