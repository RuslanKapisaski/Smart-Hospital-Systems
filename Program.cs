namespace Hospital_System.UI
{
    using Hospital_System.DAL.DB;
    using Hospital_System.DAL.Models;
    using Hospital_System.DAL.Services;
    using Hospital_System.UI.UIManagers;
    using System;
    using System.Windows.Forms;
    


    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


           //var dbContext = new HospitalDbContext();
            //var userService = new UserService(dbContext);
            //var settingsManager = new SettingsManagerRe(userService);
            //settingsManager.ShowManagmentForm(isAdmin: false, isDeveloper: true);

            Application.Run(new LoginForm());

        }
    }
}
