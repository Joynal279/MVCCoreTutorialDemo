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
            ViewBag.greeting = "hello Joynal";
            return View();
        }
    }
}