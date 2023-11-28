using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DTO
{
    internal class ProductBill
    {
        private int id;
        private string name;
        private int price;
        private int quantity;
        private int total;

        public ProductBill(int id, string name, int price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.total = price * quantity;
        }
        public ProductBill(DataRow row)
        {
            this.name = row["product_name"].ToString();
            this.quantity = (int)row["quantity"];
            this.price = (int)row["product_price"];
            this.total = price * quantity;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Price
        {
            get => price;
            set => price = value;
        }
        public int Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
                UpdateTotal();
            }
        }
        public int Total
        {
            get => total;
            set => total = value;
        }
        public void UpdateTotal()
        {
            this.total = quantity * price;
        }
    }
}
