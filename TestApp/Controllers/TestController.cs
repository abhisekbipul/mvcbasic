using Microsoft.AspNetCore.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            //var e = new Emp()
            //{
            //    Id = 101,
            //    Name= "Abhisek",
            //    salary=20000
            //};
            var e = new List<Emp>()
            {
                new Emp{Id=1,Name="John",salary=10001},
                new Emp{Id=1,Name="Raj",salary=10001},
                new Emp{Id=1,Name="Rajesh",salary=10001},
                new Emp{Id=1,Name="jay",salary=10001},

            };
            return View(e);
        }
        public IActionResult About()
        {


            var e = new List<Emp>()
            {
                new Emp{Id=1,Name="John",salary=10001},
                new Emp{Id=1,Name="Raj",salary=10001},
                new Emp{Id=1,Name="Rajesh",salary=10001},
                new Emp{Id=1,Name="jay",salary=10001},

            };
            var mn = new List<Manager>()
            {
                new Manager{mId=1,mName="John"},
                new Manager{mId=1,mName="Raj"}
            };

            var viewmodel = new CombinedViewModel()
            {
                emps=e,
                manager=mn
            };
            return View(viewmodel);

        }
    }
}
