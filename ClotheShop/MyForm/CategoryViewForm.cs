﻿using Bunifu.UI.WinForms;
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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClotheShop.CustomControl
{
    public partial class CategoryViewForm : Form
    {
        private string function = "";
        public CategoryViewForm()
        {
            InitializeComponent();
            loadData();
            loadAuthority();

        }
        void loadAuthority()
        {
            if (SessionClass.Instance.List_action.IndexOf(19) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                BillBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(7) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                BrandBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(16) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                AccountBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(4) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                UserBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(13) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                RoleChangedBt.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(11) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                addButton.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(12) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                EditButton.Visible = false;
                DeleteButton.Visible = false;
            }
        }
        private void CategoryViewForm_Load(object sender, EventArgs e)
        {
            idDetail.Text = "";
            saveBt.Visible = false;
            loadData();

            enabledTextbox(false);




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = (int)row.Cells["ID"].Value;


                showProductDetail(CategoryBLL.Instance.getCategoryById(id));
                ProductBLL.Instance.getProductByCategory(id, ProductListDGV);
                saveBt.Visible = false;

            }
        }
        private void enabledTextbox(bool flag)
        {
            nameDetail.EnableText = flag;

            if (function == "edit")
            {
                ActiveDetail.Enabled = true;
            }
            else
            {
                ActiveDetail.Enabled = false;

            }





        }
        private void showProductDetail(Category cate)
        {
            nameDetail.Texts = cate.Name;
            idDetail.Visible = true;
            idDetail.Text = cate.Id.ToString();

            ActiveDetail.Text = cate.Active.ToString();
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
            string name = nameDetail.Texts;
            bool flag;
            if (function == "add")
            {
                flag = !CategoryBLL.Instance.insertCate(name);
            }
            else
            {
                int id = Convert.ToInt32(idDetail.Text);
                int active = Convert.ToInt32(ActiveDetail.SelectedItem.ToString());
                flag = !CategoryBLL.Instance.UpdateCate(id, active, name);
            }
            if (flag)
            {
                RJMessageBox.Show("Action Failed!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                RJMessageBox.Show("Successful!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            saveBt.Visible = flag;


            enabledTextbox(flag);
            loadData();





        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //imageProductDetail.Image = null;
            nameDetail.Texts = "";
            idDetail.Text = "";
            ProductListDGV.DataSource = "";
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
                RJMessageBox.Show("Plesase select a Account! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void loadData()
        {
            dataGridView1.DataSource = CategoryBLL.Instance.GetDataTable();


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

            string name = NameSearchTxt.Texts;


            string id = IdSearchTxt.Texts;

            dataGridView1.DataSource = CategoryBLL.Instance.GetDataTableSearched(id, name, ActiveChB.Checked);

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
            UserBtChanged.ClickHanlder(sender, e);
            loadForm(new UserViewForm());
        }

        private void AccountBtChanged_Click(object sender, EventArgs e)
        {
            UserBtChanged.ClickHanlder(sender, e);
            loadForm(new AccountViewForm());
        }

        private void RoleBtChanged_Click(object sender, EventArgs e)
        {
            UserBtChanged.ClickHanlder(sender, e);
            loadForm(new RoleForm());
        }

        private void BrandBtChanged_Click(object sender, EventArgs e)
        {
            UserBtChanged.ClickHanlder(sender, e);
            loadForm(new BrandViewForm());
        }

        private void BillBtChanged_Click(object sender, EventArgs e)
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
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                openFileDialog.DefaultExt = "xlsx";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    DataTable dataTable = SessionClass.Instance.GetDataGridViewAsDataTable(dataGridView1);
                    ExportDataTableToExcel(dataTable, filePath);
                    RJMessageBox.Show(" Export successful! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (idDetail.Text.ToString() != "")
            {
                CategoryBLL.Instance.Delete(Convert.ToInt32(idDetail.Text.ToString()));
                RJMessageBox.Show("Successful ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idDetail.Text = "";
                nameDetail.Texts = "";
                ProductListDGV.DataSource = "";
                enabledTextbox(false);

                loadData();
            }
            else
                RJMessageBox.Show("Plesase select a Category! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void imageProductDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
