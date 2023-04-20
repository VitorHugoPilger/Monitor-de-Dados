using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coletor_de_Dados
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        private PerformanceCounter diskCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");

        private string csvPath = "./" + SystemInformation.ComputerName + "_Output.csv";

        private bool isRunning = true;
        private int timeOut = 1000;

        private BackgroundWorker backgroundWorker = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
            SystemTrayIcon();
            BackgroundCollector();

            button1.Text = isRunning.ToString();
        }

        private void SystemTrayIcon()
        {
            notifyIcon.Visible = true;
            notifyIcon.Text = "Coletor de Dados";
            notifyIcon.BalloonTipText = "O Coletor de Dados está executando em segundo plano";
        }

        private void BackgroundCollector()
        {
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorker.CancellationPending)
            {
                // Define a propriedade Cancel como true para indicar que a tarefa foi cancelada
                e.Cancel = true;
                Console.WriteLine(backgroundWorker.CancellationPending);
                return;
            }
            else
            {
                Console.WriteLine(backgroundWorker.IsBusy);

                while (isRunning)
                {
                    // Coleta os valores dos PerformanceCounters
                    var cpu = cpuCounter.NextValue();
                    var memory = ramCounter.NextValue();
                    var disk = diskCounter.NextValue();

                    // Grava os valores no arquivo CSV
                    using (var writer = new StreamWriter(csvPath, true))
                    {
                        writer.WriteLine($"{DateTime.Now},{Math.Round(cpu)},{Math.Round(memory)},{Math.Round(disk)}");
                    }
                    Console.WriteLine($"{DateTime.Now},{Math.Round(cpu)},{Math.Round(memory)},{Math.Round(disk)}");
                    Thread.Sleep(timeOut);
                }
            }
        }

        private void notifyIcon_Click_1(object sender, EventArgs e)
        {
            Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isRunning)
            {
                backgroundWorker.CancelAsync();
            }
            else
            {
                backgroundWorker.RunWorkerAsync();
            }
            isRunning = !isRunning;
            button1.Text = isRunning.ToString();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                notifyIcon.ShowBalloonTip(1500);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
