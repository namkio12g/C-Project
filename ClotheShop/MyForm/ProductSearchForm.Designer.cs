namespace ClotheShop.CustomControl
{
    partial class ProductSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSearchForm));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label25 = new Label();
            customTextBox1 = new CustomTextBox();
            label24 = new Label();
            ActiveDetail = new ComboBox();
            label4 = new Label();
            idDetail = new Label();
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
            AddBillBt = new customButton();
            label8 = new Label();
            uploadImageBt = new customButton();
            imageProductDetail = new PictureBox();
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
            CloseBt = new customButton();
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
            dataGridView1.Location = new Point(22, 300);
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
            dataGridView1.Size = new Size(799, 432);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label25);
            panel1.Controls.Add(customTextBox1);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(ActiveDetail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(idDetail);
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
            panel1.Controls.Add(AddBillBt);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(uploadImageBt);
            panel1.Controls.Add(imageProductDetail);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(837, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 732);
            panel1.TabIndex = 1;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.RosyBrown;
            label25.Location = new Point(179, 667);
            label25.Name = "label25";
            label25.Size = new Size(77, 19);
            label25.TabIndex = 66;
            label25.Text = "Quantity";
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.White;
            customTextBox1.BorderColor = Color.Gray;
            customTextBox1.BorderSize = 2;
            customTextBox1.EnableText = true;
            customTextBox1.FocusedColor = Color.HotPink;
            customTextBox1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            customTextBox1.ForeColor = SystemColors.ActiveCaptionText;
            customTextBox1.IconImage = null;
            customTextBox1.Location = new Point(173, 686);
            customTextBox1.Margin = new Padding(0);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.OnlyNumber = true;
            customTextBox1.Padding = new Padding(8, 7, 8, 7);
            customTextBox1.PasswordChar = false;
            customTextBox1.placeHolderText = "";
            customTextBox1.setIcon = false;
            customTextBox1.SetPassword = false;
            customTextBox1.Size = new Size(92, 37);
            customTextBox1.TabIndex = 67;
            customTextBox1.Texts = "";
            customTextBox1.Underlined1 = false;
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
            CategoryDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryDetail.FormattingEnabled = true;
            CategoryDetail.Location = new Point(122, 377);
            CategoryDetail.Name = "CategoryDetail";
            CategoryDetail.Size = new Size(100, 29);
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
            DescriptionDetail.Size = new Size(268, 123);
            DescriptionDetail.TabIndex = 36;
            // 
            // brandDetail
            // 
            brandDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            brandDetail.FormattingEnabled = true;
            brandDetail.Location = new Point(6, 377);
            brandDetail.Name = "brandDetail";
            brandDetail.Size = new Size(110, 29);
            brandDetail.TabIndex = 33;
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
            AddBillBt.Location = new Point(9, 675);
            AddBillBt.Name = "AddBillBt";
            AddBillBt.Size = new Size(146, 48);
            AddBillBt.TabIndex = 65;
            AddBillBt.Text = "Add to Bill";
            AddBillBt.Textcolor = Color.White;
            AddBillBt.UseVisualStyleBackColor = false;
            AddBillBt.Click += AddBillBt_Click;
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
            checkSearchDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkSearchDate.Location = new Point(20, 151);
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
            Rangeco.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Rangeco.ForeColor = Color.CadetBlue;
            Rangeco.Location = new Point(600, 90);
            Rangeco.Name = "Rangeco";
            Rangeco.Size = new Size(57, 21);
            Rangeco.TabIndex = 80;
            Rangeco.Text = "Price";
            // 
            // quantityRange
            // 
            quantityRange.BackColor = Color.Transparent;
            quantityRange.BackgroudColor = Color.MidnightBlue;
            quantityRange.BorderRadius = 10;
            quantityRange.ForeColor = SystemColors.ControlDarkDark;
            quantityRange.IndicatorColor = Color.DarkCyan;
            quantityRange.Location = new Point(476, 151);
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
            label5.Location = new Point(511, 116);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 73;
            label5.Text = "Quantity";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            QuantityLabel.ForeColor = Color.CadetBlue;
            QuantityLabel.Location = new Point(600, 197);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(88, 21);
            QuantityLabel.TabIndex = 82;
            QuantityLabel.Text = "Quantity";
            // 
            // CloseBt
            // 
            CloseBt.BackColor = Color.Red;
            CloseBt.BackGColor = Color.Red;
            CloseBt.BorderColor = Color.Chartreuse;
            CloseBt.BorderRadius = 40;
            CloseBt.BorderSize = 2;
            CloseBt.ClickedBool = false;
            CloseBt.clikedColor = Color.MediumAquamarine;
            CloseBt.FlatAppearance.BorderSize = 0;
            CloseBt.FlatStyle = FlatStyle.Flat;
            CloseBt.ForeColor = Color.White;
            CloseBt.HoverBool = false;
            CloseBt.HoverColor = Color.MediumAquamarine;
            CloseBt.ImageIcon = null;
            CloseBt.Location = new Point(779, 0);
            CloseBt.Name = "CloseBt";
            CloseBt.Size = new Size(42, 36);
            CloseBt.TabIndex = 83;
            CloseBt.Text = "X";
            CloseBt.Textcolor = Color.White;
            CloseBt.UseVisualStyleBackColor = false;
            CloseBt.Click += CloseBt_Click;
            // 
            // ProductSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1126, 732);
            Controls.Add(CloseBt);
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
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ProductSearchForm";
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
        private PictureBox imageProductDetail;
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
        private DateTimePicker dateTimePicker3;
        private ComboBox brandDetail;
        private Label label4;
        private Label label24;
        private ComboBox ActiveDetail;
        private PrintPreviewControl printPreviewControl1;
        private customButton AddBillBt;
        private customButton CloseBt;
        private Label label25;
        private CustomTextBox customTextBox1;
    }
}