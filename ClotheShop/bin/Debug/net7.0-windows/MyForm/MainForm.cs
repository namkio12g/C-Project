using ClotheShop.CustomControl;
using ClotheShop.MyForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClotheShop
{
    public partial class MainForm : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public MainForm()
        {
            InitializeComponent();
        }
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);

        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            mainPanel.Tag = form;
            form.Show();
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            customButton1.ClickHanlder(sender, e);
            loadForm(new ProductViewForm());
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            customButton1.ClickHanlder(sender, e);
            loadForm(new CreateBillForm());
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            customButton1.ClickHanlder(sender, e);
            loadForm(new ActionViewForm());
        }
    }
}
