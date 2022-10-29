using System.Management;
using System.Windows.Forms;

namespace Windows_Utilities
{
    internal class ManagementSearcher
    {
        /// <summary>
        /// Count an scoped object using the Management Class
        /// </summary>
        /// <param name="scope"></param>
        /// <returns></returns>
        internal static int? Count(string scope)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", scope);
                return searcher.Get().Count;
            }
            catch 
            {
                MessageBox.Show("Unable to get WMI data");
                return null;
            }
        }
        /// <summary>
        /// Return a string value from the Management Class, searches "root\\CIMV2"
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="queryString"></param>
        /// <returns></returns>
        internal static string GetValue(string scope, string queryString)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", scope);
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    string result = queryObj[queryString].ToString();
                    return result;
                }
            }
            catch 
            {
                MessageBox.Show("Unable to get WMI data");

            }
            return "Unable to get WMI data";
        }
    }
}
