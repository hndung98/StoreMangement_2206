using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementApp.Modals
{
    public class Tables
    {
    }

    public class StoreData
    {
        public StoreData()
        {
            this.StoreName = null;
            this.PhoneNumber = null;
            this.Email = null;
            this.Manager = null;
            this.RentalCost = null;
            this.OpenningDate = null;
            this.ClosingDate = null;
            this.Province = null;
            this.District = null;
            this.Ward = null;
            this.Details = null;
        }
        public StoreData(string StoreName, string PhoneNumber, string Email, string Manager, 
            string RentalCost, string OpenningDate, string ClosingDate, string Province, 
            string District, string Ward, string Details)
        {
            this.StoreName = StoreName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Manager = Manager;
            this.RentalCost = RentalCost;
            this.OpenningDate = OpenningDate;
            this.ClosingDate = ClosingDate;
            this.Province = Province;
            this.District = District;
            this.Ward = Ward;
            this.Details = Details;
        }
        public string StoreName;
        public string PhoneNumber;
        public string Email;
        public string Manager;
        public string RentalCost;
        public string OpenningDate;
        public string ClosingDate;
        public string Province;
        public string District;
        public string Ward;
        public string Details;
    }

    public class EmployeeData
    {
        public EmployeeData() { }
        public EmployeeData(string Store, string EmployeeType, string EmployeeName, 
            string Gender, string Birthday, string PhoneNumber, string StartingDate, 
            string Salary, string Username, string Password, string Email,
            string Province, string District, string Ward, string Details)
        {
            this.Store = Store;
            this.EmployeeType = EmployeeType;
            this.EmployeeName = EmployeeName;
            this.Gender = Gender;
            this.Birthday = Birthday;
            this.PhoneNumber = PhoneNumber;
            this.StartingDate = StartingDate;
            this.Salary = Salary;
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
            this.Province = Province;
            this.District = District;
            this.Ward = Ward;
            this.Details = Details;
        }
        public string Store;
        public string EmployeeType;
        public string EmployeeName;
        public string Gender;
        public string Birthday;
        public string PhoneNumber;
        public string StartingDate;
        public string Salary;
        public string Username;
        public string Password;
        public string Email;
        public string Province;
        public string District;
        public string Ward;
        public string Details;
    }
}
