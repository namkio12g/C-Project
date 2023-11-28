using ClotheShop.Class.DAO;
using ClotheShop.Class.DTO;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ClotheShop.Class.BLL
{
    internal class StatisticBLL
    {
        private static StatisticBLL instance;

        public static StatisticBLL Instance
        {
            get
            {
                if (instance == null)
                    return instance = new StatisticBLL();
                else return StatisticBLL.instance;
            }
            private set => StatisticBLL.instance = value;
        }
        public DataTable GetStatisticByMonth(DateTime timeTop, DateTime timeBottom)
        { return StatisticDAO.Instance.GetStatisticByMonth(timeTop,timeBottom);
            
        }
        public DataTable GetStatisticByYear( DateTime timeTop, DateTime timeBottom)
        {
            return StatisticDAO.Instance.GetStatisticByYear(timeTop, timeBottom);
            
        }

        internal DataTable GetStatisticByBrand(int id, DateTime timeTop, DateTime timeBottom)
        {   return StatisticDAO.Instance.GetStatisticByBrand(id,timeTop, timeBottom);
            
        }

        internal DataTable GetStatisticByCategory( int id ,DateTime timeTop, DateTime timeBottom)
        {
            return StatisticDAO.Instance.GetStatisticByCategory(id, timeTop, timeBottom);
        }
    }
}
