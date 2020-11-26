using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCandy.Models;

namespace WebApplicationCandy.Controllers {
    public class UserController : Controller {
        public IActionResult Index() {
            return View();
        }

        [HttpGet]
        public IActionResult SimpleBinding() {
            return View(new WebUser() { FirstName = "anish" , LastName = "rai"}) ;
        }

        [HttpPost]
        public IActionResult SimpleBinding(WebUser webUser) { 
            if (ModelState.IsValid) 
                return Content("Validation Complete" + webUser.FirstName + " " + webUser.LastName);
            else
                return View(webUser);
        }
    }
}
