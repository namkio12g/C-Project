using ClotheShop.Class.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using ClotheShop.CustomControl;
using ClotheShop.Class.DTO;
using static ClotheShop.Class.DTO.User;
using static ClotheShop.Class.DTO.Account;
using System.Data;

namespace ClotheShop.Class.BLL
{
 
    internal class AccountBLL
    {
        private static AccountBLL instance;
        public static AccountBLL Instance
        {
            get
            {
                if (instance == null)
                    return instance = new AccountBLL();
                else return AccountBLL.instance;
            }
            private set => AccountBLL.instance = value;
        }
        public Account login(string username, string password)
        {   DataTable dt=AccountDAO.Instance.login(username, password);
            if (dt.Rows.Count > 0)
            {
                return new Account(dt.Rows[0]);

            }
            else
                return null;

        }
        public void UpdateLastlogin(int id)
        {
            AccountDAO.Instance.UpdateLoginDate(id);
        }
        public bool checkUserName(string username)
        {
            return AccountDAO.Instance.checkUserName(username);
                }
        public void GetAccountListByIdUser(int id,DataGridView DGV)
        {
            DGV.DataSource= AccountDAO.Instance.GetAccountListByIdUserId(id);
        }
        public void checkRegister(CustomTextBox ReUserTxt,CustomTextBox RegisPw,
            CustomTextBox RegisCfPw, CustomTextBox ReNameTxt, CustomTextBox RePhonetxt, CustomTextBox ReEmailTxt, Account account, User user, Panel loginPanel)
        {

            if (account.UserName1 == "")
            {
                RJMessageBox.Show("UserName is invalid ! ", "Information Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ReUserTxt.Focus();
            }
            else if (checkUserName(account.UserName1)){
                RJMessageBox.Show("UserName is Existed ! ", "Information Exists", MessageBoxButtons.OK, MessageBoxIcon.Question);

                ReUserTxt.Focus();
            }
            else
            {
                if (account.Password1 == "")
                {
                    RJMessageBox.Show("Password is invalid ! ", "Information Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RegisPw.Focus();
                }
                else
                {
                    if (!RegisCfPw.Texts.Equals(account.Password1))
                    {
                        RJMessageBox.Show("confirm password and password are the same!", "Information Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        RegisCfPw.Focus();
                    }
                    else
                    {
                        Regex regexname = new Regex("^[0-9]+$", RegexOptions.Compiled);
                        if (user.Name1 == "" || user.Name1.Length > 9 || regexname.IsMatch(user.Name1))
                        {
                            RJMessageBox.Show("name is invalid!", "Information Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            ReNameTxt.Focus();
                        }
                        else
                        {
                            Regex regexPhone = new Regex("^[0-9]+$", RegexOptions.Compiled);
                            if (user.Phone1 == "" || user.Phone1.Length != 10 || !regexPhone.IsMatch(user.Phone1) || user.Phone1[0] != '0')
                            {
                                RJMessageBox.Show("Phone must have 10 digits and starts with 0", "phone is invalid!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                RePhonetxt.Focus();
                            }
                            else
                            {
                                Regex regexEmail = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", RegexOptions.Compiled);
                                if (user.Phone1 == "" || !regexEmail.IsMatch(user.Email1))
                                {
                                    RJMessageBox.Show("Email is invalid","", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    ReEmailTxt.Focus();
                                }
                                else
                                {
                                    if (AccountDAO.Instance.register(account.UserName1, account.Password1, user.Name1, user.Phone1, user.Email1))
                                    {
                                        RJMessageBox.Show("Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ReUserTxt.Texts = "";
                                        RePhonetxt.Texts = "";
                                        RegisCfPw.Texts = "";
                                        RegisPw.Texts = "";
                                        ReEmailTxt.Texts = "";
                                        ReNameTxt.Texts = "";
                                        loginPanel.BringToFront();

                                    }
                                    else
                                    {
                                        RJMessageBox.Show("Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        internal void GetDataTable(DataGridView DGV)
        {
            DGV.DataSource = AccountDAO.Instance.GetDataTable();
        }

        internal Account getById(int id)
        {
            return new Account((AccountDAO.Instance.GetById(id)).Rows[0]);
        }

        internal bool SaveAccount(Account acc, CustomTextBox passwordCfTxt, CustomTextBox passwordTxt)
        {
            if (passwordTxt.Texts == "")
            {
                RJMessageBox.Show("Password empty please select the brand text box ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                passwordTxt.Focus();
            }
            else
            {
                if (!passwordTxt.Texts.Equals(passwordCfTxt.Texts))
                {
                    RJMessageBox.Show("Password txt and password confirm are not the same ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    passwordCfTxt.Focus();
                }
                else
                {
                    if (checkUserName(acc.UserName1))
                    {
                        RJMessageBox.Show("Username is Existed ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        acc.Password1 = passwordCfTxt.Texts;
                        return AccountDAO.Instance.Save(acc);
                    }

                }
            }
            return false;
        }

        internal bool EditProduct(Account acc)
        {
          return AccountDAO.Instance.Update(acc);
        }

        internal void GetDataTableSearched(DataGridView dataGridView1, int id, string username, string useraccount, string timeTop, string timeBot, bool inactiveChecked)
        {
            dataGridView1.DataSource= AccountDAO.Instance.GetDataTableSearch(id,username,useraccount,timeTop,timeBot,inactiveChecked);
        }

        internal void updatePassword(int iD1, string texts)
        {
            AccountDAO.Instance.updatePassword(iD1, texts);
        }

        internal void Delete(int id)
        {
            AccountDAO.Instance.Delete(id);
        }
    }
}
