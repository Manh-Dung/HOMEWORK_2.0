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
using DAL;
using DTO;

namespace GUI
{
    public partial class Locate : Form
    {
        public Locate()
        {
            InitializeComponent();
        }
        // Diem den
        DTO_Destina dto_des = new DTO_Destina();    
        BUS_Destina bus_des = new BUS_Destina();    
        // Diem tham quan
        DTO_Sight dto_sig = new DTO_Sight();    
        BUS_Sight bus_sig = new BUS_Sight();
        // Khach san
        DTO_Hotel dto_hot = new DTO_Hotel();
        BUS_Hotel bus_hot = new BUS_Hotel();
        // Nha hang
        DTO_Restaurant dto_res = new DTO_Restaurant();
        BUS_Restaurant bus_res = new BUS_Restaurant();
        // Mua sam
        DTO_Shop dto_sho = new DTO_Shop();
        BUS_Shop bus_sho = new BUS_Shop();
        // Dich vu khac
        DTO_Service dto_ser = new DTO_Service();
        BUS_Service bus_ser = new BUS_Service();

        private void Locate_Load(object sender, EventArgs e)    // Refresh tat ca cac dgv
        {
            dgvDiemDen.DataSource = bus_des.ShowDestina();
            Load_Dgv(dto_des.MaDiemDen);    // Load lai cac dgv be theo ma diem den
        }
        public void Load_Dgv(string mdd)
        {
            dgvDiemTQ.DataSource = bus_sig.ShowSight(mdd);
            dgvKhachSan.DataSource = bus_hot.ShowHotel(mdd);
            dgvNhaHang.DataSource = bus_res.ShowRestau(mdd);
            dgvMuaSam.DataSource = bus_sho.ShowShop(mdd);
            dgvDichVu.DataSource = bus_ser.ShowService(mdd);
        }

        private void dgvDiemDen_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            dto_des.MaDiemDen = dgvDiemDen.Rows[dong].Cells[0].Value.ToString();
            Load_Dgv(dto_des.MaDiemDen);
            txtDD.Text = dgvDiemDen.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnDelDD_Click(object sender, EventArgs e)
        {
            bus_des.DelDestina(dto_des.MaDiemDen);
            MessageBox.Show("Đã xóa thành công!");
            Locate_Load(sender, e);
        }

        private void btnSearchDD_Click(object sender, EventArgs e)
        {
            if (txtSearchDD.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvDiemDen.DataSource = bus_des.SearchDestina(txtSearchDD.Text);
            }
        }

        private void btnRefrDD_Click(object sender, EventArgs e)
        {
            txtSearchDD.Clear();
            Locate_Load(sender, e);
        }

        private void dgvDiemDen_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (col == 1)
            {
                Destina f = new Destina();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void dgvDiemTQ_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if(col == 1 || col == 2)
            {
                Sight f = new Sight();
                this.Hide();
                f.ShowDialog();
                this.Show();
                Locate_Load(sender, e);
            }
        }

        private void btnRefrTQ_Click(object sender, EventArgs e)
        {
            txtTQ.Clear();
            Load_Dgv(dto_des.MaDiemDen);
        }

        private void dgvDiemTQ_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            dto_sig.MaDiemThamQuan = dgvDiemTQ.Rows[dong].Cells[0].Value.ToString();
            txtTQ.Text = dgvDiemTQ.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnDelTQ_Click(object sender, EventArgs e)
        {
            bus_sig.DelSight(dto_sig.MaDiemThamQuan);
            MessageBox.Show("Đã xóa thành công!");
            Locate_Load(sender, e);
        }

        private void btnSearchTQ_Click(object sender, EventArgs e)
        {
            if (txtSearchTQ.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvDiemTQ.DataSource = bus_sig.SearchSight(txtSearchTQ.Text);
            }
        }

        private void dgvKhachSan_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (col > 0 && col < 6)
            {
                Hotel f = new Hotel();
                this.Hide();
                f.ShowDialog();
                this.Show();
                Locate_Load(sender, e);
            }
        }

