using DAL.Context;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class MenuItemDal
    {
        private readonly DataContext context;

        public MenuItemDal()
        {
            context = new DataContext();
        }

        public List<MenuItem> GetAll()
        {
            return context.MenuItems.ToList();
        }

        public MenuItem GetById(int id)
        {
            return context.MenuItems.FirstOrDefault(mi => mi.Id == id);
        }

        public void Add(MenuItem menuItem)
        {
            context.MenuItems.Add(menuItem);
            context.SaveChanges();
        }

        public void Update(MenuItem menuItem)
        {
            context.MenuItems.Update(menuItem);
            context.SaveChanges();
        }

        public void Delete(MenuItem menuItem)
        {
            context.MenuItems.Remove(menuItem);
            context.SaveChanges();
        }

    }
}
