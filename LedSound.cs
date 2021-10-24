using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedTreeSoftware
{
    class LedSound : IEffectmodel
    {
        private int[] RGBSpektrum(int Pozice)// 0 - 1530
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
            
        public int[] DoEffect(int SoundPeak)
        {
            SoundPeak = 1530 - SoundPeak;
            if (SoundPeak > 1530)
            {
                SoundPeak = 1530;
            }

            Console.WriteLine(SoundPeak);
            return RGBSpektrum(SoundPeak);
        }
        public int MaxValue { get; } = 0;

        public int MinValue { get; } = 0;

        public bool Running { get; set; } = false;

        public string Name { get; } = "Sound";
    }
}
