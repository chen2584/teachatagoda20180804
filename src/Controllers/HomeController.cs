using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using techatagoda.Services;

namespace techatagoda.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["name"] = new NameService().GetName("Hello");
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
