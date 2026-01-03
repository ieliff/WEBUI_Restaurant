using DAL.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class MenuCategoryService
    {
        private readonly MenuCategoryDal menuCategoryDal;

        public MenuCategoryService()
        {
            menuCategoryDal = new MenuCategoryDal();
        }

        public List<MenuCategory> GetAllCategories()
        {
            return menuCategoryDal.GetMenuCategory();
        }
    }
}
