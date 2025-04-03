using CompteBancaireLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICompteBancaire
{
    public partial class GestionCompte : Form
    {
        private CompteAvecSauvegarde _compte;
        public CompteAvecSauvegarde Compte
        {

            set
            {
                _compte = value;
                Text = _compte.Proprietaire + " : " + _compte.Numero;
                RemplirLaListe();
            }
        }

        private void RemplirLaListe()
        {
            foreach (Transaction t in _compte.Transactions)
            {
                ListViewItem unElement = new ListViewItem();

                unElement.Text = t.Date.ToString("dd/MM/yyyy");
                unElement.SubItems.Add(t.Montant.ToString("N2"));
                unElement.SubItems.Add(t.Notes);
                unElement.Tag = t;
                //
                listeTransactions.Items.Add(unElement);
            }
            if (listeTransactions.Items.Count > 0)
            {
                listeTransactions.Items[0].Selected = true;

            }
        }

        public String Fichier { get; set; }

        public GestionCompte()
        {
            InitializeComponent();
        }

        private void GestionCompte_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listeTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listeTransactions.SelectedItems.Count > 0)
            {
                ListViewItem unElement = listeTransactions.SelectedItems[0];
                Transaction t = (Transaction)unElement.Tag;
                textBoxMontant.Text = t.Montant.ToString("N2");
                textNotes.Text = t.Notes;
                pickerDate.Value = t.Date;
            }
            else
            {
                textBoxMontant.Text = "";
                textNotes.Text = "";
                pickerDate.Value = DateTime.Now;
            }

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (listeTransactions.SelectedItems.Count > 0)
            {
                ListViewItem unElement = listeTransactions.SelectedItems[0];
                if (unElement.Index > 0)
                {
                    DialogResult dr = MessageBox.Show("Etes vous sur ?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        listeTransactions.Items.Remove(unElement);
                        if (listeTransactions.Items.Count > 0)
                        {
                            listeTransactions.Items[0].Selected = true;

                        }
                    }
                }
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            listeTransactions.Enabled = false;
            buttonSupprimer.Enabled = false;



            panelZoom.Enabled = true;
            buttonValider.Visible = true;
            buttonAjouter.Visible = false;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            panelZoom.Enabled = false;
            buttonValider.Visible = false;
            buttonAjouter.Visible = true;

            listeTransactions.Enabled = true;
            buttonSupprimer.Enabled = true;
        }
    }
}
