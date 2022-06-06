using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementApp.Dialog
{
    public partial class Store : Form
    {
        public string StoreName = "";
        public string PhoneNumber = "";
        public string Email = "";
        public string Manager = "";
        public string RentalCost = "";
        public string OpenningDate = "";
        public string ClosingDate = "";
        public string Province = "";
        public string District = "";
        public string Ward = "";
        public string Detail = "";

        public List<string> managerList = new List<string>();

        public Store()
        {
            InitializeComponent();
        }

        public void setInfo()
        {
            tbxStoreName.Text = StoreName;
            tbxPhoneNumber.Text = PhoneNumber;
            tbxRentalCost.Text = RentalCost;
            foreach (var item in managerList)
            {
                cbxManager.Items.Add(item);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StoreName = tbxStoreName.Text;
            PhoneNumber = tbxPhoneNumber.Text;
            RentalCost = tbxRentalCost.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
