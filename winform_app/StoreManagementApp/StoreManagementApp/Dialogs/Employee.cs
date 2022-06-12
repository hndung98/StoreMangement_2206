using StoreManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreManagementApp.Dialogs
{
    public partial class Employee : Form
    {
        public string Title = "";
        public List<ControlGroup> lstManagers = new List<ControlGroup>();
        public List<ControlGroup> lstProvinces = new List<ControlGroup>();
        public List<ControlGroup> lstDistricts = new List<ControlGroup>();
        public List<ControlGroup> lstWards = new List<ControlGroup>();

        public AppServices services;
        public Employee()
        {
            InitializeComponent();
        }

        public void setInfo()
        {
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
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

        private void tbxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
    }
}
