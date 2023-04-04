using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreTutorialDemo.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag & ViewData can send data only from controller to view
            ViewBag.greeting = "hello Joynal";
            ViewData["greeting2"] = "I am using ViewData";

            //TempData can send data from one controller method to another controller method
            TempData["greeting3"] = "It's TempData message";



            return View();
        }

        public IActionResult AddPerson()
        {
            return View();
        }
    }
}