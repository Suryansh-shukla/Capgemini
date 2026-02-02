using System.IO;

namespace SystemHealthChecker.Metrics
{
    public class DiskMonitor
    {
        public float GetDiskUsage()
        {
            DriveInfo drive = new DriveInfo("C");
            long total = drive.TotalSize;
            long free = drive.TotalFreeSpace;
            return (float)((total - free) * 100.0 / total);
        }
    }
}
