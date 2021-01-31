using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Controllers
{
    public class PolaganjaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PolaganjaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Polaganja
        [Authorize]
        public async Task<IActionResult> Index(string search)
        {
            if (!String.IsNullOrEmpty(search))
            {
                var polaganja = from Polaganje in _context.Polaganje
                                select Polaganje;
                polaganja = polaganja.Where(Polaganje => Polaganje.Naziv.Contains(search));
                return View(polaganja.ToList());
            }
            return View(await _context.Polaganje.ToListAsync());
        }

        // GET: Polaganja/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var polaganje = await _context.Polaganje
                .FirstOrDefaultAsync(m => m.Id == id);
            if (polaganje == null)
            {
                return NotFound();
            }

            return View(polaganje);
        }

        // GET: Polaganja/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Polaganja/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImeStudenta,ImeProfesora,Naziv,Polozio")] Polaganje polaganje)
        {
            if (ModelState.IsValid)
            {
                _context.Add(polaganje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(polaganje);
        }

        // GET: Polaganja/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var polaganje = await _context.Polaganje.FindAsync(id);
            if (polaganje == null)
            {
                return NotFound();
            }
            return View(polaganje);
        }

        // POST: Polaganja/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImeStudenta,ImeProfesora,Naziv,Polozio")] Polaganje polaganje)
        {
            if (id != polaganje.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(polaganje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PolaganjeExists(polaganje.Id))
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
            return View(polaganje);
        }

        // GET: Polaganja/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var polaganje = await _context.Polaganje
                .FirstOrDefaultAsync(m => m.Id == id);
            if (polaganje == null)
            {
                return NotFound();
            }

            return View(polaganje);
        }

        // POST: Polaganja/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var polaganje = await _context.Polaganje.FindAsync(id);
            _context.Polaganje.Remove(polaganje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PolaganjeExists(int id)
        {
            return _context.Polaganje.Any(e => e.Id == id);
        }
    }
}
