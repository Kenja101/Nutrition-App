namespace NutritionApp.Views
{
    partial class MenuListForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMenusTitle;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.Label lblItemsTitle;
        private System.Windows.Forms.ListBox lstMenus;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label lblDetailName;
        private System.Windows.Forms.Label lblDetailDate;
        private System.Windows.Forms.Label lblDetailMealTime;
        private System.Windows.Forms.Label lblDetailCalories;
        private System.Windows.Forms.Label lblDetailProtein;
        private System.Windows.Forms.Label lblDetailCarbs;
        private System.Windows.Forms.Label lblDetailFat;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSuggested;
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
            this.lblMenusTitle = new System.Windows.Forms.Label();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.lblItemsTitle = new System.Windows.Forms.Label();
            this.lstMenus = new System.Windows.Forms.ListBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lblDetailName = new System.Windows.Forms.Label();
            this.lblDetailDate = new System.Windows.Forms.Label();
            this.lblDetailMealTime = new System.Windows.Forms.Label();
            this.lblDetailCalories = new System.Windows.Forms.Label();
            this.lblDetailProtein = new System.Windows.Forms.Label();
            this.lblDetailCarbs = new System.Windows.Forms.Label();
            this.lblDetailFat = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSuggested = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.Text = "Nutrition App - My Menus";
            this.Size = new System.Drawing.Size(850, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.lblTitle.Text = "My Menus";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Size = new System.Drawing.Size(300, 35);

            this.lblMenusTitle.Text = "Menu List";
            this.lblMenusTitle.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblMenusTitle.Location = new System.Drawing.Point(30, 58);
            this.lblMenusTitle.Size = new System.Drawing.Size(200, 20);

            this.lstMenus.Location = new System.Drawing.Point(30, 80);
            this.lstMenus.Size = new System.Drawing.Size(790, 200);
            this.lstMenus.SelectedIndexChanged += new System.EventHandler(this.lstMenus_SelectedIndexChanged);

            this.btnCreate.Text = "New Menu";
            this.btnCreate.Location = new System.Drawing.Point(30, 295);
            this.btnCreate.Size = new System.Drawing.Size(150, 35);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);

            this.btnEdit.Text = "Edit Menu";
            this.btnEdit.Location = new System.Drawing.Point(190, 295);
            this.btnEdit.Size = new System.Drawing.Size(150, 35);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Text = "Delete Menu";
            this.btnDelete.Location = new System.Drawing.Point(350, 295);
            this.btnDelete.Size = new System.Drawing.Size(150, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnSuggested.Text = "Suggested Menus";
            this.btnSuggested.Location = new System.Drawing.Point(510, 295);
            this.btnSuggested.Size = new System.Drawing.Size(160, 35);
            this.btnSuggested.Click += new System.EventHandler(this.btnSuggested_Click);

            this.lblDetailsTitle.Text = "Menu Details";
            this.lblDetailsTitle.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblDetailsTitle.Location = new System.Drawing.Point(30, 345);
            this.lblDetailsTitle.Size = new System.Drawing.Size(200, 20);

            this.lblDetailName.Text = "Name: -";
            this.lblDetailName.Location = new System.Drawing.Point(30, 370);
            this.lblDetailName.Size = new System.Drawing.Size(250, 22);

            this.lblDetailDate.Text = "Date: -";
            this.lblDetailDate.Location = new System.Drawing.Point(30, 395);
            this.lblDetailDate.Size = new System.Drawing.Size(250, 22);

            this.lblDetailMealTime.Text = "Meal: -";
            this.lblDetailMealTime.Location = new System.Drawing.Point(30, 420);
            this.lblDetailMealTime.Size = new System.Drawing.Size(250, 22);

            this.lblDetailCalories.Text = "Calories: -";
            this.lblDetailCalories.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblDetailCalories.Location = new System.Drawing.Point(30, 445);
            this.lblDetailCalories.Size = new System.Drawing.Size(250, 22);

            this.lblDetailProtein.Text = "Protein: -";
            this.lblDetailProtein.Location = new System.Drawing.Point(300, 370);
            this.lblDetailProtein.Size = new System.Drawing.Size(200, 22);

            this.lblDetailCarbs.Text = "Carbs: -";
            this.lblDetailCarbs.Location = new System.Drawing.Point(300, 395);
            this.lblDetailCarbs.Size = new System.Drawing.Size(200, 22);

            this.lblDetailFat.Text = "Fat: -";
            this.lblDetailFat.Location = new System.Drawing.Point(300, 420);
            this.lblDetailFat.Size = new System.Drawing.Size(200, 22);

            this.lblItemsTitle.Text = "Food Items in this Menu";
            this.lblItemsTitle.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblItemsTitle.Location = new System.Drawing.Point(30, 475);
            this.lblItemsTitle.Size = new System.Drawing.Size(300, 20);

            this.lstItems.Location = new System.Drawing.Point(30, 498);
            this.lstItems.Size = new System.Drawing.Size(790, 65);

            this.btnBack.Text = "Back to Dashboard";
            this.btnBack.Location = new System.Drawing.Point(30, 573);
            this.btnBack.Size = new System.Drawing.Size(180, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMenusTitle);
            this.Controls.Add(this.lstMenus);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSuggested);
            this.Controls.Add(this.lblDetailsTitle);
            this.Controls.Add(this.lblDetailName);
            this.Controls.Add(this.lblDetailDate);
            this.Controls.Add(this.lblDetailMealTime);
            this.Controls.Add(this.lblDetailCalories);
            this.Controls.Add(this.lblDetailProtein);
            this.Controls.Add(this.lblDetailCarbs);
            this.Controls.Add(this.lblDetailFat);
            this.Controls.Add(this.lblItemsTitle);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnBack);
        }
    }
}
