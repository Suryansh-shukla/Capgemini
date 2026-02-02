using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHealthChecker.Alerts;
using SystemHealthChecker.Logging;
using SystemHealthChecker.Metrics;
using SystemHealthChecker.Models;
using SystemHealthChecker.Rules;
using SystemHealthChecker.Services;

namespace SystemHealthChecker
{
    public partial class FormMain : Form
    {
        CpuMonitor cpu = new CpuMonitor();
        MemoryMonitor memory = new MemoryMonitor();
        DiskMonitor disk = new DiskMonitor();
        ThresholdEvaluator evaluator = new ThresholdEvaluator();
        private PollingService pollingService;
        private AlertManager alertManager;
        private HealthLogger logger;

        public FormMain()
        {
            InitializeComponent();
            InitializeChart();
            pollingService = new PollingService();
            alertManager = new AlertManager();
            logger = new HealthLogger();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerHealth.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerHealth.Stop();
        }

        private void timerHealth_Tick(object sender, EventArgs e)
        {
            try
            {
                var snapshot = pollingService.CollectSnapshot();
                ProcessSnapshot(snapshot);
            }
            catch (Exception ex)
            {
                timerHealth.Stop();
                MessageBox.Show(
                    ex.Message,
                    "System Health Monitor Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void ProcessSnapshot(SystemHealthSnapshot snapshot)
        {
            UpdateMetric(pbCpu, lblCpuValue, lblCpuStatus, snapshot.CpuUsage);
            UpdateMetric(pbRam, lblRamValue, lblRamStatus, snapshot.MemoryUsage);
            UpdateMetric(pbDisk, lblDiskValue, lblDiskStatus, snapshot.DiskUsage);

            chartHealth.Series["CPU"].Points.AddY(snapshot.CpuUsage);
            chartHealth.Series["RAM"].Points.AddY(snapshot.MemoryUsage);
            chartHealth.Series["Disk"].Points.AddY(snapshot.DiskUsage);

            lblLastUpdated.Text = "Last Updated: " + snapshot.Timestamp.ToLongTimeString();
            logger.Log(snapshot);
        }
        private void UpdateMetric(ProgressBar bar, Label valueLabel, Label statusLabel, float value)
        {
            bar.Value = Math.Min(100, (int)value);
            valueLabel.Text = $"{value:0.0} %";

            var result = evaluator.Evaluate(value);
            alertManager.ApplyAlert(statusLabel,result.Item1,result.Item2);
        }

        private void InitializeChart()
        {
            chartHealth.Series.Clear();
            chartHealth.ChartAreas.Clear();

            chartHealth.ChartAreas.Add("MainArea");

            chartHealth.Series.Add("CPU");
            chartHealth.Series.Add("RAM");
            chartHealth.Series.Add("Disk");

            foreach (var series in chartHealth.Series)
            {
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series.BorderWidth = 2;
            }
        }


    }
}
