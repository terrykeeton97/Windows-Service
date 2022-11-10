using Siticone.Desktop.UI.WinForms;
using Support_Tool.UI;
using System;
using System.Diagnostics;
using System.IO;

using System.Windows.Forms;

namespace Support_Tool.Classes
{
    public class Utils
    {
        public static string RandomString(int numberOfChars)
        {
            if (numberOfChars <= 0) throw new ArgumentException(nameof(numberOfChars));
            string str = null;

            Random random = new Random();
            for (int i = 0; i < numberOfChars; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;
        }

        public static string RandomStringWithSuffix(int numberOfChars, string suffix)
        {
            if (numberOfChars <= 0) throw new ArgumentException("Number of chars must be greater than 0");
            if (string.IsNullOrWhiteSpace(suffix)) throw new ArgumentNullException(nameof(suffix));
            return RandomString(numberOfChars) + suffix;
        }
        public static SiticoneMessageDialog Message(string message, MessageDialogIcon icon, Form HANDLE)
        {
            SiticoneMessageDialog dialog = new SiticoneMessageDialog();
            dialog.Style = MessageDialogStyle.Light;
            dialog.Text = message;
            dialog.Buttons = MessageDialogButtons.OK;
            dialog.Icon = icon;
            dialog.Parent = HANDLE;
            return dialog;
        }
        public static void RenameFile(string NEW_NAME)
        {
            try
            {
                File.Move(Process.GetCurrentProcess().MainModule.FileName, NEW_NAME);
            }
            catch
            {
                Message("Unable to rename file", MessageDialogIcon.Information, Register.HANDLE()).Show();
            }
        }
    }
}
