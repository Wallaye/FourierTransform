using System.Numerics;
using FourierTransform.Interfaces;

namespace FourierTransform.Transformations;

public class DFT : IFourierTransformation
{
    public Complex[] Transform(double[] data)
    {
        Complex[] result = new Complex[data.Length];
        for (int k = 0; k < data.Length; k++)
        {
            result[k] = Complex.Zero;
            for (int n = 0; n < data.Length; n++)
            {
                double power = -2 * Math.PI * k * n / data.Length;
                var exp = new Complex(Math.Cos(power), Math.Sin(power));
                result[k] += data[n] * exp;
            }
        }
        return result;
    }

    public double[] InverseTransform(Complex[] data)
    {
        double[] result = new double[data.Length];
        for (int n = 0; n < data.Length; n++)
        {
            Complex sum = Complex.Zero;
            for (int k = 0; k < data.Length; k++)
            {
                double power = 2 * Math.PI * k * n / data.Length;
                var exp = new Complex(Math.Cos(power), Math.Sin(power));
                sum += data[k] * exp;
            }
            result[n] = sum.Magnitude / data.Length;
        }
        return result;
    }
}