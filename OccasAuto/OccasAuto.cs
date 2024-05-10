using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionMySQL;
using OccasDLL;

namespace OccasAuto
{
    public partial class OccasAuto : Form
    {
        //DECLARATION VARIABLES

        List<Concessionnaire> lesConcessionnaires = new List<Concessionnaire>();
        string modeAddMofid;
        int currentID; // For the modification 

        public OccasAuto(string pseudo)
        {
            InitializeComponent();

            BtnPseudo.Text = "            " + pseudo;
            // Calling functions
            ListFilling("", "");
        }

        // fill the list listConcessionnaires with all the Concessionnaires from the DB adn with the according parameters
        public void ListFilling(string nom, string ville)
        {
            // default values
            // set nom and vilel to empty string so the request take the value "" and not "-- Tous --"
            if (nom == "-- Tous --") 
                nom = "";
            if (ville == "-- Toutes --")
                ville = "";

            listViewConcess.Items.Clear(); // clear the listbox
            try
            {
                lesConcessionnaires = Concessionnaire.Recherche(nom, ville);    // use the Recherche Function from Concessionnaire Class
            }
            catch
            {
                MessageBox.Show("Impossible de récuperer les concessionnaires depuis la base de données. Verifiez l'état du serveur et réessayez", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            foreach (Concessionnaire c in lesConcessionnaires)
            {
                // Add each 'concessionnaire' in the ListView
                string[] concess = { c.Id.ToString(), c.Nom, c.Prenom, c.Adresse, c.CP, c.Ville };              
                listViewConcess.Items.Add(new ListViewItem(concess));
            }
            FiltresFilling();
        }

        // fill the filters with all the existing names and cities from the 'concesionnaires'
        public void FiltresFilling()
        {         
            cmbBoxNom.Items.Clear();
            cmbBoxVille.Items.Clear();
            cmbBoxNom.Items.Add("-- Tous --");
            cmbBoxVille.Items.Add("-- Toutes --");
            
            foreach (Concessionnaire c in lesConcessionnaires)
            {
                if (!cmbBoxNom.Items.Contains(c.Nom)) // if name not in the combolist, add name
                {
                    cmbBoxNom.Items.Add(c.Nom);
                }
                if (!cmbBoxVille.Items.Contains(c.Ville))
                {
                    cmbBoxVille.Items.Add(c.Ville);
                }                       
            }

            // Some graphic adjustements 
            cmbBoxNom.SelectedIndex = 0;    // Select the first value
            cmbBoxVille.SelectedIndex = 0;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            ListFilling(cmbBoxNom.Text,cmbBoxVille.Text);   // Fill the list with the name and city selected 
        }
        
        //
        // ADD NEW CONCESSIONNAIRE
        //

        // Reset all the text boxes from the ADD group box and closes it
        private void GPAddModif()
        {
            if (gpAddModifConcess.Visible)
            {
                gpAddModifConcess.Visible = false;

                lblErr.Text = "";
                txtNom_GPADD.Text = string.Empty;
                txtPrenom_GPADD.Text = string.Empty;
                txtRue_GPADD.Text = string.Empty;
                txtCP_GPADD.Text = string.Empty;
                txtVille_GPADD.Text = string.Empty;

                currentID = 0; //reset current id to default value 
            }
        }

        // Display the group box ADD that allows to create a new 'concessionnaire'
        // Preset the gp box for the differents modes
        private void GPAddModif(string mode)
        {
            if (gpAddModifConcess.Visible) GPAddModif();
            else gpAddModifConcess.Visible = true;

            switch (mode)
            {
                // ADD CONCESIONNAIRE MODE
                case "add":
                    modeAddMofid = "add";
                    lblGpAddModif.Text = "AJOUTEZ UN CONCESSIONNAIRE";
                    break;

                //MODIF CONCESIONNAIRE MODE
                case "modif":

                    // Get all the informations from the ListView's selected line
                    ListView.SelectedListViewItemCollection selectedLine = this.listViewConcess.SelectedItems;
                    foreach (ListViewItem item in selectedLine)
                    {
                        currentID = int.Parse(item.SubItems[0].Text);
                        txtNom_GPADD.Text = item.SubItems[1].Text;
                        txtPrenom_GPADD.Text = item.SubItems[2].Text;
                        txtRue_GPADD.Text = item.SubItems[3].Text;
                        txtCP_GPADD.Text = item.SubItems[4].Text;
                        txtVille_GPADD.Text = item.SubItems[5].Text;
                    }
                    modeAddMofid = "modif";
                    lblGpAddModif.Text = "MODIFIEZ LE CONCESSIONNAIRE";
                    break;
            }
        }

        private void BtnCancelGPADD_Click(object sender, EventArgs e)
        {
            GPAddModif(); // Close GP ADD
        }

        private void BtnFermerGPADD_Click(object sender, EventArgs e)
        {
            GPAddModif(); // Close GP ADD
        }
       
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            GPAddModif("add");
        }

        // On validation ..
        private void BtnOKGPADD_Click(object sender, EventArgs e)
        {
            // get all the values entered by user
            string nom = CKApostrophes(txtNom_GPADD.Text);
            string prenom = CKApostrophes(txtPrenom_GPADD.Text);
            string adresse = CKApostrophes(txtRue_GPADD.Text);
            string cp = CKApostrophes(txtCP_GPADD.Text);
            string ville = CKApostrophes(txtVille_GPADD.Text);

            if (modeAddMofid == "add" && Verification()) // if "add" mode, then add a new concessionnaire 
            {
                Concessionnaire newConcess = new Concessionnaire(nom, prenom, adresse, cp ,ville);
                try {
                    newConcess.AddDB();
                }
                catch {
                    MessageBox.Show("Imposible d'ajouter un nouveau concessionnaire. Verifiez l'état du serveur et réessayez", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                ListFilling(cmbBoxNom.Text, cmbBoxVille.Text); // Actualize
                GPAddModif();
            }
            else if(modeAddMofid == "modif" && Verification()) 
            {
                Concessionnaire modifConcess = new Concessionnaire();
                foreach(Concessionnaire concess in lesConcessionnaires)
                {
                    if (concess.Id == currentID)
                        modifConcess = concess;
                }
                modifConcess.Nom = nom;     //set new values
                modifConcess.Prenom = prenom;
                modifConcess.Adresse = adresse;
                modifConcess.CP = cp;
                modifConcess.Ville = ville;
                try {
                    modifConcess.UpdateDB(); // update DB
                }
                catch {
                    MessageBox.Show("Imposible de mofifier le concessionnaire. Verifiez l'état du serveur et réessayez", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                ListFilling(cmbBoxNom.Text, cmbBoxVille.Text); // Actualize
                GPAddModif();
            }            
        }

        // Checks if the string contains a ' and replace it with '' so it can be add in the database
        private string CKApostrophes(string check)
        {
            return check.Replace("'","\\'");
        }

        // Checks if all fields are filled correctly
        private bool Verification()
        {
            bool ok = true;
            // get all the values entered by user
            string nom = txtNom_GPADD.Text;
            string prenom = txtPrenom_GPADD.Text;
            string adresse = txtRue_GPADD.Text;
            string cp = txtCP_GPADD.Text;
            string ville = txtVille_GPADD.Text;

            if (String.IsNullOrWhiteSpace(nom) || String.IsNullOrWhiteSpace(prenom) || String.IsNullOrWhiteSpace(adresse) || String.IsNullOrWhiteSpace(cp) || String.IsNullOrWhiteSpace(ville))
            { 
                lblErr.Text = "Veuillez Remplir tous les champs.";
                ok = false;
            }
            else if ( nom.Length > 30)
            {
                lblErr.Text = "Le Nom est trop long.";
                ok = false;
            }
            else if( prenom.Length > 30)
            {
                lblErr.Text = "Le Prénom est trop long.";
                ok = false;
            }
            else if( adresse.Length > 50)
            {
                lblErr.Text = "L'adresse est trop longue.";
                ok = false;
            }
            else if (cp.Length != 5)
            {
                lblErr.Text = "Le Code Postal est formaté.";
                ok = false;
            }
            else if( ville.Length > 50)
            {
                lblErr.Text = "La Ville est trop longue.";
                ok = false;
            }
            return ok;
        }

        //
        // CONCESIONNAIRE MODIFICATION
        //

        private void BtnModif_Click(object sender, EventArgs e)
        {
            // Get all the informations from the ListView's selected line
            ListView.SelectedListViewItemCollection selectedLine = this.listViewConcess.SelectedItems;
            foreach (ListViewItem item in selectedLine)
                currentID = int.Parse(item.SubItems[0].Text); // if nothing selected, currentID =0
            if (currentID != 0) // the if a line is selected ...
                GPAddModif("modif");
            else
                MessageBox.Show("Aucun concesionnaire n'est selectionné !", "ALERT", MessageBoxButtons.OK ,MessageBoxIcon.None);
        }


        //
        // DELETE A CONCESSIONNAIRE
        //
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            GPAddModif();
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce ceoncessionnaire ?", "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {                
                ListView.SelectedListViewItemCollection selectedLine = this.listViewConcess.SelectedItems;
                foreach (ListViewItem item in selectedLine)
                    currentID = int.Parse(item.SubItems[0].Text); // get id from selected line
                if (currentID != 0) // the if a line is selected ...
                {
                    Concessionnaire deleteConcess = new Concessionnaire();
                    foreach (Concessionnaire concess in lesConcessionnaires)
                    {
                        if (concess.Id == currentID) // get the right concess from selected ID
                            deleteConcess = concess;
                    }
                    try
                    {
                        deleteConcess.DeleteDB(); // delete from database
                    }
                    catch
                    {
                        MessageBox.Show("Imposible de supprimer le concessionnaire. Verifiez l'état du serveur et réessayez", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                else
                    MessageBox.Show("Aucun concesionnaire n'est selectionné !", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.None);
                ListFilling(cmbBoxNom.Text, cmbBoxVille.Text); // actualize the listView
            }
        }

        private void OccasAuto_Click(object sender, EventArgs e)
        {
            GPAddModif();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms) // Minimaze the application
                f.WindowState = FormWindowState.Minimized;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close
        }
    }
}
