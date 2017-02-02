/*
 * Can only be toggled by the red player and extinguishes red flames?
 * 
 */

namespace Magma.Environment.Tiles
{
    class RedButton : Tile
    {

        // -- Constructor -- //

        public RedButton()
        {
            SetFlag("redtoggle");
            SetImage(Magma.Properties.Resources.RedButton);
        }

    }
}
