namespace NutritionApp.Views
{
    partial class EditProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblDietType;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.ComboBox cmbGoal;
        private System.Windows.Forms.ComboBox cmbDietType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblDietType = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.cmbGoal = new System.Windows.Forms.ComboBox();
            this.cmbDietType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.Text = "Edit Profile";
            this.Size = new System.Drawing.Size(420, 530);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.lblTitle.Text = "Edit Your Profile";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(80, 15);
            this.lblTitle.Size = new System.Drawing.Size(260, 30);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblFullName.Text = "Full Name:";
            this.lblFullName.Location = new System.Drawing.Point(30, 60);
            this.lblFullName.Size = new System.Drawing.Size(110, 25);
            this.txtFullName.Location = new System.Drawing.Point(160, 60);
            this.txtFullName.Size = new System.Drawing.Size(210, 25);

            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(30, 95);
            this.lblEmail.Size = new System.Drawing.Size(110, 25);
            this.txtEmail.Location = new System.Drawing.Point(160, 95);
            this.txtEmail.Size = new System.Drawing.Size(210, 25);

            this.lblAge.Text = "Age:";
            this.lblAge.Location = new System.Drawing.Point(30, 130);
            this.lblAge.Size = new System.Drawing.Size(110, 25);
            this.nudAge.Location = new System.Drawing.Point(160, 130);
            this.nudAge.Size = new System.Drawing.Size(210, 25);
            this.nudAge.Minimum = 1;
            this.nudAge.Maximum = 120;

            this.lblWeight.Text = "Weight (kg):";
            this.lblWeight.Location = new System.Drawing.Point(30, 165);
            this.lblWeight.Size = new System.Drawing.Size(110, 25);
            this.nudWeight.Location = new System.Drawing.Point(160, 165);
            this.nudWeight.Size = new System.Drawing.Size(210, 25);
            this.nudWeight.Minimum = 1;
            this.nudWeight.Maximum = 300;
            this.nudWeight.DecimalPlaces = 0;

            this.lblHeight.Text = "Height (cm):";
            this.lblHeight.Location = new System.Drawing.Point(30, 200);
            this.lblHeight.Size = new System.Drawing.Size(110, 25);
            this.nudHeight.Location = new System.Drawing.Point(160, 200);
            this.nudHeight.Size = new System.Drawing.Size(210, 25);
            this.nudHeight.Minimum = 1;
            this.nudHeight.Maximum = 250;
            this.nudHeight.DecimalPlaces = 0;

            this.lblActivity.Text = "Activity Level:";
            this.lblActivity.Location = new System.Drawing.Point(30, 235);
            this.lblActivity.Size = new System.Drawing.Size(110, 25);
            this.cmbActivity.Location = new System.Drawing.Point(160, 235);
            this.cmbActivity.Size = new System.Drawing.Size(210, 25);
            this.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivity.Items.AddRange(new string[] { "Sedentary", "Light", "Moderate", "Active" });
            this.cmbActivity.SelectedIndex = 0;

            this.lblGoal.Text = "Goal:";
            this.lblGoal.Location = new System.Drawing.Point(30, 270);
            this.lblGoal.Size = new System.Drawing.Size(110, 25);
            this.cmbGoal.Location = new System.Drawing.Point(160, 270);
            this.cmbGoal.Size = new System.Drawing.Size(210, 25);
            this.cmbGoal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGoal.Items.AddRange(new string[] { "MaintainWeight", "LoseFat", "GainMuscle" });
            this.cmbGoal.SelectedIndex = 0;

            this.lblDietType.Text = "Diet Type:";
            this.lblDietType.Location = new System.Drawing.Point(30, 305);
            this.lblDietType.Size = new System.Drawing.Size(110, 25);
            this.cmbDietType.Location = new System.Drawing.Point(160, 305);
            this.cmbDietType.Size = new System.Drawing.Size(210, 25);
            this.cmbDietType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDietType.Items.AddRange(new string[] { "Standard", "Keto", "Vegetarian" });
            this.cmbDietType.SelectedIndex = 0;

            this.btnSave.Text = "Save Changes";
            this.btnSave.Location = new System.Drawing.Point(160, 355);
            this.btnSave.Size = new System.Drawing.Size(210, 35);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(160, 400);
            this.btnCancel.Size = new System.Drawing.Size(210, 35);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblDietType);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.cmbActivity);
            this.Controls.Add(this.cmbGoal);
            this.Controls.Add(this.cmbDietType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
        }
    }
}
