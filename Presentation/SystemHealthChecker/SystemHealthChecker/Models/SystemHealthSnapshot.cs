using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHealthChecker.Models
{
    public class SystemHealthSnapshot
    {

        public float CpuUsage { get; set; }
        public float MemoryUsage { get; set; }
        public float DiskUsage { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
