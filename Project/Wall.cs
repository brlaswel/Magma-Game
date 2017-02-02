/*
 * No players can move through this tile
 * 
 */

namespace Magma.Environment.Tiles
{
    class Wall : Tile
    {

        // -- Constructor -- //

        public Wall()
        {
            SetFlag("obstacle");
            SetImage(Magma.Properties.Resources.Wall);
        }

    }
}
