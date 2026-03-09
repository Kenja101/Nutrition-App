using System;
using System.IO;

namespace NutritionApp.Data
{
    public class DataPaths
    {
        public static string UsersFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Files", "users.json");
        public static string FoodsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Files", "foods.json");
        public static string MenusFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Files", "menus.json");

        public static void EnsureFoldersExist()
        {
            string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Files");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
        }
    }
}
