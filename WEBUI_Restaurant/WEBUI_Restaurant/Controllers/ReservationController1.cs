using BLL.Service;
using DAL.Context;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WEBUI_Restaurant.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ReservationService _service;

        public ReservationController()
        {
            _service = new ReservationService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Reservation()); // DAİMA BOŞ MODEL
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Reservation model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _service.AddReservation(model);
            TempData["SuccessMessage"] = "Rezervasyonunuz oluşturuldu.";
            return RedirectToAction("Index"); // FORM DOLU GELMESİN DİYE PRG
        }


    }   
}
