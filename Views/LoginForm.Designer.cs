namespace NutritionApp.Views
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();

            this.Text = "Nutrition App - Login";
            this.Size = new System.Drawing.Size(380, 280);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.lblTitle.Text = "Login";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(130, 15);
            this.lblTitle.Size = new System.Drawing.Size(120, 35);

            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(30, 70);
            this.lblEmail.Size = new System.Drawing.Size(80, 25);
            this.txtEmail.Location = new System.Drawing.Point(120, 70);
            this.txtEmail.Size = new System.Drawing.Size(210, 25);

            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(30, 110);
            this.lblPassword.Size = new System.Drawing.Size(80, 25);
            this.txtPassword.Location = new System.Drawing.Point(120, 110);
            this.txtPassword.Size = new System.Drawing.Size(210, 25);
            this.txtPassword.PasswordChar = '*';

            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(120, 155);
            this.btnLogin.Size = new System.Drawing.Size(210, 35);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.btnRegister.Text = "Create Account";
            this.btnRegister.Location = new System.Drawing.Point(120, 200);
            this.btnRegister.Size = new System.Drawing.Size(210, 35);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
        }
    }
}
