using Simulateur_CEOG.ModBus_TCP.BEMS;
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
using Simulateur_CEOG.ModBus_RTU;
using Simulateur_CEOG.Profinet;

namespace Simulateur_CEOG
{
    public partial class MenuForm : Form
    {

        #region Liste des equipements

        List<TCP_Class> listTCP_Equipement = new List<TCP_Class>();

        List<RTU_Class> listRTU_Equipement = new List<RTU_Class>();

        #endregion

        public MenuForm()
        {
            InitializeComponent();
        }

        //Au chargement de l'application
        private void MenuForm_Load(object sender, EventArgs e)
        {
            //Enlever les boutons du tab_control
            tc_Main.Appearance = TabAppearance.FlatButtons;
            tc_Main.ItemSize = new Size(0, 1);
            tc_Main.SizeMode = TabSizeMode.Fixed;
        }
        private void selectConfigFile(Object sender, EventArgs e)
        {
            //permet la selection du fichier de configuration
            if (configFileSelector.ShowDialog() == DialogResult.OK) //Si le fichier chemin du fichier de config est bon
            {
                string pathName = configFileSelector.FileName;
                tb_ConfigFileDir.Text = pathName;
            } else
            {
                MessageBox.Show("Erreur lors de la récupération du fichier de configuration");
            }
        }
        private void ReadConfigFile(Object sender, EventArgs e)
        {

            string pathName = tb_ConfigFileDir.Text;

            try //Si la lécture du fichier de config se passe correctement
            {
                tb_ConfigFileDir.Text = pathName;
                StreamReader reader = new StreamReader(File.OpenRead(pathName));
                List<string[]> fileLines = new List<string[]>(); //liste contenant les lignes du fichier

                while (!reader.EndOfStream) // tant que la lécture n'est pas au bout du fichier
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(';');
                    fileLines.Add(values);
                }
                fileLines.RemoveAt(0); // Enleve la premiere ligne du fichier (les en-tetes)

                foreach (string[] line in fileLines) // pour chaque ligne du fichier
                {
                    #region ALIMENTATION LISTE TCP D'EQUIPEMENTS EN TCP
                    if (line[2] == "Modbus TCP")
                    {
                        //récupération des données et création de nos classes
                        string Nom = line[0];
                        string Machine = line[1];
                        string Protocole = line[2];
                        string Mode = line[3];
                        string Configuration_Liaison = line[4];
                        string Fichier_Echange = line[5];
                        TCP_Class newTCP_Equipement = new TCP_Class(Nom, Machine, Protocole, Configuration_Liaison, Mode, Fichier_Echange);
                        listTCP_Equipement.Add(newTCP_Equipement);
                    }
                    #endregion

                    #region ALIMENTATION LISTE RTU D'EQUIPEMENTS EN RTU
                    if (line[2] == "Modbus RTU")
                    {
                        //récupération des données et création de nos classes
                        string Nom = line[0];
                        string Machine = line[1];
                        string Protocole = line[2];
                        string Mode = line[3];
                        string Configuration_Liaison = line[4];
                        string Fichier_Echange = line[5];
                        RTU_Class newRTU_Equipement = new RTU_Class(Nom, Machine, Protocole, Configuration_Liaison, Mode, Fichier_Echange);
                        listRTU_Equipement.Add(newRTU_Equipement);
                    }
                    #endregion
                }

                //Changement de page vers le tableau de bord
                tc_Main.SelectedIndex = 1;
            }
            catch (Exception err) //Si erreur pendant la lécture du fichier de config
            {
                MessageBox.Show("Erreur lécture du fichier de configuration : " + err.Message);
            }

