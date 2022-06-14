using StoreManagementApp.Modals;
using StoreManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreManagementApp.Dialogs
{
    public partial class Store : Form
    {
        public byte mode = 0; // Add = 1, Edit = 2
        public string Title = "";
        public StoreData data = new StoreData();

        public List<IdName> lstManagers = new List<IdName>();
        public List<ControlGroup> lstProvinces = new List<ControlGroup>();
        public List<ControlGroup> lstDistricts = new List<ControlGroup>();
        public List<ControlGroup> lstWards = new List<ControlGroup>();

        public AppServices services;

        public Store()
        {
            InitializeComponent();
        }

        public void setInfo()
        {
            lblTitle.Text = Title;
            tbxStoreName.Text = data.StoreName;
            tbxPhoneNumber.Text = data.PhoneNumber;
            tbxRentalCost.Text = data.RentalCost;

            lstProvinces = services.GetControls("Province");
            lstManagers = services.GetEmployeeByStore("1");

            if (mode == 2)
            {
                foreach (var item in lstManagers)
                {
                    cbxManager.Items.Add(item.name + " - " + item.id);
                }
            }
            else
            {
                cbxManager.Enabled = false;
            }
            foreach (var item in lstProvinces)
            {
                cbxProvince.Items.Add(item.name + " - " + item.value);
            }
        }

        private void setDistricts(string province)
        {
            lstDistricts.Clear();
            lstWards.Clear();
            cbxDistrict.Items.Clear();
            cbxWard.Items.Clear();

            lstDistricts = services.GetControls(province);

            foreach (var item in lstDistricts)
            {
                cbxDistrict.Items.Add(item.name + " - " + item.value);
            }
        }

        private void setWards(string district)
        {
            lstWards.Clear();
            cbxWard.Items.Clear();

            lstWards = services.GetControls(district);

            foreach (var item in lstWards)
            {
                cbxWard.Items.Add(item.name + " - " + item.value);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            data.StoreName = string.IsNullOrEmpty(tbxStoreName.Text) ? null : tbxStoreName.Text;
            data.PhoneNumber = string.IsNullOrEmpty(tbxPhoneNumber.Text) ? null : tbxPhoneNumber.Text;
            data.Email = string.IsNullOrEmpty(tbxEmail.Text) ? null : tbxEmail.Text;
            data.Manager = string.IsNullOrEmpty(cbxManager.Text) ? "0" : cbxManager.Text;
            data.RentalCost = string.IsNullOrEmpty(tbxRentalCost.Text) ? null : tbxRentalCost.Text;
            data.OpenningDate = string.IsNullOrEmpty(dtpOpenningDate.Text) ? null : dtpOpenningDate.Text;
            data.ClosingDate = string.IsNullOrEmpty(dtpClosingDate.Text) ? null : dtpClosingDate.Text;
            data.Province = string.IsNullOrEmpty(cbxProvince.Text) ? string.Empty : cbxProvince.Text.Replace(" - ","-").Split('-')[1];
            data.District = string.IsNullOrEmpty(cbxDistrict.Text) ? string.Empty : cbxDistrict.Text.Replace(" - ", "-").Split('-')[1];
            data.Ward = string.IsNullOrEmpty(cbxWard.Text) ? string.Empty : cbxWard.Text.Replace(" - ", "-").Split('-')[1];
            data.Details = string.IsNullOrEmpty(tbxDetails.Text) ? null : tbxDetails.Text;

            //MessageBox.Show(
            //    "StoreName: <" + data.StoreName + ">\n" +
            //    "PhoneNumber: <" + data.PhoneNumber + ">\n" +
            //    "Email: <" + data.Email + ">\n" +
            //    "Manager: <" + data.Manager + ">\n" +
            //    "RentalCost: <" + data.RentalCost + ">\n" +
            //    "OpenningDate: <" + data.OpenningDate + ">\n" +
            //    "ClosingDate: <" + data.ClosingDate + ">\n" +
            //    "Province: <" + data.Province + ">\n" +
            //    "District: <" + data.District + ">\n" +
            //    "Ward: <" + data.Ward + ">\n" +
            //    "Detail: <" + data.Details + ">\n" +
            //    ""
            //    );

            int rowAffected = services.AddStore(data);

            MessageBox.Show(rowAffected + "....");

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void tbxRentalCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void cbxProvince_TextChanged(object sender, EventArgs e)
        {
            var strArray = cbxProvince.SelectedItem.ToString().Replace(" - ", "-").Split('-');
            setDistricts(strArray[0]);
        }

        private void cbxDistrict_TextChanged(object sender, EventArgs e)
        {
            var strArray = cbxDistrict.SelectedItem.ToString().Replace(" - ", "-").Split('-');
            setWards(strArray[0]);
        }

        private void dtpOpenningDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtpClosingDate_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
