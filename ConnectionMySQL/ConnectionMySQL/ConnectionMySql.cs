using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionMySQL
{
    public class CnxBDD
    {
        // VARIABLES
        private string server;
        private string database;
        private string username;
        private string password;

        private MySqlConnection cnx;
        private MySqlCommand cmd;
        private MySqlDataReader rd;

        //  CONSTRUCTORS 
        public CnxBDD()
        {
            this.Server = "localhost";
            this.Database = "database";
            this.Username = "root";
            this.Password = "root";
            this.cnx = new MySqlConnection();
            this.cmd = new MySqlCommand();
            this.rd = null;
        }

        // Main cnstructor
        public CnxBDD(string server, string database, string username, string password)
        {
            Server = server;
            Database = database;
            Username = username;
            Password = password;
            this.cnx = new MySqlConnection();
            this.cmd = new MySqlCommand();
            this.rd = null;
        }

        // Getters and Setters
        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }


        // Create SQL connection
        private MySqlConnection ConnectionOn()
        {
            cnx.ConnectionString = $"server={Server}; database={Database}; uid={Username}; password={Password}";
            cnx.Open();
            cmd.Connection = cnx;
            return cnx;
        }

        // Close the reader
        public void ReaderOff(){ rd.Close(); }
        // Close the connection        
        public void ConnectionOff(){ cnx.Close(); }

        // SQL mulitiple request (select a,b,c...)
        public MySqlDataReader RequeteReader(string req)
        {
            ConnectionOn();
            cmd.CommandText = req;
            rd = cmd.ExecuteReader();
            return rd;
        }

        // SQL  Non Query request ( insert / delete .... )
        public void RequeteNonQuery(string req)
        {
            ConnectionOn();
            cmd.CommandText = req;
            cmd.ExecuteNonQuery();
        }

        // SQL request (select a)
        public object RequeteScalar(string req)
        {
            ConnectionOn();
            cmd.CommandText = req;
            return cmd.ExecuteScalar();
        }
    }
}
