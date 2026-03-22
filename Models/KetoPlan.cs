using System;

namespace NutritionApp.Models
{
    // keto diet: 25% protein, 5% carbs, 70% fat
    public class KetoPlan : NutritionPlan
    {
        public KetoPlan()
        {
            PlanName = "Keto";
        }

        public override double GetProteinGrams(double calories)
        {
            return Math.Round((calories * 0.25) / 4, 1);
        }

        public override double GetCarbGrams(double calories)
        {
            return Math.Round((calories * 0.05) / 4, 1);
        }

        public override double GetFatGrams(double calories)
        {
            return Math.Round((calories * 0.70) / 9, 1);
        }
    }
}
