using CompteBancaireLib;

namespace GUICompteBancaire
{
    public partial class FenetrePrincipale : Form
    {
        List<GestionCompte> listeComptes = new List<GestionCompte>();

        public FenetrePrincipale()
        {
            InitializeComponent();
        }

        private void FenetrePrincipale_Load(object sender, EventArgs e)
        {

        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichiers CSV |*.csv|Fichiers JSON (.json)|*.json|Tous les fichiers(*.*)|*.*";
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string fichier = ofd.FileName;
                        string ext = Path.GetExtension(fichier).ToLower();
                        CompteAvecSauvegarde compte = null;
                try
                {
                    if (ext == ".csv")
                        {
                        compte = CompteAvecSauvegarde.LireCSV(fichier);
                        }
                        else if (ext == ".json")
                        {
                            compte = CompteAvecSauvegarde.LireJSON(fichier);

                        }
                        else
                        {
                            MessageBox.Show("Type de fichier inconnu grrr", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    bool found = false;
                    foreach(GestionCompte gc in this.MdiChildren)
                    {
                        if(gc.Fichier == fichier)
                        {
                            found = true;
                            gc.Activate();
                            break;
                        }
                    }
                    if (!found)
                    {
                        GestionCompte nouvelleFenetre = new GestionCompte();
                        nouvelleFenetre.Fichier = fichier;
                        nouvelleFenetre.Compte = compte;
                        nouvelleFenetre.MdiParent = this;
                        nouvelleFenetre.Show();

                    }

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
