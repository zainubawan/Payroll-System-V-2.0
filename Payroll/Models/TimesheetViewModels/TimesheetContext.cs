using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Payroll.Models.TimesheetViewModels
{
    public class TimesheetContext: DbContext
    {
        public TimesheetContext(DbContextOptions<TimesheetContext> options): base(options)
        {
        }

        public DbSet<Timesheet> Timesheets { get; set; }
    }
}
