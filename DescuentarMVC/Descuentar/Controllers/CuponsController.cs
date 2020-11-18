using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Descuentar.Models;

namespace Descuentar.Controllers
{
    public class CuponsController : Controller
    {
        private readonly Context _context;

        public CuponsController(Context context)
        {
            _context = context;
        }

        // GET: Cupons
        public async Task<IActionResult> Index()
        {
            return View(await _context.cupons.ToListAsync());
        }

        // GET: Cupons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupon = await _context.cupons
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cupon == null)
            {
                return NotFound();
            }

            return View(cupon);
        }

        // GET: Cupons/Thanks/5
        public async Task<IActionResult> Thanks(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupon = await _context.cupons
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cupon == null)
            {
                return NotFound();
            }

            return View();
        }

        // GET: Cupons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cupons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,description,companyName,Discount,life,likes")] Cupon cupon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cupon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cupon);
        }

        // GET: Cupons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupon = await _context.cupons.FindAsync(id);
            if (cupon == null)
            {
                return NotFound();
            }
            return View(cupon);
        }

        // POST: Cupons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,description,companyName,Discount,life,likes")] Cupon cupon)
        {
            if (id != cupon.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cupon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CuponExists(cupon.ID))
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
            return View(cupon);
        }

        // GET: Cupons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cupon = await _context.cupons
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cupon == null)
            {
                return NotFound();
            }

            return View(cupon);
        }

        // POST: Cupons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cupon = await _context.cupons.FindAsync(id);
            _context.cupons.Remove(cupon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CuponExists(int id)
        {
            return _context.cupons.Any(e => e.ID == id);
        }
    }
}
