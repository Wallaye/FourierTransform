using FourierTransform;
using FourierTransform.Interfaces;

namespace FourierTransform.SoundTypes;

public class Sinusoid : ISound
{
    public string Name { get; set; } = "Sinusoide";
    public double Frequency { get; set; }
    public double Amplitude { get; set; }
    public double Offset { get; set; } = 0;

    public Sinusoid(double frequency, double amplitude, double offset)
    {
        Frequency = frequency;
        Amplitude = amplitude;
        Offset = offset;
    }

    public double Generate(double tick)
    {
        return Amplitude * Math.Sin(2.0 * Math.PI * Frequency * tick + Offset);
    }
}