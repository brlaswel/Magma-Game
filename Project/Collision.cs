using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magma_Game
{
    class Collision
    {
        //Currently only works for staying within screen bounds
        //Blue and red characters should each have their own collision methods?

        public bool rightCollideR(int Rx)
        {
            if (Rx >= 1293) { return true; }
            else { return false; }
        }

        public bool rightCollideB(int Bx)
        {
            if (Bx >= 1293) { return true; }
            else { return false; }
        }

        public bool leftCollideR(int Rx)
        {
            if (Rx <= 23) { return true; }
            else { return false; }
        }

        public bool leftCollideB(int Bx)
        {
            if (Bx <= 23) { return true; }
            else { return false; }
        }

        public bool upCollideR(int Ry)
        {
            if (Ry <= 23) { return true; }
            else { return false; }
        }

        public bool upCollideB(int By)
        {
            if (By <= 23) { return true; }
            else { return false; }
        }

        public bool downCollideR(int Ry)
        {
            if (Ry >= 683) { return true; }
            else { return false; }
        }

        public bool downCollideB(int By)
        {
            if (By >= 683) { return true; }
            else { return false; }
        }

    }
}
