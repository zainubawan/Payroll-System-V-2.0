using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class Timesheet
    {
        public string OwnerId { set; get; }
        public int ID { get; set; }
        public string Status { get; set; }

        [Range(0, 40)]
        public double HoursWorked { get; set; }

        [Range(0, 8)]
        public double Mon { get; set; }

        [Range(0, 8)]
        public double Tue { get; set; }
        
        [Range(0, 8)]
        public double Wed { get; set; }
        
        [Range(0, 8)]
        public double Thur { get; set; }
        
        [Range(0, 8)]
        public double Fri { get; set; }
        
        [Range(0, 8)]
        public double Sat { get; set; }
        
        [Range(0, 8)]
        public double Sun { get; set; }
    }
}
