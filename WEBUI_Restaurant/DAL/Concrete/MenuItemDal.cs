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

        // Tüm menü öğelerini getirme
        public List<MenuItem> GetAll()
        {
            return context.MenuItems.ToList();
        }

        // ID'ye göre menü öğesi getirme
        public MenuItem GetById(int id)
        {
            return context.MenuItems.FirstOrDefault(mi => mi.Id == id);
        }

        // Yeni menü öğesi ekleme
        public void Add(MenuItem menuItem)
        {
            context.MenuItems.Add(menuItem);
            context.SaveChanges();
        }

        // Menü öğesini güncelleme
        public void Update(MenuItem menuItem)
        {
            var existingItem = context.MenuItems.FirstOrDefault(mi => mi.Id == menuItem.Id);
            if (existingItem != null)
            {
                existingItem.Name = menuItem.Name;
                existingItem.Price = menuItem.Price;
                existingItem.Description = menuItem.Description;
                existingItem.ImagePath = menuItem.ImagePath; // Fotoğraf yolu güncelleniyor

                context.SaveChanges();
            }
        }

        // Menü öğesini silme
        public void Delete(MenuItem menuItem)
        {
            context.MenuItems.Remove(menuItem);
            context.SaveChanges();
        }
    }
}
