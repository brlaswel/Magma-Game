/*
 * Only the blue player can move through these tiles?
 * 
 */

namespace Magma.Environment.Tiles
{
    class BlueFlame : Tile
    {

        // -- Constructor -- //

        public BlueFlame ()
        {
            SetFlag("redhazard");
            SetImage(Magma.Properties.Resources.BlueFlame);
        }
        
    }
}
