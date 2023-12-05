namespace ClotheShop.CustomControl
{
    partial class BrandViewForm
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandViewForm));
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
            customButton2 = new customButton();
            CategoryChangedBt = new customButton();
            RoleChangedBt = new customButton();
            UserChangedBt = new customButton();
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
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle9.BackColor = Color.Cornsilk;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle9.Padding = new Padding(5, 0, 0, 5);
            dataGridViewCellStyle9.SelectionBackColor = Color.Cornsilk;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new Padding(7, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(22, 374);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.DarkOrchid;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(799, 358);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 300);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 101;
            label1.Text = "Product List";
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle13.BackColor = Color.Cornsilk;
            dataGridViewCellStyle13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle13.Padding = new Padding(5, 0, 0, 5);
            dataGridViewCellStyle13.SelectionBackColor = Color.Cornsilk;
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            ProductListDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            ProductListDGV.ColumnHeadersHeight = 50;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.Padding = new Padding(7, 0, 0, 0);
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            ProductListDGV.DefaultCellStyle = dataGridViewCellStyle14;
            ProductListDGV.EnableHeadersVisualStyles = false;
            ProductListDGV.GridColor = SystemColors.ActiveCaption;
            ProductListDGV.Location = new Point(22, 322);
            ProductListDGV.Name = "ProductListDGV";
            ProductListDGV.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            ProductListDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            ProductListDGV.RowHeadersVisible = false;
            ProductListDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle16.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = Color.DarkOrchid;
            ProductListDGV.RowsDefaultCellStyle = dataGridViewCellStyle16;
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
            saveBt.BackColor = Color.DarkSlateBlue;
            saveBt.BackGColor = Color.DarkSlateBlue;
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
            saveBt.Location = new Point(9, 649);
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
            imageProductDetail.Location = new Point(52, 3);
            imageProductDetail.Name = "imageProductDetail";
            imageProductDetail.Size = new Size(182, 167);
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
            // customButton2
            // 
            customButton2.BackColor = Color.MediumTurquoise;
            customButton2.BackGColor = Color.MediumTurquoise;
            customButton2.BorderColor = Color.HotPink;
            customButton2.BorderRadius = 40;
            customButton2.BorderSize = 0;
            customButton2.ClickedBool = false;
            customButton2.clikedColor = Color.MediumAquamarine;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customButton2.ForeColor = Color.White;
            customButton2.HoverBool = false;
            customButton2.HoverColor = Color.MediumAquamarine;
            customButton2.ImageIcon = null;
            customButton2.Location = new Point(340, 322);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(93, 46);
            customButton2.TabIndex = 3;
            customButton2.Text = "Brand";
            customButton2.Textcolor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // CategoryChangedBt
            // 
            CategoryChangedBt.BackColor = Color.MediumSlateBlue;
            CategoryChangedBt.BackGColor = Color.MediumSlateBlue;
            CategoryChangedBt.BorderColor = Color.HotPink;
            CategoryChangedBt.BorderRadius = 40;
            CategoryChangedBt.BorderSize = 0;
            CategoryChangedBt.ClickedBool = false;
            CategoryChangedBt.clikedColor = Color.MediumAquamarine;
            CategoryChangedBt.FlatAppearance.BorderSize = 0;
            CategoryChangedBt.FlatStyle = FlatStyle.Flat;
            CategoryChangedBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryChangedBt.ForeColor = Color.White;
            CategoryChangedBt.HoverBool = false;
            CategoryChangedBt.HoverColor = Color.MediumAquamarine;
            CategoryChangedBt.ImageIcon = null;
            CategoryChangedBt.Location = new Point(134, 322);
            CategoryChangedBt.Name = "CategoryChangedBt";
            CategoryChangedBt.Size = new Size(94, 46);
            CategoryChangedBt.TabIndex = 4;
            CategoryChangedBt.Text = "Category";
            CategoryChangedBt.Textcolor = Color.White;
            CategoryChangedBt.UseVisualStyleBackColor = false;
            CategoryChangedBt.Click += CategoryBtChanged_Click;
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
            // UserChangedBt
            // 
            UserChangedBt.BackColor = Color.MediumSlateBlue;
            UserChangedBt.BackGColor = Color.MediumSlateBlue;
            UserChangedBt.BorderColor = Color.HotPink;
            UserChangedBt.BorderRadius = 40;
            UserChangedBt.BorderSize = 0;
            UserChangedBt.ClickedBool = false;
            UserChangedBt.clikedColor = Color.MediumAquamarine;
            UserChangedBt.FlatAppearance.BorderSize = 0;
            UserChangedBt.FlatStyle = FlatStyle.Flat;
            UserChangedBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserChangedBt.ForeColor = Color.White;
            UserChangedBt.HoverBool = false;
            UserChangedBt.HoverColor = Color.MediumAquamarine;
            UserChangedBt.ImageIcon = null;
            UserChangedBt.Location = new Point(234, 322);
            UserChangedBt.Name = "UserChangedBt";
            UserChangedBt.Size = new Size(100, 46);
            UserChangedBt.TabIndex = 6;
            UserChangedBt.Text = "User";
            UserChangedBt.Textcolor = Color.White;
            UserChangedBt.UseVisualStyleBackColor = false;
            UserChangedBt.Click += UserFormBtChanged_Click;
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
            BillBtChanged.Location = new Point(637, 322);
            BillBtChanged.Name = "BillBtChanged";
            BillBtChanged.Size = new Size(72, 46);
            BillBtChanged.TabIndex = 107;
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
            AccountBtChanged.Location = new Point(528, 322);
            AccountBtChanged.Name = "AccountBtChanged";
            AccountBtChanged.Size = new Size(103, 46);
            AccountBtChanged.TabIndex = 106;
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
            ActiveChB.Location = new Point(20, 121);
            ActiveChB.Name = "ActiveChB";
            ActiveChB.Size = new Size(90, 24);
            ActiveChB.TabIndex = 108;
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
            ExportBt.Location = new Point(715, 322);
            ExportBt.Name = "ExportBt";
            ExportBt.Size = new Size(101, 45);
            ExportBt.TabIndex = 109;
            ExportBt.Text = "Export";
            ExportBt.Textcolor = Color.White;
            ExportBt.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExportBt.UseVisualStyleBackColor = false;
            ExportBt.Click += ExportBt_Click;
            // 
            // BrandViewForm
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
            Controls.Add(UserChangedBt);
            Controls.Add(RoleChangedBt);
            Controls.Add(CategoryChangedBt);
            Controls.Add(customButton2);
            Controls.Add(ProductFormBtChanged);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BrandViewForm";
            Text = "ProductViewForm";
            Load += BrandViewForm_Load;
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
        private customButton customButton2;
        private customButton CategoryChangedBt;
        private customButton RoleChangedBt;
        private customButton UserChangedBt;
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