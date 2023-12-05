namespace ClotheShop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel2 = new Panel();
            customButton5 = new CustomControl.customButton();
            StatisticBt = new CustomControl.customButton();
            ActionButton = new CustomControl.customButton();
            CreateBillBt = new CustomControl.customButton();
            customButton1 = new CustomControl.customButton();
            topPanel = new Panel();
            CloseBt = new Button();
            UserAccessName = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuPanel = new Panel();
            mainPanel = new Panel();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            MinimizeBt = new Button();
            panel2.SuspendLayout();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(customButton5);
            panel2.Controls.Add(StatisticBt);
            panel2.Controls.Add(ActionButton);
            panel2.Controls.Add(CreateBillBt);
            panel2.Controls.Add(customButton1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 740);
            panel2.TabIndex = 1;
            // 
            // customButton5
            // 
            customButton5.BackColor = Color.Transparent;
            customButton5.BackGColor = Color.Transparent;
            customButton5.BorderColor = Color.HotPink;
            customButton5.BorderRadius = 0;
            customButton5.BorderSize = 0;
            customButton5.ClickedBool = true;
            customButton5.clikedColor = Color.Aqua;
            customButton5.Dock = DockStyle.Top;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatAppearance.MouseOverBackColor = Color.MediumAquamarine;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton5.ForeColor = Color.Black;
            customButton5.HoverBool = false;
            customButton5.HoverColor = Color.Cyan;
            customButton5.Image = (Image)resources.GetObject("customButton5.Image");
            customButton5.ImageIcon = (Image)resources.GetObject("customButton5.ImageIcon");
            customButton5.Location = new Point(0, 210);
            customButton5.Margin = new Padding(5);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(234, 50);
            customButton5.TabIndex = 4;
            customButton5.Text = "Log out";
            customButton5.Textcolor = Color.Black;
            customButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton5.UseVisualStyleBackColor = false;
            customButton5.Click += customButton5_Click;
            // 
            // StatisticBt
            // 
            StatisticBt.BackColor = Color.Transparent;
            StatisticBt.BackGColor = Color.Transparent;
            StatisticBt.BorderColor = Color.HotPink;
            StatisticBt.BorderRadius = 0;
            StatisticBt.BorderSize = 0;
            StatisticBt.ClickedBool = true;
            StatisticBt.clikedColor = Color.Aqua;
            StatisticBt.Dock = DockStyle.Top;
            StatisticBt.FlatAppearance.BorderSize = 0;
            StatisticBt.FlatAppearance.MouseOverBackColor = Color.MediumAquamarine;
            StatisticBt.FlatStyle = FlatStyle.Flat;
            StatisticBt.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StatisticBt.ForeColor = Color.Black;
            StatisticBt.HoverBool = false;
            StatisticBt.HoverColor = Color.Cyan;
            StatisticBt.Image = (Image)resources.GetObject("StatisticBt.Image");
            StatisticBt.ImageIcon = (Image)resources.GetObject("StatisticBt.ImageIcon");
            StatisticBt.Location = new Point(0, 160);
            StatisticBt.Margin = new Padding(5);
            StatisticBt.Name = "StatisticBt";
            StatisticBt.Size = new Size(234, 50);
            StatisticBt.TabIndex = 3;
            StatisticBt.Text = "Statistic";
            StatisticBt.Textcolor = Color.Black;
            StatisticBt.TextImageRelation = TextImageRelation.ImageBeforeText;
            StatisticBt.UseVisualStyleBackColor = false;
            StatisticBt.Click += StatisticBt_Click;
            // 
            // ActionButton
            // 
            ActionButton.BackColor = Color.Transparent;
            ActionButton.BackGColor = Color.Transparent;
            ActionButton.BorderColor = Color.HotPink;
            ActionButton.BorderRadius = 0;
            ActionButton.BorderSize = 0;
            ActionButton.ClickedBool = true;
            ActionButton.clikedColor = Color.Aqua;
            ActionButton.Dock = DockStyle.Top;
            ActionButton.FlatAppearance.BorderSize = 0;
            ActionButton.FlatAppearance.MouseOverBackColor = Color.MediumAquamarine;
            ActionButton.FlatStyle = FlatStyle.Flat;
            ActionButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ActionButton.ForeColor = Color.Black;
            ActionButton.HoverBool = false;
            ActionButton.HoverColor = Color.Cyan;
            ActionButton.Image = (Image)resources.GetObject("ActionButton.Image");
            ActionButton.ImageIcon = (Image)resources.GetObject("ActionButton.ImageIcon");
            ActionButton.Location = new Point(0, 110);
            ActionButton.Margin = new Padding(5);
            ActionButton.Name = "ActionButton";
            ActionButton.Size = new Size(234, 50);
            ActionButton.TabIndex = 2;
            ActionButton.Text = "Action ";
            ActionButton.Textcolor = Color.Black;
            ActionButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ActionButton.UseVisualStyleBackColor = false;
            ActionButton.Click += ActionButton_Click;
            // 
            // CreateBillBt
            // 
            CreateBillBt.BackColor = Color.Transparent;
            CreateBillBt.BackGColor = Color.Transparent;
            CreateBillBt.BorderColor = Color.HotPink;
            CreateBillBt.BorderRadius = 0;
            CreateBillBt.BorderSize = 0;
            CreateBillBt.ClickedBool = true;
            CreateBillBt.clikedColor = Color.Aqua;
            CreateBillBt.Dock = DockStyle.Top;
            CreateBillBt.FlatAppearance.BorderSize = 0;
            CreateBillBt.FlatAppearance.MouseOverBackColor = Color.MediumAquamarine;
            CreateBillBt.FlatStyle = FlatStyle.Flat;
            CreateBillBt.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateBillBt.ForeColor = Color.Black;
            CreateBillBt.HoverBool = false;
            CreateBillBt.HoverColor = Color.Cyan;
            CreateBillBt.Image = (Image)resources.GetObject("CreateBillBt.Image");
            CreateBillBt.ImageIcon = (Image)resources.GetObject("CreateBillBt.ImageIcon");
            CreateBillBt.Location = new Point(0, 60);
            CreateBillBt.Margin = new Padding(5);
            CreateBillBt.Name = "CreateBillBt";
            CreateBillBt.Size = new Size(234, 50);
            CreateBillBt.TabIndex = 1;
            CreateBillBt.Text = "Create bill";
            CreateBillBt.Textcolor = Color.Black;
            CreateBillBt.TextImageRelation = TextImageRelation.ImageBeforeText;
            CreateBillBt.UseVisualStyleBackColor = false;
            CreateBillBt.Click += customButton2_Click;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Transparent;
            customButton1.BackGColor = Color.Transparent;
            customButton1.BorderColor = Color.HotPink;
            customButton1.BorderRadius = 0;
            customButton1.BorderSize = 0;
            customButton1.ClickedBool = true;
            customButton1.clikedColor = Color.Aqua;
            customButton1.Dock = DockStyle.Top;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatAppearance.MouseOverBackColor = Color.MediumAquamarine;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.Black;
            customButton1.HoverBool = false;
            customButton1.HoverColor = Color.Cyan;
            customButton1.Image = (Image)resources.GetObject("customButton1.Image");
            customButton1.ImageIcon = (Image)resources.GetObject("customButton1.ImageIcon");
            customButton1.Location = new Point(0, 0);
            customButton1.Margin = new Padding(5);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(234, 60);
            customButton1.TabIndex = 0;
            customButton1.Text = "Data view";
            customButton1.Textcolor = Color.Black;
            customButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.PaleTurquoise;
            topPanel.Controls.Add(MinimizeBt);
            topPanel.Controls.Add(CloseBt);
            topPanel.Controls.Add(UserAccessName);
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(label1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1360, 110);
            topPanel.TabIndex = 2;
            topPanel.MouseDown += topPanel_MouseDown;
            topPanel.MouseMove += topPanel_MouseMove;
            topPanel.MouseUp += topPanel_MouseUp;
            // 
            // CloseBt
            // 
            CloseBt.BackColor = Color.FromArgb(255, 192, 192);
            CloseBt.FlatStyle = FlatStyle.Flat;
            CloseBt.Location = new Point(1300, 24);
            CloseBt.Name = "CloseBt";
            CloseBt.Size = new Size(36, 29);
            CloseBt.TabIndex = 8;
            CloseBt.Text = "X";
            CloseBt.UseVisualStyleBackColor = false;
            CloseBt.Click += CloseBt_Click;
            // 
            // UserAccessName
            // 
            UserAccessName.AutoSize = true;
            UserAccessName.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserAccessName.Location = new Point(143, 62);
            UserAccessName.Name = "UserAccessName";
            UserAccessName.Size = new Size(98, 29);
            UserAccessName.TabIndex = 2;
            UserAccessName.Text = "Welcome";
            UserAccessName.Click += UserAccessName_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(143, 24);
            label1.Name = "label1";
            label1.Size = new Size(107, 29);
            label1.TabIndex = 0;
            label1.Text = "Welcome ";
            label1.Click += label1_Click;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(128, 255, 128);
            menuPanel.Controls.Add(panel2);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 110);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(234, 740);
            menuPanel.TabIndex = 3;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.WhiteSmoke;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(234, 110);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1126, 740);
            mainPanel.TabIndex = 4;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 10;
            bunifuElipse1.TargetControl = menuPanel;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 10;
            bunifuElipse2.TargetControl = this;
            // 
            // MinimizeBt
            // 
            MinimizeBt.BackColor = Color.FromArgb(128, 128, 255);
            MinimizeBt.FlatStyle = FlatStyle.Flat;
            MinimizeBt.Location = new Point(1258, 24);
            MinimizeBt.Name = "MinimizeBt";
            MinimizeBt.Size = new Size(36, 29);
            MinimizeBt.TabIndex = 9;
            MinimizeBt.Text = "-";
            MinimizeBt.UseVisualStyleBackColor = false;
            MinimizeBt.Click += MinimizeBt_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1360, 850);
            Controls.Add(mainPanel);
            Controls.Add(menuPanel);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Form1";
            panel2.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private CustomControl.customButton customButton5;
        private CustomControl.customButton StatisticBt;
        private CustomControl.customButton ActionButton;
        private CustomControl.customButton CreateBillBt;
        private CustomControl.customButton customButton1;
        private Panel topPanel;
        private Panel menuPanel;
        private Panel mainPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label UserAccessName;
        private Button CloseBt;
        private Button MinimizeBt;
    }
}