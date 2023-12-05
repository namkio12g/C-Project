using Bunifu.UI.WinForms;
using ClotheShop.Class;
using ClotheShop.Class.BLL;
using ClotheShop.Class.DTO;
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
    public partial class RoleForm : Form
    {
        private string function = "";
        public RoleForm()
        {
            InitializeComponent();
            loadData();
            loadAuthority();

        }
        void loadAuthority()
        {
            if (SessionClass.Instance.List_action.IndexOf(7) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                BrandChangedBt.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(10) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                CategoryBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(16) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                AccountBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(19) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                BillBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(4) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                UserBtChanged.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(14) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                addButton.Visible = false;
            }
            if (SessionClass.Instance.List_action.IndexOf(15) == -1 && SessionClass.Instance.UserRole1 != 0)
            {
                EditButton.Visible = false;
                DeleteButton.Visible = false;

            }
        }
        private void RoleForm_Load(object sender, EventArgs e)
        {
            idDetail.Text = "";
            saveBt.Visible = false;


            enabledTextbox(false);




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = (int)row.Cells["ID"].Value;


                showProductDetail(RoleBLL.Instance.getProductById(id));
                UserBLL.Instance.GetUserListByRole(id, AccountListDGV);
                RoleBLL.Instance.getAuthorityByRole(id, ActionListDGV);
                saveBt.Visible = false;

            }
        }
        private void enabledTextbox(bool flag)
        {
            nameDetail.EnableText = flag;

            if (function == "edit")
            {
                ActiveDetail.Enabled = true;
            }
            else
            {
                ActiveDetail.Enabled = false;

            }





        }
        private void showProductDetail(Role role)
        {
            nameDetail.Texts = role.Name;
            idDetail.Visible = true;
            idDetail.Text = role.Id.ToString();

            ActiveDetail.Text = role.Active.ToString();
            function = "";
            //if (pd.Image.Length == 0)
            //{
            //    imageProductDetail.Image = null;
            //}
            //else
            //{
            //    using (var ms = new MemoryStream(pd.Image))
            //    {
            //        imageProductDetail.Image = Image.FromStream(ms);
            //    }
            //}
            enabledTextbox(false);
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
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


        private void saveBt_Click(object sender, EventArgs e)
        {
            string name = nameDetail.Texts;
            bool flag;
            if (function == "add")
            {
                flag = !RoleBLL.Instance.insertRole(name);
            }
            else
            {
                int id = Convert.ToInt32(idDetail.Text);
                int active = Convert.ToInt32(ActiveDetail.SelectedItem.ToString());
                flag = !RoleBLL.Instance.UpdateRole(id, active, name);
            }
            if (flag)
            {
                RJMessageBox.Show("Action Failed!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                RJMessageBox.Show("Successful!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            saveBt.Visible = flag;


            enabledTextbox(flag);
            loadData();





        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //imageProductDetail.Image = null;
            nameDetail.Texts = "";
            idDetail.Text = "";
            this.ActionListDGV.DataSource = "";
            AccountListDGV.DataSource = "";
            enabledTextbox(true);
            saveBt.Visible = true;
            function = "add";
        }


        //private void checkSearchDate_Click(object sender, EventArgs e)
        //{
        //    bool b = checkSearchDate.Checked;
        //    dateTimePickerBot.Enabled = b;
        //    dateTimePickerTop.Enabled = b;
        //}

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (idDetail.Text != "")
            {
                function = "edit";
                enabledTextbox(true);
                saveBt.Visible = true;

            }
            else
            {
                RJMessageBox.Show("please select product! ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void loadData()
        {
            dataGridView1.DataSource = RoleBLL.Instance.GetDataTable();

        }
        //private void DeleteButton_Click(object sender, EventArgs e)
        //{
        //    if (idDetail.Text != "")
        //    {
        //        MessageBox.Show(ProductBLL.Instance.DeleteProduct(idDetail.Text).ToString());
        //        imageProductDetail.Image = null;
        //        nameDetail.Texts = "";
        //        idDetail.Text = "";
        //        createdTimeDetail.Value = DateTime.Today;
        //        editedTimeDetail.Value = DateTime.Today;
        //        CCCDDetail.Texts = "";
        //        PhoneDetail.Texts = "";
        //        RoleDetail.Text = "";
        //        CategoryDetail.Text = "";
        //        QuantityDetail.Texts = "";
        //        AddressDetail.Texts = "";
        //        DescriptionDetail.Text = "";
        //        enabledTextbox(false);
        //        loadData();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Pls select a product");
        //    }
        //}

        private void searchButton_Click(object sender, EventArgs e)
        {

            string name = NameSearchTxt.Texts;


            string id = IdSearchTxt.Texts;

            dataGridView1.DataSource = RoleBLL.Instance.GetDataTableSearched(id, name, ActiveChB.Checked);

        }



        private void imageProductDetail_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("changed");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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


        private void ProductFormBtChanged_Click(object sender, EventArgs e)
        {
            ProductFormBtChanged.ClickHanlder(sender, e);
            loadForm(new ProductViewForm());
        }
        private void UserViewFormBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new UserViewForm());
        }

        private void BillBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new BillViewForm());
        }

        private void AccountBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new AccountViewForm());
        }

        private void RoleBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new RoleForm());
        }

        private void CategoryBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new CategoryViewForm());
        }

        private void BrandBtChanged_Click(object sender, EventArgs e)
        {
            loadForm(new BrandViewForm());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (idDetail.Text.ToString() != "")
            {
                RoleBLL.Instance.Delete(Convert.ToInt32(idDetail.Text.ToString()));
                RJMessageBox.Show("Successful ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idDetail.Text = "";
                nameDetail.Texts = "";
                AccountListDGV.DataSource = "";
                AccountListDGV.DataSource = "";
                enabledTextbox(false);

                loadData();
            }

            else
                RJMessageBox.Show("Plesase select a Role! ", "Something missing", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
    }
}
