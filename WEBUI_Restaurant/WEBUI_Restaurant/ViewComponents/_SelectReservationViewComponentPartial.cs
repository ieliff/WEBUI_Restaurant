using BLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace WEBUI_Restaurant.ViewComponents
{
    public class _SelectReservationViewComponentPartial : ViewComponent
    {
        private readonly ReservationService reservationService;

        public _SelectReservationViewComponentPartial()
        {
            reservationService = new ReservationService();
        }

        public IViewComponentResult Invoke()
        {
            var reservations = reservationService.GetAllReservations();
            return View(reservations);
        }
    }
}
