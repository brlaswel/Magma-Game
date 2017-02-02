/*
 * Interacts with blue buttons and moves through blue flames?
 * 
 */

namespace Magma.Environment.Tiles
{
    class BluePlayer : Tile
    {

        // -- Constructor -- //

        public BluePlayer()
        {
            SetFlag("blueplayer");
            SetImage(Magma.Properties.Resources.BluePlayer);
        }

    }
}
