﻿using ClotheShop.Class.DTO;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Bibliography;

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
            if (timeBottom > timeTop)
                MessageBox.Show("Vui long chon thoi gian hop li", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        internal DataTable GetStatisticByCategory(int id, DateTime timeTop, DateTime timeBottom)
        {
            if (timeBottom > timeTop)
                MessageBox.Show("Vui long chon thoi gian hop li", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            /// Create a dictionary to store month and corresponding days
        Dictionary<int, int> monthDaysMap = new Dictionary<int, int>();

            // Populate the dictionary with months and days
            monthDaysMap.Add(0, 31); // January
            monthDaysMap.Add(1, 28); // February (Leap year handling is not considered in this example)
            monthDaysMap.Add(2, 31); // March
            monthDaysMap.Add(3, 30); // April
            monthDaysMap.Add(4, 31); // May
            monthDaysMap.Add(5, 30); // June
            monthDaysMap.Add(6, 31); // July
            monthDaysMap.Add(7, 31); // August
            monthDaysMap.Add(8, 30); // September
            monthDaysMap.Add(9, 31); // October
            monthDaysMap.Add(10, 30); // November
            monthDaysMap.Add(11, 31); // December
            DateTime bot = new DateTime(timeBottom.Year, timeBottom.Month, 1);
            DateTime top = new DateTime(timeTop.Year, timeTop.Month, monthDaysMap[timeTop.Month - 1]);

            if (bot > top)
                MessageBox.Show("Vui long chon thoi gian hop li","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            string sql = "SELECT MONTH(date_created) AS month, SUM(total) AS total_sum " +
                "FROM bill WHERE date_created >= @timebot AND date_created <= @timetop " +
                "GROUP BY MONTH(date_created) ORDER BY month ASC;";
            return DataProvider.Instance.ExecuteQuery(sql,new Object[] {timeBottom, timeTop });
        }

        internal DataTable GetStatisticByYear(DateTime timeTop, DateTime timeBottom)
        {
            DateTime yearTop = new  DateTime(timeTop.Year,12,31);
            DateTime yearBot = new DateTime(timeBottom.Year,1,1);
            if(timeTop.Year < timeBottom.Year)
            {
                MessageBox.Show("Vui long chon time hop li","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            string sql = "SELECT Year(date_created) AS year, SUM(total) AS total_sum " +
                  "FROM bill WHERE date_created >= @timebot AND date_created <= @timetop " +
                  "GROUP BY YEAR(date_created) ORDER BY year ASC;";
            return DataProvider.Instance.ExecuteQuery(sql, new Object[] { yearBot, yearTop });
        }
    }
}
