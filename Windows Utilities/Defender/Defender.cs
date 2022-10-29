using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace Windows_Utilities
{
    public class Defender
    {
        /// <summary>
        /// Enables Real-time protection <br/>
        /// This will also enable Tamper-protection <br/>
        /// </summary>
        public static void Enable()
        {
            if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show("Administrator privileges required");
                return;
            }

            Reg.Edit(@"SOFTWARE\Policies\Microsoft\Windows Defender", "DisableAntiSpyware", "0");
            Reg.Edit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableBehaviorMonitoring", "0");
            Reg.Edit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableOnAccessProtection", "0");
            Reg.Edit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableScanOnRealtimeEnable", "0");
            CheckDefender(true);
        }

        /// <summary>
        /// Disables Real-time protection <br/>
        /// You will need to manually disable Tamper-protection for this to work <br/>
        /// </summary>
        public static void Disable()
        {
            if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
            { 
                MessageBox.Show("Administrator privileges required");
                return;
            }

            Reg.Edit(@"SOFTWARE\Policies\Microsoft\Windows Defender", "DisableAntiSpyware", "1");
            Reg.Edit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableBehaviorMonitoring", "1");
            Reg.Edit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableOnAccessProtection", "1");
            Reg.Edit(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection", "DisableScanOnRealtimeEnable", "1");
            CheckDefender(false);
        }

        private static void CheckDefender(bool enable)
        {
            Process proc = Arguments.RunPS("Get-MpPreference -verbose", true);

            if (enable)
            {
                Arguments.Enable(proc);
            }

            if (!enable)
            {
                Arguments.Disable(proc);
            }          
        }
    }
}
