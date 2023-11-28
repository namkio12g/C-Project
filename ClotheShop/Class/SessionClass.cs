using ClotheShop.Class.BLL;
using ClotheShop.Class.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotheShop.Class
{

    internal class SessionClass
    {
        private static SessionClass instance;
        private bool creatingBillFlag =true;
        private Account account=null;
        private List<int> list_action = new List<int>();
        private int UserRole;

        public DataTable GetDataGridViewAsDataTable(DataGridView _DataGridView)
        {
            try
            {
                if (_DataGridView.ColumnCount == 0) return null;
                DataTable dtSource = new DataTable();
                //////create columns
                foreach (DataGridViewColumn col in _DataGridView.Columns)
                {
                    if (col.ValueType == null) dtSource.Columns.Add(col.Name, typeof(string));
                    else dtSource.Columns.Add(col.Name, col.ValueType);
                    dtSource.Columns[col.Name].Caption = col.HeaderText;
                }
                ///////insert row data
                foreach (DataGridViewRow row in _DataGridView.Rows)
                {
                    DataRow drNewRow = dtSource.NewRow();
                    foreach (DataColumn col in dtSource.Columns)
                    {
                        drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    }
                    dtSource.Rows.Add(drNewRow);
                }
                return dtSource;
            }
            catch
            {
                return null;
            }
        }
        public static SessionClass Instance
        {
            get
            {
                if (instance == null)
                    return instance =new SessionClass();
                 else
                    return instance;
            }
            private set => instance = value;
        }

        public bool CreatingBillFlag
        {
            get => creatingBillFlag;
            set => creatingBillFlag = value;
        }
        public List<int> List_action
        {
            get => list_action;
            set {
                list_action=ActionBLL.Instance.GetListActionFromUser(account.ID1);
            
            }
        }

        public int UserRole1
        {
            get => UserRole;
            set => UserRole = value;
        }
        internal Account Account
        {
            get => account;
            set => account = value;
        }
        public byte[] imageToByte(Image image)
        {
            if (image != null)
            {
                try
                {
                    using (var ms = new MemoryStream())
                    {
                        ms.Position = 0;
                        image.Save(ms, ImageFormat.Png);
                        return ms.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    // Log or print exception details
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
            else
            {
                
                return new byte[0]; 
            }
        }
    }
}
