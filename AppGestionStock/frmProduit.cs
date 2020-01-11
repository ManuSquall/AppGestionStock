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
    public partial class frmProduit : Form
    {
        bdstockEntities bd = new bdstockEntities();
        public frmProduit()
        {
            InitializeComponent();
        }

        private void frmProduit_Load(object sender, EventArgs e)
        {
            dgProduit.DataSource = bd.produit.ToList();
            cbbCategorie.DataSource = bd.categorie.ToList();
            cbbCategorie.DisplayMember = "denominationC";
            cbbCategorie.ValueMember = "idC";
        }

        public void Effacer()
        {
            txtDenomination.Text = string.Empty;
            txtCode.Text = string.Empty;
            txtPU.Text = string.Empty;
            rtxtDescription.Text = string.Empty;
            nudQuantite.Value = 0;
            nudMinimum.Value = 0;
            nudCritique.Value = 0;
            dgProduit.DataSource = bd.produit.ToList();
            txtCode.Focus();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                produit p = new produit();
                p.idC = (cbbCategorie.SelectedIndex + 1);
                p.codeProduit = txtCode.Text;
                p.denominationProduit = txtDenomination.Text;
                p.pu = int.Parse(txtPU.Text);
                p.description = rtxtDescription.Text;
                p.qte = Convert.ToInt32(Math.Round(nudQuantite.Value, 0));
                p.qteMinimum = Convert.ToInt32(Math.Round(nudMinimum.Value, 0));
                p.qteCritique = Convert.ToInt32(Math.Round(nudCritique.Value, 0));
                p.image = imageLocationtxt.Text;

                bd.produit.Add(p);
                bd.SaveChanges();
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
                txtCode.Text = dgProduit.CurrentRow.Cells[1].Value.ToString();
                txtDenomination.Text = dgProduit.CurrentRow.Cells[2].Value.ToString();
                nudQuantite.Value = Convert.ToDecimal(dgProduit.CurrentRow.Cells[3].Value);
                txtPU.Text = dgProduit.CurrentRow.Cells[4].Value.ToString();
                cbbCategorie.SelectedItem = dgProduit.CurrentRow.Cells[5].Value;

                nudMinimum.Value = Convert.ToDecimal(dgProduit.CurrentRow.Cells[6].Value);
                nudCritique.Value = Convert.ToDecimal(dgProduit.CurrentRow.Cells[7].Value);
                rtxtDescription.Text = dgProduit.CurrentRow.Cells[9].Value.ToString();
                imageLocationtxt.Text = dgProduit.CurrentRow.Cells[8].Value.ToString();
            }catch (Exception)
            {

            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
                produit p = bd.produit.Find(id);

                p.idC = (cbbCategorie.SelectedIndex + 1);
                p.codeProduit = txtCode.Text;
                p.denominationProduit = txtDenomination.Text;
                p.pu = Convert.ToInt32(txtPU.Text);
                p.description = rtxtDescription.Text;
                p.qte = Convert.ToInt32(Math.Round(nudQuantite.Value, 0));
                p.qteMinimum = Convert.ToInt32(Math.Round(nudMinimum.Value, 0));
                p.qteCritique = Convert.ToInt32(Math.Round(nudCritique.Value, 0));
                p.image = "squall";

                bd.SaveChanges();
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

                int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
                produit p = bd.produit.Find(id);

                bd.produit.Remove(p);
                bd.SaveChanges();
                Effacer();
            }
            catch (Exception)
            {
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nudCritique_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDenomination_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPU_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    imageLocationtxt.Text = imageLocation;
                }

            } catch (Exception ) {
                MessageBox.Show("Erreur");
            }
        }
    }
}
