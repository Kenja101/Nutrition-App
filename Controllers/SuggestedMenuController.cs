using System;
using System.Collections.Generic;
using NutritionApp.Models;
using Menu = NutritionApp.Models.Menu;
using MenuItem = NutritionApp.Models.MenuItem;

namespace NutritionApp.Controllers
{
    public class SuggestedMenuController
    {
        private FoodController foodCtrl = new FoodController();
        private MenuController menuCtrl = new MenuController();

        public List<Menu> GetSuggestedMenus(string dietType, int userId)
        {
            List<FoodProduct> foods = foodCtrl.GetAllFoods();

            if (dietType == "Keto")
                return BuildKetoMenus(foods, userId);
            else if (dietType == "Vegetarian")
                return BuildVegetarianMenus(foods, userId);
            else
                return BuildStandardMenus(foods, userId);
        }

        public void SaveMenu(Menu menu)
        {
            menuCtrl.CreateMenu(menu);
        }

        private Menu MakeMenu(int userId, string name, string mealTime)
        {
            Menu m = new Menu();
            m.UserId = userId;
            m.Name = name;
            m.MealTime = mealTime;
            m.Date = DateTime.Today;
            m.Items = new List<MenuItem>();
            return m;
        }

        private void AddFood(Menu menu, FoodProduct food)
        {
            if (food == null) return;

            MenuItem item = new MenuItem();
            item.FoodProductId = food.Id;
            item.FoodName = food.Name;
            item.PortionGrams = food.PortionGrams;
            item.Calories = food.Calories;
            item.Protein = food.Protein;
            item.Carbohydrates = food.Carbohydrates;
            item.Fat = food.Fat;
            menu.Items.Add(item);
            menuCtrl.CalculateTotals(menu);
        }

        private FoodProduct Find(List<FoodProduct> foods, string name)
        {
            foreach (FoodProduct f in foods)
            {
                if (f.Name == name)
                    return f;
            }
            return null;
        }

        private List<Menu> BuildStandardMenus(List<FoodProduct> foods, int userId)
        {
            List<Menu> list = new List<Menu>();

            Menu b1 = MakeMenu(userId, "Standard Breakfast 1", "Breakfast");
            AddFood(b1, Find(foods, "Scrambled Eggs"));
            AddFood(b1, Find(foods, "Whole Wheat Bread"));
            AddFood(b1, Find(foods, "Orange Juice"));
            list.Add(b1);

            Menu b2 = MakeMenu(userId, "Standard Breakfast 2", "Breakfast");
            AddFood(b2, Find(foods, "Oatmeal"));
            AddFood(b2, Find(foods, "Banana"));
            AddFood(b2, Find(foods, "Greek Yogurt"));
            list.Add(b2);

            Menu s1 = MakeMenu(userId, "Standard Snack 1", "Snack");
            AddFood(s1, Find(foods, "Apple with Peanut Butter"));
            AddFood(s1, Find(foods, "Greek Yogurt with Honey"));
            list.Add(s1);

            Menu s2 = MakeMenu(userId, "Standard Snack 2", "Snack");
            AddFood(s2, Find(foods, "Almonds"));
            AddFood(s2, Find(foods, "Fruit Salad"));
            list.Add(s2);

            Menu l1 = MakeMenu(userId, "Standard Lunch 1", "Lunch");
            AddFood(l1, Find(foods, "Chicken Breast"));
            AddFood(l1, Find(foods, "Brown Rice"));
            AddFood(l1, Find(foods, "Broccoli"));
            list.Add(l1);

            Menu l2 = MakeMenu(userId, "Standard Lunch 2", "Lunch");
            AddFood(l2, Find(foods, "Tuna Salad"));
            AddFood(l2, Find(foods, "Whole Wheat Bread"));
            list.Add(l2);

            Menu d1 = MakeMenu(userId, "Standard Dinner 1", "Dinner");
            AddFood(d1, Find(foods, "Grilled Chicken"));
            AddFood(d1, Find(foods, "Roasted Vegetables"));
            AddFood(d1, Find(foods, "Baked Potato"));
            list.Add(d1);

            Menu d2 = MakeMenu(userId, "Standard Dinner 2", "Dinner");
            AddFood(d2, Find(foods, "Pasta Bolognese"));
            AddFood(d2, Find(foods, "Spinach Salad"));
            list.Add(d2);

            return list;
        }

