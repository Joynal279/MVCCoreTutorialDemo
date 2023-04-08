using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreTutorialDemo.Models.Domain;

namespace MVCCoreTutorialDemo.Controllers
{
    public class PersonController : Controller
    {
        private readonly DatabaseContext _ctx;

        public PersonController(DatabaseContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            //ViewBag & ViewData can send data only from controller to view
            ViewBag.greeting = "hello Joynal";
            ViewData["greeting2"] = "I am using ViewData";

            //TempData can send data from one controller method to another controller method
            TempData["greeting3"] = "It's TempData message";



            return View();
        }

        [HttpGet]
        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                _ctx.Add(person);
                _ctx.SaveChanges();
                TempData["msg"] = "Added successfully";
                return RedirectToAction("AddPerson");

            }catch(Exception ex)
            {
                TempData["msg"] = "Couldn't added";
                return View();
            }

            TempData["msg"] = "Added";
            return View();
        }

        public IActionResult DisplayPersons()
        {
            var persons = _ctx.person.ToList();
            return View(persons);
        }
    }
}