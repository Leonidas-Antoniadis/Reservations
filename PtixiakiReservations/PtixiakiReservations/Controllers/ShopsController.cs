using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PtixiakiReservations.Data;
using PtixiakiReservations.Models;
using PtixiakiReservations.Models.ViewModels;


namespace PtixiakiReservations.Controllers
{
    
    public class ShopsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;

        public IHostingEnvironment HostingEnviromnet;

        
        public ShopsController(ApplicationDbContext context,
                                IHostingEnvironment hostingEnviromnet, UserManager<ApplicationUser> UserManager, RoleManager<ApplicationRole> roleManager)
        {
            this.roleManager = roleManager;
            this.userManager = UserManager;
            _context = context;
            HostingEnviromnet = hostingEnviromnet;
        }

        // GET: Shops
        public async Task<IActionResult> Index(string city)
        {        
            var shops = from m in _context.Shops
                         select m;

            if (!String.IsNullOrEmpty(city))
            {
                shops = shops.Where(s => s.City.Contains(city));
            }

            return View(await shops.ToListAsync());
        }

        // GET: Shops/Details/5
        [Authorize(Roles = "Shop")]
        public async Task<IActionResult> Edit()
        {
            string tmp  = userManager.GetUserId(HttpContext.User);

            if (tmp == null)
            {
                return NotFound();
            }

            var shops = _context.Shops.FirstOrDefault(s => s.UserId.Equals(tmp));                              
            
            if (shops == null)
            {
                return NotFound();
            }

            return View(shops);
        }
        

        // GET: Shops/Create
        public IActionResult Create()
        {
            string id = userManager.GetUserId(HttpContext.User);
            var tmp = _context.Shops.Where(s => s.UserId == id).ToList();

            if (tmp.Count != 0)
            {
                return NotFound();
            }

            return View();
        }
        
        // POST: Shops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ShopViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(HostingEnviromnet.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                       
                 Shops newshop = new Shops
                {
                    Name = model.Name,
                    Address = model.Address,
                    City = model.City,
                    PostalCode = model.PostalCode,
                    Phone = model.Phone,
                    rating = model.rating,
                    thesis = model.thesis,
                    TimeOpen = model.TimeOpen,       
                    UserId = userManager.GetUserId(HttpContext.User),
                    imgUrl = uniqueFileName
                   
                };                
                _context.Add(newshop);
                await _context.SaveChangesAsync();
                return RedirectToAction("details",new { id = newshop.ID });
            }
            return RedirectToAction("CreateTableMap", "Table");
        }
       // [Authorize(Roles = "Shop")]
        // GET: Shops/Edit/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shops = await _context.Shops.FindAsync(id);
            if (userManager.GetUserId(HttpContext.User) != shops.UserId)
            {
             //   return NotFound();
            }
            if (shops == null)
            {
                return NotFound();
            }
            return View(shops);
        }

        // POST: Shops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,String Name, String Address, String City, String PostalCode,String Phone, String TimeOpen, String imgUrl, Shops shops)
        {
            if (id != shops.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                string tmpUrl;
                try
                {
                    if (imgUrl == null)
                    {
                        tmpUrl = _context.Shops.SingleOrDefault(s => s.ID == id).imgUrl;
                    }
                    shops = new Shops
                    {
                        ID=id,
                        Name = Name,
                        Address =Address,
                        City = City,
                        PostalCode = PostalCode,
                        Phone = Phone,
                        UserId=userManager.GetUserId(HttpContext.User),
                        TimeOpen = TimeOpen,
                        imgUrl = imgUrl
                    };
                    _context.Update(shops);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopsExists(shops.ID))
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
            return View(shops);
        }

        // GET: Shops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shops = await _context.Shops
                .FirstOrDefaultAsync(m => m.ID == id);
            if (shops == null)
            {
                return NotFound();
            }

            return View(shops);
        }

        // POST: Shops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shops = await _context.Shops.FindAsync(id);
            _context.Shops.Remove(shops);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopsExists(int id)
        {
            return _context.Shops.Any(e => e.ID == id);
        }
    }
}
