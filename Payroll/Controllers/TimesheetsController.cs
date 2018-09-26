using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Payroll.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Payroll.Data;

namespace Payroll.Controllers
{
    [Authorize]
    public class TimesheetsController : Controller
    {
        private readonly PayrollContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TimesheetsController(PayrollContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Timesheets
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return Challenge();
            }

            // TODO: needs to take a lambda expression and fetch timesheets for a particular user
            var timesheets = await _context.Timesheet
                .Where(m => m.OwnerId == currentUser.Id)
                .ToListAsync(); 

            return View(timesheets);
        }

        // GET: Timesheets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timesheet = await _context.Timesheet
                .SingleOrDefaultAsync(m => m.ID == id);
            if (timesheet == null)
            {
                return NotFound();
            }

            return View(timesheet);
        }

        // GET: Timesheets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Timesheets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Mon,Tue,Wed,Thur,Fri,Sat,Sun,ID,Status,HoursWorked")] Timesheet timesheet)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser == null)
            {
                return RedirectToAction(nameof(Index));
            }

            if (ModelState.IsValid)
            {
                timesheet.OwnerId = currentUser.Id;
                _context.Add(timesheet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(timesheet);
        }

        // GET: Timesheets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timesheet = await _context.Timesheet.SingleOrDefaultAsync(m => m.ID == id);
            if (timesheet == null)
            {
                return NotFound();
            }
            return View(timesheet);
        }

        // POST: Timesheets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Mon,Tue,Wed,Thur,Fri,Sat,Sun,ID,Status,HoursWorked")] Timesheet timesheet)
        {
            if (id != timesheet.ID)
            {
                return NotFound();
            }

            var currentUser = await _userManager.GetUserAsync(User);

            if (ModelState.IsValid)
            {
                try
                {
                    timesheet.OwnerId = currentUser.Id;
                    _context.Update(timesheet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimesheetExists(timesheet.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(timesheet);
        }

        // GET: Timesheets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timesheet = await _context.Timesheet
                .SingleOrDefaultAsync(m => m.ID == id);
            if (timesheet == null)
            {
                return NotFound();
            }

            return View(timesheet);
        }

        // POST: Timesheets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var timesheet = await _context.Timesheet.SingleOrDefaultAsync(m => m.ID == id);
            _context.Timesheet.Remove(timesheet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimesheetExists(int id)
        {
            return _context.Timesheet.Any(e => e.ID == id);
        }
    }
}
