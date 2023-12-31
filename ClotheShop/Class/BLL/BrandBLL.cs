﻿using ClotheShop.Class.DAO;
using ClotheShop.Class.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.BLL
{
    internal class BrandBLL
    {
        private static BrandBLL instance;

        public static BrandBLL Instance
        {
            get
            {
                if(instance == null)
                    return instance = new BrandBLL();
                else
                    return instance;
            }
            set => instance = value;
        }
        public void loadBrandCombobox(ComboBox comboBox)
        {   DataTable dt= BrandDAO.Instance.getBrandCombobox();
            List<Brand> datasource= new List<Brand>();
            datasource.Add(new Brand("", -1));
            foreach (DataRow dr in dt.Rows)
            {
                datasource.Add(new Brand(dr));
            }
            comboBox.DataSource = datasource;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
        }

        internal void Delete(int v)
        {
            BrandDAO.Instance.Delete(v);
        }

        internal Brand getCategoryById(int id)
        {
            return new Brand(BrandDAO.Instance.getBrandById(id));
        }

        internal DataTable GetDataTable(DataGridView dgv)
        {
           return BrandDAO.Instance.GetDataTable();
        }

        internal DataTable GetDataTableSearched( string id, string name, bool inactiveChecked)
        {
            return BrandDAO.Instance.GetDataTableSearched(id, name, inactiveChecked);
        }

        internal bool insertBrand(string name)
        {
            return BrandDAO.Instance.save(name);
        }

        internal bool UpdateBrand(int id, int active, string name)
        {
            return BrandDAO.Instance.update(id,name,active);
        }
    }
}
