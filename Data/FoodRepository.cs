using System.Collections.Generic;
using System.Linq;
using NutritionApp.Models;

namespace NutritionApp.Data
{
    public class FoodRepository
    {
        // devuelve todos los productos
        public List<FoodProduct> GetAll()
        {
            using AppDbContext db = new AppDbContext();
            return db.Foods.ToList();
        }

        // guarda todos los productos
        public void SaveAll(List<FoodProduct> foods)
        {
            using AppDbContext db = new AppDbContext();
            db.Foods.RemoveRange(db.Foods);
            db.Foods.AddRange(foods);
            db.SaveChanges();
        }
    }
}