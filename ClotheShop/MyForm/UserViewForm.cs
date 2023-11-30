using Bunifu.UI.WinForms;
using ClosedXML.Excel;
using ClotheShop.Class;
using ClotheShop.Class.BLL;
using ClotheShop.Class.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClotheShop.CustomControl
{
    public partial class UserViewForm : Form
    {
        private string function = "";
        public UserViewForm()
        {
            InitializeComponent();
            loadData();
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
                CategoryChangedBt.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(16) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                AccountBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(19) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                BillBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(13) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                RoleChangedBt.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(5) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                addButton.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(6) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                EditButton.Visible = false;
            }
        }
        private void AccountViewForm_Load(object sender, EventArgs e)
        {
            idDetail.Text = "";
            saveBt.Visible = false;
            RoleBLL.Instance.getRoleCombobox(RoleSearch);
            RoleBLL.Instance.getRoleCombobox(RoleDetail);
            enabledTextbox(false);




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = (int)row.Cells["ID"].Value;


                showProductDetail(UserBLL.Instance.getProductById(id));
                AccountBLL.Instance.GetAccountListByIdUser(id, AccountListDGV);
                saveBt.Visible = false;

            }
        }
        private void enabledTextbox(bool flag)
        {
            nameDetail.EnableText = flag;
            RoleDetail.Enabled = flag;
            AddressDetail.EnableText = flag;
            CCCDDetail.Enabled = flag;
            EmailDetail.Enabled = flag;
            if (function == "edit")
            {
                ActiveDetail.Enabled = true;
                RoleDetail.Enabled = true;
            }
            else
            {
                ActiveDetail.Enabled = false;
                RoleDetail.Enabled = false;

            }





        }
        private void showProductDetail(User user)
        {
            nameDetail.Texts = user.Name1;
            idDetail.Visible = true;
            idDetail.Text = user.Id.ToString();
            CCCDDetail.Texts = user.CCCD1;
            PhoneDetail.Texts = user.Phone1;
            RoleDetail.Text = user.Role;
            AddressDetail.Texts = user.Address1;
            EmailDetail.Texts = user.Email1;
            ActiveDetail.Text = user.Active.ToString();
            function = "";
            //if (pd.Image.Length == 0)
            //{
            //    imageProductDetail.Image = null;
            //}
            //else
            //{
            //    using (var ms = new MemoryStream(pd.Image))
            //    {
            //        imageProductDetail.Image = Image.FromStream(ms);
            //    }
            //}
            enabledTextbox(false);
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }









        private void uploadImageBt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opd = new OpenFileDialog()
            {
                Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg",
                Multiselect = false,
                Title = "Select an Image File"
            })
            {
                if (opd.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = opd.FileName;
                    imageProductDetail.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void customTextBox3_Load(object sender, EventArgs e)
        {

        }


        private void saveBt_Click(object sender, EventArgs e)
        {
            Regex regexEmail = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", RegexOptions.Compiled);
            if (nameDetail.Texts == "")
            {
                RJMessageBox.Show("Name text box empty please fill the name text box! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                nameDetail.Focus();
            }
            else
            {
                if (PhoneDetail.Texts == "" )
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
                        ;
                        if (!(function == "add") && (RoleDetail.SelectedIndex > -1 && RoleDetail.SelectedValue.ToString() == "-1"))
                        {
                            RJMessageBox.Show("role text box empty! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                            RoleDetail.Focus();

                        }
                        else
                        {

                            if (EmailDetail.Texts == "" )
                            {
                                RJMessageBox.Show("Email text box empty! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                                CCCDDetail.Focus();
                            }
                            else
                            {
                                if (PhoneDetail.Texts.Length != 10 || PhoneDetail.Texts[0] != '0')
                                {
                                    RJMessageBox.Show("the phone is invalid,phone must have 10 digits and start with 0", "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    PhoneDetail.Focus();
                                }
                                else
                                {
                                    if (CCCDDetail.Texts.Length != 10)
                                    {
                                        RJMessageBox.Show("the cccd is invalid,cccd must have 10 digits", "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                        CCCDDetail.Focus();

                                    }
                                    else
                                    {
                                        if (!(regexEmail.IsMatch(EmailDetail.Texts)))
                                        {

                                            RJMessageBox.Show("the email is invalid", "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                            EmailDetail.Focus();
                                        }
                                        else
                                        {
                                            bool flag=true;

                                            if (function == "add")
                                            {

                                                flag=!UserBLL.Instance.SaveUser(nameDetail.Texts, AddressDetail.Texts, PhoneDetail, CCCDDetail, EmailDetail);

                                            }
                                            else if (function == "edit")
                                            {
                                                flag=!UserBLL.Instance.EditUser(idDetail.Text,
                                                         nameDetail.Texts, AddressDetail.Texts, PhoneDetail, CCCDDetail, EmailDetail, RoleDetail.SelectedValue, ActiveDetail.SelectedItem.ToString()
                                                 );

                                            }
                                            if (!flag)
                                            {
                                                RJMessageBox.Show("Action Failed!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                                            }
                                            else
                                            {
                                                RJMessageBox.Show("Successful!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                            }
                                            saveBt.Visible = flag;


                                            enabledTextbox(flag);
                                        }
                                    }
                                } 
                            }



                        }
                    }


                }

            }





        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //imageProductDetail.Image = null;
            nameDetail.Texts = "";
            idDetail.Text = "";
            CCCDDetail.Texts = "";
            PhoneDetail.Texts = "";
            EmailDetail.Texts = "";
            RoleDetail.Text = "";
            AddressDetail.Texts = "";
            enabledTextbox(true);
            saveBt.Visible = true;
            function = "add";
        }


        //private void checkSearchDate_Click(object sender, EventArgs e)
        //{
        //    bool b = checkSearchDate.Checked;
        //    dateTimePickerBot.Enabled = b;
        //    dateTimePickerTop.Enabled = b;
        //}

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
                MessageBox.Show("please select product!");
            }
        }
        private void loadData()
        {
            dataGridView1.DataSource = UserBLL.Instance.getDataView();


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
        //        CCCDDetail.Texts = "";
        //        PhoneDetail.Texts = "";
        //        RoleDetail.Text = "";
        //        CategoryDetail.Text = "";
        //        QuantityDetail.Texts = "";
        //        AddressDetail.Texts = "";
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
            int role = -1;
            if (RoleSearch.SelectedIndex > -1)
            {
                role = ((Role)RoleSearch.SelectedItem).Id;

            }
            string address = AddressSearchTxt.Texts;
            string phone = PhoneSearchTxt.Texts;
            string name = NameSearchTxt.Texts;

            string cccd = AddressSearchTxt.Texts;
            string email = EmailSearchTxt.Texts;
            string id = IdSearchTxt.Texts;

            dataGridView1.DataSource = UserBLL.Instance.GetDataTableSearched(dataGridView1, id, name, address, phone, email, cccd, role, ActiveChB.Checked);

        }



        private void imageProductDetail_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("changed");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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


        private void ProductFormBtChanged_Click(object sender, EventArgs e)
        {
            ProductFormBtChanged.ClickHanlder(sender, e);
            loadForm(new ProductViewForm());
        }
        private void UserFormBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new UserViewForm());
        }

        private void BillBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new BillViewForm());
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
            string filePath = "C:\\Users\\84355\\source\\repos\\ClotheShop\\ClotheShop\\Xsls\\User.xlsx";

            DataTable dataTable = SessionClass.Instance.GetDataGridViewAsDataTable(dataGridView1);
            ExportDataTableToExcel(dataTable, filePath);

            Console.WriteLine("Excel file created successfully.");
        }
    }
}
