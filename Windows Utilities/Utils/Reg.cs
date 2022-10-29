using Microsoft.Win32;
using System.Windows.Forms;

namespace Windows_Utilities
{
    internal class Reg
    {
        internal static string GetValue(string regPath, string valueName)
        {
            try
            {
                using (var key = Registry.LocalMachine.OpenSubKey(regPath, false)) // False is important!
                {
                    var result = key.GetValue(valueName).ToString();
                    return result;
                }
            }
            catch
            {
                MessageBox.Show("Unable to get value");
            }
            return "Unable to get value";
        }
        internal static void Edit(string regPath, string valueName, string value)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regPath, RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    if (key == null)
                    {
                        Registry.LocalMachine.CreateSubKey(regPath).SetValue(valueName, value, RegistryValueKind.DWord);
                        return;
                    }
                    if (key.GetValue(valueName) != (object)value)
                        key.SetValue(valueName, value, RegistryValueKind.DWord);
                }
            }
            catch
            {
                MessageBox.Show("Unable to edit registry");
            }
        }
    }
}
