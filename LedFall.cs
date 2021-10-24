using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedTreeSoftware
{
    class LedFall : IEffectmodel
    {
        public int[] DoEffect(int Pozice) //5 - 70
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

        public int MaxValue { get; } = 70;

        public int MinValue { get; } = 5;

        public bool Running { get; set; } = false;

        public string Name { get; } = "Fall";
    }
}
