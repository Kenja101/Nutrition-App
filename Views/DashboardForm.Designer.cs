namespace NutritionApp.Views
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblDietType;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.Label lblGoalCalories;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Button btnMyMenus;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblDietType = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.lblGoalCalories = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.btnMyMenus = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.Text = "Nutrition App - Dashboard";
            this.Size = new System.Drawing.Size(480, 580);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(30, 15);
            this.lblWelcome.Size = new System.Drawing.Size(420, 35);

            this.lblEmail.Text = "Email: ";
            this.lblEmail.Location = new System.Drawing.Point(30, 60);
            this.lblEmail.Size = new System.Drawing.Size(420, 22);

            this.lblAge.Text = "Age: ";
            this.lblAge.Location = new System.Drawing.Point(30, 85);
            this.lblAge.Size = new System.Drawing.Size(200, 22);

            this.lblWeight.Text = "Weight: ";
            this.lblWeight.Location = new System.Drawing.Point(230, 85);
            this.lblWeight.Size = new System.Drawing.Size(200, 22);

            this.lblHeight.Text = "Height: ";
            this.lblHeight.Location = new System.Drawing.Point(30, 110);
            this.lblHeight.Size = new System.Drawing.Size(200, 22);

            this.lblActivity.Text = "Activity: ";
            this.lblActivity.Location = new System.Drawing.Point(230, 110);
            this.lblActivity.Size = new System.Drawing.Size(200, 22);

            this.lblGoal.Text = "Goal: ";
            this.lblGoal.Location = new System.Drawing.Point(30, 135);
            this.lblGoal.Size = new System.Drawing.Size(200, 22);

            this.lblDietType.Text = "Diet: ";
            this.lblDietType.Location = new System.Drawing.Point(230, 135);
            this.lblDietType.Size = new System.Drawing.Size(200, 22);

            this.lblBMI.Text = "BMI: ";
            this.lblBMI.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.lblBMI.Location = new System.Drawing.Point(30, 175);
            this.lblBMI.Size = new System.Drawing.Size(420, 22);

            this.lblMaintenance.Text = "Maintenance Calories: ";
            this.lblMaintenance.Location = new System.Drawing.Point(30, 205);
            this.lblMaintenance.Size = new System.Drawing.Size(420, 22);

            this.lblGoalCalories.Text = "Daily Goal: ";
            this.lblGoalCalories.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.lblGoalCalories.Location = new System.Drawing.Point(30, 230);
            this.lblGoalCalories.Size = new System.Drawing.Size(420, 22);

            this.lblProtein.Text = "Protein: ";
            this.lblProtein.Location = new System.Drawing.Point(30, 265);
            this.lblProtein.Size = new System.Drawing.Size(420, 22);

            this.lblCarbs.Text = "Carbs: ";
            this.lblCarbs.Location = new System.Drawing.Point(30, 290);
            this.lblCarbs.Size = new System.Drawing.Size(420, 22);

            this.lblFat.Text = "Fat: ";
            this.lblFat.Location = new System.Drawing.Point(30, 315);
            this.lblFat.Size = new System.Drawing.Size(420, 22);

            this.btnMyMenus.Text = "My Menus";
            this.btnMyMenus.Location = new System.Drawing.Point(30, 360);
            this.btnMyMenus.Size = new System.Drawing.Size(180, 35);
            this.btnMyMenus.Click += new System.EventHandler(this.btnMyMenus_Click);

            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.Location = new System.Drawing.Point(230, 360);
            this.btnStatistics.Size = new System.Drawing.Size(180, 35);
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);

            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.Location = new System.Drawing.Point(30, 410);
            this.btnEditProfile.Size = new System.Drawing.Size(180, 35);
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);

            this.btnLogout.Text = "Logout";
            this.btnLogout.Location = new System.Drawing.Point(230, 410);
            this.btnLogout.Size = new System.Drawing.Size(180, 35);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblDietType);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblMaintenance);
            this.Controls.Add(this.lblGoalCalories);
            this.Controls.Add(this.lblProtein);
            this.Controls.Add(this.lblCarbs);
            this.Controls.Add(this.lblFat);
            this.Controls.Add(this.btnMyMenus);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnLogout);
        }
    }
}
