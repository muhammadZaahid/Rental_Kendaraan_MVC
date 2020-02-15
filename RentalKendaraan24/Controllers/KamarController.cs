using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UAS_20170140120_DeckyAprianto.Models;

namespace UAS_20170140120_DeckyAprianto.Controllers
{
    public class KamarController : Controller
    {
        private readonly UASPAWContext _context;

        public KamarController(UASPAWContext context)
        {
            _context = context;
        }

        // GET: Kamar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kamar.ToListAsync());
        }

        // GET: Kamar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kamar = await _context.Kamar
                .FirstOrDefaultAsync(m => m.IdKamar == id);
            if (kamar == null)
            {
                return NotFound();
            }

            return View(kamar);
        }

        // GET: Kamar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kamar/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdKamar,TypeKamar,NoKamar,Lantai,Biaya,Status")] Kamar kamar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kamar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kamar);
        }

        // GET: Kamar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kamar = await _context.Kamar.FindAsync(id);
            if (kamar == null)
            {
                return NotFound();
            }
            return View(kamar);
        }

        // POST: Kamar/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdKamar,TypeKamar,NoKamar,Lantai,Biaya,Status")] Kamar kamar)
        {
            if (id != kamar.IdKamar)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kamar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KamarExists(kamar.IdKamar))
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
            return View(kamar);
        }

        // GET: Kamar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kamar = await _context.Kamar
                .FirstOrDefaultAsync(m => m.IdKamar == id);
            if (kamar == null)
            {
                return NotFound();
            }

            return View(kamar);
        }

        // POST: Kamar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kamar = await _context.Kamar.FindAsync(id);
            _context.Kamar.Remove(kamar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KamarExists(int id)
        {
            return _context.Kamar.Any(e => e.IdKamar == id);
        }
    }
}