        private void dgvNhaHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (col > 0 && col < 6)
            {
                Restaurant f = new Restaurant();
                this.Hide();
                f.ShowDialog();
                this.Show();
                Locate_Load(sender, e);
            }
        }

        private void dgvMuaSam_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (col > 0 && col < 6)
            {
                Shop f = new Shop();
                this.Hide();
                f.ShowDialog();
                this.Show();
                Locate_Load(sender, e);
            }
        }

        private void dgvDichVu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (col > 0 && col < 6)
            {
                Service f = new Service();
                this.Hide();
                f.ShowDialog();
                this.Show();
                Locate_Load(sender, e);
            }
        }

        private void dgvKhachSan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            dto_hot.MaKhachSan = dgvKhachSan.Rows[dong].Cells[0].Value.ToString();
            txtKS.Text = dgvKhachSan.Rows[dong].Cells[5].Value.ToString();
        }

        private void dgvNhaHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            dto_res.MaNhaHang = dgvNhaHang.Rows[dong].Cells[0].Value.ToString();
            txtNH.Text = dgvNhaHang.Rows[dong].Cells[5].Value.ToString();
        }

        private void dgvMuaSam_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            dto_sho.MaMuaSam = dgvMuaSam.Rows[dong].Cells[0].Value.ToString();
            txtMS.Text = dgvMuaSam.Rows[dong].Cells[5].Value.ToString();
        }

        private void dgvDichVu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            dto_ser.MaDichVu = dgvDichVu.Rows[dong].Cells[0].Value.ToString();
            txtDV.Text = dgvDichVu.Rows[dong].Cells[5].Value.ToString();
        }

        private void btnDelKS_Click(object sender, EventArgs e)
        {
            bus_hot.DelHotel(dto_hot.MaKhachSan);
            MessageBox.Show("Đã xóa thành công!");
            Locate_Load(sender, e);
        }

        private void btnSearchKS_Click(object sender, EventArgs e)
        {
            if (txtSearchKS.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvKhachSan.DataSource = bus_hot.SearchHotel(txtSearchKS.Text);
            }
        }

        private void btnRefrKS_Click(object sender, EventArgs e)
        {
            txtKS.Clear();
            Load_Dgv(dto_des.MaDiemDen);
        }

        private void btnDelNH_Click(object sender, EventArgs e)
        {
            bus_res.DelRestau(dto_res.MaNhaHang);
            MessageBox.Show("Đã xóa thành công!");
            Locate_Load(sender, e);
        }

        private void btnDelMS_Click(object sender, EventArgs e)
        {
            bus_sho.DelShop(dto_sho.MaMuaSam);
            MessageBox.Show("Đã xóa thành công!");
            Locate_Load(sender, e);
        }

        private void btnDelDV_Click(object sender, EventArgs e)
        {
            bus_ser.DelService(dto_ser.MaDichVu);
            MessageBox.Show("Đã xóa thành công!");
            Locate_Load(sender, e);
        }

        private void btnSearchNH_Click(object sender, EventArgs e)
        {
            if (txtSearchNH.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvNhaHang.DataSource = bus_res.SearchRestau(txtSearchNH.Text);
            }
        }

        private void btnSearchMS_Click(object sender, EventArgs e)
        {
            if (txtMS.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvMuaSam.DataSource = bus_sho.SearchShop(txtMS.Text);
            }
        }

        private void btnSearchDV_Click(object sender, EventArgs e)
        {
            if (txtSearchDV.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
            {
                dgvDichVu.DataSource = bus_ser.SearchService(txtSearchDV.Text);
            }
        }

        private void btnRefrDV_Click(object sender, EventArgs e)
        {
            txtDV.Clear();
            Load_Dgv(dto_des.MaDiemDen);
        }

        private void btnRefrMS_Click(object sender, EventArgs e)
        {
            txtMS.Clear();
            Load_Dgv(dto_des.MaDiemDen);
        }

        private void btnRefrNH_Click(object sender, EventArgs e)
        {
            txtNH.Clear();
            Load_Dgv(dto_des.MaDiemDen);
        }
    }
}
