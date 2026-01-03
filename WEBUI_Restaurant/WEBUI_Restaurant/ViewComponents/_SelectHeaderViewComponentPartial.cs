using Microsoft.AspNetCore.Mvc;

namespace WEBUI_Restaurant.ViewComponents
{
    public class _SelectHeaderViewComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
