using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedTreeSoftware
{
    class LedStorm : IEffectmodel
    {
        public int[] DoEffect(int Pozice) //20 - 220
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

        public int MaxValue { get; } = 220;

        public int MinValue { get; } = 20;

        public bool Running { get; set; } = false;

        public string Name { get; } = "Storm";
    }
}
