namespace Simulateur_CEOG
{
    partial class MenuForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_ConfigFileDir = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gb_Profinet_Serveur_Connexion = new System.Windows.Forms.GroupBox();
            this.rb_Profinet_Serveur_Disconnect = new System.Windows.Forms.RadioButton();
            this.rb_Profinet_Serveur_Connect = new System.Windows.Forms.RadioButton();
            this.gb_Profinet_Client_Connexion = new System.Windows.Forms.GroupBox();
            this.rb_Profinet_Client_Disconnect = new System.Windows.Forms.RadioButton();
            this.rb_Profinet_Client_Connect = new System.Windows.Forms.RadioButton();
            this.gb_RTU_Serveur_Connexion = new System.Windows.Forms.GroupBox();
            this.rb_RTU_Serveur_Disconnect = new System.Windows.Forms.RadioButton();
            this.rb_RTU_Serveur_Connect = new System.Windows.Forms.RadioButton();
            this.gb_RTU_Client_Connexion = new System.Windows.Forms.GroupBox();
            this.rb_RTU_Client_Disconnect = new System.Windows.Forms.RadioButton();
            this.rb_RTU_Client_Connect = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_TCP_Serveur_Connexion = new System.Windows.Forms.GroupBox();
            this.rb_TCP_Serveur_Disconnect = new System.Windows.Forms.RadioButton();
            this.rb_TCP_Serveur_Connect = new System.Windows.Forms.RadioButton();
            this.gb_TCP_Client_Connexion = new System.Windows.Forms.GroupBox();
            this.rb_TCP_Client_Disconnect = new System.Windows.Forms.RadioButton();
            this.rb_TCP_Client_Connect = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_Profinet_Serveur = new System.Windows.Forms.ListBox();
            this.lb_Profinet_Client = new System.Windows.Forms.ListBox();
            this.lb_ModBus_RTU_Serveur = new System.Windows.Forms.ListBox();
            this.lb_Modbus_RTU_Client = new System.Windows.Forms.ListBox();
            this.lb_ModBus_TCP_Serveur = new System.Windows.Forms.ListBox();
            this.lb_ModBus_TCP_Client = new System.Windows.Forms.ListBox();
            this.configFileSelector = new System.Windows.Forms.OpenFileDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.tc_Main.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_Profinet_Serveur_Connexion.SuspendLayout();
            this.gb_Profinet_Client_Connexion.SuspendLayout();
            this.gb_RTU_Serveur_Connexion.SuspendLayout();
            this.gb_RTU_Client_Connexion.SuspendLayout();
            this.gb_TCP_Serveur_Connexion.SuspendLayout();
            this.gb_TCP_Client_Connexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Main
            // 
            this.tc_Main.Controls.Add(this.tabPage2);
            this.tc_Main.Controls.Add(this.tabPage1);
            this.tc_Main.Location = new System.Drawing.Point(12, 12);
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(1151, 677);
            this.tc_Main.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.tb_ConfigFileDir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1143, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(474, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Charger configuration";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ReadConfigFile);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(474, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Choisir fichier de configuration";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.selectConfigFile);
            // 
            // tb_ConfigFileDir
            // 
            this.tb_ConfigFileDir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_ConfigFileDir.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_ConfigFileDir.Location = new System.Drawing.Point(241, 289);
            this.tb_ConfigFileDir.Name = "tb_ConfigFileDir";
            this.tb_ConfigFileDir.ReadOnly = true;
            this.tb_ConfigFileDir.Size = new System.Drawing.Size(647, 20);
            this.tb_ConfigFileDir.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.gb_Profinet_Serveur_Connexion);
            this.tabPage1.Controls.Add(this.gb_Profinet_Client_Connexion);
            this.tabPage1.Controls.Add(this.gb_RTU_Serveur_Connexion);
            this.tabPage1.Controls.Add(this.gb_RTU_Client_Connexion);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.gb_TCP_Serveur_Connexion);
            this.tabPage1.Controls.Add(this.gb_TCP_Client_Connexion);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lb_Profinet_Serveur);
            this.tabPage1.Controls.Add(this.lb_Profinet_Client);
            this.tabPage1.Controls.Add(this.lb_ModBus_RTU_Serveur);
            this.tabPage1.Controls.Add(this.lb_Modbus_RTU_Client);
            this.tabPage1.Controls.Add(this.lb_ModBus_TCP_Serveur);
            this.tabPage1.Controls.Add(this.lb_ModBus_TCP_Client);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1143, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tableau de bord";
            // 
            // gb_Profinet_Serveur_Connexion
            // 
            this.gb_Profinet_Serveur_Connexion.Controls.Add(this.rb_Profinet_Serveur_Disconnect);
            this.gb_Profinet_Serveur_Connexion.Controls.Add(this.rb_Profinet_Serveur_Connect);
            this.gb_Profinet_Serveur_Connexion.Location = new System.Drawing.Point(811, 625);
            this.gb_Profinet_Serveur_Connexion.Name = "gb_Profinet_Serveur_Connexion";
            this.gb_Profinet_Serveur_Connexion.Size = new System.Drawing.Size(328, 27);
            this.gb_Profinet_Serveur_Connexion.TabIndex = 29;
            this.gb_Profinet_Serveur_Connexion.TabStop = false;
            this.gb_Profinet_Serveur_Connexion.Text = "#gb_EqName(server)";
            // 
            // rb_Profinet_Serveur_Disconnect
            // 
            this.rb_Profinet_Serveur_Disconnect.AutoSize = true;
            this.rb_Profinet_Serveur_Disconnect.Enabled = false;
            this.rb_Profinet_Serveur_Disconnect.Location = new System.Drawing.Point(234, 8);
            this.rb_Profinet_Serveur_Disconnect.Name = "rb_Profinet_Serveur_Disconnect";
            this.rb_Profinet_Serveur_Disconnect.Size = new System.Drawing.Size(89, 17);
            this.rb_Profinet_Serveur_Disconnect.TabIndex = 26;
            this.rb_Profinet_Serveur_Disconnect.TabStop = true;
            this.rb_Profinet_Serveur_Disconnect.Text = "StopListening";
            this.rb_Profinet_Serveur_Disconnect.UseVisualStyleBackColor = true;
            // 
            // rb_Profinet_Serveur_Connect
            // 
            this.rb_Profinet_Serveur_Connect.AutoSize = true;
            this.rb_Profinet_Serveur_Connect.Enabled = false;
            this.rb_Profinet_Serveur_Connect.Location = new System.Drawing.Point(115, 7);
            this.rb_Profinet_Serveur_Connect.Name = "rb_Profinet_Serveur_Connect";
            this.rb_Profinet_Serveur_Connect.Size = new System.Drawing.Size(53, 17);
            this.rb_Profinet_Serveur_Connect.TabIndex = 25;
            this.rb_Profinet_Serveur_Connect.TabStop = true;
            this.rb_Profinet_Serveur_Connect.Text = "Listen";
            this.rb_Profinet_Serveur_Connect.UseVisualStyleBackColor = true;
            // 
            // gb_Profinet_Client_Connexion
            // 
            this.gb_Profinet_Client_Connexion.Controls.Add(this.rb_Profinet_Client_Disconnect);
            this.gb_Profinet_Client_Connexion.Controls.Add(this.rb_Profinet_Client_Connect);
            this.gb_Profinet_Client_Connexion.Location = new System.Drawing.Point(809, 308);
            this.gb_Profinet_Client_Connexion.Name = "gb_Profinet_Client_Connexion";
            this.gb_Profinet_Client_Connexion.Size = new System.Drawing.Size(328, 27);
            this.gb_Profinet_Client_Connexion.TabIndex = 28;
            this.gb_Profinet_Client_Connexion.TabStop = false;
            this.gb_Profinet_Client_Connexion.Text = "#gb_EqName(client)";
            // 
            // rb_Profinet_Client_Disconnect
            // 
            this.rb_Profinet_Client_Disconnect.AutoSize = true;
            this.rb_Profinet_Client_Disconnect.Enabled = false;
            this.rb_Profinet_Client_Disconnect.Location = new System.Drawing.Point(234, 8);
            this.rb_Profinet_Client_Disconnect.Name = "rb_Profinet_Client_Disconnect";
            this.rb_Profinet_Client_Disconnect.Size = new System.Drawing.Size(79, 17);
            this.rb_Profinet_Client_Disconnect.TabIndex = 26;
            this.rb_Profinet_Client_Disconnect.TabStop = true;
            this.rb_Profinet_Client_Disconnect.Text = "Disconnect";
            this.rb_Profinet_Client_Disconnect.UseVisualStyleBackColor = true;
            // 
            // rb_Profinet_Client_Connect
            // 
            this.rb_Profinet_Client_Connect.AutoSize = true;
            this.rb_Profinet_Client_Connect.Enabled = false;
            this.rb_Profinet_Client_Connect.Location = new System.Drawing.Point(115, 7);
            this.rb_Profinet_Client_Connect.Name = "rb_Profinet_Client_Connect";
            this.rb_Profinet_Client_Connect.Size = new System.Drawing.Size(65, 17);
            this.rb_Profinet_Client_Connect.TabIndex = 25;
            this.rb_Profinet_Client_Connect.TabStop = true;
            this.rb_Profinet_Client_Connect.Text = "Connect";
            this.rb_Profinet_Client_Connect.UseVisualStyleBackColor = true;
            // 
            // gb_RTU_Serveur_Connexion
            // 
            this.gb_RTU_Serveur_Connexion.Controls.Add(this.rb_RTU_Serveur_Disconnect);
            this.gb_RTU_Serveur_Connexion.Controls.Add(this.rb_RTU_Serveur_Connect);
            this.gb_RTU_Serveur_Connexion.Location = new System.Drawing.Point(411, 625);
            this.gb_RTU_Serveur_Connexion.Name = "gb_RTU_Serveur_Connexion";
            this.gb_RTU_Serveur_Connexion.Size = new System.Drawing.Size(328, 27);
            this.gb_RTU_Serveur_Connexion.TabIndex = 28;
            this.gb_RTU_Serveur_Connexion.TabStop = false;
            this.gb_RTU_Serveur_Connexion.Text = "#gb_EqName(server)";
            // 
            // rb_RTU_Serveur_Disconnect
            // 
            this.rb_RTU_Serveur_Disconnect.AutoSize = true;
            this.rb_RTU_Serveur_Disconnect.Enabled = false;
            this.rb_RTU_Serveur_Disconnect.Location = new System.Drawing.Point(234, 8);
            this.rb_RTU_Serveur_Disconnect.Name = "rb_RTU_Serveur_Disconnect";
            this.rb_RTU_Serveur_Disconnect.Size = new System.Drawing.Size(89, 17);
            this.rb_RTU_Serveur_Disconnect.TabIndex = 26;
            this.rb_RTU_Serveur_Disconnect.TabStop = true;
            this.rb_RTU_Serveur_Disconnect.Text = "StopListening";
            this.rb_RTU_Serveur_Disconnect.UseVisualStyleBackColor = true;
            this.rb_RTU_Serveur_Disconnect.CheckedChanged += new System.EventHandler(this.rtuRadioButtons_CheckedChanged);
            // 
            // rb_RTU_Serveur_Connect
            // 
            this.rb_RTU_Serveur_Connect.AutoSize = true;
            this.rb_RTU_Serveur_Connect.Enabled = false;
            this.rb_RTU_Serveur_Connect.Location = new System.Drawing.Point(115, 7);
            this.rb_RTU_Serveur_Connect.Name = "rb_RTU_Serveur_Connect";
            this.rb_RTU_Serveur_Connect.Size = new System.Drawing.Size(53, 17);
            this.rb_RTU_Serveur_Connect.TabIndex = 25;
            this.rb_RTU_Serveur_Connect.TabStop = true;
            this.rb_RTU_Serveur_Connect.Text = "Listen";
            this.rb_RTU_Serveur_Connect.UseVisualStyleBackColor = true;
            this.rb_RTU_Serveur_Connect.CheckedChanged += new System.EventHandler(this.rtuRadioButtons_CheckedChanged);
            // 
            // gb_RTU_Client_Connexion
            // 
            this.gb_RTU_Client_Connexion.Controls.Add(this.rb_RTU_Client_Disconnect);
            this.gb_RTU_Client_Connexion.Controls.Add(this.rb_RTU_Client_Connect);
            this.gb_RTU_Client_Connexion.Location = new System.Drawing.Point(411, 308);
            this.gb_RTU_Client_Connexion.Name = "gb_RTU_Client_Connexion";
            this.gb_RTU_Client_Connexion.Size = new System.Drawing.Size(328, 27);
            this.gb_RTU_Client_Connexion.TabIndex = 27;
            this.gb_RTU_Client_Connexion.TabStop = false;
            this.gb_RTU_Client_Connexion.Text = "#gb_EqName(client)";
            // 
            // rb_RTU_Client_Disconnect
            // 
            this.rb_RTU_Client_Disconnect.AutoSize = true;
            this.rb_RTU_Client_Disconnect.Enabled = false;
            this.rb_RTU_Client_Disconnect.Location = new System.Drawing.Point(234, 8);
            this.rb_RTU_Client_Disconnect.Name = "rb_RTU_Client_Disconnect";
            this.rb_RTU_Client_Disconnect.Size = new System.Drawing.Size(79, 17);
            this.rb_RTU_Client_Disconnect.TabIndex = 26;
            this.rb_RTU_Client_Disconnect.TabStop = true;
            this.rb_RTU_Client_Disconnect.Text = "Disconnect";
            this.rb_RTU_Client_Disconnect.UseVisualStyleBackColor = true;
            this.rb_RTU_Client_Disconnect.CheckedChanged += new System.EventHandler(this.rtuRadioButtons_CheckedChanged);
            // 
            // rb_RTU_Client_Connect
            // 
            this.rb_RTU_Client_Connect.AutoSize = true;
            this.rb_RTU_Client_Connect.Enabled = false;
            this.rb_RTU_Client_Connect.Location = new System.Drawing.Point(115, 7);
            this.rb_RTU_Client_Connect.Name = "rb_RTU_Client_Connect";
            this.rb_RTU_Client_Connect.Size = new System.Drawing.Size(65, 17);
            this.rb_RTU_Client_Connect.TabIndex = 25;
            this.rb_RTU_Client_Connect.TabStop = true;
            this.rb_RTU_Client_Connect.Text = "Connect";
            this.rb_RTU_Client_Connect.UseVisualStyleBackColor = true;
            this.rb_RTU_Client_Connect.CheckedChanged += new System.EventHandler(this.rtuRadioButtons_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(355, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "Ouvrir fichier des équipements";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.openEquipementsFile);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(175, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Eliminer toute les connexions";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.terminateAllConnexions);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Changer de configuration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.changeConfigBtn);
            // 
            // gb_TCP_Serveur_Connexion
            // 
            this.gb_TCP_Serveur_Connexion.Controls.Add(this.rb_TCP_Serveur_Disconnect);
            this.gb_TCP_Serveur_Connexion.Controls.Add(this.rb_TCP_Serveur_Connect);
            this.gb_TCP_Serveur_Connexion.Location = new System.Drawing.Point(13, 625);
            this.gb_TCP_Serveur_Connexion.Name = "gb_TCP_Serveur_Connexion";
            this.gb_TCP_Serveur_Connexion.Size = new System.Drawing.Size(328, 27);
            this.gb_TCP_Serveur_Connexion.TabIndex = 27;
            this.gb_TCP_Serveur_Connexion.TabStop = false;
            this.gb_TCP_Serveur_Connexion.Text = "#gb_EqName(server)";
            // 
            // rb_TCP_Serveur_Disconnect
            // 
            this.rb_TCP_Serveur_Disconnect.AutoSize = true;
            this.rb_TCP_Serveur_Disconnect.Enabled = false;
            this.rb_TCP_Serveur_Disconnect.Location = new System.Drawing.Point(234, 8);
            this.rb_TCP_Serveur_Disconnect.Name = "rb_TCP_Serveur_Disconnect";
            this.rb_TCP_Serveur_Disconnect.Size = new System.Drawing.Size(89, 17);
            this.rb_TCP_Serveur_Disconnect.TabIndex = 26;
            this.rb_TCP_Serveur_Disconnect.TabStop = true;
            this.rb_TCP_Serveur_Disconnect.Text = "StopListening";
            this.rb_TCP_Serveur_Disconnect.UseVisualStyleBackColor = true;
            this.rb_TCP_Serveur_Disconnect.CheckedChanged += new System.EventHandler(this.tcpRadioButtons_CheckedChanged);
            // 
            // rb_TCP_Serveur_Connect
            // 
            this.rb_TCP_Serveur_Connect.AutoSize = true;
            this.rb_TCP_Serveur_Connect.Enabled = false;
            this.rb_TCP_Serveur_Connect.Location = new System.Drawing.Point(115, 7);
            this.rb_TCP_Serveur_Connect.Name = "rb_TCP_Serveur_Connect";
            this.rb_TCP_Serveur_Connect.Size = new System.Drawing.Size(53, 17);
            this.rb_TCP_Serveur_Connect.TabIndex = 25;
            this.rb_TCP_Serveur_Connect.TabStop = true;
            this.rb_TCP_Serveur_Connect.Text = "Listen";
            this.rb_TCP_Serveur_Connect.UseVisualStyleBackColor = true;
            this.rb_TCP_Serveur_Connect.CheckedChanged += new System.EventHandler(this.tcpRadioButtons_CheckedChanged);
            // 
            // gb_TCP_Client_Connexion
            // 
            this.gb_TCP_Client_Connexion.Controls.Add(this.rb_TCP_Client_Disconnect);
            this.gb_TCP_Client_Connexion.Controls.Add(this.rb_TCP_Client_Connect);
            this.gb_TCP_Client_Connexion.Location = new System.Drawing.Point(13, 308);
            this.gb_TCP_Client_Connexion.Name = "gb_TCP_Client_Connexion";
            this.gb_TCP_Client_Connexion.Size = new System.Drawing.Size(328, 27);
            this.gb_TCP_Client_Connexion.TabIndex = 26;
            this.gb_TCP_Client_Connexion.TabStop = false;
            this.gb_TCP_Client_Connexion.Text = "#gb_EqName(client)";
            // 
            // rb_TCP_Client_Disconnect
            // 
            this.rb_TCP_Client_Disconnect.AutoSize = true;
            this.rb_TCP_Client_Disconnect.Enabled = false;
            this.rb_TCP_Client_Disconnect.Location = new System.Drawing.Point(234, 8);
            this.rb_TCP_Client_Disconnect.Name = "rb_TCP_Client_Disconnect";
            this.rb_TCP_Client_Disconnect.Size = new System.Drawing.Size(79, 17);
            this.rb_TCP_Client_Disconnect.TabIndex = 26;
            this.rb_TCP_Client_Disconnect.TabStop = true;
            this.rb_TCP_Client_Disconnect.Text = "Disconnect";
            this.rb_TCP_Client_Disconnect.UseVisualStyleBackColor = true;
            this.rb_TCP_Client_Disconnect.CheckedChanged += new System.EventHandler(this.tcpRadioButtons_CheckedChanged);
            // 
            // rb_TCP_Client_Connect
            // 
            this.rb_TCP_Client_Connect.AutoSize = true;
            this.rb_TCP_Client_Connect.Enabled = false;
            this.rb_TCP_Client_Connect.Location = new System.Drawing.Point(115, 7);
            this.rb_TCP_Client_Connect.Name = "rb_TCP_Client_Connect";
            this.rb_TCP_Client_Connect.Size = new System.Drawing.Size(65, 17);
            this.rb_TCP_Client_Connect.TabIndex = 25;
            this.rb_TCP_Client_Connect.TabStop = true;
            this.rb_TCP_Client_Connect.Text = "Connect";
            this.rb_TCP_Client_Connect.UseVisualStyleBackColor = true;
            this.rb_TCP_Client_Connect.CheckedChanged += new System.EventHandler(this.tcpRadioButtons_CheckedChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(809, 347);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(328, 31);
            this.textBox5.TabIndex = 24;
            this.textBox5.Text = "PROFINET Serveur";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox6.Location = new System.Drawing.Point(809, 30);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(328, 31);
            this.textBox6.TabIndex = 23;
            this.textBox6.Text = "PROFINET Client";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(411, 347);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(328, 31);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "MODBUS RTU Serveur";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(411, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(328, 31);
            this.textBox4.TabIndex = 21;
            this.textBox4.Text = "MODBUS RTU Client";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(13, 347);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 31);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "MODBUS TCP/IP Serveur";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(13, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 31);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "MODBUS TCP/IP Client";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Profinet_Serveur
            // 
            this.lb_Profinet_Serveur.FormattingEnabled = true;
            this.lb_Profinet_Serveur.Location = new System.Drawing.Point(809, 387);
            this.lb_Profinet_Serveur.Name = "lb_Profinet_Serveur";
            this.lb_Profinet_Serveur.Size = new System.Drawing.Size(328, 238);
            this.lb_Profinet_Serveur.TabIndex = 18;
            // 
            // lb_Profinet_Client
            // 
            this.lb_Profinet_Client.FormattingEnabled = true;
            this.lb_Profinet_Client.Location = new System.Drawing.Point(809, 70);
            this.lb_Profinet_Client.Name = "lb_Profinet_Client";
            this.lb_Profinet_Client.Size = new System.Drawing.Size(328, 238);
            this.lb_Profinet_Client.TabIndex = 17;
            // 
            // lb_ModBus_RTU_Serveur
            // 
            this.lb_ModBus_RTU_Serveur.FormattingEnabled = true;
            this.lb_ModBus_RTU_Serveur.Location = new System.Drawing.Point(411, 387);
            this.lb_ModBus_RTU_Serveur.Name = "lb_ModBus_RTU_Serveur";
            this.lb_ModBus_RTU_Serveur.Size = new System.Drawing.Size(328, 238);
            this.lb_ModBus_RTU_Serveur.TabIndex = 16;
            this.lb_ModBus_RTU_Serveur.SelectedIndexChanged += new System.EventHandler(this.Lb_Modbus_RTU_SelectedIndexChanged);
            this.lb_ModBus_RTU_Serveur.DoubleClick += new System.EventHandler(this.Lb_Modbus_RTU_DoubleClick);
            // 
            // lb_Modbus_RTU_Client
            // 
            this.lb_Modbus_RTU_Client.FormattingEnabled = true;
            this.lb_Modbus_RTU_Client.Location = new System.Drawing.Point(411, 70);
            this.lb_Modbus_RTU_Client.Name = "lb_Modbus_RTU_Client";
            this.lb_Modbus_RTU_Client.Size = new System.Drawing.Size(328, 238);
            this.lb_Modbus_RTU_Client.TabIndex = 15;
            this.lb_Modbus_RTU_Client.SelectedIndexChanged += new System.EventHandler(this.Lb_Modbus_RTU_SelectedIndexChanged);
            this.lb_Modbus_RTU_Client.DoubleClick += new System.EventHandler(this.Lb_Modbus_RTU_DoubleClick);
            // 
            // lb_ModBus_TCP_Serveur
            // 
            this.lb_ModBus_TCP_Serveur.FormattingEnabled = true;
            this.lb_ModBus_TCP_Serveur.Location = new System.Drawing.Point(13, 387);
            this.lb_ModBus_TCP_Serveur.Name = "lb_ModBus_TCP_Serveur";
            this.lb_ModBus_TCP_Serveur.Size = new System.Drawing.Size(328, 238);
            this.lb_ModBus_TCP_Serveur.TabIndex = 14;
            this.lb_ModBus_TCP_Serveur.SelectedIndexChanged += new System.EventHandler(this.Lb_ModBus_TCP_SelectedIndexChanged);
            this.lb_ModBus_TCP_Serveur.DoubleClick += new System.EventHandler(this.Lb_ModBus_TCP_DoubleClick);
            // 
            // lb_ModBus_TCP_Client
            // 
            this.lb_ModBus_TCP_Client.FormattingEnabled = true;
            this.lb_ModBus_TCP_Client.Location = new System.Drawing.Point(13, 70);
            this.lb_ModBus_TCP_Client.Name = "lb_ModBus_TCP_Client";
            this.lb_ModBus_TCP_Client.Size = new System.Drawing.Size(328, 238);
            this.lb_ModBus_TCP_Client.TabIndex = 0;
            this.lb_ModBus_TCP_Client.SelectedIndexChanged += new System.EventHandler(this.Lb_ModBus_TCP_SelectedIndexChanged);
            this.lb_ModBus_TCP_Client.DoubleClick += new System.EventHandler(this.Lb_ModBus_TCP_DoubleClick);
            // 
            // configFileSelector
            // 
            this.configFileSelector.FileName = "openFileDialog1";
            this.configFileSelector.Filter = "CSV Files (*.csv)|*.csv|Txt Files (*.txt)|*.txt";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "Ouvrir fichier des équipements";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.openEquipementsFile);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 701);
            this.Controls.Add(this.tc_Main);
            this.Name = "MenuForm";
            this.Text = "SIMULATEUR_CEOG";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.tc_Main.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gb_Profinet_Serveur_Connexion.ResumeLayout(false);
            this.gb_Profinet_Serveur_Connexion.PerformLayout();
            this.gb_Profinet_Client_Connexion.ResumeLayout(false);
            this.gb_Profinet_Client_Connexion.PerformLayout();
            this.gb_RTU_Serveur_Connexion.ResumeLayout(false);
            this.gb_RTU_Serveur_Connexion.PerformLayout();
            this.gb_RTU_Client_Connexion.ResumeLayout(false);
            this.gb_RTU_Client_Connexion.PerformLayout();
            this.gb_TCP_Serveur_Connexion.ResumeLayout(false);
            this.gb_TCP_Serveur_Connexion.PerformLayout();
            this.gb_TCP_Client_Connexion.ResumeLayout(false);
            this.gb_TCP_Client_Connexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tb_ConfigFileDir;
        private System.Windows.Forms.ListBox lb_Profinet_Serveur;
        private System.Windows.Forms.ListBox lb_Profinet_Client;
        private System.Windows.Forms.ListBox lb_ModBus_RTU_Serveur;
        private System.Windows.Forms.ListBox lb_Modbus_RTU_Client;
        private System.Windows.Forms.ListBox lb_ModBus_TCP_Serveur;
        private System.Windows.Forms.ListBox lb_ModBus_TCP_Client;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog configFileSelector;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gb_TCP_Client_Connexion;
        private System.Windows.Forms.RadioButton rb_TCP_Client_Disconnect;
        private System.Windows.Forms.RadioButton rb_TCP_Client_Connect;
        private System.Windows.Forms.GroupBox gb_TCP_Serveur_Connexion;
        private System.Windows.Forms.RadioButton rb_TCP_Serveur_Disconnect;
        private System.Windows.Forms.RadioButton rb_TCP_Serveur_Connect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox gb_RTU_Serveur_Connexion;
        private System.Windows.Forms.RadioButton rb_RTU_Serveur_Disconnect;
        private System.Windows.Forms.RadioButton rb_RTU_Serveur_Connect;
        private System.Windows.Forms.GroupBox gb_RTU_Client_Connexion;
        private System.Windows.Forms.RadioButton rb_RTU_Client_Disconnect;
        private System.Windows.Forms.RadioButton rb_RTU_Client_Connect;
        private System.Windows.Forms.GroupBox gb_Profinet_Serveur_Connexion;
        private System.Windows.Forms.RadioButton rb_Profinet_Serveur_Disconnect;
        private System.Windows.Forms.RadioButton rb_Profinet_Serveur_Connect;
        private System.Windows.Forms.GroupBox gb_Profinet_Client_Connexion;
        private System.Windows.Forms.RadioButton rb_Profinet_Client_Disconnect;
        private System.Windows.Forms.RadioButton rb_Profinet_Client_Connect;
        private System.Windows.Forms.Button button6;
    }
}

