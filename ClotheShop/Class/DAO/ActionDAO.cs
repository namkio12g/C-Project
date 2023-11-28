using ClotheShop.Class.BLL;
using ClotheShop.Class.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class.DAO
{
    internal class ActionDAO
    {
        private static ActionDAO instance;
        public static ActionDAO Instance
        {
            get
            {
                if (instance == null)
                    return instance = new ActionDAO();
                else return ActionDAO.instance;
            }
            private set => ActionDAO.instance = value;
        }

        internal bool DeleteActionDetail(int actionID, int roleId)
        {
            string sql = "DELETE FROM authority_detail WHERE ID_role = @id1 AND ID_authority = @id2";
            return DataProvider.Instance.ExecuteScalar(sql, new Object[] {
                roleId, actionID
                        }) > -1;
        }
        internal DataTable GetListActionFromUser(int id)
        {
            string sql = "SELECT ad.id_authority FROM authority_detail AS ad INNER JOIN (SELECT u.role FROM user AS u INNER JOIN account AS a ON a.id_user = u.id WHERE a.id = @id ) AS u "+
                " ON u.role = ad.id_role";
            return DataProvider.Instance.ExecuteQuery(sql, new Object[] { id });
        }

        internal DataTable getDatatable()
        {
            string sql = " SELECT * FROM authority";
            return DataProvider.Instance.ExecuteQuery(sql);
        }
        internal DataTable getDatatableDetail()
        {
            string sql = " SELECT * FROM authority_detail";
            return DataProvider.Instance.ExecuteQuery(sql);
        }
        internal DataTable getDatatableDetailOneRole(int id)
        {
            string sql = " SELECT * FROM authority_detail WHERE id_role = @id ";
            return DataProvider.Instance.ExecuteQuery(sql,new Object[] {id});
        }

        internal bool InsertActionDetail(int actionID, int roleId)
        {
            string sql = "INSERT INTO authority_detail (id_role,id_authority) VALUES ( @id1 , @id2 )";
            return DataProvider.Instance.ExecuteScalar(sql, new Object[] {
                roleId, actionID
                        }) > -1;
        }
    }
}
