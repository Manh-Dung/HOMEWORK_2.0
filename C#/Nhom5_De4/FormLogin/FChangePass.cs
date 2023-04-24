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

namespace FormLogin
{
    public partial class FChangePass : Form
    {
        public FChangePass()
        {
            InitializeComponent();
        }

        LopDTO gv_DTO = new LopDTO();
        LopBUS gv_BUS = new LopBUS();

        // Thay doi mat khau
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.TextLength == 0)
                MessageBox.Show("Tài khoản không được bỏ trống!");
            else if (txtOldPass.TextLength == 0)
            {
                MessageBox.Show("Mật khẩu cũ không được bỏ trống!");
            }
            else if (txtNewPass.Text == txtOldPass.Text)
                MessageBox.Show("Mật khẩu mới không được giống mật khẩu cũ!");
            else
            {
                try
                {
                    gv_DTO.UserName = txtTaiKhoan.Text;
                    gv_DTO.PassWord = txtOldPass.Text;
                    gv_DTO.NewPass = txtNewPass.Text;
                    if (gv_BUS.CheckAccount(gv_DTO.UserName, gv_DTO.PassWord) == true)
                    {
                        gv_BUS.SuaMK(gv_DTO.UserName, gv_DTO.PassWord, gv_DTO.NewPass);
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
