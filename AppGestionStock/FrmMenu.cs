using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionStock
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            frmCategorie f = new frmCategorie();
            f.MdiParent = this.MdiParent;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
            this.Hide();
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            frmProduit f = new frmProduit();
            f.MdiParent = this.MdiParent;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
