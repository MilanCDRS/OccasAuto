﻿using ConnectionMySQL;
using Serialiser;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialiser;
using MySql.Data.MySqlClient;

namespace OccasDLL
{
    public class Concessionnaire
    {
        //VARIABLES 
        private int id;
        private string nom;
        private string prenom;
        private string adresse;
        private string cp;
        private string ville;

        private static CnxBDD cnxBDD = new CnxBDD();

        public Concessionnaire(int id, string nom, string prenom, string adresse, string cp, string ville)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adresse = adresse;
            this.CP = cp;
            this.Ville = ville;
            Concessionnaire.GetCNXBDD();
        }

        public Concessionnaire(string nom, string prenom, string adresse, string cp, string ville)
        {
            this.Id = 1000;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adresse = adresse;
            this.CP = cp;
            this.Ville = ville;
            Concessionnaire.GetCNXBDD();
        }

        public Concessionnaire()
        {
            Concessionnaire.GetCNXBDD();
        }

        public static void GetCNXBDD()
        {
            string s = "";
            string d = "";
            string u = "";
            string p = "";

            Dictionary<string, string> dico = (Dictionary<string, string>)Serialise.Recup("CNXBDD.TXT");
            if (dico is Dictionary<string, string>)
            {
                dico.TryGetValue("serveur", out s);
                dico.TryGetValue("database", out d);
                dico.TryGetValue("username", out u);
                dico.TryGetValue("password", out p);
            }

            Concessionnaire.cnxBDD.Server = s;
            Concessionnaire.cnxBDD.Database = d;
            Concessionnaire.cnxBDD.Username = u;
            Concessionnaire.cnxBDD.Password = p;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string CP { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }

        // Get all the concessionnaires from the SQL Database according to the parameters "nom" and "ville"
        // If the parametres are empty, Then, all the concesionnaires are recovered
        public static List<Concessionnaire> Recherche(string nom, string ville)
        {
            Concessionnaire.GetCNXBDD();
            List<Concessionnaire> concessionnaires = new List<Concessionnaire>();   // New List
            string req = "SELECT id, nom, prenom, adresse, cp, ville " +         // SQL Request
                            "FROM concessionnaire " +
                            $"WHERE ville like '%{ville}'" +
            $"AND nom like '%{nom}'";

            MySqlDataReader rd = Concessionnaire.cnxBDD.RequeteReader(req);    // request execution
            while (rd.Read())
            {       // adding each recovered concessionnaire to the list
                concessionnaires.Add(new Concessionnaire((int)rd["id"], rd["nom"].ToString(), rd["prenom"].ToString(), rd["adresse"].ToString(), rd["cp"].ToString(), rd["ville"].ToString()));
            }
            cnxBDD.ConnectionOff();    //Close connection
            cnxBDD.ReaderOff();        //Close reader
            return concessionnaires;
        }

        // Add a new concessionnaire to the BD 
        // unConcessionnaire.AddDB();
        public void AddDB()
        {
            Concessionnaire.GetCNXBDD();
            cnxBDD.RequeteNonQuery($"INSERT INTO concessionnaire (nom, prenom, adresse, cp, ville) VALUES ('{Nom}','{Prenom}','{Adresse}','{CP}','{Ville}')");
            cnxBDD.ConnectionOff();
        }

        public void UpdateDB()
        {
            Concessionnaire.GetCNXBDD();
            cnxBDD.RequeteNonQuery($"UPDATE concessionnaire " +
                                $"SET nom = '{Nom}', " +
                                $"prenom = '{Prenom}', " +
                                $"adresse = '{Adresse}', " +
                                $"cp = '{CP}', " +
                                $"ville = '{Ville}' " +
                                $"WHERE id= {Id};");
            cnxBDD.ConnectionOff();
        }

        // Delete a concesionnaire from the DB tthanks to its id
        public void DeleteDB()
        {
            Concessionnaire.GetCNXBDD();
            cnxBDD.RequeteNonQuery($"DELETE FROM concessionnaire WHERE id = {Id}");
            cnxBDD.ConnectionOff();
        }

    }
}
