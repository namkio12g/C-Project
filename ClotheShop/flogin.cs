using ClotheShop.Class;
using ClotheShop.Class.BLL;
using ClotheShop.Class.DAO;
using ClotheShop.Class.DTO;
using System.Text.RegularExpressions;
using static ClotheShop.Class.DTO.Account;
using static ClotheShop.Class.DTO.User;

namespace ClotheShop
{
    public partial class flogin : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public flogin()
        {
            InitializeComponent();
        }

        private void BacktologinButton_click(object sender, MouseEventArgs e)
        {

            this.loginPanel.BringToFront();
            ReUserTxt.Texts = "";
            RePhonetxt.Texts = "";
            RegisCfPw.Texts = "";
            RegisPw.Texts = "";
            ReEmailTxt.Texts = "";
            ReNameTxt.Texts = "";
        }

        private void toRegisterBt_Click(object sender, EventArgs e)
        {
            UserTxt.Texts = "";
            PassTxt.Texts = "";
            this.registerPanel.BringToFront();
        }





        private void CloseBt_click(object sender, EventArgs e)
        {
            Application.Exit();
        }






        private void customButton1_Click(object sender, EventArgs e)
        {
            string username = UserTxt.Texts;
            string password = PassTxt.Texts;
            if (username == "")
            {
                RJMessageBox.Show("Pls fill username", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                UserTxt.Focus();
            }
            else if (password == "")
            {
                RJMessageBox.Show("Pls fill password ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                PassTxt.Focus();
            }
            else
            {
                SessionClass.Instance.Account = AccountBLL.Instance.login(username, password);
                if (SessionClass.Instance.Account != null)
                {

                    SessionClass.Instance.UserRole1 = UserBLL.Instance.CheckActiveUser(SessionClass.Instance.Account.ID_user1);
                    if (SessionClass.Instance.UserRole1 > -1)
                    {
                        AccountBLL.Instance.UpdateLastlogin(SessionClass.Instance.Account.ID1);
                        SessionClass.Instance.List_action = new List<int>();
                        RJMessageBox.Show("Login Successful ", "Login Successful ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Hide();

                        new MainForm().Show();
                    }
                    else
                    {
                        RJMessageBox.Show("UserName , password are wrong or account is not active ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    RJMessageBox.Show("UserName , password are wrong or account is not active ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Registerbt_click(object sender, EventArgs e)
        {
            string username = ReUserTxt.Texts;
            string password = RegisPw.Texts;
            string cfPassword = RegisCfPw.Texts;
            string email = ReEmailTxt.Texts;
            string name = ReNameTxt.Texts;
            string phone = RePhonetxt.Texts;
            User user = new User(name, "", phone, email, "");
            Account a = new Account(username, password);
            AccountBLL.Instance.checkRegister(ReUserTxt, RegisPw, RegisCfPw, ReNameTxt, RePhonetxt, ReEmailTxt, a, user, ReCCCDtxt, this.loginPanel);



        }




        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
    }
}