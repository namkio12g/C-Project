using ClotheShop.Class.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DAO
{
    internal class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                    return instance = new UserDAO();
                else return UserDAO.instance;
            }
            private set => UserDAO.instance = value;
        }

        internal bool Edit(User user)
        {
            string sql = "UPDATE user Set name = @name ,address = @address ,phone = @phone ,email = @email ,cccd = @cccd ,role = @role ,active= @active WHERE id= @id AND id <> 0 ";
            return DataProvider.Instance.ExecuteScalar(sql, new Object[] {
                user.Name1,user.Address1,user.Phone1,user.Email1,user.CCCD1,user.RoleID,user.Active,user.Id
            }) > -1;
        }

        internal DataTable getUserCombobox()
        { string sql = "SELECT id,name FROM user WHERE active =1";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        internal User GetDataById( int id)
        {
            string sql = "SELECT u.ID,u.Name,u.Phone,u.Address,u.Email,u.CCCD,r.name AS Role,u.active FROM user AS u INNER JOIN  role AS r ON r.id = u.role WHERE u.id = @id AND u.id <> 0";
            return new User((DataProvider.Instance.ExecuteQuery(sql, new object[] { id }).Rows[0]));
        }

        internal DataTable getDataTable()
        {   string sql = "SELECT u.ID,u.Name,u.Phone,u.Address,u.Email,u.CCCD,r.name AS Role FROM user AS u INNER JOIN  role AS r ON r.id = u.role WHERE u.active=1 AND u.id <> 0";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        internal DataTable GetDataTableSearched(User user, bool inactiveChecked)
        {    
            string sql = "SELECT u.ID,u.Name,u.Phone,u.Address,u.Email,u.CCCD,r.name AS Role FROM user AS u INNER JOIN  role AS r ON r.id = u.role WHERE 1=1 AND u.id <> 0";
            List<Object> list= new List<Object>();
            if (user.Name1 != "")
            {
                sql += " AND u.name LIKE @name";
                user.Name1="%"+user.Name1+"%";
                list.Add(user.Name1);
            }
            if (user.Phone1 != "")
            {
                sql += " AND u.phone LIKE @p ";
                user.Phone1 = "%" + user.Phone1+"%";
                list.Add(user.Phone1);
            }
            if(user.Email1 != "")
            {
                sql += " AND u.email LIKE @e ";
                user.Email1= "%" + user.Email1+"%";
                list.Add(user.Email1);
            }
            if (user.CCCD1 != "")
            {
                sql += " AND u.cccd LIKE @cc ";
                user.CCCD1= "%" + user.CCCD1+"%";
                list.Add(user.CCCD1);
                
            }
            if (user.Address1 != "")
            {
                sql += " AND u.address LIKE @address ";
                user.Address1 = "%" + user.Address1 + "%";
                list.Add(user.Address1);

            }
            if (user.RoleID > -1)
            {
                sql += " AND u.role = @r ";
                list.Add(user.RoleID);
            }
            if(user.Id > -1)
            {
                sql += " AND u.id = @id ";
                list.Add(user.Id);
            }
            if (!inactiveChecked)
            {
                sql += " AND u.active =1 ";
            }
            return DataProvider.Instance.ExecuteQuery(sql,list.ToArray());
        
        }

        internal DataTable GetUserListByRole(int role)
        {
            string sql = "SELECT name FROM user WHERE role = @role AND id <> 0";
            return DataProvider.Instance.ExecuteQuery(sql, new object[] { role }); ;
        }

        internal bool Save(User user)
        {
            String sql = "INSERT INTO user (name,phone,address,email,cccd) VALUES ( @name, @phone , @address , @email , @cccd)";
            return DataProvider.Instance.ExecuteScalar(sql, new Object[] {
                user.Name1,user.Phone1,user.Address1,user.Email1,user.CCCD1
            }) > -1;
        }

        internal int CheckActiveUser(int iD_user1)
        {
            String sql = "SELECT role FROM user WHERE id= @id AND active =1 ";
            return DataProvider.Instance.ExecuteScalar(sql, new Object[] {
                iD_user1
            });
        }
    }
}
