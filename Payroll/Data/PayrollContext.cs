using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Payroll.Models
{
    public class PayrollContext : DbContext
    {
        public PayrollContext (DbContextOptions<PayrollContext> options)
            : base(options)
        {
        }

        public DbSet<Payroll.Models.Timesheet> Timesheet { get; set; }
    }
}
