using ClotheShop.Class.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DTO
{
    internal class Account
    { 

     
            private int ID;
            private int ID_user;

            private string Password;
            private string userAccount;
            private string UserName;
            private DateTime Date_created;
            private DateTime Date_Edited;
            private DateTime Last_login;
        private int active;

            public Account( string userName, string password)
            {
         
                UserName1 = userName;
                Password1 = password;
            }
        public Account()
        {
        }
   
        public Account(DataRow data)
        {
            ID = (int)data["ID"];
            if (data.Table.Columns.Contains("name"))
            {
                userAccount = data["name"].ToString();
            }
             UserName = data["username"].ToString();
            if (data.Table.Columns.Contains("id_user"))
            {
                ID_user = (int)data["id_user"];

            }
            if (data.Table.Columns.Contains("password"))
            {
                Password1 = data["password"].ToString();

            }
            Date_created = (DateTime)data["date_created"];
            Date_Edited = (DateTime)data["date_edited"];

            Last_login = (DateTime)data["last_login"];
            active = (int)data["active"];
            

        }

        public Account(int iD, int iD_user, string userName, string password, DateTime date_created, DateTime date_Edited, DateTime last_login)
        {
            ID = iD;
            ID_user = iD_user;
            UserName = userName;
            Password = password;
            Date_created = date_created;
            Date_Edited = date_Edited;
            Last_login = last_login;
        }

        public Account(int id_user, string userName)
        {
            this.ID_user1= id_user;
            UserName = userName;
        }

        public int ID1
            {
                get => ID;
                set => ID = value;
            }
            public int ID_user1
            {
                get => ID_user;
                set => ID_user = value;
            }
            public string UserName1
            {
                get => UserName;
                set => UserName = value;
            }
            public string Password1
            {
                get => Password;
                set => Password = value;
            }
            public DateTime Date_created1
            {
                get => Date_created;
                set => Date_created = value;
            }
            public DateTime Date_Edited1
            {
                get => Date_Edited;
                set => Date_Edited = value;
            }
            public DateTime Last_login1
            {
                get => Last_login;
                set => Last_login = value;
            }
        public string UserAccount
        {
            get => userAccount;
            set => userAccount = value;
        }
        public int Active
        {
            get => active;
            set => active = value;
        }
    }
    }

