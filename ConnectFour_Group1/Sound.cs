using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Testing
{
    public partial class Sound
    {
        Stream soundFile;
        SoundPlayer player;
    }

    private void btn_applause_Click()
    {
        soundFile = Properties.Resources.click.wav; 
        player = new SoundPlayer(soundFile); 
        playSound();
    }
    private void btn_applause_warn()
    {
        soundFileWarn = Properties.Resources.warn.wav;
        player = new SoundPlayer(soundFile);
        playSound();
    }
    private void playSound()
    {
        if (checkBox_continuous.Checked)
        {
            player.PlayLooping();
        }
        else
        {
            player.Play();
        }
    }
}
