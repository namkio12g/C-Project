﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DTO
{
    internal class Role
    {
        private string name;
        private int id;
        private int active;

        public Role(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public Role(DataRow row)
        {
            this.name = row["name"].ToString();
            this.id= (int)row["ID"];
            this.active = (int)row["active"];
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }
        public int Active
        {
            get => active;
            set => active = value;
        }
    }
}
