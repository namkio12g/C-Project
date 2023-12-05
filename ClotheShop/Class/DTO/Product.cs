using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DTO
{
    internal class Product
    {
        private int id;
        private string name;
        private string description;
        private int price;
        private int quantity;
        private string category;
        private string brand;
        private int categoryID;
        private int brandID;
        private byte[] image;
        private DateTime created_date;
        private DateTime edited_date;
        private string created_by;  
        private string edited_by;
        private int active;

        public Product(DataRow data)
        {
            this.id = (int)data["id"];
            this.name = data["name"].ToString();
            this.description = data["description"].ToString();
            this.price = (int)data["price"];
            this.quantity = (int)data["quantity"];
    
            this.category = data["category"].ToString();
            this.brand = data["brand"].ToString();
            if (data["Image"]!= System.DBNull.Value)
                this.image = (byte[])data["Image"];
            else
                this.image = new byte[0];
            this.created_date = (DateTime)data["Created_Date"];
            this.edited_date = (DateTime)data["Edited_Date"];
            this.created_by = data["Created_by"].ToString(); 
            this.edited_by = data["Edited_by"].ToString();

            this.active = (int)data["active"];
        }
        public Product(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Product(int id, string name, string description, int price, int quantity
          , string category, string brand, byte[] image, DateTime created_date, 
            DateTime edited_date, string created_by, string edited_by)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.brand = brand;
            this.image = image;
            this.created_date = created_date;
            this.edited_date = edited_date;
            this.created_by = created_by;
            this.edited_by = edited_by;
        }
        public Product( string name, string description
            , string categoryID, string branchID, byte[] image, DateTime today, string created_by, string edited_by)
        {
            this.name = name;
            this.description = description;
            this.CategoryID = Convert.ToInt16(categoryID);
            this.BrandID = Convert.ToInt16(branchID);
            this.image = image;
            this.created_date = today;
            this.edited_date = today;
            this.created_by = created_by;
            this.edited_by = edited_by;
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
        public string Description
        {
            get => description;
            set => description = value;
        }
        public int Price
        {
            get => price;
            set => price = value;
        }
        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public string Category
        {
            get => category;
            set => category = value;
        }
        public string Brand
        {
            get => brand;
            set => brand = value;
        }
        public byte[] Image
        {
            get => image;
            set => image = value;
        }
        public DateTime Created_date
        {
            get => created_date;
            set => created_date = value;
        }
        public DateTime Edited_date
        {
            get => edited_date;
            set => edited_date = value;
        }
        public string Created_by
        {
            get => created_by;
            set => created_by = value;
        }
        public string Edited_by
        {
            get => edited_by;
            set => edited_by = value;
        }
        public int CategoryID
        {
            get => categoryID;
            set => categoryID = value;
        }
        public int BrandID
        {
            get => brandID;
            set => brandID = value;
        }
        public int Active
        {
            get => active;
            set => active = value;
        }
    }
}
