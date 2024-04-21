using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;


namespace Connect4Testing
{
    public class Sound
    {
        Stream soundFile;
        SoundPlayer player;
        SoundPlayer player2;

        private void buttonClick()
        {
            //soundFile = Properties.Resources.

            //player = new SoundPlayer(soundFile);

            //player.Play();
            
        }
        private void warning()
        {
            //soundFile = Properties.Resources.warningNoise;

            //player = new SoundPlayer(soundFile);

           // player.Play();
        }
        private void background()
        {
            //soundFile = Properties.Resources.background;

            //player2 = new SoundPlayer(soundFile);

            //player2.PlayLooping();
        }
    }
}
