using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace LedTreeSoftware
{
    public partial class Form1 : Form
    {

        Settings1 settings = new Settings1();
        bool SettingsOnce = false;
        bool MoreOnce = false;
        bool PowerOnce = false;
        Connection connection = new Connection();
        private SerialPort port;
        ArduinoWriter arduinoWriter = null;
        Color CurrentColor = Color.White;
        int AnimationDelay = 200;
        bool ClickedOnColor = false;
        MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
        bool CanSend = false;

        IEffectmodel TypEfektu;

        public Form1()
        {
            InitializeComponent();
            roundPanel_Settings.Visible = false;
            roundPanel_More.Visible = false;
            Inicializace(settings.Power);
            FillComboBoxPortsAndLoadEverything(connection.GetPortArray());
            LoadLastSaved();
        }

        private void FillComboBoxPortsAndLoadEverything(string[] ports)
        {

            foreach (var item in ports)
            {
                comboBox_Ports.Items.Add(item);
            }
            int selectedIndex = Array.IndexOf(ports, settings.Port);
            comboBox_Ports.SelectedIndex = selectedIndex;

            if (comboBox_Ports.SelectedItem != null)
            {
                try
                {
                    port = connection.ConnectToArduino(settings.Port);
                    Console.WriteLine(settings.Port);
                    label_ArduinoStatus.Text = "Arduino connected";
                    label_ArduinoStatus.ForeColor = Color.FromArgb(0, 255, 0);
                    arduinoWriter = new ArduinoWriter(port);
                    CanSend = true;
                }
                catch
                {
                    CanSend = false;
                    Console.WriteLine("nepripojeno");
                    label_ArduinoStatus.Text = "Arduino disconnected";
                    label_ArduinoStatus.ForeColor = Color.FromArgb(255, 0, 0);
                }
            }
            else
            {
                CanSend = false;
                Console.WriteLine("nepripojeno");
                label_ArduinoStatus.Text = "Arduino disconnected";
                label_ArduinoStatus.ForeColor = Color.FromArgb(255, 0, 0);
            }


            CurrentColor = settings.Color;


            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);


            comboBox_Devices.Items.AddRange(devices.ToArray());

            comboBox_Devices.SelectedIndex = settings.SelectedDevice;
        }


        private void Inicializace(bool Power)
        {
            label_TreeOff.Text = (Power) ? "" : "Off";
            roundPanel_ColorInfo.BackColor = (Power) ? settings.Color : Color.FromArgb(0, 0, 0);
            roundedButton_MoreOptions.Visible = Power;
            roundPanel_ColorSpectre.Visible = Power;
            PowerOnce = Power;
            if (MoreOnce)
            {
                roundPanel_More.Visible = Power;
            }

        }
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (!SettingsOnce)
            {
                roundPanel_Settings.Visible = true;
                SettingsOnce = true;
                roundedButton_Power.Visible = false;
                roundPanel_Settings.BringToFront();
            }
            else
            {
                settings.SelectedDevice = comboBox_Devices.SelectedIndex;
                roundPanel_Settings.Visible = false;
                SettingsOnce = false;
                roundedButton_Power.Visible = true;
                settings.Save();
            }
        }

        private void roundedButton_MoreOptions_Click(object sender, EventArgs e)
        {
            if (!MoreOnce)
            {
                roundPanel_More.Visible = true;
                MoreOnce = true;
                roundedButton_MoreOptions.Text = "ᐯ";
                roundPanel_More.BringToFront();
            }
            else
            {
                roundPanel_More.Visible = false;
                MoreOnce = false;
                roundedButton_MoreOptions.Text = "ᐱ";

            }
        }

        private void roundedButton_Power_Click(object sender, EventArgs e)
        {
            if (!PowerOnce && CanSend)
            {
                Inicializace(true);
                settings.Power = true;
                PowerOnce = true;
               
                arduinoWriter.WriteColorToArduino(settings.Color);
                settings.LastSaved = "nic";
                settings.Save();
            }
            else if (CanSend)
            {
                Inicializace(false);
                settings.Power = false;
  
                
                settings.LastSaved = "off";
                PowerOnce = false;
                
                settings.Save();
                AnimationsOff();
                arduinoWriter.WriteColorToArduino(Color.FromArgb(0, 0, 0));
            }
        }

        private void roundedButton_Save_Click(object sender, EventArgs e)
        {
            string SelectedPort;
            if (comboBox_Ports.SelectedItem != null)
            {
                SelectedPort = comboBox_Ports.SelectedItem.ToString();
                try
                {

                    port = connection.ConnectToArduino(SelectedPort);

                    settings.Port = comboBox_Ports.SelectedItem.ToString();
                    settings.Save();
                    label_ArduinoStatus.Text = "Arduino connected";
                    label_ArduinoStatus.ForeColor = Color.FromArgb(0, 255, 0);
                    arduinoWriter = new ArduinoWriter(port);
                }
                catch
                {
                    Console.WriteLine("nepripojeno");
                    label_ArduinoStatus.Text = "Arduino disconnected";
                    label_ArduinoStatus.ForeColor = Color.FromArgb(255, 0, 0);
                }
            }
            else
            {
                Console.WriteLine("nepripojeno");
                label_ArduinoStatus.Text = "Arduino disconnected";
                label_ArduinoStatus.ForeColor = Color.FromArgb(255, 0, 0);
            }

        }


        void AnimationsOff()
        {
            if (TypEfektu != null)
            {
                TypEfektu.Running = false;
                Console.WriteLine(TypEfektu.Running);
            }
        }

       

        void LedEffect(IEffectmodel Effect) //vstupuje nejaka urcita instance efektu, která je child od interface
        {
            int counter = Effect.MinValue;
            Task.Run(async () =>
            {
                MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
                var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
                int[] barvy = new int[3];
                while (Effect.Running && CanSend)
                {
                    arduinoWriter.WriteColorToArduino(Color.FromArgb(barvy[0], barvy[1], barvy[2]));
                    if (Effect.Name == "Sound")
                    {
                        int value = (int)(devices.ToArray()[comboBox_Devices.SelectedIndex].AudioMeterInformation.MasterPeakValue * 1200);
                        barvy = Effect.DoEffect(value);
                    }
                    else
                    {
                        barvy = Effect.DoEffect(counter); // metoda interfacu .DoEffect(int pozice)
                        counter++;
                        if (counter >= Effect.MaxValue)  //vlastnot interface .MaxValue a .MinValue
                        {
                            counter = Effect.MinValue;
                        }
                        await Task.Delay(AnimationDelay);
                    }
                    
                }
            });
        }

        private void StartEffect(IEffectmodel NovyEfekt) // zastavi predchozi efekt a zapne efeckt v (//params)
        {
            if (TypEfektu != null) //kdyz existuje instance, vypni predchozi efekt
            {
                TypEfektu.Running = false;
            }
            else
            {
                TypEfektu = NovyEfekt; //vytvori novou instanci
            }
            TypEfektu = NovyEfekt;
            TypEfektu.Running = true; //zapne 
            LedEffect(TypEfektu);
            settings.LastSaved = TypEfektu.Name;
            settings.Save();
        }

        private void roundedButton_Blue_Click(object sender, EventArgs e)
        {
            StartEffect(new LedStorm());
        }

        private void roundedButton_ColorCycle_Click(object sender, EventArgs e)
        {
            StartEffect(new LedWave());
        }

        private void roundedButton_Green_Click(object sender, EventArgs e)
        {
            StartEffect(new LedSunny());
        }

        private void roundedButton_Yellow_Click(object sender, EventArgs e)
        {
            StartEffect(new LedFall());
        }

        private void roundedButton_Winter_Click(object sender, EventArgs e)
        {
            StartEffect(new LedWinter());
        }
        private void roundedButton_Sound_Click(object sender, EventArgs e)
        {
            StartEffect(new LedSound());
        }

        private void ChangeColor(int pozice)
        {
            LedWave ledWave = new LedWave();
            int[] colors = ledWave.DoEffect(pozice);
            CurrentColor = Color.FromArgb(colors[0], colors[1], colors[2]);
            if (CanSend)
            {
                arduinoWriter.WriteColorToArduino(CurrentColor);
            }
           
            roundPanel_ColorInfo.BackColor = CurrentColor;
        }
      
        private void roundPanel_ColorSpectre_MouseDown(object sender, MouseEventArgs e)
        {
            ClickedOnColor = true;
            if (ClickedOnColor && e.X <= roundPanel_ColorSpectre.Width && e.X >= 0)
            {
                int pozice = (int)Math.Round(e.X * 4.65);
                Console.WriteLine(pozice);
                AnimationsOff();
                ChangeColor(pozice);
            }
        }

        private void roundPanel_ColorSpectre_MouseMove(object sender, MouseEventArgs e)
        {
            if (ClickedOnColor && e.X <= roundPanel_ColorSpectre.Width && e.X >= 0)
            {
                int pozice = (int)Math.Round(e.X * 4.65);
                Console.WriteLine(pozice);
                ChangeColor(pozice);
            }
        }
          
        private void roundPanel_ColorSpectre_MouseUp(object sender, MouseEventArgs e)
        {
            ClickedOnColor = false;
            settings.Color = CurrentColor;
            settings.LastSaved = "nic";
            settings.Save();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bool Check = Screen.GetWorkingArea(this).Contains(Cursor.Position);
            if (this.WindowState == FormWindowState.Minimized && Check)
            {
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
            }
        }


        private void LoadLastSaved()
        {
            Console.WriteLine(settings.LastSaved);
            {
                switch (settings.LastSaved)
                {
                    case "Wave":
                        StartEffect(new LedWave());
                        break;
                    case "Fall":
                        StartEffect(new LedFall());
                        break;
                    case "Sunny":
                        StartEffect(new LedSunny());
                        break;
                    case "Storm":
                        StartEffect(new LedStorm());
                        break;
                    case "Winter":
                        StartEffect(new LedWinter());
                        break;
                    case "Sound":
                        StartEffect(new LedSound());
                        break;
                    case "nic":
                        {
                            CurrentColor = settings.Color;
                            if (CanSend)
                            {
                                arduinoWriter.WriteColorToArduino(CurrentColor);
                            }
                           
                        }
                        break;
                    case "off":
                        {
                            if (CanSend)
                            {
                                arduinoWriter.WriteColorToArduino(Color.FromArgb(0, 0, 0));
                            }
                           
                        }
                        break;



                }
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           // SaveState();
        }
    }
}
