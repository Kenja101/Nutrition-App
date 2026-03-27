namespace NutritionApp.Views
{
    partial class StatisticsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblTotalMenus;
        private System.Windows.Forms.Label lblTotalDays;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblGoalDays;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label lblAvgCalories;
        private System.Windows.Forms.Label lblTotalProtein;
        private System.Windows.Forms.Label lblAvgProtein;
        private System.Windows.Forms.Label lblTotalCarbs;
        private System.Windows.Forms.Label lblAvgCarbs;
        private System.Windows.Forms.Label lblTotalFat;
        private System.Windows.Forms.Label lblAvgFat;
        private System.Windows.Forms.Label lblDailyTitle;
        private System.Windows.Forms.ListBox lstDaily;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnCalculate;
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
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblTotalMenus = new System.Windows.Forms.Label();
            this.lblTotalDays = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblGoalDays = new System.Windows.Forms.Label();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.lblAvgCalories = new System.Windows.Forms.Label();
            this.lblTotalProtein = new System.Windows.Forms.Label();
            this.lblAvgProtein = new System.Windows.Forms.Label();
            this.lblTotalCarbs = new System.Windows.Forms.Label();
            this.lblAvgCarbs = new System.Windows.Forms.Label();
            this.lblTotalFat = new System.Windows.Forms.Label();
            this.lblAvgFat = new System.Windows.Forms.Label();
            this.lblDailyTitle = new System.Windows.Forms.Label();
            this.lstDaily = new System.Windows.Forms.ListBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.Text = "Nutrition App - Statistics";
            this.Size = new System.Drawing.Size(620, 820);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.lblTitle.Text = "Statistics";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Size = new System.Drawing.Size(200, 35);

            this.lblStartDate.Text = "From:";
            this.lblStartDate.Location = new System.Drawing.Point(30, 65);
            this.lblStartDate.Size = new System.Drawing.Size(80, 25);
            this.dtpStart.Location = new System.Drawing.Point(120, 65);
            this.dtpStart.Size = new System.Drawing.Size(440, 25);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblEndDate.Text = "To:";
            this.lblEndDate.Location = new System.Drawing.Point(30, 100);
            this.lblEndDate.Size = new System.Drawing.Size(80, 25);
            this.dtpEnd.Location = new System.Drawing.Point(120, 100);
            this.dtpEnd.Size = new System.Drawing.Size(440, 25);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Location = new System.Drawing.Point(120, 135);
            this.btnCalculate.Size = new System.Drawing.Size(440, 35);
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            this.lblTotalMenus.Text = "Total Menus: -";
            this.lblTotalMenus.Location = new System.Drawing.Point(30, 185);
            this.lblTotalMenus.Size = new System.Drawing.Size(260, 22);

            this.lblTotalDays.Text = "Days Tracked: -";
            this.lblTotalDays.Location = new System.Drawing.Point(310, 185);
            this.lblTotalDays.Size = new System.Drawing.Size(260, 22);

            this.lblGoal.Text = "Daily Goal: -";
            this.lblGoal.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblGoal.Location = new System.Drawing.Point(30, 210);
            this.lblGoal.Size = new System.Drawing.Size(260, 22);

            this.lblGoalDays.Text = "Days Goal Met: -";
            this.lblGoalDays.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblGoalDays.Location = new System.Drawing.Point(310, 210);
            this.lblGoalDays.Size = new System.Drawing.Size(260, 22);

            this.lblTotalCalories.Text = "Total Calories: -";
            this.lblTotalCalories.Location = new System.Drawing.Point(30, 245);
            this.lblTotalCalories.Size = new System.Drawing.Size(260, 22);

            this.lblAvgCalories.Text = "Avg/Day: -";
            this.lblAvgCalories.Location = new System.Drawing.Point(310, 245);
            this.lblAvgCalories.Size = new System.Drawing.Size(260, 22);

            this.lblTotalProtein.Text = "Total Protein: -";
            this.lblTotalProtein.Location = new System.Drawing.Point(30, 275);
            this.lblTotalProtein.Size = new System.Drawing.Size(260, 22);

            this.lblAvgProtein.Text = "Avg/Day: -";
            this.lblAvgProtein.Location = new System.Drawing.Point(310, 275);
            this.lblAvgProtein.Size = new System.Drawing.Size(260, 22);

            this.lblTotalCarbs.Text = "Total Carbs: -";
            this.lblTotalCarbs.Location = new System.Drawing.Point(30, 305);
            this.lblTotalCarbs.Size = new System.Drawing.Size(260, 22);

            this.lblAvgCarbs.Text = "Avg/Day: -";
            this.lblAvgCarbs.Location = new System.Drawing.Point(310, 305);
            this.lblAvgCarbs.Size = new System.Drawing.Size(260, 22);

            this.lblTotalFat.Text = "Total Fat: -";
            this.lblTotalFat.Location = new System.Drawing.Point(30, 335);
            this.lblTotalFat.Size = new System.Drawing.Size(260, 22);

            this.lblAvgFat.Text = "Avg/Day: -";
            this.lblAvgFat.Location = new System.Drawing.Point(310, 335);
            this.lblAvgFat.Size = new System.Drawing.Size(260, 22);

            this.lblDailyTitle.Text = "Daily Breakdown (OK = goal met, MISS = goal missed):";
            this.lblDailyTitle.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            this.lblDailyTitle.Location = new System.Drawing.Point(30, 370);
            this.lblDailyTitle.Size = new System.Drawing.Size(540, 20);

            this.lstDaily.Location = new System.Drawing.Point(30, 395);
            this.lstDaily.Size = new System.Drawing.Size(560, 310);

            this.btnBack.Text = "Back to Dashboard";
            this.btnBack.Location = new System.Drawing.Point(30, 715);
            this.btnBack.Size = new System.Drawing.Size(180, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalMenus);
            this.Controls.Add(this.lblTotalDays);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblGoalDays);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.lblAvgCalories);
            this.Controls.Add(this.lblTotalProtein);
            this.Controls.Add(this.lblAvgProtein);
            this.Controls.Add(this.lblTotalCarbs);
            this.Controls.Add(this.lblAvgCarbs);
            this.Controls.Add(this.lblTotalFat);
            this.Controls.Add(this.lblAvgFat);
            this.Controls.Add(this.lblDailyTitle);
            this.Controls.Add(this.lstDaily);
            this.Controls.Add(this.btnBack);
        }
    }
}
