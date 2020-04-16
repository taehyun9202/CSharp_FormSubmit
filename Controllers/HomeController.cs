using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmit.Models;

namespace FormSubmit.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("submit")]
        public IActionResult Submit(User user)
        {
            if(ModelState.IsValid)
            {
                User newuser = new User()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Age = user.Age,
                    Email = user.Email,
                    Password = user.Password
                };
                return View("Success", newuser);
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("Success")]
        public IActionResult Success(User newuser)
        {
            return View("Success", newuser);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
