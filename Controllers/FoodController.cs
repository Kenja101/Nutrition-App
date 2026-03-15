using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NutritionApp.Data;
using NutritionApp.Models;
using Menu = NutritionApp.Models.Menu;
using MenuItem = NutritionApp.Models.MenuItem;

namespace NutritionApp.Controllers
{
    public class MenuController
    {
        private MenuRepository repo = new MenuRepository();

        public List<Menu> GetMenusByUser(int userId)
        {
            try
            {
                List<Menu> all = repo.GetAll();
                List<Menu> result = new List<Menu>();
                foreach (Menu m in all)
                {
                    if (m.UserId == userId)
                        result.Add(m);
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menus: " + ex.Message);
                return new List<Menu>();
            }
        }

        public void CreateMenu(Menu menu)
        {
            try
            {
                List<Menu> all = repo.GetAll();

                int maxId = 0;
                foreach (Menu m in all)
                {
                    if (m.Id > maxId)
                        maxId = m.Id;
                }
                menu.Id = maxId + 1;

                CalculateTotals(menu);
                all.Add(menu);
                repo.SaveAll(all);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating menu: " + ex.Message);
            }
        }

        public void UpdateMenu(Menu updatedMenu)
        {
            try
            {
                List<Menu> all = repo.GetAll();
                CalculateTotals(updatedMenu);
                for (int i = 0; i < all.Count; i++)
                {
                    if (all[i].Id == updatedMenu.Id)
                    {
                        all[i] = updatedMenu;
                        break;
                    }
                }
                repo.SaveAll(all);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating menu: " + ex.Message);
            }
        }

        public void DeleteMenu(int menuId)
        {
            try
            {
                List<Menu> all = repo.GetAll();
                Menu toRemove = null;
                foreach (Menu m in all)
                {
                    if (m.Id == menuId)
                    {
                        toRemove = m;
                        break;
                    }
                }
                if (toRemove != null)
                {
                    all.Remove(toRemove);
                    repo.SaveAll(all);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting menu: " + ex.Message);
            }
        }

        public void CalculateTotals(Menu menu)
        {
            menu.TotalCalories = 0;
            menu.TotalProtein = 0;
            menu.TotalCarbohydrates = 0;
            menu.TotalFat = 0;

            foreach (MenuItem item in menu.Items)
            {
                menu.TotalCalories += item.Calories;
                menu.TotalProtein += item.Protein;
                menu.TotalCarbohydrates += item.Carbohydrates;
                menu.TotalFat += item.Fat;
            }
        }
    }
}
