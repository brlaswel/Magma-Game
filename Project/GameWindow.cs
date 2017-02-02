/*
 * If the timer is disabled then movement is disabled
 * Except for the movement commands, most of this stuff right now is just for testing
 * 
 */

using Magma.Control;
using Magma.Game;
using Magma.Game.Levels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Magma
{
    public partial class GameWindow : Form
    {

        // -- Variables -- //

        int time = 0;

        Level1 lvl;
        GameState game;
        Movement move;

        // -- Constructor -- //

        public GameWindow()
        {
            lvl = new Level1();
            game = new GameState();
            move = new Movement();

            InitializeComponent();

            MessageDisplay.Text = "PRESS ENTER TO START (MOVE WITH ARROW KEYS)";
        }

        // -- Standard Operations -- //

        private void Main_Window_Paint(object sender, PaintEventArgs e)
        {
            Graphics paint = e.Graphics;
            lvl.DrawLevel(paint);
        }

        private void Main_Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down && Timer.Enabled)
            {
                // These 'if' statements make sure that there are no collisions when moving adjacent players
                if (lvl.GetRedPlayer.GetY > lvl.GetBluePlayer.GetY)
                {
                    move.Down(lvl.GetRedPlayer, lvl);
                    move.Down(lvl.GetBluePlayer, lvl);
                }

                else
                {
                    move.Down(lvl.GetBluePlayer, lvl);
                    move.Down(lvl.GetRedPlayer, lvl);
                }
            }

            if (e.KeyData == Keys.Up && Timer.Enabled)
            {
                if (lvl.GetRedPlayer.GetY < lvl.GetBluePlayer.GetY)
                {
                    move.Up(lvl.GetRedPlayer, lvl);
                    move.Up(lvl.GetBluePlayer, lvl);
                }
                else
                {
                    move.Up(lvl.GetBluePlayer, lvl);
                    move.Up(lvl.GetRedPlayer, lvl);
                }
            }

            if (e.KeyData == Keys.Right && Timer.Enabled)
            {
                if (lvl.GetRedPlayer.GetX > lvl.GetBluePlayer.GetX)
                {
                    move.Right(lvl.GetRedPlayer, lvl);
                    move.Right(lvl.GetBluePlayer, lvl);
                }
                else
                {
                    move.Right(lvl.GetBluePlayer, lvl);
                    move.Right(lvl.GetRedPlayer, lvl);
                }
            }

            if (e.KeyData == Keys.Left && Timer.Enabled)
            {
                if (lvl.GetRedPlayer.GetX < lvl.GetBluePlayer.GetX)
                {
                    move.Left(lvl.GetRedPlayer, lvl);
                    move.Left(lvl.GetBluePlayer, lvl);
                }
                else
                {
                    move.Left(lvl.GetBluePlayer, lvl);
                    move.Left(lvl.GetRedPlayer, lvl);
                }
            }

            if (e.KeyData == Keys.Enter)
            {
                if (!Timer.Enabled)
                {
                    Timer.Enabled = true;
                }
                else
                {
                    Timer.Enabled = false;
                    MessageDisplay.Text = "PAUSED";
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time += 20;
            TimeDisplay.Text = "TIME: " + Convert.ToString(time / 1000);
            MessageDisplay.Text = "LEVEL " + game.GetCurrentLevel;
            LivesDisplay.Text = "LIVES: " + game.GetLives;

            this.Invalidate();
        }
    
    }
}
