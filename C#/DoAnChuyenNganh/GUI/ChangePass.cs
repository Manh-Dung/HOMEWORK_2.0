using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using DAL;

namespace GUI
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }
        DTO_Account dto = new DTO_Account();
        BUS_Account bus = new BUS_Account();

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtUsername.TextLength == 0)
                MessageBox.Show("Tài khoản không được bỏ trống!");
            else if (txtPassword.TextLength == 0)
            {
                MessageBox.Show("Mật khẩu cũ không được bỏ trống!");
            }
            else if (txtNewPass.Text == txtPassword.Text)
                MessageBox.Show("Mật khẩu mới không được giống mật khẩu cũ!");
            else
            {
                try
                {
                    dto.UserName = txtUsername.Text;
                    dto.PassWord = txtPassword.Text;
                    dto.NewPassword = txtNewPass.Text;
                    if (bus.PassCheck(dto.UserName, dto.PassWord) == true)
                    {
                        bus.UpdatePass(dto.UserName, dto.PassWord, dto.NewPassword);
                        MessageBox.Show("Đã thay đổi mật khẩu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu hoặc tài khoản!");
                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
