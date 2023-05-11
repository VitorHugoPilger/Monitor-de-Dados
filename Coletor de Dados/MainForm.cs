using Coletor_de_Dados.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Coletor_de_Dados
{
    public partial class MainForm : Form
    {
        private PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        private PerformanceCounter diskCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");



        private string defaultFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            + @"\" + SystemInformation.ComputerName + "_Data.csv";

        private int timeSpan = 0;


        private ManualResetEvent cancelEvent = new ManualResetEvent(false);

        private BackgroundWorker backgroundWorker = new BackgroundWorker();
        public MainForm()
        {
            InitializeComponent();
            SystemTrayIcon();
            BackgroundCollector();


            DisplaySettings();


            TXT_FileDir.TextChanged += new EventHandler(PropertyChanged);
            TXT_TimeDelay.TextChanged += new EventHandler(PropertyChanged);
            CMB_TimeDelay.TextChanged += new EventHandler(PropertyChanged);


            Console.WriteLine(CMB_TimeDelay.SelectedItem = Settings.Default.timeSpanFormat);
        }

        private void SystemTrayIcon()
        {
            notifyIcon.Visible = true;
            notifyIcon.Text = "Coletor de Dados";
            notifyIcon.BalloonTipText = "O Coletor de Dados está executando em segundo plano";
        }

        private void PropertyChanged(object sender, EventArgs e)
        {
            BTN_SaveSettings.Enabled = true;
            BTN_DiscardSettings.Enabled = true;
            BTN_DefaultSettings.Enabled = true;
        }

        private void DisplaySettings()
        {
            if (Settings.Default.isDefault == true)
            {
                Settings.Default.filePath = defaultFilePath;
                Settings.Default.Save();
                BTN_DefaultSettings.Enabled = false;
            }
            TXT_FileDir.Text = Settings.Default.filePath;
            TXT_TimeDelay.Text = Settings.Default.timeSpan.ToString();
            CMB_TimeDelay.SelectedItem = Settings.Default.timeSpanFormat;

            BTN_SaveSettings.Enabled = false;
            BTN_DiscardSettings.Enabled = false;
        }

        private void BackgroundCollector()
        {
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.WorkerSupportsCancellation = true;

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            Console.WriteLine("Iniciando");


            if (Settings.Default.timeSpanFormat == "Segundos")
            {
                timeSpan = Settings.Default.timeSpan * 1000;
            }
            else if (Settings.Default.timeSpanFormat == "Minutos")
            {
                timeSpan = Settings.Default.timeSpan * 60 * 1000;
            }



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
                    cancelEvent.WaitOne(timeSpan);
                    cancelEvent.Reset();
                }



            }


        }

        private void SaveData(DateTime dateTime, double cpuData, double memoryData, double diskData)
        {
            using (var writer = new StreamWriter(Settings.Default.filePath, true))
            {
                writer.WriteLine($"{dateTime}.{cpuData},{memoryData},{diskData}");
            }

        }

        private void DisplayData(double processorData, double memoryData, double diskData)
        {

            LBL_ProcessorInfo.Invoke(new Action(() =>
            {
                LBL_ProcessorInfo.Text = $"{processorData}%";
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
                cancelEvent.Set();
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
            else if (e.CloseReason == CloseReason.UserClosing && !backgroundWorker.IsBusy)
            {
                Application.Exit();
            }
        }

        private void BTN_SearchFolder_Click(object sender, EventArgs e)
        {
            if (FBD_FileDir.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = FBD_FileDir.SelectedPath;
                TXT_FileDir.Text = selectedPath;
            }
        }

        private void TXT_FileDir_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.filePath = TXT_FileDir.Text;

        }

        private void CHK_StoppingRules_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_StoppingRules.Checked)
            {
                GRP_StoppingRules.Enabled = true;
            }
            else if (!CHK_StoppingRules.Checked)
            {
                GRP_StoppingRules.Enabled = false;
            }
        }

        private void BTN_SaveSettings_Click(object sender, EventArgs e)
        {
            Settings.Default.filePath = TXT_FileDir.Text;
            Settings.Default.timeSpan = int.Parse(TXT_TimeDelay.Text);
            Settings.Default.timeSpanFormat = (string)CMB_TimeDelay.SelectedItem;
            Settings.Default.isDefault = false;
            Settings.Default.Save();
            DisplaySettings();


        }

        private void BTN_DiscardSettings_Click(object sender, EventArgs e)
        {
            Settings.Default.Reload();
            DisplaySettings();
        }

        private void BTN_DefaultSettings_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
            DisplaySettings();
        }
    }
}
