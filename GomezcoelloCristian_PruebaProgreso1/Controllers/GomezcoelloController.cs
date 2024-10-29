using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GomezcoelloCristian_PruebaProgreso1.Data;
using GomezcoelloCristian_PruebaProgreso1.Models;

namespace GomezcoelloCristian_PruebaProgreso1.Controllers
{
    public class GomezcoelloController : Controller
    {
        private readonly GomezcoelloCristian_PruebaProgreso1Context _context;

        public GomezcoelloController(GomezcoelloCristian_PruebaProgreso1Context context)
        {
            _context = context;
        }

        // GET: Gomezcoello
        public async Task<IActionResult> Index()
        {
            var gomezcoelloCristian_PruebaProgreso1Context = _context.Gomezcoello.Include(g => g.Celular);
            return View(await gomezcoelloCristian_PruebaProgreso1Context.ToListAsync());
        }

        // GET: Gomezcoello/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gomezcoello = await _context.Gomezcoello
                .Include(g => g.Celular)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gomezcoello == null)
            {
                return NotFound();
            }

            return View(gomezcoello);
        }

        // GET: Gomezcoello/Create
        public IActionResult Create()
        {
            ViewData["IdCelular"] = new SelectList(_context.Celular, "Id", "Modelo");
            return View();
        }

        // POST: Gomezcoello/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Edad,Hermanos,Direccion,Quiteno,DireccionDate,IdCelular")] Gomezcoello gomezcoello)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gomezcoello);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCelular"] = new SelectList(_context.Celular, "Id", "Modelo", gomezcoello.IdCelular);
            return View(gomezcoello);
        }

        // GET: Gomezcoello/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gomezcoello = await _context.Gomezcoello.FindAsync(id);
            if (gomezcoello == null)
            {
                return NotFound();
            }
            ViewData["IdCelular"] = new SelectList(_context.Celular, "Id", "Modelo", gomezcoello.IdCelular);
            return View(gomezcoello);
        }

        // POST: Gomezcoello/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Edad,Hermanos,Direccion,Quiteno,DireccionDate,IdCelular")] Gomezcoello gomezcoello)
        {
            if (id != gomezcoello.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gomezcoello);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GomezcoelloExists(gomezcoello.Id))
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
            ViewData["IdCelular"] = new SelectList(_context.Celular, "Id", "Modelo", gomezcoello.IdCelular);
            return View(gomezcoello);
        }

        // GET: Gomezcoello/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gomezcoello = await _context.Gomezcoello
                .Include(g => g.Celular)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gomezcoello == null)
            {
                return NotFound();
            }

            return View(gomezcoello);
        }

        // POST: Gomezcoello/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gomezcoello = await _context.Gomezcoello.FindAsync(id);
            if (gomezcoello != null)
            {
                _context.Gomezcoello.Remove(gomezcoello);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GomezcoelloExists(int id)
        {
            return _context.Gomezcoello.Any(e => e.Id == id);
        }
    }
}
