using ClosedXML.Excel;
using ClotheShop.Class;
using ClotheShop.Class.BLL;
using ClotheShop.Class.DTO;
using ClotheShop.CustomControl;
using DocumentFormat.OpenXml.Vml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClotheShop.MyForm
{
    public partial class CreateBillForm : Form
    {
        private ProductSearchForm form;
        private DataTable dataTable = new DataTable();
        private int billId;
        private List<string> list = new List<string>();

        Random rnd = new Random();


        public CreateBillForm()
        {
            InitializeComponent();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Total");
            ProductListDGV.DataSource = dataTable;
            foreach (DataGridViewColumn column in ProductListDGV.Columns)
            {
                column.ReadOnly = true;
            }

            // Enable editing for the specific column (replace "ColumnName" with the actual column name)
            ProductListDGV.Columns["Quantity"].ReadOnly = false;

        }

        private void Form_ButtonClicked(object? sender, CustomEventArgs c)
        {
            if (c.Value2.ToString() == "")
                addProduct(int.Parse(c.Value1.ToString()), 1);
            else
                addProduct(int.Parse(c.Value1.ToString()), Convert.ToInt32(c.Value2.ToString()));
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            //string filePath = "C:\\C#file\\file.xlsx";

            //// Export DataTable to Excel
            //ExportDataTableToExcel(dataTable, filePath);

            //Console.WriteLine("Excel file created successfully.");
            if (dataTable.Rows.Count > 0)
            {
                bool flag = true;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (!ProductBLL.Instance.checkValidQuantity(Convert.ToInt32(dataTable.Rows[i][0].ToString()), Convert.ToInt32(dataTable.Rows[i][3].ToString())))
                    {
                        flag = false;
                        ProductListDGV.ClearSelection();
                        ProductListDGV.Rows[i].Selected = true;
                        RJMessageBox.Show($"Quantity of some product too hight, row : {i + 1}! ", "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        break;
                    }
                    if (Convert.ToInt32(dataTable.Rows[i][3].ToString()) == 0)
                    {
                        flag = false;
                        ProductListDGV.ClearSelection();
                        ProductListDGV.Rows[i].Selected = true;
                        RJMessageBox.Show($"Quantity of some product equal 0 ,row : {i + 1}! ", "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        break;
                    }
                    
                }
                if (flag)
                {
                    printPreviewDialog1 = new PrintPreviewDialog();
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.Show();
                    int total = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        total += int.Parse(row[4].ToString());

                    }
                    BillBLL.Instance.createABill(CustomerNameTxt.Texts, billId, DateTime.Now, SessionClass.Instance.Account.ID1.ToString(), CustomerPhoneTxt.Texts, CustomerAddressTxt.Texts, total);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        BillBLL.Instance.insertBillDetail(Convert.ToInt32(row[0].ToString()), billId, Convert.ToInt32(row[3].ToString()));

                    }
                    RJMessageBox.Show("A bill  is created! ", "S", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cancel();

                }
            }
            else
            {
                RJMessageBox.Show("Please add more product ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int fontsmall = 20;
            e.Graphics.DrawString("Shope clothe", new Font("Arial", 50, FontStyle.Regular), Brushes.Black, new Point(80, 10));
            e.Graphics.DrawString($"Customer's Name: {list[0]}", new Font("Arial", fontsmall, FontStyle.Regular), Brushes.Black, new Point(20, 100));
            e.Graphics.DrawString($"Bill id: {billId}", new Font("Arial", fontsmall, FontStyle.Regular), Brushes.Black, new Point(e.PageBounds.Width - 200, 100));
            e.Graphics.DrawString($"Customer's Phone: {list[1]}", new Font("Arial", fontsmall, FontStyle.Regular), Brushes.Black, new Point(20, 130));
            e.Graphics.DrawString($"Customer's Address: {list[2]}", new Font("Arial", fontsmall, FontStyle.Regular), Brushes.Black, new Point(20, 160));
            Pen pen = new Pen(Color.Black, 2);
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(20, 190, e.PageBounds.Width - 40, 2); // Modify the coordinates and size as needed
            e.Graphics.DrawRectangle(pen, rectangle);

            int y = 210;
            string myString = string.Format("{0,7} {1,20} {2,20}", "Amounts", "Product Name", " Total");
            e.Graphics.DrawString(myString, new Font("Arial", fontsmall, FontStyle.Regular), Brushes.Black, new Point(150, y));
            y += 30;
            int total = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                myString = string.Format("{0,7:D} {1,25} {2,30:D}", row[3].ToString(), row[1].ToString(), row[4].ToString());
                total += int.Parse(row[4].ToString());
                e.Graphics.DrawString(myString, new Font("Arial", fontsmall, FontStyle.Regular), Brushes.Black, new Point(150, y));
                y += 40;


            }
            rectangle = new System.Drawing.Rectangle(20, y, e.PageBounds.Width - 40, 2); // Modify the coordinates and size as needed
            e.Graphics.DrawRectangle(pen, rectangle);
            myString = string.Format("{0,7:D} {1,15} {2,20:D} dong", "", "", total);

            e.Graphics.DrawString(myString, new Font("Arial", fontsmall + 5, FontStyle.Regular), Brushes.Black, new Point(150, y + 30));
        }

        private void nameSearchTextbox_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            if (IdTxt.Texts != "")
            {

                int id = Convert.ToInt32(IdTxt.Texts);
                int number = 1;
                if (NumberTxt.Texts != "")
                    number = Convert.ToInt32(NumberTxt.Texts);
                addProduct(id, number);
            }
            else
            {
                RJMessageBox.Show("Plesase Enter a Id! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }
        private void addProduct(int id, int number)
        {
            Product product = ProductBLL.Instance.getProductActiveById(id);
            if (number < 0)
            {
                number = 0;
            }
            if (product == null)
            {
                RJMessageBox.Show("Cant find this Product! ", "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ProductBill productbill = new ProductBill(product.Id, product.Name, product.Price, number);
                //ProductListDGV.Rows.Add(id.ToString(), product.Name, product.Price.ToString(), number.ToString(), (number * product.Price).ToString());


                // Find the index of the row where the ID exists using LINQ
                int rowIndex = dataTable
                            .AsEnumerable()
                            .Select((row, index) => new { Row = row, Index = index })
                            .FirstOrDefault(x =>
                            {
                                object idValue = x.Row["ID"];
                                int id;

                                if (idValue != null && int.TryParse(idValue.ToString(), out id))
                                {
                                    return id == productbill.Id;
                                }

                                return false;
                            })?
                            .Index ?? -1;
                if (rowIndex != -1)
                {
                    int new_num = (int.Parse(dataTable.Rows[rowIndex][3].ToString()) + number);
                    dataTable.Rows[rowIndex][3] = new_num.ToString();
                    dataTable.Rows[rowIndex][4] = (int.Parse(dataTable.Rows[rowIndex][2].ToString()) * new_num).ToString();
                    

                }
                else
                {
                    // ID does not exist in the DataTable
                    dataTable.Rows.Add(productbill.Id, productbill.Name, productbill.Price, productbill.Quantity, productbill.Total);


                }
                RJMessageBox.Show($"ADD SUCCESSFUL ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void ProductListDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Regex regexname = new Regex("^[0-9]+$", RegexOptions.Compiled);
            if (e.RowIndex >= 0)
            {
                if (regexname.IsMatch(ProductListDGV.Rows[e.RowIndex]
            .Cells[3].Value.ToString()))
                {
                    int new_num = int.Parse(ProductListDGV.Rows[e.RowIndex]
                .Cells[3].Value.ToString());


                    if (new_num > 0)
                    {

                        int balance = new_num * int.Parse(ProductListDGV.Rows[e.RowIndex]
                    .Cells[2].Value.ToString());

                        ProductListDGV.Rows[e.RowIndex].Cells[4].Value = balance.ToString();
                    }


                }
                else
                {
                    ProductListDGV.Rows[e.RowIndex].Cells[3].Value = "0";
                    ProductListDGV.Rows[e.RowIndex].Cells[4].Value = "0";

                }
            }

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            form = new ProductSearchForm();
            form.ButtonClicked += Form_ButtonClicked;
            form.ShowDialog();
        }
        private void show(string id)
        {
            MessageBox.Show(id);
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            if (ProductListDGV.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = ProductListDGV.SelectedRows[0];

                // Get the value from the "ID" column of the selected row
                int selectedId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Find the index of the row in the DataTable based on the ID
                int rowIndex = dataTable
                    .Rows
                    .Cast<DataRow>()
                    .ToList()
                    .FindIndex(row => Convert.ToInt32(row["ID"]) == selectedId);

                // Remove the row from the DataTable
                if (rowIndex != -1)
                {
                    dataTable.Rows.RemoveAt(rowIndex);

                    // Refresh the DataGridView to reflect the changes
                    ProductListDGV.DataSource = null;
                    ProductListDGV.DataSource = dataTable;
                }
                else
                {
                    RJMessageBox.Show("Row not found in the DataTable. ", "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                RJMessageBox.Show("Please select a row to delete. ", "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void ProductListDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductListDGV.Rows[e.RowIndex];



            }
        }

        private void FinishBt_Click(object sender, EventArgs e)
        {
            if (CustomerNameTxt.Texts == "")
            {
                RJMessageBox.Show("Please enter the name. ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                CustomerNameTxt.Focus();
            }
            else
            {
                if (CustomerPhoneTxt.Texts == "" || CustomerPhoneTxt.Texts.Length != 10 || CustomerPhoneTxt.Texts[0] != '0')
                {
                    RJMessageBox.Show("The phone number is invalid. ", "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    CustomerPhoneTxt.Focus();
                }
                else
                {
                    billId = rnd.Next(1, 999999);
                    InfoPanel.Hide();
                    dataTable.Rows.Clear();
                    list.Add(CustomerNameTxt.Texts);
                    list.Add(CustomerPhoneTxt.Texts);
                    if (CustomerAddressTxt.Texts == "")
                        list.Add("");
                    else
                        list.Add(CustomerAddressTxt.Texts);
                    CancelBt.Visible = true;
                    FinishBt2.Visible = true;

                }
            }
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            cancel();
        }
        private void cancel()
        {
            CustomerNameTxt.Texts = "";
            CustomerPhoneTxt.Texts = "";
            CustomerAddressTxt.Texts = "";
            IdTxt.Texts = "";
            NumberTxt.Texts = "";
            dataTable.Rows.Clear();
            InfoPanel.Show();
            CancelBt.Visible = false;
            FinishBt2.Visible = false;
        }
    }

}
