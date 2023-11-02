using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Security;
using System.Xml.Linq;
using FourierTransform.Filters;
using FourierTransform.Interfaces;
using FourierTransform.SoundTypes;
using FourierTransform.Transformations;
using ScottPlot;

namespace FourierTransform
{
    public partial class Form1 : Form
    {
        private ObservableCollection<ISound> _signals = new();
        private const int _sampleRate = 16384;
        private const int _signalLen = 1;
        private const int _numSamples = _sampleRate * _signalLen;

        public Form1()
        {
            InitializeComponent();
            InitializePlot(ref frmValues, "Сигналы", "Значения", "");
            InitializePlot(ref frmAmplitude, "Амплитудный спектр", "Значения", "Частоты");
            InitializePlot(ref frmValues, "Фазовый спектр", "Значения", "Частоты");
            cmbSignalTypeChoice.SelectedIndex = 0;
        }

        private void btnAddSignalToList_Click(object sender, EventArgs e)
        {
            double Amplitude = (double)numAmplitude.Value;
            double Frequency = (double)numFrequency.Value;
            double Phase = (double)numPhase.Value;
            double DutyCycle = (double)numDutyCycle.Value;
            ISound sound;
            ListViewItem item;
            switch (cmbSignalTypeChoice.SelectedIndex)
            {
                case 0:
                    sound = new Sinusoid(Frequency, Amplitude, Phase);
                    item = new ListViewItem(new string[] {
                        sound.Name,
                        Amplitude.ToString(),
                        Frequency.ToString(),
                        Phase.ToString(),
                        "-"
                    });
                    break;
                case 1:
                    sound = new Impulse(Frequency, Amplitude, Phase, DutyCycle);
                    item = new ListViewItem(new string[] {
                        sound.Name,
                        Amplitude.ToString(),
                        Frequency.ToString(),
                        Phase.ToString(),
                        DutyCycle.ToString()
                    });
                    break;
                case 2:
                    sound = new Triangle(Frequency, Amplitude, Phase);
                    item = new ListViewItem(new string[] {
                        sound.Name,
                        Amplitude.ToString(),
                        Frequency.ToString(),
                        Phase.ToString(),
                        "-"
                    });
                    break;
                case 3:
                    sound = new SawTooth(Frequency, Amplitude, Phase);
                    item = new ListViewItem(new string[] {
                        sound.Name,
                        Amplitude.ToString(),
                        Frequency.ToString(),
                        Phase.ToString(),
                        "-"
                    });
                    break;
                case 4:
                    sound = new Noise(Amplitude);
                    item = new ListViewItem(new string[] {
                        sound.Name,
                        Amplitude.ToString(),
                        "-",
                        "-",
                        "-"
                    });
                    break;
                default:
                    sound = new Sinusoid(Frequency, Amplitude, Phase);
                    item = new ListViewItem(new string[] {
                        sound.Name,
                        Amplitude.ToString(),
                        Frequency.ToString(),
                        Phase.ToString(),
                        "-"
                    });
                    break;
            }
            _signals.Add(sound);
            listView1.Items.Add(item);
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            _signals.Clear();
            listView1.Items.Clear();
        }

        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Select item for deletion");
                return;
            }
            int index = listView1.SelectedIndices[0];

            listView1.Items.RemoveAt(index);
            _signals.RemoveAt(index);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblTime.Text = "";
            frmAmplitude.Plot.Clear();
            frmValues.Plot.Clear();
            frmPhase.Plot.Clear();
            Stopwatch watch = new();
            watch.Start();
            double[] Data = GeneratePolySignal();
            IFourierTransformation transformer = chkFFT.Checked ? new FFT() : new DFT();
            Complex[] transformed = transformer.Transform(Data);
            IFilter? filter = ChooseFilter();
            if (filter != null)
            {
                filter.Filter(transformed, _sampleRate);
            }

            double[] ApmplitudeSpectre = transformer.GetAmplitudeSpectrum(transformed);
            double[] PhaseSpectre = transformer.GetPhaseSpectrum(transformed);

            double[] restored = transformer.InverseTransform(transformed);
            watch.Stop();
            lblTime.Text = watch.ElapsedMilliseconds.ToString();

            frmValues.Plot.AddSignal(Data, color: Color.Blue);
            frmValues.Plot.AddSignal(restored, color: Color.Red);
            frmValues.Refresh();

            frmAmplitude.Plot.AddSignal(ApmplitudeSpectre);
            frmAmplitude.Refresh();

            frmPhase.Plot.AddSignal(PhaseSpectre);
            frmPhase.Refresh();
        }

        private IFilter? ChooseFilter()
        {
            IFilter? filter = null;
            if (chkHighFreq.Checked && chkLowFreq.Checked)
            {
                filter = new BandPassFilter((double)numLowFreq.Value, (double)numHighFreq.Value);
            }
            else if (chkLowFreq.Checked)
            {
                filter = new LowPassFilter((double)numLowFreq.Value);
            }
            else if (chkHighFreq.Checked)
            {
                filter = new HighPassFilter((double)numHighFreq.Value);
            }
            return filter;
        }

        private void InitializePlot(ref FormsPlot plot, string title, string YLabel, string XLabel)
        {
            if (String.IsNullOrEmpty(title))
            {
                plot.Plot.Title(title);
            }
            if (String.IsNullOrEmpty(YLabel))
            {
                plot.Plot.YLabel(YLabel);
            }
            if (String.IsNullOrEmpty(XLabel))
            {
                plot.Plot.XLabel(XLabel);
            }
            plot.Refresh();
        }

        private double[] GeneratePolySignal()
        {
            double[] data = new double[_numSamples];
            foreach (var sound in _signals)
            {
                double[] temp = GenerateSignal(sound);
                for (int i = 0; i < _numSamples; i++)
                {
                    data[i] += temp[i];
                }
            }
            return data;
        }

        private double[] GenerateSignal(ISound sound)
        {
            double[] result = new double[_numSamples];
            for (int i = 0; i < _numSamples; i++)
            {
                double tick = (double)i / _sampleRate;
                result[i] = sound.Generate(tick);
            }
            return result;
        }
    }
}