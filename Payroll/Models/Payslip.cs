using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class Payslip
    {
        public string OwnerId { set; get; }
        public int ID { get; set; }
        public string Status { get; set; }
        public int totalHoursWorked { get; set; }
        public int totalEarnings { get; set; }
    }
}
