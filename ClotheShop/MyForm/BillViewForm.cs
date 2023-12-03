using Bunifu.UI.WinForms;
using ClosedXML.Excel;
using ClotheShop.Class;
using ClotheShop.Class.BLL;
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
    public partial class BillViewForm : Form
    {
        private string function = "";
        private List<Product> list = new List<Product>();
        public BillViewForm()
        {
            InitializeComponent();
            loadData();
            loadAuthority();

        }
        void loadAuthority()
        {
            if (SessionClass.Instance.List_action.IndexOf(7) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                BrandBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(10) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                CategoryBtChanged.Visible = false;
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

        }
        private void BillViewForm_Load(object sender, EventArgs e)
        {
            CreatedbyDetail.EnableText = false;
            idDetail.Text = "";
            ProductBLL.Instance.loadProductCombobox(ProductSearch);




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = (int)row.Cells["ID"].Value;


                showBillDetail(BillBLL.Instance.getBillById(id));

            }
        }
        //private void enabledTextbox(bool flag)
        //{
        //    nameDetail.EnableText = flag;
        //    uploadImageBt.Enabled = flag;
        //    brandDetail.Enabled = flag;
        //    CategoryDetail.Enabled = flag;
        //    QuantityDetail.EnableText = flag;
        //    priceDetail.EnableText = flag;
        //    DescriptionDetail.Enabled = flag;
        //    AddBillBt.Visible = false;

        //    if (function == "edit")
        //    {
        //        ActiveDetail.Enabled = true;
        //    }
        //    else
        //    {
        //        ActiveDetail.Enabled = false;
        //    }





        //}
        private void showBillDetail(Bill bill)
        {
            CustomerNameDetail.Texts = bill.CustomerName;
            idDetail.Visible = true;
            idDetail.Text = bill.Id.ToString();
            CustomerPhoneDetail.Texts = bill.CustomerPhone;
            createdTimeDetail.Value = bill.Date_created;
            CreatedbyDetail.Texts = bill.Created_by;
            TotalDetail.Texts = bill.Total.ToString();
            CustomerAddDetail.Texts = bill.CustomerAddress;
            BillBLL.Instance.getProductListById(bill.Id, DGV2);


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
            Rangeco.Text = string.Format("${0} - ${1}", priceRange.RangeMin * 10, priceRange.RangeMax * 10);
        }

        private void bunifuRange1_Load(object sender, EventArgs e)
        {
            Rangeco.Text = string.Format("${0} - ${1}", priceRange.RangeMin * 10, priceRange.RangeMax * 10);
        }




        private void customTextBox3_Load(object sender, EventArgs e)
        {

        }







        private void checkSearchDate_Click(object sender, EventArgs e)
        {
            bool b = checkSearchDate.Checked;
            dateTimePickerBot.Enabled = b;
            dateTimePickerTop.Enabled = b;
        }

        private void AddProductSearchBt_Click(object sender, EventArgs e)
        {
            Product pd = null;

            if (ProductSearch.SelectedIndex > -1)
            {
                pd = ((Product)ProductSearch.SelectedItem);

            }
            if (pd.Id != -1)
            {
                bool isRowFound = false;

                foreach (DataGridViewRow row in ProductListSearchDGV.Rows)
                {
                    // Assuming "ID" is the name of the column containing the ID
                    int rowId = Convert.ToInt32(row.Cells[0].Value);

                    if (rowId == pd.Id)
                    {
                        // The row with the specified ID is found
                        isRowFound = true;
                        break;
                    }
                }
                if (!isRowFound)
                {
                    list.Add(pd);
                    ProductListSearchDGV.Rows.Add(pd.Id.ToString(), pd.Name);
                }

            }
        }
        private void loadData()
        {

            BillBLL.Instance.GetDataTable(dataGridView1);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (idDetail.Text != "")
            {
                BillBLL.Instance.DeleteBill(idDetail.Text);
                CustomerNameDetail.Texts = "";
                idDetail.Text = "";
                createdTimeDetail.Value = DateTime.Today;
                CreatedbyDetail.Texts = "";
                TotalDetail.Texts = "";
                CustomerAddDetail.Texts = "";
                loadData();
            }
            else
            {
                RJMessageBox.Show("Plesase select a Bill! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);
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



            string name = nameSearchTextbox.Texts;
            string topPrice = (priceRange.RangeMax * 10).ToString();
            string botPrice = (priceRange.RangeMin * 10).ToString();
            BillBLL.Instance.GetDataTableSearched(dataGridView1, IdSearchTextbox.Texts, name, botPrice, topPrice, timeTop, timeBot, list);

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
            loadForm(new CreateBillForm());
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

        private void ProductListSearchDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ProductListSearchDGV.Rows.RemoveAt(e.RowIndex);
                list.RemoveAt(e.RowIndex);


            }
        }

        private void ResetTotalBt_Click(object sender, EventArgs e)
        {
            priceRange.RangeMin = 0;
            priceRange.RangeMax = priceRange.MaximumRange;
            Rangeco.Text = string.Format("{0} - {1}", priceRange.RangeMin * 10, priceRange.RangeMax * 10);
        }

        private void ProductChangedBt_Click(object sender, EventArgs e)
        {
            loadForm(new ProductViewForm());
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
    }
}
