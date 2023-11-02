using System.Collections.ObjectModel;
using System.Numerics;
using System.Xml.Linq;
using FourierTransform.Interfaces;
using FourierTransform.SoundTypes;
using FourierTransform.Transformations;

namespace FourierTransform
{
    public partial class Form1 : Form
    {
        private ObservableCollection<ISound> _signals = new();
        public Form1()
        {
            InitializeComponent();
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
    }
}