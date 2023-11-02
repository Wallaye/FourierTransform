using System.Numerics;

namespace FourierTransform.Interfaces;

public interface IFourierTransformation
{
    public Complex[] Transform(double[] data);
    public double[] InverseTransform(Complex[] data);
    
    public double[] GetAmplitudeSpectrum(Complex[] data)
    {
        double[] result = new double[data.Length];
        for (int i = 0; i < data.Length; i++)
        {
            result[i] = data[i].Magnitude * 2 / data.Length;
        }
        return result;
    }

    public double[] GetPhaseSpectrum(Complex[] data)
    {
        double[] result = new double[data.Length];
        for (int i = 0; i < data.Length; i++)
        {
            result[i] = Math.Atan2(data[i].Imaginary, data[i].Real);
        }
        return result;
    }
}