using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FourierTransform.Interfaces
{
    internal interface IFilter
    {
        public Complex[] Filter(Complex[] input, int SampleRate);
    }
}
