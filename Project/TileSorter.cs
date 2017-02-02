/*
 * -- Important --
 * If new tile flags are added to the project then they must also be added to the Sort Tile operation
 * 
 * This class stores all tiles in a series of arrays based on the tile's assigned flag
 * Obstacles block movement, hazards block opposite color movement?, toggles turn off hazards?
 * 
 */

namespace Magma.Environment
{
    class TileSorter
    {

        // -- Variables -- //

        private Tile[] obstacles;
        private Tile[] hazards;
        private Tile[] toggles;
        private Tile[] players;

        // -- Constructor -- //

        public TileSorter(int i)
        {
            obstacles = new Tile[i];
            hazards = new Tile[i];
            toggles = new Tile[i];
            players = new Tile[2];
        }

        // -- Accessor Operations -- //

        public Tile[] GetObstacles { get { return obstacles; } }

        public Tile[] GetHazards { get { return hazards; } }

        public Tile[] GetToggles { get { return toggles; } }

        public Tile[] GetPlayers { get { return players; } }

        // -- Standard Operations -- //

        public void SortTile(Tile t)
        {
            if (t.GetFlag.ToLower() == "obstacle")
            {
                int i = 0;
                while (i < obstacles.Length && obstacles[i] != null) { i++; }
                obstacles[i] = t;
            }

            if (t.GetFlag.ToLower() == "redhazard" || t.GetFlag.ToLower() == "bluehazard")
            {
                int i = 0;
                while (i < hazards.Length && hazards[i] != null) { i++; }
                hazards[i] = t;
            }

            if (t.GetFlag.ToLower() == "redtoggle" || t.GetFlag.ToLower() == "bluetoggle")
            {
                int i = 0;
                while (i < toggles.Length && toggles[i] != null) { i++; }
                toggles[i] = t;
            }

            if (t.GetFlag.ToLower() == "redplayer" || t.GetFlag.ToLower() == "blueplayer")
            {
                int i = 0;
                while (i < players.Length && players[i] != null) { i++; }
                players[i] = t;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < obstacles.Length; i++) { obstacles[i] = null; }

            for (int i = 0; i < hazards.Length; i++) { hazards[i] = null; }

            for (int i = 0; i < toggles.Length; i++) { toggles[i] = null; }

            for(int i = 0; i < toggles.Length; i++) { players[i] = null; }
        }

    }
}
