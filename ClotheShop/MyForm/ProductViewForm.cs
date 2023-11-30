using Bunifu.UI.WinForms;
using ClosedXML.Excel;
using ClotheShop.Class;
using ClotheShop.Class.BLL;
using ClotheShop.Class.DAO;
using ClotheShop.Class.DTO;
using ClotheShop.MyForm;
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
    public partial class ProductViewForm : Form
    {
        private string function = "";
        public ProductViewForm()
        {
            InitializeComponent();
            ProductBLL.Instance.GetDataTable(dataGridView1);
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
                RoleBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(13) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                CategoryBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(2) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                addButton.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(3) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                EditButton.Visible = false;
            }
        }
        private void ProductViewForm_Load(object sender, EventArgs e)
        {
            CreatedbyDetail.EnableText = false;
            idDetail.Text = "";

            editedbyDetail.EnableText = false;
            saveBt.Visible = false;
            BrandBLL.Instance.loadBrandCombobox(brandDetail);
            BrandBLL.Instance.loadBrandCombobox(BrandSearch);
            CategoryBLL.Instance.getCategoryCombobox(CategoryDetail);
            CategoryBLL.Instance.getCategoryCombobox(CategorySearch);
            enabledTextbox(false);



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = (int)row.Cells["ID"].Value;


                showProductDetail(ProductBLL.Instance.getProductById(id));
                saveBt.Visible = false;

            }
        }
        private void enabledTextbox(bool flag)
        {
            nameDetail.EnableText = flag;
            uploadImageBt.Enabled = flag;
            brandDetail.Enabled = flag;
            CategoryDetail.Enabled = flag;
            QuantityDetail.EnableText = flag;
            priceDetail.EnableText = flag;
            DescriptionDetail.Enabled = flag;
            AddBillBt.Visible = false;

            if (function == "edit")
            {
                ActiveDetail.Enabled = true;
            }
            else
            {
                ActiveDetail.Enabled = false;
            }





        }
        private void showProductDetail(Product pd)
        {
            nameDetail.Texts = pd.Name;
            idDetail.Visible = true;
            idDetail.Text = pd.Id.ToString();
            createdTimeDetail.Value = pd.Created_date;
            editedTimeDetail.Value = pd.Edited_date;
            editedbyDetail.Texts = pd.Edited_by;
            CreatedbyDetail.Texts = pd.Created_by;
            brandDetail.Text = pd.Brand;
            CategoryDetail.Text = pd.Category;
            QuantityDetail.Texts = pd.Quantity.ToString();
            priceDetail.Texts = pd.Price.ToString();
            DescriptionDetail.Text = pd.Description;
            ActiveDetail.Text = pd.Active.ToString();
            if (pd.Image.Length == 0)
            {
                imageProductDetail.Image = null;
            }
            else
            {
                using (var ms = new MemoryStream(pd.Image))
                {
                    imageProductDetail.Image = Image.FromStream(ms);
                }
            }

            enabledTextbox(false);

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PriceBottom.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            PriceTop.Text = trackBar2.Value.ToString();
        }

        private void bunifuRange1_RangeChanged(object sender, EventArgs e)
        {
            if (priceRange.RangeMin > priceRange.MaximumRange - 20000)
            {
                priceRange.RangeMin = priceRange.MaximumRange - 20000;
            }
            Rangeco.Text = string.Format("${0} - ${1}", priceRange.RangeMin, priceRange.RangeMax);
        }

        private void bunifuRange1_Load(object sender, EventArgs e)
        {
            Rangeco.Text = string.Format("${0} - ${1}", priceRange.RangeMin, priceRange.RangeMax);
        }

        private void bunifuRange2_RangeChanged(object sender, EventArgs e)
        {
            if (quantityRange.RangeMin > quantityRange.MaximumRange - 50)
            {
                quantityRange.RangeMin = quantityRange.MaximumRange - 50;
            }
            QuantityLabel.Text = string.Format("{0} - {1}", quantityRange.RangeMin, quantityRange.RangeMax);
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

        private void bunifuRange2_Load(object sender, EventArgs e)
        {
            QuantityLabel.Text = string.Format("{0} - {1}", quantityRange.RangeMin, quantityRange.RangeMax);

        }

        private void saveBt_Click(object sender, EventArgs e)
        {

            Image a = imageProductDetail.Image;
            byte[] anh = SessionClass.Instance.imageToByte(a);
            if (nameDetail.Texts == "")
            {

                RJMessageBox.Show("Name text box empty please fill the name text box. ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                nameDetail.Focus();
            }
            else
            {
                if (priceDetail.Texts == "")
                {
                    RJMessageBox.Show("Price text box empty please fill the Price text box. ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    priceDetail.Focus();
                }
                else
                {
                    if (QuantityDetail.Texts == "")
                    {
                        RJMessageBox.Show("Quantity text box empty please fill the Quantity text box. ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        QuantityDetail.Focus();
                    }
                    else
                    {
                        if (brandDetail.SelectedIndex < 0)
                        {
                            RJMessageBox.Show("brand is empty please select the brand text box ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                            brandDetail.Focus();

                        }
                        else
                        {
                            if (brandDetail.SelectedValue.ToString() == "-1")
                            {
                                RJMessageBox.Show("brand is empty please select the brand text box ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                                brandDetail.Focus();
                            }
                            else
                            {


                                if (CategoryDetail.SelectedIndex > -1)
                                {
                                    if (CategoryDetail.SelectedValue.ToString() == "-1")
                                    {
                                        RJMessageBox.Show("Category is empty please select the brand text box ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                                        CategoryDetail.Focus();
                                    }
                                    else
                                    {
                                        bool flag = true;
                                        if (function == "add")
                                        {
                                            flag= !ProductBLL.Instance.SaveProduct(
                                                new Product(
                                                    nameDetail.Texts, DescriptionDetail.Text, CategoryDetail.SelectedValue.ToString(), brandDetail.SelectedValue.ToString(),
                                                    anh, createdTimeDetail.Value, "", ""), nameDetail, priceDetail, QuantityDetail
                                                );
                                           


                                        }
                                        else if (function == "edit")
                                        {
                                            flag = !ProductBLL.Instance.EditProduct(
                                                idDetail.Text,
                                             new Product(
                                                     nameDetail.Texts, DescriptionDetail.Text, CategoryDetail.SelectedValue.ToString(), brandDetail.SelectedValue.ToString(),
                                                    anh, createdTimeDetail.Value, "", ""), nameDetail, priceDetail, QuantityDetail, ActiveDetail.SelectedItem.ToString(), this
                                             );
                                           
                                          

                                        }
                                        if (!flag)
                                        {
                                            RJMessageBox.Show(" successful! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                         
                                        }
                                        enabledTextbox(flag);
                                        saveBt.Visible = flag;
                                        loadData();
                                    
                                    }
                                }
                                else
                                {
                                    RJMessageBox.Show("Category is empty please select the brand text box ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);



                                }
                            }
                        }
                    }
                }

            }





        }

        private void addButton_Click(object sender, EventArgs e)
        {
            imageProductDetail.Image = null;
            nameDetail.Texts = "";
            idDetail.Text = "";
            createdTimeDetail.Value = DateTime.Today;
            ActiveChB.Enabled = false;
            ActiveDetail.Text = "1";
            editedTimeDetail.Value = DateTime.Today;
            editedbyDetail.Texts = "";
            CreatedbyDetail.Texts = "";
            brandDetail.Text = "";
            CategoryDetail.Text = "";
            QuantityDetail.Texts = "";
            priceDetail.Texts = "";
            DescriptionDetail.Text = "";
            enabledTextbox(true);
            saveBt.Visible = true;
            function = "add";
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
                MessageBox.Show("please select product!");
            }
        }
        private void loadData()
        {
            ProductBLL.Instance.GetDataTable(dataGridView1);

        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (idDetail.Text != "")
            {
                MessageBox.Show(ProductBLL.Instance.DeleteProduct(idDetail.Text).ToString());
                imageProductDetail.Image = null;
                nameDetail.Texts = "";
                idDetail.Text = "";
                createdTimeDetail.Value = DateTime.Today;
                editedTimeDetail.Value = DateTime.Today;
                editedbyDetail.Texts = "";
                CreatedbyDetail.Texts = "";
                brandDetail.Text = "";
                CategoryDetail.Text = "";
                QuantityDetail.Texts = "";
                priceDetail.Texts = "";
                DescriptionDetail.Text = "";
                enabledTextbox(false);
                loadData();
            }
            else
            {
                MessageBox.Show("Pls select a product");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string timeTop = "";
            string timeBot = "";
            if (checkSearchDate.Checked)
            {
                timeTop = dateTimePickerTop.Value.ToString("yyyy-MM-dd");
                timeBot = dateTimePickerBot.Value.ToString("yyyy-MM-dd");
            }
            int brand = -1;
            int category = -1;
            if (CategorySearch.SelectedIndex > -1)
            {
                category = ((Category)CategorySearch.SelectedItem).Id;

            }
            if (BrandSearch.SelectedIndex > -1)
            {
                brand = ((Brand)BrandSearch.SelectedItem).Id;

            }


            string name = nameSearchTextbox.Texts;
            string topPrice = priceRange.RangeMax.ToString();
            string botPrice = priceRange.RangeMin.ToString();
            string topQuan = quantityRange.RangeMax.ToString();
            string botQuan = quantityRange.RangeMin.ToString();
            ProductBLL.Instance.GetDataTableSearched(dataGridView1, IdSearchTextbox, name, brand, category, botPrice, topPrice, botQuan, topQuan, timeTop, timeBot, ActiveChB.Checked);

        }



        private void imageProductDetail_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("changed");
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

        private void BillBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new BillViewForm());
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

        private void CategoryBtChanged_Click(object sender, EventArgs e)
        {
            UserBtChanged.ClickHanlder(sender, e);
            loadForm(new CategoryViewForm());
        }

        private void BrandBtChanged_Click(object sender, EventArgs e)
        {
            UserBtChanged.ClickHanlder(sender, e);
            loadForm(new BrandViewForm());
        }

        private void customButton2_Click(object sender, EventArgs e)
        {

        }

        private void ResetPriceBt_Click(object sender, EventArgs e)
        {
            priceRange.RangeMin = 0;
            priceRange.RangeMax = priceRange.MaximumRange;
            Rangeco.Text = string.Format("${0} - ${1}", priceRange.RangeMin, priceRange.RangeMax);
        }

        private void ResetQuanBt_Click(object sender, EventArgs e)
        {
            quantityRange.RangeMin = 0;
            quantityRange.RangeMax = quantityRange.MaximumRange;
            QuantityLabel.Text = string.Format("${0} - ${1}", quantityRange.RangeMin, quantityRange.RangeMax);
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
            string filePath = "C:\\Users\\84355\\source\\repos\\ClotheShop\\ClotheShop\\Xsls\\Products.xlsx";

            DataTable dataTable = SessionClass.Instance.GetDataGridViewAsDataTable(dataGridView1);
            ExportDataTableToExcel(dataTable, filePath);

            Console.WriteLine("Excel file created successfully.");
        }


        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            // Open a file dialog to allow the user to select an Excel file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Pass the selected file path to the controller
                    ProductBLL.Instance.ImportExcelData(selectedFilePath);
                }
            }
        }
    }
}
