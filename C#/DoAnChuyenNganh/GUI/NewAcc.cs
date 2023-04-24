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
    public partial class NewAcc : Form
    {
        public NewAcc()
        {
            InitializeComponent();
        }
        DTO_Account dto = new DTO_Account();
        BUS_Account bus = new BUS_Account();
        private void txtNewAcc_Click(object sender, EventArgs e)
        {
            if (txtUsername.TextLength == 0)
                MessageBox.Show("Tài khoản không được bỏ trống!");
            else if (txtPassword.TextLength == 0)
                MessageBox.Show("Mật khẩu không được bỏ trống!");
            else if (txtConfPass.Text != txtPassword.Text)
                MessageBox.Show("Mật khẩu không trùng khớp!");
            else
            {
                try
                {
                    dto.UserName = txtUsername.Text;
                    dto.PassWord = txtPassword.Text;
                    bus.AddAcc(dto.UserName, dto.PassWord);
                    MessageBox.Show("Đã thêm thành công");
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
