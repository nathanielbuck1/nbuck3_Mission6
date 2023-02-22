using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


//Nathaniel Buck
//    Section 4

namespace Mission6.Controllers
{
    //Controller
    public class HomeController : Controller
    {
        private movieFormContext daContext { get; set; }

        public HomeController(movieFormContext someName)
        {
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Getter for the filling of the form
        [HttpGet]
        public IActionResult FillOutForm ()
        {
            ViewBag.Categories = daContext.Categories.ToList();

            //var Categories = daContext.Categories.ToList();

            return View("addMovies");
            //return View(Categories);
        }
        //POST for the filling of the form
        [HttpPost]
        public IActionResult FillOutForm(FormResponse fr)
        {
            if (ModelState.IsValid)
            {
                //ViewBag.Categories = daContext.Categories.ToList();
                daContext.Add(fr);
                daContext.SaveChanges();

                return View("Confirm", fr);
            }
            else //if not valid
            {
                ViewBag.Categories = daContext.Categories.ToList();
                return View("AddMovies");
            }

        }

        //this is the List of Movies
        public IActionResult Waitlist ()
        {
            var applications = daContext.Responses.Include(x => x.Category)
                //.Where(x=> x.Rating == 'PG')
                .OrderBy(x=> x.Title).ToList();

            return View(applications);
        }

        //getter for the editing of fields
        [HttpGet]
        public IActionResult Edit (int AppID)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            var application = daContext.Responses.Single(x => x.AppID == AppID);

            return View("addMovies" , application);
        }

        //Post for the editing of fields
        [HttpPost]
        public IActionResult Edit(FormResponse blah)
        {
            daContext.Update(blah);
            daContext.SaveChanges();

            return RedirectToAction("WaitList");
        }

        //Getter for deleting
        [HttpGet]
        public IActionResult Delete( int appID)
        {
            var application = daContext.Responses.Single(x => x.AppID == appID);

            return View(application);
        }

        //Post for deleting
        [HttpPost]
        public IActionResult Delete(FormResponse fr)
        {
            daContext.Responses.Remove(fr);
            daContext.SaveChanges();
            
            return RedirectToAction("WaitList");
        }

        public IActionResult GoToMyPodcasts()
        {
            return View("myPodcasts");
        }


    }
}
