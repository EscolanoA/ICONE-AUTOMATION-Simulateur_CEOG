namespace Simulateur_CEOG.ModBus_TCP.BEMS
{
    partial class RTU_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_Logs = new System.Windows.Forms.TextBox();
            this.dgv_dataHolder = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifiable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Write = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Send = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Status = new System.Windows.Forms.TextBox();
            this.tb_Equipement = new System.Windows.Forms.TextBox();
            this.tb_Equipement_Mode = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tb_Equipement_Nom = new System.Windows.Forms.TextBox();
            this.tb_Equipement_ID = new System.Windows.Forms.TextBox();
            this.tb_Equipement_Port = new System.Windows.Forms.TextBox();
            this.tb_Equipement_Pooling = new System.Windows.Forms.TextBox();
            this.tb_Equipement_SerialPort = new System.Windows.Forms.TextBox();
            this.tb_Equipement_Baudrate = new System.Windows.Forms.TextBox();
            this.tb_Equipement_Parity = new System.Windows.Forms.TextBox();
            this.tb_Equipement_Stopbits = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataHolder)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Logs
            // 
            this.tb_Logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Logs.Location = new System.Drawing.Point(423, 25);
            this.tb_Logs.Multiline = true;
            this.tb_Logs.Name = "tb_Logs";
            this.tb_Logs.ReadOnly = true;
            this.tb_Logs.Size = new System.Drawing.Size(705, 164);
            this.tb_Logs.TabIndex = 3;
            // 
            // dgv_dataHolder
            // 
            this.dgv_dataHolder.AllowUserToAddRows = false;
            this.dgv_dataHolder.AllowUserToDeleteRows = false;
            this.dgv_dataHolder.AllowUserToResizeColumns = false;
            this.dgv_dataHolder.AllowUserToResizeRows = false;
            this.dgv_dataHolder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_dataHolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dataHolder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Valeur,
            this.Type,
            this.Adresse,
            this.Modifiable,
            this.Write,
            this.Send});
            this.dgv_dataHolder.Location = new System.Drawing.Point(12, 195);
            this.dgv_dataHolder.MultiSelect = false;
            this.dgv_dataHolder.Name = "dgv_dataHolder";
            this.dgv_dataHolder.RowHeadersVisible = false;
            this.dgv_dataHolder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_dataHolder.Size = new System.Drawing.Size(1119, 352);
            this.dgv_dataHolder.TabIndex = 4;
            this.dgv_dataHolder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sendValueHandler);
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Valeur
            // 
            this.Valeur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valeur.HeaderText = "Valeur";
            this.Valeur.Name = "Valeur";
            this.Valeur.ReadOnly = true;
            this.Valeur.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Adresse
            // 
            this.Adresse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            this.Adresse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Modifiable
            // 
            this.Modifiable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modifiable.HeaderText = "Modifiable";
            this.Modifiable.Name = "Modifiable";
            this.Modifiable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Write
            // 
            this.Write.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Write.HeaderText = "Write";
            this.Write.Name = "Write";
            this.Write.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Send
            // 
            this.Send.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Send.HeaderText = "Send";
            this.Send.Name = "Send";
            this.Send.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGS :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status :";
            // 
            // tb_Status
            // 
            this.tb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Status.Location = new System.Drawing.Point(353, 29);
            this.tb_Status.Name = "tb_Status";
            this.tb_Status.ReadOnly = true;
            this.tb_Status.Size = new System.Drawing.Size(64, 18);
            this.tb_Status.TabIndex = 8;
            this.tb_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Status.TextChanged += new System.EventHandler(this.Tb_Status_TextChanged);
            // 
            // tb_Equipement
            // 
            this.tb_Equipement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Equipement.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_Equipement.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Equipement.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Equipement.Location = new System.Drawing.Point(3, 3);
            this.tb_Equipement.Multiline = true;
            this.tb_Equipement.Name = "tb_Equipement";
            this.tb_Equipement.ReadOnly = true;
            this.tb_Equipement.Size = new System.Drawing.Size(162, 14);
            this.tb_Equipement.TabIndex = 9;
            this.tb_Equipement.Text = "Mode :";
            this.tb_Equipement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Equipement_Mode
            // 
            this.tb_Equipement_Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Equipement_Mode.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_Equipement_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Equipement_Mode.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Equipement_Mode.Location = new System.Drawing.Point(171, 3);
            this.tb_Equipement_Mode.Multiline = true;
            this.tb_Equipement_Mode.Name = "tb_Equipement_Mode";
            this.tb_Equipement_Mode.ReadOnly = true;
            this.tb_Equipement_Mode.Size = new System.Drawing.Size(163, 14);
            this.tb_Equipement_Mode.TabIndex = 19;
            this.tb_Equipement_Mode.Text = "Nom :";
            this.tb_Equipement_Mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(3, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(162, 14);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Equipement :";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(3, 43);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(162, 14);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "ID :";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(3, 63);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(162, 14);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Port :";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox7.Location = new System.Drawing.Point(3, 83);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(162, 14);
            this.textBox7.TabIndex = 13;
            this.textBox7.Text = "Pooling :";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox6.Location = new System.Drawing.Point(3, 103);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(162, 14);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "SerialPort :";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(3, 123);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(162, 14);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Baudrate :";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(3, 143);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(162, 14);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "Parity :";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox9.Location = new System.Drawing.Point(3, 163);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(162, 23);
            this.textBox9.TabIndex = 17;
            this.textBox9.Text = "Stopbits :";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Equipement_Nom
            // 
            this.tb_Equipement_Nom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Equipement_Nom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Equipement_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Equipement_Nom.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Equipement_Nom.Location = new System.Drawing.Point(171, 23);
            this.tb_Equipement_Nom.Multiline = true;
            this.tb_Equipement_Nom.Name = "tb_Equipement_Nom";
            this.tb_Equipement_Nom.ReadOnly = true;
            this.tb_Equipement_Nom.Size = new System.Drawing.Size(163, 14);
            this.tb_Equipement_Nom.TabIndex = 20;
            this.tb_Equipement_Nom.Text = "Nom :";
            this.tb_Equipement_Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Equipement_ID
            // 
            this.tb_Equipement_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Equipement_ID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_Equipement_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Equipement_ID.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Equipement_ID.Location = new System.Drawing.Point(171, 43);
            this.tb_Equipement_ID.Multiline = true;
            this.tb_Equipement_ID.Name = "tb_Equipement_ID";
            this.tb_Equipement_ID.ReadOnly = true;
            this.tb_Equipement_ID.Size = new System.Drawing.Size(163, 14);
            this.tb_Equipement_ID.TabIndex = 21;
            this.tb_Equipement_ID.Text = "Nom :";
            this.tb_Equipement_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Equipement_Port
            // 
            this.tb_Equipement_Port.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Equipement_Port.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Equipement_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Equipement_Port.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Equipement_Port.Location = new System.Drawing.Point(171, 63);
            this.tb_Equipement_Port.Multiline = true;
            this.tb_Equipement_Port.Name = "tb_Equipement_Port";
            this.tb_Equipement_Port.ReadOnly = true;
            this.tb_Equipement_Port.Size = new System.Drawing.Size(163, 14);
            this.tb_Equipement_Port.TabIndex = 22;
            this.tb_Equipement_Port.Text = "Nom :";
            this.tb_Equipement_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Equipement_Pooling
            // 
            this.tb_Equipement_Pooling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Equipement_Pooling.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_Equipement_Pooling.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Equipement_Pooling.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Equipement_Pooling.Location = new System.Drawing.Point(171, 83);
            this.tb_Equipement_Pooling.Multiline = true;
            this.tb_Equipement_Pooling.Name = "tb_Equipement_Pooling";
            this.tb_Equipement_Pooling.ReadOnly = true;
            this.tb_Equipement_Pooling.Size = new System.Drawing.Size(163, 14);
            this.tb_Equipement_Pooling.TabIndex = 23;
            this.tb_Equipement_Pooling.Text = "Nom :";
            this.tb_Equipement_Pooling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Equipement_SerialPort
            // 
            this.tb_Equipement_SerialPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Equipement_SerialPort.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Equipement_SerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Equipement_SerialPort.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Equipement_SerialPort.Location = new System.Drawing.Point(171, 103);
            this.tb_Equipement_SerialPort.Multiline = true;
            this.tb_Equipement_SerialPort.Name = "tb_Equipement_SerialPort";
            this.tb_Equipement_SerialPort.ReadOnly = true;
            this.tb_Equipement_SerialPort.Size = new System.Drawing.Size(163, 14);
            this.tb_Equipement_SerialPort.TabIndex = 24;
            this.tb_Equipement_SerialPort.Text = "Nom :";
            this.tb_Equipement_SerialPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Equipement_Baudrate
            // 
            this.tb_Equipement_Baudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Equipement_Baudrate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_Equipement_Baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Equipement_Baudrate.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Equipement_Baudrate.Location = new System.Drawing.Point(171, 123);
            this.tb_Equipement_Baudrate.Multiline = true;
            this.tb_Equipement_Baudrate.Name = "tb_Equipement_Baudrate";
            this.tb_Equipement_Baudrate.ReadOnly = true;
            this.tb_Equipement_Baudrate.Size = new System.Drawing.Size(163, 14);
            this.tb_Equipement_Baudrate.TabIndex = 25;
            this.tb_Equipement_Baudrate.Text = "Nom :";
            this.tb_Equipement_Baudrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Equipement_Parity
            // 
            this.tb_Equipement_Parity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Equipement_Parity.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Equipement_Parity.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Equipement_Parity.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Equipement_Parity.Location = new System.Drawing.Point(171, 143);
            this.tb_Equipement_Parity.Multiline = true;
            this.tb_Equipement_Parity.Name = "tb_Equipement_Parity";
            this.tb_Equipement_Parity.ReadOnly = true;
            this.tb_Equipement_Parity.Size = new System.Drawing.Size(163, 14);
            this.tb_Equipement_Parity.TabIndex = 26;
            this.tb_Equipement_Parity.Text = "Nom :";
            this.tb_Equipement_Parity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Equipement_Stopbits
            // 
            this.tb_Equipement_Stopbits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Equipement_Stopbits.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_Equipement_Stopbits.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Equipement_Stopbits.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Equipement_Stopbits.Location = new System.Drawing.Point(171, 163);
            this.tb_Equipement_Stopbits.Multiline = true;
            this.tb_Equipement_Stopbits.Name = "tb_Equipement_Stopbits";
            this.tb_Equipement_Stopbits.ReadOnly = true;
            this.tb_Equipement_Stopbits.Size = new System.Drawing.Size(163, 23);
            this.tb_Equipement_Stopbits.TabIndex = 27;
            this.tb_Equipement_Stopbits.Text = "Nom :";
            this.tb_Equipement_Stopbits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tb_Equipement, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Equipement_Stopbits, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Equipement_Parity, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Equipement_Baudrate, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Equipement_SerialPort, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_Equipement_Pooling, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Equipement_Port, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Equipement_ID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tb_Equipement_Nom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tb_Equipement_Mode, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 189);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // RTU_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 559);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tb_Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_dataHolder);
            this.Controls.Add(this.tb_Logs);
            this.Name = "RTU_Form";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BEMS_TCP_Form_FormClosing);
            this.Load += new System.EventHandler(this.BEMS_TCP_Form_Load);
            this.VisibleChanged += new System.EventHandler(this.TCP_Form_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataHolder)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Logs;
        private System.Windows.Forms.DataGridView dgv_dataHolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Modifiable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Write;
        private System.Windows.Forms.DataGridViewButtonColumn Send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Status;
        private System.Windows.Forms.TextBox tb_Equipement;
        private System.Windows.Forms.TextBox tb_Equipement_Mode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox tb_Equipement_Nom;
        private System.Windows.Forms.TextBox tb_Equipement_ID;
        private System.Windows.Forms.TextBox tb_Equipement_Port;
        private System.Windows.Forms.TextBox tb_Equipement_Pooling;
        private System.Windows.Forms.TextBox tb_Equipement_SerialPort;
        private System.Windows.Forms.TextBox tb_Equipement_Baudrate;
        private System.Windows.Forms.TextBox tb_Equipement_Parity;
        private System.Windows.Forms.TextBox tb_Equipement_Stopbits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}