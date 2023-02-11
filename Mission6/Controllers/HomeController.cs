using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private movieFormContext _blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, movieFormContext someName)
        {
            _logger = logger;
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FillOutForm ()
        {
            return View("addMovies");
        }
        [HttpPost]
        public IActionResult FillOutForm(FormResponse fr)
        {
            _blahContext.Add(fr);
            _blahContext.SaveChanges();

            return View("Confirm", fr);
        }
        public IActionResult GoToMyPodcasts()
        {
            return View("myPodcasts");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
