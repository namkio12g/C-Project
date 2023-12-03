namespace ClotheShop.MyForm
{
    partial class StatisticViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            ColumnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            StatisticsCb = new ComboBox();
            panel2 = new Panel();
            StatisticShow = new CustomControl.customButton();
            label2 = new Label();
            AnotherCb = new ComboBox();
            dateTimePickerTop = new DateTimePicker();
            dateTimePickerBot = new DateTimePicker();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ColumnChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PieChart).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ColumnChart);
            panel1.Controls.Add(PieChart);
            panel1.Location = new Point(448, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 708);
            panel1.TabIndex = 0;
            // 
            // ColumnChart
            // 
            chartArea3.Name = "ChartArea1";
            ColumnChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            ColumnChart.Legends.Add(legend3);
            ColumnChart.Location = new Point(3, 3);
            ColumnChart.Name = "ColumnChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            ColumnChart.Series.Add(series3);
            ColumnChart.Size = new Size(658, 704);
            ColumnChart.TabIndex = 0;
            ColumnChart.Text = "chart1";
            // 
            // PieChart
            // 
            chartArea4.Name = "ChartArea1";
            PieChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            PieChart.Legends.Add(legend4);
            PieChart.Location = new Point(26, 21);
            PieChart.Name = "PieChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            PieChart.Series.Add(series4);
            PieChart.Size = new Size(621, 670);
            PieChart.TabIndex = 2;
            PieChart.Text = "chart2";
            // 
            // StatisticsCb
            // 
            StatisticsCb.FormattingEnabled = true;
            StatisticsCb.Items.AddRange(new object[] { "Thống kê theo tháng", "Thống kê theo năm", "Thống kê theo Brand", "Thống kê theo Category" });
            StatisticsCb.Location = new Point(13, 46);
            StatisticsCb.Name = "StatisticsCb";
            StatisticsCb.Size = new Size(188, 28);
            StatisticsCb.TabIndex = 1;
            StatisticsCb.SelectedIndexChanged += StatisticsCb_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 128);
            panel2.Controls.Add(StatisticShow);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(AnotherCb);
            panel2.Controls.Add(dateTimePickerTop);
            panel2.Controls.Add(dateTimePickerBot);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(StatisticsCb);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 324);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // StatisticShow
            // 
            StatisticShow.BackColor = Color.DarkBlue;
            StatisticShow.BackGColor = Color.DarkBlue;
            StatisticShow.BorderColor = Color.HotPink;
            StatisticShow.BorderRadius = 40;
            StatisticShow.BorderSize = 0;
            StatisticShow.ClickedBool = false;
            StatisticShow.clikedColor = Color.MediumAquamarine;
            StatisticShow.FlatAppearance.BorderSize = 0;
            StatisticShow.FlatStyle = FlatStyle.Flat;
            StatisticShow.ForeColor = Color.White;
            StatisticShow.HoverBool = false;
            StatisticShow.HoverColor = Color.MediumAquamarine;
            StatisticShow.ImageIcon = null;
            StatisticShow.Location = new Point(13, 249);
            StatisticShow.Name = "StatisticShow";
            StatisticShow.Size = new Size(171, 50);
            StatisticShow.TabIndex = 59;
            StatisticShow.Text = "Finish";
            StatisticShow.Textcolor = Color.White;
            StatisticShow.UseVisualStyleBackColor = false;
            StatisticShow.Click += StatisticShow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(13, 22);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 58;
            label2.Text = "Statistc";
            // 
            // AnotherCb
            // 
            AnotherCb.FormattingEnabled = true;
            AnotherCb.Location = new Point(59, 98);
            AnotherCb.Name = "AnotherCb";
            AnotherCb.Size = new Size(179, 28);
            AnotherCb.TabIndex = 57;
            AnotherCb.Visible = false;
            // 
            // dateTimePickerTop
            // 
            dateTimePickerTop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerTop.Format = DateTimePickerFormat.Short;
            dateTimePickerTop.Location = new Point(207, 159);
            dateTimePickerTop.Name = "dateTimePickerTop";
            dateTimePickerTop.Size = new Size(153, 27);
            dateTimePickerTop.TabIndex = 56;
            // 
            // dateTimePickerBot
            // 
            dateTimePickerBot.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerBot.Format = DateTimePickerFormat.Short;
            dateTimePickerBot.Location = new Point(13, 159);
            dateTimePickerBot.Name = "dateTimePickerBot";
            dateTimePickerBot.Size = new Size(153, 27);
            dateTimePickerBot.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(172, 163);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 54;
            label1.Text = "to";
            // 
            // StatisticViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(1126, 732);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StatisticViewForm";
            Text = "StatisticViewForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ColumnChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)PieChart).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox StatisticsCb;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ColumnChart;
        private DateTimePicker dateTimePickerTop;
        private DateTimePicker dateTimePickerBot;
        private Label label1;
        private CustomControl.customButton StatisticShow;
        private Label label2;
        private ComboBox AnotherCb;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
    }
}