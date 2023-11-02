using FourierTransform.Interfaces;

namespace FourierTransform.SoundTypes;

public class Noise : ISound
{
    public string Name { get; set; } = "Noise";
    public double Frequency { get; set; }
    public double Amplitude { get; set; }
    public double Offset { get; set; } = 0;
    private Random Random { get; set; } = new Random();

    public Noise(double amplitude)
    {
        Amplitude = amplitude;
    }

    public double Generate(double tick)
    {
        return Amplitude * (2 * Random.NextDouble() - 1);
    }
}