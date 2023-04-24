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
    public partial class Login : Form
    {
        public Login()
        {
            
            InitializeComponent();
        }
        DTO_Account dto = new DTO_Account();
        BUS_Account bus = new BUS_Account();

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình không?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                dto.UserName = txtUserName.Text;
                dto.PassWord = txtPassword.Text;

                if (bus.PermissionCheck(dto.UserName, dto.PassWord) == 0)
                {
                    Main f = new Main();
                    MessageBox.Show("Đăng nhập tài khoản User thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (bus.PermissionCheck(dto.UserName, dto.PassWord) == 1)
                {
                    Main f = new Main();
                    MessageBox.Show("Đăng nhập tài khoản Admin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    f.addAcc.Enabled = true;
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(("Lỗi kết lối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error) + ex.Message);
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
