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

        public List<string> lstManagers = new List<string>();
        public List<string> lstProvinces = new List<string>();
        public List<string> lstDistricts = new List<string>();
        public List<string> lstWards = new List<string>();

        public Store()
        {
            InitializeComponent();

            lstManagers = AppServices.GetManagers();
            lstProvinces = AppServices.GetProvinces();

            setInfo();
        }

        public void setInfo()
        {
            lblTitle.Text = Title;
            tbxStoreName.Text = StoreName;
            tbxPhoneNumber.Text = PhoneNumber;
            tbxRentalCost.Text = RentalCost;

            foreach (var item in lstManagers)
            {
                cbxManager.Items.Add(item);
            }
            foreach (var item in lstProvinces)
            {
                cbxProvince.Items.Add(item);
            }
        }

        private void setDistricts(string province)
        {
            lstDistricts.Clear();
            lstWards.Clear();
            cbxDistrict.Items.Clear();
            cbxWard.Items.Clear();

            lstDistricts = AppServices.GetDistricts(province);

            foreach (var item in lstDistricts)
            {
                cbxDistrict.Items.Add(item);
            }
        }

        private void setWards(string district)
        {
            lstWards.Clear();
            cbxWard.Items.Clear();

            lstWards = AppServices.GetWards(district);

            foreach (var item in lstWards)
            {
                cbxWard.Items.Add(item);
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
            Province = cbxProvince.Text;
            District = cbxDistrict.Text;
            Ward = cbxWard.Text;
            Detail = tbxDetails.Text;

            MessageBox.Show(StoreName + "-\n" +
                PhoneNumber + "-\n" +
                Email + "-\n" +
                Manager + "-\n" +
                RentalCost + "-\n" +
                OpenningDate + "-\n" +
                ClosingDate + "-\n" +
                Province + "-\n" +
                District + "-\n" +
                Ward + "-\n" +
                Detail + "-\n" +
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
