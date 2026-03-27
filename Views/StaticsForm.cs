using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NutritionApp.Controllers;
using NutritionApp.Models;
using NutritionApp.Services;
using Menu = NutritionApp.Models.Menu;

namespace NutritionApp.Views
{
    public partial class StatisticsForm : Form
    {
        private User currentUser;
        private MenuController menuCtrl = new MenuController();
        private NutritionService nutritionService = new NutritionService();
        private double dailyGoal;

        public StatisticsForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            dailyGoal = nutritionService.CalculateDailyCalories(currentUser);
            dtpStart.Value = DateTime.Today.AddDays(-15);
            dtpEnd.Value = DateTime.Today;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value.Date;
            DateTime endDate = dtpEnd.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date must be before end date.");
                return;
            }

            List<Menu> allMenus = menuCtrl.GetMenusByUser(currentUser.Id);
            List<Menu> filtered = new List<Menu>();

            foreach (Menu m in allMenus)
            {
                if (m.Date.Date >= startDate && m.Date.Date <= endDate)
                    filtered.Add(m);
            }

            if (filtered.Count == 0)
            {
                MessageBox.Show("No menus found for that date range.");
                ClearStats();
                return;
            }

            double totalCalories = 0;
            double totalProtein = 0;
            double totalCarbs = 0;
            double totalFat = 0;

            List<string> days = new List<string>();

            foreach (Menu m in filtered)
            {
                totalCalories += m.TotalCalories;
                totalProtein += m.TotalProtein;
                totalCarbs += m.TotalCarbohydrates;
                totalFat += m.TotalFat;

                string day = m.Date.Date.ToString("yyyy-MM-dd");
                if (!days.Contains(day))
                    days.Add(day);
            }

            int totalDays = days.Count;
            MacroDistribution macroGoal = nutritionService.GetMacros(currentUser, dailyGoal);

            int goalDays = 0;
            lstDaily.Items.Clear();

            foreach (string day in days)
            {
                double dayCalories = 0;
                double dayProtein = 0;
                double dayCarbs = 0;
                double dayFat = 0;

                foreach (Menu m in filtered)
                {
                    if (m.Date.Date.ToString("yyyy-MM-dd") == day)
                    {
                        dayCalories += m.TotalCalories;
                        dayProtein += m.TotalProtein;
                        dayCarbs += m.TotalCarbohydrates;
                        dayFat += m.TotalFat;
                    }
                }

                bool goalMet = Math.Abs(dayCalories - dailyGoal) <= 100;
                if (goalMet) goalDays++;

                string status = goalMet ? "OK" : "MISS";
                string row = day + " | " + Math.Round(dayCalories, 0) + " kcal [" + status + "]" +
                             " | P: " + Math.Round(dayProtein, 1) + "g" +
                             " C: " + Math.Round(dayCarbs, 1) + "g" +
                             " F: " + Math.Round(dayFat, 1) + "g";
                lstDaily.Items.Add(row);
            }

            lblTotalMenus.Text = "Total Menus: " + filtered.Count;
            lblTotalDays.Text = "Days Tracked: " + totalDays;
            lblGoal.Text = "Daily Goal: " + dailyGoal + " kcal";
            lblGoalDays.Text = "Days Goal Met: " + goalDays + " / " + totalDays;
            lblTotalCalories.Text = "Total Calories: " + Math.Round(totalCalories, 1) + " kcal";
            lblAvgCalories.Text = "Avg/Day: " + Math.Round(totalCalories / totalDays, 1) + " kcal (Goal: " + dailyGoal + ")";
            lblTotalProtein.Text = "Total Protein: " + Math.Round(totalProtein, 1) + " g";
            lblAvgProtein.Text = "Avg/Day: " + Math.Round(totalProtein / totalDays, 1) + "g (Goal: " + macroGoal.ProteinGrams + "g)";
            lblTotalCarbs.Text = "Total Carbs: " + Math.Round(totalCarbs, 1) + " g";
            lblAvgCarbs.Text = "Avg/Day: " + Math.Round(totalCarbs / totalDays, 1) + "g (Goal: " + macroGoal.CarbGrams + "g)";
            lblTotalFat.Text = "Total Fat: " + Math.Round(totalFat, 1) + " g";
            lblAvgFat.Text = "Avg/Day: " + Math.Round(totalFat / totalDays, 1) + "g (Goal: " + macroGoal.FatGrams + "g)";
        }

        private void ClearStats()
        {
            lblTotalMenus.Text = "Total Menus: -";
            lblTotalDays.Text = "Days Tracked: -";
            lblGoal.Text = "Daily Goal: -";
            lblGoalDays.Text = "Days Goal Met: -";
            lblTotalCalories.Text = "Total Calories: -";
            lblAvgCalories.Text = "Avg/Day: -";
            lblTotalProtein.Text = "Total Protein: -";
            lblAvgProtein.Text = "Avg/Day: -";
            lblTotalCarbs.Text = "Total Carbs: -";
            lblAvgCarbs.Text = "Avg/Day: -";
            lblTotalFat.Text = "Total Fat: -";
            lblAvgFat.Text = "Avg/Day: -";
            lstDaily.Items.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm(currentUser);
            dashboard.Show();
            this.Close();
        }
    }
}
