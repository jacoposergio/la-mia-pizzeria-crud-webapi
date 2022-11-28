using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class GuestController : Controller
    {
        //si occupa soltanto di presentarci le navigazioni
        public IActionResult Index()
        {
            ViewData["title"] = "Home";
            return View();
        }

    }
}