using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidu1
{
    public partial class radioButton : Form
    {
        public radioButton()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioiTinh = "Giới tính: ";
            if (rdoNam.Checked) gioiTinh += "Nam";
            if (rdoNu.Checked) gioiTinh += "Nữ";
            string honNhan = "Tình trạng hôn nhân: ";
            if (rdoDaKetHon.Checked) honNhan += "Đã kết hôn";
            if (rdoChuaKetHon.Checked) honNhan += "Chưa kết hôn";
            string soThich = "Sở thích: ";
            lstDanhSach.Items.Add("Họ tên: " + txtName.Text);
            lstDanhSach.Items.Add(gioiTinh);
            lstDanhSach.Items.Add(honNhan);
            lstDanhSach.Items.Add(soThich);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
