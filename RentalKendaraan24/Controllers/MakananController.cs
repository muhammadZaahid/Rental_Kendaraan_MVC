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
    public class MakananController : Controller
    {
        private readonly UASPAWContext _context;

        public MakananController(UASPAWContext context)
        {
            _context = context;
        }

        // GET: Makanan
        public async Task<IActionResult> Index()
        {
            return View(await _context.Makanan.ToListAsync());
        }

        // GET: Makanan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makanan = await _context.Makanan
                .FirstOrDefaultAsync(m => m.IdMakanan == id);
            if (makanan == null)
            {
                return NotFound();
            }

            return View(makanan);
        }

        // GET: Makanan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Makanan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMakanan,PaketMakanan,HargaPermakanan")] Makanan makanan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(makanan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(makanan);
        }

        // GET: Makanan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makanan = await _context.Makanan.FindAsync(id);
            if (makanan == null)
            {
                return NotFound();
            }
            return View(makanan);
        }

        // POST: Makanan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMakanan,PaketMakanan,HargaPermakanan")] Makanan makanan)
        {
            if (id != makanan.IdMakanan)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(makanan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MakananExists(makanan.IdMakanan))
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
            return View(makanan);
        }

        // GET: Makanan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makanan = await _context.Makanan
                .FirstOrDefaultAsync(m => m.IdMakanan == id);
            if (makanan == null)
            {
                return NotFound();
            }

            return View(makanan);
        }

        // POST: Makanan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var makanan = await _context.Makanan.FindAsync(id);
            _context.Makanan.Remove(makanan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MakananExists(int id)
        {
            return _context.Makanan.Any(e => e.IdMakanan == id);
        }
    }
}
