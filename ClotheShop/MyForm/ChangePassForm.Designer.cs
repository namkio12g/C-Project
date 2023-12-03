namespace ClotheShop.MyForm
{
    partial class ChangePassForm
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
            PasswordTxt = new CustomControl.CustomTextBox();
            label1 = new Label();
            ConfirmPasswordTxt = new CustomControl.CustomTextBox();
            label2 = new Label();
            customButton1 = new CustomControl.customButton();
            SuspendLayout();
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
            PasswordTxt.Location = new Point(61, 49);
            PasswordTxt.Margin = new Padding(0);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.OnlyNumber = false;
            PasswordTxt.Padding = new Padding(8, 7, 8, 7);
            PasswordTxt.PasswordChar = true;
            PasswordTxt.placeHolderText = "";
            PasswordTxt.setIcon = false;
            PasswordTxt.SetPassword = true;
            PasswordTxt.Size = new Size(261, 39);
            PasswordTxt.TabIndex = 119;
            PasswordTxt.Texts = "";
            PasswordTxt.Underlined1 = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(62, 30);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 118;
            label1.Text = "Password";
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt.BackColor = Color.White;
            ConfirmPasswordTxt.BorderColor = Color.Gray;
            ConfirmPasswordTxt.BorderSize = 2;
            ConfirmPasswordTxt.EnableText = true;
            ConfirmPasswordTxt.FocusedColor = Color.HotPink;
            ConfirmPasswordTxt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmPasswordTxt.ForeColor = SystemColors.ActiveCaptionText;
            ConfirmPasswordTxt.IconImage = null;
            ConfirmPasswordTxt.Location = new Point(61, 170);
            ConfirmPasswordTxt.Margin = new Padding(0);
            ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            ConfirmPasswordTxt.OnlyNumber = false;
            ConfirmPasswordTxt.Padding = new Padding(8, 7, 8, 7);
            ConfirmPasswordTxt.PasswordChar = true;
            ConfirmPasswordTxt.placeHolderText = "";
            ConfirmPasswordTxt.setIcon = false;
            ConfirmPasswordTxt.SetPassword = true;
            ConfirmPasswordTxt.Size = new Size(261, 39);
            ConfirmPasswordTxt.TabIndex = 121;
            ConfirmPasswordTxt.Texts = "";
            ConfirmPasswordTxt.Underlined1 = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(62, 136);
            label2.Name = "label2";
            label2.Size = new Size(157, 19);
            label2.TabIndex = 120;
            label2.Text = "Password Confirm ";
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Gold;
            customButton1.BackGColor = Color.Gold;
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
            customButton1.Location = new Point(85, 277);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(188, 50);
            customButton1.TabIndex = 122;
            customButton1.Text = "Finish";
            customButton1.Textcolor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // ChangePassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(403, 365);
            Controls.Add(customButton1);
            Controls.Add(ConfirmPasswordTxt);
            Controls.Add(label2);
            Controls.Add(PasswordTxt);
            Controls.Add(label1);
            Name = "ChangePassForm";
            Text = "ChangePassForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControl.CustomTextBox PasswordTxt;
        private Label label1;
        private CustomControl.CustomTextBox ConfirmPasswordTxt;
        private Label label2;
        private CustomControl.customButton customButton1;
    }
}