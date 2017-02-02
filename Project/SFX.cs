using System.Media;

/*
 * SoundPlayer class crashes program
 * Probably has something to do with SoundPlayer objects not being diposed of properly by garbage collection
 * Need an alternative for playing sounds if possible
 * 
 */

namespace Magma.Sound

{
    class SFX
    {
        SoundPlayer sp = new SoundPlayer();

        // -- Accessor Operations -- //

        public void PlayDamageSound()
        {
           sp = new SoundPlayer(Magma.Properties.Resources.DamageSFX);
           sp.Play();
        }

        public void PlayToggleSound()
        {
            sp = new SoundPlayer(Magma.Properties.Resources.ToggleSFX);
            sp.Play();
        }

        public void PlayInputSound()
        {
            sp = new SoundPlayer(Magma.Properties.Resources.InputSFX);
            sp.Play();
        }

        public void PlayGameOverSound()
        {
            sp = new SoundPlayer(Magma.Properties.Resources.GameOverSFX);
            sp.Play();
        }

        public void StopSFX()
        {
            sp.Stop();
            sp.Dispose();
        }
    }
}
