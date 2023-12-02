using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DTO
{
    internal class User
    {


        private int id;
            private string Name;
            private string Address;
            private string Phone;
            private string Email;
            private string CCCD;
            private string role;
        private int roleID;
        private int active;
            public User(string name,int id)
            {
                this.Name = name;
                this.Id = id;
           
            }
        public User(string name, string address, string phone, string email, string CCCD)
        {

            this.Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            CCCD1 = CCCD;
        }
        public User(int id,string name, string address, string phone, string email, string CCCD,int roleID,int active)
        {
            this.id = id;
            this.Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            CCCD1 = CCCD;
            RoleID= roleID;
            Active = active;
        }
        public User(DataRow row)
        {
            Name = row["Name"].ToString();
            Id = (int)row["ID"];
            Address = row["Address"].ToString();
            Phone = row["Phone"].ToString();
            Email = row["email"].ToString();
            Role = row["Role"].ToString();
            CCCD = row["CCCD"].ToString();
            active = (int)row["active"];
            
            
        }

            public string Name1
            {
                get => Name;
                set => Name = value;
            }
            public string Address1
            {
                get => Address;
                set => Address = value;
            }
            public string Phone1
            {
                get => Phone;
                set => Phone = value;
            }
            public string Email1
            {
                get => Email;
                set => Email = value;
            }
            public string CCCD1
            {
                get => CCCD;
                set => CCCD = value;
            }
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Role
        {
            get => role;
            set => role = value;
        }
        public int Active
        {
            get => active;
            set => active = value;
        }
        public int RoleID
        {
            get => roleID;
            set => roleID = value;
        }
    }
}
