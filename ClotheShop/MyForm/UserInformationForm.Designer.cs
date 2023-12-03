namespace ClotheShop.MyForm
{
    partial class UserInformationForm
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
            EmailDetail = new CustomControl.CustomTextBox();
            label4 = new Label();
            idDetail = new Label();
            CCCDDetail = new CustomControl.CustomTextBox();
            PhoneDetail = new CustomControl.CustomTextBox();
            label15 = new Label();
            label10 = new Label();
            label17 = new Label();
            AddressDetail = new CustomControl.CustomTextBox();
            label14 = new Label();
            nameDetail = new CustomControl.CustomTextBox();
            label8 = new Label();
            customButton1 = new CustomControl.customButton();
            customButton2 = new CustomControl.customButton();
            PasswordTxt = new CustomControl.CustomTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // EmailDetail
            // 
            EmailDetail.BackColor = Color.White;
            EmailDetail.BorderColor = Color.Gray;
            EmailDetail.BorderSize = 2;
            EmailDetail.EnableText = true;
            EmailDetail.FocusedColor = Color.HotPink;
            EmailDetail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EmailDetail.ForeColor = SystemColors.ActiveCaptionText;
            EmailDetail.IconImage = null;
            EmailDetail.Location = new Point(25, 276);
            EmailDetail.Margin = new Padding(0);
            EmailDetail.Name = "EmailDetail";
            EmailDetail.OnlyNumber = false;
            EmailDetail.Padding = new Padding(8, 7, 8, 7);
            EmailDetail.PasswordChar = false;
            EmailDetail.placeHolderText = "";
            EmailDetail.setIcon = false;
            EmailDetail.SetPassword = false;
            EmailDetail.Size = new Size(268, 39);
            EmailDetail.TabIndex = 113;
            EmailDetail.Texts = "";
            EmailDetail.Underlined1 = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(22, 9);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 112;
            label4.Text = "Id:";
            // 
            // idDetail
            // 
            idDetail.AutoSize = true;
            idDetail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            idDetail.ForeColor = SystemColors.ActiveCaptionText;
            idDetail.Location = new Point(44, 9);
            idDetail.Name = "idDetail";
            idDetail.Size = new Size(41, 20);
            idDetail.TabIndex = 111;
            idDetail.Text = "dasd";
            // 
            // CCCDDetail
            // 
            CCCDDetail.BackColor = Color.White;
            CCCDDetail.BorderColor = Color.Gray;
            CCCDDetail.BorderSize = 2;
            CCCDDetail.EnableText = true;
            CCCDDetail.FocusedColor = Color.HotPink;
            CCCDDetail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CCCDDetail.ForeColor = SystemColors.ActiveCaptionText;
            CCCDDetail.IconImage = null;
            CCCDDetail.Location = new Point(21, 345);
            CCCDDetail.Margin = new Padding(0);
            CCCDDetail.Name = "CCCDDetail";
            CCCDDetail.OnlyNumber = true;
            CCCDDetail.Padding = new Padding(8, 7, 8, 7);
            CCCDDetail.PasswordChar = false;
            CCCDDetail.placeHolderText = "";
            CCCDDetail.setIcon = false;
            CCCDDetail.SetPassword = false;
            CCCDDetail.Size = new Size(272, 39);
            CCCDDetail.TabIndex = 109;
            CCCDDetail.Texts = "";
            CCCDDetail.Underlined1 = false;
            // 
            // PhoneDetail
            // 
            PhoneDetail.BackColor = Color.White;
            PhoneDetail.BorderColor = Color.Gray;
            PhoneDetail.BorderSize = 2;
            PhoneDetail.EnableText = true;
            PhoneDetail.FocusedColor = Color.HotPink;
            PhoneDetail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneDetail.ForeColor = SystemColors.ActiveCaptionText;
            PhoneDetail.IconImage = null;
            PhoneDetail.Location = new Point(25, 205);
            PhoneDetail.Margin = new Padding(0);
            PhoneDetail.Name = "PhoneDetail";
            PhoneDetail.OnlyNumber = true;
            PhoneDetail.Padding = new Padding(8, 7, 8, 7);
            PhoneDetail.PasswordChar = false;
            PhoneDetail.placeHolderText = "";
            PhoneDetail.setIcon = false;
            PhoneDetail.SetPassword = false;
            PhoneDetail.Size = new Size(268, 39);
            PhoneDetail.TabIndex = 108;
            PhoneDetail.Texts = "";
            PhoneDetail.Underlined1 = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(22, 326);
            label15.Name = "label15";
            label15.Size = new Size(58, 19);
            label15.TabIndex = 107;
            label15.Text = "CCCD";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(22, 186);
            label10.Name = "label10";
            label10.Size = new Size(58, 19);
            label10.TabIndex = 106;
            label10.Text = "Phone";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(25, 257);
            label17.Name = "label17";
            label17.Size = new Size(53, 19);
            label17.TabIndex = 105;
            label17.Text = "Email";
            // 
            // AddressDetail
            // 
            AddressDetail.BackColor = Color.White;
            AddressDetail.BorderColor = Color.Gray;
            AddressDetail.BorderSize = 2;
            AddressDetail.EnableText = true;
            AddressDetail.FocusedColor = Color.HotPink;
            AddressDetail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddressDetail.ForeColor = SystemColors.ActiveCaptionText;
            AddressDetail.IconImage = null;
            AddressDetail.Location = new Point(24, 134);
            AddressDetail.Margin = new Padding(0);
            AddressDetail.Name = "AddressDetail";
            AddressDetail.OnlyNumber = false;
            AddressDetail.Padding = new Padding(8, 7, 8, 7);
            AddressDetail.PasswordChar = false;
            AddressDetail.placeHolderText = "";
            AddressDetail.setIcon = false;
            AddressDetail.SetPassword = false;
            AddressDetail.Size = new Size(271, 37);
            AddressDetail.TabIndex = 104;
            AddressDetail.Texts = "";
            AddressDetail.Underlined1 = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(22, 115);
            label14.Name = "label14";
            label14.Size = new Size(73, 19);
            label14.TabIndex = 103;
            label14.Text = "Address";
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
            nameDetail.Location = new Point(22, 62);
            nameDetail.Margin = new Padding(0);
            nameDetail.Name = "nameDetail";
            nameDetail.OnlyNumber = false;
            nameDetail.Padding = new Padding(8, 7, 8, 7);
            nameDetail.PasswordChar = false;
            nameDetail.placeHolderText = "";
            nameDetail.setIcon = false;
            nameDetail.SetPassword = false;
            nameDetail.Size = new Size(271, 37);
            nameDetail.TabIndex = 102;
            nameDetail.Texts = "";
            nameDetail.Underlined1 = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(24, 43);
            label8.Name = "label8";
            label8.Size = new Size(54, 19);
            label8.TabIndex = 100;
            label8.Text = "Name";
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
            customButton1.ForeColor = Color.White;
            customButton1.HoverBool = false;
            customButton1.HoverColor = Color.MediumAquamarine;
            customButton1.ImageIcon = null;
            customButton1.Location = new Point(25, 398);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(188, 50);
            customButton1.TabIndex = 114;
            customButton1.Text = "Save";
            customButton1.Textcolor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton2_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.MediumSlateBlue;
            customButton2.BackGColor = Color.MediumSlateBlue;
            customButton2.BorderColor = Color.HotPink;
            customButton2.BorderRadius = 40;
            customButton2.BorderSize = 0;
            customButton2.ClickedBool = false;
            customButton2.clikedColor = Color.MediumAquamarine;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.ForeColor = Color.White;
            customButton2.HoverBool = false;
            customButton2.HoverColor = Color.MediumAquamarine;
            customButton2.ImageIcon = null;
            customButton2.Location = new Point(332, 407);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(188, 50);
            customButton2.TabIndex = 115;
            customButton2.Text = "Edit Password";
            customButton2.Textcolor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton1_Click;
            // 
            // PasswordTxt
            // 
            PasswordTxt.BackColor = Color.White;
            PasswordTxt.BorderColor = Color.Gray;
            PasswordTxt.BorderSize = 2;
            PasswordTxt.EnableText = true;
            PasswordTxt.FocusedColor = Color.HotPink;
            PasswordTxt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTxt.ForeColor = SystemColors.ActiveCaptionText;
            PasswordTxt.IconImage = null;
            PasswordTxt.Location = new Point(304, 345);
            PasswordTxt.Margin = new Padding(0);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.OnlyNumber = false;
            PasswordTxt.Padding = new Padding(8, 7, 8, 7);
            PasswordTxt.PasswordChar = true;
            PasswordTxt.placeHolderText = "";
            PasswordTxt.setIcon = false;
            PasswordTxt.SetPassword = true;
            PasswordTxt.Size = new Size(261, 39);
            PasswordTxt.TabIndex = 117;
            PasswordTxt.Texts = "";
            PasswordTxt.Underlined1 = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(305, 326);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 116;
            label1.Text = "Password";
            // 
            // UserInformationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(574, 460);
            Controls.Add(PasswordTxt);
            Controls.Add(label1);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Controls.Add(EmailDetail);
            Controls.Add(label4);
            Controls.Add(idDetail);
            Controls.Add(CCCDDetail);
            Controls.Add(PhoneDetail);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(label17);
            Controls.Add(AddressDetail);
            Controls.Add(label14);
            Controls.Add(nameDetail);
            Controls.Add(label8);
            Name = "UserInformationForm";
            Text = "UserInformationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControl.CustomTextBox EmailDetail;
        private Label label4;
        private Label idDetail;
        private CustomControl.CustomTextBox CCCDDetail;
        private CustomControl.CustomTextBox PhoneDetail;
        private Label label15;
        private Label label10;
        private Label label17;
        private CustomControl.CustomTextBox AddressDetail;
        private Label label14;
        private CustomControl.CustomTextBox nameDetail;
        private Label label8;
        private CustomControl.customButton customButton1;
        private CustomControl.customButton customButton2;
        private CustomControl.CustomTextBox PasswordTxt;
        private Label label1;
    }
}