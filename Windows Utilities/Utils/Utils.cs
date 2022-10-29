using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace Windows_Utilities
{
    internal class Utils
    {
        /// <summary>
        /// Checks if 3rd party anti-virus is installed
        /// </summary>
        /// <returns></returns>
        public static bool IsAntiVirusInstalled()
        {

            string wmipathstr = @"\\" + Environment.MachineName + @"\root\SecurityCenter";
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmipathstr, "SELECT * FROM AntivirusProduct");
                ManagementObjectCollection instances = searcher.Get();
                if (instances.Count > 0)
                {
                    return true;
                }
            }

            catch
            {
                MessageBox.Show("Unable to get WMI data", "IsAntiVirusInstalled");
            }

            return false;
        }
        internal static string RAM()
        {
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject item in moc)
            {
                return Convert.ToString(Convert.ToUInt64(item.Properties["TotalPhysicalMemory"].Value) / 1024*1024 + "GB");
            }
            return "Unable to get RAM Capacity";
        }
        public static List<string> GetDrives()
        {
            List<string> disks = new List<string>() { };

            try
            {
                DriveInfo[] myDrives = DriveInfo.GetDrives();

                foreach (DriveInfo drive in myDrives)
                {
                    disks.Add(drive.Name);
                    disks.Add(drive.DriveType.ToString());
                    disks.Add(drive.VolumeLabel);
                    disks.Add(drive.DriveFormat);
                    disks.Add("");
                }
                return disks;
            }
            catch { }
            return disks;
        }
    }
}
