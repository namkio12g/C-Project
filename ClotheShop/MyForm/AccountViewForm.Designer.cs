namespace ClotheShop.CustomControl
{
    partial class AccountViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountViewForm));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            PasswordCfTxt = new CustomTextBox();
            PasswordCfLb = new Label();
            PasswordTxt = new CustomTextBox();
            PasswordLb = new Label();
            UserAccountDetail = new ComboBox();
            Last_login = new DateTimePicker();
            label5 = new Label();
            label24 = new Label();
            ActiveDetail = new ComboBox();
            label4 = new Label();
            idDetail = new Label();
            saveBt = new customButton();
            label20 = new Label();
            label19 = new Label();
            editedTimeDetail = new DateTimePicker();
            createdTimeDetail = new DateTimePicker();
            label10 = new Label();
            userNameDetail = new CustomTextBox();
            label8 = new Label();
            uploadImageBt = new customButton();
            imageProductDetail = new PictureBox();
            customButton1 = new customButton();
            BrandChangedBt = new customButton();
            CategoryBtChanged = new customButton();
            RoleChangedBt = new customButton();
            UserBtChanged = new customButton();
            UserAccountSearchTextbox = new CustomTextBox();
            searchButton = new customButton();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            IdSearchTextbox = new CustomTextBox();
            dateTimePickerBot = new DateTimePicker();
            dateTimePickerTop = new DateTimePicker();
            label13 = new Label();
            label16 = new Label();
            checkSearchDate = new CheckBox();
            addButton = new customButton();
            EditButton = new customButton();
            ShowPassBt = new customButton();
            AccountBtChanged = new customButton();
            UserNameSearchTxt = new CustomTextBox();
            label6 = new Label();
            ActiveChB = new CheckBox();
            BillBtChanged = new customButton();
            ExportBt = new customButton();
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
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(PasswordCfTxt);
            panel1.Controls.Add(PasswordCfLb);
            panel1.Controls.Add(PasswordTxt);
            panel1.Controls.Add(PasswordLb);
            panel1.Controls.Add(UserAccountDetail);
            panel1.Controls.Add(Last_login);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(ActiveDetail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(idDetail);
            panel1.Controls.Add(saveBt);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(editedTimeDetail);
            panel1.Controls.Add(createdTimeDetail);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(userNameDetail);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(uploadImageBt);
            panel1.Controls.Add(imageProductDetail);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(837, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 732);
            panel1.TabIndex = 1;
            // 
            // PasswordCfTxt
            // 
            PasswordCfTxt.BackColor = Color.White;
            PasswordCfTxt.BorderColor = Color.Gray;
            PasswordCfTxt.BorderSize = 2;
            PasswordCfTxt.EnableText = true;
            PasswordCfTxt.FocusedColor = Color.HotPink;
            PasswordCfTxt.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordCfTxt.ForeColor = SystemColors.ActiveCaptionText;
            PasswordCfTxt.IconImage = null;
            PasswordCfTxt.Location = new Point(9, 544);
            PasswordCfTxt.Margin = new Padding(0);
            PasswordCfTxt.Name = "PasswordCfTxt";
            PasswordCfTxt.OnlyNumber = false;
            PasswordCfTxt.Padding = new Padding(8, 7, 8, 7);
            PasswordCfTxt.PasswordChar = true;
            PasswordCfTxt.placeHolderText = "";
            PasswordCfTxt.setIcon = false;
            PasswordCfTxt.SetPassword = true;
            PasswordCfTxt.Size = new Size(271, 37);
            PasswordCfTxt.TabIndex = 70;
            PasswordCfTxt.Texts = "";
            PasswordCfTxt.Underlined1 = false;
            // 
            // PasswordCfLb
            // 
            PasswordCfLb.AutoSize = true;
            PasswordCfLb.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordCfLb.ForeColor = Color.White;
            PasswordCfLb.Location = new Point(6, 525);
            PasswordCfLb.Name = "PasswordCfLb";
            PasswordCfLb.Size = new Size(103, 19);
            PasswordCfLb.TabIndex = 69;
            PasswordCfLb.Text = "PasswordCf";
            // 
            // PasswordTxt
            // 
            PasswordTxt.BackColor = Color.White;
            PasswordTxt.BorderColor = Color.Gray;
            PasswordTxt.BorderSize = 2;
            PasswordTxt.EnableText = true;
            PasswordTxt.FocusedColor = Color.HotPink;
            PasswordTxt.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTxt.ForeColor = SystemColors.ActiveCaptionText;
            PasswordTxt.IconImage = null;
            PasswordTxt.Location = new Point(9, 488);
            PasswordTxt.Margin = new Padding(0);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.OnlyNumber = false;
            PasswordTxt.Padding = new Padding(8, 7, 8, 7);
            PasswordTxt.PasswordChar = true;
            PasswordTxt.placeHolderText = "";
            PasswordTxt.setIcon = false;
            PasswordTxt.SetPassword = true;
            PasswordTxt.Size = new Size(271, 37);
            PasswordTxt.TabIndex = 68;
            PasswordTxt.Texts = "";
            PasswordTxt.Underlined1 = false;
            // 
            // PasswordLb
            // 
            PasswordLb.AutoSize = true;
            PasswordLb.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLb.ForeColor = Color.White;
            PasswordLb.Location = new Point(9, 469);
            PasswordLb.Name = "PasswordLb";
            PasswordLb.Size = new Size(85, 19);
            PasswordLb.TabIndex = 67;
            PasswordLb.Text = "Password";
            // 
            // UserAccountDetail
            // 
            UserAccountDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            UserAccountDetail.FormattingEnabled = true;
            UserAccountDetail.Items.AddRange(new object[] { "1", "0" });
            UserAccountDetail.Location = new Point(6, 327);
            UserAccountDetail.Name = "UserAccountDetail";
            UserAccountDetail.Size = new Size(271, 29);
            UserAccountDetail.TabIndex = 66;
            // 
            // Last_login
            // 
            Last_login.Enabled = false;
            Last_login.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Last_login.Format = DateTimePickerFormat.Short;
            Last_login.Location = new Point(9, 434);
            Last_login.Name = "Last_login";
            Last_login.Size = new Size(129, 27);
            Last_login.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(9, 415);
            label5.Name = "label5";
            label5.Size = new Size(85, 19);
            label5.TabIndex = 64;
            label5.Text = "Last login";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.White;
            label24.Location = new Point(220, 415);
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
            ActiveDetail.Location = new Point(228, 434);
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
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(179, 363);
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
            label19.Location = new Point(6, 363);
            label19.Name = "label19";
            label19.Size = new Size(110, 19);
            label19.TabIndex = 56;
            label19.Text = "Created time";
            // 
            // editedTimeDetail
            // 
            editedTimeDetail.Enabled = false;
            editedTimeDetail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editedTimeDetail.Format = DateTimePickerFormat.Short;
            editedTimeDetail.Location = new Point(144, 385);
            editedTimeDetail.Name = "editedTimeDetail";
            editedTimeDetail.Size = new Size(133, 27);
            editedTimeDetail.TabIndex = 53;
            // 
            // createdTimeDetail
            // 
            createdTimeDetail.Enabled = false;
            createdTimeDetail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createdTimeDetail.Format = DateTimePickerFormat.Short;
            createdTimeDetail.Location = new Point(9, 385);
            createdTimeDetail.Name = "createdTimeDetail";
            createdTimeDetail.Size = new Size(129, 27);
            createdTimeDetail.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(6, 305);
            label10.Name = "label10";
            label10.Size = new Size(109, 19);
            label10.TabIndex = 50;
            label10.Text = "UserAccount";
            label10.Click += label10_Click;
            // 
            // userNameDetail
            // 
            userNameDetail.BackColor = Color.White;
            userNameDetail.BorderColor = Color.Gray;
            userNameDetail.BorderSize = 2;
            userNameDetail.EnableText = true;
            userNameDetail.FocusedColor = Color.HotPink;
            userNameDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            userNameDetail.ForeColor = SystemColors.ControlText;
            userNameDetail.IconImage = null;
            userNameDetail.Location = new Point(9, 259);
            userNameDetail.Margin = new Padding(0);
            userNameDetail.Name = "userNameDetail";
            userNameDetail.OnlyNumber = false;
            userNameDetail.Padding = new Padding(8, 7, 8, 7);
            userNameDetail.PasswordChar = false;
            userNameDetail.placeHolderText = "";
            userNameDetail.setIcon = false;
            userNameDetail.SetPassword = false;
            userNameDetail.Size = new Size(268, 37);
            userNameDetail.TabIndex = 38;
            userNameDetail.Texts = "";
            userNameDetail.Underlined1 = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(9, 240);
            label8.Name = "label8";
            label8.Size = new Size(89, 19);
            label8.TabIndex = 28;
            label8.Text = "Username";
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
            uploadImageBt.Visible = false;
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
            // customButton1
            // 
            customButton1.BackColor = Color.MediumSlateBlue;
            customButton1.BackGColor = Color.MediumSlateBlue;
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
            customButton1.Click += ProductViewFormBtChanged_Click;
            // 
            // BrandChangedBt
            // 
            BrandChangedBt.BackColor = Color.MediumSlateBlue;
            BrandChangedBt.BackGColor = Color.MediumSlateBlue;
            BrandChangedBt.BorderColor = Color.HotPink;
            BrandChangedBt.BorderRadius = 40;
            BrandChangedBt.BorderSize = 0;
            BrandChangedBt.ClickedBool = false;
            BrandChangedBt.clikedColor = Color.MediumAquamarine;
            BrandChangedBt.FlatAppearance.BorderSize = 0;
            BrandChangedBt.FlatStyle = FlatStyle.Flat;
            BrandChangedBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BrandChangedBt.ForeColor = Color.White;
            BrandChangedBt.HoverBool = false;
            BrandChangedBt.HoverColor = Color.MediumAquamarine;
            BrandChangedBt.ImageIcon = null;
            BrandChangedBt.Location = new Point(340, 322);
            BrandChangedBt.Name = "BrandChangedBt";
            BrandChangedBt.Size = new Size(93, 46);
            BrandChangedBt.TabIndex = 3;
            BrandChangedBt.Text = "Brand";
            BrandChangedBt.Textcolor = Color.White;
            BrandChangedBt.UseVisualStyleBackColor = false;
            BrandChangedBt.Click += BrandBtChanged_Click;
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
            // UserAccountSearchTextbox
            // 
            UserAccountSearchTextbox.BackColor = Color.White;
            UserAccountSearchTextbox.BorderColor = Color.MediumAquamarine;
            UserAccountSearchTextbox.BorderSize = 2;
            UserAccountSearchTextbox.EnableText = true;
            UserAccountSearchTextbox.FocusedColor = Color.HotPink;
            UserAccountSearchTextbox.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            UserAccountSearchTextbox.ForeColor = SystemColors.ActiveCaptionText;
            UserAccountSearchTextbox.IconImage = null;
            UserAccountSearchTextbox.Location = new Point(248, 44);
            UserAccountSearchTextbox.Margin = new Padding(0);
            UserAccountSearchTextbox.Name = "UserAccountSearchTextbox";
            UserAccountSearchTextbox.OnlyNumber = false;
            UserAccountSearchTextbox.Padding = new Padding(8, 7, 8, 7);
            UserAccountSearchTextbox.PasswordChar = false;
            UserAccountSearchTextbox.placeHolderText = "";
            UserAccountSearchTextbox.setIcon = false;
            UserAccountSearchTextbox.SetPassword = false;
            UserAccountSearchTextbox.Size = new Size(205, 37);
            UserAccountSearchTextbox.TabIndex = 8;
            UserAccountSearchTextbox.Texts = "";
            UserAccountSearchTextbox.Underlined1 = false;
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
            label3.Location = new Point(329, 23);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 25;
            label3.Text = "UserAccount";
            label3.Click += label3_Click;
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
            IdSearchTextbox.Size = new Size(206, 37);
            IdSearchTextbox.TabIndex = 21;
            IdSearchTextbox.Texts = "";
            IdSearchTextbox.Underlined1 = false;
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
            checkSearchDate.Click += CheckSearchDate_Click;
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
            // ShowPassBt
            // 
            ShowPassBt.BackColor = Color.FromArgb(64, 0, 0);
            ShowPassBt.BackGColor = Color.FromArgb(64, 0, 0);
            ShowPassBt.BorderColor = Color.HotPink;
            ShowPassBt.BorderRadius = 40;
            ShowPassBt.BorderSize = 0;
            ShowPassBt.ClickedBool = false;
            ShowPassBt.clikedColor = Color.MediumAquamarine;
            ShowPassBt.FlatAppearance.BorderSize = 0;
            ShowPassBt.FlatStyle = FlatStyle.Flat;
            ShowPassBt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ShowPassBt.ForeColor = Color.White;
            ShowPassBt.HoverBool = false;
            ShowPassBt.HoverColor = Color.MediumAquamarine;
            ShowPassBt.ImageIcon = null;
            ShowPassBt.Location = new Point(340, 251);
            ShowPassBt.Name = "ShowPassBt";
            ShowPassBt.Size = new Size(128, 38);
            ShowPassBt.TabIndex = 85;
            ShowPassBt.Text = "Show Pass";
            ShowPassBt.Textcolor = Color.White;
            ShowPassBt.TextImageRelation = TextImageRelation.ImageBeforeText;
            ShowPassBt.UseVisualStyleBackColor = false;
            ShowPassBt.Click += ShowPassBt_Click;
            // 
            // AccountBtChanged
            // 
            AccountBtChanged.BackColor = Color.DarkTurquoise;
            AccountBtChanged.BackGColor = Color.DarkTurquoise;
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
            // 
            // UserNameSearchTxt
            // 
            UserNameSearchTxt.BackColor = Color.White;
            UserNameSearchTxt.BorderColor = Color.MediumAquamarine;
            UserNameSearchTxt.BorderSize = 2;
            UserNameSearchTxt.EnableText = true;
            UserNameSearchTxt.FocusedColor = Color.HotPink;
            UserNameSearchTxt.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameSearchTxt.ForeColor = SystemColors.ActiveCaptionText;
            UserNameSearchTxt.IconImage = null;
            UserNameSearchTxt.Location = new Point(23, 111);
            UserNameSearchTxt.Margin = new Padding(0);
            UserNameSearchTxt.Name = "UserNameSearchTxt";
            UserNameSearchTxt.OnlyNumber = false;
            UserNameSearchTxt.Padding = new Padding(8, 7, 8, 7);
            UserNameSearchTxt.PasswordChar = false;
            UserNameSearchTxt.placeHolderText = "";
            UserNameSearchTxt.setIcon = false;
            UserNameSearchTxt.SetPassword = false;
            UserNameSearchTxt.Size = new Size(205, 37);
            UserNameSearchTxt.TabIndex = 87;
            UserNameSearchTxt.Texts = "";
            UserNameSearchTxt.Underlined1 = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(20, 90);
            label6.Name = "label6";
            label6.Size = new Size(102, 21);
            label6.TabIndex = 88;
            label6.Text = "UserName";
            // 
            // ActiveChB
            // 
            ActiveChB.AutoSize = true;
            ActiveChB.Checked = true;
            ActiveChB.CheckState = CheckState.Checked;
            ActiveChB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ActiveChB.Location = new Point(248, 151);
            ActiveChB.Name = "ActiveChB";
            ActiveChB.Size = new Size(90, 24);
            ActiveChB.TabIndex = 89;
            ActiveChB.Text = "In Active";
            ActiveChB.UseVisualStyleBackColor = true;
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
            BillBtChanged.TabIndex = 90;
            BillBtChanged.Text = "Bill";
            BillBtChanged.Textcolor = Color.White;
            BillBtChanged.UseVisualStyleBackColor = false;
            BillBtChanged.Click += BillBtChanged_Click_1;
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
            // AccountViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(1126, 732);
            Controls.Add(ExportBt);
            Controls.Add(BillBtChanged);
            Controls.Add(ActiveChB);
            Controls.Add(label6);
            Controls.Add(UserNameSearchTxt);
            Controls.Add(AccountBtChanged);
            Controls.Add(ShowPassBt);
            Controls.Add(EditButton);
            Controls.Add(addButton);
            Controls.Add(checkSearchDate);
            Controls.Add(label16);
            Controls.Add(label13);
            Controls.Add(dateTimePickerTop);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(IdSearchTextbox);
            Controls.Add(dateTimePickerBot);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchButton);
            Controls.Add(UserAccountSearchTextbox);
            Controls.Add(UserBtChanged);
            Controls.Add(RoleChangedBt);
            Controls.Add(CategoryBtChanged);
            Controls.Add(BrandChangedBt);
            Controls.Add(customButton1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountViewForm";
            Text = "ProductViewForm";
            Load += AccountViewForm_Load;
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
        private customButton BrandChangedBt;
        private customButton CategoryBtChanged;
        private customButton RoleChangedBt;
        private PictureBox imageProductDetail;
        private customButton UserBtChanged;
        private CustomTextBox UserAccountSearchTextbox;
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
        private Label label8;
        private CustomTextBox IdDetail;
        private ComboBox branchDetail;
        private CustomTextBox userNameDetail;
        private Label label20;
        private DateTimePicker editedTimeDetail;
        private Label label10;
        private customButton saveBt;
        private Label label11;
        private DateTimePicker dateTimePickerBot;
        private DateTimePicker dateTimePickerTop;
        private Label label13;
        private Label label16;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label label23;
        private CheckBox checkSearchDate;
        private Label PriceBottom;
        private Label PriceTop;
        private PictureBox pictureBox1;
        private Label idDetail;
        private customButton addButton;
        private DateTimePicker dateTimePicker3;
        private customButton EditButton;
        private customButton ShowPassBt;
        private Label label4;
        private customButton AccountBtChanged;
        private Label label24;
        private ComboBox ActiveDetail;
        private DateTimePicker Last_login;
        private Label label5;
        private Label label19;
        private DateTimePicker createdTimeDetail;
        private CustomTextBox UserNameSearchTxt;
        private Label label6;
        private ComboBox UserAccountDetail;
        private CustomTextBox PasswordCfTxt;
        private Label PasswordCfLb;
        private CustomTextBox PasswordTxt;
        private Label PasswordLb;
        private CheckBox ActiveChB;
        private customButton BillBtChanged;
        private customButton ExportBt;
    }
}