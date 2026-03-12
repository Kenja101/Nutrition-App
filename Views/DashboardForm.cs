using System;
using System.Windows.Forms;
using NutritionApp.Controllers;
using NutritionApp.Models;
using NutritionApp.Services;

namespace NutritionApp.Views
{
    public partial class DashboardForm : Form
    {
        private User currentUser;
        private NutritionService nutritionService = new NutritionService();

        public DashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadData();
        }

        private void LoadData()
        {
            lblWelcome.Text = "Welcome, " + currentUser.FullName + "!";
            lblEmail.Text = "Email: " + currentUser.Email;
            lblAge.Text = "Age: " + currentUser.Age;
            lblWeight.Text = "Weight: " + currentUser.Weight + " kg";
            lblHeight.Text = "Height: " + currentUser.Height + " cm";
            lblGoal.Text = "Goal: " + currentUser.Goal;
            lblDietType.Text = "Diet: " + currentUser.DietType;
            lblActivity.Text = "Activity: " + currentUser.ActivityLevel;

            double bmi = nutritionService.CalculateBMI(currentUser.Weight, currentUser.Height);
            string category = nutritionService.GetBMICategory(bmi);
            lblBMI.Text = "BMI: " + bmi + " (" + category + ")";

            double maintenance = nutritionService.CalculateMaintenanceCalories(currentUser);
            lblMaintenance.Text = "Maintenance Calories: " + maintenance + " kcal";

            double goalCalories = nutritionService.CalculateDailyCalories(currentUser);
            lblGoalCalories.Text = "Daily Goal: " + goalCalories + " kcal";

            MacroDistribution macros = nutritionService.GetMacros(currentUser, goalCalories);
            lblProtein.Text = "Protein: " + macros.ProteinGrams + " g (" + macros.ProteinCalories + " kcal)";
            lblCarbs.Text = "Carbs: " + macros.CarbGrams + " g (" + macros.CarbCalories + " kcal)";
            lblFat.Text = "Fat: " + macros.FatGrams + " g (" + macros.FatCalories + " kcal)";
        }

        private void btnMyMenus_Click(object sender, EventArgs e)
        {
            MenuListForm menuForm = new MenuListForm(currentUser);
            menuForm.Show();
            this.Close();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statsForm = new StatisticsForm(currentUser);
            statsForm.Show();
            this.Close();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfileForm editForm = new EditProfileForm(currentUser);
            editForm.ShowDialog();

            UserController userCtrl = new UserController();
            currentUser = userCtrl.GetById(currentUser.Id);
            LoadData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
