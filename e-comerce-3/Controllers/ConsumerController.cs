#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using e_comerce_3.Models;

namespace e_comerce_3.Controllers
{
    public class ConsumerController : Controller
    {
        private readonly MyDbContext _context;

        public ConsumerController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Consumer
        public async Task<IActionResult> Index()
        {
            return View(await _context.Consumer.ToListAsync());
        }

        // GET: Consumer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consumer = await _context.Consumer
                .FirstOrDefaultAsync(m => m.id == id);
            if (consumer == null)
            {
                return NotFound();
            }

            return View(consumer);
        }

        // GET: Consumer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Consumer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,phone,email,cpf")] Consumer consumer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consumer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consumer);
        }

        // GET: Consumer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consumer = await _context.Consumer.FindAsync(id);
            if (consumer == null)
            {
                return NotFound();
            }
            return View(consumer);
        }

        // POST: Consumer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,phone,email,cpf")] Consumer consumer)
        {
            if (id != consumer.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consumer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsumerExists(consumer.id))
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
            return View(consumer);
        }

        // GET: Consumer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consumer = await _context.Consumer
                .FirstOrDefaultAsync(m => m.id == id);
            if (consumer == null)
            {
                return NotFound();
            }

            return View(consumer);
        }

        // POST: Consumer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consumer = await _context.Consumer.FindAsync(id);
            _context.Consumer.Remove(consumer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsumerExists(int id)
        {
            return _context.Consumer.Any(e => e.id == id);
        }
    }
}
