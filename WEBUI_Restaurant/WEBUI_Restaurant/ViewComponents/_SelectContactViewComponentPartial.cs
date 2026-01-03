using BLL.Service;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WEBUI_Restaurant.ViewComponents
{
    public class _SelectContactViewComponentPartial : ViewComponent
    {
        private readonly ContactService contactService;

        public _SelectContactViewComponentPartial()
        {
            contactService = new ContactService();
        }

        public IViewComponentResult Invoke()
        {
            var contact = new Contact();  
            var result = contactService.GetContact(contact);
            return View(result);
        }
    }
}
