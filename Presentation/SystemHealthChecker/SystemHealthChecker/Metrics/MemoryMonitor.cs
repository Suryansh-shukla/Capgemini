using Microsoft.VisualBasic.Devices;
using System.CodeDom.Compiler;

namespace SystemHealthChecker.Metrics
{
    public class MemoryMonitor
    {
        private ComputerInfo info = new ComputerInfo();

        public float GetMemoryUsage()
        {
            ulong total = info.TotalPhysicalMemory;
            ulong available = info.AvailablePhysicalMemory;
            return (float)((total - available) * 100.0 / total);
        }
    }
}
