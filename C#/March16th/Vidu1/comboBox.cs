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
    public partial class comboBox : Form
    {
        public comboBox()
        {
            InitializeComponent();
        }

        private void comboBox_Load(object sender, EventArgs e)
        {
            cBoxGen.Items.Add("Male");
            cBoxGen.Items.Add("Famale");
            cBoxDepart.Items.Add("Phòng tài vụ");
            cBoxDepart.Items.Add("Phòng hành chính");
            cBoxDepart.Items.Add("Phòng kinh doanh");
            cBoxDepart.Items.Add("Phòng kỹ thuật");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string st = txtName.Text + " - " + cBoxGen.Text + " - " + cBoxDepart.Text;
            lstDanhSach.Items.Add(st);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
