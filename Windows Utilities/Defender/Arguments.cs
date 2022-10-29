using System.Diagnostics;

namespace Windows_Utilities
{
    class Arguments
    {
        public static void Enable(Process proc)
        {
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();

                if (line.StartsWith(@"DisableRealtimeMonitoring") && line.EndsWith("True"))
                    RunPS("Set-MpPreference -DisableRealtimeMonitoring $false"); //real-time protection

                else if (line.StartsWith(@"DisableBehaviorMonitoring") && line.EndsWith("True"))
                    RunPS("Set-MpPreference -DisableBehaviorMonitoring $false"); //behavior monitoring

                else if (line.StartsWith(@"DisableBlockAtFirstSeen") && line.EndsWith("True"))
                    RunPS("Set-MpPreference -DisableBlockAtFirstSeen $false");

                else if (line.StartsWith(@"DisableIOAVProtection") && line.EndsWith("True"))
                    RunPS("Set-MpPreference -DisableIOAVProtection $false"); //scans all downloaded files and attachments

                else if (line.StartsWith(@"DisablePrivacyMode") && line.EndsWith("True"))
                    RunPS("Set-MpPreference -DisablePrivacyMode $false"); //displaying threat history

                else if (line.StartsWith(@"SignatureDisableUpdateOnStartupWithoutEngine") && line.EndsWith("True"))
                    RunPS("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $false"); //definition updates on startup

                else if (line.StartsWith(@"DisableArchiveScanning") && line.EndsWith("True"))
                    RunPS("Set-MpPreference -DisableArchiveScanning $false"); //scan archive files, such as .zip and .cab files

                else if (line.StartsWith(@"DisableIntrusionPreventionSystem") && line.EndsWith("True"))
                    RunPS("Set-MpPreference -DisableIntrusionPreventionSystem $false"); // network protection 

                else if (line.StartsWith(@"DisableScriptScanning") && line.EndsWith("True"))
                    RunPS("Set-MpPreference -DisableScriptScanning $false"); //scanning of scripts during scans
            }
        }
        public static void Disable(Process proc)
        {
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();

                if (line.StartsWith(@"DisableRealtimeMonitoring") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableRealtimeMonitoring $true"); //real-time protection

                else if (line.StartsWith(@"DisableBehaviorMonitoring") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableBehaviorMonitoring $true"); //behavior monitoring

                else if (line.StartsWith(@"DisableBlockAtFirstSeen") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableBlockAtFirstSeen $true");

                else if (line.StartsWith(@"DisableIOAVProtection") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableIOAVProtection $true"); //scans all downloaded files and attachments

                else if (line.StartsWith(@"DisablePrivacyMode") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisablePrivacyMode $true"); //displaying threat history

                else if (line.StartsWith(@"SignatureDisableUpdateOnStartupWithoutEngine") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true"); //definition updates on startup

                else if (line.StartsWith(@"DisableArchiveScanning") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableArchiveScanning $true"); //scan archive files, such as .zip and .cab files

                else if (line.StartsWith(@"DisableIntrusionPreventionSystem") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableIntrusionPreventionSystem $true"); // network protection 

                else if (line.StartsWith(@"DisableScriptScanning") && line.EndsWith("False"))
                    RunPS("Set-MpPreference -DisableScriptScanning $true"); //scanning of scripts during scans
            }
        }
        public static Process RunPS(string args, bool redirectOutput = false)
        {
            if (!redirectOutput)
            {
                Process proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "powershell",
                        Arguments = args,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true
                    }
                };
                proc.Start();
                return proc;
            }

            if (redirectOutput)
            {
                Process proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "powershell",
                        Arguments = "Get-MpPreference -verbose",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true
                    }
                };
                proc.Start();
                return proc;
            }
            return null;
        }
    }
}
