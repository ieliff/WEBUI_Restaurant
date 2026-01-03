using BLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace WEBUI_Restaurant.ViewComponents
{
    public class _SelectAboutCounterViewComponentPartial: ViewComponent
    {
        private readonly AboutCounterService aboutCounterService;

        public _SelectAboutCounterViewComponentPartial()
        {
            aboutCounterService = new AboutCounterService();
        }

        public IViewComponentResult Invoke()
        {
            var aboutCounter = aboutCounterService.GetAll();
            return View(aboutCounter);
        }
    }
}
