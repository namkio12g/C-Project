using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace ClotheShop.Class
{
    internal class DataProvider
    {
        private static DataProvider instance;
        private static MySqlConnection conn;
        public static DataProvider Instance
        {
            get { if (instance == null) return instance =new DataProvider(); else return DataProvider.instance; }
            private set => DataProvider.instance = value;
        }
        static string server = "127.0.0.1";
        static string Uid = "root";
        static string password = "namkio12g";
        static string nameDatabase = "clothe_database";
        public static MySqlConnection Conn
        {
            get {
                if (conn == null) return conn = new MySqlConnection($"server={server}; database={nameDatabase}; Uid={Uid}; password={password};"); else return DataProvider.conn; }
            set => DataProvider.conn = value;
        }

        public DataTable ExecuteQuery(string sql, Object[] objs = null)
        {
            DataTable data = new DataTable();
            using (DataProvider.Conn)
            {
                DataProvider.Conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                cmd.CommandType = CommandType.Text;
                if (objs != null)
                {
                    string[] listpara = sql.Split(' ');
                    int i = 0;
                    foreach (string paraName in listpara) {

                        if (paraName.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(paraName, objs[i++]);
                        }
                    }
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


                DataProvider.Conn.Close();
                
                
                
                adapter.Fill(data);

            }
            return data;
        }
        public bool ExcuteNonQuery(string sql, Object[] objs=null )

        {
            bool status = false;


            using (DataProvider.Conn) 
            {
                DataProvider.Conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                cmd.CommandType = CommandType.Text;
                if (objs != null)
                {
                    string[] listpara = sql.Split(' ');
                    int i = 0;
                    foreach (string paraName in listpara)
                    {

                        if (paraName.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(paraName, objs[i++]);
                        }
                    }
                }
                cmd.CommandText = sql;
                status=(cmd.ExecuteNonQuery()>0);

                DataProvider.conn.Close();
            }
            return status;

        }
        public int ExecuteScalar(string sql, Object[] objs = null)
        {
            int number = -1;

            using (DataProvider.Conn) {
                DataProvider.Conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                cmd.CommandType=CommandType.Text;
                if (objs != null)
                {
                    string[] listpara = sql.Split(' ');
                    int i = 0;
                    foreach (string paraName in listpara)
                    {

                        if (paraName.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(paraName, objs[i++]);
                        }
                    }
                }
                object result= cmd.ExecuteScalar();
                if (result == null)
                {
                    DataProvider.Conn.Close();

                    return number;
                }
                number = Convert.ToInt32(result);
                DataProvider.Conn.Close();


            }

            return number;
        }
        public int ExecuteUpdate(string sql, Object[] objs = null)
        {
            int number = -1;

            using (DataProvider.Conn)
            {
                DataProvider.Conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                cmd.CommandType = CommandType.Text;
                if (objs != null)
                {
                    string[] listpara = sql.Split(' ');
                    int i = 0;
                    foreach (string paraName in listpara)
                    {

                        if (paraName.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(paraName, objs[i++]);
                        }
                    }
                }
                object result = cmd.ExecuteNonQuery();
                if (result == null)
                {
                    DataProvider.Conn.Close();

                    return number;
                }
                number = Convert.ToInt32(result);
                DataProvider.Conn.Close();


            }

            return number;
        }
        public int ExecuteInsertGetID(string sql, Object[] objs = null)
        {
            int number = -1;

            using (DataProvider.Conn)
            {
                DataProvider.Conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                cmd.CommandType = CommandType.Text;
                if (objs != null)
                {
                    string[] listpara = sql.Split(' ');
                    int i = 0;
                    foreach (string paraName in listpara)
                    {

                        if (paraName.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(paraName, objs[i++]);
                        }
                    }
                }
                object result = cmd.ExecuteNonQuery();
                number = Convert.ToInt32(cmd.LastInsertedId);
                DataProvider.Conn.Close();
            }
            return number;
        }
    }

}
