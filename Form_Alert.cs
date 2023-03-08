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
    public partial class Form_Alert : Form
    {
        int ceform;
        public Form_Alert()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.literature_icon;
        }
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Corect,
            Gresit,
            Nimic,
            Final,
            Perfect,
            Addtime,
            Addpoints

        }
        private Form_Alert.enmAction action;


        private int x, y;
        public void showAlert(string msg, string rasp1, string rasp2, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            lblMsg.ForeColor = Color.FromArgb(240, 240, 240);
            switch (type)
            {
                case enmType.Corect:

                    Top = 0;
                    Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
                    this.BackColor = Color.DarkRed;
                    ceform = 1;
                    xulet.BackgroundImage = Properties.Resources.x_button;
                    corect.BackgroundImage = Properties.Resources.approved;
                    lblMsg.Text = rasp1 + '\n' + "Raspuns corect:" + rasp2;
                    break;
                case enmType.Gresit:
                    Top = 20;
                    Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
                    ceform = 1;
                    this.BackColor = Color.DarkRed;
                    xulet.BackgroundImage = Properties.Resources.x_button__1_;
                    corect.BackgroundImage = Properties.Resources.approved;
                    lblMsg.Text = rasp1 + '\n' + "Raspuns corect:" + rasp2;
                    break;


                case enmType.Nimic:
                    Top = 20;
                    Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
                    ceform = 1;
                    this.BackColor = Color.Yellow;
                    xulet.BackgroundImage = Properties.Resources.x_button__1_;
                    corect.BackgroundImage = Properties.Resources.dece;
                    lblMsg.Text = "Nici macar nu ai incercat!"; lblMsg.ForeColor = Color.Red;
                    break;


                case enmType.Final:

                    lblMsg.BackColor = panel1.BackColor=this.BackColor = Color.FromArgb(22,18,126);
                    xulet.BackgroundImage = Properties.Resources.x_button__2_;
                    corect.BackgroundImage = Properties.Resources.positive_vote;
                
                    lblMsg.Text = rasp1;
                    for (int i = 1; i < 10; i++)
                    {
                        ceform = 2;
                        fname = "alert" + i.ToString();
                        Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                        if (frm == null)
                        {
                            this.Name = fname;
                            this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                            this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                            this.Location = new Point(this.x, this.y);
                            break;

                        }

                    }
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
                    break;

                case enmType.Perfect:

                    xulet.BackgroundImage = Properties.Resources.x_button__3_;
                    corect.BackgroundImage = Properties.Resources.trophy;
                    lblMsg.BackColor = panel1.BackColor =  this.BackColor = Color.Goldenrod;
                    lblMsg.Text = rasp1;
                    for (int i = 1; i < 10; i++)
                    {
                        ceform = 2;
                        fname = "alert" + i.ToString();
                        Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                        if (frm == null)
                        {
                            this.Name = fname;
                            this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                            this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                            this.Location = new Point(this.x, this.y);
                            break;

                        }

                    }
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
                    break;

            }




   





            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:


                    if (ceform == 2) timer1.Interval = 4000;
                    else if (ceform == 1) timer1.Interval = 100;
                    action = enmAction.close;
                    break;
                case Form_Alert.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                       
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Form_Alert.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
    }
}
