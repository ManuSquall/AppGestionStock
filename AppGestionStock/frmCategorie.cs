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
    public partial class frmCategorie : Form
    {
        bdstockEntities db = new bdstockEntities();
        public frmCategorie()
        {
            InitializeComponent();
        }

        private void frmCategorie_Load(object sender, EventArgs e)
        {
            
                dgCategorie.DataSource = db.categorie.ToList();

        }

        public void Effacer()
        {
            txtdenomination.Text = string.Empty;
            txtCode.Text = string.Empty;
            dgCategorie.DataSource = db.categorie.ToList();
            txtCode.Focus();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                categorie c = new categorie();
                c.codeC = txtCode.Text;
                c.denominationC = txtdenomination.Text;
                db.categorie.Add(c);
                db.SaveChanges();
                Effacer();
            }
            catch (Exception)
            {

            }
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            try
            {
                txtCode.Text = dgCategorie.CurrentRow.Cells[1].Value.ToString();
                txtdenomination.Text = dgCategorie.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
                categorie c = db.categorie.Find(id);
                c.codeC = txtCode.Text;
                c.denominationC = txtdenomination.Text;
                db.SaveChanges();
                Effacer();
            }
            catch (Exception)
            {

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
                categorie c = db.categorie.Find(id);
                db.categorie.Remove(c);
                db.SaveChanges();
                Effacer();
            }
            catch (Exception)
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
