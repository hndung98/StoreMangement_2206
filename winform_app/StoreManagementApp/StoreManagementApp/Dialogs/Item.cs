using StoreManagementApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementApp.Dialogs
{
    public partial class Item : Form
    {
        public string Title = "";
        public string ItemType = "";
        public string ItemUnit = "";
        public string ItemName = "";
        public string Supplier = "";
        public string Cost = "";
        public string SuggestedPrice = "";

        public List<ControlGroup> lstItemTypes = new List<ControlGroup>();
        public List<ControlGroup> lstItemUnits = new List<ControlGroup>();
        public List<ControlGroup> lstSuppliers = new List<ControlGroup>();

        public AppServices services;

        public Item()
        {
            InitializeComponent();
        }

        public void setInfo()
        {
            lblTitle.Text = Title;
            tbxItemName.Text = ItemName;

            lstItemTypes = services.GetControls("ItemType");
            lstItemUnits = services.GetControls("ItemUnit");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void tbxSuggestedPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
    }
}
