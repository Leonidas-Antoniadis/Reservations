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
        public async Task<IActionResult> Index(bool flag)
        {
            List<Reservations> res = new List<Reservations>();
            if(flag == true)
            {
                res = _context.Reservations.Include(r => r.ApplicationUser).Include(r => r.table).Include(r => r.table.shop).Where(r => r.table.shop.UserId == userManager.GetUserId(HttpContext.User)).OrderBy(r => r.date).ToList();
                
                return View(res);
            }
            
            string id = userManager.GetUserId(HttpContext.User);
            var user = await userManager.FindByIdAsync(id);          
            var tmp1 = await userManager.GetRolesAsync(user);
            
            if (tmp1.Contains("Shop"))
            {
                DateTime date = DateTime.Now;
                TimeSpan span = TimeSpan.FromHours(12);
                TimeSpan span2 = TimeSpan.FromHours(-12);
                res =  _context.Reservations.Include(r => r.ApplicationUser).Include(r => r.table).Include(r => r.table.shop).Where(r => r.table.shop.UserId == userManager.GetUserId(HttpContext.User)).OrderBy(r => r.date).ToList();
                res = res.Where(res => res.date.Subtract((DateTime)date) <= span && res.date.Subtract((DateTime)date) >= span2).ToList();
                
                return View(res);
            }

            res = _context.Reservations.Include(r => r.ApplicationUser).Include(r => r.table).Where(f => f.ApplicationUser.Id == userManager.GetUserId(HttpContext.User)).OrderBy(r => r.date).ToList();
            return  View(res);
        }
        
            public  JsonResult isFree(int? shopid, DateTime? date,int? people)
        {
            var tables = _context.Table.Where(s => s.shopID == shopid).ToList();
         
            TimeSpan span = TimeSpan.FromHours(2);
            TimeSpan span2 = TimeSpan.FromHours(-2);
            DateTime dateTime = DateTime.Now;
            var reservations =  _context.Reservations.Include(r => r.table).Include(r => r.table.shop).Where(r => r.table.shop.ID == shopid).ToList();
            if(dateTime.Subtract((DateTime)date) <= TimeSpan.FromHours(4))
            {
                reservations = reservations.Where(res => res.date.Subtract((DateTime)date) <= span && res.date.Subtract((DateTime)date) >= span2 || res.table.Available == false).ToList();
            }
            else
            {
                reservations = reservations.Where(res => res.date.Subtract((DateTime)date) <= span && res.date.Subtract((DateTime)date) >= span2).ToList();
            }
          return  Json(reservations);
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
                .Include(r => r.table.shop)
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

            return Json(reservation); 
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
