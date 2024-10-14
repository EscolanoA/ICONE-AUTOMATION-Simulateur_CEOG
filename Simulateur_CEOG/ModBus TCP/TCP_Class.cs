using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;

namespace Simulateur_CEOG.ModBus_TCP.BEMS
{
    public class TCP_Class
    {
        public string Nom;
        public string Machine;
        public string Protocol;
        public string Configuration_Liaison;
        public string Mode;
        public string Fichier_Echange;

        public string AdressIP;
        public int Port;
        public int Pooling;

        public ModbusClient Modbus_Client;
        public ModbusServer Modbus_Server;

        public TCP_Form Equipement_Form;

        public string ConnexionStatus = "Disconnected";

        public TCP_Class(string Nom, string Machine, string Protocol, string Configuration_Liaison, string Mode, string Fichier_Echange)
        {
            this.Nom = Nom;
            this.Machine = Machine;
            this.Protocol = Protocol;
            this.Configuration_Liaison = Configuration_Liaison;
            this.Mode = Mode;
            this.Fichier_Echange = AppDomain.CurrentDomain.BaseDirectory + Fichier_Echange;
            this.AdressIP = Configuration_Liaison.Split('|')[0];
            this.Port = Convert.ToInt32(Configuration_Liaison.Split('|')[1]);
            this.Pooling = Convert.ToInt32(Configuration_Liaison.Split('|')[2]);
        }
    }
}
