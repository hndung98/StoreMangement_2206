using StoreManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreManagementApp.Dialogs
{
    public partial class Employee : Form
    {
        public byte mode = 0; // Add = 1, Edit = 2
        public string Title = "";
        public string Store = "";
        public string EmployeeType = "";
        public string EmployeeName = "";
        public string Gender = "";
        public string Birthday = "";
        public string PhoneNumber = "";
        public string StartingDate = "";
        public string Salary = "";
        public string Username = "";
        public string Password = "";
        public string Email = "";
        public string Province = "";
        public string District = "";
        public string Ward = "";
        public string Details = "";

        public List<IdName> lstStores = new List<IdName>();
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
            lblTitle.Text = Title;

            lstStores = services.GetStores();
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
