using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DTO
{
    internal class Bill
    {
        private int id;
        private string customerName;
        private string customerPhone;
        private string customerAddress;
        private int total;
        private int id_createdby;
        private string created_by;
        private DateTime date_created;

        public Bill(int id, string customerName, string customerPhone, string customerAddress, int total, int id_createdby, string created_by, DateTime date_created)
        {
            this.Id = id;
            CustomerName = customerName;
            CustomerPhone= customerPhone;
            CustomerAddress = customerAddress;
            this.Total = total;
            this.Id_createdby = id_createdby;
            this.Created_by = created_by;
            this.Date_created = date_created;
        }
        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            CustomerName = row["customer_name"].ToString();
            CustomerPhone = row["customer_phone"].ToString();
            CustomerAddress = row["customer_address"].ToString();
            this.Total = (int)row["total"];
         
            this.Created_by = row["CreatedBy_name"].ToString();
            this.Date_created = (DateTime)row["date_created"];
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string CustomerName
        {
            get => customerName;
            set => customerName = value;
        }
        public string CustomerPhone
        {
            get => customerPhone;
            set => customerPhone = value;
        }
        public string CustomerAddress
        {
            get => customerAddress;
            set => customerAddress = value;
        }
        public int Total
        {
            get => total;
            set => total = value;
        }
        public int Id_createdby
        {
            get => id_createdby;
            set => id_createdby = value;
        }
        public string Created_by
        {
            get => created_by;
            set => created_by = value;
        }
        public DateTime Date_created
        {
            get => date_created;
            set => date_created = value;
        }
    }
}
