using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClotheShop.CustomControl
{

    public partial class CustomTextBox : UserControl
    {   //variables
        private Color borderColor = Color.MediumAquamarine;
        private bool Underlined;
        private int borderSize = 2;
        private bool IsFocused = false;
        private Color focusedColor = Color.HotPink;
        private Image Iconimage;
        private int widthSize;
        private bool onlyNumber;


        //Contrustor
        public CustomTextBox()
        {
            widthSize = this.Width;
            InitializeComponent();
        }
        //properties
        [Category("Custom Advanced setting")]

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom Advanced setting")]

        public bool Underlined1
        {
            get => Underlined;
            set
            {
                Underlined = value;
                this.Invalidate();
            }
        }
        [Category("Custom Advanced setting")]

        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                Mytextbox.BackColor = value;
            }
        }
        [Category("Custom Advanced setting")]
        public Color FocusedColor
        {
            get => focusedColor;
            set
            {
                focusedColor = value;
            }
        }
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                Mytextbox.ForeColor = value;
                base.ForeColor = value;
            }
        }
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                Mytextbox.Font = value;
                if (this.DesignMode)
                {
                    updateControlHeight();
                }
            }
        }
        [Category("Custom Advanced setting")]
        public string Texts
        {
            get => Mytextbox.Text;
            set
            {
                Mytextbox.Text = value;
            }
        }
        [Category("Custom Advanced setting")]
        public bool PasswordChar
        {
            get => Mytextbox.UseSystemPasswordChar;
            set => Mytextbox.UseSystemPasswordChar = value;
        }
        [Category("Custom Advanced setting")]
        public Image IconImage
        {
            get => Iconimage;
            set
            {
                myPictureBox.Image = value;
                Iconimage = value;
            }
        }
        [Category("Custom Advanced setting")]

        public bool setIcon
        {
            get => myPictureBox.Visible;
            set
            {
                myPictureBox.Visible = value;
                if (!myPictureBox.Visible)
                    Mytextbox.Location = new Point(Mytextbox.Location.X - myPictureBox.Width, Mytextbox.Location.Y);
            }
        }
        [Category("Custom Advanced setting")]
        public string placeHolderText
        {
            get => Mytextbox.PlaceholderText;
            set
            {
                Mytextbox.PlaceholderText = value;

            }
        }
        [Category("Custom Advanced setting")]
        public bool SetPassword
        {
            get => Mytextbox.UseSystemPasswordChar;
            set
            {
                Mytextbox.UseSystemPasswordChar = value;
            }
        }
        public bool EnableText
        {
            get => Mytextbox.Enabled;
            set
            {
                Mytextbox.Enabled = value;
                if (value)
                {
                    this.BackColor = Color.White;

                }
                else
                {
                    this.BackColor = System.Drawing.ColorTranslator.FromHtml("#f8f4f4");
                }
            }
        }
        [Category("Custom Advanced setting")]
        public bool OnlyNumber
        {
            get => onlyNumber;
            set => onlyNumber = value;
        }



        //overriden methods
        protected override void OnTextChanged(EventArgs e)
        {
            MessageBox.Show("ádasda");
            if (onlyNumber)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(Mytextbox.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    Mytextbox.Text = Mytextbox.Text.Remove(Mytextbox.Text.Length - 1);
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (!IsFocused)
                {
                    if (Underlined)
                    {
                        g.DrawLine(penBorder, this.Padding.Left, this.Height - 1, this.Width - this.Padding.Right, this.Height - 1);
                    }
                    else
                    {
                        g.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
                else
                {
                    penBorder.Color = focusedColor;
                    if (Underlined)
                    {
                        g.DrawLine(penBorder, this.Padding.Left, this.Height - 1, this.Width - this.Padding.Right, this.Height - 1);
                    }
                    else
                    {
                        g.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            updateControlHeight();

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                updateControlHeight();
            }
        }
        //private methods
        private void updateControlHeight()
        {
            if (Mytextbox.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                Mytextbox.Multiline = true;
                Mytextbox.MinimumSize = new Size(0, txtHeight);
                Mytextbox.Multiline = false;

                this.Height = Mytextbox.Height + this.Padding.Top + this.Padding.Right;
            }
        }
        private void updateControlWidth()
        {
            int diff = this.Width - widthSize;
            widthSize = this.Width;
            Mytextbox.Width += diff;
        }
        private void Mytextbox_Enter(object sender, EventArgs e)
        {
            this.IsFocused = true;
            this.Invalidate();
        }

        private void Mytextbox_Leave(object sender, EventArgs e)
        {
            this.IsFocused = false;
            this.Invalidate();
        }

     

     
        private void Mytextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mytextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (onlyNumber)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }
    }



}
