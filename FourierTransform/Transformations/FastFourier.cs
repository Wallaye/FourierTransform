﻿using System.Numerics;
using FourierTransform.Interfaces;

namespace FourierTransform.Transformations;

public class FastFourier : IFourierTransformation
{
    public Complex[] Transform(double[] data)
    {
        throw new NotImplementedException();
    }

    public double[] InverseTransform(Complex[] data)
    {
        throw new NotImplementedException();
    }
}