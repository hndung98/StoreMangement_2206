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
                dialog.Title = "Thêm cửa hàng";

                dialog.services = services;
                dialog.setInfo();
                dialog.ShowDialog();

                var res = dialog.DialogResult;
                if (res == DialogResult.OK)
                {
                    MessageBox.Show(dialog.StoreName + dialog.PhoneNumber + dialog.RentalCost);
                }
                else if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancel");
                }
            }
        }

        private void btnEditStore_Click(object sender, EventArgs e)
        {
            using (Store dialog = new Store())
            {
                dialog.Title = "Cập nhật cửa hàng";
                dialog.StoreName = "Quan An 1";
                dialog.PhoneNumber = "035 777 2123";
                dialog.RentalCost = "10 000 000";

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

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (Employee dialog = new Employee())
            {
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
