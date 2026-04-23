using System.Collections.Generic;
using System.Linq;
using NutritionApp.Models;
using Menu = NutritionApp.Models.Menu;
using Microsoft.EntityFrameworkCore;

namespace NutritionApp.Data
{
    public class MenuRepository
    {
        // devuelve todos los menus con sus items
        public List<Menu> GetAll()
        {
            using AppDbContext db = new AppDbContext();
            return db.Menus.Include(m => m.Items).ToList();
        }

        // guarda todos los menus
        public void SaveAll(List<Menu> menus)
        {
            using AppDbContext db = new AppDbContext();
            db.Menus.RemoveRange(db.Menus);
            db.MenuItems.RemoveRange(db.MenuItems);
            db.Menus.AddRange(menus);
            db.SaveChanges();
        }
    }
}