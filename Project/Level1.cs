/*
 * -- How To Create A Level --
 * A level is created from a multidimensional array of tiles
 * New tiles can be placed in this array using the AddTile operation
 * The first parameter must be a string naming the tile be added
 * The second parameter is the X location and the third is the Y location
 * Valid X values are between 1 and 30 and valid Y values are between 1 and 16
 * An example of an AddTile method call - AddTile("wall", 4, 3);
 * This will create a wall tile at grid location 4 across and 3 down
 * Every level already has a border of walls drawn at creation
 * Red and blue players must be added with the AddPlayers operation or the program will break
 * 
 */

namespace Magma.Game.Levels
{

    class Level1 : Level
    {

        // -- Constructor -- //

        public Level1()
        {
            AddPlayers(10, 16, 20, 16);
            AddTile("wall", 15, 8);
            AddTile("wall", 16, 8);
            AddTile("bluebutton", 14, 8);
            AddTile("redflame", 15, 7);
            AddTile("redflame", 15, 9);
            AddTile("blueflame", 16, 7);
            AddTile("blueflame", 16, 9);
            AddTile("redbutton", 17, 8);
        }
        
    }
}
