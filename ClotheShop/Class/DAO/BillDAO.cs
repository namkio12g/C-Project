using ClotheShop.Class.BLL;
using ClotheShop.Class.DTO;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClotheShop.Class.DAO
{
    internal class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    return instance = new BillDAO();
                else return BillDAO.instance;
            }
            private set => BillDAO.instance = value;
        }

        internal bool createABill(string name,string phone,string address,DateTime dateCreated,string createdBy,int billId,int total)
        {
            string sql = " INSERT INTO bill  (ID,Date_created,Created_by,Customer_Name,Customer_Phone,Customer_address,total) VALUES ( @id , @date , @by , @name , @phone , @address , @total )";
            return DataProvider.Instance.ExecuteScalar(sql, new Object[] { billId,dateCreated,createdBy,name,phone,address,total }) > -1;
        }

        internal System.Data.DataTable GetBillById(int id)
        {
            string sql = " SELECT b.id,b.Customer_name,b.Customer_phone,b.Customer_address,b.Date_created,a.Username AS CreatedBy_name,b.total FROM bill AS b INNER JOIN account AS a ON b.Created_by = a.id WHERE b.id= @id ";
            return DataProvider.Instance.ExecuteQuery(sql,new Object[] {id});
        }
         internal System.Data.DataTable GetProductListById(int id)
        {
            string sql = " SELECT p.Name AS Name,bd.Quantity,p.price*bd.quantity AS Total FROM bill_detail AS bd INNER JOIN product AS p ON p.id = bd.product_id WHERE bd.Bill_id= @id ";
            return DataProvider.Instance.ExecuteQuery(sql,new Object[] {id});
        }

        internal System.Data.DataTable GetDataTable()
        {
            string sql = " SELECT b.Id,b.Customer_name,b.Customer_phone,a.Username AS Created_by FROM bill AS b INNER JOIN account AS a ON b.Created_by = a.id";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        internal bool InsertBillDetail(int billId,int idproduct,int quantity)
        {
            string sql = " INSERT INTO bill_detail  (Bill_id,Product_id,Quantity) VALUES ( @id , @idproduct , @quantity )";
            return DataProvider.Instance.ExecuteScalar(sql, new Object[] { billId, idproduct,quantity }) > -1;
        }

        internal System.Data.DataTable GetDataTableSearch(string id, string phone, string botPrice, string topPrice, string timeTop, string timeBot, List<Product> list)
        {
            int idnum = -1;
            List<Object> listObject = new List<Object>();
            //listObject.Add(botPrice);
            //listObject.Add(topPrice);
            string sql = " SELECT b.id,b.Customer_Name,b.Customer_phone,a.Username AS created_by FROM bill AS b INNER JOIN account AS a ON b.Created_by = a.id ";
            if(list.Count > 0) {
                sql += "INNER JOIN bill_detail bd ON b.id = bd.bill_id WHERE bd.product_id IN ( ";
                for (int i =0;i<list.Count-1;i++)
                {
                    sql += $"@pd{i} , ";
                    listObject.Add(list[i].Id);
                }
                sql += $"@pd{list.Count-1} )";
                listObject.Add(list[list.Count-1].Id);
            }
            else
            {
                sql += " WHERE 1=1";
            }
            if (id != "")
            {
                sql += " AND b.id= @id ";
                listObject.Add(Convert.ToInt32(id));
            }
            if(phone != "")
            {
                sql += " AND b.Customer_phone LIKE @phone";
                phone = "%" + phone + "%";
                listObject.Add(phone);
            }
            if (timeTop != "")
            {
                sql += " AND b.date_created <= @topT AND b.date_created  >= @botT ";
                listObject.Add(timeTop);
                listObject.Add(timeBot);
            }
            listObject.Add(botPrice);
            listObject.Add(topPrice);
            sql += " AND b.total >= @botP AND b.total <= @topP";
            return DataProvider.Instance.ExecuteQuery(sql ,listObject.ToArray());
        }

        internal bool DeleteBill(int id)
        {
            string sql = "DELETE FROM bill WHERE id = @id ";
            return DataProvider.Instance.ExecuteScalar(sql, new Object[] {
                id
                           }) > -1;
        }
    }
}
