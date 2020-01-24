using EmpDeptSample.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDeptSample.classes
{
   public class Department
    {
        public Department(int deptNo, string deptName, string location)
        {
            DeptNo = deptNo;
            DeptName = deptName;
            Location = location;
            ListOfDeparmentEmployees = new List<Employee>();

           // ListofLocationsInsideDataClass = EmpDeptViewModel.ListofLocationsInsideViewModel;
        }

        public int DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
        public List<Employee> ListOfDeparmentEmployees { get; set; }

       // public List<Location> ListofLocationsInsideDataClass { get; set; }
    }
}
