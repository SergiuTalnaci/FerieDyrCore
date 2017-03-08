using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FerieDyrCore.Models;

namespace FerieDyrCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult HelloCore()
        {
            using (var db = new FerieDyrCoreContext())
            {
                var model = new HelloCoreModel();
                model.Number = new Random().Next(1, 100);
                model.Message = $"Hello Core with EF Core number {model.Number}";
                db.HelloCoreModels.Add(model);
                db.SaveChanges();
                return View(model);
            }
        }
    }
}
