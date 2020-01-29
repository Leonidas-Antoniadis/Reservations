using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PtixiakiReservations.Models;

namespace PtixiakiReservations.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IShop _shop;

        public DefaultController(IShop shop)
        {
            _shop = shop;
        }
        public IActionResult Index()
        {
            return View(_shop.List());
        }
       
    }
}