using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHealthChecker.Alerts
{
    public class AlertManager
    {
            public void ApplyAlert(Label statusLabel, string status, Color color)
            {
                statusLabel.Text = "Status: " + status;
                statusLabel.ForeColor = color;
            }
    }
}
