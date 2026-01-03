using BLL.Service;
using DAL.Context;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WEBUI_Restaurant.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataContext _context;

        public AdminController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items = _context.MenuItems.ToList();
            return View(items);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MenuItem item, IFormFile ImageFile)
        {
            if (ImageFile != null)
            {
                var fileName = Path.GetFileName(ImageFile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    ImageFile.CopyTo(stream);
                }

                item.ImageUrl = "/images/" + fileName;
            }

            _context.MenuItems.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _context.MenuItems.Find(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(MenuItem item, IFormFile ImageFile)
        {
            if (ImageFile != null)
            {
                var fileName = Path.GetFileName(ImageFile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    ImageFile.CopyTo(stream);
                }

                item.ImageUrl = "/images/" + fileName;
            }

            _context.MenuItems.Update(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var item = _context.MenuItems.Find(id);
            _context.MenuItems.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

