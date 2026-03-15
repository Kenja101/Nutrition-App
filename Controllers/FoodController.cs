using System.Collections.Generic;
using NutritionApp.Data;
using NutritionApp.Models;

namespace NutritionApp.Controllers
{
    public class FoodController
    {
        private FoodRepository repo = new FoodRepository();

        public List<FoodProduct> GetAllFoods()
        {
            return repo.GetAll();
        }

        public FoodProduct GetById(int id)
        {
            List<FoodProduct> foods = repo.GetAll();
            foreach (FoodProduct f in foods)
            {
                if (f.Id == id)
                    return f;
            }
            return null;
        }
    }
}
