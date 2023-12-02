namespace ClotheShop.CustomControl
{
    partial class CategoryViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryViewForm));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            ProductListDGV = new DataGridView();
            label24 = new Label();
            ActiveDetail = new ComboBox();
            label4 = new Label();
            idDetail = new Label();
            saveBt = new customButton();
            nameDetail = new CustomTextBox();
            label8 = new Label();
            imageProductDetail = new PictureBox();
            ProductFormBtChanged = new customButton();
            BrandBtChanged = new customButton();
            customButton3 = new customButton();
            RoleChangedBt = new customButton();
            UserBtChanged = new customButton();
            searchButton = new customButton();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            label2 = new Label();
            label7 = new Label();
            IdSearchTxt = new CustomTextBox();
            label16 = new Label();
            addButton = new customButton();
            EditButton = new customButton();
            DeleteButton = new customButton();
            label12 = new Label();
            label13 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
            NameSearchTxt = new CustomTextBox();
            label5 = new Label();
            BillBtChanged = new customButton();
            AccountBtChanged = new customButton();
            ActiveChB = new CheckBox();
            ExportBt = new customButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductListDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageProductDetail).BeginInit();
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
            panel1.BackColor = Color.Chocolate;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ProductListDGV);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(ActiveDetail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(idDetail);
            panel1.Controls.Add(saveBt);
            panel1.Controls.Add(nameDetail);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(imageProductDetail);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(837, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 732);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 300);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 101;
            label1.Text = "Product list";
            // 
            // ProductListDGV
            // 
            ProductListDGV.AllowUserToAddRows = false;
            ProductListDGV.AllowUserToDeleteRows = false;
            ProductListDGV.AllowUserToResizeColumns = false;
            ProductListDGV.AllowUserToResizeRows = false;
            ProductListDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductListDGV.BackgroundColor = Color.White;
            ProductListDGV.BorderStyle = BorderStyle.None;
            ProductListDGV.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            ProductListDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle5.BackColor = Color.Cornsilk;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle5.Padding = new Padding(5, 0, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = Color.Cornsilk;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ProductListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ProductListDGV.ColumnHeadersHeight = 50;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(7, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ProductListDGV.DefaultCellStyle = dataGridViewCellStyle6;
            ProductListDGV.EnableHeadersVisualStyles = false;
            ProductListDGV.GridColor = SystemColors.ActiveCaption;
            ProductListDGV.Location = new Point(22, 322);
            ProductListDGV.Name = "ProductListDGV";
            ProductListDGV.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            ProductListDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            ProductListDGV.RowHeadersVisible = false;
            ProductListDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.DarkOrchid;
            ProductListDGV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            ProductListDGV.RowTemplate.Height = 29;
            ProductListDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductListDGV.Size = new Size(242, 239);
            ProductListDGV.TabIndex = 100;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.White;
            label24.Location = new Point(220, 216);
            label24.Name = "label24";
            label24.Size = new Size(57, 19);
            label24.TabIndex = 99;
            label24.Text = "Active";
            // 
            // ActiveDetail
            // 
            ActiveDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ActiveDetail.FormattingEnabled = true;
            ActiveDetail.Items.AddRange(new object[] { "1", "0" });
            ActiveDetail.Location = new Point(228, 238);
            ActiveDetail.Name = "ActiveDetail";
            ActiveDetail.Size = new Size(49, 29);
            ActiveDetail.TabIndex = 98;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(106, 182);
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
            idDetail.Location = new Point(138, 182);
            idDetail.Name = "idDetail";
            idDetail.Size = new Size(0, 20);
            idDetail.TabIndex = 60;
            // 
            // saveBt
            // 
            saveBt.BackColor = Color.OrangeRed;
            saveBt.BackGColor = Color.OrangeRed;
            saveBt.BorderColor = Color.HotPink;
            saveBt.BorderRadius = 40;
            saveBt.BorderSize = 0;
            saveBt.ClickedBool = false;
            saveBt.clikedColor = Color.MediumAquamarine;
            saveBt.FlatAppearance.BorderSize = 0;
            saveBt.FlatStyle = FlatStyle.Flat;
            saveBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saveBt.ForeColor = Color.White;
            saveBt.HoverBool = false;
            saveBt.HoverColor = Color.MediumAquamarine;
            saveBt.ImageIcon = null;
            saveBt.Location = new Point(9, 672);
            saveBt.Name = "saveBt";
            saveBt.Size = new Size(268, 48);
            saveBt.TabIndex = 42;
            saveBt.Text = "Save";
            saveBt.Textcolor = Color.White;
            saveBt.UseVisualStyleBackColor = false;
            saveBt.Click += saveBt_Click;
            // 
            // nameDetail
            // 
            nameDetail.BackColor = Color.White;
            nameDetail.BorderColor = Color.Gray;
            nameDetail.BorderSize = 2;
            nameDetail.EnableText = true;
            nameDetail.FocusedColor = Color.HotPink;
            nameDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nameDetail.ForeColor = SystemColors.ActiveCaptionText;
            nameDetail.IconImage = null;
            nameDetail.Location = new Point(6, 235);
            nameDetail.Margin = new Padding(0);
            nameDetail.Name = "nameDetail";
            nameDetail.OnlyNumber = false;
            nameDetail.Padding = new Padding(8, 7, 8, 7);
            nameDetail.PasswordChar = false;
            nameDetail.placeHolderText = "";
            nameDetail.setIcon = false;
            nameDetail.SetPassword = false;
            nameDetail.Size = new Size(197, 37);
            nameDetail.TabIndex = 38;
            nameDetail.Texts = "";
            nameDetail.Underlined1 = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(8, 216);
            label8.Name = "label8";
            label8.Size = new Size(54, 19);
            label8.TabIndex = 28;
            label8.Text = "Name";
            // 
            // imageProductDetail
            // 
            imageProductDetail.BackColor = Color.Transparent;
            imageProductDetail.Image = (Image)resources.GetObject("imageProductDetail.Image");
            imageProductDetail.Location = new Point(88, 75);
            imageProductDetail.Name = "imageProductDetail";
            imageProductDetail.Size = new Size(115, 93);
            imageProductDetail.SizeMode = PictureBoxSizeMode.StretchImage;
            imageProductDetail.TabIndex = 0;
            imageProductDetail.TabStop = false;
            // 
            // ProductFormBtChanged
            // 
            ProductFormBtChanged.BackColor = Color.MediumSlateBlue;
            ProductFormBtChanged.BackGColor = Color.MediumSlateBlue;
            ProductFormBtChanged.BorderColor = Color.HotPink;
            ProductFormBtChanged.BorderRadius = 40;
            ProductFormBtChanged.BorderSize = 0;
            ProductFormBtChanged.ClickedBool = false;
            ProductFormBtChanged.clikedColor = Color.MediumAquamarine;
            ProductFormBtChanged.FlatAppearance.BorderSize = 0;
            ProductFormBtChanged.FlatStyle = FlatStyle.Flat;
            ProductFormBtChanged.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProductFormBtChanged.ForeColor = Color.White;
            ProductFormBtChanged.HoverBool = false;
            ProductFormBtChanged.HoverColor = Color.MediumAquamarine;
            ProductFormBtChanged.ImageIcon = null;
            ProductFormBtChanged.Location = new Point(22, 322);
            ProductFormBtChanged.Name = "ProductFormBtChanged";
            ProductFormBtChanged.Size = new Size(103, 46);
            ProductFormBtChanged.TabIndex = 2;
            ProductFormBtChanged.Text = "Products";
            ProductFormBtChanged.Textcolor = Color.White;
            ProductFormBtChanged.UseVisualStyleBackColor = false;
            ProductFormBtChanged.Click += ProductFormBtChanged_Click;
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
            // customButton3
            // 
            customButton3.BackColor = Color.MediumTurquoise;
            customButton3.BackGColor = Color.MediumTurquoise;
            customButton3.BorderColor = Color.HotPink;
            customButton3.BorderRadius = 40;
            customButton3.BorderSize = 0;
            customButton3.ClickedBool = false;
            customButton3.clikedColor = Color.MediumAquamarine;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customButton3.ForeColor = Color.White;
            customButton3.HoverBool = false;
            customButton3.HoverColor = Color.MediumAquamarine;
            customButton3.ImageIcon = null;
            customButton3.Location = new Point(134, 322);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(94, 46);
            customButton3.TabIndex = 4;
            customButton3.Text = "Category";
            customButton3.Textcolor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // RoleChangedBt
            // 
            RoleChangedBt.BackColor = Color.MediumSlateBlue;
            RoleChangedBt.BackGColor = Color.MediumSlateBlue;
            RoleChangedBt.BorderColor = Color.HotPink;
            RoleChangedBt.BorderRadius = 40;
            RoleChangedBt.BorderSize = 0;
            RoleChangedBt.ClickedBool = false;
            RoleChangedBt.clikedColor = Color.MediumAquamarine;
            RoleChangedBt.FlatAppearance.BorderSize = 0;
            RoleChangedBt.FlatStyle = FlatStyle.Flat;
            RoleChangedBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RoleChangedBt.ForeColor = Color.White;
            RoleChangedBt.HoverBool = false;
            RoleChangedBt.HoverColor = Color.MediumAquamarine;
            RoleChangedBt.ImageIcon = null;
            RoleChangedBt.Location = new Point(439, 322);
            RoleChangedBt.Name = "RoleChangedBt";
            RoleChangedBt.Size = new Size(83, 46);
            RoleChangedBt.TabIndex = 5;
            RoleChangedBt.Text = "Role";
            RoleChangedBt.Textcolor = Color.White;
            RoleChangedBt.UseVisualStyleBackColor = false;
            RoleChangedBt.Click += RoleBtChanged_Click;
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
            searchButton.Location = new Point(20, 251);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 3);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 23;
            // 
            // IdSearchTxt
            // 
            IdSearchTxt.BackColor = Color.White;
            IdSearchTxt.BorderColor = Color.MediumAquamarine;
            IdSearchTxt.BorderSize = 2;
            IdSearchTxt.EnableText = true;
            IdSearchTxt.FocusedColor = Color.HotPink;
            IdSearchTxt.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            IdSearchTxt.ForeColor = SystemColors.ActiveCaptionText;
            IdSearchTxt.IconImage = null;
            IdSearchTxt.Location = new Point(22, 44);
            IdSearchTxt.Margin = new Padding(0);
            IdSearchTxt.Name = "IdSearchTxt";
            IdSearchTxt.OnlyNumber = true;
            IdSearchTxt.Padding = new Padding(8, 7, 8, 7);
            IdSearchTxt.PasswordChar = false;
            IdSearchTxt.placeHolderText = "";
            IdSearchTxt.setIcon = false;
            IdSearchTxt.SetPassword = false;
            IdSearchTxt.Size = new Size(185, 37);
            IdSearchTxt.TabIndex = 21;
            IdSearchTxt.Texts = "";
            IdSearchTxt.Underlined1 = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Blue;
            label16.Location = new Point(22, 23);
            label16.Name = "label16";
            label16.Size = new Size(29, 21);
            label16.TabIndex = 59;
            label16.Text = "Id";
            // 
            // addButton
            // 
            addButton.BackColor = Color.Gold;
            addButton.BackGColor = Color.Gold;
            addButton.BorderColor = Color.HotPink;
            addButton.BorderRadius = 40;
            addButton.BorderSize = 0;
            addButton.ClickedBool = false;
            addButton.clikedColor = Color.MediumAquamarine;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.HoverBool = false;
            addButton.HoverColor = Color.MediumAquamarine;
            addButton.Image = (Image)resources.GetObject("addButton.Image");
            addButton.ImageIcon = (Image)resources.GetObject("addButton.ImageIcon");
            addButton.Location = new Point(134, 251);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 38);
            addButton.TabIndex = 83;
            addButton.Text = "Add";
            addButton.Textcolor = Color.White;
            addButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.LawnGreen;
            EditButton.BackGColor = Color.LawnGreen;
            EditButton.BorderColor = Color.HotPink;
            EditButton.BorderRadius = 40;
            EditButton.BorderSize = 0;
            EditButton.ClickedBool = false;
            EditButton.clikedColor = Color.MediumAquamarine;
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.ForeColor = Color.White;
            EditButton.HoverBool = false;
            EditButton.HoverColor = Color.MediumAquamarine;
            EditButton.Image = (Image)resources.GetObject("EditButton.Image");
            EditButton.ImageIcon = (Image)resources.GetObject("EditButton.ImageIcon");
            EditButton.Location = new Point(234, 251);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 38);
            EditButton.TabIndex = 84;
            EditButton.Text = "Edit";
            EditButton.Textcolor = Color.White;
            EditButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
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
            DeleteButton.Location = new Point(340, 251);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(101, 38);
            DeleteButton.TabIndex = 85;
            DeleteButton.Text = "Delete";
            DeleteButton.Textcolor = Color.White;
            DeleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 75);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 89;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 148);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 87;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(246, 149);
            label18.Name = "label18";
            label18.Size = new Size(0, 20);
            label18.TabIndex = 95;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(248, 222);
            label19.Name = "label19";
            label19.Size = new Size(0, 20);
            label19.TabIndex = 93;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(248, 150);
            label20.Name = "label20";
            label20.Size = new Size(0, 20);
            label20.TabIndex = 92;
            // 
            // bunifuElipse3
            // 
            bunifuElipse3.ElipseRadius = 15;
            bunifuElipse3.TargetControl = this;
            // 
            // NameSearchTxt
            // 
            NameSearchTxt.BackColor = Color.White;
            NameSearchTxt.BorderColor = Color.MediumAquamarine;
            NameSearchTxt.BorderSize = 2;
            NameSearchTxt.EnableText = true;
            NameSearchTxt.FocusedColor = Color.HotPink;
            NameSearchTxt.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            NameSearchTxt.ForeColor = SystemColors.ActiveCaptionText;
            NameSearchTxt.IconImage = null;
            NameSearchTxt.Location = new Point(246, 44);
            NameSearchTxt.Margin = new Padding(0);
            NameSearchTxt.Name = "NameSearchTxt";
            NameSearchTxt.OnlyNumber = false;
            NameSearchTxt.Padding = new Padding(8, 7, 8, 7);
            NameSearchTxt.PasswordChar = false;
            NameSearchTxt.placeHolderText = "";
            NameSearchTxt.setIcon = false;
            NameSearchTxt.SetPassword = false;
            NameSearchTxt.Size = new Size(205, 37);
            NameSearchTxt.TabIndex = 98;
            NameSearchTxt.Texts = "";
            NameSearchTxt.Underlined1 = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(248, 23);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 99;
            label5.Text = "Name";
            // 
            // BillBtChanged
            // 
            BillBtChanged.BackColor = Color.MediumSlateBlue;
            BillBtChanged.BackGColor = Color.MediumSlateBlue;
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
            BillBtChanged.Location = new Point(647, 322);
            BillBtChanged.Name = "BillBtChanged";
            BillBtChanged.Size = new Size(72, 46);
            BillBtChanged.TabIndex = 103;
            BillBtChanged.Text = "Bill";
            BillBtChanged.Textcolor = Color.White;
            BillBtChanged.UseVisualStyleBackColor = false;
            BillBtChanged.Click += BillBtChanged_Click;
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
            AccountBtChanged.Location = new Point(538, 322);
            AccountBtChanged.Name = "AccountBtChanged";
            AccountBtChanged.Size = new Size(103, 46);
            AccountBtChanged.TabIndex = 102;
            AccountBtChanged.Text = "Accounts";
            AccountBtChanged.Textcolor = Color.White;
            AccountBtChanged.UseVisualStyleBackColor = false;
            AccountBtChanged.Click += AccountBtChanged_Click;
            // 
            // ActiveChB
            // 
            ActiveChB.AutoSize = true;
            ActiveChB.Checked = true;
            ActiveChB.CheckState = CheckState.Checked;
            ActiveChB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ActiveChB.Location = new Point(22, 104);
            ActiveChB.Name = "ActiveChB";
            ActiveChB.Size = new Size(90, 24);
            ActiveChB.TabIndex = 104;
            ActiveChB.Text = "In Active";
            ActiveChB.UseVisualStyleBackColor = true;
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
            ExportBt.TabIndex = 105;
            ExportBt.Text = "Export";
            ExportBt.Textcolor = Color.White;
            ExportBt.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExportBt.UseVisualStyleBackColor = false;
            ExportBt.Click += ExportBt_Click;
            // 
            // CategoryViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1126, 732);
            Controls.Add(ExportBt);
            Controls.Add(ActiveChB);
            Controls.Add(BillBtChanged);
            Controls.Add(AccountBtChanged);
            Controls.Add(label5);
            Controls.Add(NameSearchTxt);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(addButton);
            Controls.Add(label16);
            Controls.Add(label7);
            Controls.Add(IdSearchTxt);
            Controls.Add(label2);
            Controls.Add(searchButton);
            Controls.Add(UserBtChanged);
            Controls.Add(RoleChangedBt);
            Controls.Add(customButton3);
            Controls.Add(BrandBtChanged);
            Controls.Add(ProductFormBtChanged);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryViewForm";
            Text = "ProductViewForm";
            Load += CategoryViewForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductListDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageProductDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private customButton ProductFormBtChanged;
        private customButton BrandBtChanged;
        private customButton customButton3;
        private customButton RoleChangedBt;
        private customButton UserBtChanged;
        private customButton searchButton;
        private DataGridViewTextBoxColumn Column2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Label label2;
        private Label label7;
        private CustomTextBox IdSearchTxt;
        private CustomTextBox IdDetail;
        private ComboBox branchDetail;
        private CustomTextBox nameDetail;
        private customButton saveBt;
        private Label label16;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label label23;
        private Label PriceBottom;
        private Label PriceTop;
        private PictureBox pictureBox1;
        private Label idDetail;
        private customButton addButton;
        private DateTimePicker dateTimePicker3;
        private customButton EditButton;
        private customButton DeleteButton;
        private Label label4;
        private Label label12;
        private Label label13;
        private Label label18;
        private Label label19;
        private Label label20;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Label label24;
        private ComboBox ActiveDetail;
        private CustomTextBox NameSearchTxt;
        private Label label5;
        private Label label3;
        private Label label1;
        private DataGridView ProductListDGV;
        private Label label8;
        private PictureBox imageProductDetail;
        private customButton BillBtChanged;
        private customButton AccountBtChanged;
        private CheckBox ActiveChB;
        private customButton ExportBt;
    }
}