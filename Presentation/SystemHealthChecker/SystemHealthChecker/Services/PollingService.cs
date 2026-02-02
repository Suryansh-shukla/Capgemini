using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHealthChecker.Metrics;
using SystemHealthChecker.Models;

namespace SystemHealthChecker.Services
{
    public class PollingService
    {
        private CpuMonitor cpu;
        private MemoryMonitor memory;
        private DiskMonitor disk;

        public PollingService()
        {
            cpu = new CpuMonitor();
            memory = new MemoryMonitor();
            disk = new DiskMonitor();
        }

        public SystemHealthSnapshot CollectSnapshot()
        {
            return new SystemHealthSnapshot
            {
                CpuUsage = cpu.GetCpuUsage(),
                MemoryUsage = memory.GetMemoryUsage(),
                DiskUsage = disk.GetDiskUsage(),
                Timestamp = DateTime.Now
            };
        }
    }
}
