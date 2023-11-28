using ClotheShop.Class;
using ClotheShop.Class.BLL;
using ClotheShop.Class.DTO;
using DocumentFormat.OpenXml.Math;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClotheShop.MyForm
{
    public partial class UserInformationForm : Form
    {
        User u;
        public UserInformationForm()
        {
            InitializeComponent();
            u = UserBLL.Instance.getProductById(SessionClass.Instance.Account.ID_user1);
            nameDetail.Texts = u.Name1;
            idDetail.Text = u.Id.ToString();
            AddressDetail.Texts = u.Address1;
            PhoneDetail.Texts = u.Phone1;
            CCCDDetail.Texts = u.Phone1;
            EmailDetail.Texts = u.Email1;


        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (nameDetail.Texts == "")
            {
                RJMessageBox.Show("Name text box empty please fill the name text box! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                nameDetail.Focus();
            }
            else
            {
                if (PhoneDetail.Texts == "")
                {
                    RJMessageBox.Show("Phone text box empty ! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    PhoneDetail.Focus();
                }
                else
                {
                    if (CCCDDetail.Texts == "")
                    {
                        RJMessageBox.Show("CCCD text box empty please! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        CCCDDetail.Focus();
                    }
                    else
                    {


                        if (EmailDetail.Texts == "")
                        {
                            RJMessageBox.Show("Email text box empty! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                            CCCDDetail.Focus();
                        }
                        else
                        {
                            UserBLL.Instance.EditUser(idDetail.Text,
                                      nameDetail.Texts, AddressDetail.Texts, PhoneDetail, CCCDDetail, EmailDetail, u.RoleID, "1"
                              );
                            RJMessageBox.Show("Update Successful! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                }
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (PasswordTxt.Texts == "")
            {
                RJMessageBox.Show("Please enter the password first! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (AccountBLL.Instance.login(SessionClass.Instance.Account.UserName1, PasswordTxt.Texts) == null)
                {
                    RJMessageBox.Show("Your Password is incorrect! ", "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    RJMessageBox.Show("Access! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new ChangePassForm().ShowDialog();
                }
            }
        }
    }
}
