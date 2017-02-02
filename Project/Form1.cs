using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml;

namespace Magma_Game
{
    public partial class Start_Window : Form
    {
        public Start_Window()
        {
            InitializeComponent();

        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            Start_Button_Function();
            

        }
        private void Start_Button_Function()
        {
            this.Close();
            Game_Screen Game_Play_Window = new Game_Screen();
        }

        private void Credits_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Created By: Brandon Laswell, Tony Freitas, and Ryan Goodman");
            this.Show();
        }

        private void Controls_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HowToPlay();
            this.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HowToPlay()
        {
            #region HowToPlayForm
            Form test = new Form();
            test.Show();

            

            #endregion

        }
    }
}
