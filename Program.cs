namespace Hospital_System.UI
{
    using Hospital_System.UI.UIManagers;
    using System;
    using System.Windows.Forms;
    


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var settingsManager = new SettingsManagerRe();
            //settingsManager.ShowManagmentForm(true,true);

            Application.Run(new LoginForm());


        }
    }
}
