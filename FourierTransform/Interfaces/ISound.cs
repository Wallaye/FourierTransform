﻿namespace FourierTransform.Interfaces
{
    internal interface ISound
    {
        public string Name { get; set; }
        public double Frequency { get; set; }
        public double Amplitude { get; set; }
        public double Offset { get; set; }
        public double Generate(double tick);
        
    }
}
