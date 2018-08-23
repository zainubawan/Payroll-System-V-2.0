using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class Timesheet
    {
        public int ID { get; set; }
        //public int EmployeeID { get; set; }
        public string Status { get; set; }
        public double HoursWorked { get; set; }
    }
}
