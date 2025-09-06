using DAL.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class MenuItemService
    {
        private readonly MenuItemDal menuItemDal;

        public MenuItemService()
        {
            menuItemDal = new MenuItemDal();
        }

        public List<MenuItem> GetMenuItems()
        {
            return menuItemDal.GetAll();
        }
        

        
    }
}