            #region Ajout form dans les classes
            foreach (TCP_Class TCP in listTCP_Equipement)
            {
                TCP_Form Form = new TCP_Form(TCP);
                TCP.Equipement_Form = Form;
                TCP.Equipement_Form.set_tbStatusText("Disconnected");
                TCP.Equipement_Form.Show(); //Ceci permet de charger les formulaire puis de les cacher
                TCP.Equipement_Form.Hide();
            }
            foreach (RTU_Class RTU in listRTU_Equipement)
            {
                RTU_Form Form = new RTU_Form(RTU);
                RTU.Equipement_Form = Form;
                RTU.Equipement_Form.set_tbStatusText("Disconnected");
                RTU.Equipement_Form.Show(); //Ceci permet de charger les formulaire puis de les cacher
                RTU.Equipement_Form.Hide();
            }
            #endregion
            #region Ajout dans les ListBox
            foreach (TCP_Class TCPequipement in listTCP_Equipement)
            {
                switch (TCPequipement.Mode)
                {
                    case "Client":
                        lb_ModBus_TCP_Client.Items.Add(TCPequipement.Nom);
                        break;

                    case "Server":
                        lb_ModBus_TCP_Serveur.Items.Add(TCPequipement.Nom);
                        break;
                }
            }
            foreach (RTU_Class RTUEquipement in listRTU_Equipement)
            {
                switch (RTUEquipement.Mode)
                {
                    case "Client":
                        lb_Modbus_RTU_Client.Items.Add(RTUEquipement.Nom);
                        break;

                    case "Server":
                        lb_ModBus_RTU_Serveur.Items.Add(RTUEquipement.Nom);
                        break;
                }
            }
            #endregion
            #region Ajout des modbus Client/Serveur
            foreach (TCP_Class TCPclass in listTCP_Equipement) //Ajout des modbus de la DLL dans les classes
            {
                switch (TCPclass.Mode)
                {
                    case "Client":
                        ModbusClient client = new ModbusClient();
                        client.IPAddress = TCPclass.AdressIP;
                        client.Port = TCPclass.Port;
                        TCPclass.Modbus_Client = client;
                        break;

                    case "Server":
                        ModbusServer server = new ModbusServer();
                        IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                        server.LocalIPAddress = host.AddressList[3];
                        server.Port = TCPclass.Port;
                        TCPclass.Modbus_Server = server;
                        break;
                }
            }
            foreach (RTU_Class RTUclass in listRTU_Equipement) //Ajout des modbus de la DLL dans les classes
            {
                switch (RTUclass.Mode)
                {
                    case "Client":
                        ModbusClient client = new ModbusClient();
                        client.SerialPort = RTUclass.SerialPort;
                        client.Baudrate = RTUclass.Baudrate;
                        client.Parity = RTUclass.Parity;
                        client.StopBits = RTUclass.Stopbits;
                        client.UnitIdentifier = RTUclass.ID;
                        RTUclass.Modbus_Client = client;
                        break;

                    case "Server":
                        ModbusServer server = new ModbusServer();
                        server.SerialFlag = true;
                        server.SerialPort = RTUclass.SerialPort;
                        server.Baudrate = RTUclass.Baudrate;
                        server.StopBits = RTUclass.Stopbits;
                        server.Parity = RTUclass.Parity;
                        server.Port = RTUclass.Port;
                        server.UnitIdentifier = RTUclass.ID;
                        RTUclass.Modbus_Server = server;
                        break;
                }
            }
            #endregion
        }

