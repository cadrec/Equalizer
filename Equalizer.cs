using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCore.Streams.Effects;

namespace SoundPlayer
{
    //setting specific filters for mid high and low
    public partial class Equalizer : Form
    {
        private EqualizerFilter lowFilter = new EqualizerFilter();
        private EqualizerFilter midFilter = new EqualizerFilter();
        private EqualizerFilter highFilter = new EqualizerFilter();
        public Equalizer()
        {
            InitializeComponent();

        }

        //affects the highs when slider is changed
        private void tbarHighs_ValueChanged(object sender, EventArgs e)
        {
            var value = Math.Min(2.0f, Math.Max(tbarHighs.Value / 20f, 0f));
            highFilter.AverageGainDB = value;
           
        }

        //affects the mids when slider is changed
        private void tbarMids_ValueChanged(object sender, EventArgs e)
        {
            var value = Math.Min(2.0f, Math.Max(tbarMids.Value / 20f, 0f));
            midFilter.AverageGainDB = value;
        }

        //affects the lows when slider is changed
        private void tbarLows_ValueChanged(object sender, EventArgs e)
        {
            var value = Math.Min(2.0f, Math.Max(tbarLows.Value / 20f, 0f));
            lowFilter.AverageGainDB = value;
        }
    }
}
