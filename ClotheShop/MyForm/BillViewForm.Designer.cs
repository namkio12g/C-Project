namespace ClotheShop.CustomControl
{
    partial class BillViewForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillViewForm));
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label6 = new Label();
            DGV2 = new DataGridView();
            label5 = new Label();
            CustomerPhoneDetail = new CustomTextBox();
            label4 = new Label();
            idDetail = new Label();
            label19 = new Label();
            CreatedbyDetail = new CustomTextBox();
            createdTimeDetail = new DateTimePicker();
            label10 = new Label();
            TotalDetail = new CustomTextBox();
            label12 = new Label();
            CustomerAddDetail = new CustomTextBox();
            label14 = new Label();
            CustomerNameDetail = new CustomTextBox();
            label8 = new Label();
            ProductChangedBt = new customButton();
            BrandBtChanged = new customButton();
            CategoryBtChanged = new customButton();
            RoleBtChanged = new customButton();
            UserBtChanged = new customButton();
            nameSearchTextbox = new CustomTextBox();
            searchButton = new customButton();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            IdSearchTextbox = new CustomTextBox();
            ProductSearch = new ComboBox();
            dateTimePickerBot = new DateTimePicker();
            dateTimePickerTop = new DateTimePicker();
            label13 = new Label();
            label16 = new Label();
            label22 = new Label();
            label9 = new Label();
            checkSearchDate = new CheckBox();
            priceRange = new Bunifu.Framework.UI.BunifuRange();
            Rangeco = new Label();
            DeleteButton = new customButton();
            AccountBtChanged = new customButton();
            BillBtChanged = new customButton();
            AddProductSearchBt = new Button();
            ProductListSearchDGV = new DataGridView();
            Product_id = new DataGridViewTextBoxColumn();
            Product_name = new DataGridViewTextBoxColumn();
            ResetTotalBt = new customButton();
            ExportBt = new customButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductListSearchDGV).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.BackColor = Color.Cornsilk;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.Padding = new Padding(5, 0, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = Color.Cornsilk;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(7, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(22, 374);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkOrchid;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(799, 358);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(DGV2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(CustomerPhoneDetail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(idDetail);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(CreatedbyDetail);
            panel1.Controls.Add(createdTimeDetail);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(TotalDetail);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(CustomerAddDetail);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(CustomerNameDetail);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(837, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 732);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(9, 412);
            label6.Name = "label6";
            label6.Size = new Size(87, 19);
            label6.TabIndex = 89;
            label6.Text = "Bill Detail";
            // 
            // DGV2
            // 
            DGV2.AllowUserToAddRows = false;
            DGV2.AllowUserToDeleteRows = false;
            DGV2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV2.BackgroundColor = Color.White;
            DGV2.BorderStyle = BorderStyle.None;
            DGV2.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            DGV2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle5.BackColor = Color.Cornsilk;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle5.Padding = new Padding(5, 0, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = Color.Cornsilk;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DGV2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DGV2.ColumnHeadersHeight = 50;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(7, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DGV2.DefaultCellStyle = dataGridViewCellStyle6;
            DGV2.EnableHeadersVisualStyles = false;
            DGV2.GridColor = SystemColors.ActiveCaption;
            DGV2.Location = new Point(9, 434);
            DGV2.Name = "DGV2";
            DGV2.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DGV2.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DGV2.RowHeadersVisible = false;
            DGV2.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.DarkOrchid;
            DGV2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            DGV2.RowTemplate.Height = 29;
            DGV2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV2.Size = new Size(268, 264);
            DGV2.TabIndex = 88;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(148, 62);
            label5.Name = "label5";
            label5.Size = new Size(138, 19);
            label5.TabIndex = 67;
            label5.Text = "Customer Phone";
            // 
            // CustomerPhoneDetail
            // 
            CustomerPhoneDetail.BackColor = Color.White;
            CustomerPhoneDetail.BorderColor = Color.Gray;
            CustomerPhoneDetail.BorderSize = 2;
            CustomerPhoneDetail.EnableText = true;
            CustomerPhoneDetail.FocusedColor = Color.HotPink;
            CustomerPhoneDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerPhoneDetail.ForeColor = SystemColors.ActiveCaptionText;
            CustomerPhoneDetail.IconImage = null;
            CustomerPhoneDetail.Location = new Point(148, 90);
            CustomerPhoneDetail.Margin = new Padding(0);
            CustomerPhoneDetail.Name = "CustomerPhoneDetail";
            CustomerPhoneDetail.OnlyNumber = false;
            CustomerPhoneDetail.Padding = new Padding(8, 7, 8, 7);
            CustomerPhoneDetail.PasswordChar = false;
            CustomerPhoneDetail.placeHolderText = "";
            CustomerPhoneDetail.setIcon = false;
            CustomerPhoneDetail.SetPassword = false;
            CustomerPhoneDetail.Size = new Size(129, 37);
            CustomerPhoneDetail.TabIndex = 66;
            CustomerPhoneDetail.Texts = "";
            CustomerPhoneDetail.Underlined1 = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(126, 9);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 61;
            label4.Text = "Id:";
            // 
            // idDetail
            // 
            idDetail.AutoSize = true;
            idDetail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            idDetail.ForeColor = SystemColors.ButtonHighlight;
            idDetail.Location = new Point(148, 10);
            idDetail.Name = "idDetail";
            idDetail.Size = new Size(0, 20);
            idDetail.TabIndex = 60;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(6, 349);
            label19.Name = "label19";
            label19.Size = new Size(110, 19);
            label19.TabIndex = 56;
            label19.Text = "Created time";
            // 
            // CreatedbyDetail
            // 
            CreatedbyDetail.BackColor = Color.White;
            CreatedbyDetail.BorderColor = Color.Gray;
            CreatedbyDetail.BorderSize = 2;
            CreatedbyDetail.EnableText = true;
            CreatedbyDetail.FocusedColor = Color.HotPink;
            CreatedbyDetail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CreatedbyDetail.IconImage = null;
            CreatedbyDetail.Location = new Point(9, 297);
            CreatedbyDetail.Margin = new Padding(0);
            CreatedbyDetail.Name = "CreatedbyDetail";
            CreatedbyDetail.OnlyNumber = false;
            CreatedbyDetail.Padding = new Padding(8, 7, 8, 7);
            CreatedbyDetail.PasswordChar = false;
            CreatedbyDetail.placeHolderText = "";
            CreatedbyDetail.setIcon = false;
            CreatedbyDetail.SetPassword = false;
            CreatedbyDetail.Size = new Size(268, 39);
            CreatedbyDetail.TabIndex = 54;
            CreatedbyDetail.Texts = "";
            CreatedbyDetail.Underlined1 = false;
            // 
            // createdTimeDetail
            // 
            createdTimeDetail.Enabled = false;
            createdTimeDetail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createdTimeDetail.Format = DateTimePickerFormat.Short;
            createdTimeDetail.Location = new Point(6, 374);
            createdTimeDetail.Name = "createdTimeDetail";
            createdTimeDetail.Size = new Size(271, 27);
            createdTimeDetail.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(9, 278);
            label10.Name = "label10";
            label10.Size = new Size(95, 19);
            label10.TabIndex = 50;
            label10.Text = "Created by";
            // 
            // TotalDetail
            // 
            TotalDetail.BackColor = Color.White;
            TotalDetail.BorderColor = Color.Gray;
            TotalDetail.BorderSize = 2;
            TotalDetail.EnableText = true;
            TotalDetail.FocusedColor = Color.HotPink;
            TotalDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TotalDetail.ForeColor = SystemColors.ActiveCaptionText;
            TotalDetail.IconImage = null;
            TotalDetail.Location = new Point(9, 234);
            TotalDetail.Margin = new Padding(0);
            TotalDetail.Name = "TotalDetail";
            TotalDetail.OnlyNumber = true;
            TotalDetail.Padding = new Padding(8, 7, 8, 7);
            TotalDetail.PasswordChar = false;
            TotalDetail.placeHolderText = "";
            TotalDetail.setIcon = false;
            TotalDetail.SetPassword = false;
            TotalDetail.Size = new Size(268, 37);
            TotalDetail.TabIndex = 46;
            TotalDetail.Texts = "";
            TotalDetail.Underlined1 = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(9, 213);
            label12.Name = "label12";
            label12.Size = new Size(49, 19);
            label12.TabIndex = 45;
            label12.Text = "Total";
            // 
            // CustomerAddDetail
            // 
            CustomerAddDetail.BackColor = Color.White;
            CustomerAddDetail.BorderColor = Color.Gray;
            CustomerAddDetail.BorderSize = 2;
            CustomerAddDetail.EnableText = true;
            CustomerAddDetail.FocusedColor = Color.HotPink;
            CustomerAddDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerAddDetail.ForeColor = SystemColors.ActiveCaptionText;
            CustomerAddDetail.IconImage = null;
            CustomerAddDetail.Location = new Point(6, 161);
            CustomerAddDetail.Margin = new Padding(0);
            CustomerAddDetail.Name = "CustomerAddDetail";
            CustomerAddDetail.OnlyNumber = true;
            CustomerAddDetail.Padding = new Padding(8, 7, 8, 7);
            CustomerAddDetail.PasswordChar = false;
            CustomerAddDetail.placeHolderText = "";
            CustomerAddDetail.setIcon = false;
            CustomerAddDetail.SetPassword = false;
            CustomerAddDetail.Size = new Size(271, 37);
            CustomerAddDetail.TabIndex = 44;
            CustomerAddDetail.Texts = "";
            CustomerAddDetail.Underlined1 = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(6, 142);
            label14.Name = "label14";
            label14.Size = new Size(153, 19);
            label14.TabIndex = 39;
            label14.Text = "Customer Address";
            // 
            // CustomerNameDetail
            // 
            CustomerNameDetail.BackColor = Color.White;
            CustomerNameDetail.BorderColor = Color.Gray;
            CustomerNameDetail.BorderSize = 2;
            CustomerNameDetail.EnableText = true;
            CustomerNameDetail.FocusedColor = Color.HotPink;
            CustomerNameDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerNameDetail.ForeColor = SystemColors.ActiveCaptionText;
            CustomerNameDetail.IconImage = null;
            CustomerNameDetail.Location = new Point(6, 90);
            CustomerNameDetail.Margin = new Padding(0);
            CustomerNameDetail.Name = "CustomerNameDetail";
            CustomerNameDetail.OnlyNumber = false;
            CustomerNameDetail.Padding = new Padding(8, 7, 8, 7);
            CustomerNameDetail.PasswordChar = false;
            CustomerNameDetail.placeHolderText = "";
            CustomerNameDetail.setIcon = false;
            CustomerNameDetail.SetPassword = false;
            CustomerNameDetail.Size = new Size(129, 37);
            CustomerNameDetail.TabIndex = 38;
            CustomerNameDetail.Texts = "";
            CustomerNameDetail.Underlined1 = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(6, 62);
            label8.Name = "label8";
            label8.Size = new Size(134, 19);
            label8.TabIndex = 28;
            label8.Text = "Customer Name";
            // 
            // ProductChangedBt
            // 
            ProductChangedBt.BackColor = Color.MediumSlateBlue;
            ProductChangedBt.BackGColor = Color.MediumSlateBlue;
            ProductChangedBt.BorderColor = Color.HotPink;
            ProductChangedBt.BorderRadius = 40;
            ProductChangedBt.BorderSize = 0;
            ProductChangedBt.ClickedBool = false;
            ProductChangedBt.clikedColor = Color.MediumSlateBlue;
            ProductChangedBt.FlatAppearance.BorderSize = 0;
            ProductChangedBt.FlatStyle = FlatStyle.Flat;
            ProductChangedBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProductChangedBt.ForeColor = Color.White;
            ProductChangedBt.HoverBool = false;
            ProductChangedBt.HoverColor = Color.MediumSlateBlue;
            ProductChangedBt.ImageIcon = null;
            ProductChangedBt.Location = new Point(22, 322);
            ProductChangedBt.Name = "ProductChangedBt";
            ProductChangedBt.Size = new Size(103, 46);
            ProductChangedBt.TabIndex = 2;
            ProductChangedBt.Text = "Products";
            ProductChangedBt.Textcolor = Color.White;
            ProductChangedBt.UseVisualStyleBackColor = false;
            ProductChangedBt.Click += ProductChangedBt_Click;
            // 
            // BrandBtChanged
            // 
            BrandBtChanged.BackColor = Color.MediumSlateBlue;
            BrandBtChanged.BackGColor = Color.MediumSlateBlue;
            BrandBtChanged.BorderColor = Color.HotPink;
            BrandBtChanged.BorderRadius = 40;
            BrandBtChanged.BorderSize = 0;
            BrandBtChanged.ClickedBool = false;
            BrandBtChanged.clikedColor = Color.MediumAquamarine;
            BrandBtChanged.FlatAppearance.BorderSize = 0;
            BrandBtChanged.FlatStyle = FlatStyle.Flat;
            BrandBtChanged.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BrandBtChanged.ForeColor = Color.White;
            BrandBtChanged.HoverBool = false;
            BrandBtChanged.HoverColor = Color.MediumAquamarine;
            BrandBtChanged.ImageIcon = null;
            BrandBtChanged.Location = new Point(340, 322);
            BrandBtChanged.Name = "BrandBtChanged";
            BrandBtChanged.Size = new Size(93, 46);
            BrandBtChanged.TabIndex = 3;
            BrandBtChanged.Text = "Brand";
            BrandBtChanged.Textcolor = Color.White;
            BrandBtChanged.UseVisualStyleBackColor = false;
            BrandBtChanged.Click += BrandBtChanged_Click;
            // 
            // CategoryBtChanged
            // 
            CategoryBtChanged.BackColor = Color.MediumSlateBlue;
            CategoryBtChanged.BackGColor = Color.MediumSlateBlue;
            CategoryBtChanged.BorderColor = Color.HotPink;
            CategoryBtChanged.BorderRadius = 40;
            CategoryBtChanged.BorderSize = 0;
            CategoryBtChanged.ClickedBool = false;
            CategoryBtChanged.clikedColor = Color.MediumAquamarine;
            CategoryBtChanged.FlatAppearance.BorderSize = 0;
            CategoryBtChanged.FlatStyle = FlatStyle.Flat;
            CategoryBtChanged.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryBtChanged.ForeColor = Color.White;
            CategoryBtChanged.HoverBool = false;
            CategoryBtChanged.HoverColor = Color.MediumAquamarine;
            CategoryBtChanged.ImageIcon = null;
            CategoryBtChanged.Location = new Point(134, 322);
            CategoryBtChanged.Name = "CategoryBtChanged";
            CategoryBtChanged.Size = new Size(94, 46);
            CategoryBtChanged.TabIndex = 4;
            CategoryBtChanged.Text = "Category";
            CategoryBtChanged.Textcolor = Color.White;
            CategoryBtChanged.UseVisualStyleBackColor = false;
            CategoryBtChanged.Click += CategoryBtChanged_Click;
            // 
            // RoleBtChanged
            // 
            RoleBtChanged.BackColor = Color.MediumSlateBlue;
            RoleBtChanged.BackGColor = Color.MediumSlateBlue;
            RoleBtChanged.BorderColor = Color.HotPink;
            RoleBtChanged.BorderRadius = 40;
            RoleBtChanged.BorderSize = 0;
            RoleBtChanged.ClickedBool = false;
            RoleBtChanged.clikedColor = Color.MediumAquamarine;
            RoleBtChanged.FlatAppearance.BorderSize = 0;
            RoleBtChanged.FlatStyle = FlatStyle.Flat;
            RoleBtChanged.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RoleBtChanged.ForeColor = Color.White;
            RoleBtChanged.HoverBool = false;
            RoleBtChanged.HoverColor = Color.MediumAquamarine;
            RoleBtChanged.ImageIcon = null;
            RoleBtChanged.Location = new Point(439, 322);
            RoleBtChanged.Name = "RoleBtChanged";
            RoleBtChanged.Size = new Size(83, 46);
            RoleBtChanged.TabIndex = 5;
            RoleBtChanged.Text = "Role";
            RoleBtChanged.Textcolor = Color.White;
            RoleBtChanged.UseVisualStyleBackColor = false;
            RoleBtChanged.Click += RoleBtChanged_Click;
            // 
            // UserBtChanged
            // 
            UserBtChanged.BackColor = Color.MediumSlateBlue;
            UserBtChanged.BackGColor = Color.MediumSlateBlue;
            UserBtChanged.BorderColor = Color.HotPink;
            UserBtChanged.BorderRadius = 40;
            UserBtChanged.BorderSize = 0;
            UserBtChanged.ClickedBool = false;
            UserBtChanged.clikedColor = Color.MediumAquamarine;
            UserBtChanged.FlatAppearance.BorderSize = 0;
            UserBtChanged.FlatStyle = FlatStyle.Flat;
            UserBtChanged.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserBtChanged.ForeColor = Color.White;
            UserBtChanged.HoverBool = false;
            UserBtChanged.HoverColor = Color.MediumAquamarine;
            UserBtChanged.ImageIcon = null;
            UserBtChanged.Location = new Point(234, 322);
            UserBtChanged.Name = "UserBtChanged";
            UserBtChanged.Size = new Size(100, 46);
            UserBtChanged.TabIndex = 6;
            UserBtChanged.Text = "User";
            UserBtChanged.Textcolor = Color.White;
            UserBtChanged.UseVisualStyleBackColor = false;
            UserBtChanged.Click += UserFormBtChanged_Click;
            // 
            // nameSearchTextbox
            // 
            nameSearchTextbox.BackColor = Color.White;
            nameSearchTextbox.BorderColor = Color.MediumAquamarine;
            nameSearchTextbox.BorderSize = 2;
            nameSearchTextbox.EnableText = true;
            nameSearchTextbox.FocusedColor = Color.HotPink;
            nameSearchTextbox.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            nameSearchTextbox.ForeColor = SystemColors.ActiveCaptionText;
            nameSearchTextbox.IconImage = null;
            nameSearchTextbox.Location = new Point(248, 30);
            nameSearchTextbox.Margin = new Padding(0);
            nameSearchTextbox.Name = "nameSearchTextbox";
            nameSearchTextbox.OnlyNumber = false;
            nameSearchTextbox.Padding = new Padding(8, 7, 8, 7);
            nameSearchTextbox.PasswordChar = false;
            nameSearchTextbox.placeHolderText = "";
            nameSearchTextbox.setIcon = false;
            nameSearchTextbox.SetPassword = false;
            nameSearchTextbox.Size = new Size(227, 37);
            nameSearchTextbox.TabIndex = 8;
            nameSearchTextbox.Texts = "";
            nameSearchTextbox.Underlined1 = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.HotPink;
            searchButton.BackGColor = Color.HotPink;
            searchButton.BorderColor = Color.HotPink;
            searchButton.BorderRadius = 40;
            searchButton.BorderSize = 0;
            searchButton.ClickedBool = false;
            searchButton.clikedColor = Color.MediumAquamarine;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            searchButton.ForeColor = Color.White;
            searchButton.HoverBool = false;
            searchButton.HoverColor = Color.MediumAquamarine;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.ImageIcon = (Image)resources.GetObject("searchButton.ImageIcon");
            searchButton.Location = new Point(28, 272);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(105, 38);
            searchButton.TabIndex = 15;
            searchButton.Text = "Search";
            searchButton.Textcolor = Color.White;
            searchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = dataGridView1;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 10;
            bunifuElipse2.TargetControl = panel1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(213, 232);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 16;
            label1.Text = "to";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(302, 9);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 25;
            label3.Text = "Cusomer Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 3);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 23;
            // 
            // IdSearchTextbox
            // 
            IdSearchTextbox.BackColor = Color.White;
            IdSearchTextbox.BorderColor = Color.MediumAquamarine;
            IdSearchTextbox.BorderSize = 2;
            IdSearchTextbox.EnableText = true;
            IdSearchTextbox.FocusedColor = Color.HotPink;
            IdSearchTextbox.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            IdSearchTextbox.ForeColor = SystemColors.ActiveCaptionText;
            IdSearchTextbox.IconImage = null;
            IdSearchTextbox.Location = new Point(22, 30);
            IdSearchTextbox.Margin = new Padding(0);
            IdSearchTextbox.Name = "IdSearchTextbox";
            IdSearchTextbox.OnlyNumber = true;
            IdSearchTextbox.Padding = new Padding(8, 7, 8, 7);
            IdSearchTextbox.PasswordChar = false;
            IdSearchTextbox.placeHolderText = "";
            IdSearchTextbox.setIcon = false;
            IdSearchTextbox.SetPassword = false;
            IdSearchTextbox.Size = new Size(188, 37);
            IdSearchTextbox.TabIndex = 21;
            IdSearchTextbox.Texts = "";
            IdSearchTextbox.Underlined1 = false;
            // 
            // ProductSearch
            // 
            ProductSearch.FormattingEnabled = true;
            ProductSearch.Items.AddRange(new object[] { "", "Brand", "lo", "ld", "asd", "dasd" });
            ProductSearch.Location = new Point(507, 39);
            ProductSearch.Name = "ProductSearch";
            ProductSearch.Size = new Size(203, 28);
            ProductSearch.TabIndex = 26;
            // 
            // dateTimePickerBot
            // 
            dateTimePickerBot.Enabled = false;
            dateTimePickerBot.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerBot.Format = DateTimePickerFormat.Short;
            dateTimePickerBot.Location = new Point(20, 232);
            dateTimePickerBot.Name = "dateTimePickerBot";
            dateTimePickerBot.Size = new Size(185, 27);
            dateTimePickerBot.TabIndex = 52;
            // 
            // dateTimePickerTop
            // 
            dateTimePickerTop.Enabled = false;
            dateTimePickerTop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerTop.Format = DateTimePickerFormat.Short;
            dateTimePickerTop.Location = new Point(248, 232);
            dateTimePickerTop.Name = "dateTimePickerTop";
            dateTimePickerTop.Size = new Size(227, 27);
            dateTimePickerTop.TabIndex = 53;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Blue;
            label13.Location = new Point(20, 208);
            label13.Name = "label13";
            label13.Size = new Size(123, 21);
            label13.TabIndex = 58;
            label13.Text = "Created date";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Blue;
            label16.Location = new Point(22, 9);
            label16.Name = "label16";
            label16.Size = new Size(29, 21);
            label16.TabIndex = 59;
            label16.Text = "Id";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Blue;
            label22.Location = new Point(507, 10);
            label22.Name = "label22";
            label22.Size = new Size(81, 21);
            label22.TabIndex = 60;
            label22.Text = "Product";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(22, 75);
            label9.Name = "label9";
            label9.Size = new Size(55, 21);
            label9.TabIndex = 68;
            label9.Text = "Total";
            // 
            // checkSearchDate
            // 
            checkSearchDate.AutoSize = true;
            checkSearchDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkSearchDate.Location = new Point(20, 181);
            checkSearchDate.Name = "checkSearchDate";
            checkSearchDate.Size = new Size(168, 24);
            checkSearchDate.TabIndex = 70;
            checkSearchDate.Text = "Search Created date";
            checkSearchDate.UseVisualStyleBackColor = true;
            checkSearchDate.Click += checkSearchDate_Click;
            // 
            // priceRange
            // 
            priceRange.BackColor = Color.Transparent;
            priceRange.BackgroudColor = Color.LightSeaGreen;
            priceRange.BorderRadius = 10;
            priceRange.IndicatorColor = Color.DarkCyan;
            priceRange.Location = new Point(22, 101);
            priceRange.Margin = new Padding(4, 5, 4, 5);
            priceRange.MaximumRange = 100000;
            priceRange.MaximumSize = new Size(345, 0);
            priceRange.Name = "priceRange";
            priceRange.RangeMax = 100000;
            priceRange.RangeMin = 0;
            priceRange.Size = new Size(345, 41);
            priceRange.TabIndex = 79;
            priceRange.RangeChanged += bunifuRange1_RangeChanged;
            priceRange.Load += bunifuRange1_Load;
            // 
            // Rangeco
            // 
            Rangeco.AutoSize = true;
            Rangeco.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Rangeco.ForeColor = Color.CadetBlue;
            Rangeco.Location = new Point(153, 147);
            Rangeco.Name = "Rangeco";
            Rangeco.Size = new Size(57, 21);
            Rangeco.TabIndex = 80;
            Rangeco.Text = "Price";
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(64, 0, 0);
            DeleteButton.BackGColor = Color.FromArgb(64, 0, 0);
            DeleteButton.BorderColor = Color.HotPink;
            DeleteButton.BorderRadius = 40;
            DeleteButton.BorderSize = 0;
            DeleteButton.ClickedBool = false;
            DeleteButton.clikedColor = Color.MediumAquamarine;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.HoverBool = false;
            DeleteButton.HoverColor = Color.MediumAquamarine;
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.ImageIcon = (Image)resources.GetObject("DeleteButton.ImageIcon");
            DeleteButton.Location = new Point(139, 272);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(101, 38);
            DeleteButton.TabIndex = 85;
            DeleteButton.Text = "Delete";
            DeleteButton.Textcolor = Color.White;
            DeleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AccountBtChanged
            // 
            AccountBtChanged.BackColor = Color.MediumSlateBlue;
            AccountBtChanged.BackGColor = Color.MediumSlateBlue;
            AccountBtChanged.BorderColor = Color.HotPink;
            AccountBtChanged.BorderRadius = 40;
            AccountBtChanged.BorderSize = 0;
            AccountBtChanged.ClickedBool = false;
            AccountBtChanged.clikedColor = Color.MediumAquamarine;
            AccountBtChanged.FlatAppearance.BorderSize = 0;
            AccountBtChanged.FlatStyle = FlatStyle.Flat;
            AccountBtChanged.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AccountBtChanged.ForeColor = Color.White;
            AccountBtChanged.HoverBool = false;
            AccountBtChanged.HoverColor = Color.MediumAquamarine;
            AccountBtChanged.ImageIcon = null;
            AccountBtChanged.Location = new Point(528, 322);
            AccountBtChanged.Name = "AccountBtChanged";
            AccountBtChanged.Size = new Size(103, 46);
            AccountBtChanged.TabIndex = 86;
            AccountBtChanged.Text = "Accounts";
            AccountBtChanged.Textcolor = Color.White;
            AccountBtChanged.UseVisualStyleBackColor = false;
            AccountBtChanged.Click += AccountBtChanged_Click;
            // 
            // BillBtChanged
            // 
            BillBtChanged.BackColor = Color.DarkTurquoise;
            BillBtChanged.BackGColor = Color.DarkTurquoise;
            BillBtChanged.BorderColor = Color.HotPink;
            BillBtChanged.BorderRadius = 40;
            BillBtChanged.BorderSize = 0;
            BillBtChanged.ClickedBool = false;
            BillBtChanged.clikedColor = Color.MediumAquamarine;
            BillBtChanged.FlatAppearance.BorderSize = 0;
            BillBtChanged.FlatStyle = FlatStyle.Flat;
            BillBtChanged.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BillBtChanged.ForeColor = Color.White;
            BillBtChanged.HoverBool = false;
            BillBtChanged.HoverColor = Color.MediumAquamarine;
            BillBtChanged.ImageIcon = null;
            BillBtChanged.Location = new Point(637, 322);
            BillBtChanged.Name = "BillBtChanged";
            BillBtChanged.Size = new Size(72, 46);
            BillBtChanged.TabIndex = 87;
            BillBtChanged.Text = "Bill";
            BillBtChanged.Textcolor = Color.White;
            BillBtChanged.UseVisualStyleBackColor = false;
            // 
            // AddProductSearchBt
            // 
            AddProductSearchBt.Location = new Point(716, 38);
            AddProductSearchBt.Name = "AddProductSearchBt";
            AddProductSearchBt.Size = new Size(94, 29);
            AddProductSearchBt.TabIndex = 88;
            AddProductSearchBt.Text = "Add";
            AddProductSearchBt.UseVisualStyleBackColor = true;
            AddProductSearchBt.Click += AddProductSearchBt_Click;
            // 
            // ProductListSearchDGV
            // 
            ProductListSearchDGV.AllowUserToAddRows = false;
            ProductListSearchDGV.AllowUserToDeleteRows = false;
            ProductListSearchDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductListSearchDGV.BackgroundColor = Color.White;
            ProductListSearchDGV.BorderStyle = BorderStyle.None;
            ProductListSearchDGV.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            ProductListSearchDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle9.BackColor = Color.Cornsilk;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle9.Padding = new Padding(5, 0, 0, 5);
            dataGridViewCellStyle9.SelectionBackColor = Color.Cornsilk;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            ProductListSearchDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            ProductListSearchDGV.ColumnHeadersHeight = 50;
            ProductListSearchDGV.Columns.AddRange(new DataGridViewColumn[] { Product_id, Product_name });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new Padding(7, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            ProductListSearchDGV.DefaultCellStyle = dataGridViewCellStyle10;
            ProductListSearchDGV.EnableHeadersVisualStyles = false;
            ProductListSearchDGV.GridColor = SystemColors.ActiveCaption;
            ProductListSearchDGV.Location = new Point(507, 83);
            ProductListSearchDGV.Name = "ProductListSearchDGV";
            ProductListSearchDGV.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            ProductListSearchDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            ProductListSearchDGV.RowHeadersVisible = false;
            ProductListSearchDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.DarkOrchid;
            ProductListSearchDGV.RowsDefaultCellStyle = dataGridViewCellStyle12;
            ProductListSearchDGV.RowTemplate.Height = 29;
            ProductListSearchDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductListSearchDGV.Size = new Size(303, 214);
            ProductListSearchDGV.TabIndex = 90;
            ProductListSearchDGV.CellDoubleClick += ProductListSearchDGV_CellDoubleClick;
            // 
            // Product_id
            // 
            Product_id.HeaderText = "Product_id";
            Product_id.MinimumWidth = 6;
            Product_id.Name = "Product_id";
            Product_id.ReadOnly = true;
            // 
            // Product_name
            // 
            Product_name.HeaderText = "Product_name";
            Product_name.MinimumWidth = 6;
            Product_name.Name = "Product_name";
            Product_name.ReadOnly = true;
            // 
            // ResetTotalBt
            // 
            ResetTotalBt.BackColor = Color.FromArgb(255, 128, 0);
            ResetTotalBt.BackGColor = Color.FromArgb(255, 128, 0);
            ResetTotalBt.BorderColor = Color.HotPink;
            ResetTotalBt.BorderRadius = 40;
            ResetTotalBt.BorderSize = 0;
            ResetTotalBt.ClickedBool = false;
            ResetTotalBt.clikedColor = Color.MediumAquamarine;
            ResetTotalBt.FlatAppearance.BorderSize = 0;
            ResetTotalBt.FlatStyle = FlatStyle.Flat;
            ResetTotalBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ResetTotalBt.ForeColor = Color.White;
            ResetTotalBt.HoverBool = false;
            ResetTotalBt.HoverColor = Color.MediumAquamarine;
            ResetTotalBt.ImageIcon = null;
            ResetTotalBt.Location = new Point(374, 104);
            ResetTotalBt.Name = "ResetTotalBt";
            ResetTotalBt.Size = new Size(101, 38);
            ResetTotalBt.TabIndex = 91;
            ResetTotalBt.Text = "Reset";
            ResetTotalBt.Textcolor = Color.White;
            ResetTotalBt.TextImageRelation = TextImageRelation.ImageBeforeText;
            ResetTotalBt.UseVisualStyleBackColor = false;
            ResetTotalBt.Click += ResetTotalBt_Click;
            // 
            // ExportBt
            // 
            ExportBt.BackColor = Color.Crimson;
            ExportBt.BackGColor = Color.Crimson;
            ExportBt.BorderColor = Color.HotPink;
            ExportBt.BorderRadius = 40;
            ExportBt.BorderSize = 0;
            ExportBt.ClickedBool = false;
            ExportBt.clikedColor = Color.MediumAquamarine;
            ExportBt.FlatAppearance.BorderSize = 0;
            ExportBt.FlatStyle = FlatStyle.Flat;
            ExportBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExportBt.ForeColor = Color.White;
            ExportBt.HoverBool = false;
            ExportBt.HoverColor = Color.MediumAquamarine;
            ExportBt.Image = (Image)resources.GetObject("ExportBt.Image");
            ExportBt.ImageIcon = (Image)resources.GetObject("ExportBt.ImageIcon");
            ExportBt.Location = new Point(720, 322);
            ExportBt.Name = "ExportBt";
            ExportBt.Size = new Size(101, 45);
            ExportBt.TabIndex = 92;
            ExportBt.Text = "Export";
            ExportBt.Textcolor = Color.White;
            ExportBt.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExportBt.UseVisualStyleBackColor = false;
            ExportBt.Click += ExportBt_Click;
            // 
            // BillViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1126, 732);
            Controls.Add(ExportBt);
            Controls.Add(ResetTotalBt);
            Controls.Add(ProductListSearchDGV);
            Controls.Add(AddProductSearchBt);
            Controls.Add(BillBtChanged);
            Controls.Add(AccountBtChanged);
            Controls.Add(DeleteButton);
            Controls.Add(Rangeco);
            Controls.Add(priceRange);
            Controls.Add(checkSearchDate);
            Controls.Add(label9);
            Controls.Add(label22);
            Controls.Add(label16);
            Controls.Add(label13);
            Controls.Add(dateTimePickerTop);
            Controls.Add(ProductSearch);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(IdSearchTextbox);
            Controls.Add(dateTimePickerBot);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchButton);
            Controls.Add(nameSearchTextbox);
            Controls.Add(UserBtChanged);
            Controls.Add(RoleBtChanged);
            Controls.Add(CategoryBtChanged);
            Controls.Add(BrandBtChanged);
            Controls.Add(ProductChangedBt);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BillViewForm";
            Text = "ProductViewForm";
            Load += BillViewForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductListSearchDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private customButton ProductChangedBt;
        private customButton BrandBtChanged;
        private customButton CategoryBtChanged;
        private customButton RoleBtChanged;
        private customButton UserBtChanged;
        private CustomTextBox nameSearchTextbox;
        private customButton searchButton;
        private DataGridViewTextBoxColumn Column2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        private CustomTextBox IdSearchTextbox;
        private ComboBox ProductSearch;
        private Label label8;
        private CustomTextBox IdDetail;
        private ComboBox branchDetail;
        private Label label14;
        private CustomTextBox CustomerNameDetail;
        private CustomTextBox CustomerAddDetail;
        private CustomTextBox TotalDetail;
        private Label label12;
        private Label label19;
        private DateTimePicker createdTimeDetail;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePickerBot;
        private DateTimePicker dateTimePickerTop;
        private Label label13;
        private Label label16;
        private Label label22;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label label9;
        private Label label23;
        private CheckBox checkSearchDate;
        private Label PriceBottom;
        private Label PriceTop;
        private Bunifu.Framework.UI.BunifuRange priceRange;
        private Label Rangeco;
        private PictureBox pictureBox1;
        private Label idDetail;
        private DateTimePicker dateTimePicker3;
        private customButton DeleteButton;
        private Label label4;
        private customButton AccountBtChanged;
        private customButton BillBtChanged;
        private PrintPreviewControl printPreviewControl1;
        private Label label6;
        private DataGridView DGV2;
        private Label label5;
        private CustomTextBox CustomerPhoneDetail;
        private CustomTextBox CreatedbyDetail;
        private Button AddProductSearchBt;
        private customButton customButton2;
        private DataGridView ProductListSearchDGV;
        private DataGridViewTextBoxColumn Product_id;
        private DataGridViewTextBoxColumn Product_name;
        private customButton ResetTotalBt;
        private customButton ExportBt;
    }
}