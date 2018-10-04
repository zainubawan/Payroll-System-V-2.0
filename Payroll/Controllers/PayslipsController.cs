using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Payroll.Models;

namespace Payroll.Controllers
{
    public class PayslipsController : Controller
    {
        private readonly PayrollContext _context;

        public PayslipsController(PayrollContext context)
        {
            _context = context;
        }

        // GET: Payslips
        public async Task<IActionResult> Index()
        {
            return View(await _context.Payslip.ToListAsync());
        }

        // GET: Payslips/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payslip = await _context.Payslip
                .SingleOrDefaultAsync(m => m.ID == id);
            if (payslip == null)
            {
                return NotFound();
            }

            return View(payslip);
        }

        // GET: Payslips/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Payslips/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OwnerId,ID,Status,totalHoursWorked,totalEarnings")] Payslip payslip)
        {
            if (ModelState.IsValid)
            {
                _context.Add(payslip);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(payslip);
        }

        // GET: Payslips/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payslip = await _context.Payslip.SingleOrDefaultAsync(m => m.ID == id);
            if (payslip == null)
            {
                return NotFound();
            }
            return View(payslip);
        }

        // POST: Payslips/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OwnerId,ID,Status,totalHoursWorked,totalEarnings")] Payslip payslip)
        {
            if (id != payslip.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(payslip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PayslipExists(payslip.ID))
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
            return View(payslip);
        }

        // GET: Payslips/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payslip = await _context.Payslip
                .SingleOrDefaultAsync(m => m.ID == id);
            if (payslip == null)
            {
                return NotFound();
            }

            return View(payslip);
        }

        // POST: Payslips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var payslip = await _context.Payslip.SingleOrDefaultAsync(m => m.ID == id);
            _context.Payslip.Remove(payslip);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PayslipExists(int id)
        {
            return _context.Payslip.Any(e => e.ID == id);
        }
    }
}
