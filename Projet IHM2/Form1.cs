using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Projet_IHM2
{
    public partial class Form1 : Form
    {
        // variables globales
        static OleDbConnection cnx;     // l'objet de connexion à la base de données

        // le constructeur de la class Form1 (on n'y touche pas !)
        public Form1()
        {
            InitializeComponent();
        }

        // cette fonction s'exécute lors de l'évènement Load du formulaire qui indique la fin du chargement en mémoire
        // c'est une des premières fonctions à s'exécuter, on y place donc des traitements d'initialisation
        // comme la connexion à une base de données
        private void Form1_Load(object sender, EventArgs e)
        {
            // chaîne de connexion à une base de données Access (Jet est le moteur d'Access)
            // Data Source ne précise pas de chemin
            // ce qui signifie que la base Lycée2012 accdb est placée dans le dossier d'exécution (bin/Debug)
            // ATTENTION : bien respecter la casse et ne pas ajouter ou retirer d'espace
            const String CHAINE_CNX = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Lycee2012.accdb;";
            String msg;

            // un bloc Try (essayer) sert à placer des instructions qui risquent de "planter"
            // (par exemple : tentative de connexion à une base de données absente ou défectueuse)
            // en cas d'erreur d'exécution, le programme se déroute automatiquement vers le bloc Catch
            try
            {
                // Connexion à la base données
                cnx = new OleDbConnection(CHAINE_CNX);
                cnx.Open();

                // affichage des données dans le contrôle listBoxMatieres
                afficherDonnees();
            }
            catch (Exception ex)
            {
                // un bloc Catch permet de "reprendre la main" lors d'une erreur d'exécution
                // l'objet ex (de la classe Exception) représente l'erreur
                // sa propriété ex.Message done le libellé de l'erreur
                msg = "Problème de connexion à la base de données \r\r" + ex.Message;
                MessageBox.Show(msg, "Problème", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // cette fonction s'exécute lors de l'évènement FormClosing du formulaire qui précède la fermeture du formulaire
        // c'est une des dernières fonctions à s'exécuter, on y place donc des traitements terminaux
        // comme la déconnexion d'une base de données
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // fermeture de la connexion (si elle est ouverte)
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }

            // suppression de l'objet cnx
            cnx = null;
        }

        // cette fonction s'exécute lors d'un clic sur le bouton btnQuitter et ferme le formulaire
        // ce qui déclenche l'évènement FormClosing, et donc la déconnexion de la base
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // cette procédure affiche les matières dans le contrôle listBoMatieres
        // elle utilise un objet de la classe DataTable pour stocker le jeu de données (jdd)
        // obtenu avec une requête SQL de type SELECT
        private void afficherDonnees()
        {
            // requête SQL de sélection des données
            String req;
            req = "SELECT * FROM Matieres WHERE CodeMatiere LIKE '";
            req += this.txtFiltreCode.Text + "%' ORDER BY CodeMatiere";
            OleDbDataAdapter cmd;                           // la source de données (correspond à la connexion et à la requête SELECT)
            DataTable jdd;                                  // les données résultant de la requête SELECT(jdd = Jeu De Données)
            String uneLigne;                                // une ligne de texte à ajouter à la collection listBoxMatieres.Items

            this.listBoxMatieres.Items.Clear();             // efface le contenu de la collection listBoxMatieres
            cmd = new OleDbDataAdapter(req, cnx);           // préparation de la source de données
            jdd = new DataTable("Matières");                // on donne un nom significatif à l'objet DataTable
            cmd.Fill(jdd);                                  // exécution de la requête et récupération des données

            // boucle de remplissage de la collection listBoxMatieres.Items
            // la variable unEnreg représente l'enregistrement courant de jdd
            foreach (DataRow unEnreg in jdd.Rows)           // pour un enregistrement de l'objet DataTable
            {
                // traitement de l'enregistrement : ajout d'une ligne de texte dans la collection d'éléements de listBoxMatieres
                // unEnreg["CodeMatiere"] désigne la colonne CodeMatiere dans l'enregistrement courant du unEnreg
                // PadRight complète le code matière avec des espaces à droite pour le mettre à une longueur de 5 caractères
                uneLigne = Convert.ToString(unEnreg["CodeMatiere"]).PadRight(3, ' ');
                uneLigne = uneLigne + " - " + Convert.ToString(unEnreg["LibelleMatiere"]);
                this.listBoxMatieres.Items.Add(uneLigne);
            }

            // suppression du jeu de données
            jdd = null;
            cmd = null;

            // sélection automatique de la première ligne du contrôle listBox
            if(this.listBoxMatieres.Items.Count > 0)
            {
                this.listBoxMatieres.SelectedIndex = 0;
            }
        }

        // cette fonction s'exécute lors d'un clic sur le bouton btnAjouter
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            String msg;
            String req;             // requête SQL du type INSERT
            OleDbCommand cmd;       // la commande à exécuter
            if (this.txtAjoutCode.Text == "" || this.txtAjoutLibelle.Text == "")
            {
                msg = "Les données doivent être saisies";
                MessageBox.Show(msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // construction de la requête d'insertion
                req = "INSERT INTO Matieres(CodeMatiere, LibelleMatiere) VALUES";
                req += "('" + this.txtAjoutCode.Text.ToUpper() + "'";
                req += ",'" + this.txtAjoutLibelle.Text.Replace("'", "''") + "')";

                try
                {
                    cmd = new OleDbCommand(req, cnx);               // prépare la requête
                    cmd.ExecuteNonQuery();                          // exécute la requête
                    afficherDonnees();                              // affiche les données (avec une ligne en plus et un nouveau tri)
                }
                catch (Exception ex)
                {
                    // une erreur d'exécution s'est produite
                    msg = ex.Message + "\r" + req;
                    MessageBox.Show(msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // cette fonction s'exécute lorsqu'on sélectionne une nouvelle ligne dans le contrôle listBoxMatieres
        private void listBoxMatieres_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtModifCode.Text = this.listBoxMatieres.Text.Substring(0, 5);
            this.txtModifLibelle.Text = this.listBoxMatieres.Text.Substring(8, this.listBoxMatieres.Text.Length - 8);
        }

        // cette fonction s'exécute lors d'un clic sur le bouton btnModifier
        private void btnModifier_Click(object sender, EventArgs e)
        {
            String msg;
            String req;             // requête SQL du type UPDATE
            OleDbCommand cmd;       // la commande à exécuter

            if (this.txtModifCode.Text == "" || this.txtModifLibelle.Text == "")
            {
                msg = "Les données doivent être saisies";
                MessageBox.Show(msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // construction de la requête de mise à jour
                req = "UPDATE Matieres";
                req += " set LibelleMatiere = '" + this.txtModifLibelle.Text.Replace("'", "''") + "'";
                req += " WHERE CodeMatiere = '" + this.txtModifCode.Text + "'";
                try
                {
                    cmd = new OleDbCommand(req, cnx);           // prépare la requête
                    cmd.ExecuteNonQuery();                      // exécute la requête 
                    afficherDonnees();                          // affiche les données ( avec une ligne de plus et un nouveau tri)
                }
                catch (Exception ex)
                {
                    // une erreur d'exécution s'est produite
                    msg = ex.Message + "\r" + req;
                    MessageBox.Show(msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // cette fonction s'exécute lors d'un clic sur le bouton btnSupprimer
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            String msg;
            String req;             // requête SQL du type UPDATE
            OleDbCommand cmd;       // la commande à exécuter

            if (this.listBoxMatieres.Text == "")
            {
                msg = "Il faut sélectionner un enregistrement";
                MessageBox.Show(msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // construction de la requête de suppression
                req = "DELETE FROM Matieres WHERE CodeMatiere = " + this.listBoxMatieres.Text.Substring(0, 5).Trim() + "'";
                req += " set LibelleMatiere = '" + this.txtModifLibelle.Text + "'";
                req += " WHERE CodeMatiere = '" + this.txtModifCode.Text + "'";
                try
                {
                    cmd = new OleDbCommand(req, cnx);           // prépare la requête
                    cmd.ExecuteNonQuery();                      // exécute la requête 
                    afficherDonnees();                          // affiche les données ( avec une ligne de plus et un nouveau tri)
                }
                catch (Exception ex)
                {
                    // une erreur d'exécution s'est produite
                    msg = ex.Message + "\r" + req;
                    MessageBox.Show(msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // cette fonction s'exécute à chaque changement du contenu de la zone de txtFiltreCode
        // elle réaffiche les données en tenant compte du nouveau filtre saisi
        private void txtFiltreCode_TextChanged(object sender, EventArgs e)
        {
            afficherDonnees();
        }

    }
}