using System;
using System.Windows.Forms;

namespace SoundPlayer
{
    static class Program
    {
        //main method 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); //set up
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());   //creates a new instance of Splash which runs the splash screen
                                             //SoundPlayer is called from within Splash
                                             //Equalizer is called upon from SoundPlayer
        }
    }
}
