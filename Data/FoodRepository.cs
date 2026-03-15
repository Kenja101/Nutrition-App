using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using NutritionApp.Models;

namespace NutritionApp.Data
{
    public class FoodRepository
    {
        public List<FoodProduct> GetAll()
        {
            try
            {
                if (!File.Exists(DataPaths.FoodsFile))
                    return new List<FoodProduct>();

                string text = File.ReadAllText(DataPaths.FoodsFile);
                return JsonConvert.DeserializeObject<List<FoodProduct>>(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading foods: " + ex.Message);
                return new List<FoodProduct>();
            }
        }
    }
}
