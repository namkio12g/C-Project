using Bunifu.UI.WinForms;
using ClotheShop.Class;
using ClotheShop.Class.BLL;
using ClotheShop.Class.DTO;
using ClotheShop.MyForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClotheShop.CustomControl
{
    public partial class ProductSearchForm : Form
    {
        private string function = "";
        public string ReturnValue

        {
            get; set;
        }
        public event EventHandler<CustomEventArgs> ButtonClicked;


        public ProductSearchForm()
        {
            InitializeComponent();
            ProductBLL.Instance.GetDataTable(dataGridView1);

        }

        private void ProductViewForm_Load(object sender, EventArgs e)
        {
            CreatedbyDetail.EnableText = false;
            idDetail.Text = "";

            editedbyDetail.EnableText = false;
            BrandBLL.Instance.loadBrandCombobox(brandDetail);
            BrandBLL.Instance.loadBrandCombobox(BrandSearch);
            CategoryBLL.Instance.getCategoryCombobox(CategoryDetail);
            CategoryBLL.Instance.getCategoryCombobox(CategorySearch);
            enabledTextbox(false);



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = (int)row.Cells["ID"].Value;


                showProductDetail(ProductBLL.Instance.getProductById(id));


            }
        }
        private void enabledTextbox(bool flag)
        {
            nameDetail.EnableText = flag;
            uploadImageBt.Enabled = flag;
            brandDetail.Enabled = flag;
            CategoryDetail.Enabled = flag;
            QuantityDetail.EnableText = flag;
            priceDetail.EnableText = flag;
            DescriptionDetail.Enabled = flag;
            AddBillBt.Visible = false;
            customTextBox1.Texts = "";

            if (function == "edit")
            {
                ActiveDetail.Enabled = true;
            }
            else
            {
                ActiveDetail.Enabled = false;
            }





        }
        private void showProductDetail(Product pd)
        {
            nameDetail.Texts = pd.Name;
            idDetail.Visible = true;
            idDetail.Text = pd.Id.ToString();
            createdTimeDetail.Value = pd.Created_date;
            editedTimeDetail.Value = pd.Edited_date;
            editedbyDetail.Texts = pd.Edited_by;
            CreatedbyDetail.Texts = pd.Created_by;
            brandDetail.Text = pd.Brand;
            CategoryDetail.Text = pd.Category;
            QuantityDetail.Texts = pd.Quantity.ToString();
            priceDetail.Texts = pd.Price.ToString();
            DescriptionDetail.Text = pd.Description;
            ActiveDetail.Text = pd.Active.ToString();
            if (pd.Image.Length == 0)
            {
                imageProductDetail.Image = null;
            }
            else
            {
                using (var ms = new MemoryStream(pd.Image))
                {
                    imageProductDetail.Image = Image.FromStream(ms);
                }
            }

            enabledTextbox(false);
            AddBillBt.Visible = SessionClass.Instance.CreatingBillFlag;

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PriceBottom.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            PriceTop.Text = trackBar2.Value.ToString();
        }

        private void bunifuRange1_RangeChanged(object sender, EventArgs e)
        {
            if (priceRange.RangeMin > priceRange.MaximumRange - 20000)
            {
                priceRange.RangeMin = priceRange.MaximumRange - 20000;
            }
            Rangeco.Text = string.Format("${0} - ${1}", priceRange.RangeMin, priceRange.RangeMax);
        }

        private void bunifuRange1_Load(object sender, EventArgs e)
        {
            Rangeco.Text = string.Format("${0} - ${1}", priceRange.RangeMin, priceRange.RangeMax);
        }

        private void bunifuRange2_RangeChanged(object sender, EventArgs e)
        {
            if (quantityRange.RangeMin > quantityRange.MaximumRange - 50)
            {
                quantityRange.RangeMin = quantityRange.MaximumRange - 50;
            }
            QuantityLabel.Text = string.Format("{0} - {1}", quantityRange.RangeMin, quantityRange.RangeMax);
        }

        private void uploadImageBt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opd = new OpenFileDialog()
            {
                Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg",
                Multiselect = false,
                Title = "Select an Image File"
            })
            {
                if (opd.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = opd.FileName;
                    imageProductDetail.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void customTextBox3_Load(object sender, EventArgs e)
        {

        }

        private void bunifuRange2_Load(object sender, EventArgs e)
        {
            QuantityLabel.Text = string.Format("{0} - {1}", quantityRange.RangeMin, quantityRange.RangeMax);

        }





        private void checkSearchDate_Click(object sender, EventArgs e)
        {
            bool b = checkSearchDate.Checked;
            dateTimePickerBot.Enabled = b;
            dateTimePickerTop.Enabled = b;
        }


        private void loadData()
        {
            ProductBLL.Instance.GetDataTable(dataGridView1);

        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (idDetail.Text != "")
            {

                imageProductDetail.Image = null;
                nameDetail.Texts = "";
                idDetail.Text = "";
                createdTimeDetail.Value = DateTime.Today;
                editedTimeDetail.Value = DateTime.Today;
                editedbyDetail.Texts = "";
                CreatedbyDetail.Texts = "";
                brandDetail.Text = "";
                CategoryDetail.Text = "";
                QuantityDetail.Texts = "";
                priceDetail.Texts = "";
                DescriptionDetail.Text = "";
                enabledTextbox(false);
                loadData();
            }
            else
            {
                MessageBox.Show("Pls select a product");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string timeTop = "";
            string timeBot = "";
            if (checkSearchDate.Checked)
            {
                timeTop = dateTimePickerTop.Value.ToString("yyyy-MM-dd");
                timeBot = dateTimePickerBot.Value.ToString("yyyy-MM-dd");
            }
            int brand = -1;
            int category = -1;
            if (CategorySearch.SelectedIndex > -1)
            {
                category = ((Category)CategorySearch.SelectedItem).Id;

            }
            if (BrandSearch.SelectedIndex > -1)
            {
                brand = ((Brand)BrandSearch.SelectedItem).Id;

            }
            int active = 0;
            string name = nameSearchTextbox.Texts;
            string topPrice = priceRange.RangeMax.ToString();
            string botPrice = priceRange.RangeMin.ToString();
            string topQuan = quantityRange.RangeMax.ToString();
            string botQuan = quantityRange.RangeMin.ToString();
            ProductBLL.Instance.GetDataTableSearched(dataGridView1, IdSearchTextbox, name, brand, category, botPrice, topPrice, botQuan, topQuan, timeTop, timeBot, false);

        }



        private void imageProductDetail_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("changed");
        }
        private void loadForm(object Form)
        {
            Form form = Form as Form;
            Control parentcontroll = this.Parent;
            this.Dispose();
            form.TopLevel = false;
            form.Parent = parentcontroll;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if (idDetail.Text != "")
            {
                Control parentcontroll = this.Parent;
                this.ReturnValue = idDetail.Text;
            }

        }
        private void AddBillBt_Click(object sender, EventArgs e)
        {
            string value = idDetail.Text;
            string quantity = customTextBox1.Texts;

            ButtonClicked?.Invoke(this, new CustomEventArgs(value, quantity));
        }

        private void CloseBt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