        ////Partie graphique RTU + connexions equipements
        private void Lb_ModBus_TCP_DoubleClick(object sender, EventArgs e)
        {
            //affiche le form de la classe séléctioné

            #region formulaire TCP client
            if (sender == lb_ModBus_TCP_Client)
            {
                try
                {
                    string selectedEquipementName = lb_ModBus_TCP_Client.SelectedItem.ToString();
                    foreach (TCP_Class TCPclass in listTCP_Equipement)
                    {
                        if (selectedEquipementName == TCPclass.Nom) //récupération de la bonne classe
                        {
                            TCPclass.Equipement_Form.Show();
                        }
                    }
                }
                catch // si aucun item selectioné, ne rien faire
                {

                }
            }

            #endregion

            #region formulaire TCP serveur
            if (sender == lb_ModBus_TCP_Serveur)
            {
                try
                {
                    string selectedEquipementName = lb_ModBus_TCP_Serveur.SelectedItem.ToString();
                    foreach (TCP_Class TCPclass in listTCP_Equipement)
                    {
                        if (selectedEquipementName == TCPclass.Nom)
                        {
                            TCPclass.Equipement_Form.Show();
                        }
                    }
                }
                catch
                {

                }
            }
            #endregion
        }
        private void Lb_ModBus_TCP_SelectedIndexChanged(object sender, EventArgs e) //Quand l'element choisie de la liste change
        {
            #region affichage radiobuttons TCP client quand changement de selection d'item
            if (sender == lb_ModBus_TCP_Client)
            {
                try
                {
                    string equipementName = lb_ModBus_TCP_Client.SelectedItem.ToString();
                    foreach (TCP_Class TCPequipement in listTCP_Equipement)
                    {
                        if (TCPequipement.Nom == equipementName) //recupere la bonne classe
                        {
                            gb_TCP_Client_Connexion.Text = TCPequipement.Nom;
                            switch (TCPequipement.ConnexionStatus)
                            {
                                case "Connected": // si l'élement est connecter
                                    rb_TCP_Client_Connect.Checked = false;
                                    rb_TCP_Client_Disconnect.Checked = false;

                                    rb_TCP_Client_Connect.Enabled = false;
                                    rb_TCP_Client_Disconnect.Enabled = true;
                                    break;

                                case "Disconnected": // si l'élément est deconnecter
                                    rb_TCP_Client_Connect.Checked = false;
                                    rb_TCP_Client_Disconnect.Checked = false;

                                    rb_TCP_Client_Connect.Enabled = true;
                                    rb_TCP_Client_Disconnect.Enabled = false;
                                    break;
                            }
                        }
                    }
                }
                catch
                {

                }
            }
            #endregion

            #region affichage radiobuttons TCP serveur quand changement de selection d'item
            if (sender == lb_ModBus_TCP_Serveur)
            {
                try
                {
                    string equipementName = lb_ModBus_TCP_Serveur.SelectedItem.ToString();
                    foreach (TCP_Class TCPequipement in listTCP_Equipement)
                    {
                        if (TCPequipement.Nom == equipementName)
                        {
                            gb_TCP_Serveur_Connexion.Text = TCPequipement.Nom;
                            switch (TCPequipement.ConnexionStatus)
                            {
                                case "Listening":
                                    rb_TCP_Serveur_Connect.Checked = false;
                                    rb_TCP_Serveur_Disconnect.Checked = false;

                                    rb_TCP_Serveur_Connect.Enabled = false;
                                    rb_TCP_Serveur_Disconnect.Enabled = true;

                                    break;

                                case "Disconnected":
                                    rb_TCP_Serveur_Connect.Checked = false;
                                    rb_TCP_Serveur_Disconnect.Checked = false;

                                    rb_TCP_Serveur_Connect.Enabled = true;
                                    rb_TCP_Serveur_Disconnect.Enabled = false;
                                    break;
                            }
                        }
                    }
                }
                catch
                {

                }
            }
            #endregion
        }
        private void tcpRadioButtons_CheckedChanged(Object sender, EventArgs e)
        {
            /*Cette fonction se trouve dans 2 radiobuttons donc pour eviter qu'elle se déclanche deux fois (elle se déclanche a chaque changement sur 1 radiobutton)
            C'est pour cela que les radio button ne sont jamais selectioner par le code, explication :
            si nous changons de client sélectioner, il faut que les radios button change en fonction de son status de connexion
            seulement, si nous changons directement le radiobutton selectioné, cette fonction est appelé et va tenter une connexion non voulu
            vu que nous voulons un changement purement graphique, j'utilise l'option Enabled des radiobutton qui marche bien pour ce cas
            */
            if (((RadioButton)sender).Checked) // pour ne pas que la fonction se lance 2 fois (1 seule bouton est .Checked donc elle se lance une fois)
            {
                #region Si RadioButton TCP Client changé
                if (sender == rb_TCP_Client_Connect) //Regarde quel radiobutton appel l'event
                {
                    string equipementName = lb_ModBus_TCP_Client.SelectedItem.ToString();
                    foreach (TCP_Class TCPEquipement in listTCP_Equipement)
                    {
                        if (equipementName == TCPEquipement.Nom)
                        {
                            connectTCPEquipement(TCPEquipement); //Connecte l'equipement grace a la fonction écrite plus haut
                        }
                    }
                }
                if (sender == rb_TCP_Client_Disconnect)
                {
                    string equipementName = lb_ModBus_TCP_Client.SelectedItem.ToString();
                    foreach (TCP_Class TCPEquipement in listTCP_Equipement)
                    {
                        if (equipementName == TCPEquipement.Nom)
                        {
                            disconnectTCPEquipement(TCPEquipement);
                        }
                    }
                }
                #endregion

                #region Si RadioButton TCP Serveur changé
                if (sender == rb_TCP_Serveur_Connect)
                {
                    string equipementName = lb_ModBus_TCP_Serveur.SelectedItem.ToString();
                    foreach (TCP_Class TCPEquipement in listTCP_Equipement)
                    {
                        if (equipementName == TCPEquipement.Nom)
                        {
                            connectTCPEquipement(TCPEquipement);
                        }
                    }
                }
                if (sender == rb_TCP_Serveur_Disconnect)
                {
                    string equipementName = lb_ModBus_TCP_Serveur.SelectedItem.ToString();
                    foreach (TCP_Class TCPEquipement in listTCP_Equipement)
                    {
                        if (equipementName == TCPEquipement.Nom)
                        {
                            disconnectTCPEquipement(TCPEquipement);
                        }
                    }
                }
                #endregion
            }
        }

