using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedTreeSoftware
{
    public interface IEffectmodel
    {
        int[] DoEffect(int Pozice);

        int MaxValue { get; }

        int MinValue { get; }

        bool Running { get; set; }

        string Name { get; }
    }
}
