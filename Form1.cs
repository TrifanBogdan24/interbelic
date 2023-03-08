using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interbelic
{
    public partial class Form1 : Form
    {
        int t = 0;
        int stop_pause = 1;
        public Form1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.literature_icon;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            test1.BackgroundImage = Properties.Resources.test1_1;test2.BackgroundImage = Properties.Resources.test2_1;
            panel_start.BackgroundImage = Properties.Resources.backcarte ;
            info.BackgroundImage = Properties.Resources.information;
            test1.MouseEnter += OnMouseEntertest1;test1.MouseLeave += OnMouseLeavetest1;
            test2.MouseEnter += OnMouseEntertest2; test2.MouseLeave += OnMouseLeavetest2;
            info.MouseEnter += OnMouseEnterinfo; info.MouseLeave += OnMouseLeaveinfo;
            test1.Cursor = test2.Cursor =info.Cursor=volume_pagina_teste.Cursor= Cursors.Hand;
            WindowsMediaPlayer.Visible = false;
          //  WindowsMediaPlayer.URL = "D:/surdina/sunet2.mp4";
            volume_pagina_teste.BackgroundImage = Properties.Resources.soundon;

            volume_pagina_teste.Visible = false;

        }

        private void OnMouseEntertest1(object sender, EventArgs e)
        {
            test1.BackgroundImage = Properties.Resources.test1_2;
        }
        private void OnMouseLeavetest1(object sender, EventArgs e)
        {
            test1.BackgroundImage = Properties.Resources.test1_1;
        }

        private void OnMouseEntertest2(object sender, EventArgs e)
        {
            test2.BackgroundImage = Properties.Resources.test2_2;
        }
        private void OnMouseLeavetest2(object sender, EventArgs e)
        {
            test2.BackgroundImage = Properties.Resources.test2_1;
        }

        private void OnMouseEnterinfo(object sender, EventArgs e)
        {
            info.BackgroundImage = Properties.Resources.information__1;
        }
        private void OnMouseLeaveinfo(object sender, EventArgs e)
        {
           info.BackgroundImage = Properties.Resources.information;
        }

        private void WindowsMediaPlayer_EndOfStream(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
            WindowsMediaPlayer.Ctlcontrols.play();
        }

        private void WindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            stop_pause = 1 - stop_pause;
            if (stop_pause == 0)
            {
                WindowsMediaPlayer.Ctlcontrols.pause();
          
                volume_pagina_teste.BackgroundImage = Properties.Resources.soundoff;

            }
            else if (stop_pause == 1)
            {
                WindowsMediaPlayer.Ctlcontrols.play();

                volume_pagina_teste.BackgroundImage = Properties.Resources.soundon;

            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void test1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void test2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
