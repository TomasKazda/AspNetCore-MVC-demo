using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCdemo.Models;
using Helpers;

namespace MVCdemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string sessionKey = "BFLMkey123xyz";
    
        [BindProperty]
        public User UserData { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult LoginForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginFormExec()
        { 
            if (ModelState.IsValid)
            {
                if (UserData.Age >= 18)
                {
                    HttpContext.Session.Set<User>(sessionKey, UserData);
                   
                    return RedirectToAction("LoginSuccess", UserData);
                }
            }

            return View("LoginForm");
        }

        public IActionResult LoginSuccess(User userData)
        {

            //return View(HttpContext.Session.Get<User>(sessionKey));
            return View(userData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ErrorViewModel data = new ErrorViewModel();
            data.RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View(data);
        }
    }
}
