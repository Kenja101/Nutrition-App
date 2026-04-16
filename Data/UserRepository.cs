using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using NutritionApp.Models;

namespace NutritionApp.Data
{
    public class UserRepository
    {
        public List<User> GetAll()
        {
            try
            {
                if (!File.Exists(DataPaths.UsersFile))
                    return new List<User>();

                string text = File.ReadAllText(DataPaths.UsersFile);
                return JsonConvert.DeserializeObject<List<User>>(text);
            }
    catch (Exception ex)
    {
        throw new Exception("Error loading users: " + ex.Message);
    }
        }

        public void SaveAll(List<User> users)
        {
            try
            {
                string text = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(DataPaths.UsersFile, text);
            }
    catch (Exception ex)
    {
        throw new Exception("Error saving users: " + ex.Message);
    }
        }
    }
}
