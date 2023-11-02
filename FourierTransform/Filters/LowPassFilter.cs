using FourierTransform.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FourierTransform.Filters
{
    internal class LowPassFilter : IFilter
    {
        public double CutOffFrequency { get; set; }

        public LowPassFilter(double cutOffFrequency)
        {
            CutOffFrequency = cutOffFrequency;
        }

        public Complex[] Filter(Complex[] input, int SampleRate)
        {
            for (int i = 0; i < SampleRate; i++)
            {
                if (i > CutOffFrequency)
                {
                    input[i] = Complex.Zero;
                }
            }
            return input;
        }
    }
}
