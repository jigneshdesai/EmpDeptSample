using EmpDeptSample.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDeptSample.models
{
   public class LocationList
    {
        public  List<Location> ListofLocationsInsideViewModel { get; set; }

        public LocationList()
        {
            ListofLocationsInsideViewModel = new List<Location>();
            ListofLocationsInsideViewModel.Add(new Location(1, "USA"));
            ListofLocationsInsideViewModel.Add(new Location(2, "Canada"));
            ListofLocationsInsideViewModel.Add(new Location(3, "UK"));
            ListofLocationsInsideViewModel.Add(new Location(4, "China"));
            ListofLocationsInsideViewModel.Add(new Location(5, "India"));
        }
    }
}
