namespace ClotheShop.CustomControl
{
    partial class CustomTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Mytextbox = new TextBox();
            myPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)myPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Mytextbox
            // 
            Mytextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Mytextbox.BorderStyle = BorderStyle.None;
            Mytextbox.Cursor = Cursors.IBeam;
            Mytextbox.ForeColor = Color.White;
            Mytextbox.Location = new Point(46, 13);
            Mytextbox.Name = "Mytextbox";
            Mytextbox.Size = new Size(191, 22);
            Mytextbox.TabIndex = 0;
            Mytextbox.TextChanged += Mytextbox_TextChanged;
            Mytextbox.Enter += Mytextbox_Enter;
            Mytextbox.KeyPress += Mytextbox_KeyPress;
            Mytextbox.Leave += Mytextbox_Leave;
            // 
            // myPictureBox
            // 
            myPictureBox.Dock = DockStyle.Left;
            myPictureBox.Location = new Point(8, 7);
            myPictureBox.Name = "myPictureBox";
            myPictureBox.Size = new Size(32, 31);
            myPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            myPictureBox.TabIndex = 1;
            myPictureBox.TabStop = false;
            // 
            // CustomTextBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            Controls.Add(myPictureBox);
            Controls.Add(Mytextbox);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "CustomTextBox";
            Padding = new Padding(8, 7, 2, 7);
            Size = new Size(242, 45);
            ((System.ComponentModel.ISupportInitialize)myPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Mytextbox;
        private PictureBox myPictureBox;
    }
}
