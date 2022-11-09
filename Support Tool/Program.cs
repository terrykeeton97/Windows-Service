using System;
using System.Windows.Forms;
using Support_Tool.Classes;
namespace Support_Tool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Form());
        }
        internal static void Init()
        {
            Utils.RenameFile(Utils.RandomStringWithSuffix(10, ".exe"));
        }
    }
}
