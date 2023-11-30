using ClotheShop.Class.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DAO
{
    internal class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                    return instance = new CategoryDAO();
                else return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DataTable getCategoryCombobox()
        {
            string sql = "SELECT * FROM Category";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        internal DataRow getCategoryById(int id)
        {
            string sql = "SELECT * FROM category WHERE id= @id ";
            return DataProvider.Instance.ExecuteQuery(sql,new Object[] { id }).Rows[0];
        }

        internal DataTable getDataTable()
        {
            string sql = "SELECT * FROM Category WHERE active =1";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        internal bool save(string name)
        {
            string sql = "INSERT INTO category (name) VALUES ( @name )";
            return DataProvider.Instance.ExecuteInsertGetID(sql, new Object[] { name })>-1;

        }

        internal bool update(string name,int active,int id)
        {
            string sql = "UPDATE category SET name= @name ,active = @active WHERE id= @id ";
            return DataProvider.Instance.ExcuteNonQuery(sql, new Object[] { name,active,id });
        }
        internal DataTable GetDataTableSearched(string id, string name, bool inactiveChecked)
        {
            List<object> list = new List<object>();
            string sql = "SELECT * FROM Category WHERE 1=1";
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
    }
}
