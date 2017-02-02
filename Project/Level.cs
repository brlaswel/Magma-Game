using Magma.Environment;
using Magma.Environment.Tiles;
using System;
using System.Drawing;

/*
 * This is the level master class that all level classes should inherit
 * It contains all operations for building a level and also sends tiles to the TileSorter class
 * To create levels check out the classes in the levels folder
 * 
 */

namespace Magma.Game
{
    class Level
    {

        // -- Variables -- //

        private int width;
        private int height;
        private Tile tile;

        private RedPlayer redPlayer;
        private BluePlayer bluePlayer;

        private Tile[,] grid;
        private TileSorter sorter;

        // --  Constructor -- //

        public Level()
        {
            width = 1280;
            height = 720;
            tile = new Tile();

            redPlayer = new RedPlayer();
            bluePlayer = new BluePlayer();

            grid = new Tile[width / tile.GetSize, height / tile.GetSize];
            sorter = new TileSorter(grid.Length);

            AddBorder();
        }

        // -- Accessor Operations -- //

        public int GetHeight { get { return height; } }

        public int GetWidth { get { return width; } }

        public Tile GetRedPlayer { get { return redPlayer; } }

        public Tile GetBluePlayer { get { return bluePlayer; } }

        public Tile[,] GetGrid { get { return grid; } }

        public TileSorter GetSorter { get { return sorter; } }

        // -- Standard Operations -- //

        public void AddPlayers(int rx, int ry, int bx, int by)
        {
            redPlayer.SetLocation(rx * tile.GetSize, ry * tile.GetSize);
            sorter.SortTile(redPlayer);
            bluePlayer.SetLocation(bx * tile.GetSize, by * tile.GetSize);
            sorter.SortTile(bluePlayer);
        }

        public void AddTile(String s, int x, int y)
        {
            TileBuilder tb = new TileBuilder();

            grid[x, y] = tb.CreateTile(s);
            grid[x, y].SetLocation(x * tile.GetSize, y * tile.GetSize);
            sorter.SortTile(grid[x, y]);
        }

        public void AddBorder()
        {
            for(int x = 0; x < grid.GetLength(0); x++)
            {
                for(int y = 0; y < grid.GetLength(1); y++)
                {
                    if(x == 0 || y == 0 || x == grid.GetLength(0) - 1 || y == grid.GetLength(1) - 1)
                    {
                        AddTile("wall", x, y);
                    }
                }
            }
        }

        public void Clear()
        {
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    grid[x, y] = null;
                }
            }

            sorter.Clear();
        }

        public void DrawLevel(Graphics paint)
        {
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    if (grid[x, y] != null) { grid[x, y].DrawTile(paint); }
                }
            }

            redPlayer.DrawTile(paint);
            bluePlayer.DrawTile(paint);
        }

    }
}
