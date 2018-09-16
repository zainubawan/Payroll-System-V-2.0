using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Payroll.Migrations
{
    public partial class AddDaysToTimesheets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Fri",
                table: "Timesheet",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Mon",
                table: "Timesheet",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Sat",
                table: "Timesheet",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Sun",
                table: "Timesheet",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Thur",
                table: "Timesheet",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Tue",
                table: "Timesheet",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Wed",
                table: "Timesheet",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fri",
                table: "Timesheet");

            migrationBuilder.DropColumn(
                name: "Mon",
                table: "Timesheet");

            migrationBuilder.DropColumn(
                name: "Sat",
                table: "Timesheet");

            migrationBuilder.DropColumn(
                name: "Sun",
                table: "Timesheet");

            migrationBuilder.DropColumn(
                name: "Thur",
                table: "Timesheet");

            migrationBuilder.DropColumn(
                name: "Tue",
                table: "Timesheet");

            migrationBuilder.DropColumn(
                name: "Wed",
                table: "Timesheet");
        }
    }
}
