using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClotheShop.Class
{
    internal class ConnectionDb
    {
       private static MySqlConnection connection=new MySqlConnection();
    
        public static MySqlConnection dataSource()
        {    string server = "127.0.0.1";
             string Uid = "root";
             string password = "namkio12g";
             string nameDatabase = "clothe_database";
            connection = new MySqlConnection($"server={server}; database={nameDatabase}; Uid={Uid}; password={password};");
            return connection;
        }
        public void OpenDB()
        {
            dataSource();
            connection.Open();
        }
        private static ConnectionDb instance;

        public static ConnectionDb Instance
        {
            get
            {
                if (instance == null)
                {
                    return new ConnectionDb();
                }
                else
                {
                    return instance;
                }
            }
            private set => instance = value;
        }

        public static MySqlConnection Connection
        {
            get => connection;
            private set => connection = value;
        }

        public void CloseDB()
        {
            Connection.Close();
        }
    }
}
