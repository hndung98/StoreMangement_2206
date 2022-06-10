using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace StoreManagementApp.Services
{
    public class AppServices
    {
        public string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database2"].ConnectionString;
        public SqlConnection conn = null;

        public AppServices()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        ~AppServices()
        {
        }

        public DataTable PullData(string query)
        {
            DataTable dataTable = new DataTable();

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dataTable);

            da.Dispose();

            List<string> lst = dataTable.AsEnumerable().Select(x => x.Field<string>("StoreName")).ToList();

            return dataTable;
        }

        public List<ControlGroup> GetControls(string code)
        {
            string query = String.Format("SELECT * FROM TBL_Control WHERE ControlGroup = N'{0}'", code);

            DataTable dataTable = new DataTable();

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dataTable);

            da.Dispose();

            List<ControlGroup> lst = dataTable.AsEnumerable().Select(x => new ControlGroup(x.Field<Byte>("ControlValue"), x.Field<string>("ControlName"))).ToList();

            return lst;
        }

        public List<string> GetManagers()
        {
            var lstManagers = new List<string>();
            lstManagers.Add("HN Dung - 1");
            lstManagers.Add("HN Hung - 5");
            lstManagers.Add("HN Phat - 12");

            return lstManagers;
        }
        public List<string> GetStores()
        {
            var lstStores = new List<string>();
            lstStores.Add("Store 1 - 1");
            lstStores.Add("Store 2 - 2");
            lstStores.Add("Store 3 - 3");

            return lstStores;
        }
        public List<string> GetEmployeeTypes()
        {
            var lstTypes = new List<string>();
            lstTypes.Add("Admin - 1");
            lstTypes.Add("Manager - 2");
            lstTypes.Add("Employee - 3");

            return lstTypes;
        }

        public List<string> GetGenders()
        {
            var lstGenders = new List<string>();
            lstGenders.Add("Nam - 1");
            lstGenders.Add("Nữ - 2");
            lstGenders.Add("Khác - 3");

            return lstGenders;
        }

        public List<string> GetItemTypes()
        {
            var lstTypes = new List<string>();
            lstTypes.Add("Đồ ăn - 1");
            lstTypes.Add("Đồ uống - 2");
            lstTypes.Add("Khác - 3");

            return lstTypes;
        }

        public List<string> GetProvinces()
        {
            var lstProvinces = new List<string>();
            lstProvinces.Add("TP Hồ Chí Minh - 1");
            lstProvinces.Add("Sài Gòn - 2");

            return lstProvinces;
        }

        public List<string> GetDistricts(string province)
        {
            var lstDistricts = new List<string>();
            lstDistricts.Add("District 1 - 1");
            lstDistricts.Add("District 2 - 2");
            lstDistricts.Add("District 3 - 3");
            lstDistricts.Add("District 4 - 4");
            lstDistricts.Add("District 5 - 5");

            return lstDistricts;
        }

        public List<string> GetWards(string province)
        {
            var lstWards = new List<string>();
            lstWards.Add("Ward 1 - 1");
            lstWards.Add("Ward 2 - 2");
            lstWards.Add("Ward 3 - 3");
            lstWards.Add("Ward 4 - 4");
            lstWards.Add("Ward 5 - 5");

            return lstWards;
        }
    }
    public class ControlGroup
    {
        public ControlGroup()
        {
        }
        public ControlGroup(Byte value, string name)
        {
            this.value = value;
            this.name = name;
        }
        public Byte value;
        public string name;
    }
}
