using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace March22th
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        int row;
        private void btnThem_Click(object sender, EventArgs e)
        {
            row = listView1.Items.Count;
            listView1.Items.Add(txtHoTen.Text);
            listView1.Items[row].SubItems.Add(txtNgaySinh.Text);
            listView1.Items[row].SubItems.Add(txtQueQuan.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(row);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            row = e.ItemIndex;
            txtHoTen.Text = listView1.Items[row].SubItems[0].Text;
            txtNgaySinh.Text = listView1.Items[row].SubItems[1].Text;
            txtQueQuan.Text = listView1.Items[row].SubItems[2].Text;
        }
    }
}
