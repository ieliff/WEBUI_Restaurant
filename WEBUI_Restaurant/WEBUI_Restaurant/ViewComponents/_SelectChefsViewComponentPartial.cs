using BLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace WEBUI_Restaurant.ViewComponents
{
    public class _SelectChefsViewComponentPartial : ViewComponent
    {
        private readonly ChefsService chefService;

        public _SelectChefsViewComponentPartial()
        {
            chefService = new ChefsService();
        }

        public IViewComponentResult Invoke()
        {
            var chefs = chefService.GetAllChefs();
            return View(chefs);
        }
    }
}
