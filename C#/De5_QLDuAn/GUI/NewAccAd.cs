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
    public partial class NewAccAd : Form
    {
        public NewAccAd()
        {
            InitializeComponent();
        }
        DTO_Class dto = new DTO_Class();
        BUS_Class bus = new BUS_Class();

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            if (txtUsername.TextLength == 0)
                MessageBox.Show("Tài khoản không được bỏ trống!");
            else if (txtPassword.TextLength == 0)
                MessageBox.Show("Mật khẩu không được bỏ trống!");
            else if (txtRePass.Text != txtPassword.Text)
                MessageBox.Show("Nhập lại mật khẩu không chính xác!");
            else
            {
                try
                {
                    dto.Username = txtUsername.Text;
                    dto.Password = txtPassword.Text;
                    if (rdoAdmin.Checked) dto.Permission = 1;
                    if (rdoUser.Checked) dto.Permission = 0;
                    bus.AddAcc(dto.Username, dto.Password, dto.Permission);
                    MessageBox.Show("Đã thêm thành công");
                    NewAccAd_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void NewAccAd_Load(object sender, EventArgs e)
        {
            dgvAccount.DataSource = bus.ShowAcc();
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            if (txtUsername.TextLength == 0)
                MessageBox.Show("Bạn cần chọn tài khoản để xóa");
            else
            {
                dto.Username = txtUsername.Text;
                dto.Password = txtPassword.Text;
                bus.DelAcc(dto.Username, dto.Password);
            }
            MessageBox.Show("Đã xóa thành công!");
            NewAccAd_Load(sender, e);
        }

        private void dgvAccount_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtUsername.Text = dgvAccount.Rows[dong].Cells[0].Value.ToString();
            txtPassword.Text = dgvAccount.Rows[dong].Cells[1].Value.ToString();
        }
    }
}
