using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DTO
{
    internal class Brand
    {
        private string name;
        private int id;
        private int active;

        public Brand(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public Brand(DataRow row)
        {
            this.name = row["name"].ToString();
            this.id = (int)row["ID"];
            this.active= (int)row["active"];
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
        public int Active
        {
            get => active;
            set => active = value;
        }
    }
}
