using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace ClotheShop.CustomControl
{
    public partial class customButton : Button
    {
        private int borderRadius = 40;
        private int borderSize = 0;
        private Color borderColor = Color.HotPink;
        private bool hoverBool;
        private Color hoverColor = Color.MediumAquamarine;
        private Color ClikedColor = Color.MediumAquamarine;
        private bool clickedBool;
        [Category("advanced custom")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            }

        }

        [Category("advanced custom")]

        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("advanced custom")]

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
                
            }
        }
        [Category("advanced custom")]

        public Color BackGColor
        {
            get => this.BackColor;
            set
            {
                this.BackColor = value;
                this.Invalidate();
            }
        }
        [Category("advanced custom")]
        public Color Textcolor
        {
            get => this.ForeColor;
            set
            {

                this.ForeColor = value;
                this.Invalidate();
            }
        }
        [Category("advanced custom")]
        public bool HoverBool
        {
            get => hoverBool;
            set => hoverBool = value;
        }
        [Category("advanced custom")]
        public Color HoverColor
        {
            get => hoverColor;
            set
            {
                hoverColor = value;
                if (hoverBool) 
                    this.FlatAppearance.MouseOverBackColor = hoverColor;
            }
        }
        [Category("advanced custom")]
        public Image ImageIcon
        {
            get => this.Image;
            set
            {
                int SizeIcon = this.Height / 2;
                if(value!=null)
                    this.Image = value.GetThumbnailImage(SizeIcon, SizeIcon, null, IntPtr.Zero);
                else
                    this.Image = null;
                
            }
        }
        [Category("advanced custom")]
        public Color clikedColor
        {
            get => ClikedColor;
            set => ClikedColor = value;
        }
        [Category("advanced custom")]
        public bool ClickedBool
        {
            get => clickedBool;
            set => clickedBool = value;
        }

        public customButton()
        {
            InitializeComponent();
        }
        private GraphicsPath GetFigurePath(RectangleF rec, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rec.X, rec.Y, radius, radius, 180, 90);
            path.AddArc(rec.Width - radius, rec.Y, radius, radius, 270, 90);
            path.AddArc(rec.Width - radius, rec.Height - radius, radius, radius, 0, 90);
            path.AddArc(rec.X, rec.Height - radius, radius, radius, 90, 90);


            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF recSur = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF recBor = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);
            if (BorderRadius > 2)
            {
                using (GraphicsPath pathSur = GetFigurePath(recSur, BorderRadius))
                using (GraphicsPath pathBor = GetFigurePath(recBor, BorderRadius))
                using (Pen penSur = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(BorderColor, BorderSize))
                {
                    penBorder.Alignment = PenAlignment.Center;
                    this.Region = new Region(pathSur);
                    e.Graphics.DrawPath(penSur, pathSur);
                    if (BorderSize > 1)
                    {
                        e.Graphics.DrawPath(penBorder, pathBor);
                    }
                }




            }
            else
            {
                this.Region = new Region(recSur);
                if (BorderSize >= 1)
                {
                    using (Pen Border = new Pen(BorderColor, BorderSize))
                    {
                        Border.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(Border, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_Backcolorchanged);
        }

        private void Container_Backcolorchanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }


        public void ClickHanlder(object sender, EventArgs e)
        {
            if (clickedBool)
            {
                Color a= this.BackColor;
                this.BackColor = clikedColor;
                clikedColor = a;

            }
        }
    }
}
