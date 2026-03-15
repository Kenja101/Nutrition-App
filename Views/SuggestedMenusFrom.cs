using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NutritionApp.Controllers;
using NutritionApp.Models;
using Menu = NutritionApp.Models.Menu;
using MenuItem = NutritionApp.Models.MenuItem;

namespace NutritionApp.Views
{
    public partial class SuggestedMenusForm : Form
    {
        private User currentUser;
        private SuggestedMenuController suggestedCtrl = new SuggestedMenuController();
        private List<Menu> suggestedMenus;

        public SuggestedMenusForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblDietType.Text = "Diet Type: " + currentUser.DietType;
            LoadMenus();
        }

        private void LoadMenus()
        {
            suggestedMenus = suggestedCtrl.GetSuggestedMenus(currentUser.DietType, currentUser.Id);
            lstMenus.Items.Clear();

            foreach (Menu m in suggestedMenus)
            {
                string line = m.MealTime + " | " + m.Name + " | " + Math.Round(m.TotalCalories, 1) + " kcal";
                lstMenus.Items.Add(line);
            }
        }

        private void lstMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstMenus.SelectedIndex;
            if (index < 0) return;

            Menu selected = suggestedMenus[index];

            lblDetailName.Text = "Name: " + selected.Name;
            lblDetailMeal.Text = "Meal: " + selected.MealTime;
            lblDetailCalories.Text = "Calories: " + Math.Round(selected.TotalCalories, 1) + " kcal";
            lblDetailProtein.Text = "Protein: " + Math.Round(selected.TotalProtein, 1) + " g";
            lblDetailCarbs.Text = "Carbs: " + Math.Round(selected.TotalCarbohydrates, 1) + " g";
            lblDetailFat.Text = "Fat: " + Math.Round(selected.TotalFat, 1) + " g";

            lstItems.Items.Clear();
            foreach (MenuItem item in selected.Items)
            {
                lstItems.Items.Add(item.FoodName + " - " + item.PortionGrams + "g - " + Math.Round(item.Calories, 1) + " kcal");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = lstMenus.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select a menu first.");
                return;
            }

            Menu selected = suggestedMenus[index];
            suggestedCtrl.SaveMenu(selected);
            MessageBox.Show(selected.Name + " added to your menus!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
