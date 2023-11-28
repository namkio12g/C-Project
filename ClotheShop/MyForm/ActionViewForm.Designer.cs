namespace ClotheShop.MyForm
{
    partial class ActionViewForm
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
            RoleCombobox = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // RoleCombobox
            // 
            RoleCombobox.FormattingEnabled = true;
            RoleCombobox.Location = new Point(136, 258);
            RoleCombobox.Name = "RoleCombobox";
            RoleCombobox.Size = new Size(215, 28);
            RoleCombobox.TabIndex = 0;
            RoleCombobox.SelectedValueChanged += RoleCombobox_SelectedValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(545, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 575);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 258);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 2;
            label1.Text = "Pick a Role";
            // 
            // ActionViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(965, 630);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(RoleCombobox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActionViewForm";
            Text = "ActionViewForm";
            Load += ActionViewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox RoleCombobox;
        private Panel panel1;
        private Label label1;
    }
}