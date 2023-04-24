using Coletor_de_Dados.Properties;
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
    public partial class MainForm : Form
    {
        private PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        private PerformanceCounter diskCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");

        private string csvPath = "./" + SystemInformation.ComputerName + "_Output.csv";

        private int timeOut = 1000;

        private BackgroundWorker backgroundWorker = new BackgroundWorker();
        public MainForm()
        {
            InitializeComponent();
            SystemTrayIcon();
            BackgroundCollector();
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

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            while (backgroundWorker.IsBusy)
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
                    // Coleta os valores dos PerformanceCounters
                    var cpu = cpuCounter.NextValue();
                    var memory = ramCounter.NextValue();
                    var disk = diskCounter.NextValue();


                    SaveData(DateTime.Now, Math.Round(cpu), Math.Round(memory), Math.Round(disk));
                    DisplayData(Math.Round(cpu), Math.Round(memory), Math.Round(disk));

                    Console.WriteLine($"{DateTime.Now},{Math.Round(cpu)},{Math.Round(memory)},{Math.Round(disk)}");
                    Thread.Sleep(timeOut);
                }

            }

            
        }

        private void SaveData(DateTime dateTime, double cpuData, double memoryData, double diskData)
        {
            using (var writer = new StreamWriter(csvPath, true))
            {
                writer.WriteLine($"{dateTime}.{cpuData},{memoryData},{diskData}");
            }

        }

        private void DisplayData(double processorData, double memoryData, double diskData)
        {

            LBL_ProcessorInfo.Invoke(new Action(() =>
            {
                LBL_ProcessorInfo.Text = $"{processorData}%" ;
            }));

            LBL_MemoryInfo.Invoke(new Action(() =>
            {
                LBL_MemoryInfo.Text = $"{memoryData}%";
            }));

            LBL_DiskInfo.Invoke(new Action(() =>
            {
                LBL_DiskInfo.Text = $"{diskData}%";
            }));


        }


        private void notifyIcon_Click_1(object sender, EventArgs e)
        {
            Show();
        }

        private void BTN_StartStop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
                BTN_StartStop.Image = Resources.start_icon;
                BTN_StartStop.Text = "Executar";
                this.Text = "Coletor de Dados - (Parado)";

            }
            else
            {
                backgroundWorker.RunWorkerAsync();
                BTN_StartStop.Image = Resources.stop_icon;
                BTN_StartStop.Text = "Parar";
                this.Text = "Coletor de Dados - (Executando)";
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && backgroundWorker.IsBusy)
            {
                e.Cancel = true;
                Hide();
                notifyIcon.ShowBalloonTip(1500);
            }
            else if(e.CloseReason == CloseReason.UserClosing && !backgroundWorker.IsBusy)
            {
                Application.Exit();
            }
        }


        
    }
}
