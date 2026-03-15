using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NutritionApp.Controllers;
using NutritionApp.Models;
using Menu = NutritionApp.Models.Menu;
using MenuItem = NutritionApp.Models.MenuItem;

namespace NutritionApp.Views
{
    public partial class MenuEditForm : Form
    {
        private User currentUser;
        private Menu menu;
        private MenuController menuCtrl = new MenuController();
        private FoodController foodCtrl = new FoodController();
        private List<FoodProduct> foods;
        private bool isNew = false;

        public MenuEditForm(User user, Menu existingMenu)
        {
            InitializeComponent();
            currentUser = user;

            if (existingMenu == null)
            {
                isNew = true;
                menu = new Menu();
                menu.UserId = user.Id;
                menu.Date = DateTime.Today;
                menu.Items = new List<MenuItem>();
                menu.MealTime = "Breakfast";
            }
            else
            {
                menu = existingMenu;
            }

            LoadFoods();
            LoadForm();
            RefreshList();
        }

        private void LoadFoods()
        {
            foods = foodCtrl.GetAllFoods();
            cmbFood.Items.Clear();
            foreach (FoodProduct f in foods)
            {
                cmbFood.Items.Add(f.Name);
            }
            if (cmbFood.Items.Count > 0)
                cmbFood.SelectedIndex = 0;
        }

        private void LoadForm()
        {
            txtName.Text = menu.Name;
            dtpDate.Value = menu.Date;
            cmbMealTime.SelectedItem = menu.MealTime;
            if (cmbMealTime.SelectedIndex < 0)
                cmbMealTime.SelectedIndex = 0;
        }

        private void RefreshList()
        {
            lstItems.Items.Clear();
            foreach (MenuItem item in menu.Items)
            {
                lstItems.Items.Add(item.FoodName + " - " + item.PortionGrams + "g - " + Math.Round(item.Calories, 1) + " kcal");
            }

            menuCtrl.CalculateTotals(menu);
            lblCalories.Text = "Calories: " + Math.Round(menu.TotalCalories, 1) + " kcal";
            lblProtein.Text = "Protein: " + Math.Round(menu.TotalProtein, 1) + " g";
            lblCarbs.Text = "Carbs: " + Math.Round(menu.TotalCarbohydrates, 1) + " g";
            lblFat.Text = "Fat: " + Math.Round(menu.TotalFat, 1) + " g";
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            int index = cmbFood.SelectedIndex;
            if (index < 0) return;

            FoodProduct food = foods[index];

            MenuItem newItem = new MenuItem();
            newItem.FoodProductId = food.Id;
            newItem.FoodName = food.Name;
            newItem.PortionGrams = food.PortionGrams;
            newItem.Calories = food.Calories;
            newItem.Protein = food.Protein;
            newItem.Carbohydrates = food.Carbohydrates;
            newItem.Fat = food.Fat;

            menu.Items.Add(newItem);
            RefreshList();
        }

        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            int index = lstItems.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Select a food to remove.");
                return;
            }

            menu.Items.RemoveAt(index);
            RefreshList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            menu.Name = txtName.Text.Trim();
            menu.Date = dtpDate.Value;
            menu.MealTime = cmbMealTime.SelectedItem.ToString();

            if (isNew)
                menuCtrl.CreateMenu(menu);
            else
                menuCtrl.UpdateMenu(menu);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
