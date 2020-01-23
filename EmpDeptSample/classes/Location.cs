using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDeptSample.classes
{
    public class Location
    {
        public Location(int locationId, string locationName)
        {
            LocationId = locationId;
            LocationName = locationName;
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
    }
}
