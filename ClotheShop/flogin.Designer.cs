namespace ClotheShop
{
    partial class flogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flogin));
            UserTxt = new CustomControl.CustomTextBox();
            PassTxt = new CustomControl.CustomTextBox();
            customButton1 = new CustomControl.customButton();
            loginPanel = new Panel();
            pictureBox1 = new PictureBox();
            toRegisterBt = new CustomControl.customButton();
            registerPanel = new Panel();
            ReUserTxt = new CustomControl.CustomTextBox();
            ReNameTxt = new CustomControl.CustomTextBox();
            RegisPw = new CustomControl.CustomTextBox();
            pictureBox2 = new PictureBox();
            customButton3 = new CustomControl.customButton();
            RePhonetxt = new CustomControl.CustomTextBox();
            BacktologinBt = new CustomControl.customButton();
            RegisCfPw = new CustomControl.CustomTextBox();
            ReEmailTxt = new CustomControl.CustomTextBox();
            CloseBt = new Button();
            panel1 = new Panel();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UserTxt
            // 
            UserTxt.BackColor = Color.White;
            UserTxt.BorderColor = Color.White;
            UserTxt.BorderSize = 2;
            UserTxt.EnableText = true;
            UserTxt.FocusedColor = Color.HotPink;
            UserTxt.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserTxt.ForeColor = Color.Black;
            UserTxt.IconImage = (Image)resources.GetObject("UserTxt.IconImage");
            UserTxt.Location = new Point(54, 122);
            UserTxt.Margin = new Padding(0);
            UserTxt.Name = "UserTxt";
            UserTxt.OnlyNumber = false;
            UserTxt.Padding = new Padding(8, 7, 8, 7);
            UserTxt.PasswordChar = false;
            UserTxt.placeHolderText = "Username";
            UserTxt.setIcon = true;
            UserTxt.SetPassword = false;
            UserTxt.Size = new Size(264, 39);
            UserTxt.TabIndex = 0;
            UserTxt.Texts = "";
            UserTxt.Underlined1 = false;
            // 
            // PassTxt
            // 
            PassTxt.BackColor = Color.White;
            PassTxt.BorderColor = Color.White;
            PassTxt.BorderSize = 2;
            PassTxt.EnableText = true;
            PassTxt.FocusedColor = Color.HotPink;
            PassTxt.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassTxt.ForeColor = Color.Black;
            PassTxt.IconImage = (Image)resources.GetObject("PassTxt.IconImage");
            PassTxt.Location = new Point(54, 202);
            PassTxt.Margin = new Padding(0);
            PassTxt.Name = "PassTxt";
            PassTxt.OnlyNumber = false;
            PassTxt.Padding = new Padding(8, 7, 8, 7);
            PassTxt.PasswordChar = true;
            PassTxt.placeHolderText = "Password";
            PassTxt.setIcon = true;
            PassTxt.SetPassword = true;
            PassTxt.Size = new Size(264, 39);
            PassTxt.TabIndex = 1;
            PassTxt.Texts = "";
            PassTxt.Underlined1 = false;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Transparent;
            customButton1.BackGColor = Color.Transparent;
            customButton1.BorderColor = Color.White;
            customButton1.BorderRadius = 30;
            customButton1.BorderSize = 2;
            customButton1.ClickedBool = false;
            customButton1.clikedColor = Color.MediumAquamarine;
            customButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = SystemColors.Window;
            customButton1.HoverBool = false;
            customButton1.HoverColor = Color.FromArgb(0, 192, 192);
            customButton1.ImageIcon = null;
            customButton1.Location = new Point(54, 280);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(264, 43);
            customButton1.TabIndex = 3;
            customButton1.Text = "Login";
            customButton1.Textcolor = SystemColors.Window;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.Transparent;
            loginPanel.Controls.Add(pictureBox1);
            loginPanel.Controls.Add(UserTxt);
            loginPanel.Controls.Add(toRegisterBt);
            loginPanel.Controls.Add(customButton1);
            loginPanel.Controls.Add(PassTxt);
            loginPanel.Location = new Point(808, 125);
            loginPanel.Margin = new Padding(0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(370, 486);
            loginPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // toRegisterBt
            // 
            toRegisterBt.BackColor = Color.Transparent;
            toRegisterBt.BackGColor = Color.Transparent;
            toRegisterBt.BorderColor = Color.White;
            toRegisterBt.BorderRadius = 30;
            toRegisterBt.BorderSize = 2;
            toRegisterBt.ClickedBool = false;
            toRegisterBt.clikedColor = Color.MediumAquamarine;
            toRegisterBt.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            toRegisterBt.FlatStyle = FlatStyle.Flat;
            toRegisterBt.Font = new Font("Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point);
            toRegisterBt.ForeColor = SystemColors.Window;
            toRegisterBt.HoverBool = false;
            toRegisterBt.HoverColor = Color.FromArgb(0, 192, 192);
            toRegisterBt.ImageIcon = null;
            toRegisterBt.Location = new Point(97, 354);
            toRegisterBt.Name = "toRegisterBt";
            toRegisterBt.Size = new Size(170, 41);
            toRegisterBt.TabIndex = 4;
            toRegisterBt.Text = "Register";
            toRegisterBt.Textcolor = SystemColors.Window;
            toRegisterBt.UseVisualStyleBackColor = false;
            toRegisterBt.Click += toRegisterBt_Click;
            // 
            // registerPanel
            // 
            registerPanel.BackColor = Color.Transparent;
            registerPanel.Controls.Add(ReUserTxt);
            registerPanel.Controls.Add(ReNameTxt);
            registerPanel.Controls.Add(RegisPw);
            registerPanel.Controls.Add(pictureBox2);
            registerPanel.Controls.Add(customButton3);
            registerPanel.Controls.Add(RePhonetxt);
            registerPanel.Controls.Add(BacktologinBt);
            registerPanel.Controls.Add(RegisCfPw);
            registerPanel.Controls.Add(ReEmailTxt);
            registerPanel.Location = new Point(809, 125);
            registerPanel.Margin = new Padding(0);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(370, 486);
            registerPanel.TabIndex = 6;
            // 
            // ReUserTxt
            // 
            ReUserTxt.BackColor = Color.White;
            ReUserTxt.BorderColor = Color.White;
            ReUserTxt.BorderSize = 2;
            ReUserTxt.EnableText = true;
            ReUserTxt.FocusedColor = Color.HotPink;
            ReUserTxt.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ReUserTxt.ForeColor = Color.Black;
            ReUserTxt.IconImage = (Image)resources.GetObject("ReUserTxt.IconImage");
            ReUserTxt.Location = new Point(-1, 136);
            ReUserTxt.Margin = new Padding(0);
            ReUserTxt.Name = "ReUserTxt";
            ReUserTxt.OnlyNumber = false;
            ReUserTxt.Padding = new Padding(8, 7, 8, 7);
            ReUserTxt.PasswordChar = false;
            ReUserTxt.placeHolderText = "Username";
            ReUserTxt.setIcon = true;
            ReUserTxt.SetPassword = false;
            ReUserTxt.Size = new Size(306, 36);
            ReUserTxt.TabIndex = 8;
            ReUserTxt.Texts = "";
            ReUserTxt.Underlined1 = true;
            // 
            // ReNameTxt
            // 
            ReNameTxt.BackColor = Color.White;
            ReNameTxt.BorderColor = Color.White;
            ReNameTxt.BorderSize = 2;
            ReNameTxt.EnableText = true;
            ReNameTxt.FocusedColor = Color.HotPink;
            ReNameTxt.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ReNameTxt.ForeColor = Color.Black;
            ReNameTxt.IconImage = (Image)resources.GetObject("ReNameTxt.IconImage");
            ReNameTxt.Location = new Point(172, 294);
            ReNameTxt.Margin = new Padding(0);
            ReNameTxt.Name = "ReNameTxt";
            ReNameTxt.OnlyNumber = false;
            ReNameTxt.Padding = new Padding(8, 7, 8, 7);
            ReNameTxt.PasswordChar = false;
            ReNameTxt.placeHolderText = "Name";
            ReNameTxt.setIcon = true;
            ReNameTxt.SetPassword = false;
            ReNameTxt.Size = new Size(133, 36);
            ReNameTxt.TabIndex = 7;
            ReNameTxt.Texts = "";
            ReNameTxt.Underlined1 = true;
            // 
            // RegisPw
            // 
            RegisPw.BackColor = Color.White;
            RegisPw.BorderColor = Color.White;
            RegisPw.BorderSize = 2;
            RegisPw.EnableText = true;
            RegisPw.FocusedColor = Color.HotPink;
            RegisPw.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RegisPw.ForeColor = Color.Black;
            RegisPw.IconImage = (Image)resources.GetObject("RegisPw.IconImage");
            RegisPw.Location = new Point(0, 188);
            RegisPw.Margin = new Padding(0);
            RegisPw.Name = "RegisPw";
            RegisPw.OnlyNumber = false;
            RegisPw.Padding = new Padding(8, 7, 8, 7);
            RegisPw.PasswordChar = true;
            RegisPw.placeHolderText = "Password";
            RegisPw.setIcon = true;
            RegisPw.SetPassword = true;
            RegisPw.Size = new Size(305, 36);
            RegisPw.TabIndex = 6;
            RegisPw.Texts = "";
            RegisPw.Underlined1 = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(75, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(242, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.Transparent;
            customButton3.BackGColor = Color.Transparent;
            customButton3.BorderColor = Color.White;
            customButton3.BorderRadius = 30;
            customButton3.BorderSize = 2;
            customButton3.ClickedBool = false;
            customButton3.clikedColor = Color.MediumAquamarine;
            customButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customButton3.ForeColor = SystemColors.Window;
            customButton3.HoverBool = false;
            customButton3.HoverColor = Color.FromArgb(0, 192, 192);
            customButton3.ImageIcon = null;
            customButton3.Location = new Point(13, 421);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(93, 41);
            customButton3.TabIndex = 4;
            customButton3.Text = "Register";
            customButton3.Textcolor = SystemColors.Window;
            customButton3.UseVisualStyleBackColor = false;
            customButton3.Click += Registerbt_click;
            // 
            // RePhonetxt
            // 
            RePhonetxt.BackColor = Color.White;
            RePhonetxt.BorderColor = Color.White;
            RePhonetxt.BorderSize = 2;
            RePhonetxt.EnableText = true;
            RePhonetxt.FocusedColor = Color.HotPink;
            RePhonetxt.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RePhonetxt.ForeColor = Color.Black;
            RePhonetxt.IconImage = (Image)resources.GetObject("RePhonetxt.IconImage");
            RePhonetxt.Location = new Point(-1, 294);
            RePhonetxt.Margin = new Padding(0);
            RePhonetxt.Name = "RePhonetxt";
            RePhonetxt.OnlyNumber = false;
            RePhonetxt.Padding = new Padding(8, 7, 8, 7);
            RePhonetxt.PasswordChar = false;
            RePhonetxt.placeHolderText = "Phone";
            RePhonetxt.setIcon = true;
            RePhonetxt.SetPassword = false;
            RePhonetxt.Size = new Size(145, 36);
            RePhonetxt.TabIndex = 0;
            RePhonetxt.Texts = "";
            RePhonetxt.Underlined1 = true;
            // 
            // BacktologinBt
            // 
            BacktologinBt.BackColor = Color.Transparent;
            BacktologinBt.BackGColor = Color.Transparent;
            BacktologinBt.BorderColor = Color.White;
            BacktologinBt.BorderRadius = 30;
            BacktologinBt.BorderSize = 2;
            BacktologinBt.ClickedBool = false;
            BacktologinBt.clikedColor = Color.MediumAquamarine;
            BacktologinBt.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            BacktologinBt.FlatStyle = FlatStyle.Flat;
            BacktologinBt.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BacktologinBt.ForeColor = SystemColors.Window;
            BacktologinBt.HoverBool = false;
            BacktologinBt.HoverColor = Color.FromArgb(0, 192, 192);
            BacktologinBt.ImageIcon = null;
            BacktologinBt.Location = new Point(156, 421);
            BacktologinBt.Name = "BacktologinBt";
            BacktologinBt.Size = new Size(128, 41);
            BacktologinBt.TabIndex = 3;
            BacktologinBt.Text = "Back to Login";
            BacktologinBt.Textcolor = SystemColors.Window;
            BacktologinBt.UseVisualStyleBackColor = false;
            BacktologinBt.MouseClick += BacktologinButton_click;
            // 
            // RegisCfPw
            // 
            RegisCfPw.BackColor = Color.White;
            RegisCfPw.BorderColor = Color.White;
            RegisCfPw.BorderSize = 2;
            RegisCfPw.EnableText = true;
            RegisCfPw.FocusedColor = Color.HotPink;
            RegisCfPw.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RegisCfPw.ForeColor = Color.Black;
            RegisCfPw.IconImage = (Image)resources.GetObject("RegisCfPw.IconImage");
            RegisCfPw.Location = new Point(0, 241);
            RegisCfPw.Margin = new Padding(0);
            RegisCfPw.Name = "RegisCfPw";
            RegisCfPw.OnlyNumber = false;
            RegisCfPw.Padding = new Padding(8, 7, 8, 7);
            RegisCfPw.PasswordChar = true;
            RegisCfPw.placeHolderText = "Confirm Password";
            RegisCfPw.setIcon = true;
            RegisCfPw.SetPassword = true;
            RegisCfPw.Size = new Size(305, 36);
            RegisCfPw.TabIndex = 1;
            RegisCfPw.Texts = "";
            RegisCfPw.Underlined1 = true;
            // 
            // ReEmailTxt
            // 
            ReEmailTxt.BackColor = Color.White;
            ReEmailTxt.BorderColor = Color.White;
            ReEmailTxt.BorderSize = 2;
            ReEmailTxt.EnableText = true;
            ReEmailTxt.FocusedColor = Color.HotPink;
            ReEmailTxt.Font = new Font("Rockwell", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ReEmailTxt.ForeColor = Color.Black;
            ReEmailTxt.IconImage = (Image)resources.GetObject("ReEmailTxt.IconImage");
            ReEmailTxt.Location = new Point(0, 345);
            ReEmailTxt.Margin = new Padding(0);
            ReEmailTxt.Name = "ReEmailTxt";
            ReEmailTxt.OnlyNumber = false;
            ReEmailTxt.Padding = new Padding(8, 7, 8, 7);
            ReEmailTxt.PasswordChar = false;
            ReEmailTxt.placeHolderText = "Email";
            ReEmailTxt.setIcon = true;
            ReEmailTxt.SetPassword = false;
            ReEmailTxt.Size = new Size(256, 36);
            ReEmailTxt.TabIndex = 9;
            ReEmailTxt.Texts = "";
            ReEmailTxt.Underlined1 = true;
            // 
            // CloseBt
            // 
            CloseBt.BackColor = Color.FromArgb(255, 192, 192);
            CloseBt.FlatStyle = FlatStyle.Flat;
            CloseBt.Location = new Point(1170, 12);
            CloseBt.Name = "CloseBt";
            CloseBt.Size = new Size(36, 29);
            CloseBt.TabIndex = 7;
            CloseBt.Text = "X";
            CloseBt.UseVisualStyleBackColor = false;
            CloseBt.Click += CloseBt_click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(CloseBt);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1247, 72);
            panel1.TabIndex = 8;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 20;
            bunifuElipse1.TargetControl = this;
            // 
            // flogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1247, 780);
            Controls.Add(panel1);
            Controls.Add(loginPanel);
            Controls.Add(registerPanel);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.None;
            Name = "flogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            loginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            registerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomControl.CustomTextBox UserTxt;
        private CustomControl.CustomTextBox PassTxt;
        private CustomControl.customButton customButton1;
        private Panel loginPanel;
        private CustomControl.customButton toRegisterBt;
        private PictureBox pictureBox1;
        private Panel registerPanel;
        private PictureBox pictureBox2;
        private CustomControl.customButton customButton3;
        private CustomControl.CustomTextBox RePhonetxt;
        private CustomControl.customButton BacktologinBt;
        private CustomControl.CustomTextBox RegisCfPw;
        private CustomControl.CustomTextBox RegisPw;
        private CustomControl.CustomTextBox ReNameTxt;
        private CustomControl.CustomTextBox ReUserTxt;
        private CustomControl.CustomTextBox ReEmailTxt;
        private Button CloseBt;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}