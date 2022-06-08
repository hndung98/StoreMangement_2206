using System.Collections.Generic;

namespace StoreManagementApp.Services
{
    public static class AppServices
    {
        public static List<string> GetManagers()
        {
            var lstManagers = new List<string>();
            lstManagers.Add("HN Dung - 1");
            lstManagers.Add("HN Hung - 5");
            lstManagers.Add("HN Phat - 12");

            return lstManagers;
        }
        public static List<string> GetStores()
        {
            var lstStores = new List<string>();
            lstStores.Add("Store 1 - 1");
            lstStores.Add("Store 2 - 2");
            lstStores.Add("Store 3 - 3");

            return lstStores;
        }
        public static List<string> GetEmployeeTypes()
        {
            var lstTypes = new List<string>();
            lstTypes.Add("Admin - 1");
            lstTypes.Add("Manager - 2");
            lstTypes.Add("Employee - 3");

            return lstTypes;
        }

        public static List<string> GetGenders()
        {
            var lstGenders = new List<string>();
            lstGenders.Add("Nam - 1");
            lstGenders.Add("Nữ - 2");
            lstGenders.Add("Khác - 3");

            return lstGenders;
        }

        public static List<string> GetItemTypes()
        {
            var lstTypes = new List<string>();
            lstTypes.Add("Đồ ăn - 1");
            lstTypes.Add("Đồ uống - 2");
            lstTypes.Add("Khác - 3");

            return lstTypes;
        }

        public static List<string> GetProvinces()
        {
            var lstProvinces = new List<string>();
            lstProvinces.Add("TP Hồ Chí Minh - 1");
            lstProvinces.Add("Sài Gòn - 2");

            return lstProvinces;
        }

        public static List<string> GetDistricts(string province)
        {
            var lstDistricts = new List<string>();
            lstDistricts.Add("District 1 - 1");
            lstDistricts.Add("District 2 - 2");
            lstDistricts.Add("District 3 - 3");
            lstDistricts.Add("District 4 - 4");
            lstDistricts.Add("District 5 - 5");

            return lstDistricts;
        }

        public static List<string> GetWards(string province)
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
}
