using ConnectionMySQL;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllOccasAuto
{
    public class Utilisateur
    {
        private int identifiant;
        private string login;
        private string mdp;

        private static CnxBDD cnx = new CnxBDD("localhost", "bdoccasauto", "root", "root");

        public Utilisateur()
        {
        }

        public Utilisateur(int identifiant, string login, string mdp)
        {
            Identifiant = identifiant;
            Login = login;
            MDP = mdp;
        }

        public int Identifiant { get => identifiant; set => identifiant = value; }
        public string Login { get => login; set => login = value; }
        public string MDP { get => mdp; set => mdp = value; }

        // get all the users from the database
        public static List<Utilisateur> GetUtilisateurs() { 
            List<Utilisateur> utilisateurs = new List<Utilisateur>();

            //CnxBDD cnx = new CnxBDD("localhost", "bdoccasauto", "root", "root");
            string req = "SELECT identifiant, login, mdp FROM utilisateur";

            MySqlDataReader rd = cnx.RequeteReader(req);
            while (rd.Read())
            {
                utilisateurs.Add(new Utilisateur((int)rd["identifiant"], rd["login"].ToString(), rd["mdp"].ToString())); ; ;
            }
            cnx.ConnectionOff();
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
            if (!Existe(login))
            {
                //CnxBDD cnx = new CnxBDD("localhost", "bdoccasauto", "root", "root");
                string req = $"INSERT INTO utilisateur (login, mdp) VALUES ('{login}','{mdp}')";
                cnx.RequeteNonQuery(req);
            }
        }
    }
}
