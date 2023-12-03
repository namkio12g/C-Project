namespace ClotheShop.CustomControl
{
    partial class ProductViewForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductViewForm));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label24 = new Label();
            ActiveDetail = new ComboBox();
            label4 = new Label();
            idDetail = new Label();
            saveBt = new customButton();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            editedbyDetail = new CustomTextBox();
            CreatedbyDetail = new CustomTextBox();
            editedTimeDetail = new DateTimePicker();
            createdTimeDetail = new DateTimePicker();
            label15 = new Label();
            label10 = new Label();
            label18 = new Label();
            CategoryDetail = new ComboBox();
            label17 = new Label();
            QuantityDetail = new CustomTextBox();
            label12 = new Label();
            priceDetail = new CustomTextBox();
            label14 = new Label();
            nameDetail = new CustomTextBox();
            DescriptionDetail = new TextBox();
            brandDetail = new ComboBox();
            label8 = new Label();
            uploadImageBt = new customButton();
            imageProductDetail = new PictureBox();
            AddBillBt = new customButton();
            customButton1 = new customButton();
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
            BrandSearch = new ComboBox();
            CategorySearch = new ComboBox();
            dateTimePickerBot = new DateTimePicker();
            dateTimePickerTop = new DateTimePicker();
            label6 = new Label();
            label13 = new Label();
            label16 = new Label();
            label22 = new Label();
            label9 = new Label();
            checkSearchDate = new CheckBox();
            priceRange = new Bunifu.Framework.UI.BunifuRange();
            Rangeco = new Label();
            quantityRange = new Bunifu.Framework.UI.BunifuRange();
            label5 = new Label();
            QuantityLabel = new Label();
            addButton = new customButton();
            EditButton = new customButton();
            DeleteButton = new customButton();
            AccountBtChanged = new customButton();
            BillBtChanged = new customButton();
            ActiveChB = new CheckBox();
            ResetPriceBt = new customButton();
            ResetQuanBt = new customButton();
            ExportBt = new customButton();
            ImportBt = new customButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle5.BackColor = Color.Cornsilk;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle5.Padding = new Padding(5, 0, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = Color.Cornsilk;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(7, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(22, 374);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.DarkOrchid;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(799, 358);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(label24);
            panel1.Controls.Add(ActiveDetail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(idDetail);
            panel1.Controls.Add(saveBt);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(editedbyDetail);
            panel1.Controls.Add(CreatedbyDetail);
            panel1.Controls.Add(editedTimeDetail);
            panel1.Controls.Add(createdTimeDetail);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(CategoryDetail);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(QuantityDetail);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(priceDetail);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(nameDetail);
            panel1.Controls.Add(DescriptionDetail);
            panel1.Controls.Add(brandDetail);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(uploadImageBt);
            panel1.Controls.Add(imageProductDetail);
            panel1.Controls.Add(AddBillBt);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(837, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 732);
            panel1.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.White;
            label24.Location = new Point(220, 357);
            label24.Name = "label24";
            label24.Size = new Size(57, 19);
            label24.TabIndex = 63;
            label24.Text = "Active";
            // 
            // ActiveDetail
            // 
            ActiveDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ActiveDetail.FormattingEnabled = true;
            ActiveDetail.Items.AddRange(new object[] { "1", "0" });
            ActiveDetail.Location = new Point(228, 377);
            ActiveDetail.Name = "ActiveDetail";
            ActiveDetail.Size = new Size(49, 29);
            ActiveDetail.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(204, 213);
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
            idDetail.Location = new Point(236, 214);
            idDetail.Name = "idDetail";
            idDetail.Size = new Size(0, 20);
            idDetail.TabIndex = 60;
            // 
            // saveBt
            // 
            saveBt.BackColor = Color.MidnightBlue;
            saveBt.BackGColor = Color.MidnightBlue;
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
            saveBt.Location = new Point(9, 674);
            saveBt.Name = "saveBt";
            saveBt.Size = new Size(268, 48);
            saveBt.TabIndex = 42;
            saveBt.Text = "Save";
            saveBt.Textcolor = Color.White;
            saveBt.UseVisualStyleBackColor = false;
            saveBt.Click += saveBt_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(9, 521);
            label21.Name = "label21";
            label21.Size = new Size(100, 19);
            label21.TabIndex = 58;
            label21.Text = "Description";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(167, 469);
            label20.Name = "label20";
            label20.Size = new Size(98, 19);
            label20.TabIndex = 57;
            label20.Text = "Edited time";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(6, 469);
            label19.Name = "label19";
            label19.Size = new Size(110, 19);
            label19.TabIndex = 56;
            label19.Text = "Created time";
            // 
            // editedbyDetail
            // 
            editedbyDetail.BackColor = Color.White;
            editedbyDetail.BorderColor = Color.Gray;
            editedbyDetail.BorderSize = 2;
            editedbyDetail.EnableText = true;
            editedbyDetail.FocusedColor = Color.HotPink;
            editedbyDetail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            editedbyDetail.IconImage = null;
            editedbyDetail.Location = new Point(144, 430);
            editedbyDetail.Margin = new Padding(0);
            editedbyDetail.Name = "editedbyDetail";
            editedbyDetail.OnlyNumber = false;
            editedbyDetail.Padding = new Padding(8, 7, 8, 7);
            editedbyDetail.PasswordChar = false;
            editedbyDetail.placeHolderText = "";
            editedbyDetail.setIcon = false;
            editedbyDetail.SetPassword = false;
            editedbyDetail.Size = new Size(133, 39);
            editedbyDetail.TabIndex = 55;
            editedbyDetail.Texts = "";
            editedbyDetail.Underlined1 = false;
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
            CreatedbyDetail.Location = new Point(6, 430);
            CreatedbyDetail.Margin = new Padding(0);
            CreatedbyDetail.Name = "CreatedbyDetail";
            CreatedbyDetail.OnlyNumber = false;
            CreatedbyDetail.Padding = new Padding(8, 7, 8, 7);
            CreatedbyDetail.PasswordChar = false;
            CreatedbyDetail.placeHolderText = "";
            CreatedbyDetail.setIcon = false;
            CreatedbyDetail.SetPassword = false;
            CreatedbyDetail.Size = new Size(129, 39);
            CreatedbyDetail.TabIndex = 54;
            CreatedbyDetail.Texts = "";
            CreatedbyDetail.Underlined1 = false;
            // 
            // editedTimeDetail
            // 
            editedTimeDetail.Enabled = false;
            editedTimeDetail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editedTimeDetail.Format = DateTimePickerFormat.Short;
            editedTimeDetail.Location = new Point(144, 491);
            editedTimeDetail.Name = "editedTimeDetail";
            editedTimeDetail.Size = new Size(133, 27);
            editedTimeDetail.TabIndex = 53;
            // 
            // createdTimeDetail
            // 
            createdTimeDetail.Enabled = false;
            createdTimeDetail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createdTimeDetail.Format = DateTimePickerFormat.Short;
            createdTimeDetail.Location = new Point(6, 491);
            createdTimeDetail.Name = "createdTimeDetail";
            createdTimeDetail.Size = new Size(129, 27);
            createdTimeDetail.TabIndex = 52;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(179, 411);
            label15.Name = "label15";
            label15.Size = new Size(83, 19);
            label15.TabIndex = 51;
            label15.Text = "Edited by";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(6, 411);
            label10.Name = "label10";
            label10.Size = new Size(95, 19);
            label10.TabIndex = 50;
            label10.Text = "Created by";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(122, 357);
            label18.Name = "label18";
            label18.Size = new Size(80, 19);
            label18.TabIndex = 49;
            label18.Text = "Category";
            // 
            // CategoryDetail
            // 
            CategoryDetail.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryDetail.FormattingEnabled = true;
            CategoryDetail.Location = new Point(122, 377);
            CategoryDetail.Name = "CategoryDetail";
            CategoryDetail.Size = new Size(100, 30);
            CategoryDetail.TabIndex = 48;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(9, 357);
            label17.Name = "label17";
            label17.Size = new Size(66, 19);
            label17.TabIndex = 47;
            label17.Text = "Branch";
            // 
            // QuantityDetail
            // 
            QuantityDetail.BackColor = Color.White;
            QuantityDetail.BorderColor = Color.Gray;
            QuantityDetail.BorderSize = 2;
            QuantityDetail.EnableText = true;
            QuantityDetail.FocusedColor = Color.HotPink;
            QuantityDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityDetail.ForeColor = SystemColors.ActiveCaptionText;
            QuantityDetail.IconImage = null;
            QuantityDetail.Location = new Point(185, 319);
            QuantityDetail.Margin = new Padding(0);
            QuantityDetail.Name = "QuantityDetail";
            QuantityDetail.OnlyNumber = true;
            QuantityDetail.Padding = new Padding(8, 7, 8, 7);
            QuantityDetail.PasswordChar = false;
            QuantityDetail.placeHolderText = "";
            QuantityDetail.setIcon = false;
            QuantityDetail.SetPassword = false;
            QuantityDetail.Size = new Size(92, 37);
            QuantityDetail.TabIndex = 46;
            QuantityDetail.Texts = "";
            QuantityDetail.Underlined1 = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(185, 300);
            label12.Name = "label12";
            label12.Size = new Size(77, 19);
            label12.TabIndex = 45;
            label12.Text = "Quantity";
            // 
            // priceDetail
            // 
            priceDetail.BackColor = Color.White;
            priceDetail.BorderColor = Color.Gray;
            priceDetail.BorderSize = 2;
            priceDetail.EnableText = true;
            priceDetail.FocusedColor = Color.HotPink;
            priceDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            priceDetail.ForeColor = SystemColors.ActiveCaptionText;
            priceDetail.IconImage = null;
            priceDetail.Location = new Point(6, 319);
            priceDetail.Margin = new Padding(0);
            priceDetail.Name = "priceDetail";
            priceDetail.OnlyNumber = true;
            priceDetail.Padding = new Padding(8, 7, 8, 7);
            priceDetail.PasswordChar = false;
            priceDetail.placeHolderText = "";
            priceDetail.setIcon = false;
            priceDetail.SetPassword = false;
            priceDetail.Size = new Size(175, 37);
            priceDetail.TabIndex = 44;
            priceDetail.Texts = "";
            priceDetail.Underlined1 = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(9, 298);
            label14.Name = "label14";
            label14.Size = new Size(50, 19);
            label14.TabIndex = 39;
            label14.Text = "Price";
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
            nameDetail.Location = new Point(6, 259);
            nameDetail.Margin = new Padding(0);
            nameDetail.Name = "nameDetail";
            nameDetail.OnlyNumber = false;
            nameDetail.Padding = new Padding(8, 7, 8, 7);
            nameDetail.PasswordChar = false;
            nameDetail.placeHolderText = "";
            nameDetail.setIcon = false;
            nameDetail.SetPassword = false;
            nameDetail.Size = new Size(271, 37);
            nameDetail.TabIndex = 38;
            nameDetail.Texts = "";
            nameDetail.Underlined1 = false;
            // 
            // DescriptionDetail
            // 
            DescriptionDetail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DescriptionDetail.ForeColor = SystemColors.InfoText;
            DescriptionDetail.Location = new Point(9, 543);
            DescriptionDetail.Multiline = true;
            DescriptionDetail.Name = "DescriptionDetail";
            DescriptionDetail.Size = new Size(268, 126);
            DescriptionDetail.TabIndex = 36;
            // 
            // brandDetail
            // 
            brandDetail.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            brandDetail.FormattingEnabled = true;
            brandDetail.Location = new Point(6, 377);
            brandDetail.Name = "brandDetail";
            brandDetail.Size = new Size(110, 30);
            brandDetail.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(9, 240);
            label8.Name = "label8";
            label8.Size = new Size(54, 19);
            label8.TabIndex = 28;
            label8.Text = "Name";
            // 
            // uploadImageBt
            // 
            uploadImageBt.BackColor = Color.MidnightBlue;
            uploadImageBt.BackGColor = Color.MidnightBlue;
            uploadImageBt.BorderColor = Color.HotPink;
            uploadImageBt.BorderRadius = 40;
            uploadImageBt.BorderSize = 0;
            uploadImageBt.ClickedBool = false;
            uploadImageBt.clikedColor = Color.MediumAquamarine;
            uploadImageBt.FlatAppearance.BorderSize = 0;
            uploadImageBt.FlatStyle = FlatStyle.Flat;
            uploadImageBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            uploadImageBt.ForeColor = Color.White;
            uploadImageBt.HoverBool = false;
            uploadImageBt.HoverColor = Color.MediumAquamarine;
            uploadImageBt.Image = (Image)resources.GetObject("uploadImageBt.Image");
            uploadImageBt.ImageIcon = (Image)resources.GetObject("uploadImageBt.ImageIcon");
            uploadImageBt.Location = new Point(92, 200);
            uploadImageBt.Name = "uploadImageBt";
            uploadImageBt.Size = new Size(89, 47);
            uploadImageBt.TabIndex = 16;
            uploadImageBt.Text = "From";
            uploadImageBt.Textcolor = Color.White;
            uploadImageBt.TextImageRelation = TextImageRelation.ImageBeforeText;
            uploadImageBt.UseVisualStyleBackColor = false;
            uploadImageBt.Click += uploadImageBt_Click;
            // 
            // imageProductDetail
            // 
            imageProductDetail.BackColor = Color.Gainsboro;
            imageProductDetail.Location = new Point(33, 12);
            imageProductDetail.Name = "imageProductDetail";
            imageProductDetail.Size = new Size(220, 180);
            imageProductDetail.SizeMode = PictureBoxSizeMode.StretchImage;
            imageProductDetail.TabIndex = 0;
            imageProductDetail.TabStop = false;
            // 
            // AddBillBt
            // 
            AddBillBt.BackColor = Color.HotPink;
            AddBillBt.BackGColor = Color.HotPink;
            AddBillBt.BorderColor = Color.HotPink;
            AddBillBt.BorderRadius = 40;
            AddBillBt.BorderSize = 0;
            AddBillBt.ClickedBool = false;
            AddBillBt.clikedColor = Color.MediumAquamarine;
            AddBillBt.FlatAppearance.BorderSize = 0;
            AddBillBt.FlatStyle = FlatStyle.Flat;
            AddBillBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddBillBt.ForeColor = Color.White;
            AddBillBt.HoverBool = false;
            AddBillBt.HoverColor = Color.MediumAquamarine;
            AddBillBt.ImageIcon = null;
            AddBillBt.Location = new Point(9, 674);
            AddBillBt.Name = "AddBillBt";
            AddBillBt.Size = new Size(268, 48);
            AddBillBt.TabIndex = 65;
            AddBillBt.Text = "Add to Bill";
            AddBillBt.Textcolor = Color.White;
            AddBillBt.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.DarkTurquoise;
            customButton1.BackGColor = Color.DarkTurquoise;
            customButton1.BorderColor = Color.HotPink;
            customButton1.BorderRadius = 40;
            customButton1.BorderSize = 0;
            customButton1.ClickedBool = false;
            customButton1.clikedColor = Color.MediumAquamarine;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.HoverBool = false;
            customButton1.HoverColor = Color.MediumAquamarine;
            customButton1.ImageIcon = null;
            customButton1.Location = new Point(22, 322);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(103, 46);
            customButton1.TabIndex = 2;
            customButton1.Text = "Products";
            customButton1.Textcolor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
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
            nameSearchTextbox.Location = new Point(248, 44);
            nameSearchTextbox.Margin = new Padding(0);
            nameSearchTextbox.Name = "nameSearchTextbox";
            nameSearchTextbox.OnlyNumber = false;
            nameSearchTextbox.Padding = new Padding(8, 7, 8, 7);
            nameSearchTextbox.PasswordChar = false;
            nameSearchTextbox.placeHolderText = "";
            nameSearchTextbox.setIcon = false;
            nameSearchTextbox.SetPassword = false;
            nameSearchTextbox.Size = new Size(205, 37);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(211, 199);
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
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(393, 23);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 25;
            label3.Text = "Name";
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
            IdSearchTextbox.Location = new Point(22, 44);
            IdSearchTextbox.Margin = new Padding(0);
            IdSearchTextbox.Name = "IdSearchTextbox";
            IdSearchTextbox.OnlyNumber = true;
            IdSearchTextbox.Padding = new Padding(8, 7, 8, 7);
            IdSearchTextbox.PasswordChar = false;
            IdSearchTextbox.placeHolderText = "";
            IdSearchTextbox.setIcon = false;
            IdSearchTextbox.SetPassword = false;
            IdSearchTextbox.Size = new Size(185, 37);
            IdSearchTextbox.TabIndex = 21;
            IdSearchTextbox.Texts = "";
            IdSearchTextbox.Underlined1 = false;
            // 
            // BrandSearch
            // 
            BrandSearch.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BrandSearch.FormattingEnabled = true;
            BrandSearch.Items.AddRange(new object[] { "", "Brand", "lo", "ld", "asd", "dasd" });
            BrandSearch.Location = new Point(22, 114);
            BrandSearch.Name = "BrandSearch";
            BrandSearch.Size = new Size(185, 28);
            BrandSearch.TabIndex = 26;
            // 
            // CategorySearch
            // 
            CategorySearch.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CategorySearch.FormattingEnabled = true;
            CategorySearch.Items.AddRange(new object[] { "vietnam,dl,asdd,sad" });
            CategorySearch.Location = new Point(248, 114);
            CategorySearch.Name = "CategorySearch";
            CategorySearch.Size = new Size(205, 28);
            CategorySearch.TabIndex = 27;
            // 
            // dateTimePickerBot
            // 
            dateTimePickerBot.Enabled = false;
            dateTimePickerBot.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerBot.Format = DateTimePickerFormat.Short;
            dateTimePickerBot.Location = new Point(20, 199);
            dateTimePickerBot.Name = "dateTimePickerBot";
            dateTimePickerBot.Size = new Size(185, 27);
            dateTimePickerBot.TabIndex = 52;
            // 
            // dateTimePickerTop
            // 
            dateTimePickerTop.Enabled = false;
            dateTimePickerTop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerTop.Format = DateTimePickerFormat.Short;
            dateTimePickerTop.Location = new Point(248, 199);
            dateTimePickerTop.Name = "dateTimePickerTop";
            dateTimePickerTop.Size = new Size(205, 27);
            dateTimePickerTop.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(364, 90);
            label6.Name = "label6";
            label6.Size = new Size(89, 21);
            label6.TabIndex = 56;
            label6.Text = "Category";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Blue;
            label13.Location = new Point(20, 177);
            label13.Name = "label13";
            label13.Size = new Size(123, 21);
            label13.TabIndex = 58;
            label13.Text = "Created date";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Blue;
            label16.Location = new Point(22, 23);
            label16.Name = "label16";
            label16.Size = new Size(29, 21);
            label16.TabIndex = 59;
            label16.Text = "Id";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Blue;
            label22.Location = new Point(20, 90);
            label22.Name = "label22";
            label22.Size = new Size(65, 21);
            label22.TabIndex = 60;
            label22.Text = "Brand";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(511, 23);
            label9.Name = "label9";
            label9.Size = new Size(57, 21);
            label9.TabIndex = 68;
            label9.Text = "Price";
            // 
            // checkSearchDate
            // 
            checkSearchDate.AutoSize = true;
            checkSearchDate.BackColor = Color.Transparent;
            checkSearchDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkSearchDate.Location = new Point(20, 151);
            checkSearchDate.Name = "checkSearchDate";
            checkSearchDate.Size = new Size(168, 24);
            checkSearchDate.TabIndex = 70;
            checkSearchDate.Text = "Search Created date";
            checkSearchDate.UseVisualStyleBackColor = false;
            checkSearchDate.Click += checkSearchDate_Click;
            // 
            // priceRange
            // 
            priceRange.BackColor = Color.Transparent;
            priceRange.BackgroudColor = Color.MidnightBlue;
            priceRange.BorderRadius = 10;
            priceRange.IndicatorColor = Color.DodgerBlue;
            priceRange.Location = new Point(476, 44);
            priceRange.Margin = new Padding(4, 5, 4, 5);
            priceRange.MaximumRange = 100000;
            priceRange.MaximumSize = new Size(345, 0);
            priceRange.Name = "priceRange";
            priceRange.RangeMax = 99999;
            priceRange.RangeMin = 0;
            priceRange.Size = new Size(345, 41);
            priceRange.TabIndex = 79;
            priceRange.RangeChanged += bunifuRange1_RangeChanged;
            priceRange.Load += bunifuRange1_Load;
            // 
            // Rangeco
            // 
            Rangeco.AutoSize = true;
            Rangeco.BackColor = Color.Transparent;
            Rangeco.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Rangeco.ForeColor = Color.OrangeRed;
            Rangeco.Location = new Point(511, 90);
            Rangeco.Name = "Rangeco";
            Rangeco.Size = new Size(57, 21);
            Rangeco.TabIndex = 80;
            Rangeco.Text = "Price";
            // 
            // quantityRange
            // 
            quantityRange.BackColor = Color.Transparent;
            quantityRange.BackgroudColor = Color.FromArgb(0, 192, 0);
            quantityRange.BorderRadius = 10;
            quantityRange.ForeColor = SystemColors.ControlDarkDark;
            quantityRange.IndicatorColor = Color.Khaki;
            quantityRange.Location = new Point(476, 167);
            quantityRange.Margin = new Padding(4, 5, 4, 5);
            quantityRange.MaximumRange = 500;
            quantityRange.MaximumSize = new Size(345, 0);
            quantityRange.Name = "quantityRange";
            quantityRange.RangeMax = 500;
            quantityRange.RangeMin = 0;
            quantityRange.Size = new Size(345, 41);
            quantityRange.TabIndex = 81;
            quantityRange.RangeChanged += bunifuRange2_RangeChanged;
            quantityRange.Load += bunifuRange2_Load;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(501, 141);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 73;
            label5.Text = "Quantity";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.BackColor = Color.Transparent;
            QuantityLabel.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            QuantityLabel.ForeColor = Color.OrangeRed;
            QuantityLabel.Location = new Point(511, 213);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(88, 21);
            QuantityLabel.TabIndex = 82;
            QuantityLabel.Text = "Quantity";
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
            BillBtChanged.TabIndex = 87;
            BillBtChanged.Text = "Bill";
            BillBtChanged.Textcolor = Color.White;
            BillBtChanged.UseVisualStyleBackColor = false;
            BillBtChanged.Click += BillBtChanged_Click;
            // 
            // ActiveChB
            // 
            ActiveChB.AutoSize = true;
            ActiveChB.BackColor = Color.Transparent;
            ActiveChB.Checked = true;
            ActiveChB.CheckState = CheckState.Checked;
            ActiveChB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ActiveChB.Location = new Point(248, 151);
            ActiveChB.Name = "ActiveChB";
            ActiveChB.Size = new Size(90, 24);
            ActiveChB.TabIndex = 88;
            ActiveChB.Text = "In Active";
            ActiveChB.UseVisualStyleBackColor = false;
            // 
            // ResetPriceBt
            // 
            ResetPriceBt.BackColor = Color.FromArgb(255, 128, 128);
            ResetPriceBt.BackGColor = Color.FromArgb(255, 128, 128);
            ResetPriceBt.BorderColor = Color.HotPink;
            ResetPriceBt.BorderRadius = 40;
            ResetPriceBt.BorderSize = 0;
            ResetPriceBt.ClickedBool = false;
            ResetPriceBt.clikedColor = Color.MediumAquamarine;
            ResetPriceBt.FlatAppearance.BorderSize = 0;
            ResetPriceBt.FlatStyle = FlatStyle.Flat;
            ResetPriceBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ResetPriceBt.ForeColor = Color.White;
            ResetPriceBt.HoverBool = false;
            ResetPriceBt.HoverColor = Color.MediumAquamarine;
            ResetPriceBt.ImageIcon = null;
            ResetPriceBt.Location = new Point(665, 90);
            ResetPriceBt.Name = "ResetPriceBt";
            ResetPriceBt.Size = new Size(101, 36);
            ResetPriceBt.TabIndex = 89;
            ResetPriceBt.Text = "Reset";
            ResetPriceBt.Textcolor = Color.White;
            ResetPriceBt.UseVisualStyleBackColor = false;
            ResetPriceBt.Click += ResetPriceBt_Click;
            // 
            // ResetQuanBt
            // 
            ResetQuanBt.BackColor = Color.FromArgb(255, 128, 128);
            ResetQuanBt.BackGColor = Color.FromArgb(255, 128, 128);
            ResetQuanBt.BorderColor = Color.HotPink;
            ResetQuanBt.BorderRadius = 40;
            ResetQuanBt.BorderSize = 0;
            ResetQuanBt.ClickedBool = false;
            ResetQuanBt.clikedColor = Color.MediumAquamarine;
            ResetQuanBt.FlatAppearance.BorderSize = 0;
            ResetQuanBt.FlatStyle = FlatStyle.Flat;
            ResetQuanBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ResetQuanBt.ForeColor = Color.White;
            ResetQuanBt.HoverBool = false;
            ResetQuanBt.HoverColor = Color.MediumAquamarine;
            ResetQuanBt.ImageIcon = null;
            ResetQuanBt.Location = new Point(665, 216);
            ResetQuanBt.Name = "ResetQuanBt";
            ResetQuanBt.Size = new Size(101, 36);
            ResetQuanBt.TabIndex = 90;
            ResetQuanBt.Text = "Reset";
            ResetQuanBt.Textcolor = Color.White;
            ResetQuanBt.UseVisualStyleBackColor = false;
            ResetQuanBt.Click += ResetQuanBt_Click;
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
            ExportBt.TabIndex = 91;
            ExportBt.Text = "Export";
            ExportBt.Textcolor = Color.White;
            ExportBt.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExportBt.UseVisualStyleBackColor = false;
            ExportBt.Click += ExportBt_Click;
            // 
            // ImportBt
            // 
            ImportBt.BackColor = Color.Crimson;
            ImportBt.BackGColor = Color.Crimson;
            ImportBt.BorderColor = Color.HotPink;
            ImportBt.BorderRadius = 40;
            ImportBt.BorderSize = 0;
            ImportBt.ClickedBool = false;
            ImportBt.clikedColor = Color.MediumAquamarine;
            ImportBt.FlatAppearance.BorderSize = 0;
            ImportBt.FlatStyle = FlatStyle.Flat;
            ImportBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ImportBt.ForeColor = Color.White;
            ImportBt.HoverBool = false;
            ImportBt.HoverColor = Color.MediumAquamarine;
            ImportBt.Image = (Image)resources.GetObject("ImportBt.Image");
            ImportBt.ImageIcon = (Image)resources.GetObject("ImportBt.ImageIcon");
            ImportBt.Location = new Point(457, 251);
            ImportBt.Name = "ImportBt";
            ImportBt.Size = new Size(101, 38);
            ImportBt.TabIndex = 92;
            ImportBt.Text = "Import";
            ImportBt.Textcolor = Color.White;
            ImportBt.TextImageRelation = TextImageRelation.ImageBeforeText;
            ImportBt.UseVisualStyleBackColor = false;
            ImportBt.Click += SelectFileButton_Click;
            // 
            // ProductViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1126, 732);
            Controls.Add(ImportBt);
            Controls.Add(ExportBt);
            Controls.Add(ResetQuanBt);
            Controls.Add(ResetPriceBt);
            Controls.Add(ActiveChB);
            Controls.Add(BillBtChanged);
            Controls.Add(AccountBtChanged);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(addButton);
            Controls.Add(QuantityLabel);
            Controls.Add(quantityRange);
            Controls.Add(Rangeco);
            Controls.Add(priceRange);
            Controls.Add(label5);
            Controls.Add(checkSearchDate);
            Controls.Add(label9);
            Controls.Add(label22);
            Controls.Add(label16);
            Controls.Add(label13);
            Controls.Add(label6);
            Controls.Add(dateTimePickerTop);
            Controls.Add(CategorySearch);
            Controls.Add(BrandSearch);
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
            Controls.Add(customButton1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductViewForm";
            Text = "ProductViewForm";
            Load += ProductViewForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageProductDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private customButton customButton1;
        private customButton BrandBtChanged;
        private customButton CategoryBtChanged;
        private customButton RoleBtChanged;
        private PictureBox imageProductDetail;
        private customButton UserBtChanged;
        private CustomTextBox nameSearchTextbox;
        private customButton searchButton;
        private customButton uploadImageBt;
        private DataGridViewTextBoxColumn Column2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        private CustomTextBox IdSearchTextbox;
        private ComboBox BrandSearch;
        private Label label8;
        private TextBox DescriptionDetail;
        private CustomTextBox IdDetail;
        private ComboBox branchDetail;
        private Label label14;
        private CustomTextBox nameDetail;
        private CustomTextBox priceDetail;
        private CustomTextBox QuantityDetail;
        private Label label12;
        private Label label17;
        private Label label20;
        private Label label19;
        private CustomTextBox editedbyDetail;
        private CustomTextBox CreatedbyDetail;
        private DateTimePicker editedTimeDetail;
        private DateTimePicker createdTimeDetail;
        private Label label15;
        private Label label10;
        private Label label18;
        private ComboBox CategoryDetail;
        private customButton saveBt;
        private Label label11;
        private Label label21;
        private ComboBox CategorySearch;
        private DateTimePicker dateTimePickerBot;
        private DateTimePicker dateTimePickerTop;
        private Label label6;
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
        private Bunifu.Framework.UI.BunifuRange quantityRange;
        private Label label5;
        private Label QuantityLabel;
        private PictureBox pictureBox1;
        private Label idDetail;
        private customButton addButton;
        private DateTimePicker dateTimePicker3;
        private ComboBox brandDetail;
        private customButton EditButton;
        private customButton DeleteButton;
        private Label label4;
        private Label label24;
        private ComboBox ActiveDetail;
        private customButton AccountBtChanged;
        private customButton BillBtChanged;
        private PrintPreviewControl printPreviewControl1;
        private customButton AddBillBt;
        private CheckBox ActiveChB;
        private customButton ResetPriceBt;
        private customButton ResetQuanBt;
        private customButton ExportBt;
        private customButton ImportBt;
    }
}