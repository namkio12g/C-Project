using ClotheShop.Class.DTO;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace ClotheShop.Class.DAO
{
    internal class StatisticDAO
    {
        private static StatisticDAO instance;
        public static StatisticDAO Instance
        {
            get
            {
                if (instance == null)
                    return instance = new StatisticDAO();
                else return StatisticDAO.instance;
            }
            private set => StatisticDAO.instance = value;
        }

        internal DataTable GetStatisticByBrand(int id,DateTime timeTop, DateTime timeBottom)
        {   List<object> list = new List<object>(); 
            string sql = "SELECT p.name,p.price * bd.quantity AS total_sum " +
                            "FROM bill_detail as bd INNER JOIN ( " +
                        " SELECT br.name,p.id,br.id AS brand,p.price FROM product as p INNER JOIN brand AS br ON p.brand = br.id " +
                        " ) AS p ON p.id = bd.product_id " +
                        " INNER JOIN bill as b ON b.id = bd.bill_id " +
                        " WHERE b.date_created >= @timebot AND b.date_created < @timetop ";
            if(id > -1)
            {

                sql = "SELECT p.name,p.price * bd.quantity AS total_sum " +
                            "FROM bill_detail as bd INNER JOIN ( " +
                        " SELECT p.name,p.id,br.id AS brand,p.price FROM product as p INNER JOIN brand AS br ON p.brand = br.id " +
                        " ) AS p ON p.id = bd.product_id " +
                        " INNER JOIN bill as b ON b.id = bd.bill_id " +
                        " WHERE b.date_created >= @timebot AND b.date_created < @timetop AND ";
                sql += " p.brand = @id ";
                list.Add(timeBottom);
                list.Add(timeTop);
                list.Add(id);
                sql += " GROUP BY p.id ";
                return DataProvider.Instance.ExecuteQuery(sql, list.ToArray());
            }
            else
            {
                sql = "SELECT p.name,p.price * bd.quantity AS total_sum " +
                            "FROM bill_detail as bd INNER JOIN ( " +
                        " SELECT br.name,p.id,br.id AS brand,p.price FROM product as p INNER JOIN brand AS br ON p.brand = br.id " +
                        " ) AS p ON p.id = bd.product_id " +
                        " INNER JOIN bill as b ON b.id = bd.bill_id " +
                        " WHERE b.date_created >= @timebot AND b.date_created < @timetop ";
                list.Add(timeBottom);
                list.Add(timeTop);
                sql += " GROUP BY p.brand ";
                return DataProvider.Instance.ExecuteQuery(sql, list.ToArray());
            }
          
        
        }

        internal DataTable GetStatisticByCategory(int id, object timeTop, object timeBottom)
        {
            List<object> list = new List<object>();
            string sql = "";
            if (id > -1)
            {

                sql = "SELECT p.name,p.price * bd.quantity AS total_sum " +
                            "FROM bill_detail as bd INNER JOIN ( " +
                        " SELECT p.name,p.id,c.id AS cate,p.price FROM product as p INNER JOIN category AS c ON p.brand = c.id " +
                        " ) AS p ON p.id = bd.product_id " +
                        " INNER JOIN bill as b ON b.id = bd.bill_id " +
                        " WHERE b.date_created >= @timebot AND b.date_created < @timetop AND ";
                sql += " p.cate = @id ";
                list.Add(timeBottom);
                list.Add(timeTop);
                list.Add(id);
                sql += " GROUP BY p.id ";
                return DataProvider.Instance.ExecuteQuery(sql, list.ToArray());
            }
            else
            {
                sql = "SELECT p.name,p.price * bd.quantity AS total_sum " +
                            "FROM bill_detail as bd INNER JOIN ( " +
                        " SELECT c.name,p.id,c.id AS cate,p.price FROM product as p INNER JOIN category AS c ON p.brand = c.id " +
                        " ) AS p ON p.id = bd.product_id " +
                        " INNER JOIN bill as b ON b.id = bd.bill_id " +
                        " WHERE b.date_created >= @timebot AND b.date_created < @timetop ";
                list.Add(timeBottom);
                list.Add(timeTop);
                sql += " GROUP BY p.cate ";
                return DataProvider.Instance.ExecuteQuery(sql, list.ToArray());
            }
        }

        internal  DataTable GetStatisticByMonth(DateTime timeTop, DateTime timeBottom)
        {
          
            string sql = "SELECT MONTH(date_created) AS month, SUM(total) AS total_sum " +
                "FROM bill WHERE date_created >= @timebot AND date_created <= @timetop " +
                "GROUP BY MONTH(date_created) ORDER BY month ASC;";
            return DataProvider.Instance.ExecuteQuery(sql,new Object[] {timeBottom, timeTop });
        }

        internal DataTable GetStatisticByYear(DateTime timeTop, DateTime timeBottom)
        {
            DateTime yearTop = new  DateTime(timeTop.Year,12,31);
            DateTime yearBot = new DateTime(timeBottom.Year,1,1);

            string sql = "SELECT Year(date_created) AS year, SUM(total) AS total_sum " +
                  "FROM bill WHERE date_created >= @timebot AND date_created <= @timetop " +
                  "GROUP BY YEAR(date_created) ORDER BY year ASC;";
            return DataProvider.Instance.ExecuteQuery(sql, new Object[] { yearBot, yearTop });
        }
    }
}
