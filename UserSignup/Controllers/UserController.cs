using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
           
            if (user.Password == verify)
            {
                
                ViewBag.name = user.Username;
                return View("Index");
            }

            ViewBag.error = "Password and Verify Password must match";
            ViewBag.user = user.Username;
            ViewBag.email = user.Email;
            return View();
        }
    }
}
