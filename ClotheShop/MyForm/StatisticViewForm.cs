using ClotheShop.Class;
using ClotheShop.Class.BLL;
using ClotheShop.Class.DTO;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using Category = ClotheShop.Class.DTO.Category;
using Color = System.Drawing.Color;
using DataPoint = System.Windows.Forms.DataVisualization.Charting.DataPoint;
using DataTable = System.Data.DataTable;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace ClotheShop.MyForm
{
    public partial class StatisticViewForm : Form
    {
        private Random random = new Random();

        public StatisticViewForm()
        {
            InitializeComponent();
        }

        private void StatisticShow_Click(object sender, EventArgs e)
        {
            int statistic = StatisticsCb.SelectedIndex;

            switch (statistic)
            {

                case 0:
                    DataTable dt = StatisticBLL.Instance.GetStatisticByMonth(dateTimePickerTop.Value, dateTimePickerBot.Value);
                    ColumnChart.Series.Clear();
                    ColumnChart.BringToFront();
                    ColumnChart.Titles.Clear();
                    Series series = new Series();
                    series.ChartType = SeriesChartType.Column;
                    int totalSum = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        int total = Convert.ToInt32(row["total_sum"]);
                        totalSum += total;
                    }
                    // Bind the series to the DataTable
                    series.Points.DataBind(dt.DefaultView, "month", "total_Sum", "");
                    series.IsValueShownAsLabel = true;
                    int red = 0;
                    int green = 0;
                    int blue = 0;
                    foreach (DataPoint dataPoint in series.Points)
                    {
                        dataPoint.LabelForeColor = System.Drawing.Color.Black; // Set the label color
                        dataPoint.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold); // Set the label font
                        red = random.Next(256);
                        green = random.Next(256);
                        blue = random.Next(256);

                        // Set the color for the data point
                        dataPoint.Color = Color.FromArgb(red, green, blue);
                    }
                    // Add the series to the chart
                    ColumnChart.Series.Add(series);

                    // Customize chart appearance if needed
                    ColumnChart.Titles.Add($"Statistic Months | Total = {totalSum}");
                    ColumnChart.ChartAreas[0].AxisX.Interval = 1;
                    ColumnChart.ChartAreas[0].AxisX.Title = "Months";
                    ColumnChart.ChartAreas[0].AxisY.Title = "Total Sum";
                    break;
                case 1:
                    dt = StatisticBLL.Instance.GetStatisticByYear(dateTimePickerTop.Value, dateTimePickerBot.Value);
                    ColumnChart.Series.Clear();
                    ColumnChart.BringToFront();
                    ColumnChart.Titles.Clear();

                    series = new Series();
                    series.ChartType = SeriesChartType.Column;
                    totalSum = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        int total = Convert.ToInt32(row["total_sum"]);
                        totalSum += total;
                    }
                    // Bind the series to the DataTable
                    series.Points.DataBind(dt.DefaultView, "year", "total_Sum", "");
                    series.IsValueShownAsLabel = true;
                    red = 0;
                    green = 0;
                    blue = 0;
                    foreach (DataPoint dataPoint in series.Points)
                    {
                        dataPoint.LabelForeColor = System.Drawing.Color.Black; // Set the label color
                        dataPoint.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold); // Set the label font
                        red = random.Next(256);
                        green = random.Next(256);
                        blue = random.Next(256);

                        // Set the color for the data point
                        dataPoint.Color = Color.FromArgb(red, green, blue);

                    }
                    // Add the series to the chart
                    ColumnChart.Series.Add(series);
                    ColumnChart.Titles.Add($"Statistic Years | Total = {totalSum}");
                    // Customize chart appearance if needed
                    ColumnChart.ChartAreas[0].AxisX.Interval = 1;
                    ColumnChart.ChartAreas[0].AxisX.Title = "Years";
                    ColumnChart.ChartAreas[0].AxisY.Title = "Total Sum";
                    break;
                case 2:
                    int id = ((Brand)AnotherCb.SelectedItem).Id;
                    dt = StatisticBLL.Instance.GetStatisticByBrand(id, dateTimePickerTop.Value, dateTimePickerBot.Value);
                    PieChart.Series.Clear();
                    PieChart.Titles.Clear();
                    PieChart.BringToFront();

                    // Create a new series
                    series = new Series();
                    series.ChartType = SeriesChartType.Doughnut;
                    totalSum = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        int total = Convert.ToInt32(row["total_sum"]);
                        totalSum += total;
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        string name = row["name"].ToString();
                        int total = Convert.ToInt32(row["total_sum"]);
                        double percentage = (total / (double)totalSum) * 100;
                        DataPoint dataPoint = new DataPoint();
                        dataPoint.Label = $"{total} ({percentage:F2}%)";
                        dataPoint.LegendText = name;
                        dataPoint.YValues = new double[] { total };
                        red = random.Next(256);
                        green = random.Next(256);
                        blue = random.Next(256);

                        // Set the color for the data point
                        dataPoint.Color = Color.FromArgb(red, green, blue);
                        series.Points.Add(dataPoint);
                    }

                    // Add the series to the chart
                    PieChart.Series.Add(series);

                    // Set the palette to use different colors for each data point
                    PieChart.Palette = ChartColorPalette.Pastel;

                    // Set other chart properties as needed
                    PieChart.Titles.Add($"Statistic Brand : {((Brand)AnotherCb.SelectedItem).Name}");
                    PieChart.ChartAreas[0].Area3DStyle.Enable3D = true;
                    break;
                case 3:
                    id = ((Category)AnotherCb.SelectedItem).Id;
                    dt = StatisticBLL.Instance.GetStatisticByCategory(id, dateTimePickerTop.Value, dateTimePickerBot.Value);
                    PieChart.Series.Clear();
                    PieChart.Titles.Clear();
                    PieChart.BringToFront();

                    // Create a new series
                    series = new Series();
                    series.ChartType = SeriesChartType.Doughnut;
                    totalSum = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        int total = Convert.ToInt32(row["total_sum"]);
                        totalSum += total;
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        string name = row["name"].ToString();
                        int total = Convert.ToInt32(row["total_sum"]);
                        double percentage = (total / (double)totalSum) * 100;
                        DataPoint dataPoint = new DataPoint();
                        dataPoint.Label = $"{total} ({percentage:F2}%)";
                        dataPoint.LegendText = name;
                        dataPoint.YValues = new double[] { total };
                        red = random.Next(256);
                        green = random.Next(256);
                        blue = random.Next(256);

                        // Set the color for the data point
                        dataPoint.Color = Color.FromArgb(red, green, blue);
                        series.Points.Add(dataPoint);
                    }

                    // Add the series to the chart
                    PieChart.Series.Add(series);

                    // Set the palette to use different colors for each data point
                    PieChart.Palette = ChartColorPalette.Pastel;

                    // Set other chart properties as needed
                    PieChart.Titles.Add($"Statistic Category : {((Category)AnotherCb.SelectedItem).Name} | Total = {totalSum}");
                    PieChart.ChartAreas[0].Area3DStyle.Enable3D = true;
                    break;
                default:
                    RJMessageBox.Show("Nothing here! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    break;
            }
        }

        private void StatisticsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (StatisticsCb.SelectedIndex)
            {

                case 2:
                    BrandBLL.Instance.loadBrandCombobox(AnotherCb);
                    AnotherCb.Visible = true;
                    break;
                case 3:
                    CategoryBLL.Instance.getCategoryCombobox(AnotherCb);
                    AnotherCb.Visible = true;
                    break;
                default:
                    AnotherCb.Visible = false;
                    break;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
