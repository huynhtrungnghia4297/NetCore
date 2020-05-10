using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCore.Controllers
{
    public class DemoController : Controller
    {
        //local:port/Demo/Chuoi

        public string Chuoi()
        {
            return "Hello World";
        }
        //local:port/Demo/So
        public int So()
        {
            return new Random().Next(1, 100);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}