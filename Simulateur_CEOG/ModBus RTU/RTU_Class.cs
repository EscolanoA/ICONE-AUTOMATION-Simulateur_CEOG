using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using Simulateur_CEOG.ModBus_TCP.BEMS;

namespace Simulateur_CEOG.ModBus_RTU
{
    public class RTU_Class
    {
        public string Nom;
        public string Machine;
        public string Protocol;
        public string Configuration_Liaison;
        public string Mode;
        public string Fichier_Echange;

        public byte ID;
        public string SerialPort;
        public int Pooling;
        public int Baudrate;
        public System.IO.Ports.Parity Parity;
        public System.IO.Ports.StopBits Stopbits;
        public int Port;

        public ModbusClient Modbus_Client;
        public ModbusServer Modbus_Server;

        public RTU_Form Equipement_Form;

        public string ConnexionStatus = "Disconnected";

        public RTU_Class(string Nom, string Machine, string Protocol, string Configuration_Liaison, string Mode, string Fichier_Echange)
        {
            this.Nom = Nom;
            this.Machine = Machine;
            this.Protocol = Protocol;
            this.Configuration_Liaison = Configuration_Liaison;
            this.Mode = Mode;
            this.Fichier_Echange = AppDomain.CurrentDomain.BaseDirectory + Fichier_Echange;

            this.ID = Convert.ToByte(Configuration_Liaison.Split('|')[4]);
            this.SerialPort = Configuration_Liaison.Split('|')[0];
            this.Pooling = Convert.ToInt32(Configuration_Liaison.Split('|')[5]);
            this.Baudrate = Convert.ToInt32(Configuration_Liaison.Split('|')[1]);
            this.Port = Convert.ToInt32(Configuration_Liaison.Split('|')[6]);
            string parity = Configuration_Liaison.Split('|')[2];
            switch (parity)
            {
                case "0":
                    this.Parity = System.IO.Ports.Parity.None;
                    break;
                case "1":
                    this.Parity = System.IO.Ports.Parity.Odd;
                    break;

                case "2":
                    this.Parity = System.IO.Ports.Parity.Even;
                    break;

                case "3":
                    this.Parity = System.IO.Ports.Parity.Mark;
                    break;

                case "4":
                    this.Parity = System.IO.Ports.Parity.Space;
                    break;

            }

            string stopbits = Configuration_Liaison.Split('|')[3];
            switch (stopbits)
            {
                case "0":
                    this.Stopbits = System.IO.Ports.StopBits.None;
                    break;
                case "1":
                    this.Stopbits = System.IO.Ports.StopBits.One;
                    break;

                case "2":
                    this.Stopbits = System.IO.Ports.StopBits.Two;
                    break;

                case "3":
                    this.Stopbits = System.IO.Ports.StopBits.OnePointFive;
                    break;
            }
        }
    }
}
