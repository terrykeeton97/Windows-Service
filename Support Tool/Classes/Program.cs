using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
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
            try
            {
                string NEW_NAME = Utils.RandomString();
                var r = new Random();
                var idx = r.Next(NEW_NAME.Length);
                if (File.Exists(NEW_NAME))
                    Init();
                File.Move(Process.GetCurrentProcess().MainModule.FileName, NEW_NAME);
            }
            catch
            { }
        }
    }
}
