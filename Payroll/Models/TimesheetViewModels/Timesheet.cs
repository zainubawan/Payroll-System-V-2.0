using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models.TimesheetViewModels
{
    public class Timesheet
    {
        public long Id { get; set; }
        public double HoursWorked { get; set; }
        public string Status { get; set; }
    }
}
