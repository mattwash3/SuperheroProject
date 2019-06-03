using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuperheroProject.Models;

namespace SuperheroProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Have you ever wanted to view a list of superheroes' alter egos, abilities and catchphrases? " +
                "This is by no means a complete list of superheroes as that would be a massive list! However it is a list of " +
                "Spiderman heroes with a couple anti heroes mixed in there.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Matt Washington";

            return View();
        }
    }
}