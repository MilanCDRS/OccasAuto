using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DllOccasAuto;

namespace OccasAuto
{
    public partial class Connexion : Form
    {
        List<Utilisateur> utilisateurs = new List<Utilisateur>();
        private bool connexion = true; //Incription ou Connexion ?
        public Connexion()
        {
            InitializeComponent();
            VoirMDP();
            lblErr.Text = "";
        }
                
        // Switch between sing in or login 
        private void lblCnxInscr_Click(object sender, EventArgs e)
        {
            lblErr.Text = "";
            if (connexion)
            {
                lblMDP2.Show();
                txtMDP2.Show();
                lblCnxInscr.Text = "Déjà inscrit ? Connectez vous !";
                connexion = false;
            }
            else {
                lblMDP2.Hide();
                txtMDP2.Hide();
                lblCnxInscr.Text = "Nouvel utilisateur ? Créez un compte !";
                connexion = true;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (connexion) Cnx();
            else Inscr();
        }


        // Connection function
        // try to login 
        private void Cnx()
        {
            lblErr.Text = "";
            try // Is database responding ?
            {
                List<Utilisateur> utilisateurs = Utilisateur.GetUtilisateurs(); // Get All users
                foreach (Utilisateur user in utilisateurs)
                {
                    if (user.Login == txtIdent.Text) 
                    {
                        if (user.MDP == Hash(txtMDP.Text)) // compare psw to hashed pasword in BD
                        {
                            OccasAuto oa = new OccasAuto(user.Login);
                            oa.Show();
                            this.Hide();
                        }
                    }
                }
                lblErr.Text = "Veuillez vérifiez vos informations de connexion.";
            }
            catch
            {
                lblErr.Text = "Connexion impossible à la base de données.";
            }
        }


        private void Inscr() {
            lblErr.Text = "";
            try // database responding ?
            {
                List<Utilisateur> utilisateurs = Utilisateur.GetUtilisateurs();
                if (txtIdent.Text != string.Empty) 
                {
                    if (testMDP()) // string password
                    {
                        if (!Utilisateur.Existe(txtIdent.Text)) // do not create a new user if it already exists
                        {
                            if (txtMDP.Text == txtMDP2.Text) // same password and confirmation
                            {
                                try
                                {
                                    Utilisateur.InsertUser(txtIdent.Text, Hash(txtMDP.Text)); // insert new user in DB
                                    OccasAuto oa = new OccasAuto(txtIdent.Text); // open OccasAuto Form
                                    oa.Show();
                                    this.Hide();
                                }
                                catch { lblErr.Text = "Erreur lors de la création du nouvel utilisateur."; }
                            }
                            else lblErr.Text = "Les mots de passe ne sont pas identiques.";                             
                        }
                        else lblErr.Text = "Cet utilisateur existe déjà.";
                    }
                    else lblErr.Text = "Veuillez entrer un mot de passe valide.\nMajuscule / chiffre / caractère spécial";
                }
                else lblErr.Text = "Remplissez tous les champs.";
            }
            catch
            {
                lblErr.Text = "Connexion impossible à la base de données.";             
            }
        }

        // Password Must contains at least one Maj, one number and one special caract
        private bool testMDP()
        {
            bool mdp = false;
            if(txtMDP.TextLength >= 12)
            {
                bool num = false;
                bool maj = false;
                bool spe = false;
                string nums = "0123456789";
                string alphMaj = "ABCDEFGHJIKLMNOPQRSTUVWXYZ";
                string cSpeciaux = "!?§!:;,%£$¤&~#'{([-|_^@°)]+=}/*-+.€";
                foreach (char c in txtMDP.Text)
                {
                    if (nums.Contains(c))
                        num = true;
                    if (alphMaj.Contains(c))
                        maj = true;
                    if (cSpeciaux.Contains(c))
                        spe = true;
                }
                if (num && maj && spe)
                    mdp = true;
            }
            return mdp;
        }

        // Allow to Hash a password with md5 algorithm
        private string Hash(string mdp)
        {
            var md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(mdp));
            var newMDP = new StringBuilder();
            for(int i =0; i < bytes.Length; i++)
            {
                newMDP.Append(bytes[i].ToString("x2"));
            }
            return newMDP.ToString();
        }

        private void BtnSeePSW_Click(object sender, EventArgs e)
        {
            VoirMDP();
        }

        // Hide of Show the password
        private void VoirMDP()
        {
            if(txtMDP.UseSystemPasswordChar)
            {
                txtMDP.UseSystemPasswordChar = false;
                txtMDP2.UseSystemPasswordChar = false;
            }
            else
            {
                txtMDP.UseSystemPasswordChar = true;
                txtMDP2.UseSystemPasswordChar = true;
            }
        }

        private void txtMDP2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnValider_Click(sender, e);
        }

        private void txtMDP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && connexion)
                btnValider_Click(sender, e);
        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gpParamBDD_Enter(object sender, EventArgs e)
        {

        }

        private void btnCloseParamBDD_Click(object sender, EventArgs e)
        {
            gpParamBDD.Visible = false;
            gpParamBDD.Enabled = false;
        }

        private void btnParam_Click(object sender, EventArgs e)
        {
            gpParamBDD.Visible = true;
            gpParamBDD.Enabled = true;
        }
    }
}
