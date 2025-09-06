using DAL.Context;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class MenuCategoryDal
    {
        private readonly DataContext context;

        public MenuCategoryDal()
        {
            context = new DataContext();
        }

        public List<MenuCategory> GetMenuCategory()
        {
            return context.MenuCategorys.ToList();
        }
        
    }
}
