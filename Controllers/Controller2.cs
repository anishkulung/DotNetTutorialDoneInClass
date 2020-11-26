using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCandy.Models;

namespace WebApplicationCandy.Controllers {
    public class Controller2 : Controller {
        public IActionResult ShowData(string name, int id = 1) {
            ViewData["message"] = "Hello " + name;
            ViewData["numTimes"] = id;
            return View();

        }

        [HttpGet]
        public IActionResult SimpleBinding() {
            return View(new model1() { FullName = "Anish Rai", Salary = 10000, Email = "anish@gmail.com" });

        }

        [HttpPost]
        public IActionResult SimpleBinding(model1 user) {
            if (ModelState.IsValid)
                return Content("validation complete!");
            else
                return View(user);
        }
    }
}
