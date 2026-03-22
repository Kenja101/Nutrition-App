using System;

namespace NutritionApp.Models
{
    // vegetarian: 20% protein, 55% carbs, 25% fat
    public class VegetarianPlan : NutritionPlan
    {
        public VegetarianPlan()
        {
            PlanName = "Vegetarian";
        }

        public override double GetProteinGrams(double calories)
        {
            return Math.Round((calories * 0.20) / 4, 1);
        }

        public override double GetCarbGrams(double calories)
        {
            return Math.Round((calories * 0.55) / 4, 1);
        }

        public override double GetFatGrams(double calories)
        {
            return Math.Round((calories * 0.25) / 9, 1);
        }
    }
}
