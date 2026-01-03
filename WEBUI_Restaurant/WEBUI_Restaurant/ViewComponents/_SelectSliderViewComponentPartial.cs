using BLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace WEBUI_Restaurant.ViewComponents
{
    public class _SelectSliderViewComponentPartial : ViewComponent
    {
        private readonly SliderService sliderService;

        public _SelectSliderViewComponentPartial()
        {
            sliderService = new SliderService();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = sliderService.GetAll();
            return View(values);
        }
    }
}
