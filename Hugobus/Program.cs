using GUI.Home;
using GUI.Login;

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
            Application.Run(new Home());

        }
    }
}