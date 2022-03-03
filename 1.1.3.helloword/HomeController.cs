using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1._1._3.helloword
{
    public class HomeController : Controller
    {
        //[Route("/hello")]
        //public string SayHello() => "Hello World";

        [HttpGet("/hello/{name}")]
        public IActionResult SayHello(string name)
        {
            ViewBag.Name = name;
            return View();
        }

    }
}
