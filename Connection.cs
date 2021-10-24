using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedTreeSoftware
{
    class Connection
    {
        private string[] ports;
        public Connection()
        {
            
        }
        public string[] GetPortArray()
        {
            ports = SerialPort.GetPortNames();
            return ports;
        }

        public SerialPort ConnectToArduino(string SerialPort)
        {
            if (SerialPort != null && SerialPort != "")
            {
                
                SerialPort port;
                string selectedPort = SerialPort;
                port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                try
                {
                    Console.WriteLine("pripojeno");
                    port.Open();
                    return port;
                }
                catch { }
                return null;
            }
            else
                return null;
        }
    }
}
