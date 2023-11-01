using FourierTransform.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FourierTransform.Filters
{
    internal class BandPassFilter : IFilter
    {
        public double LowCutOffFrequency { get; set; }
        public double HighCutOffFrequency { get; set; }

        public BandPassFilter(double lowCutOffFrequency, double highCutOffFrequency)
        {
            LowCutOffFrequency = lowCutOffFrequency;
            HighCutOffFrequency = highCutOffFrequency;
        }

        public Complex[] Filter(Complex[] input, int SampleRate)
        {
            for (int i = 0; i < SampleRate; i++)
            {
                if (i < LowCutOffFrequency || i > HighCutOffFrequency)
                {
                    input[i] = Complex.Zero;
                }
            }
            return input;
        }
    }
}
