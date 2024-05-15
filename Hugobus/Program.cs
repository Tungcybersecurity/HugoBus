using GUI.Home;
using GUI.Login;
using GUI.Student;
using GUI.Student.InfomationStudent;

namespace Hugobus
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
            
        }
    }
}