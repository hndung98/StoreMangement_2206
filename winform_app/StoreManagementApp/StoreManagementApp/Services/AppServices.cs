using StoreManagementApp.Modals;
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

        public List<IdName> GetIdName(string tableName, string conditionField, string conditionValue, string fId, string fName)
        {

            string query = String.Format("SELECT * FROM {0} WHERE {1} = N'{2}'", tableName, conditionField, conditionValue);

            DataTable dataTable = new DataTable();

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dataTable);

            da.Dispose();

            List<IdName> lst = dataTable.AsEnumerable().Select(x => new IdName(x.Field<int>(fId), x.Field<string>(fName))).ToList();

            return lst;
        }

        public List<IdName> GetIdName(string tableName, string fId, string fName)
        {

            string query = String.Format("SELECT * FROM {0}", tableName);

            DataTable dataTable = new DataTable();

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dataTable);

            da.Dispose();

            List<IdName> lst = dataTable.AsEnumerable().Select(x => new IdName(x.Field<int>(fId), x.Field<string>(fName))).ToList();

            return lst;
        }

        public List<IdName> GetStores()
        {
            return GetIdName("TBL_Store", "StoreID", "StoreName");
        }

        public List<IdName> GetEmployeeByStore(string StoreId)
        {
            return GetIdName("TBL_Employee", "StoreId", StoreId, "EmployeeID", "EmployeeName");
        }

        public int AddStore(StoreData data)
        {
            SqlCommand cmd = new SqlCommand("addStore", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StoreName", data.StoreName);
            cmd.Parameters.AddWithValue("@PhoneNumber", data.PhoneNumber);
            cmd.Parameters.AddWithValue("@Email", data.Email);
            cmd.Parameters.AddWithValue("@ManagerID", data.Manager);
            cmd.Parameters.AddWithValue("@RentalCost", data.RentalCost);
            cmd.Parameters.AddWithValue("@OpenningDate", data.OpenningDate);
            cmd.Parameters.AddWithValue("@ClosingDate", data.ClosingDate);
            cmd.Parameters.AddWithValue("@Province", data.Province);
            cmd.Parameters.AddWithValue("@District", data.District);
            cmd.Parameters.AddWithValue("@Ward", data.Ward);
            cmd.Parameters.AddWithValue("@Details", data.Details);

            int rowAffected = cmd.ExecuteNonQuery();

            return rowAffected;
        }

        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
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

    public class IdName
    {
        public IdName() { }
        public IdName(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int id;
        public string name;
    }
}