        private List<Menu> BuildKetoMenus(List<FoodProduct> foods, int userId)
        {
            List<Menu> list = new List<Menu>();

            Menu b1 = MakeMenu(userId, "Keto Breakfast 1", "Breakfast");
            AddFood(b1, Find(foods, "Scrambled Eggs"));
            AddFood(b1, Find(foods, "Bacon"));
            AddFood(b1, Find(foods, "Avocado"));
            list.Add(b1);

            Menu b2 = MakeMenu(userId, "Keto Breakfast 2", "Breakfast");
            AddFood(b2, Find(foods, "Keto Pancakes"));
            AddFood(b2, Find(foods, "Cottage Cheese"));
            list.Add(b2);

            Menu s1 = MakeMenu(userId, "Keto Snack 1", "Snack");
            AddFood(s1, Find(foods, "Almonds"));
            AddFood(s1, Find(foods, "Cheese Slice"));
            list.Add(s1);

            Menu s2 = MakeMenu(userId, "Keto Snack 2", "Snack");
            AddFood(s2, Find(foods, "Keto Fat Bombs"));
            AddFood(s2, Find(foods, "Celery with Cream Cheese"));
            list.Add(s2);

            Menu l1 = MakeMenu(userId, "Keto Lunch 1", "Lunch");
            AddFood(l1, Find(foods, "Salmon"));
            AddFood(l1, Find(foods, "Greek Salad"));
            list.Add(l1);

            Menu l2 = MakeMenu(userId, "Keto Lunch 2", "Lunch");
            AddFood(l2, Find(foods, "Chicken Breast"));
            AddFood(l2, Find(foods, "Caprese Salad"));
            list.Add(l2);

            Menu d1 = MakeMenu(userId, "Keto Dinner 1", "Dinner");
            AddFood(d1, Find(foods, "Keto Chicken Bowl"));
            AddFood(d1, Find(foods, "Sauteed Spinach"));
            list.Add(d1);

            Menu d2 = MakeMenu(userId, "Keto Dinner 2", "Dinner");
            AddFood(d2, Find(foods, "Beef Steak"));
            AddFood(d2, Find(foods, "Cauliflower Rice"));
            list.Add(d2);

            return list;
        }

        private List<Menu> BuildVegetarianMenus(List<FoodProduct> foods, int userId)
        {
            List<Menu> list = new List<Menu>();

            Menu b1 = MakeMenu(userId, "Vegetarian Breakfast 1", "Breakfast");
            AddFood(b1, Find(foods, "Tofu Scramble"));
            AddFood(b1, Find(foods, "Whole Wheat Bread"));
            AddFood(b1, Find(foods, "Orange Juice"));
            list.Add(b1);

            Menu b2 = MakeMenu(userId, "Vegetarian Breakfast 2", "Breakfast");
            AddFood(b2, Find(foods, "Overnight Oats"));
            AddFood(b2, Find(foods, "Strawberries"));
            AddFood(b2, Find(foods, "Almond Milk"));
            list.Add(b2);

            Menu s1 = MakeMenu(userId, "Vegetarian Snack 1", "Snack");
            AddFood(s1, Find(foods, "Hummus with Carrots"));
            AddFood(s1, Find(foods, "Veggie Sticks"));
            list.Add(s1);

            Menu s2 = MakeMenu(userId, "Vegetarian Snack 2", "Snack");
            AddFood(s2, Find(foods, "Mixed Berries"));
            AddFood(s2, Find(foods, "Greek Yogurt"));
            list.Add(s2);

            Menu l1 = MakeMenu(userId, "Vegetarian Lunch 1", "Lunch");
            AddFood(l1, Find(foods, "Lentil Soup"));
            AddFood(l1, Find(foods, "Brown Rice"));
            list.Add(l1);

            Menu l2 = MakeMenu(userId, "Vegetarian Lunch 2", "Lunch");
            AddFood(l2, Find(foods, "Chickpea Salad"));
            AddFood(l2, Find(foods, "Veggie Wrap"));
            list.Add(l2);

            Menu d1 = MakeMenu(userId, "Vegetarian Dinner 1", "Dinner");
            AddFood(d1, Find(foods, "Vegetable Curry"));
            AddFood(d1, Find(foods, "Brown Rice"));
            list.Add(d1);

            Menu d2 = MakeMenu(userId, "Vegetarian Dinner 2", "Dinner");
            AddFood(d2, Find(foods, "Vegetarian Lasagna"));
            AddFood(d2, Find(foods, "Spinach Salad"));
            list.Add(d2);

            return list;
        }
    }
}
