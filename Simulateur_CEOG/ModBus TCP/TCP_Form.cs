using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EasyModbus;
using System.Net;

/* !! ATTENTION GROS PROBLEME (Résolue solution voir Conversion_Uint_Explication.txt sur le projet)!!
La DLL contient des registre de type Int16 (32767 Max) ce qui oblige les données de type UInt16/Uint32 a etre stocker sur 2 fois plus
de registres car (Int16 = 32767Max et Uint 65535Max) sauf que les applications tel que Ananas modbus tcp à des registres de Uint16
(65535 Max) ce qui fait que dans Ananas, certain registres ne seront jamais remplies tandis que dans la DLL il le seront
Même en cherchant une solution, j'en ai trouver aucune donc j'ai adapter mon code pour le faire fonctionner qui ne correspond pas
avec un modbus tel que celui dans l'appli Ananas
*/

namespace Simulateur_CEOG.ModBus_TCP.BEMS
{
    public partial class TCP_Form : Form
    {
        string Mode;
        public string equipementName;
        string AdressIP;
        int Port;
        int Pooling;
        string Fichier_echange;
        public DateTime Old_date = DateTime.Now;
        public DateTime New_date = new DateTime();
        public int AdresseMax = 0;
        TCP_Class TCPEquipement;

        public TCP_Form(TCP_Class TCPEquipement) //Constructeur
        {
            this.Mode = TCPEquipement.Mode;
            this.equipementName = TCPEquipement.Nom;
            this.AdressIP = TCPEquipement.AdressIP;
            this.Port = TCPEquipement.Port;
            this.Pooling = TCPEquipement.Pooling;
            this.Fichier_echange = TCPEquipement.Fichier_Echange;
            this.TCPEquipement = TCPEquipement;

            InitializeComponent();

            logMessage("Initialisation complete.");

            try
            {
                StreamReader streamReader = File.OpenText(this.Fichier_echange);
                string headerLine = streamReader.ReadLine();
                int count = 0;
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] values = line.Split(';');
                    string Nom = values[0];
                    string Type = values[1];
                    string Adresse = values[2];
                    string ReadWrite = values[3];
                    dgv_dataHolder.Rows.Add(Nom, 0, Type, Adresse, true);
                    //MessageBox.Show(Nom + " / " + Type + " / " + Adresse + " / " + ReadWrite);
                    switch (ReadWrite)
                    {
                        case "R":
                            dgv_dataHolder.Rows[count].Cells["Write"].ReadOnly = true;
                            dgv_dataHolder.Rows[count].Cells["Write"].Style.BackColor = Color.FromArgb(255, 110, 50, 50);
                            dgv_dataHolder.Rows[count].Cells["Write"].Style.ForeColor = Color.White;
                            dgv_dataHolder.Rows[count].Cells["Write"].Value = "Lécture seule pour | " + Nom;
                            break;

                        case "W":
                            dgv_dataHolder.Rows[count].Cells["Valeur"].Value = "Ecriture seule pour | " + Nom;
                            dgv_dataHolder.Rows[count].Cells["Valeur"].Style.BackColor = Color.FromArgb(255, 110, 50, 50);
                            dgv_dataHolder.Rows[count].Cells["Valeur"].Style.ForeColor = Color.White;
                            break;
                    }
                    count += 1;
                }
                AdresseMax = Convert.ToInt32(dgv_dataHolder.Rows[count - 1].Cells["Adresse"].Value);
            } catch (Exception e)
            {
                MessageBox.Show("Erreur chargement du fichier de configuration de : " + TCPEquipement.Nom + " | " + e.Message);
            }
        }

        private void BEMS_TCP_Form_Load(object sender, EventArgs e)
        {
            lb_Equipement_Mode.Text = Mode;
            lb_Equipement_Name.Text = equipementName;
            lb_Equipement_IP.Text = AdressIP;
            lb_Equipement_Port.Text = Port.ToString();
            lb_Equipement_Pooling.Text = Pooling.ToString();
            this.Text = this.equipementName;
            timer1.Interval = this.Pooling;

            foreach(DataGridViewRow row in dgv_dataHolder.Rows)
            {
                if (Convert.ToInt32(row.Cells[3].Value) > AdresseMax)
                {
                    AdresseMax = Convert.ToInt32(row.Cells[3].Value);
                }
            }
        }

        public void set_tbStatusText(string text)
        {
            tb_Status.Text = text;
        }

        public void logMessage(string msg) // Permet de faire un message de log
        {
            string now = DateTime.Now.ToString();
            string line= now + " ---> " + msg + "\n";
            string historique = tb_Logs.Text;
            tb_Logs.Text = line + "\r\n" + historique;
        }

        private void BEMS_TCP_Form_FormClosing(object sender, FormClosingEventArgs e) //empeche le form de se supprimer mais juste de se cacher
        {
            Hide();
            e.Cancel = true;
        }

        //Les 3 fonctions qui suivent qui sont un peu collé sont les fonctions d'envoies, de réceptions et de convertion des valeurs
        //1 . le client envoie la valeur (Si serveur envoie la valeur, il écrit juste dans ses registres et passe au 3.)
        //2 . Le serveur la reçoi et reconvertie la valeur
        //3 . le client récupere les valeurs du serveur et les reconverties
        private void sendValueHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && dgv_dataHolder.CurrentRow.Cells[5].Style.BackColor != Color.FromArgb(255, 110, 50, 50)) //Si c'est le bouton qui est clicker
            {
                int adresse = Convert.ToInt32(dgv_dataHolder.CurrentRow.Cells[3].Value); //l'adresse
                int value = 0; //la valeur int du datagridview (16/32)
                int[] valueTwoRegisters = new int[2]; //conteneur de 2 registre (pour tout /32 ou float)
                Single valueFloat = 0; //la valeur float du datagridview
                try
                {
                    switch (TCPEquipement.Mode)
                    {
                        case "Client": //Si c'est un client
                            switch (dgv_dataHolder.CurrentRow.Cells[2].Value.ToString())
                            {
                                case "U16":
                                    value = Convert.ToUInt16(dgv_dataHolder.CurrentRow.Cells[5].Value);
                                    Int16 valInt16 = 0;
                                    if (value > 32767)
                                    {
                                        valInt16 = Convert.ToInt16(value - 65536);
                                    } else
                                    {
                                        valInt16 = Convert.ToInt16(value);
                                    }
                                    TCPEquipement.Modbus_Client.WriteSingleRegister(adresse, valInt16);
                                    logMessage("Envoie de la valeur : " + value.ToString() + " | à l'adresse : " + adresse.ToString() + " | de type : " + dgv_dataHolder.CurrentRow.Cells[2].Value.ToString());
                                    break;
                                case "U32":
                                    UInt32 val = Convert.ToUInt32(dgv_dataHolder.CurrentRow.Cells[5].Value);
                                    if (val > 2147483647)
                                    {
                                        value = Convert.ToInt32(val - 4294967296L); //Le L spécifie qu'il sagit d'un chiffre de type long (car sinon erreur)
                                    } else
                                    {
                                        value = Convert.ToInt32(val);
                                    }
                                    valueTwoRegisters = EasyModbus.ModbusClient.ConvertIntToRegisters(value);
                                    TCPEquipement.Modbus_Client.WriteMultipleRegisters(adresse, valueTwoRegisters);
                                    logMessage("Envoie de la valeur : " + val.ToString() + " | à l'adresse : " + adresse.ToString() + " | de type : " + dgv_dataHolder.CurrentRow.Cells[2].Value.ToString());
                                    break;

                                case "I16": //Aucun besoin de convertion pour de l'I16
                                    value = Convert.ToInt16(dgv_dataHolder.CurrentRow.Cells[5].Value); //la valeur du datagridview
                                    TCPEquipement.Modbus_Client.WriteSingleRegister(adresse, value);
                                    logMessage("Envoie de la valeur : " + value.ToString() + " | à l'adresse : " + adresse.ToString() + " | de type : " + dgv_dataHolder.CurrentRow.Cells[2].Value.ToString());
                                    break;

                                case "I32":
                                    value = Convert.ToInt32(dgv_dataHolder.CurrentRow.Cells[5].Value);
                                    valueTwoRegisters = EasyModbus.ModbusClient.ConvertIntToRegisters(value);
                                    TCPEquipement.Modbus_Client.WriteMultipleRegisters(adresse, valueTwoRegisters);
                                    logMessage("Envoie de la valeur : " + value.ToString() + " | à l'adresse : " + adresse.ToString() + " | de type : " + dgv_dataHolder.CurrentRow.Cells[2].Value.ToString());
                                    break;

                                case "Float":
                                    valueFloat = Convert.ToSingle(dgv_dataHolder.CurrentRow.Cells[5].Value);
                                    valueTwoRegisters = EasyModbus.ModbusClient.ConvertFloatToRegisters(valueFloat);
                                    TCPEquipement.Modbus_Client.WriteMultipleRegisters(adresse, valueTwoRegisters);
                                    logMessage("Envoie de la valeur : " + valueFloat.ToString() + " | à l'adresse : " + adresse.ToString() + " | de type : " + dgv_dataHolder.CurrentRow.Cells[2].Value.ToString());
                                    break;
                            }
                            break;


                        case "Server": //Si c'est un Serveur
                            switch (dgv_dataHolder.CurrentRow.Cells[2].Value.ToString()) //Important ! Pour X raisons, l'adresse doit 1 fois plus haute que l'adresse d'envoie (raison du +1/+2)
                            {
                                case "U16":
                                    value = Convert.ToUInt16(dgv_dataHolder.CurrentRow.Cells[5].Value);
                                    Int16 valInt16 = 0;
                                    if (value > 32767)
                                    {
                                        valInt16 = Convert.ToInt16(value - 65536);
                                    }
                                    else
                                    {
                                        valInt16 = Convert.ToInt16(value);
                                    }
                                    TCPEquipement.Modbus_Server.holdingRegisters.localArray[adresse + 1] = valInt16;
                                    logMessage("Envoie de la valeur : " + value.ToString() + " | à l'adresse : " + adresse.ToString() + " | de type : " + dgv_dataHolder.CurrentRow.Cells[2].Value.ToString());
                                    break;
                                case "U32":
                                    UInt32 val1 = Convert.ToUInt32(dgv_dataHolder.CurrentRow.Cells[5].Value);
                                    if (val1 > 2147483647)
                                    {
                                        value = Convert.ToInt32(val1 - 4294967296L); //Le L spécifie qu'il sagit d'un chiffre de type long (car sinon erreur)
                                    }
                                    else
                                    {
                                        value = Convert.ToInt32(val1);
                                    }
                                    valueTwoRegisters = EasyModbus.ModbusClient.ConvertIntToRegisters(value);
                                    TCPEquipement.Modbus_Server.holdingRegisters.localArray[adresse + 1] = (short)valueTwoRegisters[0];
                                    TCPEquipement.Modbus_Server.holdingRegisters.localArray[adresse + 2] = (short)valueTwoRegisters[1];
                                    logMessage("Envoie de la valeur : " + val1.ToString() + " | à l'adresse : " + adresse.ToString() + " | de type : " + dgv_dataHolder.CurrentRow.Cells[2].Value.ToString());
                                    break;

                                case "I16":
                                    Int16 val = Convert.ToInt16(dgv_dataHolder.CurrentRow.Cells[5].Value); //la valeur du datagridview
                                    TCPEquipement.Modbus_Server.holdingRegisters.localArray[adresse + 1] = val;
                                    logMessage("Envoie de la valeur : " + val.ToString() + " | à l'adresse : " + adresse.ToString() + " | de type : " + dgv_dataHolder.CurrentRow.Cells[2].Value.ToString());
                                    break;

                                case "I32":
                                    value = Convert.ToInt32(dgv_dataHolder.CurrentRow.Cells[5].Value);
                                    valueTwoRegisters = EasyModbus.ModbusClient.ConvertIntToRegisters(value);
                                    TCPEquipement.Modbus_Server.holdingRegisters.localArray[adresse + 1] = (short)valueTwoRegisters[0];
                                    TCPEquipement.Modbus_Server.holdingRegisters.localArray[adresse + 2] = (short)valueTwoRegisters[1];
                                    logMessage("Envoie de la valeur : " + value.ToString() + " | à l'adresse : " + adresse.ToString() + " | de type : " + dgv_dataHolder.CurrentRow.Cells[2].Value.ToString());
                                    break;

                                case "Float":
                                    valueFloat = Convert.ToSingle(dgv_dataHolder.CurrentRow.Cells[5].Value);
                                    valueTwoRegisters = EasyModbus.ModbusClient.ConvertFloatToRegisters(valueFloat);
                                    TCPEquipement.Modbus_Server.holdingRegisters.localArray[adresse + 1] = (short)valueTwoRegisters[0];
                                    TCPEquipement.Modbus_Server.holdingRegisters.localArray[adresse + 2] = (short)valueTwoRegisters[1];
                                    logMessage("Envoie de la valeur : " + valueFloat.ToString() + " | à l'adresse : " + adresse.ToString() + " | de type : " + dgv_dataHolder.CurrentRow.Cells[2].Value.ToString());
                                    break;
                            }
                            break;
                    }
                } catch (Exception err)
                {
                    logMessage("Erreur lors de l'envoie : " + err.Message);
                }
                dgv_dataHolder.CurrentRow.Cells[5].Value = "";
            }
        }
        public void registersChanged(int register, int numberOfRegisters)
        {
            try
            {
                int[] valueTwoRegisters = new int[2];
                int value = 0;
                Single valueFloat = 0;

                valueTwoRegisters[0] = TCPEquipement.Modbus_Server.holdingRegisters.localArray[register];
                valueTwoRegisters[1] = TCPEquipement.Modbus_Server.holdingRegisters.localArray[register+1];
                foreach (DataGridViewRow row in dgv_dataHolder.Rows)
                {
                    if (row.Cells[3].Value.ToString() == (register - 1).ToString() && row.Cells[1].Style.BackColor != Color.FromArgb(255, 110, 50, 50)) //Car le register est l'adresse + 1 donc il faut enlever 1
                    {
                        switch (row.Cells[2].Value.ToString())
                        {
                            case "U16":
                                value = TCPEquipement.Modbus_Server.holdingRegisters.localArray[register];
                                if (value < 0)
                                {
                                    value = 65535 + (value + 1);
                                }
                                value = Convert.ToUInt16(value);
                                row.Cells[1].Value = value;

                                tb_Logs.Invoke(new MethodInvoker(delegate
                                {
                                    logMessage("Ecriture reçu à l'adresse : " + (register - 1).ToString() + " | de valeur : " + value.ToString() + " | et de type : " + row.Cells[2].Value.ToString());
                                }));
                                break;
                            case "U32":
                                Int32 val = EasyModbus.ModbusClient.ConvertRegistersToInt(valueTwoRegisters);
                                UInt32 valUint32 = 0;
                                if (val < 0)
                                {
                                    valUint32 = Convert.ToUInt32(4294967295L + (val + 1));
                                } else
                                {
                                    valUint32 = Convert.ToUInt32(val);
                                }
                                row.Cells[1].Value = valUint32;

                                tb_Logs.Invoke(new MethodInvoker(delegate
                                {
                                    logMessage("Ecriture reçu à l'adresse : " + (register - 1).ToString() + " | de valeur : " + valUint32.ToString() + " | et de type : " + row.Cells[2].Value.ToString());
                                }));
                                break;

                            case "I16":
                                value = TCPEquipement.Modbus_Server.holdingRegisters.localArray[register];
                                value = Convert.ToInt16(valueTwoRegisters[0]);
                                row.Cells[1].Value = value;

                                tb_Logs.Invoke(new MethodInvoker(delegate
                                {
                                    logMessage("Ecriture reçu à l'adresse : " + (register - 1).ToString() + " | de valeur : " + value.ToString() + " | et de type : " + row.Cells[2].Value.ToString());
                                }));
                                break;

                            case "I32":
                                value = EasyModbus.ModbusClient.ConvertRegistersToInt(valueTwoRegisters);
                                row.Cells[1].Value = value;
                                tb_Logs.Invoke(new MethodInvoker(delegate
                                {
                                    logMessage("Ecriture reçu à l'adresse : " + (register - 1).ToString() + " | de valeur : " + value.ToString() + " | et de type : " + row.Cells[2].Value.ToString());
                                }));
                                break;

                            case "Float":
                                valueFloat = EasyModbus.ModbusClient.ConvertRegistersToFloat(valueTwoRegisters);
                                row.Cells[1].Value = valueFloat;
                                tb_Logs.Invoke(new MethodInvoker(delegate
                                {
                                    logMessage("Ecriture reçu à l'adresse : " + (register - 1).ToString() + " | de valeur : " + valueFloat.ToString() + " | et de type : " + row.Cells[2].Value.ToString());
                                }));
                                break;
                        }
                    }
                }
            }
            catch (Exception err)
            {
                logMessage("Erreur de lécture : " + err.Message);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (TCPEquipement.Mode == "Client")
            {
                try
                {
                    int[] registersTable = TCPEquipement.Modbus_Client.ReadHoldingRegisters(0, AdresseMax + 3);

                    /*
                    foreach (int num in registersTable)
                    {
                        Console.Write(num.ToString() + ";");
                    }
                    Console.WriteLine("");
                    Console.ReadLine();
                    */

                    foreach (DataGridViewRow row in dgv_dataHolder.Rows)
                    {
                        if (row.Cells[1].Style.BackColor != Color.FromArgb(255, 110, 50, 50))
                        {
                            int adresse = Convert.ToInt32(row.Cells[3].Value);
                            string type = row.Cells[2].Value.ToString();
                            int value = 0;
                            Single valueFloat = 0;
                            int[] valueTwoRegisters = new int[2];
                            switch (type)
                            {
                                case "U16":
                                    value = Convert.ToInt16(registersTable[adresse]);
                                    if (value < 0)
                                    {
                                        value = 65535 + (value + 1);
                                    }
                                    value = Convert.ToUInt16(value);
                                    row.Cells[1].Value = value;
                                    row.Cells[5].ToolTipText = "Nom : " + row.Cells[0].Value.ToString() + " | Valeur : " + row.Cells[1].Value.ToString() + " | Type : " + type + " | Adresse : " + row.Cells[3].Value.ToString();
                                    break;
                                case "U32":
                                    valueTwoRegisters[0] = registersTable[adresse];
                                    valueTwoRegisters[1] = registersTable[adresse + 1];
                                    value = EasyModbus.ModbusClient.ConvertRegistersToInt(valueTwoRegisters);
                                    UInt32 valUint32 = 0;
                                    if (value < 0)
                                    {
                                        valUint32 = Convert.ToUInt32(4294967295L + (value + 1));
                                    }
                                    else
                                    {
                                        valUint32 = Convert.ToUInt32(value);
                                    }
                                    row.Cells[1].Value = valUint32;
                                    row.Cells[5].ToolTipText = "Nom : " + row.Cells[0].Value.ToString() + " | Valeur : " + row.Cells[1].Value.ToString() + " | Type : " + type + " | Adresse : " + row.Cells[3].Value.ToString();
                                    break;

                                case "I16":
                                    value = Convert.ToInt16(registersTable[adresse]);
                                    row.Cells[1].Value = value;
                                    row.Cells[5].ToolTipText = "Nom : " + row.Cells[0].Value.ToString() + " | Valeur : " + row.Cells[1].Value.ToString() + " | Type : " + type + " | Adresse : " + row.Cells[3].Value.ToString();
                                    break;

                                case "I32":
                                    valueTwoRegisters[0] = registersTable[adresse];
                                    valueTwoRegisters[1] = registersTable[adresse + 1];
                                    value = EasyModbus.ModbusClient.ConvertRegistersToInt(valueTwoRegisters);
                                    row.Cells[1].Value = value;
                                    row.Cells[5].ToolTipText = "Nom : " + row.Cells[0].Value.ToString() + " | Valeur : " + row.Cells[1].Value.ToString() + " | Type : " + type + " | Adresse : " + row.Cells[3].Value.ToString();
                                    break;

                                case "Float":
                                    valueTwoRegisters[0] = registersTable[adresse];
                                    valueTwoRegisters[1] = registersTable[adresse + 1];
                                    valueFloat = EasyModbus.ModbusClient.ConvertRegistersToFloat(valueTwoRegisters);
                                    row.Cells[1].Value = valueFloat;
                                    row.Cells[5].ToolTipText = "Nom : " + row.Cells[0].Value.ToString() + " | Valeur : " + row.Cells[1].Value.ToString() + " | Type : " + type + " | Adresse : " + row.Cells[3].Value.ToString();
                                    break;
                            }
                        }
                    }
                } catch (Exception err)
                {
                    logMessage("Erreur lécture des registres : " + err.Message + " | déconnexion...");
                    MenuForm menuForm = new MenuForm();
                    menuForm.disconnectTCPEquipement(TCPEquipement);
                }
            }


            if (TCPEquipement.Mode == "Server")
            {
                short[] registersTable = TCPEquipement.Modbus_Server.holdingRegisters.localArray;

                /*
                foreach (int num in registersTable)
                {
                    Console.Write(num.ToString() + ";");
                }
                Console.WriteLine("");
                Console.ReadLine();
                */

                foreach (DataGridViewRow row in dgv_dataHolder.Rows)
                {
                    if (row.Cells[1].Style.BackColor != Color.FromArgb(255, 110, 50, 50))
                    {
                        int adresse = Convert.ToInt32(row.Cells[3].Value) + 1; //Adresse + 1 car local Array contient un 0 de plus au debut exemple adresse 2 -> 10 = [0; 0; 10]
                        string type = row.Cells[2].Value.ToString();
                        int value = 0;
                        Single valueFloat = 0;
                        int[] valueTwoRegisters = new int[2];
                        switch (type)
                        {
                            case "U16":
                                value = Convert.ToInt16(registersTable[adresse]);
                                if (value < 0)
                                {
                                    value = 65535 + (value + 1);
                                }
                                value = Convert.ToUInt16(value);
                                row.Cells[1].Value = value;
                                row.Cells[5].ToolTipText = "Nom : " + row.Cells[0].Value.ToString() + " | Valeur : " + row.Cells[1].Value.ToString() + " | Type : " + type + " | Adresse : " + row.Cells[3].Value.ToString();
                                break;
                            case "U32":
                                valueTwoRegisters[0] = registersTable[adresse];
                                valueTwoRegisters[1] = registersTable[adresse + 1];
                                value = EasyModbus.ModbusClient.ConvertRegistersToInt(valueTwoRegisters);
                                UInt32 valUint32 = 0;
                                if (value < 0)
                                {
                                    valUint32 = Convert.ToUInt32(4294967295L + (value + 1));
                                }
                                else
                                {
                                    valUint32 = Convert.ToUInt32(value);
                                }
                                row.Cells[1].Value = valUint32;
                                row.Cells[5].ToolTipText = "Nom : " + row.Cells[0].Value.ToString() + " | Valeur : " + row.Cells[1].Value.ToString() + " | Type : " + type + " | Adresse : " + row.Cells[3].Value.ToString();
                                break;

                            case "I16":
                                value = Convert.ToInt16(registersTable[adresse]);
                                row.Cells[1].Value = value;
                                row.Cells[5].ToolTipText = "Nom : " + row.Cells[0].Value.ToString() + " | Valeur : " + row.Cells[1].Value.ToString() + " | Type : " + type + " | Adresse : " + row.Cells[3].Value.ToString();
                                break;

                            case "I32":
                                valueTwoRegisters[0] = registersTable[adresse];
                                valueTwoRegisters[1] = registersTable[adresse + 1];
                                value = EasyModbus.ModbusClient.ConvertRegistersToInt(valueTwoRegisters);
                                row.Cells[1].Value = value;
                                row.Cells[5].ToolTipText = "Nom : " + row.Cells[0].Value.ToString() + " | Valeur : " + row.Cells[1].Value.ToString() + " | Type : " + type + " | Adresse : " + row.Cells[3].Value.ToString();
                                break;

                            case "Float":
                                valueTwoRegisters[0] = registersTable[adresse];
                                valueTwoRegisters[1] = registersTable[adresse + 1];
                                valueFloat = EasyModbus.ModbusClient.ConvertRegistersToFloat(valueTwoRegisters);
                                row.Cells[1].Value = valueFloat;
                                row.Cells[5].ToolTipText = "Nom : " + row.Cells[0].Value.ToString() + " | Valeur : " + row.Cells[1].Value.ToString() + " | Type : " + type + " | Adresse : " + row.Cells[3].Value.ToString();
                                break;
                        }
                    }
                }
            }
        }


        private void TCP_Form_VisibleChanged(object sender, EventArgs e) //Empecher l'utilisateur d'envoyer des valeurs si l'equipements n'est pas connecté
        {
            if (tb_Status.Text == "Connected" || tb_Status.Text == "Listening")
            {
                dgv_dataHolder.Visible = true;
            } else
            {
                dgv_dataHolder.Visible = false;
            }
        }
        private void Tb_Status_TextChanged(object sender, EventArgs e)
        {
            if (tb_Status.Text == "Connected" || tb_Status.Text == "Listening")
            {
                dgv_dataHolder.Visible = true;
                timer1.Start();
            }
            else
            {
                dgv_dataHolder.Visible = false;
                timer1.Stop();
            }
        } //Question visibilité
    }
}