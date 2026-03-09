using System;
using System.Windows.Forms;
using NutritionApp.Controllers;
using NutritionApp.Models;

namespace NutritionApp.Views
{
    public partial class RegisterForm : Form
    {
        private UserController userCtrl = new UserController();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            User newUser = new User();
            newUser.FullName = txtFullName.Text.Trim();
            newUser.Email = txtEmail.Text.Trim();
            newUser.Password = txtPassword.Text;
            newUser.Age = (int)nudAge.Value;
            newUser.Weight = (double)nudWeight.Value;
            newUser.Height = (double)nudHeight.Value;
            newUser.ActivityLevel = cmbActivity.SelectedItem.ToString();
            newUser.Goal = cmbGoal.SelectedItem.ToString();
            newUser.DietType = cmbDietType.SelectedItem.ToString();

            bool ok = userCtrl.Register(newUser);

            if (!ok)
            {
                MessageBox.Show("Email already exists.");
                return;
            }

            MessageBox.Show("Account created! Please log in.");
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
