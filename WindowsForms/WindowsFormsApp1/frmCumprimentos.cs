using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCumprimentos : Form
    {
        public frmCumprimentos()
        {
            InitializeComponent();
            this.Height = 137;
            this.Width = 252;
            this.Text = "Cumprimentos";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0} {1}", txt1.Text , textBox2.Text);
            this.Height = 208;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            textBox2.Clear();
            this.Height = 137;
        }
    }
}
