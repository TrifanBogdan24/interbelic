
namespace interbelic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_start = new System.Windows.Forms.Panel();
            this.volume_pagina_teste = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.PictureBox();
            this.test2 = new System.Windows.Forms.PictureBox();
            this.test1 = new System.Windows.Forms.PictureBox();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel_start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_pagina_teste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_start
            // 
            this.panel_start.BackColor = System.Drawing.Color.White;
            this.panel_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_start.BackgroundImage")));
            this.panel_start.Controls.Add(this.volume_pagina_teste);
            this.panel_start.Controls.Add(this.WindowsMediaPlayer);
            this.panel_start.Controls.Add(this.info);
            this.panel_start.Controls.Add(this.test2);
            this.panel_start.Controls.Add(this.test1);
            this.panel_start.Location = new System.Drawing.Point(0, 0);
            this.panel_start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_start.Name = "panel_start";
            this.panel_start.Size = new System.Drawing.Size(986, 513);
            this.panel_start.TabIndex = 0;
            // 
            // volume_pagina_teste
            // 
            this.volume_pagina_teste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.volume_pagina_teste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volume_pagina_teste.BackgroundImage")));
            this.volume_pagina_teste.Location = new System.Drawing.Point(108, 8);
            this.volume_pagina_teste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.volume_pagina_teste.Name = "volume_pagina_teste";
            this.volume_pagina_teste.Size = new System.Drawing.Size(32, 32);
            this.volume_pagina_teste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.volume_pagina_teste.TabIndex = 4;
            this.volume_pagina_teste.TabStop = false;
            this.volume_pagina_teste.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("info.BackgroundImage")));
            this.info.Location = new System.Drawing.Point(8, 8);
            this.info.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(64, 65);
            this.info.TabIndex = 2;
            this.info.TabStop = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // test2
            // 
            this.test2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.test2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("test2.BackgroundImage")));
            this.test2.Location = new System.Drawing.Point(485, 81);
            this.test2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(256, 255);
            this.test2.TabIndex = 1;
            this.test2.TabStop = false;
            this.test2.Click += new System.EventHandler(this.test2_Click);
            // 
            // test1
            // 
            this.test1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.test1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("test1.BackgroundImage")));
            this.test1.Location = new System.Drawing.Point(158, 81);
            this.test1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(256, 255);
            this.test1.TabIndex = 0;
            this.test1.TabStop = false;
            this.test1.Click += new System.EventHandler(this.test1_Click);
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(542, 3);
            this.WindowsMediaPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(402, 22);
            this.WindowsMediaPlayer.TabIndex = 3;
            this.WindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WindowsMediaPlayer_PlayStateChange);
            this.WindowsMediaPlayer.EndOfStream += new AxWMPLib._WMPOCXEvents_EndOfStreamEventHandler(this.WindowsMediaPlayer_EndOfStream);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 453);
            this.Controls.Add(this.panel_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Romanul interbelic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_start.ResumeLayout(false);
            this.panel_start.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_pagina_teste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_start;
        private System.Windows.Forms.PictureBox test1;
        private System.Windows.Forms.PictureBox test2;
        private System.Windows.Forms.PictureBox info;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox volume_pagina_teste;
    }
}

