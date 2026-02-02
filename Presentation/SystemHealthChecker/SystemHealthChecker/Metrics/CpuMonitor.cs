using System.Diagnostics;

namespace SystemHealthChecker.Metrics
{
    public class CpuMonitor
    {
        private PerformanceCounter cpuCounter;

        public CpuMonitor()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuCounter.NextValue(); // warm-up
        }

        public float GetCpuUsage()
        {
            return cpuCounter.NextValue();
        }
    }
}
