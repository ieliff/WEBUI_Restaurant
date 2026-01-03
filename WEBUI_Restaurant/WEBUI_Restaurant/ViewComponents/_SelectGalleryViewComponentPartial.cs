
using Microsoft.AspNetCore.Mvc;

namespace WEBUI_Restaurant.ViewComponents
{
    public class _SelectGalleryViewComponentPartial:ViewComponent
    {    
        public IViewComponentResult Invoke()
        {           
            return View();
        }
    }
}
