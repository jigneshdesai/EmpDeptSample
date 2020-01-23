using EmpDeptSample.classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDeptSample.models
{
    public class EmpDeptViewModel
    {
        private ObservableCollection<Department> _instanceOfDepartmentData;
        public ObservableCollection<Department> InstanceOfDepartmentData
        {
            get { return _instanceOfDepartmentData; }
            set { _instanceOfDepartmentData = value; }
        }



        public static List<Location> ListofLocationsInsideViewModel { get; set; }

        public EmpDeptViewModel() {

            ListofLocationsInsideViewModel = new List<Location>();
            InstanceOfDepartmentData = new ObservableCollection<Department>();
            FillDummyData();
        }

        public void FillDummyData()
        {
            InstanceOfDepartmentData.Add(new Department(1,"Accounts", "USA"));
            InstanceOfDepartmentData.Add(new Department(2, "HumanResource", "Canada"));
            InstanceOfDepartmentData.Add(new Department(3, "Software", "USA"));

            InstanceOfDepartmentData[0].ListOfDeparmentEmployees.Add(new Employee(1, "Jignesh", 100,"Developer"));
            InstanceOfDepartmentData[0].ListOfDeparmentEmployees.Add(new Employee(2, "Rajesh", 200, "Programmer"));
            InstanceOfDepartmentData[0].ListOfDeparmentEmployees.Add(new Employee(3, "Amar", 100, "Developer"));


            InstanceOfDepartmentData[1].ListOfDeparmentEmployees.Add(new Employee(4, "Rekha", 300, "Manager"));
            InstanceOfDepartmentData[1].ListOfDeparmentEmployees.Add(new Employee(5, "Dipika", 400, "Sales"));


            InstanceOfDepartmentData[2].ListOfDeparmentEmployees.Add(new Employee(6, "David", 500, "Director"));
            InstanceOfDepartmentData[2].ListOfDeparmentEmployees.Add(new Employee(7, "Deik", 600, "CEO"));
            InstanceOfDepartmentData[2].ListOfDeparmentEmployees.Add(new Employee(8, "Paul", 700,"COO"));



            ListofLocationsInsideViewModel.Add(new Location(1,"USA"));
            ListofLocationsInsideViewModel.Add(new Location(2, "Canada"));
            ListofLocationsInsideViewModel.Add(new Location(3, "UK"));
            ListofLocationsInsideViewModel.Add(new Location(4, "China"));
            ListofLocationsInsideViewModel.Add(new Location(5, "India"));

        }




    }
}
