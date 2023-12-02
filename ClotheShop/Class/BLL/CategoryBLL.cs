using ClotheShop.Class.DAO;
using ClotheShop.Class.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.BLL
{
    internal class CategoryBLL
    {
        private static CategoryBLL instance;
        public static CategoryBLL Instance
        {
            get
            {
                if (instance == null) 
                    return instance = new CategoryBLL();
                else return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public void getCategoryCombobox(ComboBox comboBox)
        {   DataTable dt= CategoryDAO.Instance.getCategoryCombobox();
            List<Category> datasource = new List<Category>();
            datasource.Add(new Category("", -1));
            foreach (DataRow dr in dt.Rows)
            {
                datasource.Add(new Category(dr));
            }
            comboBox.DataSource = datasource;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "ID";
        }

        internal DataTable GetDataTable()
        {
            return CategoryDAO.Instance.getDataTable();
        }
        internal DataTable GetDataTableSearched(string id, string name, bool inactiveChecked)
        {
            return CategoryDAO.Instance.GetDataTableSearched(id, name, inactiveChecked);
        }
        internal Category getCategoryById(int id)
        {
            return new Category(CategoryDAO.Instance.getCategoryById(id));
        }

        internal bool insertCate(string name)
        {
            return CategoryDAO.Instance.save(name);
        }

        internal bool UpdateCate(int id, int active, string name)
        {
            return CategoryDAO.Instance.update(name,active,id);
        }

        internal void Delete(int v)
        {
            CategoryDAO.Instance.Delete(v);
        }
    }
}
