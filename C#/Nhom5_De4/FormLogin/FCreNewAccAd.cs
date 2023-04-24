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
    public partial class FCreNewAccAd : Form
    {
        public FCreNewAccAd()
        {
            InitializeComponent();
        }
        LopDTO gv_DTO = new LopDTO();
        LopBUS gv_BUS = new LopBUS();

        // Tao tai khoan moi voi quyen han cua Admin
        private void btnCreNew_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.TextLength == 0)
                MessageBox.Show("Tài khoản không được bỏ trống!");
            else if (txtMatKhau.TextLength == 0)
                MessageBox.Show("Mật khẩu không được bỏ trống!");
            else if (txtReMatKhau.Text != txtMatKhau.Text)
                MessageBox.Show("Nhập lại mật khẩu không chính xác!");
            else
            {
                try
                {
                    gv_DTO.UserName = txtTaiKhoan.Text;
                    gv_DTO.PassWord = txtMatKhau.Text;
                    if (rdoAdmin.Checked) gv_DTO.QuyenHan = 1;
                    if (rdoNguoiDung.Checked) gv_DTO.QuyenHan = 0;
                    gv_BUS.ThemAcc(gv_DTO.UserName, gv_DTO.PassWord, gv_DTO.QuyenHan);
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

