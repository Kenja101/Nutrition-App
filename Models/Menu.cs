using System;
using System.Collections.Generic;

namespace NutritionApp.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string MealTime { get; set; }
        public List<MenuItem> Items { get; set; }
        public double TotalCalories { get; set; }
        public double TotalProtein { get; set; }
        public double TotalCarbohydrates { get; set; }
        public double TotalFat { get; set; }
    }
}
