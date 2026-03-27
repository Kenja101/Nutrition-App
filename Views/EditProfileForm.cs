using System;
using System.Windows.Forms;
using NutritionApp.Controllers;
using NutritionApp.Models;

namespace NutritionApp.Views
{
    public partial class EditProfileForm : Form
    {
        private User currentUser;
        private UserController userCtrl = new UserController();

        public EditProfileForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadData();
        }

        private void LoadData()
        {
            txtFullName.Text = currentUser.FullName;
            txtEmail.Text = currentUser.Email;
            nudAge.Value = currentUser.Age;
            nudWeight.Value = (decimal)currentUser.Weight;
            nudHeight.Value = (decimal)currentUser.Height;
            cmbActivity.SelectedItem = currentUser.ActivityLevel;
            cmbGoal.SelectedItem = currentUser.Goal;
            cmbDietType.SelectedItem = currentUser.DietType;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Trim() == "" || txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Name and email are required.");
                return;
            }

            currentUser.FullName = txtFullName.Text.Trim();
            currentUser.Email = txtEmail.Text.Trim();
            currentUser.Age = (int)nudAge.Value;
            currentUser.Weight = (double)nudWeight.Value;
            currentUser.Height = (double)nudHeight.Value;
            currentUser.ActivityLevel = cmbActivity.SelectedItem.ToString();
            currentUser.Goal = cmbGoal.SelectedItem.ToString();
            currentUser.DietType = cmbDietType.SelectedItem.ToString();

            userCtrl.UpdateUser(currentUser);
            MessageBox.Show("Profile updated.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