        //Partie graphique RTU + connexions equipements
        private void Lb_Modbus_RTU_DoubleClick(object sender, EventArgs e)
        {
            //affiche le form de la classe séléctioné

            #region formulaire RTU client
            if (sender == lb_Modbus_RTU_Client)
            {
                try
                {
                    string selectedEquipementName = lb_Modbus_RTU_Client.SelectedItem.ToString();
                    foreach (RTU_Class RTUclass in listRTU_Equipement)
                    {
                        if (selectedEquipementName == RTUclass.Nom) //récupération de la bonne classe
                        {
                            RTUclass.Equipement_Form.Show();
                        }
                    }
                }
                catch // si aucun item selectioné, ne rien faire
                {

                }
            }

            #endregion

            #region formulaire RTU serveur
            if (sender == lb_ModBus_RTU_Serveur)
            {
                try
                {
                    string selectedEquipementName = lb_ModBus_RTU_Serveur.SelectedItem.ToString();
                    foreach (RTU_Class RTUclass in listRTU_Equipement)
                    {
                        if (selectedEquipementName == RTUclass.Nom)
                        {
                            RTUclass.Equipement_Form.Show();
                        }
                    }
                }
                catch
                {

                }
            }
            #endregion
        }
        private void Lb_Modbus_RTU_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region affichage radiobuttons RTU client quand changement de selection d'item
            if (sender == lb_Modbus_RTU_Client)
            {
                try
                {
                    string equipementName = lb_Modbus_RTU_Client.SelectedItem.ToString();
                    foreach (RTU_Class RTUequipement in listRTU_Equipement)
                    {
                        if (RTUequipement.Nom == equipementName) //recupere la bonne classe
                        {
                            gb_RTU_Client_Connexion.Text = RTUequipement.Nom;
                            switch (RTUequipement.ConnexionStatus)
                            {
                                case "Connected": // si l'élement est connecter
                                    rb_RTU_Client_Connect.Checked = false;
                                    rb_RTU_Client_Disconnect.Checked = false;

                                    rb_RTU_Client_Connect.Enabled = false;
                                    rb_RTU_Client_Disconnect.Enabled = true;
                                    break;

                                case "Disconnected": // si l'élément est deconnecter
                                    rb_RTU_Client_Connect.Checked = false;
                                    rb_RTU_Client_Disconnect.Checked = false;

                                    rb_RTU_Client_Connect.Enabled = true;
                                    rb_RTU_Client_Disconnect.Enabled = false;
                                    break;
                            }
                        }
                    }
                }
                catch
                {

                }
            }
            #endregion

