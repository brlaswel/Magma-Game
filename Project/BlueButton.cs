/*
 * Can only be toggled by the blue player and extinguishes blue flames?
 * 
 */

namespace Magma.Environment.Tiles
{
    class BlueButton : Tile
    {

        // -- Constructor -- //

        public BlueButton()
        {
            SetFlag("bluetoggle");
            SetImage(Magma.Properties.Resources.BlueButton);
        }

    }
}
