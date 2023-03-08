
namespace interbelic
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel_info = new System.Windows.Forms.Panel();
            this.exit_info = new System.Windows.Forms.PictureBox();
            this.volume_pagina_inf = new System.Windows.Forms.PictureBox();
            this.descriere2 = new System.Windows.Forms.Label();
            this.testul2 = new System.Windows.Forms.LinkLabel();
            this.descriere1 = new System.Windows.Forms.Label();
            this.testul1 = new System.Windows.Forms.LinkLabel();
            this.panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_pagina_inf)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_info
            // 
            this.panel_info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_info.BackgroundImage")));
            this.panel_info.Controls.Add(this.exit_info);
            this.panel_info.Controls.Add(this.volume_pagina_inf);
            this.panel_info.Controls.Add(this.descriere2);
            this.panel_info.Controls.Add(this.testul2);
            this.panel_info.Controls.Add(this.descriere1);
            this.panel_info.Controls.Add(this.testul1);
            this.panel_info.Location = new System.Drawing.Point(0, 0);
            this.panel_info.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(986, 513);
            this.panel_info.TabIndex = 0;
            // 
            // exit_info
            // 
            this.exit_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit_info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_info.BackgroundImage")));
            this.exit_info.Location = new System.Drawing.Point(813, 8);
            this.exit_info.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit_info.Name = "exit_info";
            this.exit_info.Size = new System.Drawing.Size(32, 32);
            this.exit_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exit_info.TabIndex = 7;
            this.exit_info.TabStop = false;
            this.exit_info.Click += new System.EventHandler(this.exit_info_Click);
            // 
            // volume_pagina_inf
            // 
            this.volume_pagina_inf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.volume_pagina_inf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volume_pagina_inf.BackgroundImage")));
            this.volume_pagina_inf.Location = new System.Drawing.Point(763, 8);
            this.volume_pagina_inf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.volume_pagina_inf.Name = "volume_pagina_inf";
            this.volume_pagina_inf.Size = new System.Drawing.Size(32, 32);
            this.volume_pagina_inf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.volume_pagina_inf.TabIndex = 6;
            this.volume_pagina_inf.TabStop = false;
            // 
            // descriere2
            // 
            this.descriere2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descriere2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriere2.ForeColor = System.Drawing.Color.Goldenrod;
            this.descriere2.Location = new System.Drawing.Point(255, 255);
            this.descriere2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriere2.Name = "descriere2";
            this.descriere2.Size = new System.Drawing.Size(548, 149);
            this.descriere2.TabIndex = 3;
            this.descriere2.Text = resources.GetString("descriere2.Text");
            // 
            // testul2
            // 
            this.testul2.ActiveLinkColor = System.Drawing.Color.Purple;
            this.testul2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testul2.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testul2.LinkColor = System.Drawing.Color.Goldenrod;
            this.testul2.Location = new System.Drawing.Point(251, 197);
            this.testul2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testul2.Name = "testul2";
            this.testul2.Size = new System.Drawing.Size(354, 84);
            this.testul2.TabIndex = 2;
            this.testul2.TabStop = true;
            this.testul2.Text = "Testul 2";
            this.testul2.VisitedLinkColor = System.Drawing.Color.Goldenrod;
            this.testul2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.testul2_LinkClicked);
            // 
            // descriere1
            // 
            this.descriere1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descriere1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriere1.ForeColor = System.Drawing.Color.Goldenrod;
            this.descriere1.Location = new System.Drawing.Point(255, 109);
            this.descriere1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriere1.Name = "descriere1";
            this.descriere1.Size = new System.Drawing.Size(579, 96);
            this.descriere1.TabIndex = 1;
            this.descriere1.Text = "  Cuprindeă intrebari cu alegere multipla. Cronometrul este de 10 secunde si se r" +
    "eseteaza automat dupa fiecare raspuns dat. ";
            // 
            // testul1
            // 
            this.testul1.ActiveLinkColor = System.Drawing.Color.Purple;
            this.testul1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testul1.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testul1.LinkColor = System.Drawing.Color.Goldenrod;
            this.testul1.Location = new System.Drawing.Point(251, 53);
            this.testul1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testul1.Name = "testul1";
            this.testul1.Size = new System.Drawing.Size(354, 84);
            this.testul1.TabIndex = 0;
            this.testul1.TabStop = true;
            this.testul1.Text = "Testul 1";
            this.testul1.VisitedLinkColor = System.Drawing.Color.Goldenrod;
            this.testul1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.testul1_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 453);
            this.Controls.Add(this.panel_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Romanul interbelic";
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_pagina_inf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.LinkLabel testul1;
        private System.Windows.Forms.Label descriere2;
        private System.Windows.Forms.LinkLabel testul2;
        private System.Windows.Forms.Label descriere1;
        private System.Windows.Forms.PictureBox volume_pagina_inf;
        private System.Windows.Forms.PictureBox exit_info;
    }
}