﻿using StoreManagementApp.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementApp
{
    public partial class MainScreen : Form
    {
        string connectionString = string.Empty;

        SqlConnection conn = null;

        DataTable dtStore = new DataTable();
        DataTable dtItem = new DataTable();
        DataTable dtCustomer = new DataTable();
        DataTable dtEmployee = new DataTable();

        public MainScreen()
        {
            InitializeComponent();
        }

        ~MainScreen()
        {
            conn.Close();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database"].ConnectionString;

            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        // your method to pull data from database to datatable   
        public DataTable PullData(string query)
        {
            // your data table
            DataTable dataTable = new DataTable();

            SqlCommand cmd = new SqlCommand(query, conn);

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dataTable);

            da.Dispose();

            return dataTable;
        }

        private void btnReloadStore_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TBL_Store";

            DataTable dt = PullData(query);

            dgvStoreInquiry.DataSource = dt;
        }

        private void btnReloadItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TBL_StoreItem";

            DataTable dt = PullData(query);

            dgvItemInquiry.DataSource = dt;
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            using (Store dialog = new Store())
            {
                var managerList = new List<string>();
                managerList.Add("HN Dung - 1");
                managerList.Add("HN Hung - 5");
                managerList.Add("HN Phat - 12");

                dialog.StoreName = "Quan An 1";
                dialog.PhoneNumber = "035 241 2123";
                dialog.RentalCost = "10,000,000";
                dialog.managerList = managerList;
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
                var managerList = new List<string>();
                managerList.Add("HN Dung - 1");
                managerList.Add("HN Hung - 5");
                managerList.Add("HN Phat - 12");

                dialog.StoreName = "Quan An 1";
                dialog.PhoneNumber = "035 241 2123";
                dialog.RentalCost = "10,000,000";
                dialog.managerList = managerList;
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
    }
}