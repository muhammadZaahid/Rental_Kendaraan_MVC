using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UAS_20170140120_DeckyAprianto.Models;
using Microsoft.AspNetCore.Authorization;

namespace UAS_20170140120_DeckyAprianto.Controllers
{
    public class ReservasiController : Controller
    {
        private readonly UASPAWContext _context;

        public ReservasiController(UASPAWContext context)
        {
            _context = context;
        }

        [Authorize(Policy = "readonlypolicy")]

        // GET: Reservasi
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, int? pageNumber, string reservasi, string search)
        {
            //buat list menyimpan ketersediaan
            var reservasiList = new List<string>();

            //query untuk mengambil data
            var ktsQuery = from d in _context.Reservasi orderby d.NamaCustomer select d.Alamat;
            reservasiList.AddRange(ktsQuery.Distinct());

            //menampilkan data kedalam dropdwont list
            ViewBag.costomer = new SelectList(reservasiList);

            //untuk mengambil semua data
            var menu = from m in _context.Reservasi.Include(c => c.IdRoomserviceNavigation) select m;
            if (!string.IsNullOrEmpty(reservasi))
            {
                menu = menu.Where(x => x.NamaCustomer == reservasi);
            }

            //untuk memuat sort
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["DateSortParm2"] = sortOrder == "Cek" ? "Out" : "Cek";

            switch (sortOrder)
            {
                case "name_desc":
                    menu = menu.OrderByDescending(s => s.NamaCustomer);
                    break;
                case "Date":
                    menu = menu.OrderBy(s => s.TglCekin);
                    break;
                case "date_desc":
                    menu = menu.OrderByDescending(s => s.TglCekin);
                    break;
                case "Cek":
                    menu = menu.OrderBy(s => s.TglCekout);
                    break;
                case "Out":
                    menu = menu.OrderByDescending(s => s.TglCekout);
                    break;
                default: //name ascending
                    menu = menu.OrderBy(s => s.NamaCustomer);
                    break;
            }

            //untuk membuat paged list
            ViewData["CurrentSort"] = sortOrder;

            if (search != null)
            {
                pageNumber = 1;
            }
            else
            {
                search = currentFilter;
            }
            ViewData["CurrentFilter"] = search;

            //return View(await menu.ToListAsync());

            int pageSize = 4;
            return View(await PaginatedList<Reservasi>.CreateAsync(menu.AsNoTracking(), pageNumber ?? 1, pageSize));

            //var uASPAWContext = _context.Reservasi.Include(r => r.IdKamar1Navigation).Include(r => r.IdKamarNavigation).Include(r => r.IdMakananNavigation).Include(r => r.IdRoomserviceNavigation);
            //return View(await uASPAWContext.ToListAsync());
        }

        // GET: Reservasi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservasi = await _context.Reservasi
                .Include(r => r.IdKamar1Navigation)
                .Include(r => r.IdKamarNavigation)
                .Include(r => r.IdMakananNavigation)
                .Include(r => r.IdRoomserviceNavigation)
                .FirstOrDefaultAsync(m => m.IdReservasi == id);
            if (reservasi == null)
            {
                return NotFound();
            }

            return View(reservasi);
        }

        [Authorize(Policy = "writepolicy")]

        // GET: Reservasi/Create
        public IActionResult Create()
        {
            ViewData["IdKamar1"] = new SelectList(_context.Kamar, "IdKamar", "IdKamar");
            ViewData["IdKamar"] = new SelectList(_context.Kamar, "IdKamar", "IdKamar");
            ViewData["IdMakanan"] = new SelectList(_context.Makanan, "IdMakanan", "IdMakanan");
            ViewData["IdRoomservice"] = new SelectList(_context.RoomService, "IdRoomservice", "IdRoomservice");
            return View();
        }

        // POST: Reservasi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdReservasi,NamaCustomer,Alamat,NoHp,TanggalLahir,JenisKelamin,JumlahTamu,TglCekin,TglCekout,Haripermalam,IdKamar1,IdKamar,Lantai,BiayaKamar,IdMakanan,BanyakMakanan,HargaMakanan,IdRoomservice,BanyakHari,HargaService,Total,CreditCard,NoCc,Status")] Reservasi reservasi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservasi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdKamar1"] = new SelectList(_context.Kamar, "IdKamar", "IdKamar", reservasi.IdKamar1);
            ViewData["IdKamar"] = new SelectList(_context.Kamar, "IdKamar", "IdKamar", reservasi.IdKamar);
            ViewData["IdMakanan"] = new SelectList(_context.Makanan, "IdMakanan", "IdMakanan", reservasi.IdMakanan);
            ViewData["IdRoomservice"] = new SelectList(_context.RoomService, "IdRoomservice", "IdRoomservice", reservasi.IdRoomservice);
            return View(reservasi);
        }

        [Authorize(Policy = "editpolicy")]

        // GET: Reservasi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservasi = await _context.Reservasi.FindAsync(id);
            if (reservasi == null)
            {
                return NotFound();
            }
            ViewData["IdKamar1"] = new SelectList(_context.Kamar, "IdKamar", "IdKamar", reservasi.IdKamar1);
            ViewData["IdKamar"] = new SelectList(_context.Kamar, "IdKamar", "IdKamar", reservasi.IdKamar);
            ViewData["IdMakanan"] = new SelectList(_context.Makanan, "IdMakanan", "IdMakanan", reservasi.IdMakanan);
            ViewData["IdRoomservice"] = new SelectList(_context.RoomService, "IdRoomservice", "IdRoomservice", reservasi.IdRoomservice);
            return View(reservasi);
        }

        // POST: Reservasi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdReservasi,NamaCustomer,Alamat,NoHp,TanggalLahir,JenisKelamin,JumlahTamu,TglCekin,TglCekout,Haripermalam,IdKamar1,IdKamar,Lantai,BiayaKamar,IdMakanan,BanyakMakanan,HargaMakanan,IdRoomservice,BanyakHari,HargaService,Total,CreditCard,NoCc,Status")] Reservasi reservasi)
        {
            if (id != reservasi.IdReservasi)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservasi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservasiExists(reservasi.IdReservasi))
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
            ViewData["IdKamar1"] = new SelectList(_context.Kamar, "IdKamar", "IdKamar", reservasi.IdKamar1);
            ViewData["IdKamar"] = new SelectList(_context.Kamar, "IdKamar", "IdKamar", reservasi.IdKamar);
            ViewData["IdMakanan"] = new SelectList(_context.Makanan, "IdMakanan", "IdMakanan", reservasi.IdMakanan);
            ViewData["IdRoomservice"] = new SelectList(_context.RoomService, "IdRoomservice", "IdRoomservice", reservasi.IdRoomservice);
            return View(reservasi);
        }

        [Authorize(Policy = "deletepolicy")]

        // GET: Reservasi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservasi = await _context.Reservasi
                .Include(r => r.IdKamar1Navigation)
                .Include(r => r.IdKamarNavigation)
                .Include(r => r.IdMakananNavigation)
                .Include(r => r.IdRoomserviceNavigation)
                .FirstOrDefaultAsync(m => m.IdReservasi == id);
            if (reservasi == null)
            {
                return NotFound();
            }

            return View(reservasi);
        }

        // POST: Reservasi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservasi = await _context.Reservasi.FindAsync(id);
            _context.Reservasi.Remove(reservasi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservasiExists(int id)
        {
            return _context.Reservasi.Any(e => e.IdReservasi == id);
        }
    }
}
