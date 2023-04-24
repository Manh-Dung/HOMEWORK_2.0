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
using System.Data.Sql;
using System.Data.SqlClient;

namespace GUI
{
    public partial class AdNewAcc : Form
    {
        public AdNewAcc()
        {
            InitializeComponent();
        }
        DTO_Account dto = new DTO_Account();
        BUS_Account bus = new BUS_Account();
        private void AdNewAcc_Load(object sender, EventArgs e)
        {
            dgvAccount.DataSource = bus.ShowAcc();
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            if (txtUsername.TextLength == 0)
                MessageBox.Show("Tài khoản không được bỏ trống!");
            else if (txtPassword.TextLength == 0)
                MessageBox.Show("Mật khẩu không được bỏ trống!");
            else if (txtConfPass.Text != txtPassword.Text)
                MessageBox.Show("Nhập lại mật khẩu không chính xác!");
            else
            {
                try
                {
                    dto.UserName = txtUsername.Text;
                    dto.PassWord = txtPassword.Text;
                    if (rdoAdmin.Checked) dto.Permission = 1;
                    if (rdoUser.Checked) dto.Permission = 0;
                    bus.AddAcc(dto.UserName, dto.PassWord, dto.Permission);
                    MessageBox.Show("Đã thêm thành công");
                    AdNewAcc_Load(sender, e);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Có lỗi!");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            if (txtUsername.TextLength == 0)
                MessageBox.Show("Bạn cần chọn tài khoản để xóa");
            else
            {
                dto.UserName = txtUsername.Text;
                dto.PassWord = txtPassword.Text;
                bus.DelAcc(dto.UserName, dto.PassWord);
            }
            MessageBox.Show("Đã xóa thành công!");
            AdNewAcc_Load(sender, e);
        }

        private void dgvAccount_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtUsername.Text = dgvAccount.Rows[dong].Cells[0].Value.ToString();
            txtPassword.Text = dgvAccount.Rows[dong].Cells[1].Value.ToString();
        }
    }
}
