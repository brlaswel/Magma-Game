namespace Magma
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.MessageDisplay = new System.Windows.Forms.Label();
            this.TimeDisplay = new System.Windows.Forms.Label();
            this.LivesDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MessageDisplay
            // 
            this.MessageDisplay.BackColor = System.Drawing.Color.Black;
            this.MessageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MessageDisplay.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageDisplay.ForeColor = System.Drawing.Color.White;
            this.MessageDisplay.Location = new System.Drawing.Point(196, 7);
            this.MessageDisplay.Name = "MessageDisplay";
            this.MessageDisplay.Size = new System.Drawing.Size(888, 25);
            this.MessageDisplay.TabIndex = 1;
            this.MessageDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeDisplay
            // 
            this.TimeDisplay.BackColor = System.Drawing.Color.Black;
            this.TimeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeDisplay.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeDisplay.ForeColor = System.Drawing.Color.White;
            this.TimeDisplay.Location = new System.Drawing.Point(40, 7);
            this.TimeDisplay.Name = "TimeDisplay";
            this.TimeDisplay.Size = new System.Drawing.Size(150, 25);
            this.TimeDisplay.TabIndex = 2;
            this.TimeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LivesDisplay
            // 
            this.LivesDisplay.BackColor = System.Drawing.Color.Black;
            this.LivesDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LivesDisplay.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesDisplay.ForeColor = System.Drawing.Color.White;
            this.LivesDisplay.Location = new System.Drawing.Point(1090, 7);
            this.LivesDisplay.Name = "LivesDisplay";
            this.LivesDisplay.Size = new System.Drawing.Size(150, 25);
            this.LivesDisplay.TabIndex = 3;
            this.LivesDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1279, 717);
            this.Controls.Add(this.LivesDisplay);
            this.Controls.Add(this.TimeDisplay);
            this.Controls.Add(this.MessageDisplay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameWindow";
            this.Text = "Magma";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Window_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Window_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label MessageDisplay;
        public System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label TimeDisplay;
        private System.Windows.Forms.Label LivesDisplay;
    }
}

