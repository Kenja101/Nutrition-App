// base class for nutrition plans
namespace NutritionApp.Models
{
    public abstract class NutritionPlan
    {
        public string PlanName { get; set; }

        // each plan calculates macros differently
        public abstract double GetProteinGrams(double calories);
        public abstract double GetCarbGrams(double calories);
        public abstract double GetFatGrams(double calories);
    }
}
