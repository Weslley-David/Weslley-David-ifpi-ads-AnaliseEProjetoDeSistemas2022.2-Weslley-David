#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using car_online.Models;

namespace car_online.Controllers
{
    public class CarVersionController : Controller
    {
        private readonly MyDbContext _context;

        public CarVersionController(MyDbContext context)
        {
            _context = context;
        }

        // GET: CarVersion
        public async Task<IActionResult> Index()
        {
            return View(await _context.CarVersion.ToListAsync());
        }

        // GET: CarVersion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carVersion = await _context.CarVersion
                .FirstOrDefaultAsync(m => m.id == id);
            if (carVersion == null)
            {
                return NotFound();
            }

            return View(carVersion);
        }

        // GET: CarVersion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarVersion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,description")] CarVersion carVersion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carVersion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carVersion);
        }

        // GET: CarVersion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carVersion = await _context.CarVersion.FindAsync(id);
            if (carVersion == null)
            {
                return NotFound();
            }
            return View(carVersion);
        }

        // POST: CarVersion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,description")] CarVersion carVersion)
        {
            if (id != carVersion.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carVersion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarVersionExists(carVersion.id))
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
            return View(carVersion);
        }

        // GET: CarVersion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carVersion = await _context.CarVersion
                .FirstOrDefaultAsync(m => m.id == id);
            if (carVersion == null)
            {
                return NotFound();
            }

            return View(carVersion);
        }

        // POST: CarVersion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carVersion = await _context.CarVersion.FindAsync(id);
            _context.CarVersion.Remove(carVersion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarVersionExists(int id)
        {
            return _context.CarVersion.Any(e => e.id == id);
        }
    }
}
