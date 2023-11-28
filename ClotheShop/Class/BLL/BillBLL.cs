using ClotheShop.Class.DAO;
using ClotheShop.Class.DTO;
using ClotheShop.CustomControl;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.BLL
{
    internal class BillBLL
    {
        private static BillBLL instance;
        public static BillBLL Instance
        {
            get
            {
                if (instance == null)
                    return instance = new BillBLL();
                else return BillBLL.instance;
            }
            private set => BillBLL.instance = value;
        }
        internal List<ActionDetail> GetListActionDetail()
        {
            List<ActionDetail> list = new List<ActionDetail>();
            System.Data.DataTable dt = ActionDAO.Instance.getDatatableDetail();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new ActionDetail(dr));
            }
            return list;


        }
        internal List<ActionObject> GetListAction()
        {
            List<ActionObject> list = new List<ActionObject>();
            System.Data.DataTable dt = ActionDAO.Instance.getDatatable();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new ActionObject(dr));
            }
            return list;


        }
        internal bool createABill(string customerName, int billId, DateTime dateCreated, string createdBy, string customerPhone, string customerAddress,int total)
        {
            return BillDAO.Instance.createABill(customerName, customerPhone, customerAddress, dateCreated, createdBy, billId,total);
        }
        internal bool insertBillDetail(int productId, int billId, int quantity)
            {
            return BillDAO.Instance.InsertBillDetail(billId,productId, quantity);
        }

        internal void GetDataTable(DataGridView DGV)
        {
            DGV.DataSource = BillDAO.Instance.GetDataTable();
        }

        internal Bill getBillById(int id)
        {
            return new Bill(BillDAO.Instance.GetBillById(id).Rows[0]);
        }
        internal List<ProductBill> getProductListById(int id,DataGridView DGV)
        {
            DGV.DataSource=BillDAO.Instance.GetProductListById(id);
            return new List<ProductBill>();
        }

        internal void GetDataTableSearched(DataGridView DGV, string id, string name, string botPrice, string topPrice, string timeTop, string timeBot, List<Product> list)
        {
         
            DGV.DataSource = BillDAO.Instance.GetDataTableSearch(id, name , botPrice, topPrice, timeTop, timeBot,list);

        }

        internal bool DeleteBill(string text)
        {
            int id = Convert.ToInt32(text);
            return BillDAO.Instance.DeleteBill(id);
        }
    }
}
