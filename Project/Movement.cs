using Magma.Environment;
using Magma.Game;
using System.Drawing;

/*
 * Handles movement of the player characters and calls appropriate collision operations
 * A temp rectangle is created to test for collision before the player is moved
 * 
 */

namespace Magma.Control
{
    class Movement
    {

        Interaction collision = new Interaction();

        // -- Standard Operations -- //

        public void Down(Tile t, Level lvl)
        {
            Rectangle rTemp = t.GetRec;
            rTemp.Y += t.GetSize / 4;

            if (!collision.IsObstacle(rTemp, lvl) && !collision.IsPlayer(rTemp, t.GetFlag, lvl))
            {
                t.SetLocation(rTemp.X, rTemp.Y);
            }
        }

        public void Up(Tile t, Level lvl)
        {
            Rectangle rTemp = t.GetRec;
            rTemp.Y -= t.GetSize / 4;

            if (!collision.IsObstacle(rTemp, lvl) && !collision.IsPlayer(rTemp, t.GetFlag, lvl))
            {
                t.SetLocation(rTemp.X, rTemp.Y);
            }
        }

        public void Right(Tile t, Level lvl)
        {
            Rectangle rTemp = t.GetRec;
            rTemp.X += t.GetSize / 4;

            if (!collision.IsObstacle(rTemp, lvl) && !collision.IsPlayer(rTemp, t.GetFlag, lvl))
            {
                t.SetLocation(rTemp.X, rTemp.Y);
            }
        }

        public void Left(Tile t, Level lvl)
        {
            Rectangle rTemp = t.GetRec;
            rTemp.X -= t.GetSize / 4;

            if (!collision.IsObstacle(rTemp, lvl) && !collision.IsPlayer(rTemp, t.GetFlag, lvl))
            {
                t.SetLocation(rTemp.X, rTemp.Y);
            }
        }

    }
}
