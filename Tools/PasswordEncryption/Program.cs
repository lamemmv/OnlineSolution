using SimpleInjector;
using System;
using System.Windows.Forms;

namespace PasswordEncryption
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new Container();
            DependencyConfig.RegisterContainer(container);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(container));
        }
    }
}
