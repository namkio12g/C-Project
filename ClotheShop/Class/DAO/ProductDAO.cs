using ClotheShop.Class.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using ClosedXML.Excel;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ClotheShop.Class.DAO
{
    internal class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                    return instance = new ProductDAO();
                else return ProductDAO.instance;
            }
            private set => ProductDAO.instance = value;
        }
        public DataTable GetDataTable()
        {
            string sql = "SELECT p.ID,p.Name,p.Price,c.name as Category ,p.brand as Brand,p.Quantity ,p.Active" +
                " FROM category as c,(select p.ID,p.name,p.Price,b.name as brand,p.category,p.Quantity,p.active " +
                "from product as p,brand as b where b.id=p.brand) as p Where c.id= p.category AND p.active = 1";
            return DataProvider.Instance.ExecuteQuery(sql);
        }
        public DataTable GetDataTableIncludeInactive()
        {
            string sql = "SELECT p.ID,p.name,p.Price,c.name as Category ,p.brand as Brand,p.Quantity ,p.Active" +
                " FROM category as c,(select p.ID,p.name,p.Price,b.name as brand,p.category,p.Quantity,p.active " +
                "from product as p,brand as b where b.id=p.brand) as p Where c.id= p.category ";
            return DataProvider.Instance.ExecuteQuery(sql);
        }
        public Product getProductbyId(int id)
        { string sql = "SELECT p.id,p.name,p.price,CONCAT(c.id, ' - ', c.name) as category,CONCAT(b.id, ' - ', b.name) as brand,p.quantity,p.image,p.Description," +
                "a.UserName as Created_by,p.Created_Date,r.UserName as Edited_by,p.Edited_Date,p.active " +
                " FROM product AS p" +
                " INNER JOIN  category AS c ON p.category = c.id" +
                " INNER JOIN brand AS b ON p.brand = b.id" +
                " LEFT JOIN account as a on a.id = p.created_by" +
                " LEFT JOIN account as r on r.id = p.edited_by" +
                " WHERE p.id = @ID ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql, new object[] { id });
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DataRow dr = dt.Rows[0];
            Product pd = new Product(dr);
            return pd;
        }
        public bool Insert(Product product){
            string sql = "INSERT INTO product (name,price,brand,category,quantity,image,description,created_by,created_date,edited_by,edited_date ,active)" +
                " VALUES ( @name , @price , @brand , @category , @quantity , @image , @description , @created_by , @created_date , @edited_by , @edited_date ,1 )";
            return DataProvider.Instance.ExecuteInsertGetID(sql, new Object[] { 
                product.Name,product.Price,product.BrandID,product.CategoryID,product.Quantity,product.Image,product.Description,SessionClass.Instance.Account.ID1,
                product.Created_date,SessionClass.Instance.Account.ID1,product.Edited_date
            }) > -1;
            }

        public bool Update(Product product)
        {
            string sql = "UPDATE product SET name =  @name ,price = @price ,brand = @brand ,category = @category ,quantity = @quantity ,image = @image , description = @description ,edited_date = @date ,edited_by = @by ,active = @active WHERE id = @id";
            return DataProvider.Instance.ExcuteNonQuery(sql, new Object[] {
                product.Name,product.Price,product.BrandID,product.CategoryID,product.Quantity,product.Image,product.Description,DateTime.Now,SessionClass.Instance.Account.ID1,product.Active,product.Id
            }) ;
        }

        internal bool Delete(int id)
        {
            string sql= "UPDATE product SET active=0 WHERE id = @id ";
            return DataProvider.Instance.ExecuteScalar(sql, new Object[] { id })>-1;
        }

        internal DataTable GetDataTableSearch(string id, string name, int brand, int cate, string botP, string topP, string botQ, string topQ, string botT, string topT,bool active)
        {
            int idnum = -1;
            List<Object> listObject = new List<Object>();
            listObject.Add(botP.ToString());
            listObject.Add(topP.ToString());
            listObject.Add(botQ.ToString());
            listObject.Add(topQ.ToString());
            string sql = "SELECT p.id,p.name,p.price,c.name as category,b.name as brand,p.quantity,p.active" +
              
                 " FROM product AS p" +
                 " INNER JOIN  category AS c ON p.category = c.id" +
                 " INNER JOIN brand AS b ON p.brand = b.id" +
                 " LEFT JOIN account as a on a.id = p.created_by" +
                 " LEFT JOIN account as r on r.id = p.edited_by" +
                 " WHERE p.price > @botP AND p.price < @topP AND p.quantity > @botQ AND p.quantity < @topQ";
            if (id != "")
            {
                sql += " AND p.id = @id";
                idnum = Convert.ToInt32(id);
                listObject.Add((int)idnum);
            }
            if(name != "")
            {
                sql += " AND p.name LIKE @name";
                name="%"+name+"%";
                listObject.Add(name);
            }
            if (!active)
            {
                sql += " AND p.active = 1 ";
            }
            if (brand != -1)
            {
                sql += " AND p.brand = @brand";
                listObject.Add(brand);
            }
            if (cate != -1)
            {
                sql += " AND p.category = @cate";
                listObject.Add(cate);
            }
            if (topT != "")
            {
                sql += " AND p.created_date <= @topT AND p.created_date >= @botT ";
                listObject.Add(topT);
                listObject.Add(botT);
            }
            
            return DataProvider.Instance.ExecuteQuery(sql, listObject.ToArray());
        }

        internal object getProductByCategory(int category)
        {
            string sql = "SELECT Id,name as Product_Name ,Active FROM product WHERE category = @category ";
            return DataProvider.Instance.ExecuteQuery(sql, new Object[] {category});
        }
        internal object getProductByBrand(int brand)
        {
            string sql = "SELECT Id,name as Product_Name ,Active FROM product WHERE brand = @brand ";
            return DataProvider.Instance.ExecuteQuery(sql, new Object[] { brand });
        }

        internal bool checkValidQuantity(int id, int quantity)
        {
            string sql = "SELECT 1 FROM product WHERE id = @id AND quantity >= @quantity ";
            return DataProvider.Instance.ExecuteScalar(sql, new Object[] { id,quantity })==1;
        }



        internal DataTable ReadExcelFile(string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1); // Assuming data is in the first sheet
                    var dataTable = new DataTable();

                    // Assuming the first row contains column names
                    foreach (var cell in worksheet.Row(1).CellsUsed())
                    {
                        dataTable.Columns.Add(cell.Value.ToString());
                    }

                    // Read data from Excel and populate DataTable
                    for (int row = 2; row <= worksheet.LastRowUsed().RowNumber(); row++)
                    {
                        var dataRow = dataTable.NewRow();

                        for (int col = 1; col <= worksheet.LastColumnUsed().ColumnNumber(); col++)
                        {
                            dataRow[col - 1] = worksheet.Cell(row, col).Value.ToString();
                        }

                        dataTable.Rows.Add(dataRow);
                    }

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"Error reading Excel file: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal void InsertDataIntoDatabase(DataTable dataTable, string connectionString)
        {   
            List<string> expectedColumnNames=new List<string>() { "Name", "Description", "Category" , "Brand","Price","Quantity" };
            bool flag = true;
            foreach (string columnName in expectedColumnNames)
            {
                if (!dataTable.Columns.Contains(columnName))
                {
                    flag = false;
                }
            }
            if (!flag)
            {
                RJMessageBox.Show("Sai dinh dang file excel,vui long lua chon dung file ","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else { 
            if (dataTable != null )
            {
               

                        foreach (DataRow row in dataTable.Rows)
                        {
      

                                Insert(new Product(row["Name"].ToString(), row["Description"].ToString(), row["Category"].ToString(), row["Brand"].ToString()
                                    , new byte[0], DateTime.Now, "", ""
                                    )
                                {
                                    Price=Convert.ToInt32(row["Price"]),
                                    Quantity = Convert.ToInt32(row["Quantity"])
                                }); 
                     ;
                            
                        }
                    RJMessageBox.Show("Successful! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    RJMessageBox.Show("Sai dinh dang file excel,vui long lua chon dung file ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

        }


    }
    }
