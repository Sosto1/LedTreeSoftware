using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedTreeSoftware
{
    static class LedControls
    {
        public static int[] RGBSpektrum(int Pozice) // 0 - 1530
        {
            int[] Colors = new int[3];
            int red = 255;
            int green = 0;
            int blue = 0;

            if (Pozice <= 255)
            {
                green = Pozice;
            }
            else if (Pozice <= 510)
            {
                green = 255;
                red = 255 - (Pozice - 255); //255 - 0 
            }
            else if (Pozice <= 765)
            {
                green = 255;
                red = 0;
                blue = Pozice - 510;
            }
            else if (Pozice <= 1020)
            {
                blue = 255;
                red = 0;
                green = 255 - (Pozice - 765);
            }
            else if (Pozice <= 1275)
            {
                blue = 255;
                red = Pozice - 1020;
            }
            else
            {
                blue = 255 - (Pozice - 1275);
            }
            Colors[0] = red;
            Colors[1] = green;
            Colors[2] = blue;
            return Colors;
        }

        public static int[] LedSound(int SoundPeak) //5 - 70
        {
            SoundPeak = 1530 - SoundPeak;
            if (SoundPeak > 1530)
            {
                SoundPeak = 1530;
            }
            //double level = SoundPeak * 0.565359;
            
          //  level = level * 15.3; //1530 - 765
            Console.WriteLine(SoundPeak);
           return RGBSpektrum(SoundPeak);
        }
           
        public static int[] ShadesOFRed(int Pozice) //5 - 70
        {
            int R = 255;
            int G = 0;
            int B = 0;
            if (Pozice <= 35)
            {
                G = Pozice;
            }
            else
            {

                G = 35 - (Pozice - 35);

            }
            return new int[] { R, G, B };
        }

        public static int[] ShadesOFGreen(int Pozice) //120 - 390
        {
            int R = 255;
            int G = 0;
            int B = 0;
            if (Pozice <= 255)
            {
                G = Pozice;
            }
            else
            {
                G = 255 - (Pozice - 255);

            }

            return new int[] { R, G, B };
        }

        public static int[] ShadesOFBlue(int Pozice) //20 - 220
        {
            int R = 0;
            int G = 0;
            int B = 255;
            if (Pozice <= 120)
            {
                R = Pozice;
            }
            else
            {
                R = 120 - (Pozice - 120);
            }
            return new int[] { R, G, B };
        }

        public static int[] ShadesOFWhite(int Pozice) //100 - 310
        {
            int R = 0;
            int G = 100;
            int B = 255;
            if (Pozice <= 255)
            {
                R = Pozice;
            }
            else
            {
                R = 255 - (Pozice - 255);
            }
            return new int[] { R, G, B };
        }
    }
}
