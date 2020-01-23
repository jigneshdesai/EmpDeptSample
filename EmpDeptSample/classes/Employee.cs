using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDeptSample.classes
{
    public class Employee
    {
        public Employee(int empNo, string empName, int jobID, string job)
        {
            EmpNo = empNo;
            EmpName = empName;
            JobID = jobID;
            Job = job;
        }

        public int EmpNo { get; set; }
        public string EmpName { get; set; }

        public int JobID { get; set; }
        public string Job { get; set; }
       
    }
}
