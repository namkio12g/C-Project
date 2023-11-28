using ClotheShop.Class.BLL;
using ClotheShop.Class.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClotheShop.MyForm
{
    public partial class ActionViewForm : Form
    {
        private List<Role> roles ; // Replace with your actual data retrieval logic
        private List<Class.DTO.ActionObject> allActions ; // Replace with your actual data retrieval logic
        private List<ActionDetail> roleActionDetails ; // Replace with your actual data retrieval logic
        private class ActionRolePair
        {
            public ActionObject Action
            {
                get;
            }
            public Role Role
            {
                get;
            }

            public ActionRolePair(ActionObject action, Role role)
            {
                Action = action;
                Role = role;
            }

            public override string ToString()
            {
                return Action.Name; // Adjust as needed for display
            }
        }
        public ActionViewForm()
        {
            InitializeComponent();


        }
        private void InitializeUI()
        {
            foreach (var role in roles)
            {
                var groupBox = new GroupBox
                {
                    Text = role.Name,
                    Font= new Font("Arial", 10, FontStyle.Regular),
                    Location = new System.Drawing.Point(10, 10),
                    Size = new System.Drawing.Size(panel1.Width-20, panel1.Height-20)
                };

                var actionsCheckBoxList = new CheckedListBox
                {
                    Location = new System.Drawing.Point(10, 20),
                    Size = new System.Drawing.Size(panel1.Width - 70, panel1.Height - 70)
                };

                // Filter actions based on the current role
                var actionsForRole = roleActionDetails
                    .Where(rd => rd.IdRole == role.Id)
                    .Select(rd => rd.IdAction)
                    .ToList();

                //actionsCheckBoxList.Items.AddRange(allActions.Where(action => actionsForRole.Contains(action.Id)).ToArray());

                // Load selected actions for the current role
                foreach (var action in allActions)
                {
                    actionsCheckBoxList.Items.Add(new ActionRolePair(action, role), actionsForRole.Contains(action.Id));
                }
                actionsCheckBoxList.ItemCheck += ActionsCheckBoxList_ItemCheck;
                groupBox.Controls.Add(actionsCheckBoxList);
                panel1.Controls.Add(groupBox);
            }

        }
        private void ActionsCheckBoxList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Handle the ItemCheck event
            var checkedListBox = (CheckedListBox)sender;
            var selectedPair = (ActionRolePair)checkedListBox.Items[e.Index];

            if (e.NewValue == CheckState.Checked)
            {
                // The checkbox is being checked, update your data accordingly
                UpdateData(selectedPair.Action, selectedPair.Role, true);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // The checkbox is being unchecked, update your data accordingly
                UpdateData(selectedPair.Action, selectedPair.Role, false);
            }
        }

        private void UpdateData(ActionObject selectedAction, Role selectedRole, bool isChecked)
        {
            ActionBLL.Instance.UpdateActionDetail(selectedAction.Id,selectedRole.Id,isChecked);
        }

        private void ActionViewForm_Load(object sender, EventArgs e)
        {
            RoleBLL.Instance.getRoleCombobox(RoleCombobox);
        }

        private void RoleCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(RoleCombobox.SelectedIndex > -1 && RoleCombobox.SelectedValue.ToString() == "-1")
            {
                panel1.Controls.Clear();
                RoleCombobox.Focus();
            }
            else
            {
                int roleid = ((Role)RoleCombobox.SelectedItem).Id;
                roles = RoleBLL.Instance.GetOneRole(roleid); // Replace with your actual data retrieval logic
                allActions = ActionBLL.Instance.GetListAction(); // Replace with your actual data retrieval logic
                roleActionDetails = ActionBLL.Instance.GetListActionDetailOneRole(roleid); // Replace with your actual data retrieval logic
                panel1.Controls.Clear();
                InitializeUI();

            }
        }
    }
}
