using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Vidu1 : Form
    {
        public Vidu1()
        {
            InitializeComponent();
        }

        private void Vidu1_Load(object sender, EventArgs e)
        {
            this.Text = "Xin chào!";
        }

        private void Vidu1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xảy ra sự kiện Click!");
        }

        private void Vidu1_Resize(object sender, EventArgs e)
        {
            string height = "Chiều cao của Form là: " + this.Height.ToString();
            string width = "Chiều rộng của Form là: " + this.Width.ToString();
            MessageBox.Show(height + width);
        }
    }
}
