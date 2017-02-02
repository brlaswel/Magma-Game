using Magma.Game;
using System;
using System.Drawing;

/*
 * This class handles all player tile interactions in the game, including collision detection
 * 
 */

namespace Magma.Control
{
    class Interaction
    {

        // -- Standard Operations -- //

        public Boolean IsObstacle(Rectangle r, Level lvl)
        {

            int i = 0;
            while (i < lvl.GetSorter.GetObstacles.Length && lvl.GetSorter.GetObstacles[i] != null)
            {
                if (r.IntersectsWith(lvl.GetSorter.GetObstacles[i].GetRec)) { return true; }
                i++;
            }

            return false;
        }

        public Boolean IsHazard(Rectangle r, String s, Level lvl)
        {
            int i = 0;
            while (i < lvl.GetSorter.GetHazards.Length && lvl.GetSorter.GetHazards[i] != null)
            {
                if (r.IntersectsWith(lvl.GetSorter.GetHazards[i].GetRec))
                {
                    if (s.ToLower() == "redplayer" && lvl.GetSorter.GetHazards[i].GetFlag.ToLower() == "redhazard")
                    { return true; }
                    if (s.ToLower() == "blueplayer" && lvl.GetSorter.GetHazards[i].GetFlag.ToLower() == "bluehazard")
                    { return true; }
                }
                i++;
            }

            return false;
        }

        public Boolean IsToggle(Rectangle r, String s, Level lvl)
        {
            return false;
        }

        public Boolean IsPlayer(Rectangle r, String s, Level lvl)
        {
            int i = 0;
            while (i < lvl.GetSorter.GetPlayers.Length && lvl.GetSorter.GetPlayers[i] != null)
            {
                if (r.IntersectsWith(lvl.GetSorter.GetPlayers[i].GetRec))
                {
                    if (s.ToLower() == "redplayer" && lvl.GetSorter.GetPlayers[i].GetFlag.ToLower() == "blueplayer")
                    { return true; }
                    if (s.ToLower() == "blueplayer" && lvl.GetSorter.GetPlayers[i].GetFlag.ToLower() == "redplayer")
                    { return true; }
                }
                i++;
            }

            return false;
        }
    }
}
