using System;
using System.Windows.Forms;
using NutritionApp.Controllers;
using NutritionApp.Models;

namespace NutritionApp.Views
{
    public partial class LoginForm : Form
    {
        private UserController userCtrl = new UserController();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter email and password.");
                return;
            }

            User user = userCtrl.Login(email, password);

            if (user == null)
            {
                MessageBox.Show("Email or password is wrong.");
                return;
            }

            DashboardForm dashboard = new DashboardForm(user);
            dashboard.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Close();
        }
    }
}
