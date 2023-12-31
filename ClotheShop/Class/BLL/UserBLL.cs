﻿using ClotheShop.Class.DAO;
using ClotheShop.Class.DTO;
using ClotheShop.CustomControl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClotheShop.Class.BLL
{
    internal class UserBLL
    {
        private static UserBLL instance;
        public static UserBLL Instance
        {
            get
            {
                if (instance == null)
                    return instance = new UserBLL();
                else return UserBLL.instance;
            }
            private set => UserBLL.instance = value;
        }

        internal int CheckActiveUser(int iD_user1)
        {
            return UserDAO.Instance.CheckActiveUser(iD_user1);
        }

        internal bool EditUser(string idString, string name, string address, CustomTextBox phoneDetail, CustomTextBox cCCDDetail, CustomTextBox emailDetail, object selectedValue,string active)
        {
            string phone = phoneDetail.Texts;
            string cccd = cCCDDetail.Texts;
            string email = emailDetail.Texts;
            string role = selectedValue.ToString();

                        return UserDAO.Instance.Edit(new User(Convert.ToInt32(idString),name, address, phone, email, cccd, Convert.ToInt32(role), Convert.ToInt32(active)));
                    
                
            
        }

        internal void getCombobox(ComboBox comboBox)
        {
            DataTable dt = UserDAO.Instance.getUserCombobox();
            List<User> datasource = new List<User>();
            datasource.Add(new User("",-1));
            foreach (DataRow dr in dt.Rows)
            {
                datasource.Add(new User( dr["name"].ToString(),(int)dr["id"]));
            }
            comboBox.DataSource = datasource;
            comboBox.DisplayMember = "Name1";
            comboBox.ValueMember = "Id";
        }

        internal DataTable GetDataTableSearched(DataGridView DGV,string id, string name, string address, string phone, string email, string cccd, int role,bool inactiveChecked)
        {   User user=new User(name,address,phone,email,cccd);
            user.RoleID = role;
            user.Id = -1;
            if(id != "")
            {
                user.Id=Convert.ToInt32(id);
            }
            return UserDAO.Instance.GetDataTableSearched(user,inactiveChecked);
        }

        internal DataTable getDataView()
        {
            return UserDAO.Instance.getDataTable();
           
        }

        internal User getUserById(int id)
        {
            User user = UserDAO.Instance.GetDataById(id);
            return user;
        }

        internal void GetUserListByRole(int role, DataGridView DGV)
        {
            DGV.DataSource = UserDAO.Instance.GetUserListByRole(role);
        }

        internal bool SaveUser(string name, string address, CustomTextBox phoneDetail, CustomTextBox cCCDDetail, CustomTextBox emailDetail)
        {
           
            string phone = phoneDetail.Texts;
            string cccd=cCCDDetail.Texts;
            string email = emailDetail.Texts;

           
                    
            return UserDAO.Instance.Save(new User(name, address, phone, email, cccd));
                   
                
            
        }
    }
}
