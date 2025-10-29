using BuzzLock1._0;
using BuzzLock1._0.View;
using System;
using System.Windows.Forms;

namespace BuzzLock
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database.Initialize();
            Application.Run(new StartPage());
            //no changes/ testing purposes
        }
    }
}
