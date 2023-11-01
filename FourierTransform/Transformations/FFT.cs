using System.DirectoryServices;
using System.Numerics;
using FourierTransform.Interfaces;

namespace FourierTransform.Transformations;

public class FFT : IFourierTransformation
{
    public Complex[] Transform(double[] data)
    {
        return Iteration(CreateComplexArrayLengthPow2(data), false);
    }

    public double[] InverseTransform(Complex[] data)
    {
        return Iteration(data, true).Select(d => d.Magnitude / data.Length).ToArray();
    }

    private Complex[] CreateComplexArrayLengthPow2(double[] data)
    {
        int length = data.Length;
        int lengthNew = 1;
        while (lengthNew < length)
        {
            lengthNew *= 2;
        }
        Complex[] result = new Complex[lengthNew];
        if (lengthNew == length)
        {
            return data.Select(d => new Complex(d, 0.0)).ToArray();
        }
        for (int i = 0; i < lengthNew; i++)
        {
            if (i < data.Length)
            {
                result[i] = new Complex(data[i], 0.0);
            }
            else
            {
                result[i] = new Complex(0.0, 0.0);
            }
        }
        return result;
    }

    private Complex[] Iteration(Complex[] data, bool invert)
    {
        int n = data.Length;
        if (n == 1)
        {
            return data;
        }

        Complex[] result = new Complex[n];

        Complex[] even = new Complex[n / 2];
        Complex[] odd = new Complex[n / 2];

        for (int i = 0; i < n / 2; i++)
        {
            even[i] = data[i];
            odd[i] = data[i + 1];
        }

        Complex[] evenRes = Iteration(even, invert);
        Complex[] oddRes = Iteration(odd, invert);

        double ang = 2 * Math.PI / n * (invert ? -1 : 1);

        Complex w = new Complex(1.0, 0.0);
        Complex wn = new Complex(Math.Cos(ang), Math.Sin(ang));

        for (int i = 0; i < n / 2; ++i)
        {
            result[i] = evenRes[i] + w * oddRes[i];
            result[i + n / 2] = evenRes[i] - w * oddRes[i];
            if (invert)
            {
                result[i] /= 2;
                result[i + n / 2] /= 2;
            }
            w *= wn;
        }

        return result;
    }
}