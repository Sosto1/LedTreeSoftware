using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedTreeSoftware
{
    class LedSunny : IEffectmodel
    {
        public int[] DoEffect(int Pozice) //120 - 390
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

        public int MaxValue { get; } = 390;

        public int MinValue { get; } = 120;

        public bool Running { get; set; } = false;

        public string Name { get; } = "Sunny";
    }
}
