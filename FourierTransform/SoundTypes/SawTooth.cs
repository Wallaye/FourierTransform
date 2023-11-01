using FourierTransform;
using FourierTransform.Interfaces;

namespace FourierTransform.SoundTypes;

public class SawTooth : ISound
{
    public string Name { get; set; } = "SawTooth";
    public double Frequency { get; set; }
    public double Amplitude { get; set; }
    public double Offset { get; set; } = 0;

    public SawTooth(double frequency, double amplitude, double offset)
    {
        Frequency = frequency;
        Amplitude = amplitude;
        Offset = offset;
    }

    public double Generate(double tick)
    {
        return -2 * Amplitude / Math.PI * Math.Atan(1 / Math.Tan(Math.PI * Frequency * tick + Offset));
    }
}