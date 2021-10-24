using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedTreeSoftware
{
    class LedWinter : IEffectmodel
    {
        public int[] DoEffect(int Pozice) //100 - 410
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
        public int MaxValue { get; } = 410;

        public int MinValue { get; } = 100;

        public bool Running { get; set; } = false;

        public string Name { get; } = "Winter";
    }
}
