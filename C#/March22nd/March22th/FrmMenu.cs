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
    public partial class frmCha : Form
    {
        public frmCha()
        {
            InitializeComponent();
        }

        

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmDangNhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTreeView();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmListView();
            frm.MdiParent = this;
            frm.Show();
        }

        private void phátSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmMayTinh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void máyTínhOOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmMayTinhOOP();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
