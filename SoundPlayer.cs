using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using System;
using System.ComponentModel;

using System.Windows.Forms;
using System.Threading;

namespace SoundPlayer
{
    public partial class SoundPlayer : Form
    {
        private string filename = string.Empty; 
        public ISoundOut soundOut;
        public CSCore.Streams.Effects.Equalizer SoundEqualizer;
        private static SoundPlayer _instance;
        public SoundPlayer()
        {
            InitializeComponent();
            _instance = this;
        }

        public static SoundPlayer instance => _instance;

        //Shows Equalizer Form on click
        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            new Equalizer().Show();
        }

        //Opens file for mp3 selection
        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        //checks to see if the file is mp3, if not, it will ask the user to select mp3. Once an mp3 is selected
        //it will allow the user to have access to the play button and the track bar for volume
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.FileName.EndsWith(".mp3"))
                filename = openFileDialog1.FileName;
            else
            {
                MessageBox.Show("Please load an mp3 file");
                return;
            }

            btnPlay.Enabled = true;
            tbarVolume.Enabled = true;
        }

        //When play is clicked, it will disable the play button and load button until the stop button is selected
        //it will also begin the play music, code specifically for the audio library "CSCore" is found in here
        //to play music
        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = false;
            btnLoad.Enabled = false;
            btnStop.Enabled = true;
            using (var source = CodecFactory.Instance.GetCodec(filename))
            {
                var waveSource =
                    CodecFactory.Instance.GetCodec(filename)
                        .ToSampleSource()
                        .ToMono()
                        .AppendSource(CSCore.Streams.Effects.Equalizer.Create10BandEqualizer, out SoundEqualizer)
                        .ToWaveSource();
                soundOut = new WasapiOut() { Latency = 100 };
                soundOut.Initialize(waveSource);

                double length = waveSource.GetLength().TotalSeconds;//gathers total seconds
                int sLength; //declaring a new int
                sLength = Convert.ToInt32(length); //convert double to the new int so that pbar.Maximum 
                                                    //and timer1.Interval can handle
                soundOut.Play();
                pbarSong.Maximum = sLength; //sets Progress bar time to time of song roughly
                pbarSong.Value = 0; //reset value to 0
                timer1.Interval = sLength; //sets timer interval to same as progress bar
                timer1.Start();        //Starts counting, calls on timer1's if statement
                
            }
        }

        //When clicked, it will stop the audio that is currently playing
        //it will will disable the stop button but allow for the user to use the play button 
        //to replay the current track or will allow the user to select a new mp3 file by clicking load
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
            btnLoad.Enabled = true;
            btnStop.Enabled = false;
            soundOut.Stop();
            timer1.Stop();
            pbarSong.Value = 0;
        }


        //volume track bar the controls the sound level when the user toggles with it
        private void tbarVolume_ValueChanged(object sender, EventArgs e)
        {
            soundOut.Volume = Math.Min(1.0f, Math.Max(tbarVolume.Value / 10f, 0f));
        }

        //Affects the bar the displays the songs progress, will continue to move forward until song limit is reached
        private void timer1_Tick(object sender, EventArgs e)
        {


            if (pbarSong.Value < pbarSong.Maximum)
            {
                pbarSong.Value += 1; //adds to value and will continue until it hits pbarSong.Maximum
                Thread.Sleep(1000); //1000 millimetes = 1 second, allows for the progress bar to count 1 sec at a time
            }
            else //any other action will cut the music
            {

                soundOut.Stop();

            }
        }   

        //When the form is closed, the console will exit from the application
        private void SoundPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
