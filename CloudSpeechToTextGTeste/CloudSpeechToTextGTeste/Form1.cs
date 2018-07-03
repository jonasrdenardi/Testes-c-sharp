using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Cloud.Speech.V1;
using NAudio.Wave;

namespace CloudSpeechToTextGTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int simplehate;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            using (Mp3FileReader mp3 = new Mp3FileReader(ofd.FileName))
            {
                var outFormat = new WaveFormat(mp3.WaveFormat.SampleRate, 1);
                using (var resampler = new MediaFoundationResampler(mp3, outFormat))
                {
                    simplehate = outFormat.SampleRate;
                    WaveFileWriter.CreateWaveFile("audioteste3.wav", resampler);
                }
            }
            var speech = SpeechClient.Create();
            var response = speech.Recognize(new RecognitionConfig()
            {
                Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                SampleRateHertz = simplehate,
                LanguageCode = "en",
            }, RecognitionAudio.FromFile("audioteste3.wav"));
            foreach (var result in response.Results)
            {
                foreach (var alternative in result.Alternatives)
                {
                    txtResultado.Text += alternative.Transcript;
                }
            }
        }
    }
}
