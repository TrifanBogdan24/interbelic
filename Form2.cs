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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.literature_icon;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            panel_info.BackgroundImage = Properties.Resources.backg_informatii1;
            testul1.Cursor = testul2.Cursor =volume_pagina_inf.Cursor=exit_info.Cursor= Cursors.Hand;
            exit_info.BackgroundImage = Properties.Resources.exitpage;


            descriere1.Text = "  Cuprinde întrebări cu alegere multiplă. Cronometrul este de douăzeci(20) de secunde și se resetează automat după fiecare răspuns dat. ";
            descriere2.Text = "  Trebuie să potriviți citatul cu autorul/cartea corespunzător(-oare). Odată ce utilizatorul face o corespundență corectă, durata se va mari."+Environment.NewLine+"  Scopul jocului este să obtineți un scor cât mai mare în lupta contra cronometrului.";
           volume_pagina_inf.BackgroundImage = Properties.Resources.soundon;
            volume_pagina_inf.Visible = false;
            
        }

        private void testul1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void exit_info_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void testul2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form4 = new Form4();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
