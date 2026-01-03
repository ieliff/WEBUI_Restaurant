using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WEBUI_Restaurant.Models;

namespace WEBUI_Restaurant.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
