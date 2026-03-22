using System;

namespace NutritionApp.Models
{
    // standard diet: 30% protein, 40% carbs, 30% fat
    public class StandardPlan : NutritionPlan
    {
        public StandardPlan()
        {
            PlanName = "Standard";
        }

        public override double GetProteinGrams(double calories)
        {
            return Math.Round((calories * 0.30) / 4, 1);
        }

        public override double GetCarbGrams(double calories)
        {
            return Math.Round((calories * 0.40) / 4, 1);
        }

        public override double GetFatGrams(double calories)
        {
            return Math.Round((calories * 0.30) / 9, 1);
        }
    }
}
