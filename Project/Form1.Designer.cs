namespace Magma_Game
{
    partial class Start_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Window));
            this.Start_Button = new System.Windows.Forms.Button();
            this.Credits_Button = new System.Windows.Forms.Button();
            this.Controls_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Start_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Start_Button.Image = ((System.Drawing.Image)(resources.GetObject("Start_Button.Image")));
            this.Start_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Start_Button.Location = new System.Drawing.Point(255, 227);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(219, 107);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Credits_Button
            // 
            this.Credits_Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Credits_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Credits_Button.Location = new System.Drawing.Point(665, 386);
            this.Credits_Button.Name = "Credits_Button";
            this.Credits_Button.Size = new System.Drawing.Size(75, 23);
            this.Credits_Button.TabIndex = 4;
            this.Credits_Button.Text = "Creators";
            this.Credits_Button.UseVisualStyleBackColor = false;
            this.Credits_Button.Click += new System.EventHandler(this.Credits_Button_Click);
            // 
            // Controls_Button
            // 
            this.Controls_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Controls_Button.BackgroundImage")));
            this.Controls_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls_Button.Location = new System.Drawing.Point(210, 340);
            this.Controls_Button.Name = "Controls_Button";
            this.Controls_Button.Size = new System.Drawing.Size(322, 69);
            this.Controls_Button.TabIndex = 2;
            this.Controls_Button.UseVisualStyleBackColor = true;
            this.Controls_Button.Click += new System.EventHandler(this.Controls_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit_Button.Location = new System.Drawing.Point(665, 357);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 3;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Start_Window
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(766, 458);
            this.ControlBox = false;
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Controls_Button);
            this.Controls.Add(this.Credits_Button);
            this.Controls.Add(this.Start_Button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(768, 460);
            this.MinimumSize = new System.Drawing.Size(768, 460);
            this.Name = "Start_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Credits_Button;
        private System.Windows.Forms.Button Controls_Button;
        private System.Windows.Forms.Button Exit_Button;
    }
}

