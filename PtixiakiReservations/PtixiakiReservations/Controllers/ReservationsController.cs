using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PtixiakiReservations.Data;
using PtixiakiReservations.Models;

namespace PtixiakiReservations.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservationsController(ApplicationDbContext context, UserManager<ApplicationUser> _userManager)
        {
            _context = context;
            userManager = _userManager;
        }

        // GET: Reservations
        public async Task<IActionResult> Index2()
        {
            string a = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var applicationDbContext = _context.Reservations.Include(r => r.ApplicationUser).Include(r => r.shop).Where(f =>f.ApplicationUser.Id == userManager.GetUserId(HttpContext.User));
            return View(await applicationDbContext.ToListAsync());
        }
        //the shop see reservation
        public async Task<IActionResult> Index()
        {
            string a = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var applicationDbContext = _context.Reservations.Include(r => r.ApplicationUser).Include(r => r.shop).Where(f => f.shop.UserId == userManager.GetUserId(HttpContext.User));
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Reservations1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations = await _context.Reservations
                .Include(r => r.ApplicationUser)
                .Include(r => r.shop)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (reservations == null)
            {
                return NotFound();
            }

            return View(reservations);
        }
        private readonly UserManager<ApplicationUser> userManager;
        // GET: Reservations1/Create
        public IActionResult Create(int? shopid,string? userId)
        {

            ViewData["userId"] = userManager.GetUserId(HttpContext.User);
          if (ViewData["userId"].ToString() != userId)
            {
                return NotFound();
            }

            ViewData["userId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["shopId"] = new SelectList(_context.Shops, "ID", "ID");   
            
            return View();
        }

        // POST: Reservations1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,people,userId,shopId,date")] Reservations reservations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["userId"] = new SelectList(_context.Users, "Id", "Id", reservations.userId);
            ViewData["shopId"] = new SelectList(_context.Shops, "ID", "ID", reservations.shopId);
            return View(reservations);
        }

        // GET: Reservations1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations = await _context.Reservations.FindAsync(id);
            if (reservations == null)
            {
                return NotFound();
            }
            ViewData["userId"] = new SelectList(_context.Users, "Id", "Id", reservations.userId);
            ViewData["shopId"] = new SelectList(_context.Shops, "ID", "ID", reservations.shopId);
            return View(reservations);
        }

        // POST: Reservations1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,people,userId,shopId,date")] Reservations reservations)
        {
            if (id != reservations.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationsExists(reservations.ID))
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
            ViewData["userId"] = new SelectList(_context.Users, "Id", "Id", reservations.userId);
            ViewData["shopId"] = new SelectList(_context.Shops, "ID", "ID", reservations.shopId);
            return View(reservations);
        }

        // GET: Reservations1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations = await _context.Reservations
                .Include(r => r.ApplicationUser)
                .Include(r => r.shop)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (reservations == null)
            {
                return NotFound();
            }

            return View(reservations);
        }

        // POST: Reservations1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservations = await _context.Reservations.FindAsync(id);
            _context.Reservations.Remove(reservations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationsExists(int id)
        {
            return _context.Reservations.Any(e => e.ID == id);
        }
    }
}
