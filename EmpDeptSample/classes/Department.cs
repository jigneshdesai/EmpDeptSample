using EmpDeptSample.models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDeptSample.classes
{
   public class Department : BindableBase
    {

        private string _location;
        public Department(int pdeptNo, string pdeptName, string plocation)
        {
            DeptNo = pdeptNo;
            DeptName = pdeptName;
            Location = plocation;
            ListOfDeparmentEmployees = new List<Employee>();

           // ListofLocationsInsideDataClass = EmpDeptViewModel.ListofLocationsInsideViewModel;
        }

        public int DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Location {
            get { return this._location; }
            set { this.SetProperty(ref this._location, value); }
        }
        public List<Employee> ListOfDeparmentEmployees { get; set; }

       // public List<Location> ListofLocationsInsideDataClass { get; set; }
    }
}
