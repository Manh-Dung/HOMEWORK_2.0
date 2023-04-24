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
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTreeView_Load(object sender, EventArgs e)
        {
            TreeNode nodeKhoa = treeView1.Nodes.Add("Khoa đào tạo");
            nodeKhoa.Nodes.Add("Khoa cơ khí");
            nodeKhoa.Nodes.Add("Khoa kế toán");
            TreeNode nodeCNTT = nodeKhoa.Nodes.Add("Khoa công nghệ thông tin");
            nodeCNTT.Nodes.Add("Tổ công nghệ đa phương tiện");
            nodeCNTT.Nodes.Add("Tổ khoa học máy tính");
            nodeCNTT.Nodes.Add("Tổ kỹ thuật phần mềm");
            nodeCNTT.Nodes.Add("Tổ Mạng - Kỹ thuật máy tính");
            nodeCNTT.Nodes.Add("Tổ Kỹ thuật - Hành chính");
            nodeKhoa.Nodes.Add("Khoa điện");
            nodeKhoa.Nodes.Add("Khoa điện tử");
        }

        private void btnXoaNode_Click(object sender, EventArgs e)
        {
            TreeNode tn = treeView1.SelectedNode;
            treeView1.Nodes.Remove(tn);
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }
    }
}
