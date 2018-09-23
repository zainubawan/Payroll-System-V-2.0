using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Payroll.Models;

namespace Payroll.Models
{
    public class PayrollContext : DbContext
    {
        public PayrollContext(DbContextOptions<PayrollContext> options)
            : base(options)
        {
        }

        public DbSet<Timesheet> Timesheet { get; set; }

        public DbSet<Contract> Contract { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Timesheet>()
                .Property(b => b.Status)
                .HasDefaultValue("Pending");
        }
    }
}
