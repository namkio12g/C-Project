using ClotheShop.Class.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DAO
{
    internal class RoleDAO
    {
        private static RoleDAO instance;
        public static RoleDAO Instance
        {
            get
            {
                if (instance == null)
                    return instance = new RoleDAO();
                else return RoleDAO.instance;
            }
            private set => RoleDAO.instance = value;
        }

        internal DataTable getAuthorityByRole(int role)
        {
            string sql = "SELECT a.name AS Action_Name FROM authority_detail AS ad INNER JOIN authority AS a ON ad.id_authority = a.id WHERE ad.id_role = @role ";
            return DataProvider.Instance.ExecuteQuery(sql , new object[] { role });
        }
        internal DataTable GetDataTableSearched(string id, string name, bool inactiveChecked)
        {
            List<object> list = new List<object>();
            string sql = "SELECT * FROM role WHERE 1=1 AND id <> 0";
            if (id != "")
            {
                list.Add(Convert.ToInt32(id));
                sql += " AND id= @id ";
            }
            if (name != "")
            {
                sql += " AND name LIKE @name";
                name = "%" + name + "%";
                list.Add(name);
            }
            if (!inactiveChecked)
            {
                sql += " AND active = 1 ";
            }
            return DataProvider.Instance.ExecuteQuery(sql, list.ToArray());

        }
        internal DataTable getRoleCombobox()
        {
            string sql = "SELECT * FROM role WHERE active =1 AND id <> 0";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        internal DataTable getDatatable()
        {
            string sql = " SELECT * FROM role  WHERE active =1 AND id <> 0";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        internal DataTable getRolebyId(int id)
        {
            string sql = " SELECT * FROM role WHERE id = @id AND id <> 0";
            return DataProvider.Instance.ExecuteQuery(sql,new Object[] {id});
        }

        internal DataTable getProductById(int id)
        {
            string sql = "SELECT * FROM role WHERE id= @id AND id <> 0";
            return DataProvider.Instance.ExecuteQuery(sql, new object[] { id });
        }

        internal bool save(string name)
        {
            string sql2 = "INSERT INTO role (name) VALUES ( @name )";
            return DataProvider.Instance.ExecuteInsertGetID(sql2, new Object[] { name }) > -1;
        }

        internal bool update(int id, int active,string name)
        {
            string sql = "UPDATE role SET name= @name ,active = @active  WHERE id = @id";
            return DataProvider.Instance.ExcuteNonQuery(sql, new Object[] { name,active,id }) ;
        }
    }
}
