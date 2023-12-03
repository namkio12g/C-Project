namespace ClotheShop.MyForm
{
    partial class CreateBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBillForm));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            FinishBt2 = new CustomControl.customButton();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ProductListDGV = new DataGridView();
            IdTxt = new CustomControl.CustomTextBox();
            AddBt = new CustomControl.customButton();
            NumberTxt = new CustomControl.CustomTextBox();
            label16 = new Label();
            label1 = new Label();
            customButton2 = new CustomControl.customButton();
            customButton3 = new CustomControl.customButton();
            InfoPanel = new Panel();
            CustomerPhoneTxt = new CustomControl.CustomTextBox();
            FinishBt = new CustomControl.customButton();
            label4 = new Label();
            CustomerAddressTxt = new CustomControl.CustomTextBox();
            label3 = new Label();
            label2 = new Label();
            CustomerNameTxt = new CustomControl.CustomTextBox();
            CancelBt = new CustomControl.customButton();
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)ProductListDGV).BeginInit();
            InfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FinishBt2
            // 
            FinishBt2.BackColor = Color.MediumSlateBlue;
            FinishBt2.BackGColor = Color.MediumSlateBlue;
            FinishBt2.BorderColor = Color.HotPink;
            FinishBt2.BorderRadius = 40;
            FinishBt2.BorderSize = 0;
            FinishBt2.ClickedBool = false;
            FinishBt2.clikedColor = Color.MediumAquamarine;
            FinishBt2.FlatAppearance.BorderSize = 0;
            FinishBt2.FlatStyle = FlatStyle.Flat;
            FinishBt2.ForeColor = Color.White;
            FinishBt2.HoverBool = false;
            FinishBt2.HoverColor = Color.MediumAquamarine;
            FinishBt2.ImageIcon = null;
            FinishBt2.Location = new Point(909, 416);
            FinishBt2.Name = "FinishBt2";
            FinishBt2.Size = new Size(160, 50);
            FinishBt2.TabIndex = 0;
            FinishBt2.Text = "Finish";
            FinishBt2.Textcolor = Color.White;
            FinishBt2.UseVisualStyleBackColor = false;
            FinishBt2.Visible = false;
            FinishBt2.Click += customButton1_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // ProductListDGV
            // 
            ProductListDGV.AllowUserToAddRows = false;
            ProductListDGV.AllowUserToDeleteRows = false;
            ProductListDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductListDGV.BackgroundColor = Color.White;
            ProductListDGV.BorderStyle = BorderStyle.None;
            ProductListDGV.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            ProductListDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.BottomLeft;
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
            ProductListDGV.Location = new Point(22, 315);
            ProductListDGV.Name = "ProductListDGV";
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
            ProductListDGV.Size = new Size(863, 371);
            ProductListDGV.TabIndex = 2;
            ProductListDGV.CellClick += ProductListDGV_CellClick;
            ProductListDGV.CellValueChanged += ProductListDGV_CellValueChanged;
            // 
            // IdTxt
            // 
            IdTxt.BackColor = Color.White;
            IdTxt.BorderColor = Color.Plum;
            IdTxt.BorderSize = 2;
            IdTxt.EnableText = true;
            IdTxt.FocusedColor = Color.HotPink;
            IdTxt.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            IdTxt.ForeColor = SystemColors.ActiveCaptionText;
            IdTxt.IconImage = null;
            IdTxt.Location = new Point(22, 48);
            IdTxt.Margin = new Padding(0);
            IdTxt.Name = "IdTxt";
            IdTxt.OnlyNumber = false;
            IdTxt.Padding = new Padding(8, 7, 8, 7);
            IdTxt.PasswordChar = false;
            IdTxt.placeHolderText = "";
            IdTxt.setIcon = false;
            IdTxt.SetPassword = false;
            IdTxt.Size = new Size(137, 37);
            IdTxt.TabIndex = 9;
            IdTxt.Texts = "";
            IdTxt.Underlined1 = false;
            IdTxt.Load += nameSearchTextbox_Load;
            // 
            // AddBt
            // 
            AddBt.BackColor = Color.Gold;
            AddBt.BackGColor = Color.Gold;
            AddBt.BorderColor = Color.HotPink;
            AddBt.BorderRadius = 40;
            AddBt.BorderSize = 0;
            AddBt.ClickedBool = false;
            AddBt.clikedColor = Color.MediumAquamarine;
            AddBt.FlatAppearance.BorderSize = 0;
            AddBt.FlatStyle = FlatStyle.Flat;
            AddBt.ForeColor = Color.White;
            AddBt.HoverBool = false;
            AddBt.HoverColor = Color.MediumAquamarine;
            AddBt.ImageIcon = null;
            AddBt.Location = new Point(22, 245);
            AddBt.Name = "AddBt";
            AddBt.Size = new Size(137, 50);
            AddBt.TabIndex = 10;
            AddBt.Text = "Add Product";
            AddBt.Textcolor = Color.White;
            AddBt.UseVisualStyleBackColor = false;
            AddBt.Click += AddBt_Click;
            // 
            // NumberTxt
            // 
            NumberTxt.BackColor = Color.White;
            NumberTxt.BorderColor = Color.Plum;
            NumberTxt.BorderSize = 2;
            NumberTxt.EnableText = true;
            NumberTxt.FocusedColor = Color.HotPink;
            NumberTxt.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            NumberTxt.ForeColor = SystemColors.ActiveCaptionText;
            NumberTxt.IconImage = null;
            NumberTxt.Location = new Point(191, 48);
            NumberTxt.Margin = new Padding(0);
            NumberTxt.Name = "NumberTxt";
            NumberTxt.OnlyNumber = false;
            NumberTxt.Padding = new Padding(8, 7, 8, 7);
            NumberTxt.PasswordChar = false;
            NumberTxt.placeHolderText = "";
            NumberTxt.setIcon = false;
            NumberTxt.SetPassword = false;
            NumberTxt.Size = new Size(137, 37);
            NumberTxt.TabIndex = 11;
            NumberTxt.Texts = "";
            NumberTxt.Underlined1 = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.MidnightBlue;
            label16.Location = new Point(22, 26);
            label16.Name = "label16";
            label16.Size = new Size(29, 21);
            label16.TabIndex = 60;
            label16.Text = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(191, 27);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 61;
            label1.Text = "Number";
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.FromArgb(0, 192, 192);
            customButton2.BackGColor = Color.FromArgb(0, 192, 192);
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
            customButton2.Location = new Point(191, 245);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(137, 50);
            customButton2.TabIndex = 62;
            customButton2.Text = "Search Product";
            customButton2.Textcolor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.Red;
            customButton3.BackGColor = Color.Red;
            customButton3.BorderColor = Color.HotPink;
            customButton3.BorderRadius = 40;
            customButton3.BorderSize = 0;
            customButton3.ClickedBool = false;
            customButton3.clikedColor = Color.MediumAquamarine;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.ForeColor = Color.White;
            customButton3.HoverBool = false;
            customButton3.HoverColor = Color.MediumAquamarine;
            customButton3.ImageIcon = null;
            customButton3.Location = new Point(364, 245);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(137, 50);
            customButton3.TabIndex = 63;
            customButton3.Text = "Delete Product";
            customButton3.Textcolor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            customButton3.Click += customButton3_Click;
            // 
            // InfoPanel
            // 
            InfoPanel.BackColor = Color.LightBlue;
            InfoPanel.Controls.Add(CustomerPhoneTxt);
            InfoPanel.Controls.Add(FinishBt);
            InfoPanel.Controls.Add(label4);
            InfoPanel.Controls.Add(CustomerAddressTxt);
            InfoPanel.Controls.Add(label3);
            InfoPanel.Controls.Add(label2);
            InfoPanel.Controls.Add(CustomerNameTxt);
            InfoPanel.Location = new Point(12, 2);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(662, 307);
            InfoPanel.TabIndex = 64;
            // 
            // CustomerPhoneTxt
            // 
            CustomerPhoneTxt.BackColor = Color.White;
            CustomerPhoneTxt.BorderColor = Color.Plum;
            CustomerPhoneTxt.BorderSize = 2;
            CustomerPhoneTxt.EnableText = true;
            CustomerPhoneTxt.FocusedColor = Color.HotPink;
            CustomerPhoneTxt.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerPhoneTxt.ForeColor = SystemColors.ActiveCaptionText;
            CustomerPhoneTxt.IconImage = null;
            CustomerPhoneTxt.Location = new Point(21, 153);
            CustomerPhoneTxt.Margin = new Padding(0);
            CustomerPhoneTxt.Name = "CustomerPhoneTxt";
            CustomerPhoneTxt.OnlyNumber = true;
            CustomerPhoneTxt.Padding = new Padding(8, 7, 8, 7);
            CustomerPhoneTxt.PasswordChar = false;
            CustomerPhoneTxt.placeHolderText = "";
            CustomerPhoneTxt.setIcon = false;
            CustomerPhoneTxt.SetPassword = false;
            CustomerPhoneTxt.Size = new Size(222, 37);
            CustomerPhoneTxt.TabIndex = 66;
            CustomerPhoneTxt.Texts = "";
            CustomerPhoneTxt.Underlined1 = false;
            // 
            // FinishBt
            // 
            FinishBt.BackColor = Color.OrangeRed;
            FinishBt.BackGColor = Color.OrangeRed;
            FinishBt.BorderColor = Color.HotPink;
            FinishBt.BorderRadius = 40;
            FinishBt.BorderSize = 0;
            FinishBt.ClickedBool = false;
            FinishBt.clikedColor = Color.MediumAquamarine;
            FinishBt.FlatAppearance.BorderSize = 0;
            FinishBt.FlatStyle = FlatStyle.Flat;
            FinishBt.ForeColor = Color.White;
            FinishBt.HoverBool = false;
            FinishBt.HoverColor = Color.MediumAquamarine;
            FinishBt.ImageIcon = null;
            FinishBt.Location = new Point(10, 243);
            FinishBt.Name = "FinishBt";
            FinishBt.Size = new Size(224, 50);
            FinishBt.TabIndex = 65;
            FinishBt.Text = "Finish";
            FinishBt.Textcolor = Color.White;
            FinishBt.UseVisualStyleBackColor = false;
            FinishBt.Click += FinishBt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(316, 24);
            label4.Name = "label4";
            label4.Size = new Size(173, 21);
            label4.TabIndex = 65;
            label4.Text = "Customer Address";
            // 
            // CustomerAddressTxt
            // 
            CustomerAddressTxt.BackColor = Color.White;
            CustomerAddressTxt.BorderColor = Color.Plum;
            CustomerAddressTxt.BorderSize = 2;
            CustomerAddressTxt.EnableText = true;
            CustomerAddressTxt.FocusedColor = Color.HotPink;
            CustomerAddressTxt.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerAddressTxt.ForeColor = SystemColors.ActiveCaptionText;
            CustomerAddressTxt.IconImage = null;
            CustomerAddressTxt.Location = new Point(316, 56);
            CustomerAddressTxt.Margin = new Padding(0);
            CustomerAddressTxt.Name = "CustomerAddressTxt";
            CustomerAddressTxt.OnlyNumber = false;
            CustomerAddressTxt.Padding = new Padding(8, 7, 8, 7);
            CustomerAddressTxt.PasswordChar = false;
            CustomerAddressTxt.placeHolderText = "";
            CustomerAddressTxt.setIcon = false;
            CustomerAddressTxt.SetPassword = false;
            CustomerAddressTxt.Size = new Size(222, 37);
            CustomerAddressTxt.TabIndex = 64;
            CustomerAddressTxt.Texts = "";
            CustomerAddressTxt.Underlined1 = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(21, 114);
            label3.Name = "label3";
            label3.Size = new Size(158, 21);
            label3.TabIndex = 63;
            label3.Text = "Customer Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(21, 24);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 61;
            label2.Text = "Customer Name";
            // 
            // CustomerNameTxt
            // 
            CustomerNameTxt.BackColor = Color.White;
            CustomerNameTxt.BorderColor = Color.Plum;
            CustomerNameTxt.BorderSize = 2;
            CustomerNameTxt.EnableText = true;
            CustomerNameTxt.FocusedColor = Color.DarkOrchid;
            CustomerNameTxt.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerNameTxt.ForeColor = SystemColors.ActiveCaptionText;
            CustomerNameTxt.IconImage = null;
            CustomerNameTxt.Location = new Point(21, 56);
            CustomerNameTxt.Margin = new Padding(0);
            CustomerNameTxt.Name = "CustomerNameTxt";
            CustomerNameTxt.OnlyNumber = false;
            CustomerNameTxt.Padding = new Padding(8, 7, 8, 7);
            CustomerNameTxt.PasswordChar = false;
            CustomerNameTxt.placeHolderText = "";
            CustomerNameTxt.setIcon = false;
            CustomerNameTxt.SetPassword = false;
            CustomerNameTxt.Size = new Size(222, 37);
            CustomerNameTxt.TabIndex = 12;
            CustomerNameTxt.Texts = "";
            CustomerNameTxt.Underlined1 = false;
            // 
            // CancelBt
            // 
            CancelBt.BackColor = Color.FromArgb(255, 128, 0);
            CancelBt.BackGColor = Color.FromArgb(255, 128, 0);
            CancelBt.BorderColor = Color.HotPink;
            CancelBt.BorderRadius = 40;
            CancelBt.BorderSize = 0;
            CancelBt.ClickedBool = false;
            CancelBt.clikedColor = Color.MediumAquamarine;
            CancelBt.FlatAppearance.BorderSize = 0;
            CancelBt.FlatStyle = FlatStyle.Flat;
            CancelBt.ForeColor = Color.White;
            CancelBt.HoverBool = false;
            CancelBt.HoverColor = Color.MediumAquamarine;
            CancelBt.ImageIcon = null;
            CancelBt.Location = new Point(907, 485);
            CancelBt.Name = "CancelBt";
            CancelBt.Size = new Size(162, 50);
            CancelBt.TabIndex = 65;
            CancelBt.Text = "Cancel";
            CancelBt.Textcolor = Color.White;
            CancelBt.UseVisualStyleBackColor = false;
            CancelBt.Visible = false;
            CancelBt.Click += CancelBt_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // CreateBillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1108, 685);
            Controls.Add(InfoPanel);
            Controls.Add(CancelBt);
            Controls.Add(customButton3);
            Controls.Add(customButton2);
            Controls.Add(label1);
            Controls.Add(label16);
            Controls.Add(NumberTxt);
            Controls.Add(FinishBt2);
            Controls.Add(AddBt);
            Controls.Add(IdTxt);
            Controls.Add(ProductListDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateBillForm";
            Text = "BillViewForm";
            ((System.ComponentModel.ISupportInitialize)ProductListDGV).EndInit();
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControl.customButton FinishBt2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintPreviewControl printPreviewControl1;
        private DataGridView ProductListDGV;
        private CustomControl.CustomTextBox IdTxt;
        private CustomControl.customButton AddBt;
        private CustomControl.CustomTextBox NumberTxt;
        private Label label16;
        private Label label1;
        private CustomControl.customButton customButton2;
        private CustomControl.customButton customButton3;
        private Panel InfoPanel;
        private Label label2;
        private CustomControl.CustomTextBox CustomerNameTxt;
        private CustomControl.customButton FinishBt;
        private Label label4;
        private CustomControl.CustomTextBox CustomerAddressTxt;
        private Label label3;
        private CustomControl.CustomTextBox CustomerPhoneTxt;
        private CustomControl.customButton CancelBt;
        private NotifyIcon notifyIcon1;
    }
}