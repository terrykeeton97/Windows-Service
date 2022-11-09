using Siticone.Desktop.UI.WinForms;
using System;
using System.Diagnostics;
using System.IO;

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
        public static SiticoneMessageDialog Message(string message, MessageDialogButtons option, MessageDialogIcon icon)
        {
            //add more without having to manually insert each parameter manually.
            //so if(error), if(information) and style the message dialog accordingly.
            //  if(error)
            //  {
            //      dialog shows error style
            //  }

            SiticoneMessageDialog dialog = new SiticoneMessageDialog();
            dialog.Text = message;
            dialog.Style = MessageDialogStyle.Light;
            dialog.Icon = icon;
            dialog.Buttons = option;
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
                Message("Unable to rename file", MessageDialogButtons.OK, MessageDialogIcon.Error).Show();
            }
        }
    }
}
