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
    public partial class listBox : Form
    {
        public listBox()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            danhSach.Items.Add("Nhập môn tin học");
            danhSach.Items.Add("Tin văn phòng");
            danhSach.Items.Add("Lập trình mạng");
            danhSach.Items.Add("Lập trình trên Windows");
            danhSach.Items.Add("Công nghệ thực tế ảo");
            danhSach.Items.Add("Phân tích thiết kế hệ thống");
            danhSach.Items.Add("Lập trình hướng đối tượng");
            danhSach.Items.Add("Thiết kế trang Web");
            danhSach.Items.Add("Đảm bảo chất lượng phần mềm");
            danhSach.Items.Add("Giải thuật di truyền và ứng dụng");
            danhSach.Items.Add("Hệ chuyên gia");
            danhSach.Items.Add("Lập trình căn bản");
            danhSach.Items.Add("Một số phương pháp tính toán mềm");
            danhSach.Items.Add("Phân tích và thống kê số liệu");
            danhSach.Items.Add("Thiết kế cơ sở dữ liệu");
        }

        private void themDonLe_Click(object sender, EventArgs e)
        {
            sachDaChon.Items.Add(danhSach.SelectedItem);
        }

        private void themToanBo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < danhSach.Items.Count; i++)
            {
                sachDaChon.Items.Add(danhSach.Items[i]);
            }
        }

        private void xoaDonLe_Click(object sender, EventArgs e)
        {
            sachDaChon.Items.Remove(sachDaChon.SelectedItem);
        }

        private void xoaToanBo_Click(object sender, EventArgs e)
        {
            sachDaChon.Items.Clear();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
