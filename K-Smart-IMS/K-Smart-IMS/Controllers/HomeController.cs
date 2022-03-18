using K_Smart_IMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace K_Smart_IMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CurrentInventory()
        {
            return View();
        }
        public IActionResult BrowseProducts()
        {
            return View();
        }
        public IActionResult InventoryEdit()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult OrderConfirmation()
        {
            return View();
        }
        public IActionResult OrderHistory()
        {
            return View();
        }
        public IActionResult ProductArrival()
        {
            return View();
        }
        public IActionResult ProductInfo()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult ViewCart()
        {
            return View();
        }
        public IActionResult ViewOrder()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
