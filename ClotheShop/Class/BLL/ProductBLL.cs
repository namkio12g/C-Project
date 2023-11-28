using ClotheShop.Class.DAO;
using ClotheShop.Class.DTO;
using ClotheShop.CustomControl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClotheShop.Class.BLL
{
    internal class ProductBLL
    {
        private static ProductBLL instance;
        public static ProductBLL Instance
        {
            get
            {
                if (instance == null)
                    return instance = new ProductBLL();
                else return ProductBLL.instance;
            }
            private set => ProductBLL.instance = value;
        }
        public void GetDataTable(DataGridView DGV)
        {
            DataTable dt = ProductDAO.Instance.GetDataTable();
            DGV.DataSource = dt;
        }
        public Product getProductById(int id)
        {
            Product product =ProductDAO.Instance.getProductbyId(id) ;
            return product;
        }
        public void SaveProduct(Product product,CustomTextBox name,CustomTextBox price,CustomTextBox quantity)
        {
            Regex regexname = new Regex("^[0-9]+$", RegexOptions.Compiled);
            if (!regexname.IsMatch(price.Texts))
            {
                RJMessageBox.Show("Price value is invalid! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                price.Focus();
             

            }
            else
            {
                product.Price = Convert.ToInt32(price.Texts);
                if (!regexname.IsMatch(quantity.Texts)) {
                    RJMessageBox.Show("Quantity value is invalid! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    quantity.Focus();
                }
                else
                {
                    if (Convert.ToInt32(quantity.Texts) > 0)
                    {
                        product.Quantity = Convert.ToInt32(quantity.Texts);
                        ProductDAO.Instance.Insert(product);
                    }
                    else
                    {
                        RJMessageBox.Show("Quantity value is invalid! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        quantity.Focus();
                    }
                }
            }
        }

        internal bool EditProduct(string id,Product product, CustomTextBox nameDetail, CustomTextBox price, CustomTextBox quantity,string active,Form form)
        {
            Regex regexname = new Regex("^[0-9]+$", RegexOptions.Compiled);
            if (!regexname.IsMatch(price.Texts))
            {
                RJMessageBox.Show("Price value is invalid! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                price.Focus();


            }
            else
            {
                product.Price = Convert.ToInt32(price.Texts);
                if (!regexname.IsMatch(quantity.Texts))
                {
                    RJMessageBox.Show("Quantity value is invalid! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    quantity.Focus();
                }
                else
                {
                    product.Quantity = Convert.ToInt32(quantity.Texts);
                    product.Id= Convert.ToInt32(id);
                    product.Active= Convert.ToInt32(active);
                    return ProductDAO.Instance.Update(product);
                    
                }
            }
            return false;
        }
        internal bool DeleteProduct(string id)
        {
            return ProductDAO.Instance.Delete(Convert.ToInt32(id));
        }

        internal void GetDataTableSearched(DataGridView DGV,CustomTextBox idTxt,string name,int brand,int cate,string botP,string topP,string botQ,string topQ,string topT,string botT,bool active)
        {
            string id = idTxt.Texts;
            Regex regexname = new Regex("^[0-9]+$", RegexOptions.Compiled);
            if (regexname.IsMatch(id) || id=="")
            {
                
                    DataTable dt = ProductDAO.Instance.GetDataTableSearch(id, name, brand, cate, botP, topP, botQ, topQ, botT, topT,active);
                    DGV.DataSource = dt;
              
               
            }
            else
            {
                RJMessageBox.Show("The id is invalid! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                idTxt.Focus();
            }
        }

        internal void getProductByCategory(int category, DataGridView DGV)
        {
            DGV.DataSource = ProductDAO.Instance.getProductByCategory(category);
        }

        internal void getProductByBrand(int brand, DataGridView DGV)
        {
            DGV.DataSource = ProductDAO.Instance.getProductByBrand(brand);
        }

        internal bool checkValidQuantity(int id, int quantity)
        {

            return ProductDAO.Instance.checkValidQuantity(id, quantity);
        }

        internal void loadProductCombobox(ComboBox comboBox)
        {
            DataTable dt = ProductDAO.Instance.GetDataTableIncludeInactive();
            List<Product> datasource = new List<Product>();
            datasource.Add(new Product(-1,""));
            foreach (DataRow dr in dt.Rows)
            {
                datasource.Add(new Product((int)dr["id"], dr["name"].ToString()));
            }
            comboBox.DataSource = datasource;
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "id";
        }

        internal  void ImportExcelData(string filePath)
        {
            // Call the model to read Excel file and get DataTable
            DataTable excelData = ProductDAO.Instance.ReadExcelFile(filePath);

            // Call the model to insert data into the database
            ProductDAO.Instance.InsertDataIntoDatabase(excelData, "YourConnectionString");
        }
    }
}
