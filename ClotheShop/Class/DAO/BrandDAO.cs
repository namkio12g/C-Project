using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DAO
{
    internal class BrandDAO
    {
        private static BrandDAO instance;
        public static BrandDAO Instance
        {
        
        get
            {
                if (instance == null)
                    return instance = new BrandDAO();
                else return instance;
            }
        set
            {
            instance = value; }
        }
        public DataTable getBrandCombobox()
        {
            string sql = "SELECT CONCAT(id, ' - ', name) AS Name,id,Active FROM brand WHERE active = 1 ";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        internal void Delete(int id)
        {
            string sql = "UPDATE brand SET active = 0  WHERE id= @id ";
            DataProvider.Instance.ExecuteScalar(sql, new Object[] { id });
        }
        internal DataRow getBrandById(int id)
        {
            string sql = "SELECT * FROM Brand WHERE id = @id ";
            return DataProvider.Instance.ExecuteQuery(sql,new object[] {id}).Rows[0];
        }

        internal DataTable GetDataTable()
        {
            string sql = "SELECT * FROM Brand WHERE active =1";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        internal DataTable GetDataTableSearched(string id, string name, bool inactiveChecked)
        {   List<object> list = new List<object>();
            string sql = "SELECT * FROM Brand WHERE 1=1";
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
                return DataProvider.Instance.ExecuteQuery(sql,list.ToArray());

        }

        internal bool save(string name)
        {
            string sql = "INSERT INTO brand (name) VALUES ( @name ) ";
            return DataProvider.Instance.ExecuteInsertGetID(sql, new Object[] { name}) > -1;
        }

        internal bool update(int id, string name, int active)
        {
            string sql = "UPDATE brand SET name= @name ,active = @active WHERE id= @id ";
            return DataProvider.Instance.ExcuteNonQuery(sql, new Object[] { name, active, id }) ;
        }
    }
}
