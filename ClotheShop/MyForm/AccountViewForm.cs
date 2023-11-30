using Bunifu.UI.WinForms;
using ClosedXML.Excel;
using ClotheShop.Class;
using ClotheShop.Class.BLL;
using ClotheShop.Class.DTO;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClotheShop.CustomControl
{
    public partial class AccountViewForm : Form
    {
        private string function = "";
        public AccountViewForm()
        {
            InitializeComponent();
            AccountBLL.Instance.GetDataTable(dataGridView1);
            loadAuthority();

        }
        void loadAuthority()
        {
            if (SessionClass.Instance.List_action.IndexOf(7) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                BrandChangedBt.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(10) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                CategoryBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(13) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                RoleChangedBt.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(19) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                BillBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(4) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                UserBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(17) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                addButton.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(18) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                EditButton.Visible = false;
            }
        }
        private void AccountViewForm_Load(object sender, EventArgs e)
        {
            idDetail.Text = "";
            userNameDetail.EnableText = false;
            UserBLL.Instance.getCombobox(UserAccountDetail);

            saveBt.Visible = false;
            enabledTextbox(false);



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = (int)row.Cells["ID"].Value;


                showProductDetail(AccountBLL.Instance.getById(id));
                saveBt.Visible = false;

            }
        }
        private void enabledTextbox(bool flag)
        {
            userNameDetail.EnableText = flag;
            if (function == "edit")
            {
                ActiveDetail.Enabled = true;
                PasswordCfLb.Visible = false;
                PasswordCfTxt.Visible = false;
                PasswordLb.Visible = false;
                PasswordTxt.Visible = false;
                UserAccountDetail.Enabled = false;
            }
            else if (function == "add")
            {
                ActiveDetail.Enabled = false;
                PasswordCfLb.Visible = true;
                PasswordCfTxt.Visible = true;
                PasswordLb.Visible = true;
                PasswordTxt.Visible = true;
                UserAccountDetail.Enabled = true;

            }
            else
            {
                ActiveDetail.Enabled = false;
                PasswordCfLb.Visible = false;
                PasswordCfTxt.Visible = false;
                PasswordLb.Visible = false;
                PasswordTxt.Visible = false;
                UserAccountDetail.Enabled = false;
            }





        }
        private void showProductDetail(Account acc)
        {
            userNameDetail.Texts = acc.UserName1;
            idDetail.Visible = true;
            idDetail.Text = acc.ID1.ToString();
            UserAccountDetail.Text = acc.UserAccount;
            createdTimeDetail.Value = acc.Date_created1;
            editedTimeDetail.Value = acc.Date_Edited1;
            Last_login.Value = acc.Last_login1;
            ActiveDetail.Text = acc.Active.ToString();
            function = "";
            enabledTextbox(false);
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }






        //private void uploadImageBt_Click(object sender, EventArgs e)
        //{
        //    using (OpenFileDialog opd = new OpenFileDialog()
        //    {
        //        Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg",
        //        Multiselect = false,
        //        Title = "Select an Image File"
        //    })
        //    {
        //        if (opd.ShowDialog() == DialogResult.OK)
        //        {
        //            string selectedImagePath = opd.FileName;
        //            imageProductDetail.Image = Image.FromFile(selectedImagePath);
        //        }
        //    }
        //}



        private void saveBt_Click(object sender, EventArgs e)
        {

            if (userNameDetail.Texts == "")
            {
                RJMessageBox.Show("UserName was empty ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                userNameDetail.Focus();
            }
            else
            {

                MessageBox.Show(UserAccountDetail.SelectedIndex.ToString());
                if ((UserAccountDetail.SelectedIndex < 0))
                {
                    RJMessageBox.Show("Useraccount empty please select the brand text box ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    UserAccountDetail.Focus();

                }
                else
                {
                    if (UserAccountDetail.SelectedValue.ToString() == "-1")
                    {
                        RJMessageBox.Show("Useraccount empty please select the brand text box ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        UserAccountDetail.Focus();
                    }
                    else
                    {
                        bool flag = true;
                        if (function == "add")
                        {
                            flag=AccountBLL.Instance.SaveProduct(
                                new Account(Convert.ToInt32(UserAccountDetail.SelectedValue), userNameDetail.Texts), PasswordCfTxt, PasswordTxt
                                );
                        }
                        else if (function == "edit")
                        {
                            string a = idDetail.Text;
                            flag = !AccountBLL.Instance.EditProduct(
                                new Account() { Active = Convert.ToInt32(ActiveDetail.SelectedItem.ToString()), UserName1 = userNameDetail.Texts, ID1 = Convert.ToInt32(idDetail.Text) }
                                );
                            

                        }
                        if( flag )
                        {
                        RJMessageBox.Show("Action Failed!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                        }
                        else
                        {
                            RJMessageBox.Show("Successful!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        }
                        enabledTextbox(flag);
                        saveBt.Visible = flag;
                        loadData();
                    }
                }
            }








        }
        private void CheckSearchDate_Click(object sender, EventArgs e)
        {
            bool b = checkSearchDate.Checked;
            dateTimePickerBot.Enabled = b;
            dateTimePickerTop.Enabled = b;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            userNameDetail.Texts = "";
            idDetail.Text = "";
            createdTimeDetail.Value = DateTime.Today;
            editedTimeDetail.Value = DateTime.Today;
            UserAccountDetail.Text = "";
            PasswordCfTxt.Texts = "";
            PasswordTxt.Texts = "";
            function = "add";
            enabledTextbox(true);
            saveBt.Visible = true;
        }


        private void checkSearchDate_Click(object sender, EventArgs e)
        {
            bool b = checkSearchDate.Checked;
            dateTimePickerBot.Enabled = b;
            dateTimePickerTop.Enabled = b;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (idDetail.Text != "")
            {
                function = "edit";
                enabledTextbox(true);
                saveBt.Visible = true;

            }
            else
            {
                RJMessageBox.Show("Plesase select a Account! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void loadData()
        {
            AccountBLL.Instance.GetDataTable(dataGridView1);

        }
        //private void DeleteButton_Click(object sender, EventArgs e)
        //{
        //    if (idDetail.Text != "")
        //    {
        //        MessageBox.Show(ProductBLL.Instance.DeleteProduct(idDetail.Text).ToString());
        //        imageProductDetail.Image = null;
        //        nameDetail.Texts = "";
        //        idDetail.Text = "";
        //        createdTimeDetail.Value = DateTime.Today;
        //        editedTimeDetail.Value = DateTime.Today;
        //        editedbyDetail.Texts = "";
        //        UserNameDetail.Texts = "";
        //        brandDetail.Text = "";
        //        CategoryDetail.Text = "";
        //        QuantityDetail.Texts = "";
        //        priceDetail.Texts = "";
        //        DescriptionDetail.Text = "";
        //        enabledTextbox(false);
        //        loadData();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Pls select a product");
        //    }
        //}

        private void searchButton_Click(object sender, EventArgs e)
        {
            string timeTop = "";
            string timeBot = "";
            if (checkSearchDate.Checked)
            {
                timeTop = dateTimePickerTop.Value.ToString("yyyy-MM-dd");
                timeBot = dateTimePickerBot.Value.ToString("yyyy-MM-dd");
            }
            int id = -1;
            if (IdSearchTextbox.Texts != "")
                id = Convert.ToInt32(IdSearchTextbox.Texts);
            string useraccount = UserAccountSearchTextbox.Texts;
            string username = userNameDetail.Text;
            AccountBLL.Instance.GetDataTableSearched(dataGridView1, id, username, useraccount, timeTop, timeBot, ActiveChB.Checked);

        }




        private void loadForm(object Form)
        {
            Form form = Form as Form;
            Control parentcontroll = this.Parent;
            this.Dispose();
            form.TopLevel = false;
            form.Parent = parentcontroll;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void UserFormBtChanged_Click(object sender, EventArgs e)
        {
            UserBtChanged.ClickHanlder(sender, e);
            loadForm(new UserViewForm());
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void ProductViewFormBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new ProductViewForm());
        }


        private void AccountBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new AccountViewForm());
        }

        private void RoleBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new RoleForm());
        }

        private void CategoryBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new CategoryViewForm());
        }

        private void BrandBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new BrandViewForm());
        }

        private void BillBtChanged_Click_1(object sender, EventArgs e)
        {
            loadForm(new BillViewForm());
        }
        void ExportDataTableToExcel(DataTable dataTable, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sheet1");

                // Insert the DataTable data to the worksheet
                worksheet.Cell(1, 1).InsertTable(dataTable);

                // Save the workbook to the specified file path
                workbook.SaveAs(filePath);
            }
        }
        private void ExportBt_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\84355\\source\\repos\\ClotheShop\\ClotheShop\\Xsls\\accounts.xlsx";

            DataTable dataTable = SessionClass.Instance.GetDataGridViewAsDataTable(dataGridView1);
            ExportDataTableToExcel(dataTable, filePath);

            Console.WriteLine("Excel file created successfully.");
        }

        private void ShowPassBt_Click(object sender, EventArgs e)
        {
            if (idDetail.Text.ToString() != "")
            {
                Account acc = AccountBLL.Instance.getById(Convert.ToInt16(idDetail.Text.ToString()));
                RJMessageBox.Show($"Password is '{acc.Password1}' ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);


            }
            else
            {
                RJMessageBox.Show("Plesase select a Account! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
        }
    }
}
