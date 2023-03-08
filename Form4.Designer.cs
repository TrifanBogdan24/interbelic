
namespace interbelic
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer_notificari_adauga = new System.Windows.Forms.Timer(this.components);
            this.panel_rezultate = new System.Windows.Forms.Panel();
            this.perc = new System.Windows.Forms.Label();
            this.trofeu = new System.Windows.Forms.PictureBox();
            this.scorobt = new System.Windows.Forms.Label();
            this.scor1 = new System.Windows.Forms.Label();
            this.home_rezultate = new System.Windows.Forms.PictureBox();
            this.restart = new System.Windows.Forms.PictureBox();
            this.panel_potriviri = new System.Windows.Forms.Panel();
            this.et4 = new System.Windows.Forms.Label();
            this.et3 = new System.Windows.Forms.Label();
            this.et2 = new System.Windows.Forms.Label();
            this.et1 = new System.Windows.Forms.Label();
            this.adauga = new System.Windows.Forms.Label();
            this.carte4 = new System.Windows.Forms.PictureBox();
            this.carte3 = new System.Windows.Forms.PictureBox();
            this.carte2 = new System.Windows.Forms.PictureBox();
            this.carte1 = new System.Windows.Forms.PictureBox();
            this.citat5 = new System.Windows.Forms.Label();
            this.citat4 = new System.Windows.Forms.Label();
            this.citat3 = new System.Windows.Forms.Label();
            this.citat2 = new System.Windows.Forms.Label();
            this.citat1 = new System.Windows.Forms.Label();
            this.punctajpotriviri = new System.Windows.Forms.Label();
            this.volume_potriviri = new System.Windows.Forms.PictureBox();
            this.timp2 = new System.Windows.Forms.Label();
            this.clock2 = new System.Windows.Forms.PictureBox();
            this.panel_rezultate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trofeu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_rezultate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).BeginInit();
            this.panel_potriviri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carte4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_potriviri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clock2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer_notificari_adauga
            // 
            this.timer_notificari_adauga.Tick += new System.EventHandler(this.timer_notificari_adauga_Tick);
            // 
            // panel_rezultate
            // 
            this.panel_rezultate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_rezultate.BackgroundImage")));
            this.panel_rezultate.Controls.Add(this.perc);
            this.panel_rezultate.Controls.Add(this.trofeu);
            this.panel_rezultate.Controls.Add(this.scorobt);
            this.panel_rezultate.Controls.Add(this.scor1);
            this.panel_rezultate.Controls.Add(this.home_rezultate);
            this.panel_rezultate.Controls.Add(this.restart);
            this.panel_rezultate.Location = new System.Drawing.Point(0, 0);
            this.panel_rezultate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_rezultate.Name = "panel_rezultate";
            this.panel_rezultate.Size = new System.Drawing.Size(1000, 549);
            this.panel_rezultate.TabIndex = 34;
            // 
            // perc
            // 
            this.perc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.perc.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perc.ForeColor = System.Drawing.Color.Goldenrod;
            this.perc.Location = new System.Drawing.Point(296, 31);
            this.perc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.perc.Name = "perc";
            this.perc.Size = new System.Drawing.Size(329, 76);
            this.perc.TabIndex = 15;
            this.perc.Text = "100/100";
            this.perc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trofeu
            // 
            this.trofeu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trofeu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trofeu.BackgroundImage")));
            this.trofeu.Location = new System.Drawing.Point(411, 160);
            this.trofeu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trofeu.Name = "trofeu";
            this.trofeu.Size = new System.Drawing.Size(70, 107);
            this.trofeu.TabIndex = 14;
            this.trofeu.TabStop = false;
            // 
            // scorobt
            // 
            this.scorobt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scorobt.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorobt.ForeColor = System.Drawing.Color.Goldenrod;
            this.scorobt.Location = new System.Drawing.Point(163, 99);
            this.scorobt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scorobt.Name = "scorobt";
            this.scorobt.Size = new System.Drawing.Size(549, 76);
            this.scorobt.TabIndex = 11;
            this.scorobt.Text = "Scor obtinut:";
            this.scorobt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scor1
            // 
            this.scor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scor1.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scor1.ForeColor = System.Drawing.Color.Goldenrod;
            this.scor1.Location = new System.Drawing.Point(163, 202);
            this.scor1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scor1.Name = "scor1";
            this.scor1.Size = new System.Drawing.Size(549, 76);
            this.scor1.TabIndex = 10;
            this.scor1.Text = " 78/100";
            this.scor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home_rezultate
            // 
            this.home_rezultate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_rezultate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_rezultate.BackgroundImage")));
            this.home_rezultate.Location = new System.Drawing.Point(447, 393);
            this.home_rezultate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.home_rezultate.Name = "home_rezultate";
            this.home_rezultate.Size = new System.Drawing.Size(32, 32);
            this.home_rezultate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.home_rezultate.TabIndex = 9;
            this.home_rezultate.TabStop = false;
            this.home_rezultate.Click += new System.EventHandler(this.home_rezultate_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restart.BackgroundImage")));
            this.restart.Location = new System.Drawing.Point(397, 393);
            this.restart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(32, 32);
            this.restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.restart.TabIndex = 8;
            this.restart.TabStop = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // panel_potriviri
            // 
            this.panel_potriviri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_potriviri.BackgroundImage")));
            this.panel_potriviri.Controls.Add(this.et4);
            this.panel_potriviri.Controls.Add(this.et3);
            this.panel_potriviri.Controls.Add(this.et2);
            this.panel_potriviri.Controls.Add(this.et1);
            this.panel_potriviri.Controls.Add(this.adauga);
            this.panel_potriviri.Controls.Add(this.carte4);
            this.panel_potriviri.Controls.Add(this.carte3);
            this.panel_potriviri.Controls.Add(this.carte2);
            this.panel_potriviri.Controls.Add(this.carte1);
            this.panel_potriviri.Controls.Add(this.citat5);
            this.panel_potriviri.Controls.Add(this.citat4);
            this.panel_potriviri.Controls.Add(this.citat3);
            this.panel_potriviri.Controls.Add(this.citat2);
            this.panel_potriviri.Controls.Add(this.citat1);
            this.panel_potriviri.Controls.Add(this.punctajpotriviri);
            this.panel_potriviri.Controls.Add(this.volume_potriviri);
            this.panel_potriviri.Controls.Add(this.timp2);
            this.panel_potriviri.Controls.Add(this.clock2);
            this.panel_potriviri.Location = new System.Drawing.Point(0, 0);
            this.panel_potriviri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_potriviri.Name = "panel_potriviri";
            this.panel_potriviri.Size = new System.Drawing.Size(1000, 549);
            this.panel_potriviri.TabIndex = 35;
            // 
            // et4
            // 
            this.et4.BackColor = System.Drawing.Color.Gray;
            this.et4.ForeColor = System.Drawing.Color.Cornsilk;
            this.et4.Location = new System.Drawing.Point(749, 346);
            this.et4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.et4.Name = "et4";
            this.et4.Size = new System.Drawing.Size(81, 38);
            this.et4.TabIndex = 26;
            this.et4.Text = "\"Ion\"";
            this.et4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // et3
            // 
            this.et3.BackColor = System.Drawing.Color.Gray;
            this.et3.ForeColor = System.Drawing.Color.Cornsilk;
            this.et3.Location = new System.Drawing.Point(626, 346);
            this.et3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.et3.Name = "et3";
            this.et3.Size = new System.Drawing.Size(81, 38);
            this.et3.TabIndex = 25;
            this.et3.Text = "\"Maitreyi\"";
            this.et3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // et2
            // 
            this.et2.BackColor = System.Drawing.Color.Gray;
            this.et2.ForeColor = System.Drawing.Color.Cornsilk;
            this.et2.Location = new System.Drawing.Point(749, 162);
            this.et2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.et2.Name = "et2";
            this.et2.Size = new System.Drawing.Size(81, 38);
            this.et2.TabIndex = 24;
            this.et2.Text = "\"Ultima noapte de dragoste...\"";
            this.et2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // et1
            // 
            this.et1.BackColor = System.Drawing.Color.Gray;
            this.et1.ForeColor = System.Drawing.Color.Cornsilk;
            this.et1.Location = new System.Drawing.Point(626, 162);
            this.et1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.et1.Name = "et1";
            this.et1.Size = new System.Drawing.Size(81, 38);
            this.et1.TabIndex = 23;
            this.et1.Text = "\"Enigma Otiliei\"";
            this.et1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adauga
            // 
            this.adauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adauga.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.adauga.ForeColor = System.Drawing.Color.White;
            this.adauga.Location = new System.Drawing.Point(-1, 9);
            this.adauga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(123, 49);
            this.adauga.TabIndex = 22;
            this.adauga.Text = "+10 puncte\r\n+10 secunde";
            this.adauga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carte4
            // 
            this.carte4.Location = new System.Drawing.Point(724, 265);
            this.carte4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carte4.Name = "carte4";
            this.carte4.Size = new System.Drawing.Size(123, 172);
            this.carte4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carte4.TabIndex = 21;
            this.carte4.TabStop = false;
            this.carte4.Click += new System.EventHandler(this.carte4_Click);
            // 
            // carte3
            // 
            this.carte3.Location = new System.Drawing.Point(601, 265);
            this.carte3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carte3.Name = "carte3";
            this.carte3.Size = new System.Drawing.Size(123, 172);
            this.carte3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carte3.TabIndex = 20;
            this.carte3.TabStop = false;
            this.carte3.Click += new System.EventHandler(this.carte3_Click);
            // 
            // carte2
            // 
            this.carte2.Location = new System.Drawing.Point(724, 93);
            this.carte2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carte2.Name = "carte2";
            this.carte2.Size = new System.Drawing.Size(123, 172);
            this.carte2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carte2.TabIndex = 18;
            this.carte2.TabStop = false;
            this.carte2.Click += new System.EventHandler(this.carte2_Click);
            // 
            // carte1
            // 
            this.carte1.Location = new System.Drawing.Point(601, 93);
            this.carte1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carte1.Name = "carte1";
            this.carte1.Size = new System.Drawing.Size(123, 172);
            this.carte1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carte1.TabIndex = 17;
            this.carte1.TabStop = false;
            this.carte1.Click += new System.EventHandler(this.carte1_Click);
            // 
            // citat5
            // 
            this.citat5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.citat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citat5.Location = new System.Drawing.Point(2, 369);
            this.citat5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.citat5.Name = "citat5";
            this.citat5.Size = new System.Drawing.Size(386, 69);
            this.citat5.TabIndex = 15;
            this.citat5.Text = "label5";
            this.citat5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.citat5.Click += new System.EventHandler(this.citat5_Click);
            // 
            // citat4
            // 
            this.citat4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.citat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citat4.Location = new System.Drawing.Point(2, 300);
            this.citat4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.citat4.Name = "citat4";
            this.citat4.Size = new System.Drawing.Size(386, 69);
            this.citat4.TabIndex = 14;
            this.citat4.Text = "label4";
            this.citat4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.citat4.Click += new System.EventHandler(this.citat4_Click);
            // 
            // citat3
            // 
            this.citat3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.citat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citat3.Location = new System.Drawing.Point(0, 231);
            this.citat3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.citat3.Name = "citat3";
            this.citat3.Size = new System.Drawing.Size(388, 69);
            this.citat3.TabIndex = 13;
            this.citat3.Text = "label3";
            this.citat3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.citat3.Click += new System.EventHandler(this.citat3_Click);
            // 
            // citat2
            // 
            this.citat2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.citat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citat2.Location = new System.Drawing.Point(0, 162);
            this.citat2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.citat2.Name = "citat2";
            this.citat2.Size = new System.Drawing.Size(388, 69);
            this.citat2.TabIndex = 12;
            this.citat2.Text = "“O iubire mare e mai curând un proces de autosugestie, trebuie timp și trebuie co" +
    "mplicitate pentru formarea ei.”";
            this.citat2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.citat2.Click += new System.EventHandler(this.citat2_Click);
            // 
            // citat1
            // 
            this.citat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.citat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citat1.Location = new System.Drawing.Point(0, 93);
            this.citat1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.citat1.Name = "citat1";
            this.citat1.Size = new System.Drawing.Size(388, 69);
            this.citat1.TabIndex = 11;
            this.citat1.Text = resources.GetString("citat1.Text");
            this.citat1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.citat1.Click += new System.EventHandler(this.citat1_Click);
            // 
            // punctajpotriviri
            // 
            this.punctajpotriviri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.punctajpotriviri.Font = new System.Drawing.Font("Poor Richard", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punctajpotriviri.ForeColor = System.Drawing.Color.White;
            this.punctajpotriviri.Location = new System.Drawing.Point(333, 9);
            this.punctajpotriviri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.punctajpotriviri.Name = "punctajpotriviri";
            this.punctajpotriviri.Size = new System.Drawing.Size(201, 35);
            this.punctajpotriviri.TabIndex = 6;
            this.punctajpotriviri.Text = "20 de puncte";
            this.punctajpotriviri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volume_potriviri
            // 
            this.volume_potriviri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.volume_potriviri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volume_potriviri.BackgroundImage")));
            this.volume_potriviri.Location = new System.Drawing.Point(538, 24);
            this.volume_potriviri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.volume_potriviri.Name = "volume_potriviri";
            this.volume_potriviri.Size = new System.Drawing.Size(32, 32);
            this.volume_potriviri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.volume_potriviri.TabIndex = 5;
            this.volume_potriviri.TabStop = false;
            // 
            // timp2
            // 
            this.timp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timp2.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timp2.ForeColor = System.Drawing.Color.Green;
            this.timp2.Location = new System.Drawing.Point(625, 24);
            this.timp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timp2.Name = "timp2";
            this.timp2.Size = new System.Drawing.Size(216, 35);
            this.timp2.TabIndex = 4;
            this.timp2.Text = "label26";
            this.timp2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clock2
            // 
            this.clock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clock2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clock2.BackgroundImage")));
            this.clock2.Location = new System.Drawing.Point(578, 21);
            this.clock2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clock2.Name = "clock2";
            this.clock2.Size = new System.Drawing.Size(32, 32);
            this.clock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.clock2.TabIndex = 3;
            this.clock2.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 453);
            this.Controls.Add(this.panel_potriviri);
            this.Controls.Add(this.panel_rezultate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Romanul interbelic";
            this.panel_rezultate.ResumeLayout(false);
            this.panel_rezultate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trofeu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_rezultate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).EndInit();
            this.panel_potriviri.ResumeLayout(false);
            this.panel_potriviri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carte4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_potriviri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clock2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer_notificari_adauga;
        private System.Windows.Forms.Panel panel_rezultate;
        private System.Windows.Forms.Label perc;
        private System.Windows.Forms.PictureBox trofeu;
        private System.Windows.Forms.Label scorobt;
        private System.Windows.Forms.Label scor1;
        private System.Windows.Forms.PictureBox home_rezultate;
        private System.Windows.Forms.PictureBox restart;
        private System.Windows.Forms.Panel panel_potriviri;
        private System.Windows.Forms.Label et4;
        private System.Windows.Forms.Label et3;
        private System.Windows.Forms.Label et2;
        private System.Windows.Forms.Label et1;
        private System.Windows.Forms.Label adauga;
        private System.Windows.Forms.PictureBox carte4;
        private System.Windows.Forms.PictureBox carte3;
        private System.Windows.Forms.PictureBox carte2;
        private System.Windows.Forms.PictureBox carte1;
        private System.Windows.Forms.Label citat5;
        private System.Windows.Forms.Label citat4;
        private System.Windows.Forms.Label citat3;
        private System.Windows.Forms.Label citat2;
        private System.Windows.Forms.Label citat1;
        private System.Windows.Forms.Label punctajpotriviri;
        private System.Windows.Forms.PictureBox volume_potriviri;
        private System.Windows.Forms.Label timp2;
        private System.Windows.Forms.PictureBox clock2;
    }
}