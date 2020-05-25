﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PtixiakiReservations.Data;
using PtixiakiReservations.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using PtixiakiReservations.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Net;
using System.Net.Mime;
using Newtonsoft.Json;

namespace PtixiakiReservations.Controllers
{
    public class TableController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext _context;

        public TableController(ApplicationDbContext context, UserManager<ApplicationUser> UserManager)
        {
            userManager = UserManager;
            _context = context;
        }

        // GET: Table
        public async Task<IActionResult> Index()
        {         
           
            return View();
        }
        [HttpGet]
        public JsonResult get_data(int? shopid, DateTime? date, int? people)
        {

            var tables = _context.Table.Where(s => s.shopID == shopid).ToList();
         

                return Json(tables);
        }     
            public async Task<IActionResult> ListOfMytables()
        {
            var id = userManager.GetUserId(HttpContext.User);

            var tables =  _context.Table.Where(s => s.shop.UserId == id).Include(r => r.shop);

            return View( await tables.ToListAsync());
        }
            // GET: Table/Details/5
            public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table = await _context.Table
                .Include(t => t.shop)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (table == null)
            {
                return NotFound();
            }

            return View(table);
        }

        // GET: Table/Create
        public IActionResult Create()
        {

            return View("CreateTableMap");
        }
        // POST: Table/Create
        [HttpPost]
        public async Task<IActionResult> CreateTableMap([FromBody] TableJsonModel[] tables)
        {

           var userID = userManager.GetUserId(HttpContext.User);
           var shop= _context.Shops.FirstOrDefault(s => s.UserId.Equals(userID));

            
            if (shop == null)
            {
                return null;
            }
            else
            if (ModelState.IsValid)
            {
                foreach (var t in tables)
                {
                    Table table = new Table
                    {
                        Name = t.Name,
                        people = int.Parse(t.text),
                        x = t.left,
                        y = t.top,
                        shopID = shop.ID,
                        Available=true
                        
                    };
                    _context.Add(table);

                }

                await _context.SaveChangesAsync();
            }
            Response.StatusCode = (int)HttpStatusCode.OK;
            return Json(Response.StatusCode); 
        }
       
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        // GET: Table/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table = await _context.Table.FindAsync(id);
            if (table == null)
            {
                return NotFound();
            }    
            ViewData["shopID"] = new SelectList(_context.Shops, "ID", "ID", table.shopID);
            return View(table);
        }

        // POST: Table/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ReservationId,shopID")] Table table)
        {
            if (id != table.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(table);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableExists(table.ID))
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
            ViewData["shopID"] = new SelectList(_context.Shops, "ID", "ID", table.shopID);
            return View(table);
        }
        public async Task<IActionResult> ChangeAvailable(int ID, bool Flag)
        {

            Table table = _context.Table.FirstOrDefault(t => t.ID == ID);
            if (table != null)
            {
                table.Available = Flag;
                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(table);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!TableExists(table.ID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }                  
                }             
            }
            return RedirectToAction("ListOfMytables","Table");
        }


        // GET: Table/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table = await _context.Table
                .Include(t => t.shop)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (table == null)
            {
                return NotFound();
            }

            return View(table);
        }

        // POST: Table/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var table = await _context.Table.FindAsync(id);
            var test = _context.Reservations.Where(r => r.tableId == table.ID).ToList();
               foreach(var r in test)
            {
                _context.Reservations.Remove(r);
            }
            _context.Table.Remove(table);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(ListOfMytables));
        }

        private bool TableExists(int id)
        {
            return _context.Table.Any(e => e.ID == id);
        }
    }
}
