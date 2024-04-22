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
        Stream soundFile2;
        SoundPlayer player2;

        public void buttonClick()
        {
            soundFile = Properties.Resources.newClick;
            player = new SoundPlayer(soundFile);
            player.Play();
            //musicBack();

        }
        public void warning()
        {
            soundFile = Properties.Resources.newWarn;
            player = new SoundPlayer(soundFile);
            player.Play();
            //musicBack();
        }
        public void musicBack()
        {
            soundFile2 = Properties.Resources.background;
            player2 = new SoundPlayer(soundFile2);
            player2.PlayLooping();
        }
        public void Applause()
        {
            soundFile = Properties.Resources.applause;
            player = new SoundPlayer(soundFile);
            player.Play();
        }
        public void CrowdGasp()
        {
            soundFile = Properties.Resources.gasp_x;
            player = new SoundPlayer(soundFile);
            player.Play();
        }
    }
}
