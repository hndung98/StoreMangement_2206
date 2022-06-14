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
            tbxEmail.Text = data.Email;
            dtpOpenningDate.Text = data.OpenningDate;
            dtpClosingDate.ShowCheckBox = true;
            tbxDetails.Text = data.Details;

            dtpOpenningDate.MinDate = new DateTime(DateTime.Now.Year, 01, 01);
            dtpOpenningDate.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);

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
                dtpClosingDate.Value = new DateTime(2900, 12, 31);
                dtpClosingDate.Enabled = false;
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
            if (dtpClosingDate.ShowCheckBox == true && dtpClosingDate.Checked == true)
            {
                data.ClosingDate = dtpClosingDate.Text;
            }
            else
            {
                data.ClosingDate = "''";
            }
            MessageBox.Show(dtpClosingDate.Text);
            return;
            data.StoreName = string.IsNullOrEmpty(tbxStoreName.Text) ? "''" : tbxStoreName.Text;
            data.PhoneNumber = string.IsNullOrEmpty(tbxPhoneNumber.Text) ? "0" : tbxPhoneNumber.Text;
            data.Email = string.IsNullOrEmpty(tbxEmail.Text) ? "''" : tbxEmail.Text;
            data.Manager = string.IsNullOrEmpty(cbxManager.Text) ? "0" : cbxManager.Text;
            data.RentalCost = string.IsNullOrEmpty(tbxRentalCost.Text) ? "0" : tbxRentalCost.Text;
            data.OpenningDate = string.IsNullOrEmpty(dtpOpenningDate.Text) ? "''" : dtpOpenningDate.Text;
            data.Province = string.IsNullOrEmpty(cbxProvince.Text) ? "0" : cbxProvince.Text.Replace(" - ","-").Split('-')[1];
            data.District = string.IsNullOrEmpty(cbxDistrict.Text) ? "0" : cbxDistrict.Text.Replace(" - ", "-").Split('-')[1];
            data.Ward = string.IsNullOrEmpty(cbxWard.Text) ? "0" : cbxWard.Text.Replace(" - ", "-").Split('-')[1];
            data.Details = string.IsNullOrEmpty(tbxDetails.Text) ? "''" : tbxDetails.Text;

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

            string msg = services.AddStore(data);

            MessageBox.Show(msg);

            //this.DialogResult = DialogResult.OK;
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
