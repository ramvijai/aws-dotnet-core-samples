using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleASPNETWebAPP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SampleASPNETWebAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static readonly int charLimit = 8;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult PickRandomNumber()
        {
            ColorUtils myColorUtils = new ColorUtils();
            int randPersonId = myColorUtils.PickRandomNumber(charLimit);
            ViewBag.Message = "Random Number: " + randPersonId;
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
