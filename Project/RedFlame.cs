/*
 * Only the red player can move through these tiles?
 * 
 */

namespace Magma.Environment.Tiles
{
    class RedFlame : Tile
    {

        // -- Constructor -- //

        public RedFlame()
        {
            SetFlag("bluehazard");
            SetImage(Magma.Properties.Resources.RedFlame);
        }

    }
}
