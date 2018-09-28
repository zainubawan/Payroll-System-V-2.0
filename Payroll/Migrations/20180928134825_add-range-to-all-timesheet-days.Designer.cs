﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Payroll.Models;
using System;

namespace Payroll.Migrations
{
    [DbContext(typeof(PayrollContext))]
    [Migration("20180928134825_add-range-to-all-timesheet-days")]
    partial class addrangetoalltimesheetdays
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Payroll.Models.Contract", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Employer");

                    b.Property<double>("HourlyRate");

                    b.HasKey("ID");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("Payroll.Models.Timesheet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Fri");

                    b.Property<double>("HoursWorked");

                    b.Property<double>("Mon");

                    b.Property<string>("OwnerId");

                    b.Property<double>("Sat");

                    b.Property<string>("Status")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("Pending");

                    b.Property<double>("Sun");

                    b.Property<double>("Thur");

                    b.Property<double>("Tue");

                    b.Property<double>("Wed");

                    b.HasKey("ID");

                    b.ToTable("Timesheet");
                });
#pragma warning restore 612, 618
        }
    }
}
