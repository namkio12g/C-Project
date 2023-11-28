using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DTO
{
    internal class ActionObject
    {
        private int id;
        private string name;

        public ActionObject(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public ActionObject(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
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
        public override string ToString()
        {
            return name;
        }
    }
}
