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
    internal class RoleBLL
    {
        private static RoleBLL instance;
        public static RoleBLL Instance
        {
            get
            {
                if (instance == null)
                    return instance = new RoleBLL();
                else return RoleBLL.instance;
            }
            private set => RoleBLL.instance = value;
        }
        public void getRoleCombobox(ComboBox comboBox)
        {
            DataTable dt = RoleDAO.Instance.getRoleCombobox();
            List<Role> datasource = new List<Role>();
            datasource.Add(new Role("", -1));
            foreach (DataRow dr in dt.Rows)
            {
                datasource.Add(new Role(dr));
            }
            comboBox.DataSource = datasource;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "ID";
        }

        internal void getAuthorityByRole(int role, DataGridView DGV)
        {
            DGV.DataSource = RoleDAO.Instance.getAuthorityByRole(role);
        }

        internal DataTable GetDataTable()
        {
            return RoleDAO.Instance.getDatatable();
        }

        internal DataTable GetDataTableSearched(string id, string name, bool inactiveChecked)
        {
            return RoleDAO.Instance.GetDataTableSearched(id, name, inactiveChecked);
        }
        internal List<Role> GetListRole()
        {
            List<Role> list = new List<Role>();
            DataTable dt= RoleDAO.Instance.getDatatable();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Role(dr));
            }
            return list;


        }
        internal List<Role> GetOneRole(int id)
        {
            List<Role> list = new List<Role>();
            DataTable dt = RoleDAO.Instance.getRolebyId(id);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Role(dr));
            }
            return list;


        }

        internal Role getProductById(int id)
        {    
            return new Role(RoleDAO.Instance.getProductById(id).Rows[0]);
        }

        internal bool insertRole(string name)
        {
            return RoleDAO.Instance.save(name);
        }

        internal bool UpdateRole(int id, int active,string name)
        {
            return RoleDAO.Instance.update(id,active,name);

        }
    }
}
