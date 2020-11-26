using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationCandy.Controllers {
    public class HelloWorldController : Controller {

        public string Index() {
            return "child";
            
        }
        public string Hello(string name = "app", int id = 1) {
            // return using HtmlEncoder Function
            return HtmlEncoder.Default.Encode($"Hello {name}, Your Id is : {id}");
            
        }

        public IActionResult Welcome(string name="Candy", int id = 1) {
            // return ViewData name and id

            ViewData["message"] = "welcome " + name;
            ViewData["id"] = id;
            ViewBag.gret = "This is paragraph";
            return View();

        }
    }
}
