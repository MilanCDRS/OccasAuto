using ConnectionMySQL;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Serialiser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DllOccasAuto
{
    public class Utilisateur
    {
        private int identifiant;
        private string login;
        private string mdp;

        private CnxBDD cnx = new CnxBDD();

        public Utilisateur()
        {
            Utilisateur.GetCNXBDD();
        }

        public Utilisateur(int identifiant, string login, string mdp)
        {
            Identifiant = identifiant;
            Login = login;
            MDP = mdp;
            Utilisateur.GetCNXBDD();
        }

        public int Identifiant { get => identifiant; set => identifiant = value; }
        public string Login { get => login; set => login = value; }
        public string MDP { get => mdp; set => mdp = value; }

        public static void GetCNXBDD()
        {
            Dictionary<string, string> dico = (Dictionary<string, string>)Serialise.Recup("CNXBDD.TXT");
            dico.TryGetValue("serveur", out Utilisateur.cnx.Serveur);
            dico.TryGetValue("database", out Utilisateur.cnx.Database);
            dico.TryGetValue("username", out Utilisateur.cnx.Username);
            dico.TryGetValue("password", out Utilisateur.cnx.Password);
        }

        // get all the users from the database
        public static List<Utilisateur> GetUtilisateurs() {
            Utilisateur.GetCNXBDD();
            List<Utilisateur> utilisateurs = new List<Utilisateur>();

            //CnxBDD cnx = new CnxBDD("localhost", "bdoccasauto", "root", "root");
            string req = "SELECT identifiant, login, mdp FROM utilisateur";

            MySqlDataReader rd = Utilisateur.cnx.RequeteReader(req);
            while (rd.Read())
            {
                utilisateurs.Add(new Utilisateur((int)rd["identifiant"], rd["login"].ToString(), rd["mdp"].ToString()));
            }
            Utilisateur.cnx.ConnectionOff();
            return utilisateurs;
        }

        // tests if user exists
        public static bool Existe(string login)
        {
            List<Utilisateur> utilisateurs = GetUtilisateurs();
            bool existe = false;
            int i = 0;
            while (!existe && i<utilisateurs.Count())
            {
                if (utilisateurs[i].Login == login)
                    existe = true;
                else
                    i++;
            }
            return existe;
        }

        // Insert a new user in the DB
        public static void InsertUser(string login, string mdp) {
            Utilisateur.GetCNXBDD();
            if (!Existe(login))
            {
                //CnxBDD cnx = new CnxBDD("localhost", "bdoccasauto", "root", "root");
                string req = $"INSERT INTO utilisateur (login, mdp) VALUES ('{login}','{mdp}')";
                Utilisateur.cnx.RequeteNonQuery(req);
            }
        }
    }
}
