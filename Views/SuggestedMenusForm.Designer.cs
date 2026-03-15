namespace NutritionApp.Views
{
    partial class SuggestedMenusForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDietType;
        private System.Windows.Forms.Label lblMenusTitle;
        private System.Windows.Forms.ListBox lstMenus;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.Label lblDetailName;
        private System.Windows.Forms.Label lblDetailMeal;
        private System.Windows.Forms.Label lblDetailCalories;
        private System.Windows.Forms.Label lblDetailProtein;
        private System.Windows.Forms.Label lblDetailCarbs;
        private System.Windows.Forms.Label lblDetailFat;
        private System.Windows.Forms.Label lblItemsTitle;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDietType = new System.Windows.Forms.Label();
            this.lblMenusTitle = new System.Windows.Forms.Label();
            this.lstMenus = new System.Windows.Forms.ListBox();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.lblDetailName = new System.Windows.Forms.Label();
            this.lblDetailMeal = new System.Windows.Forms.Label();
            this.lblDetailCalories = new System.Windows.Forms.Label();
            this.lblDetailProtein = new System.Windows.Forms.Label();
            this.lblDetailCarbs = new System.Windows.Forms.Label();
            this.lblDetailFat = new System.Windows.Forms.Label();
            this.lblItemsTitle = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.Text = "Nutrition App - Suggested Menus";
            this.Size = new System.Drawing.Size(700, 630);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.lblTitle.Text = "Suggested Menus";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Size = new System.Drawing.Size(400, 35);

            this.lblDietType.Text = "Diet Type: -";
            this.lblDietType.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.lblDietType.Location = new System.Drawing.Point(30, 55);
            this.lblDietType.Size = new System.Drawing.Size(300, 25);

            this.lblMenusTitle.Text = "Select a suggested menu:";
            this.lblMenusTitle.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblMenusTitle.Location = new System.Drawing.Point(30, 88);
            this.lblMenusTitle.Size = new System.Drawing.Size(300, 20);

            this.lstMenus.Location = new System.Drawing.Point(30, 110);
            this.lstMenus.Size = new System.Drawing.Size(640, 150);
            this.lstMenus.SelectedIndexChanged += new System.EventHandler(this.lstMenus_SelectedIndexChanged);

            this.lblDetailsTitle.Text = "Menu Details:";
            this.lblDetailsTitle.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblDetailsTitle.Location = new System.Drawing.Point(30, 275);
            this.lblDetailsTitle.Size = new System.Drawing.Size(300, 20);

            this.lblDetailName.Text = "Name: -";
            this.lblDetailName.Location = new System.Drawing.Point(30, 298);
            this.lblDetailName.Size = new System.Drawing.Size(300, 22);

            this.lblDetailMeal.Text = "Meal: -";
            this.lblDetailMeal.Location = new System.Drawing.Point(30, 323);
            this.lblDetailMeal.Size = new System.Drawing.Size(300, 22);

            this.lblDetailCalories.Text = "Calories: -";
            this.lblDetailCalories.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblDetailCalories.Location = new System.Drawing.Point(30, 348);
            this.lblDetailCalories.Size = new System.Drawing.Size(300, 22);

            this.lblDetailProtein.Text = "Protein: -";
            this.lblDetailProtein.Location = new System.Drawing.Point(350, 298);
            this.lblDetailProtein.Size = new System.Drawing.Size(300, 22);

            this.lblDetailCarbs.Text = "Carbs: -";
            this.lblDetailCarbs.Location = new System.Drawing.Point(350, 323);
            this.lblDetailCarbs.Size = new System.Drawing.Size(300, 22);

            this.lblDetailFat.Text = "Fat: -";
            this.lblDetailFat.Location = new System.Drawing.Point(350, 348);
            this.lblDetailFat.Size = new System.Drawing.Size(300, 22);

            this.lblItemsTitle.Text = "Foods in this menu:";
            this.lblItemsTitle.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblItemsTitle.Location = new System.Drawing.Point(30, 380);
            this.lblItemsTitle.Size = new System.Drawing.Size(300, 20);

            this.lstItems.Location = new System.Drawing.Point(30, 403);
            this.lstItems.Size = new System.Drawing.Size(640, 120);

            this.btnBack.Text = "Back";
            this.btnBack.Location = new System.Drawing.Point(30, 538);
            this.btnBack.Size = new System.Drawing.Size(160, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.btnAdd.Text = "Add to My Menus";
            this.btnAdd.Location = new System.Drawing.Point(480, 538);
            this.btnAdd.Size = new System.Drawing.Size(160, 35);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDietType);
            this.Controls.Add(this.lblMenusTitle);
            this.Controls.Add(this.lstMenus);
            this.Controls.Add(this.lblDetailsTitle);
            this.Controls.Add(this.lblDetailName);
            this.Controls.Add(this.lblDetailMeal);
            this.Controls.Add(this.lblDetailCalories);
            this.Controls.Add(this.lblDetailProtein);
            this.Controls.Add(this.lblDetailCarbs);
            this.Controls.Add(this.lblDetailFat);
            this.Controls.Add(this.lblItemsTitle);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
        }
    }
}
