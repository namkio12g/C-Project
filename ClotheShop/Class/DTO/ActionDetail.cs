using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DTO
{
    internal class ActionDetail
    {
        private int idAction;
        private int idRole;

        public ActionDetail(int idAction, int idRole)
        {
            this.idAction = idAction;
            this.idRole = idRole;
        }
        public ActionDetail(DataRow row)
        {
            this.idAction = (int)row["id_authority"];
            this.idRole = (int)row["id_role"];
        }


        public int IdAction
        {
            get => idAction;
            set => idAction = value;
        }
        public int IdRole
        {
            get => idRole;
            set => idRole = value;
        }

    }
}
