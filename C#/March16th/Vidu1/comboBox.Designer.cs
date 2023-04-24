namespace Vidu1
{
    partial class comboBox
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
            this.name = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cBoxGen = new System.Windows.Forms.ComboBox();
            this.cBoxDepart = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(159, 47);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 19);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(159, 90);
            this.gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(59, 19);
            this.gender.TabIndex = 1;
            this.gender.Text = "Gender";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Location = new System.Drawing.Point(159, 137);
            this.department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(89, 19);
            this.department.TabIndex = 2;
            this.department.Text = "Department";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(292, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(461, 27);
            this.txtName.TabIndex = 3;
            // 
            // cBoxGen
            // 
            this.cBoxGen.FormattingEnabled = true;
            this.cBoxGen.Location = new System.Drawing.Point(292, 87);
            this.cBoxGen.Name = "cBoxGen";
            this.cBoxGen.Size = new System.Drawing.Size(461, 27);
            this.cBoxGen.Sorted = true;
            this.cBoxGen.TabIndex = 4;
            // 
            // cBoxDepart
            // 
            this.cBoxDepart.FormattingEnabled = true;
            this.cBoxDepart.Location = new System.Drawing.Point(292, 134);
            this.cBoxDepart.Name = "cBoxDepart";
            this.cBoxDepart.Size = new System.Drawing.Size(461, 27);
            this.cBoxDepart.Sorted = true;
            this.cBoxDepart.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(555, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(662, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 19;
            this.lstDanhSach.Location = new System.Drawing.Point(163, 220);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(596, 232);
            this.lstDanhSach.TabIndex = 8;
            // 
            // comboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 535);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cBoxDepart);
            this.Controls.Add(this.cBoxGen);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.department);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "comboBox";
            this.Text = "comboBox";
            this.Load += new System.EventHandler(this.comboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cBoxGen;
        private System.Windows.Forms.ComboBox cBoxDepart;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstDanhSach;
    }
}