using ClotheShop.Class;
using ClotheShop.CustomControl;
using ClotheShop.MyForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClotheShop
{
    public partial class MainForm : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private flogin loginForm;
        public MainForm()
        {
            InitializeComponent();
            loadAuthority();
            UserAccessName.Text = SessionClass.Instance.Account.UserName1;
            loginForm = new flogin();

        }
        void loadAuthority()
        {
            if (SessionClass.Instance.List_action.IndexOf(20) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                CreateBillBt.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(21) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                StatisticBt.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(22) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                ActionButton.Visible = false;
            }
        }
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);

        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            mainPanel.Tag = form;
            form.Show();
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            customButton1.ClickHanlder(sender, e);
            loadForm(new ProductViewForm());
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            customButton1.ClickHanlder(sender, e);
            loadForm(new CreateBillForm());
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            customButton1.ClickHanlder(sender, e);
            loadForm(new ActionViewForm());
        }

        private void StatisticBt_Click(object sender, EventArgs e)
        {
            customButton1.ClickHanlder(sender, e);
            loadForm(new StatisticViewForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CloseBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void customButton5_Click(object sender, EventArgs e)
        {
            // Perform logout logic if needed

            // Hide the main form
            this.Hide();

            // Show the login form
            loginForm.ShowDialog();

            // Close the application if the login is successful and the main form is not needed anymore
            if (loginForm.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                // Show the main form again if needed
                this.Show();
            }
        }

        private void UserAccessName_Click(object sender, EventArgs e)
        {
            new UserInformationForm() {TopLevel=true }.ShowDialog();
        }
    }
}
