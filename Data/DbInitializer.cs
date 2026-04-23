using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using NutritionApp.Models;
using Menu = NutritionApp.Models.Menu;

namespace NutritionApp.Data
{
    public class DbInitializer
    {
        // crea la base de datos y carga los datos del json si esta vacia
        public static void Initialize()
        {
            using AppDbContext db = new AppDbContext();
            db.Database.EnsureCreated();

            if (db.Users.Any()) return;

            string usersJson = File.ReadAllText(DataPaths.UsersFile);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(usersJson);
            db.Users.AddRange(users);

            string foodsJson = File.ReadAllText(DataPaths.FoodsFile);
            List<FoodProduct> foods = JsonConvert.DeserializeObject<List<FoodProduct>>(foodsJson);
            db.Foods.AddRange(foods);

            string menusJson = File.ReadAllText(DataPaths.MenusFile);
            List<Menu> menus = JsonConvert.DeserializeObject<List<Menu>>(menusJson);
            db.Menus.AddRange(menus);

            db.SaveChanges();
        }
    }
}