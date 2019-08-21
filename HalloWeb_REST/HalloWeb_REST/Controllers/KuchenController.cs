using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HalloWeb_REST.Models;

namespace HalloWeb_REST.Controllers
{
    public class KuchenController : Controller
    {
        private readonly KuchenContext _context;

        public KuchenController(KuchenContext context)
        {
            _context = context;
        }

        // GET: Kuchen
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kuchen.ToListAsync());
        }

        // GET: Kuchen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kuchen = await _context.Kuchen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kuchen == null)
            {
                return NotFound();
            }

            return View(kuchen);
        }

        // GET: Kuchen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kuchen/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Bewertung,Schoko")] Kuchen kuchen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kuchen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kuchen);
        }

        // GET: Kuchen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kuchen = await _context.Kuchen.FindAsync(id);
            if (kuchen == null)
            {
                return NotFound();
            }
            return View(kuchen);
        }

        // POST: Kuchen/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Bewertung,Schoko")] Kuchen kuchen)
        {
            if (id != kuchen.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kuchen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KuchenExists(kuchen.Id))
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
            return View(kuchen);
        }

        // GET: Kuchen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kuchen = await _context.Kuchen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kuchen == null)
            {
                return NotFound();
            }

            return View(kuchen);
        }

        // POST: Kuchen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kuchen = await _context.Kuchen.FindAsync(id);
            _context.Kuchen.Remove(kuchen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KuchenExists(int id)
        {
            return _context.Kuchen.Any(e => e.Id == id);
        }
    }
}
