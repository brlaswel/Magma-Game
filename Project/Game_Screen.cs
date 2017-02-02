using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace Magma_Game
{

    public partial class Game_Screen : Form
    {
        public Game_Screen()
        {
            this.KeyPreview = true;
            InitializeComponent();
            KeyDown += new System.Windows.Forms.KeyEventHandler(Form1_KeyDown);
            Create_Game_Window();

        }
        private void Create_Game_Window()
        {

            //Test_Label.Show();
            Red_Magma_Control();
            KeyDown += new System.Windows.Forms.KeyEventHandler(Form1_KeyDown);

            //MessageBox.Show("You are not Crazy.");
        }
        private void Red_Magma_Control()
        {
            Red_Magma.CreateControl();

        }
        void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            int Rx = Red_Magma.Location.X;
            int Ry = Red_Magma.Location.Y;
            int Bx = Blue_Magma.Location.X;
            int By = Blue_Magma.Location.Y;
            Collision collision = new Collision();

            //If collision methods return false then move location of characters

            if (e.KeyCode == Keys.D)
            {
                if (!collision.rightCollideR(Rx)) { Rx += 5; }
                if (!collision.rightCollideB(Bx)) { Bx += 5; }
            }
            else if (e.KeyCode == Keys.A)
            {
                if (!collision.leftCollideR(Rx)) { Rx -= 5; }
                if (!collision.leftCollideB(Bx)) { Bx -= 5; }
            }
            else if (e.KeyCode == Keys.W)
            {
                if (!collision.upCollideR(Ry)) { Ry -= 5; }
                if (!collision.upCollideB(By)) { By -= 5; }
            }
            else if (e.KeyCode == Keys.S)
            {
                if (!collision.downCollideR(Ry)) { Ry += 5; }
                if (!collision.downCollideB(By)) { By += 5; }
            }

            Red_Magma.Location = new Point(Rx, Ry);
            Blue_Magma.Location = new Point(Bx, By);

            //if (IsTouching(Red_Magma, Col_Tester))
            //    {
            //    MessageBox.Show(@"Red Collision!");
            //    }


        }

        //private bool IsTouching(PictureBox p1, PictureBox p2)
        //{
        //    if (p1.Location.X + p1.Width < p2.Location.X)
        //        return false;
        //    if (p2.Location.X + p2.Width < p1.Location.X)
        //        return false;
        //    if (p1.Location.Y + p1.Height < p2.Location.Y)
        //        return false;
        //    if (p2.Location.Y + p2.Height < p1.Location.Y)
        //        return false;
        //    return true;
        //}

        private void Main_Menu_Click(object sender, EventArgs e)
        {
            Main_Menu_Function();
        }
        private void Main_Menu_Function()
        {
            this.Close();
            Start_Window Go_Back = new Start_Window();
            Application.Restart();
        }
        private void PanelFunction()
        {
            panel1.CreateControl();
        }
    }
}