            #region affichage radiobuttons RTU serveur quand changement de selection d'item
            if (sender == lb_ModBus_RTU_Serveur)
            {
                try
                {
                    string equipementName = lb_ModBus_RTU_Serveur.SelectedItem.ToString();
                    foreach (RTU_Class RTUequipement in listRTU_Equipement)
                    {
                        if (RTUequipement.Nom == equipementName)
                        {
                            gb_RTU_Serveur_Connexion.Text = RTUequipement.Nom;
                            switch (RTUequipement.ConnexionStatus)
                            {
                                case "Listening":
                                    rb_RTU_Serveur_Connect.Checked = false;
                                    rb_RTU_Serveur_Disconnect.Checked = false;

                                    rb_RTU_Serveur_Connect.Enabled = false;
                                    rb_RTU_Serveur_Disconnect.Enabled = true;

                                    break;

                                case "Disconnected":
                                    rb_RTU_Serveur_Connect.Checked = false;
                                    rb_RTU_Serveur_Disconnect.Checked = false;

                                    rb_RTU_Serveur_Connect.Enabled = true;
                                    rb_RTU_Serveur_Disconnect.Enabled = false;
                                    break;
                            }
                        }
                    }
                }
                catch
                {

                }
            }
            #endregion
        }
        private void rtuRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) // pour ne pas que la fonction se lance 2 fois (1 seule bouton est .Checked donc elle se lance une fois)
            {
                #region Si RadioButton RTU Client changé
                if (sender == rb_RTU_Client_Connect) //Regarde quel radiobutton appel l'event
                {
                    string equipementName = lb_Modbus_RTU_Client.SelectedItem.ToString();
                    foreach (RTU_Class RTUEquipement in listRTU_Equipement)
                    {
                        if (equipementName == RTUEquipement.Nom)
                        {
                            connectRTUEquipement(RTUEquipement); //Connecte l'equipement grace a la fonction écrite plus haut
                        }
                    }
                }
                if (sender == rb_RTU_Client_Disconnect)
                {
                    string equipementName = lb_Modbus_RTU_Client.SelectedItem.ToString();
                    foreach (RTU_Class RTUEquipement in listRTU_Equipement)
                    {
                        if (equipementName == RTUEquipement.Nom)
                        {
                            disconnectRTUEquipement(RTUEquipement); //Connecte l'equipement grace a la fonction écrite plus haut
                        }
                    }
                }
                #endregion

                #region Si RadioButton RTU Serveur changé
                if (sender == rb_RTU_Serveur_Connect)
                {
                    string equipementName = lb_ModBus_RTU_Serveur.SelectedItem.ToString();
                    foreach (RTU_Class RTUEquipement in listRTU_Equipement)
                    {
                        if (equipementName == RTUEquipement.Nom)
                        {
                            connectRTUEquipement(RTUEquipement);
                        }
                    }
                }
                if (sender == rb_RTU_Serveur_Disconnect)
                {
                    string equipementName = lb_ModBus_RTU_Serveur.SelectedItem.ToString();
                    foreach (RTU_Class RTUEquipement in listRTU_Equipement)
                    {
                        if (equipementName == RTUEquipement.Nom)
                        {
                            disconnectRTUEquipement(RTUEquipement);
                        }
                    }
                }
                #endregion
            }
        }


        //Connexions des équipements
        private void connectTCPEquipement(TCP_Class TCPclass)
        {
            switch (TCPclass.Mode)
            {
                case "Client": //Connexion client
                    try
                    {
                        if (TCPclass.Modbus_Client.Connected == false) //si le client n'est pas connécté
                        {
                            TCPclass.Equipement_Form.logMessage("Trying connexion at : IP->" + TCPclass.AdressIP + " / Port->" + TCPclass.Port.ToString());
                            TCPclass.Modbus_Client.Connect();
                            TCPclass.ConnexionStatus = "Connected";
                            TCPclass.Equipement_Form.set_tbStatusText("Connected");
                            TCPclass.Equipement_Form.logMessage("Connexion established at : IP->" + TCPclass.AdressIP + " / Port->" + TCPclass.Port.ToString());

                            //Ceci permet de disable les radiobutton en fonction de la connexion (Explication dans la fonction des radiobutton)
                            rb_TCP_Client_Connect.Checked = false;
                            rb_TCP_Client_Disconnect.Checked = false;

                            rb_TCP_Client_Connect.Enabled = false;
                            rb_TCP_Client_Disconnect.Enabled = true;
                        }
                    }
                    catch (Exception e)
                    {
                        TCPclass.Equipement_Form.logMessage("Connexion failed at : IP->" + TCPclass.AdressIP + " / Port->" + TCPclass.Port.ToString());
                        rb_TCP_Client_Connect.Checked = false;
                        rb_TCP_Client_Disconnect.Checked = false;

                        rb_TCP_Client_Connect.Enabled = true;
                        rb_TCP_Client_Disconnect.Enabled = false;
                        MessageBox.Show("Erreur connexion Client (verifier qu'un serveur écoute et que les adresse IP sont bien attribuées : " + TCPclass.Nom + " | " + e.Message);
                    }
                    break;

                case "Server": //Ecoute serveur
                    try
                    {
                        TCPclass.Equipement_Form.logMessage("Trying listen on : IP->" + TCPclass.AdressIP + " / Port->" + TCPclass.Port.ToString());
                        TCPclass.Modbus_Server.Listen();
                        TCPclass.Modbus_Server.HoldingRegistersChanged += new ModbusServer.HoldingRegistersChangedHandler(TCPclass.Equipement_Form.registersChanged);
                        TCPclass.Equipement_Form.logMessage("Listen successful on : IP." + TCPclass.AdressIP + " Port." + TCPclass.Port.ToString());
                        TCPclass.ConnexionStatus = "Listening";
                        TCPclass.Equipement_Form.set_tbStatusText("Listening");
                        rb_TCP_Serveur_Connect.Checked = false;
                        rb_TCP_Serveur_Disconnect.Checked = false;

                        rb_TCP_Serveur_Connect.Enabled = false;
                        rb_TCP_Serveur_Disconnect.Enabled = true;
                    }
                    catch (Exception e)
                    {
                        TCPclass.Equipement_Form.logMessage("Listen failed on : IP->" + TCPclass.AdressIP + " / Port->" + TCPclass.Port.ToString());
                        rb_TCP_Serveur_Connect.Checked = false;
                        rb_TCP_Serveur_Disconnect.Checked = false;

                        rb_TCP_Serveur_Connect.Enabled = true;
                        rb_TCP_Serveur_Disconnect.Enabled = false;
                        MessageBox.Show("Erreur écoute Serveur : " + TCPclass.Nom + " | " + e.Message);
                    }
                    break;
            }
        }
        public void disconnectTCPEquipement(TCP_Class TCPclass)
        {
            switch (TCPclass.Mode)
            {
                case "Client": //Déconnexion client
                    try
                    {
                        if (TCPclass.Modbus_Client.Connected)
                        {
                            TCPclass.Modbus_Client.Disconnect();
                            TCPclass.Equipement_Form.logMessage("Client successfully disconnected from : IP->" + TCPclass.AdressIP + " / Port->" + TCPclass.Port.ToString());
                            TCPclass.ConnexionStatus = "Disconnected";
                            TCPclass.Equipement_Form.set_tbStatusText("Disconnected");
                            rb_TCP_Client_Connect.Checked = false;
                            rb_TCP_Client_Disconnect.Checked = false;

                            rb_TCP_Client_Connect.Enabled = true;
                            rb_TCP_Client_Disconnect.Enabled = false;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Erreur déconnexion Client : " + TCPclass.Nom + " | " + e.Message);
                    }
                    break;

                case "Server": // Arret écoute serveur
                    try
                    {
                        TCPclass.Modbus_Server.StopListening();
                        TCPclass.Equipement_Form.logMessage("Server successfully stopped listening on : IP->" + TCPclass.AdressIP + " / Port->" + TCPclass.Port.ToString());
                        TCPclass.ConnexionStatus = "Disconnected";
                        TCPclass.Equipement_Form.set_tbStatusText("Disconnected");
                        rb_TCP_Serveur_Connect.Checked = false;
                        rb_TCP_Serveur_Disconnect.Checked = false;

                        rb_TCP_Serveur_Connect.Enabled = true;
                        rb_TCP_Serveur_Disconnect.Enabled = false;
                    }
                    catch (Exception e)
                    {
                        //MessageBox.Show("Erreur stop écoute Serveur : " + TCPclass.Nom + " | " + e.Message);
                    }
                    break;
            }
        }

        private void connectRTUEquipement(RTU_Class RTUclass)
        {
            switch (RTUclass.Mode)
            {
                case "Client": //Connexion client
                    try
                    {
                        if (RTUclass.Modbus_Client.Connected == false) //si le client n'est pas connécté
                        {
                            RTUclass.Equipement_Form.logMessage("Trying connexion at : SerialPort->" + RTUclass.SerialPort + " / Port->" + RTUclass.Port.ToString());
                            RTUclass.Modbus_Client.Connect();
                            RTUclass.ConnexionStatus = "Connected";
                            RTUclass.Equipement_Form.set_tbStatusText("Connected");
                            RTUclass.Equipement_Form.logMessage("Connexion established at : SerialPort->" + RTUclass.SerialPort + " / Port->" + RTUclass.Port.ToString());

                            //Ceci permet de disable les radiobutton en fonction de la connexion (Explication dans la fonction des radiobutton)
                            rb_RTU_Client_Connect.Checked = false;
                            rb_RTU_Client_Disconnect.Checked = false;

                            rb_RTU_Client_Connect.Enabled = false;
                            rb_RTU_Client_Disconnect.Enabled = true;
                        }
                    }
                    catch (Exception e)
                    {
                        RTUclass.Equipement_Form.logMessage("Connexion failed at : SerialPort->" + RTUclass.SerialPort + " / Port->" + RTUclass.Port.ToString());
                        rb_RTU_Client_Connect.Checked = false;
                        rb_RTU_Client_Disconnect.Checked = false;

                        rb_RTU_Client_Connect.Enabled = true;
                        rb_RTU_Client_Disconnect.Enabled = false;
                        MessageBox.Show("Erreur connexion Client (verifier qu'un serveur écoute et que les adresse IP sont bien attribuées : " + RTUclass.Nom + " | " + e.Message);
                    }
                    break;

                case "Server": //Ecoute serveur
                    try
                    {
                        RTUclass.Equipement_Form.logMessage("Trying listen on : SerialPort->" + RTUclass.SerialPort + " / Port->" + RTUclass.Port.ToString());
                        RTUclass.Modbus_Server.Listen();
                        RTUclass.Modbus_Server.HoldingRegistersChanged += new ModbusServer.HoldingRegistersChangedHandler(RTUclass.Equipement_Form.registersChanged);
                        RTUclass.Equipement_Form.logMessage("Listen successful on : SerialPort." + RTUclass.SerialPort + " Port." + RTUclass.Port.ToString());
                        RTUclass.ConnexionStatus = "Listening";
                        RTUclass.Equipement_Form.set_tbStatusText("Listening");
                        rb_RTU_Serveur_Connect.Checked = false;
                        rb_RTU_Serveur_Disconnect.Checked = false;

                        rb_RTU_Serveur_Connect.Enabled = false;
                        rb_RTU_Serveur_Disconnect.Enabled = true;
                    }
                    catch (Exception e)
                    {
                        RTUclass.Equipement_Form.logMessage("Listen failed on : SerialPort->" + RTUclass.SerialPort + " / Port->" + RTUclass.Port.ToString());
                        rb_RTU_Serveur_Connect.Checked = false;
                        rb_RTU_Serveur_Disconnect.Checked = false;

                        rb_RTU_Serveur_Connect.Enabled = true;
                        rb_RTU_Serveur_Disconnect.Enabled = false;
                        MessageBox.Show("Erreur écoute Serveur : " + RTUclass.Nom + " | " + e.Message);
                    }
                    break;
            }
        }
        public void disconnectRTUEquipement(RTU_Class RTUclass)
        {
            switch (RTUclass.Mode)
            {
                case "Client": //Déconnexion client
                    try
                    {
                        if (RTUclass.Modbus_Client.Connected)
                        {
                            RTUclass.Modbus_Client.Disconnect();
                            RTUclass.Equipement_Form.logMessage("Client successfully disconnected from : SerialPort->" + RTUclass.SerialPort + " / Port->" + RTUclass.Port.ToString());
                            RTUclass.ConnexionStatus = "Disconnected";
                            RTUclass.Equipement_Form.set_tbStatusText("Disconnected");
                            rb_RTU_Client_Connect.Checked = false;
                            rb_RTU_Client_Disconnect.Checked = false;

                            rb_RTU_Client_Connect.Enabled = true;
                            rb_RTU_Client_Disconnect.Enabled = false;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Erreur déconnexion Client : " + RTUclass.Nom + " | " + e.Message);
                    }
                    break;

                case "Server": // Arret écoute serveur
                    try
                    {
                        RTUclass.Modbus_Server.StopListening();
                        RTUclass.Equipement_Form.logMessage("Server successfully stopped listening on : SerialPort->" + RTUclass.SerialPort + " / Port->" + RTUclass.Port.ToString());
                        RTUclass.ConnexionStatus = "Disconnected";
                        RTUclass.Equipement_Form.set_tbStatusText("Disconnected");
                        rb_RTU_Serveur_Connect.Checked = false;
                        rb_RTU_Serveur_Disconnect.Checked = false;

                        rb_RTU_Serveur_Connect.Enabled = true;
                        rb_RTU_Serveur_Disconnect.Enabled = false;
                    }
                    catch
                    {
                        //MessageBox.Show("Erreur stop écoute Serveur : " + TCPclass.Nom + " | " + e.Message);
                    }
                    break;
            }
        }

        //Fonctionnalitées supplémentaires
        private void changeConfigBtn(Object sender, EventArgs e)
        {
            lb_ModBus_TCP_Client.Items.Clear();
            lb_ModBus_TCP_Serveur.Items.Clear();
            lb_Modbus_RTU_Client.Items.Clear();
            lb_ModBus_RTU_Serveur.Items.Clear();
            lb_Profinet_Client.Items.Clear();
            lb_Profinet_Serveur.Items.Clear();

            foreach(TCP_Class eq in listTCP_Equipement)
            {
                disconnectTCPEquipement(eq);
                eq.Equipement_Form.Close();
            }

            listTCP_Equipement.Clear();

            tb_ConfigFileDir.Text = "";
            tc_Main.SelectedIndex = 0;
        }

        private void terminateAllConnexions(Object sender, EventArgs e)
        {
            foreach (TCP_Class eq in listTCP_Equipement)
            {
                disconnectTCPEquipement(eq);
                eq.Equipement_Form.Close();
            }
            MessageBox.Show("Toute les connexions ont été éliminé");
        }

        private void openEquipementsFile(Object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\ConfigEquipementsCSV");
        }


    }
}
