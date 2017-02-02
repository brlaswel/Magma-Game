using System;
using System.Drawing;

/*
 * This is the tile master class that all tile classes should inherit
 * Each tile is a 40 x 40 rectangle and an image is drawn inside of that shape
 * Each tile also contains a 'flag' string variable that is used for handling tile interactions
 * To change the image of a tile, drop an image file in the Solution Explorer Magma/Properties/Resources.resx
 * Then go the tile's specific class and change the SetImage operation parameter to the new file
 * Images should be 40 x 40 and preferably PNG since JPG can't do transparency
 * 
 */

namespace Magma.Environment
{
    class Tile
    {
        // -- Variables -- //

        private Image img;
        private Rectangle rec;

        private int x, y, size;

        private String flag;

        // -- Constructor -- //

        public Tile()
        {
            img = null;
            rec = new Rectangle(x, y, size, size);

            x = 0;
            y = 0;
            size = 40;

            flag = "";
        }

        // -- Accessor Operations -- //

        public Image GetImg { get { return img; } }

        public Rectangle GetRec { get { return rec; } }

        public int GetX { get { return x; } }

        public int GetY { get { return y; } }

        public int GetSize { get { return size; } }

        public String GetFlag { get { return flag; } }

        // -- Standard Operations -- //

        public void SetImage(Image m)
        {
            img = m;
        }

        public void SetLocation(int i, int j)
        {
            x = i;
            y = j;
            rec = new Rectangle(x, y, size, size);
        }

        public void SetFlag(String s)
        {
            flag = s;
        }

        public void DrawTile(Graphics paint)
        {
            paint.DrawImage(new Bitmap(img), rec);
        }

    }
}
