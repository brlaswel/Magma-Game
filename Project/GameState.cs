/*
 *  This class should keep track of important game variables?
 *  
 */

namespace Magma.Game
{
    class GameState
    {

        // -- Variables -- //

        private int lives;
        private int level;

        // -- Constructor -- //

        public GameState()
        {
            lives = 3;
            level = 1;
        }

        // -- Accessor Operations -- //

        public int GetLives { get { return lives; } }

        public int GetCurrentLevel { get { return level; } }

        // -- Standard Operations -- //

        public void IncLives() { lives++; }

        public void DecLives() { lives--; }

        public void IncLevel() { level++; }

        public void DecLevel() { level--; }
    }
}
