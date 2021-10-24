using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedTreeSoftware
{
    class ArduinoWriter
    {
        private SerialPort port;
        public ArduinoWriter(SerialPort port)
        {
            this.port = port;
        }

        public void WriteColorToArduino(Color color)
        {
            
            string ColorCode = "000,000,000S";
            string SR = color.R.ToString();
            string SG = color.G.ToString();
            string SB = color.B.ToString();
            while (SR.Length <= 2)
            {
                SR = "0" + SR;
            }
            while (SG.Length <= 2)
            {
                SG = "0" + SG;
            }
            while (SB.Length <= 2)
            {
                SB = "0" + SB;
            }
            ColorCode = SR + "," + SG + "," + SB + "\n";
            try
            {
                if (port != null)
                {
                    port.Write(ColorCode);
                }
            }
            catch { MessageBox.Show("Failed to send to arduino"); }

            Console.WriteLine(ColorCode);
        }
    }
}
