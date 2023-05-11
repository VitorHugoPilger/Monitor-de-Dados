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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LBL_DiskInfo = new System.Windows.Forms.Label();
            this.LBL_MemoryInfo = new System.Windows.Forms.Label();
            this.LBL_ProcessorInfo = new System.Windows.Forms.Label();
            this.BTN_StartStop = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTN_DefaultSettings = new System.Windows.Forms.Button();
            this.BTN_DiscardSettings = new System.Windows.Forms.Button();
            this.BTN_SaveSettings = new System.Windows.Forms.Button();
            this.GRP_File = new System.Windows.Forms.GroupBox();
            this.CHK_StoppingRules = new System.Windows.Forms.CheckBox();
            this.GRP_StoppingRules = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_FileSize = new System.Windows.Forms.Label();
            this.CMB_FileSize = new System.Windows.Forms.ComboBox();
            this.TXT_FileSize = new System.Windows.Forms.TextBox();
            this.CMB_TimeDelay = new System.Windows.Forms.ComboBox();
            this.TXT_TimeDelay = new System.Windows.Forms.TextBox();
            this.LBL_TimeDelay = new System.Windows.Forms.Label();
            this.BTN_SearchFolder = new System.Windows.Forms.Button();
            this.TXT_FileDir = new System.Windows.Forms.TextBox();
            this.LBL_FileDir = new System.Windows.Forms.Label();
            this.FBD_FileDir = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GRP_File.SuspendLayout();
            this.GRP_StoppingRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click_1);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(883, 497);
            this.tabControl.TabIndex = 2;
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
            this.tabPage1.Size = new System.Drawing.Size(875, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BTN_DefaultSettings);
            this.tabPage2.Controls.Add(this.BTN_DiscardSettings);
            this.tabPage2.Controls.Add(this.BTN_SaveSettings);
            this.tabPage2.Controls.Add(this.GRP_File);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(875, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTN_DefaultSettings
            // 
            this.BTN_DefaultSettings.Location = new System.Drawing.Point(792, 440);
            this.BTN_DefaultSettings.Name = "BTN_DefaultSettings";
            this.BTN_DefaultSettings.Size = new System.Drawing.Size(75, 23);
            this.BTN_DefaultSettings.TabIndex = 3;
            this.BTN_DefaultSettings.Text = "Padrão";
            this.BTN_DefaultSettings.UseVisualStyleBackColor = true;
            this.BTN_DefaultSettings.Click += new System.EventHandler(this.BTN_DefaultSettings_Click);
            // 
            // BTN_DiscardSettings
            // 
            this.BTN_DiscardSettings.Enabled = false;
            this.BTN_DiscardSettings.Location = new System.Drawing.Point(711, 440);
            this.BTN_DiscardSettings.Name = "BTN_DiscardSettings";
            this.BTN_DiscardSettings.Size = new System.Drawing.Size(75, 23);
            this.BTN_DiscardSettings.TabIndex = 2;
            this.BTN_DiscardSettings.Text = "Descartar";
            this.BTN_DiscardSettings.UseVisualStyleBackColor = true;
            this.BTN_DiscardSettings.Click += new System.EventHandler(this.BTN_DiscardSettings_Click);
            // 
            // BTN_SaveSettings
            // 
            this.BTN_SaveSettings.Enabled = false;
            this.BTN_SaveSettings.Location = new System.Drawing.Point(630, 440);
            this.BTN_SaveSettings.Name = "BTN_SaveSettings";
            this.BTN_SaveSettings.Size = new System.Drawing.Size(75, 23);
            this.BTN_SaveSettings.TabIndex = 1;
            this.BTN_SaveSettings.Text = "Salvar";
            this.BTN_SaveSettings.UseVisualStyleBackColor = true;
            this.BTN_SaveSettings.Click += new System.EventHandler(this.BTN_SaveSettings_Click);
            // 
            // GRP_File
            // 
            this.GRP_File.Controls.Add(this.CHK_StoppingRules);
            this.GRP_File.Controls.Add(this.GRP_StoppingRules);
            this.GRP_File.Controls.Add(this.CMB_TimeDelay);
            this.GRP_File.Controls.Add(this.TXT_TimeDelay);
            this.GRP_File.Controls.Add(this.LBL_TimeDelay);
            this.GRP_File.Controls.Add(this.BTN_SearchFolder);
            this.GRP_File.Controls.Add(this.TXT_FileDir);
            this.GRP_File.Controls.Add(this.LBL_FileDir);
            this.GRP_File.Location = new System.Drawing.Point(8, 6);
            this.GRP_File.Name = "GRP_File";
            this.GRP_File.Size = new System.Drawing.Size(859, 365);
            this.GRP_File.TabIndex = 0;
            this.GRP_File.TabStop = false;
            this.GRP_File.Text = "Arquivo";
            // 
            // CHK_StoppingRules
            // 
            this.CHK_StoppingRules.AutoSize = true;
            this.CHK_StoppingRules.Location = new System.Drawing.Point(9, 98);
            this.CHK_StoppingRules.Name = "CHK_StoppingRules";
            this.CHK_StoppingRules.Size = new System.Drawing.Size(161, 17);
            this.CHK_StoppingRules.TabIndex = 10;
            this.CHK_StoppingRules.Text = "Aplicar condições de parada";
            this.CHK_StoppingRules.UseVisualStyleBackColor = true;
            this.CHK_StoppingRules.CheckedChanged += new System.EventHandler(this.CHK_StoppingRules_CheckedChanged);
            // 
            // GRP_StoppingRules
            // 
            this.GRP_StoppingRules.Controls.Add(this.radioButton3);
            this.GRP_StoppingRules.Controls.Add(this.radioButton2);
            this.GRP_StoppingRules.Controls.Add(this.radioButton1);
            this.GRP_StoppingRules.Controls.Add(this.checkBox1);
            this.GRP_StoppingRules.Controls.Add(this.label3);
            this.GRP_StoppingRules.Controls.Add(this.LBL_FileSize);
            this.GRP_StoppingRules.Controls.Add(this.CMB_FileSize);
            this.GRP_StoppingRules.Controls.Add(this.TXT_FileSize);
            this.GRP_StoppingRules.Enabled = false;
            this.GRP_StoppingRules.Location = new System.Drawing.Point(427, 19);
            this.GRP_StoppingRules.Name = "GRP_StoppingRules";
            this.GRP_StoppingRules.Size = new System.Drawing.Size(343, 243);
            this.GRP_StoppingRules.TabIndex = 9;
            this.GRP_StoppingRules.TabStop = false;
            this.GRP_StoppingRules.Text = "Condições de Parada";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 140);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(144, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Parar o Coletor de Dados";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 117);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(264, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Criar um novo arquivo de dados e excluir o anterior";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 94);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(175, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Criar um novo arquivo de dados";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Exibir uma notificação";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quando o arquivo chegar no tamanho especificado:";
            // 
            // LBL_FileSize
            // 
            this.LBL_FileSize.AutoSize = true;
            this.LBL_FileSize.Location = new System.Drawing.Point(6, 16);
            this.LBL_FileSize.Name = "LBL_FileSize";
            this.LBL_FileSize.Size = new System.Drawing.Size(105, 13);
            this.LBL_FileSize.TabIndex = 6;
            this.LBL_FileSize.Text = "Tamanho do arquivo";
            // 
            // CMB_FileSize
            // 
            this.CMB_FileSize.FormattingEnabled = true;
            this.CMB_FileSize.Location = new System.Drawing.Point(136, 32);
            this.CMB_FileSize.Name = "CMB_FileSize";
            this.CMB_FileSize.Size = new System.Drawing.Size(65, 21);
            this.CMB_FileSize.TabIndex = 8;
            // 
            // TXT_FileSize
            // 
            this.TXT_FileSize.Location = new System.Drawing.Point(9, 32);
            this.TXT_FileSize.Name = "TXT_FileSize";
            this.TXT_FileSize.Size = new System.Drawing.Size(121, 20);
            this.TXT_FileSize.TabIndex = 7;
            // 
            // CMB_TimeDelay
            // 
            this.CMB_TimeDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_TimeDelay.FormattingEnabled = true;
            this.CMB_TimeDelay.Items.AddRange(new object[] {
            "Segundos",
            "Minutos"});
            this.CMB_TimeDelay.Location = new System.Drawing.Point(137, 69);
            this.CMB_TimeDelay.Name = "CMB_TimeDelay";
            this.CMB_TimeDelay.Size = new System.Drawing.Size(110, 21);
            this.CMB_TimeDelay.TabIndex = 5;
            // 
            // TXT_TimeDelay
            // 
            this.TXT_TimeDelay.Location = new System.Drawing.Point(9, 71);
            this.TXT_TimeDelay.Name = "TXT_TimeDelay";
            this.TXT_TimeDelay.Size = new System.Drawing.Size(121, 20);
            this.TXT_TimeDelay.TabIndex = 4;
            // 
            // LBL_TimeDelay
            // 
            this.LBL_TimeDelay.AutoSize = true;
            this.LBL_TimeDelay.Location = new System.Drawing.Point(6, 55);
            this.LBL_TimeDelay.Name = "LBL_TimeDelay";
            this.LBL_TimeDelay.Size = new System.Drawing.Size(123, 13);
            this.LBL_TimeDelay.TabIndex = 3;
            this.LBL_TimeDelay.Text = "Intervalo de amostragem";
            // 
            // BTN_SearchFolder
            // 
            this.BTN_SearchFolder.Location = new System.Drawing.Point(346, 29);
            this.BTN_SearchFolder.Name = "BTN_SearchFolder";
            this.BTN_SearchFolder.Size = new System.Drawing.Size(75, 23);
            this.BTN_SearchFolder.TabIndex = 2;
            this.BTN_SearchFolder.Text = "Procurar";
            this.BTN_SearchFolder.UseVisualStyleBackColor = true;
            this.BTN_SearchFolder.Click += new System.EventHandler(this.BTN_SearchFolder_Click);
            // 
            // TXT_FileDir
            // 
            this.TXT_FileDir.Location = new System.Drawing.Point(9, 32);
            this.TXT_FileDir.Name = "TXT_FileDir";
            this.TXT_FileDir.ReadOnly = true;
            this.TXT_FileDir.Size = new System.Drawing.Size(331, 20);
            this.TXT_FileDir.TabIndex = 1;
            this.TXT_FileDir.TextChanged += new System.EventHandler(this.TXT_FileDir_TextChanged);
            // 
            // LBL_FileDir
            // 
            this.LBL_FileDir.AutoSize = true;
            this.LBL_FileDir.Location = new System.Drawing.Point(6, 16);
            this.LBL_FileDir.Name = "LBL_FileDir";
            this.LBL_FileDir.Size = new System.Drawing.Size(102, 13);
            this.LBL_FileDir.TabIndex = 0;
            this.LBL_FileDir.Text = "Caminho do Arquivo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 497);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Coletor de Dados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.GRP_File.ResumeLayout(false);
            this.GRP_File.PerformLayout();
            this.GRP_StoppingRules.ResumeLayout(false);
            this.GRP_StoppingRules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button BTN_StartStop;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LBL_DiskInfo;
        private System.Windows.Forms.Label LBL_MemoryInfo;
        private System.Windows.Forms.Label LBL_ProcessorInfo;
        private System.Windows.Forms.GroupBox GRP_File;
        private System.Windows.Forms.Button BTN_SearchFolder;
        private System.Windows.Forms.TextBox TXT_FileDir;
        private System.Windows.Forms.Label LBL_FileDir;
        private System.Windows.Forms.FolderBrowserDialog FBD_FileDir;
        private System.Windows.Forms.GroupBox GRP_StoppingRules;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_FileSize;
        private System.Windows.Forms.ComboBox CMB_FileSize;
        private System.Windows.Forms.TextBox TXT_FileSize;
        private System.Windows.Forms.ComboBox CMB_TimeDelay;
        private System.Windows.Forms.TextBox TXT_TimeDelay;
        private System.Windows.Forms.Label LBL_TimeDelay;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox CHK_StoppingRules;
        private System.Windows.Forms.Button BTN_DefaultSettings;
        private System.Windows.Forms.Button BTN_DiscardSettings;
        private System.Windows.Forms.Button BTN_SaveSettings;
    }
}

