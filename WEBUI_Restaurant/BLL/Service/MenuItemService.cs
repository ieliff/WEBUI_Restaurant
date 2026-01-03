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

        // Tüm menü öğelerini getirme
        public List<MenuItem> GetMenuItems()
        {
            return menuItemDal.GetAll();
        }

        // ID'ye göre menü öğesi getirme
        public MenuItem GetMenuItemById(int id)
        {
            return menuItemDal.GetById(id);
        }

        // Yeni bir menü öğesi ekleme (Fotoğraf dosya yolu ile)
        public void AddMenuItem(MenuItem menuItem, string imageFilePath)
        {
            if (!string.IsNullOrEmpty(imageFilePath))
            {
                var fileName = Path.GetFileName(imageFilePath);
                var destinationPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", fileName);

                // Fotoğrafı hedef klasöre kopyala
                File.Copy(imageFilePath, destinationPath, true);

                menuItem.ImagePath = fileName; // Fotoğraf yolu kaydediliyor
            }

            menuItemDal.Add(menuItem); // Veri tabanına ekleme
        }

        // Menü öğesini güncelleme (Fotoğraf dosya yolu ile)
        public void UpdateMenuItem(MenuItem menuItem, string imageFilePath)
        {
            var existingItem = menuItemDal.GetById(menuItem.Id);
            if (existingItem != null)
            {
                existingItem.Name = menuItem.Name;
                existingItem.Price = menuItem.Price;
                existingItem.Description = menuItem.Description;

                if (!string.IsNullOrEmpty(imageFilePath))
                {
                    var fileName = Path.GetFileName(imageFilePath);
                    var destinationPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", fileName);

                    // Fotoğrafı hedef klasöre kopyala
                    File.Copy(imageFilePath, destinationPath, true);

                    existingItem.ImagePath = fileName; // Fotoğraf yolu güncelleniyor
                }

                menuItemDal.Update(existingItem); // Veri tabanında güncelleme
            }
        }

        // Menü öğesini silme
        public void DeleteMenuItem(int id)
        {
            var menuItem = menuItemDal.GetById(id);
            if (menuItem != null)
            {
                menuItemDal.Delete(menuItem);
            }
        }
    }
}
