using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using NutritionApp.Models;
using Menu = NutritionApp.Models.Menu;

namespace NutritionApp.Data
{
    public class MenuRepository
    {
        public List<Menu> GetAll()
        {
            try
            {
                if (!File.Exists(DataPaths.MenusFile))
                    return new List<Menu>();

                string text = File.ReadAllText(DataPaths.MenusFile);
                return JsonConvert.DeserializeObject<List<Menu>>(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menus: " + ex.Message);
                return new List<Menu>();
            }
        }

        public void SaveAll(List<Menu> menus)
        {
            try
            {
                string text = JsonConvert.SerializeObject(menus, Formatting.Indented);
                File.WriteAllText(DataPaths.MenusFile, text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving menus: " + ex.Message);
            }
        }
    }
}
