using System.Media;

/*
 * SoundPlayer class can't play more than one sound at a time
 * Having music and sfx is probably impossible unless an alternative to SoundPlayer is found
 * 
 */

namespace Magma.Sound
{
    class Music
    {

        SoundPlayer sp;

        public void PlayMenuMusic()
        {
            sp = new SoundPlayer(Magma.Properties.Resources.MenuMusic);
            sp.PlayLooping();
        }

        public void StopMusic()
        {
            sp.Stop();
            sp.Dispose();
        }

    }
}
