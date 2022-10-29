using System;


namespace Windows_Utilities
{
    public class Specification
    {
        public static string AntiVirus = Utils.IsAntiVirusInstalled().ToString();
        //PC Details
        public static string DESKTOP_NAME = Environment.MachineName;
        public static string MANUFACTURER = Reg.GetValue(@"HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardManufacturer");
        public static string MODEL = Reg.GetValue(@"HARDWARE\DESCRIPTION\System\BIOS", "SystemProductName");
        public static string SYSTEM_TYPE = ManagementSearcher.GetValue("SELECT * FROM Win32_ComputerSystem", "SystemType");
        public static string BIOS_SERIAL = ManagementSearcher.GetValue("SELECT * FROM Win32_BIOS", "SerialNumber");
        public static string MOTHERBOARD_SERIAL = ManagementSearcher.GetValue("SELECT * FROM Win32_BaseBoard", "SerialNumber");

        //CPU Details
        public static string CPU_NAME = ManagementSearcher.GetValue("SELECT * FROM Win32_Processor", "Name");
        public static int CPU_BASESPEED = Int32.Parse(ManagementSearcher.GetValue("SELECT * FROM Win32_Processor", "MaxClockSpeed"));
        public static int CPU_CORES = Int32.Parse(ManagementSearcher.GetValue("SELECT * FROM Win32_Processor", "NumberOfCores"));
        public static int CPU_LOGICAL = Environment.ProcessorCount;
        public static int CPU_COUNT = Int32.Parse(ManagementSearcher.GetValue("SELECT * FROM Win32_ComputerSystem", "NumberOfProcessors"));
    
        //GPU Details
        public static string GPU_NAME = ManagementSearcher.GetValue("SELECT * FROM Win32_VideoController", "VideoProcessor");

        //RAM Details
        public static string RAM_TOTALCAPACITY = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024 * 1024 * 1024) + "GB";

        //Drive Details
        public static string DRIVES = string.Join(Environment.NewLine, Utils.GetDrives().ToArray());
        public static int? DRIVES_COUNT = ManagementSearcher.Count("SELECT * FROM Win32_DiskDrive");
    }
}
