namespace Simulateur_CEOG.ModBus_TCP.BEMS
{
    partial class TCP_Form
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
            this.label0 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Equipement_Pooling = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_Equipement_Port = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Equipement_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Equipement_Mode = new System.Windows.Forms.Label();
            this.lb_Equipement_IP = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // label0
            // 
            this.label0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label0.AutoSize = true;
            this.label0.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label0.Location = new System.Drawing.Point(3, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(163, 35);
            this.label0.TabIndex = 1;
            this.label0.Text = "Mode :";
            this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Equipement_Pooling, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_Equipement_Port, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Equipement_Name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Equipement_Mode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Equipement_IP, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 177);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lb_Equipement_Pooling
            // 
            this.lb_Equipement_Pooling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Equipement_Pooling.AutoSize = true;
            this.lb_Equipement_Pooling.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_Equipement_Pooling.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Equipement_Pooling.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_Equipement_Pooling.Location = new System.Drawing.Point(172, 140);
            this.lb_Equipement_Pooling.Name = "lb_Equipement_Pooling";
            this.lb_Equipement_Pooling.Size = new System.Drawing.Size(163, 37);
            this.lb_Equipement_Pooling.TabIndex = 10;
            this.lb_Equipement_Pooling.Text = "XXX";
            this.lb_Equipement_Pooling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(3, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 37);
            this.label8.TabIndex = 9;
            this.label8.Text = "Pooling :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Equipement_Port
            // 
            this.lb_Equipement_Port.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Equipement_Port.AutoSize = true;
            this.lb_Equipement_Port.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Equipement_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Equipement_Port.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_Equipement_Port.Location = new System.Drawing.Point(172, 105);
            this.lb_Equipement_Port.Name = "lb_Equipement_Port";
            this.lb_Equipement_Port.Size = new System.Drawing.Size(163, 35);
            this.lb_Equipement_Port.TabIndex = 8;
            this.lb_Equipement_Port.Text = "XXX";
            this.lb_Equipement_Port.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(3, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "Port :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adress IP :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Equipement_Name
            // 
            this.lb_Equipement_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Equipement_Name.AutoSize = true;
            this.lb_Equipement_Name.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lb_Equipement_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Equipement_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_Equipement_Name.Location = new System.Drawing.Point(172, 35);
            this.lb_Equipement_Name.Name = "lb_Equipement_Name";
            this.lb_Equipement_Name.Size = new System.Drawing.Size(163, 35);
            this.lb_Equipement_Name.TabIndex = 4;
            this.lb_Equipement_Name.Text = "#Name";
            this.lb_Equipement_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Equipement :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Equipement_Mode
            // 
            this.lb_Equipement_Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Equipement_Mode.AutoSize = true;
            this.lb_Equipement_Mode.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_Equipement_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Equipement_Mode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_Equipement_Mode.Location = new System.Drawing.Point(172, 0);
            this.lb_Equipement_Mode.Name = "lb_Equipement_Mode";
            this.lb_Equipement_Mode.Size = new System.Drawing.Size(163, 35);
            this.lb_Equipement_Mode.TabIndex = 2;
            this.lb_Equipement_Mode.Text = "#Mode";
            this.lb_Equipement_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Equipement_IP
            // 
            this.lb_Equipement_IP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Equipement_IP.AutoSize = true;
            this.lb_Equipement_IP.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_Equipement_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Equipement_IP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_Equipement_IP.Location = new System.Drawing.Point(172, 70);
            this.lb_Equipement_IP.Name = "lb_Equipement_IP";
            this.lb_Equipement_IP.Size = new System.Drawing.Size(163, 35);
            this.lb_Equipement_IP.TabIndex = 6;
            this.lb_Equipement_IP.Text = "000.000.000.000";
            this.lb_Equipement_IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // TCP_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 559);
            this.Controls.Add(this.tb_Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_dataHolder);
            this.Controls.Add(this.tb_Logs);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TCP_Form";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BEMS_TCP_Form_FormClosing);
            this.Load += new System.EventHandler(this.BEMS_TCP_Form_Load);
            this.VisibleChanged += new System.EventHandler(this.TCP_Form_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataHolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Equipement_Pooling;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_Equipement_Port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_Equipement_IP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Equipement_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Equipement_Mode;
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
    }
}