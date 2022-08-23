using Templar.Aplication.Processes.LoadProject;
using Templar.Aplication.Processes.PrepareProject;
using Templar.UI;

namespace Templar
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ApplicationService.MainForm = new MainForm();

            Application.Run(ApplicationService.MainForm);
        }
    }
}