using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationCandy.Controllers {
    public class Controller1 : Controller {
        public string Index() {
            return "This is Index page.";
        }

        public string Details() {
            string name = "User";
            return HtmlEncoder.Default.Encode($"Hello {name}, this is detail page.");
        }

        public IActionResult Show(string name = "User") {
            ViewData["message"] = "Welcome " + name;
            ViewBag.greet = "How are you?";
            return View();
        }

    }
}
