using System.Numerics;
using System.Xml.Linq;
using FourierTransform.Interfaces;
using FourierTransform.SoundTypes;
using FourierTransform.Transformations;

namespace FourierTransform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ISound sound = new Sinusoid(5, 1, 0);
            double[] signal = new double[100];
            for (int i = 0; i < 100; i++)
            {
                signal[i] = sound.Generate(i / 100.0);
            }
            IFourierTransformation transform = new DFT();
            Complex[] dft = transform.Transform(signal);
            double[] idft = transform.InverseTransform(dft);
            int a = 5;
        }
    }
}