using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class Contract
    {
        // TODO: Foreign key with employee
        public int ID { get; set; }
        public string Employer { get; set; }
        public double HourlyRate { get; set; }
    }
}
