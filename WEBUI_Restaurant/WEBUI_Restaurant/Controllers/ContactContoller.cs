using BLL.Service;
using DAL.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WEBUI_Restaurant.Controllers
{
    public class ContactContoller : Controller
    {
        private readonly ContactService _contactService;

        public ContactContoller(ContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.GetContact(contact);
                ViewBag.Message = "Mesajınız başarıyla gönderildi!";
                return View();
            }

            ViewBag.Message = "Mesaj gönderilirken bir hata oluştu.";
            return View(contact);
        }
    }

}
