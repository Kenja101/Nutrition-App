using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NutritionApp.Controllers;
using NutritionApp.Models;
using Menu = NutritionApp.Models.Menu;
using MenuItem = NutritionApp.Models.MenuItem;

namespace NutritionApp.Views
{
    public partial class MenuListForm : Form
    {
        private User currentUser;
        private MenuController menuCtrl = new MenuController();
        private List<Menu> menus;

        public MenuListForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadMenus();
        }

        private void LoadMenus()
        {
            menus = menuCtrl.GetMenusByUser(currentUser.Id);
            lstMenus.Items.Clear();

            foreach (Menu m in menus)
            {
                string line = m.Date.ToString("dd/MM/yyyy") + " | " + m.MealTime + " | " + m.Name + " | " + Math.Round(m.TotalCalories, 1) + " kcal";
                lstMenus.Items.Add(line);
            }

            ClearDetails();
        }

        private void lstMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstMenus.SelectedIndex;
            if (index < 0) return;

            Menu selected = menus[index];

            lblDetailName.Text = "Name: " + selected.Name;
            lblDetailDate.Text = "Date: " + selected.Date.ToString("dd/MM/yyyy");
            lblDetailMealTime.Text = "Meal: " + selected.MealTime;
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MenuEditForm editForm = new MenuEditForm(currentUser, null);
            editForm.ShowDialog();
            LoadMenus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstMenus.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select a menu first.");
                return;
            }

            Menu selected = menus[index];
            MenuEditForm editForm = new MenuEditForm(currentUser, selected);
            editForm.ShowDialog();
            LoadMenus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstMenus.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select a menu first.");
                return;
            }

            Menu selected = menus[index];
            DialogResult result = MessageBox.Show("Delete '" + selected.Name + "'?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                menuCtrl.DeleteMenu(selected.Id);
                LoadMenus();
            }
        }

        private void btnSuggested_Click(object sender, EventArgs e)
        {
            SuggestedMenusForm suggestedForm = new SuggestedMenusForm(currentUser);
            suggestedForm.ShowDialog();
            LoadMenus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm(currentUser);
            dashboard.Show();
            this.Close();
        }

        private void ClearDetails()
        {
            lblDetailName.Text = "Name: -";
            lblDetailDate.Text = "Date: -";
            lblDetailMealTime.Text = "Meal: -";
            lblDetailCalories.Text = "Calories: -";
            lblDetailProtein.Text = "Protein: -";
            lblDetailCarbs.Text = "Carbs: -";
            lblDetailFat.Text = "Fat: -";
            lstItems.Items.Clear();
        }
    }
}
