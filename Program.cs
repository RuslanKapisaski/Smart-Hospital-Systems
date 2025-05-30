namespace Hospital_System.UI
{
    using Hospital_System.DAL.DB;
    using Hospital_System.DAL.Models;
    using Hospital_System.DAL.Services;
    using Hospital_System.UI.UIManagers;
    using Mapster;
    using System;
    using System.Windows.Forms;
    


    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MapsterConfiguration();
            Application.Run(new LoginForm());

        }

        //Case insensitive configuration
        static void MapsterConfiguration()
        {
            TypeAdapterConfig.GlobalSettings.Default.NameMatchingStrategy(NameMatchingStrategy.IgnoreCase);
        }
    }
}
