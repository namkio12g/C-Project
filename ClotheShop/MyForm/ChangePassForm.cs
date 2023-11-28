using ClotheShop.Class;
using ClotheShop.Class.BLL;
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
    public partial class ChangePassForm : Form
    {
        public ChangePassForm()
        {
            InitializeComponent();
        }



        private void customButton1_Click(object sender, EventArgs e)
        {
            if (PasswordTxt.Texts == "")
            {
                RJMessageBox.Show("Password is empty !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!PasswordTxt.Texts.Equals(ConfirmPasswordTxt.Texts))
                {
                    RJMessageBox.Show("2 Password is not the same  !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AccountBLL.Instance.updatePassword(SessionClass.Instance.Account.ID1, PasswordTxt.Texts);
                    this.Close();
                }
            }
        }
    }
}
