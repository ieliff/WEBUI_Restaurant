using BLL.Service;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WEBUI_Restaurant.ViewComponents
{
    public class _SelectMenuCategoryViewComponentPartial : ViewComponent
    {
        private readonly MenuCategoryService menuCategoryService;
        private readonly MenuItemService menuItemService;

        public _SelectMenuCategoryViewComponentPartial()
        {
            menuCategoryService = new MenuCategoryService();
            menuItemService = new MenuItemService();
        }

        public IViewComponentResult Invoke()
        {
            var model = new MenuViewModel
            {
                Categories = menuCategoryService.GetAllCategories(),
                Items = menuItemService.GetMenuItems()
            };

            return View(model);
        }

    }
    public class MenuViewModel
    {
        public List<MenuCategory> Categories { get; set; }
        public List<MenuItem> Items { get; set; }
    }
}
