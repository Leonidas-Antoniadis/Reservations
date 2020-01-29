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
using PtixiakiReservations.Models.ViewModels;

namespace PtixiakiReservations.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;
        public ReservationsController(ApplicationDbContext context, UserManager<ApplicationUser> _userManager,RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            userManager = _userManager;
            this.roleManager = roleManager;
        }

        // GET: Reservations        
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reservations.Include(r => r.ApplicationUser).Include(r => r.table).Where(f => f.ApplicationUser.Id == userManager.GetUserId(HttpContext.User));

            string id = userManager.GetUserId(HttpContext.User);
            var user = await userManager.FindByIdAsync(id);          
            var tmp1 = await userManager.GetRolesAsync(user);

            if (tmp1.Contains("shop"))
            {
              //  applicationDbContext = _context.Reservations.Include(r => r.ApplicationUser).Include(r => r.table).Where(f => f.table.UserId == userManager.GetUserId(HttpContext.User));
            }
            return View();
        }
        public List<Reservations> getResTables(int shopid,DateTime date)
        {
            var resTable = _context.Reservations.Where(s => s.date == date);

            return null; 
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations = await _context.Reservations
                .Include(r => r.ApplicationUser)
                .Include(r => r.table)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (reservations == null)
            {
                return NotFound();
            }

            return View(reservations);
        }
       
        public IActionResult Create(int? shopid)
        {


            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(int shopid)
        {
            

            return RedirectToAction("Index", "Table", new { shopid = shopid });
        }

        public async Task<IActionResult> MakeRes(Reservations res)
        {
          
                Reservations reservation = new Reservations
                {
                    people = res.people,
                    date = res.date,
                    tableId = res.tableId,
                    userId = userManager.GetUserId(HttpContext.User)
                };

            _context.Add(reservation);
            await _context.SaveChangesAsync();

            return null;
        }

        // GET: Reservations/Edit/5
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
            return View(reservations);
        }

        // POST: Reservations/Edit/5
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
          //  ViewData["shopId"] = new SelectList(_context.Shops, "ID", "ID", reservations.shopId);
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
               // .Include(r => r.shop)
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
