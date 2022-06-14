using StoreManagementApp.Dialogs;
using StoreManagementApp.Services;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StoreManagementApp
{
    public partial class MainScreen : Form
    {
        AppServices services;

        public MainScreen()
        {
            InitializeComponent();
        }

        ~MainScreen()
        {
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            services = new AppServices();
        }

        private void btnReloadStore_Click(object sender, EventArgs e)
        {            
            string query = "SELECT * FROM TBL_Store";

            DataTable dt = services.PullData(query);

            dgvStoreInquiry.DataSource = dt;
        }

        private void btnReloadItem_Click(object sender, EventArgs e)
        {
            return;
            string query = "SELECT * FROM TBL_StoreItem";

            DataTable dt = services.PullData(query);

            dgvItemInquiry.DataSource = dt;
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            using (Store dialog = new Store())
            {
                dialog.mode = 1;
                dialog.Title = "Thêm cửa hàng";

                dialog.services = services;
                dialog.setInfo();
                dialog.ShowDialog();

                var res = dialog.DialogResult;
                if (res == DialogResult.OK)
                {
                    //MessageBox.Show(dialog.data.StoreName + dialog.data.PhoneNumber + dialog.data.RentalCost);
                }
                else if (res == DialogResult.Cancel)
                {
                    //MessageBox.Show("Cancel");
                }
            }
        }

        private void btnEditStore_Click(object sender, EventArgs e)
        {
            if (dgvStoreInquiry.SelectedRows.Count > 0)
            {
                var cells = dgvStoreInquiry.SelectedRows[0].Cells;
                using (Store dialog = new Store())
                {
                    dialog.mode = 2;
                    dialog.Title = "Cập nhật cửa hàng";
                    dialog.data.StoreName = (string)cells[1].FormattedValue;
                    dialog.data.PhoneNumber = (string)cells[2].FormattedValue;
                    dialog.data.Email = (string)cells[3].FormattedValue;
                    dialog.data.Manager = (string)cells[4].FormattedValue;
                    dialog.data.RentalCost = (string)cells[5].FormattedValue;
                    dialog.data.OpenningDate = (string)cells[6].FormattedValue;
                    dialog.data.ClosingDate = (string)cells[7].FormattedValue;
                    dialog.data.Province = (string)cells[8].FormattedValue;
                    dialog.data.District = (string)cells[9].FormattedValue;
                    dialog.data.Ward = (string)cells[10].FormattedValue;
                    dialog.data.Details = (string)cells[11].FormattedValue;

                    dialog.services = services;
                    dialog.setInfo();
                    dialog.ShowDialog();

                    var res = dialog.DialogResult;
                    if (res == DialogResult.OK)
                    {
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        MessageBox.Show("Cancel");
                    }
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (Employee dialog = new Employee())
            {
                dialog.mode = 1;
                dialog.Title = "Thêm nhân viên";
                var storeList = new List<string>();

                dialog.services = services;
                dialog.setInfo();
                dialog.ShowDialog();

                var res = dialog.DialogResult;
                if (res == DialogResult.OK)
                {
                    MessageBox.Show("OK");
                }
                else if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancel");
                }
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            using (Employee dialog = new Employee())
            {
                dialog.mode = 2;
                dialog.Title = "Cập nhật nhân viên";
                var storeList = new List<string>();

                dialog.services = services;
                dialog.setInfo();
                dialog.ShowDialog();

                var res = dialog.DialogResult;
                if (res == DialogResult.OK)
                {
                    MessageBox.Show("OK");
                }
                else if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancel");
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using (Item dialog = new Item())
            {
                dialog.mode = 1;
                dialog.Title = "Thêm sản phẩm";
                var storeList = new List<string>();

                dialog.services = services;
                dialog.setInfo();
                dialog.ShowDialog();

                var res = dialog.DialogResult;
                if (res == DialogResult.OK)
                {
                    MessageBox.Show("OK");
                }
                else if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancel");
                }
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            using (Item dialog = new Item())
            {
                dialog.mode = 2;
                dialog.Title = "Cập nhật sản phẩm";
                var storeList = new List<string>();

                dialog.services = services;
                dialog.setInfo();
                dialog.ShowDialog();

                var res = dialog.DialogResult;
                if (res == DialogResult.OK)
                {
                    MessageBox.Show("OK");
                }
                else if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancel");
                }
            }
        }

        private void btnAddStoreItem_Click(object sender, EventArgs e)
        {
            using (StoreItem dialog = new StoreItem())
            {
                dialog.mode = 1;
                dialog.Title = "Thêm sản phẩm";
                var storeList = new List<string>();
                dialog.setInfo();

                dialog.ShowDialog();
                var res = dialog.DialogResult;
                if (res == DialogResult.OK)
                {
                    MessageBox.Show("OK");
                }
                else if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancel");
                }
            }
        }

        private void btnEditStoreItem_Click(object sender, EventArgs e)
        {
            using (StoreItem dialog = new StoreItem())
            {
                dialog.mode = 2;
                dialog.Title = "Cập nhật sản phẩm";
                var storeList = new List<string>();
                dialog.setInfo();

                dialog.ShowDialog();
                var res = dialog.DialogResult;
                if (res == DialogResult.OK)
                {
                    MessageBox.Show("OK");
                }
                else if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancel");
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (Customer dialog = new Customer())
            {
                dialog.mode = 1;
                dialog.Title = "Thêm khách hàng";
                var storeList = new List<string>();

                dialog.services = services;
                dialog.setInfo();
                dialog.ShowDialog();

                var res = dialog.DialogResult;
                if (res == DialogResult.OK)
                {
                    MessageBox.Show("OK");
                }
                else if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancel");
                }
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {

            using (Customer dialog = new Customer())
            {
                dialog.mode = 2;
                dialog.Title = "Cập nhật khách hàng";
                var storeList = new List<string>();

                dialog.services = services;
                dialog.setInfo();
                dialog.ShowDialog();

                var res = dialog.DialogResult;
                if (res == DialogResult.OK)
                {
                    MessageBox.Show("OK");
                }
                else if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancel");
                }
            }
        }
    }
}
