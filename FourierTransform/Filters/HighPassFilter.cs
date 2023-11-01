using FourierTransform.Interfaces;
using System.Numerics;


namespace FourierTransform.Filters
{
    internal class HighPassFilter : IFilter
    {
        public double CutOffFrequency { get; set; }

        public HighPassFilter(double cutOffFrequency)
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
