using ClotheShop.Class.DAO;
using ClotheShop.Class.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.BLL
{
    internal class ActionBLL
    {
        private static ActionBLL instance;
        public static ActionBLL Instance
        {
            get
            {
                if (instance == null)
                    return instance = new ActionBLL();
                else return ActionBLL.instance;
            }
            private set => ActionBLL.instance = value;
        }
        internal List<ActionDetail> GetListActionDetail()
        {
            List<ActionDetail> list = new List<ActionDetail>();
            DataTable dt = ActionDAO.Instance.getDatatableDetail();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new ActionDetail(dr));
            }
            return list;


        }
        internal List<ActionDetail> GetListActionDetailOneRole(int id)
        {
            List<ActionDetail> list = new List<ActionDetail>();
            DataTable dt = ActionDAO.Instance.getDatatableDetailOneRole(id);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new ActionDetail(dr));
            }
            return list;


        }
        internal List<ActionObject> GetListAction()
        {
            List<ActionObject> list = new List<ActionObject>();
            DataTable dt = ActionDAO.Instance.getDatatable();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new ActionObject(dr));
            }
            return list;


        }

        internal void UpdateActionDetail(int actionID, int roleId, bool isChecked)
        {
            if(isChecked)
            {
                ActionDAO.Instance.InsertActionDetail(actionID, roleId);
            }
            else
            {
                ActionDAO.Instance.DeleteActionDetail(actionID,roleId);
            }
        }

        internal List<int> GetListActionFromUser(int id)
        {
            List<int> list=new List<int>();
            DataTable dt = ActionDAO.Instance.GetListActionFromUser(id);
            foreach(DataRow dataRow in dt.Rows)
            {
                list.Add((int)dataRow["id_authority"]);
            }
            return list;
        }
    }
}
