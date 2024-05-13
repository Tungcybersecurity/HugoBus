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
            Console.WriteLine("hi");
            DAO.Connection.getConnection();

        }
    }
}