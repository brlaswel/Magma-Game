/*
 * Interacts with red buttons and moves through red flames?
 * 
 */

namespace Magma.Environment.Tiles
{
    class RedPlayer : Tile
    {

        // -- Constructor -- //

        public RedPlayer()
        {
            SetFlag("redplayer");
            SetImage(Magma.Properties.Resources.RedPlayer);
        }

    }
}

