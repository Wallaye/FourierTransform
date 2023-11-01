using FourierTransform;
using FourierTransform.Interfaces;

namespace FourierTransform.SoundTypes;

public class Impulse : ISound
{
    public string Name { get; set; } = "Impulse";
    public double Frequency { get; set; }
    public double Amplitude { get; set; }
    public double Offset { get; set; } = 0;
    public double DutyCycle { get; set; }

    public Impulse(double frequency, double amplitude, double offset, double dutyCycle)
    {
        Frequency = frequency;
        Amplitude = amplitude;
        Offset = offset;
        DutyCycle = dutyCycle;
    }

    public double Generate(double tick)
    {
        double T = 1 / Frequency;
        return (tick % T) / T < 1 / DutyCycle ? Amplitude : -Amplitude;
    }
}