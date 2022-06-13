using StoreManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreManagementApp.Dialogs
{
    public partial class Store : Form
    {
        public string Title = "";
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

        public List<ControlGroup> lstManagers = new List<ControlGroup>();
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
            tbxStoreName.Text = StoreName;
            tbxPhoneNumber.Text = PhoneNumber;
            tbxRentalCost.Text = RentalCost;

            lstProvinces = services.GetControls("Province");

            foreach (var item in lstManagers)
            {
                //cbxManager.Items.Add(item);
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
            StoreName = tbxStoreName.Text;
            PhoneNumber = tbxPhoneNumber.Text;
            Email = tbxEmail.Text;
            Manager = cbxManager.Text;
            RentalCost = tbxRentalCost.Text;
            OpenningDate = dtpOpenningDate.Text;
            ClosingDate = dtpClosingDate.Text;
            Province = string.IsNullOrEmpty(cbxProvince.Text) ? string.Empty : cbxProvince.Text.Replace(" - ","-").Split('-')[1];
            District = string.IsNullOrEmpty(cbxDistrict.Text) ? string.Empty : cbxDistrict.Text.Replace(" - ", "-").Split('-')[1];
            Ward = string.IsNullOrEmpty(cbxWard.Text) ? string.Empty : cbxWard.Text.Replace(" - ", "-").Split('-')[1];
            Detail = tbxDetails.Text;

            MessageBox.Show(StoreName + "\n" +
                "PhoneNumber: " + PhoneNumber + "\n" +
                "Email: " + Email + "\n" +
                "Manager: " + Manager + "\n" +
                "RentalCost: " + RentalCost + "\n" +
                "OpenningDate: " + OpenningDate + "\n" +
                "ClosingDate: " + ClosingDate + "\n" +
                "Province: " + Province + "\n" +
                "District: " + District + "\n" +
                "Ward: " + Ward + "\n" +
                "Detail: " + Detail + "\n" +
                ""
                );

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
