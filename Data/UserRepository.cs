using System.Collections.Generic;
using System.Linq;
using NutritionApp.Models;

namespace NutritionApp.Data
{
    public class UserRepository
    {
        // devuelve todos los usuarios
        public List<User> GetAll()
        {
            using AppDbContext db = new AppDbContext();
            return db.Users.ToList();
        }

        // guarda todos los usuarios
        public void SaveAll(List<User> users)
        {
            using AppDbContext db = new AppDbContext();
            db.Users.RemoveRange(db.Users);
            db.Users.AddRange(users);
            db.SaveChanges();
        }
    }
}