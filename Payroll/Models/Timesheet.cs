using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class Timesheet
    {
        public string OwnerId { set; get; }
        public int ID { get; set; }
        public string Status { get; set; }
        public double HoursWorked { get; set; }
        public double Mon { get; set; }
        public double Tue { get; set; }
        public double Wed { get; set; }
        public double Thur { get; set; }
        public double Fri { get; set; }
        public double Sat { get; set; }
        public double Sun { get; set; }
    }
}
