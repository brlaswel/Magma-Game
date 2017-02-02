using Magma.Environment;
using Magma.Environment.Tiles;
using System;

/*
 * -- Important --
 * If new tile classes are added to the project a new case for that tile must be added here
 * 
 * This class is used to select tiles for the AddTile command in the Level class
 * 
 */

namespace Magma.Game
{
    class TileBuilder
    {

        // -- Standard Operations -- //

        public Tile CreateTile(String tileName)
        {
            switch (tileName.ToLower())
            {
                case "bluebutton":
                    BlueButton blueButton = new BlueButton();
                    return blueButton;
                case "blueflame":
                    BlueFlame blueFlame = new BlueFlame();
                    return blueFlame;
                case "blueplayer":
                    BluePlayer bluePlayer = new BluePlayer();
                    return bluePlayer;
                case "redbutton":
                    RedButton redButton = new RedButton();
                    return redButton;
                case "redflame":
                    RedFlame redFlame = new RedFlame();
                    return redFlame;
                case "redplayer":
                    RedPlayer redPlayer = new RedPlayer();
                    return redPlayer;
                case "wall":
                    Wall wall = new Wall();
                    return wall;
                default:
                    return null;
            }
        }

    }
}
