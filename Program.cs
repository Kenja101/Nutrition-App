using System;
using System.Windows.Forms;
using NutritionApp.Data;
using NutritionApp.Views;

namespace NutritionApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DataPaths.EnsureFoldersExist();

            LoginForm login = new LoginForm();
            login.Show();
            Application.Run();
        }
    }
}