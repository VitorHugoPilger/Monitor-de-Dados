namespace Coletor_de_Dados
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LBL_DiskInfo = new System.Windows.Forms.Label();
            this.LBL_MemoryInfo = new System.Windows.Forms.Label();
            this.LBL_ProcessorInfo = new System.Windows.Forms.Label();
            this.BTN_StartStop = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LBL_DiskInfo);
            this.tabPage1.Controls.Add(this.LBL_MemoryInfo);
            this.tabPage1.Controls.Add(this.LBL_ProcessorInfo);
            this.tabPage1.Controls.Add(this.BTN_StartStop);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LBL_DiskInfo
            // 
            this.LBL_DiskInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_DiskInfo.AutoSize = true;
            this.LBL_DiskInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DiskInfo.Image = ((System.Drawing.Image)(resources.GetObject("LBL_DiskInfo.Image")));
            this.LBL_DiskInfo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LBL_DiskInfo.Location = new System.Drawing.Point(709, 6);
            this.LBL_DiskInfo.MinimumSize = new System.Drawing.Size(75, 40);
            this.LBL_DiskInfo.Name = "LBL_DiskInfo";
            this.LBL_DiskInfo.Size = new System.Drawing.Size(75, 40);
            this.LBL_DiskInfo.TabIndex = 4;
            this.LBL_DiskInfo.Text = "00%";
            this.LBL_DiskInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_MemoryInfo
            // 
            this.LBL_MemoryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_MemoryInfo.AutoSize = true;
            this.LBL_MemoryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MemoryInfo.Image = global::Coletor_de_Dados.Properties.Resources.memory_icon;
            this.LBL_MemoryInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LBL_MemoryInfo.Location = new System.Drawing.Point(628, 6);
            this.LBL_MemoryInfo.MinimumSize = new System.Drawing.Size(75, 40);
            this.LBL_MemoryInfo.Name = "LBL_MemoryInfo";
            this.LBL_MemoryInfo.Size = new System.Drawing.Size(75, 40);
            this.LBL_MemoryInfo.TabIndex = 3;
            this.LBL_MemoryInfo.Text = "00%";
            this.LBL_MemoryInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_ProcessorInfo
            // 
            this.LBL_ProcessorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_ProcessorInfo.AutoSize = true;
            this.LBL_ProcessorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ProcessorInfo.Image = global::Coletor_de_Dados.Properties.Resources.processor_icon;
            this.LBL_ProcessorInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LBL_ProcessorInfo.Location = new System.Drawing.Point(547, 6);
            this.LBL_ProcessorInfo.MinimumSize = new System.Drawing.Size(75, 40);
            this.LBL_ProcessorInfo.Name = "LBL_ProcessorInfo";
            this.LBL_ProcessorInfo.Size = new System.Drawing.Size(75, 40);
            this.LBL_ProcessorInfo.TabIndex = 2;
            this.LBL_ProcessorInfo.Text = "00%";
            this.LBL_ProcessorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BTN_StartStop
            // 
            this.BTN_StartStop.AutoSize = true;
            this.BTN_StartStop.Image = global::Coletor_de_Dados.Properties.Resources.start_icon;
            this.BTN_StartStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_StartStop.Location = new System.Drawing.Point(8, 6);
            this.BTN_StartStop.MinimumSize = new System.Drawing.Size(90, 40);
            this.BTN_StartStop.Name = "BTN_StartStop";
            this.BTN_StartStop.Size = new System.Drawing.Size(90, 40);
            this.BTN_StartStop.TabIndex = 0;
            this.BTN_StartStop.Text = "Executar";
            this.BTN_StartStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_StartStop.UseVisualStyleBackColor = true;
            this.BTN_StartStop.Click += new System.EventHandler(this.BTN_StartStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Coletor de Dados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button BTN_StartStop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LBL_DiskInfo;
        private System.Windows.Forms.Label LBL_MemoryInfo;
        private System.Windows.Forms.Label LBL_ProcessorInfo;
    }
}

