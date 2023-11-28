using ClotheShop.Class.DTO;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClotheShop.Class.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                return instance=new AccountDAO(); else return AccountDAO.instance;
            }
            private set => AccountDAO.instance = value;
        }
        public DataTable login(string username, string password)
        {
            string sql = "SELECT * FROM account WHERE UserName = @username AND Password = @password AND Active = 1;";

            return DataProvider.Instance.ExecuteQuery(sql,new Object[]{username,password});
        }
        public bool register(string username, string password,string name,string phone,string email)
        {
            string sql = "INSERT INTO user (Name,Phone,Email) VALUES ( @name , @phone , @email)";

            int IDInserted=DataProvider.Instance.ExecuteInsertGetID(sql,new Object[]{name,phone,email});
            DateTime dateCreate=DateTime.Now;
            string sql2 = "INSERT INTO account (ID_user,UserName,Password,Date_Created) VALUES ( @IDUser , @username , @password , @dateCreated )";
            return DataProvider.Instance.ExecuteScalar(sql2, new Object[] {IDInserted, username, password, dateCreate })>-1;

        }

        internal bool checkUserName(string username)
        {
            string sql = "SELECT id FROM Account WHERE username= @username ";
            return DataProvider.Instance.ExecuteScalar(sql, new Object[] { username }) > -1;
        }

        internal DataTable GetAccountListByIdUserId(int id)
        {
            string sql = "SELECT username FROM Account WHERE ID_User = @id ";
            return DataProvider.Instance.ExecuteQuery(sql,new object[] {id});
        }

        internal DataTable GetById(int id)
        {
            string sql = "SELECT a.ID,a.username,a.active,a.last_login,u.name AS name,a.date_created,a.date_edited,a.active,a.password FROM account AS a INNER JOIN  user AS u ON a.ID_user = u.ID WHERE a.id= @id AND a.id <> 0";
            return DataProvider.Instance.ExecuteQuery(sql,new Object[] {id});
        }

        internal DataTable GetDataTable()
        {
            string sql = "SELECT a.ID,a.username,a.active,a.last_login,u.name AS name FROM account AS a INNER JOIN  user AS u ON a.ID_user = u.ID WHERE  a.id <> 0";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        internal DataTable GetDataTableSearch(int id, string username, string useraccount, string timeTop, string timeBot, bool inactiveChecked)
        {   List<Object> list = new List<Object>();
            string sql = "SELECT a.ID,a.username,a.active,a.last_login,u.name AS name,a.active FROM account AS a INNER JOIN  user AS u ON a.ID_user = u.ID WHERE 1=1 AND a.id <> 0 ";
            if (id!= -1){
                sql += " AND a.ID = @id";
                list.Add(id);
            }
            if (username != "") {
                sql += " AND a.username LIKE @un ";
                list.Add(("%" + username + "%"));
            }
            if(useraccount != "")
            {
                sql += " AND u.name LIKE @u ";
                list.Add(("%" + useraccount + "%"));
            }
            if (timeTop != "")
            {
                sql += " AND a.date_created <= @topT AND a.date_created >= @botT ";
                list.Add(timeTop);
                list.Add(timeBot);
            }
            if(!inactiveChecked)
            {
                sql += " a.active=1 ";
            }
            return DataProvider.Instance.ExecuteQuery(sql, list.ToArray());
        }

      
        internal bool Save(Account acc)
        {
            string sql2 = "INSERT INTO account (ID_user,UserName,Password,Date_Created,last_login,date_edited,active) VALUES ( @IDUser , @username , @password , @dateCreated , @ll , @de ,1)";
            return DataProvider.Instance.ExecuteScalar(sql2, new Object[] { acc.ID_user1, acc.UserName1, acc.Password1,DateTime.Now, DateTime.Now, DateTime.Now }) > -1;
        }

        internal bool Update(Account acc)
        {
            string sql = "UPDATE account SET username= @username ,active = @active ,date_edited= @de WHERE id = @id";
            return DataProvider.Instance.ExecuteScalar(sql, new Object[] {  acc.UserName1,acc.Active, DateTime.Now,acc.ID1}) > -1;

        }
        internal void UpdateLoginDate(int id)
        {
            string sql = "UPDATE account SET last_login= @last_login WHERE id = @id";
            DataProvider.Instance.ExecuteScalar(sql, new Object[] { DateTime.Now, id });
        }

        internal void updatePassword(int iD1, string texts)
        {
            string sql = "UPDATE account SET password= @pass WHERE id = @id";
            DataProvider.Instance.ExecuteScalar(sql, new Object[] { texts,iD1 });
        }
    }
}
