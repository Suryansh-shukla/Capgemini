using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHealthChecker.Models;

namespace SystemHealthChecker.Logging
{
    public class HealthLogger
    {
        private readonly string logFile = "system_health_log.csv";

        public void Log(SystemHealthSnapshot snapshot)
        {
            if (!File.Exists(logFile))
            {
                File.AppendAllText(logFile, "CPU,RAM,DISK,TIMESTAMP\n");
            }

            string line = $"{snapshot.CpuUsage:0.0},{snapshot.MemoryUsage:0.0},{snapshot.DiskUsage:0.0},{snapshot.Timestamp}";
            File.AppendAllText(logFile, line + "\n");
        }
    }
}
