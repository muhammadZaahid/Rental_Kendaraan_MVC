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
    public class RoomServiceController : Controller
    {
        private readonly UASPAWContext _context;

        public RoomServiceController(UASPAWContext context)
        {
            _context = context;
        }

        // GET: RoomService
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoomService.ToListAsync());
        }

        // GET: RoomService/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomService = await _context.RoomService
                .FirstOrDefaultAsync(m => m.IdRoomservice == id);
            if (roomService == null)
            {
                return NotFound();
            }

            return View(roomService);
        }

        // GET: RoomService/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomService/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdRoomservice,PaketService,HargaPerservice")] RoomService roomService)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roomService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomService);
        }

        // GET: RoomService/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomService = await _context.RoomService.FindAsync(id);
            if (roomService == null)
            {
                return NotFound();
            }
            return View(roomService);
        }

        // POST: RoomService/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdRoomservice,PaketService,HargaPerservice")] RoomService roomService)
        {
            if (id != roomService.IdRoomservice)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomServiceExists(roomService.IdRoomservice))
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
            return View(roomService);
        }

        // GET: RoomService/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomService = await _context.RoomService
                .FirstOrDefaultAsync(m => m.IdRoomservice == id);
            if (roomService == null)
            {
                return NotFound();
            }

            return View(roomService);
        }

        // POST: RoomService/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roomService = await _context.RoomService.FindAsync(id);
            _context.RoomService.Remove(roomService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomServiceExists(int id)
        {
            return _context.RoomService.Any(e => e.IdRoomservice == id);
        }
    }
}
