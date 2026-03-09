using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NutritionApp.Data;
using NutritionApp.Models;

namespace NutritionApp.Controllers
{
    public class UserController
    {
        private UserRepository repo = new UserRepository();

        public User Login(string email, string password)
        {
            try
            {
                List<User> users = repo.GetAll();
                foreach (User u in users)
                {
                    if (u.Email == email && u.Password == password)
                        return u;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
                return null;
            }
        }

        public bool Register(User newUser)
        {
            try
            {
                List<User> users = repo.GetAll();
                foreach (User u in users)
                {
                    if (u.Email == newUser.Email)
                        return false;
                }

                int maxId = 0;
                foreach (User u in users)
                {
                    if (u.Id > maxId)
                        maxId = u.Id;
                }
                newUser.Id = maxId + 1;

                users.Add(newUser);
                repo.SaveAll(users);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Register error: " + ex.Message);
                return false;
            }
        }

        public void UpdateUser(User updatedUser)
        {
            try
            {
                List<User> users = repo.GetAll();
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Id == updatedUser.Id)
                    {
                        users[i] = updatedUser;
                        break;
                    }
                }
                repo.SaveAll(users);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        public User GetById(int id)
        {
            List<User> users = repo.GetAll();
            foreach (User u in users)
            {
                if (u.Id == id)
                    return u;
            }
            return null;
        }
    }
}
