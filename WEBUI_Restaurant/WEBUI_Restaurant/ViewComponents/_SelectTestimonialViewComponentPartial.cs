using BLL.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace WEBUI_Restaurant.ViewComponents
{
    public class _SelectTestimonialViewComponentPartial : ViewComponent
    {
        private readonly TestimonialService testimonialService;

        public _SelectTestimonialViewComponentPartial()
        {
            testimonialService = new TestimonialService();
        }
        public IViewComponentResult Invoke()
        {
            var values = testimonialService.GetAllTestimonials();
            return View(values);
        }
    }
}
