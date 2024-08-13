using Microsoft.AspNetCore.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Emp e)
        {
            if (ModelState.IsValid)
            {
                return View(e);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login log)
        {
            if (ModelState.IsValid)
            {
                if(log.Username.Equals("Admin") && log.Password.Equals("Admin123"))
                {
                    /*return RedirectToAction("ActionName", "ControllerName");*/ //only when we have to redirect one controller to another
                    /*return RedirectToAction("ActionName")*/; //within same controller
                    TempData["successMsg"] = "Login Success From TempData";
                    ViewData["successMsg"] = "Login Success From ViewData";
                    ViewBag.msg = "Login success from ViewBag";
                    return RedirectToAction("About", "Test");
                }
                else
                {
                    TempData["msg"] = "Invalid credentials";
                    return RedirectToAction("Login");
                }
            }
            else
            {
                return View();
            }
        }
    }
}
