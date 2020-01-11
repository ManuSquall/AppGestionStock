using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// agrandir la page
using Microsoft.VisualBasic.Devices;

namespace AppGestionStock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void approvisionnementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fermer()
        {
            Form[] enfant = this.MdiChildren;
            foreach (var gg in enfant)
            {
                gg.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Computer mycomputer = new Computer();
            //this.Width = mycomputer.Screen.Bounds.Width;
            //this.Height = mycomputer.Screen.Bounds.Height;
            this.Width = 820;
            this.Height = 510;
            this.SetDesktopLocation(0, 0);
            fermer();
            FrmMenu menu = new FrmMenu();
            menu.MdiParent = this;
            menu.Show();
            menu.WindowState = FormWindowState.Maximized;
        }

        

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void suivantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FrmMenu menu = new FrmMenu();
            menu.MdiParent = this;
            menu.Show();
            menu.WindowState = FormWindowState.Maximized;
        }

        private void retourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
