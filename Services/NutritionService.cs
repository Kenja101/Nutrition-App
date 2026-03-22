using System;
using NutritionApp.Models;

namespace NutritionApp.Services
{
    public class NutritionService
    {
        public double CalculateBMI(double weightKg, double heightCm)
        {
            if (heightCm <= 0) return 0;
            double heightM = heightCm / 100.0;
            return Math.Round(weightKg / (heightM * heightM), 2);
        }

        public string GetBMICategory(double bmi)
        {
            if (bmi < 18.5) return "Underweight";
            if (bmi < 25.0) return "Normal weight";
            if (bmi < 30.0) return "Overweight";
            return "Obese";
        }

        public double CalculateMaintenanceCalories(User user)
        {
            double bmr = (10 * user.Weight) + (6.25 * user.Height) - (5 * user.Age);

            double multiplier = 1.2;
            if (user.ActivityLevel == "Light") multiplier = 1.375;
            if (user.ActivityLevel == "Moderate") multiplier = 1.55;
            if (user.ActivityLevel == "Active") multiplier = 1.725;

            return Math.Round(bmr * multiplier, 0);
        }

        public double CalculateDailyCalories(User user)
        {
            double calories = CalculateMaintenanceCalories(user);

            if (user.Goal == "LoseFat") calories -= 500;
            if (user.Goal == "GainMuscle") calories += 300;

            if (user.DietType == "Keto") calories = calories * 0.95;
            if (user.DietType == "Vegetarian") calories = calories * 1.02;

            return Math.Round(calories, 0);
        }

        public NutritionPlan GetPlan(string dietType)
        {
            if (dietType == "Keto") return new KetoPlan();
            if (dietType == "Vegetarian") return new VegetarianPlan();
            return new StandardPlan();
        }

        public MacroDistribution GetMacros(User user, double dailyCalories)
        {
            NutritionPlan plan = GetPlan(user.DietType);

            MacroDistribution macros = new MacroDistribution();
            macros.ProteinGrams = plan.GetProteinGrams(dailyCalories);
            macros.CarbGrams = plan.GetCarbGrams(dailyCalories);
            macros.FatGrams = plan.GetFatGrams(dailyCalories);
            macros.ProteinCalories = Math.Round(macros.ProteinGrams * 4, 1);
            macros.CarbCalories = Math.Round(macros.CarbGrams * 4, 1);
            macros.FatCalories = Math.Round(macros.FatGrams * 9, 1);

            return macros;
        }
    }
}
