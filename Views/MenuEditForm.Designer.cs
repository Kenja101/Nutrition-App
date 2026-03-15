namespace NutritionApp.Views
{
    partial class MenuEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMealTime;
        private System.Windows.Forms.Label lblFoodLabel;
        private System.Windows.Forms.Label lblItemsTitle;
        private System.Windows.Forms.Label lblTotalsTitle;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbMealTime;
        private System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnRemoveFood;
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMealTime = new System.Windows.Forms.Label();
            this.lblFoodLabel = new System.Windows.Forms.Label();
            this.lblItemsTitle = new System.Windows.Forms.Label();
            this.lblTotalsTitle = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbMealTime = new System.Windows.Forms.ComboBox();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnRemoveFood = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.Text = "Nutrition App - Edit Menu";
            this.Size = new System.Drawing.Size(620, 640);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.lblTitle.Text = "Edit Menu";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Size = new System.Drawing.Size(200, 30);

            this.lblName.Text = "Name:";
            this.lblName.Location = new System.Drawing.Point(30, 60);
            this.lblName.Size = new System.Drawing.Size(100, 25);
            this.txtName.Location = new System.Drawing.Point(140, 60);
            this.txtName.Size = new System.Drawing.Size(430, 25);

            this.lblDate.Text = "Date:";
            this.lblDate.Location = new System.Drawing.Point(30, 95);
            this.lblDate.Size = new System.Drawing.Size(100, 25);
            this.dtpDate.Location = new System.Drawing.Point(140, 95);
            this.dtpDate.Size = new System.Drawing.Size(430, 25);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblMealTime.Text = "Meal Time:";
            this.lblMealTime.Location = new System.Drawing.Point(30, 130);
            this.lblMealTime.Size = new System.Drawing.Size(100, 25);
            this.cmbMealTime.Location = new System.Drawing.Point(140, 130);
            this.cmbMealTime.Size = new System.Drawing.Size(430, 25);
            this.cmbMealTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealTime.Items.AddRange(new string[] { "Breakfast", "Lunch", "Dinner", "Snack" });
            this.cmbMealTime.SelectedIndex = 0;

            this.lblFoodLabel.Text = "Add Food:";
            this.lblFoodLabel.Location = new System.Drawing.Point(30, 170);
            this.lblFoodLabel.Size = new System.Drawing.Size(100, 25);
            this.cmbFood.Location = new System.Drawing.Point(140, 170);
            this.cmbFood.Size = new System.Drawing.Size(310, 25);
            this.cmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.btnAddFood.Text = "Add";
            this.btnAddFood.Location = new System.Drawing.Point(460, 170);
            this.btnAddFood.Size = new System.Drawing.Size(110, 25);
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);

            this.lblItemsTitle.Text = "Foods in this menu:";
            this.lblItemsTitle.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblItemsTitle.Location = new System.Drawing.Point(30, 210);
            this.lblItemsTitle.Size = new System.Drawing.Size(300, 20);

            this.lstItems.Location = new System.Drawing.Point(30, 233);
            this.lstItems.Size = new System.Drawing.Size(540, 150);

            this.btnRemoveFood.Text = "Remove Selected";
            this.btnRemoveFood.Location = new System.Drawing.Point(30, 393);
            this.btnRemoveFood.Size = new System.Drawing.Size(160, 30);
            this.btnRemoveFood.Click += new System.EventHandler(this.btnRemoveFood_Click);

            this.lblTotalsTitle.Text = "Totals:";
            this.lblTotalsTitle.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblTotalsTitle.Location = new System.Drawing.Point(30, 438);
            this.lblTotalsTitle.Size = new System.Drawing.Size(100, 20);

            this.lblCalories.Text = "Calories: 0 kcal";
            this.lblCalories.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblCalories.Location = new System.Drawing.Point(30, 460);
            this.lblCalories.Size = new System.Drawing.Size(270, 22);

            this.lblProtein.Text = "Protein: 0 g";
            this.lblProtein.Location = new System.Drawing.Point(310, 460);
            this.lblProtein.Size = new System.Drawing.Size(270, 22);

            this.lblCarbs.Text = "Carbs: 0 g";
            this.lblCarbs.Location = new System.Drawing.Point(30, 485);
            this.lblCarbs.Size = new System.Drawing.Size(270, 22);

            this.lblFat.Text = "Fat: 0 g";
            this.lblFat.Location = new System.Drawing.Point(310, 485);
            this.lblFat.Size = new System.Drawing.Size(270, 22);

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(30, 535);
            this.btnSave.Size = new System.Drawing.Size(150, 35);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(420, 535);
            this.btnCancel.Size = new System.Drawing.Size(150, 35);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMealTime);
            this.Controls.Add(this.lblFoodLabel);
            this.Controls.Add(this.lblItemsTitle);
            this.Controls.Add(this.lblTotalsTitle);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblProtein);
            this.Controls.Add(this.lblCarbs);
            this.Controls.Add(this.lblFat);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbMealTime);
            this.Controls.Add(this.cmbFood);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnRemoveFood);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
        }
    }
}
