using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using BUS;
using DTO;
using DAL;

namespace GUI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        DTO_Class dto = new DTO_Class();
        BUS_Class bus = new BUS_Class();

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình không?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                dto.Username = txtUserName.Text;
                dto.Password = txtPassword.Text;

                if (bus.PermissionCheck(dto.Username, dto.Password) == 0)
                {
                    Main f = new Main();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (bus.PermissionCheck(dto.Username, dto.Password) == 1)
                {
                    Main f = new Main();
                    this.Hide();
                    f.themTK.Enabled = true;
                    f.quanLy.Enabled = true;
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!" + ex.Message);
            }
        }

        

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            NewAcc f = new NewAcc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void cbShowAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowAcc.Checked == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }
    }
}
