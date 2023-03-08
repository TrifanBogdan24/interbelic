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
    public partial class Form3 : Form
    {
        string rasp;
        bool ok;
        private int quick = 1200; //o secunda = 60
        bool merge_cronometrul = false;
        int nr = 1;
        int v;
        bool aspect = false;
        double punctaj;
        int p;
        private int x, y;
        int corecte, gresite, omise;
        string motivator;
        public Form3()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.literature_icon;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            intrebari_generale.Cursor = intrebari_romane.Cursor = home_romane.Cursor = exit_romane.Cursor = Next.Cursor=roman1.Cursor = roman2.Cursor = roman3.Cursor = roman4.Cursor = roman5.Cursor = roman6.Cursor = poza1.Cursor = poza2.Cursor = poza4.Cursor = poza3.Cursor = poza5.Cursor = poza6.Cursor =V1.Cursor=V2.Cursor=V3.Cursor=V4.Cursor=volume_tabel.Cursor = exit_tabel.Cursor = home_tabel.Cursor = restart.Cursor = home_rezultate.Cursor = home_choice.Cursor=volume_test.Cursor = Cursors.Hand;
            
            panel_tabel_raspunsuri.BackgroundImage = Properties.Resources.backg_tabel;

            exit_romane.BackgroundImage = exit_tabel.BackgroundImage = Properties.Resources.exitpage;
            home_choice.BackgroundImage= home_romane.BackgroundImage = home_tabel.BackgroundImage = home_rezultate.BackgroundImage = Properties.Resources.homepage;
            volume_tabel.BackgroundImage = volume_test.BackgroundImage = Properties.Resources.soundon;
          
            panel_rezultate.BackgroundImage = Properties.Resources.podium;
            restart.BackgroundImage = Properties.Resources.restart;
            panel_test.BackgroundImage = Properties.Resources.back_test;
            clock1.BackgroundImage = Properties.Resources.clock;
            panel_romane.BackgroundImage = Properties.Resources.back_romane1;
            panel_choice.BackgroundImage = Properties.Resources.backcarte1;


            roman1.Text = "„Ultima noapte de dragoste,întâia noapte de război”";poza1.BackgroundImage = Properties.Resources.romanUNDD;
            roman2.Text = "„Patul lui Procust”";poza2.BackgroundImage = Properties.Resources.romanProcust;
            roman3.Text = "„Răscoala”"; poza3.BackgroundImage = Properties.Resources.romanIon; 

            roman4.Text = "„Ion”"; poza4.BackgroundImage = Properties.Resources.romanRascoala;
            roman5.Text = "„Enigma Otiliei”";poza5.BackgroundImage = Properties.Resources.romanOtilia;
            roman6.Text = "„Maytrei”";poza6.BackgroundImage = Properties.Resources.romanMaytrei;

            roman1.ForeColor = roman2.ForeColor = roman4.ForeColor = roman5.ForeColor = roman6.ForeColor = Color.FromArgb(45, 63, 83);
            roman1.Font = roman2.Font = roman3.Font = roman4.Font = roman5.Font = roman6.Font = new Font("Sitka Small", 10,FontStyle.Italic );


            intrebari_generale.BackgroundImage = Properties.Resources.generale1;
            intrebari_romane.BackgroundImage = Properties.Resources.romane1;



            V1.MouseEnter += OnMouseEnterV1; V1.MouseLeave += OnMouseLeaveV1;
            V2.MouseEnter += OnMouseEnterV2; V2.MouseLeave += OnMouseLeaveV2;
            V3.MouseEnter += OnMouseEnterV3; V3.MouseLeave += OnMouseLeaveV3;
            V4.MouseEnter += OnMouseEnterV4; V4.MouseLeave += OnMouseLeaveV4;
            Next.MouseEnter += OnMouseEnterNext; Next.MouseLeave += OnMouseLeaveNext;
            poza1.MouseEnter += OnMouseEnterpoza1; poza1.MouseLeave += OnMouseLeavepoza1;
            roman1.MouseEnter += OnMouseEnterpoza1; roman1.MouseLeave += OnMouseLeavepoza1;


            poza2.MouseEnter += OnMouseEnterpoza2; poza2.MouseLeave += OnMouseLeavepoza2;
            roman2.MouseEnter += OnMouseEnterpoza2; roman2.MouseLeave += OnMouseLeavepoza2;


            poza4.MouseEnter += OnMouseEnterpoza3; poza4.MouseLeave += OnMouseLeavepoza3;
            roman3.MouseEnter += OnMouseEnterpoza3; roman3.MouseLeave += OnMouseLeavepoza3;


            poza3.MouseEnter += OnMouseEnterpoza4; poza3.MouseLeave += OnMouseLeavepoza4;
            roman4.MouseEnter += OnMouseEnterpoza4; roman4.MouseLeave += OnMouseLeavepoza4;


            poza5.MouseEnter += OnMouseEnterpoza5; poza5.MouseLeave += OnMouseLeavepoza5;
            roman5.MouseEnter += OnMouseEnterpoza5; roman5.MouseLeave += OnMouseLeavepoza5;

            poza6.MouseEnter += OnMouseEnterpoza6; poza6.MouseLeave += OnMouseLeavepoza6;
            roman6.MouseEnter += OnMouseEnterpoza6; roman6.MouseLeave += OnMouseLeavepoza6;

            intrebari_generale.MouseEnter += OnMouseEnterintrebari_generale; intrebari_generale.MouseLeave += OnMouseLeaveintrebari_generale;
            intrebari_romane.MouseEnter += OnMouseEnterintrebari_romane; intrebari_romane.MouseLeave += OnMouseLeaveintrebari_romane;


            not1.Visible = false;

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;


            timer_notificare1 = new System.Windows.Forms.Timer();
            timer_notificare1.Interval = 1;
            timer_notificare1.Tick += new EventHandler(timer_notificare1_Tick);
            timer_notificare1.Enabled = true;

            aspect = false;
            //
            volume_tabel.BackgroundImage = volume_test.BackgroundImage = Properties.Resources.soundon;
            //
            panel_test.BackgroundImage = Properties.Resources.back_test1;

            volume_tabel.Visible = volume_test.Visible = false;

          timp1.ForeColor = Color.FromArgb(30, 208, 34);
            timp1.Text = "20 de secunde";
            merge_cronometrul = true;
            quick = 1200;
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

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert("Success",motivator, " ", type);
        }

        void afis_rezulatate()
        {
            scor1.Visible = scorobt.Visible = trofeu.Visible = perc.Visible = false;
            if (punctaj == 100.0) { perc.Visible = trofeu.Visible = true; panel_rezultate.BackgroundImage = Properties.Resources.podium; }
            else { if(punctaj>19.99)scor1.Text=Convert.ToString(punctaj)+" de puncte";
                   else scor1.Text = Convert.ToString(punctaj) + " puncte";
                scorobt.Visible = scor1.Visible = true;
                panel_rezultate.BackgroundImage = Properties.Resources.purple; 
               }

           
        }


        private void OnMouseEnterintrebari_generale(object sender, EventArgs e)
        {
            intrebari_generale.BackgroundImage = Properties.Resources.generale2;
        }
        private void OnMouseLeaveintrebari_generale(object sender, EventArgs e)
        {
            intrebari_generale.BackgroundImage = Properties.Resources.generale1;

        }

        private void OnMouseEnterintrebari_romane(object sender, EventArgs e)
        {
            intrebari_romane.BackgroundImage = Properties.Resources.romane2;
        }
        private void OnMouseLeaveintrebari_romane(object sender, EventArgs e)
        {
            intrebari_romane.BackgroundImage = Properties.Resources.romane1;

        }

        private void OnMouseEnterV1(object sender, EventArgs e)
        {
            if (aspect == true)
            {
                V1.FillColor = Color.FromArgb(212, 176, 127);
                V1.ForeColor = Color.FromArgb(35, 60, 79);
            }
       
        }
        private void OnMouseLeaveV1(object sender, EventArgs e)
        {
            if (aspect == true)
            {
                V1.FillColor = Color.FromArgb(35, 60, 79);
                // V1.ForeColor = Color.FromArgb(212, 176, 127);
                V1.ForeColor = Color.White;
            }
        }


        private void OnMouseEnterV2(object sender, EventArgs e)
        {
            if (aspect == true)
            {
                V2.FillColor = Color.FromArgb(212, 176, 127);
                V2.ForeColor = Color.FromArgb(35, 60, 79);
            }
        }
        private void OnMouseLeaveV2(object sender, EventArgs e)
        {
            if (aspect == true)
            {

                V2.FillColor = Color.FromArgb(35, 60, 79);
                //   V2.ForeColor = Color.FromArgb(212, 176, 127);
                V2.ForeColor = Color.White;
            }
        }
        private void OnMouseEnterV3(object sender, EventArgs e)
        {
            if (aspect == true)
            {
                V3.FillColor = Color.FromArgb(212, 176, 127);
                V3.ForeColor = Color.FromArgb(35, 60, 79);
            }
           
        }
        private void OnMouseLeaveV3(object sender, EventArgs e)
        {
            if (aspect == true)
            {
                V3.FillColor = Color.FromArgb(35, 60, 79);
                //   V3.ForeColor = Color.FromArgb(212, 176, 127);
                V3.ForeColor = Color.White;
            }
        }


        private void OnMouseEnterV4(object sender, EventArgs e)
        {
            if (aspect == true)
            {
                V4.FillColor = Color.FromArgb(212, 176, 127);
                V4.ForeColor = Color.FromArgb(35, 60, 79);
            }
        }
        private void OnMouseLeaveV4(object sender, EventArgs e)
        {
            if (aspect == true)
            {
                V4.FillColor = Color.FromArgb(35, 60, 79);
                //   V4.ForeColor = Color.FromArgb(212, 176, 127);
                V4.ForeColor = Color.White;
            }
        }

        private void OnMouseEnterNext(object sender, EventArgs e)
        {
            Next.BackColor = Color.FromArgb(35, 60, 79);
            Next.ForeColor = Color.FromArgb(212, 176, 127);
                
        }
        private void OnMouseLeaveNext(object sender, EventArgs e)
        {
            Next.BackColor = Color.FromArgb(212, 176, 127);
            Next.ForeColor = Color.FromArgb(35, 60, 79);
           

        }

        private void OnMouseEnterpoza1(object sender, EventArgs e)
        {
            roman1.ForeColor = Color.FromArgb(97, 77, 89);
            roman1.Font = new Font("Sitka Small", 10, FontStyle.Italic | FontStyle.Underline);
        }
        private void OnMouseLeavepoza1(object sender, EventArgs e)
        {
            roman1.ForeColor = Color.FromArgb(45, 63, 83);
            roman1.Font = new Font("Sitka Small", 10, FontStyle.Italic);

        }


        private void OnMouseEnterpoza2(object sender, EventArgs e)
        {
            roman2.ForeColor = Color.FromArgb(97, 77, 89);
            roman2.Font = new Font("Sitka Small", 10, FontStyle.Italic | FontStyle.Underline);
        }
        private void OnMouseLeavepoza2(object sender, EventArgs e)
        {
            roman2.ForeColor = Color.FromArgb(45, 63, 83);
            roman2.Font = new Font("Sitka Small", 10, FontStyle.Italic);

        }

        private void OnMouseEnterpoza3(object sender, EventArgs e)
        {
            roman3.ForeColor = Color.FromArgb(97, 77, 89);
            roman3.Font = new Font("Sitka Small", 10, FontStyle.Italic | FontStyle.Underline);
        }
        private void OnMouseLeavepoza3(object sender, EventArgs e)
        {
            roman3.ForeColor = Color.FromArgb(45, 63, 83);
            roman3.Font = new Font("Sitka Small", 10, FontStyle.Italic);

        }

        private void OnMouseEnterpoza4(object sender, EventArgs e)
        {
            roman4.ForeColor = Color.FromArgb(97, 77, 89);
            roman4.Font = new Font("Sitka Small", 10, FontStyle.Italic | FontStyle.Underline);
        }
        private void OnMouseLeavepoza4(object sender, EventArgs e)
        {
            roman4.ForeColor = Color.FromArgb(45, 63, 83);
            roman4.Font = new Font("Sitka Small", 10, FontStyle.Italic);

        }

        private void OnMouseEnterpoza5(object sender, EventArgs e)
        {
            roman5.ForeColor = Color.FromArgb(97, 77, 89);
            roman5.Font = new Font("Sitka Small", 10, FontStyle.Italic | FontStyle.Underline);
        }
        private void OnMouseLeavepoza5(object sender, EventArgs e)
        {
            roman5.ForeColor = Color.FromArgb(45, 63, 83);
            roman5.Font = new Font("Sitka Small", 10, FontStyle.Italic);

        }
        private void OnMouseEnterpoza6(object sender, EventArgs e)
        {
            roman6.ForeColor = Color.FromArgb(97, 77, 89);
            roman6.Font = new Font("Sitka Small", 10, FontStyle.Italic | FontStyle.Underline);
        }
        private void OnMouseLeavepoza6(object sender, EventArgs e)
        {
            roman6.ForeColor = Color.FromArgb(45, 63, 83);
            roman6.Font = new Font("Sitka Small", 10, FontStyle.Italic);

        }


        void corectare()
        { bool corect = false;
            Next.Visible = true;

            ok = true;
            aspect = false;
            merge_cronometrul = false;
            V1.Animated = V2.Animated = V3.Animated = V4.Animated = false;
            V1.ForeColor = V2.ForeColor = V3.ForeColor = V4.ForeColor = Color.White;
            corect = false;
            if (p == 1)
            {

              
                if(nr==4)
                {
                    r4.Text = V1.Text;

                    if (v == 1) 
                    {  V1.FillColor = Color.Lime; corect = true;
        
                    }else if (v == 2)
                    {
                        V2.FillColor = Color.Red;V1.FillColor = Color.Green;

                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V1.FillColor = Color.Green;

                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V1.FillColor = Color.Green;
                       
                    }else if (v == 5)
                    {
                        V1.FillColor = Color.Yellow;V1.ForeColor = Color.Red;
                      
                    }
                }else if (nr==3||nr==6)
                {
                    if (nr == 3) r3.Text = V2.Text;
                    else if (nr == 6) r6.Text = V2.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V2.FillColor = Color.Green;

                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Lime;corect = true;
              

                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V2.FillColor = Color.Green;
      
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V2.FillColor = Color.Green;

                    }
                    if (v == 5)
                    {
                        V2.FillColor = Color.Yellow; V2.ForeColor = Color.Red;

                    }
                }
                else if (nr == 1 ||nr==2)
                {
                    if (nr == 1) r1.Text = V3.Text;
                    else if (nr == 2) r2.Text = V3.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V3.FillColor = Color.Green;

                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V3.FillColor = Color.Green;

                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Lime;corect = true;
             

                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V3.FillColor = Color.Green;
                   
                    }else if (v == 5)
                    {
                        V3.FillColor = Color.Yellow;V3.ForeColor = Color.Red;


                    }
                }else if (nr==5)
                {
                    r5.Text = V4.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V4.FillColor = Color.Green;

                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V4.FillColor = Color.Green;

                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V4.FillColor = Color.Green;
    
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Lime; corect = true;
                       

                    }else if (v == 5)
                    {
                        V4.FillColor = Color.Yellow;V4.ForeColor = Color.Red;
                   
                    }
                }

            
            }else if (p == 2)
            {
                if(nr==2)//v1
                {
                    r2.Text = V1.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Lime; corect = true;
                      
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V1.FillColor = Color.Green;


                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V1.FillColor = Color.Green;

                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V1.FillColor = Color.Green;
                     
                    }
                    else if (v == 5)
                    {
                        V1.FillColor = Color.Yellow; V1.ForeColor = Color.Red;
                 
                    }
                }
                else if (nr == 3||nr==5)//v2
                {
                    if (nr == 3) r3.Text = V2.Text;
                    else if (nr == 5) r5.Text = V2.Text;


                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V2.FillColor = Color.Green;

                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Lime; corect = true;


                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V2.FillColor = Color.Green;


                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V2.FillColor = Color.Green;

                    }
                    else if (v == 5)
                    {
                        V2.FillColor = Color.Yellow; V2.ForeColor = Color.Red;
                       
                    }
                }
                else if (nr==6)//v3
                {
                    r6.Text = V3.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V3.FillColor = Color.Green;

                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V3.FillColor = Color.Green;

                    }
                    else if (v == 3)
                    {
                        V2.FillColor = Color.Lime; corect = true;
                      
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V2.FillColor = Color.Green;
                     
                    }
                    else if (v == 5)
                    {
                        V3.FillColor = Color.Yellow; V3.ForeColor = Color.Red;
          
                    }
                }
                else if (nr == 1 ||nr==4)//v4
                {
                    if (nr == 1) r1.Text = V4.Text;
                    else if (nr == 4) r4.Text = V4.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V4.FillColor = Color.Green;
                      
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V4.FillColor = Color.Green;
                      
                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V4.FillColor = Color.Green;


                      
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Lime;corect = true;
           
                    
                    }
                    else if (v == 5)
                    {
                        V4.FillColor = Color.Yellow; V4.ForeColor = Color.Red;
                        
                    }
                }



            }else if (p == 4)
            {
                if (nr == 4)//v1
                {
                    r4.Text = V1.Text;

                    if (v == 1) 
                    {
                        V1.FillColor = Color.Lime;corect = true;
                      
                    }else if (v == 2)
                    {
                        V2.FillColor = Color.Red;V1.FillColor = Color.Green;
                      
                    }else if (v == 3)
                    {
                        V3.FillColor = Color.Red;V1.FillColor = Color.Green;
                      
                    }else if (v == 4)
                    {
                        V4.FillColor = Color.Red;V1.FillColor = Color.Green;
                       

                    }else if (v == 5)
                    {
                        V1.FillColor = Color.Yellow;V1.ForeColor = Color.Red;
                       
                    }
                    
                    
                }
                else if (nr == 1)//v2
                {
                    r1.Text = V2.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red;V2.FillColor = Color.Green;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Lime;corect = true;
                     

                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V2.FillColor = Color.Green;

                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V2.FillColor = Color.Green;


                    }
                    else if (v == 5)
                    {
                        V2.FillColor = Color.Yellow; V2.ForeColor = Color.Red;

                    }
                }
                else if (nr == 2 || nr == 5)//v3
                {
                    if (nr == 2) r2.Text = V3.Text;
                    else if (nr == 5) r5.Text = V3.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red;V3.FillColor = Color.Green;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V3.FillColor = Color.Green;

                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Lime;corect = true;
                       

                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V3.FillColor = Color.Green;


                    }
                    else if (v == 5)
                    {
                        V3.FillColor = Color.Yellow; V3.ForeColor = Color.Red;
                     
                    }
                }
                else if (nr == 3)//v4
                {
                    r3.Text = V4.Text;
                    if (v == 1)
                    {
                        V1.FillColor = Color.Red;V4.FillColor = Color.Green;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V4.FillColor = Color.Green;

                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V4.FillColor = Color.Green;

                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Lime;corect = true;
                      


                    }
                    else if (v == 5)
                    {
                        V1.FillColor = Color.Yellow; V1.ForeColor = Color.Red;
                     
                    }
                }
            }else if (p == 5)
            {
                if (nr ==2||nr==3)
                {
                    if (nr == 2) r2.Text = V1.Text;
                    else if (nr == 3) r3.Text = V1.Text;


                    if (v == 1)
                    {
                        V1.FillColor = Color.Lime;corect = true;
                    }else if (v == 2)
                    {
                        V2.FillColor = Color.Red;V1.FillColor = Color.Green;

                    }else if (v == 3)
                    {
                        V3.FillColor = Color.Red;V1.FillColor = Color.Green;
                    }else if (v == 4)
                    {
                        V4.FillColor = Color.Red;V1.FillColor = Color.Green;
                    }else if (v == 5)
                    {
                        V1.FillColor = Color.Yellow;V1.ForeColor = Color.Red;
                    }
                }else if (nr==4)
                {
                    if (nr == 4) r4.Text = V2.Text;
                   
                    if (v == 1)
                    {
                        V1.FillColor = Color.Red;V2.FillColor = Color.Green;
                    }else if (v == 2)
                    {
                        V2.FillColor = Color.Lime;corect = true;
                            
                    }else if (v == 3)
                    {
                        V3.FillColor = Color.Red;V2.FillColor = Color.Green;
                    }else if (v == 4)
                    {
                        V4.FillColor = Color.Red;V2.FillColor = Color.Green;
                    }else if (v == 5)
                    {
                        V2.FillColor = Color.Yellow;V2.ForeColor = Color.Red;
                    }
                }else if (nr ==1)
                {
                    r1.Text =V3.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red;V3.FillColor = Color.Green;
                    }else if (v == 2)
                    {
                        V2.FillColor = Color.Red;V3.FillColor = Color.Green;
                    }else if (v == 3)
                    {
                        V3.FillColor = Color.Lime;corect = true;
                    }else if (v == 4)
                    {
                        V4.FillColor = Color.Red;V3.FillColor = Color.Green;
                    }else if (v == 5)
                    {
                        V3.FillColor = Color.Yellow;V3.ForeColor = Color.Red;
                    }
                }else if (nr==6||nr==5)
                {
                    if (nr == 5) r5.Text = V4.Text;
                    else if(nr==6)r6.Text = V4.Text;


                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V4.FillColor = Color.Green;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V4.FillColor = Color.Green;
                    }
                    else if (v == 3)
                    {
                        V4.FillColor = Color.Red; V4.FillColor = Color.Green;
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Lime; corect = true;
                        
                    }else if (v == 5)
                    {
                        V4.FillColor = Color.Yellow;V4.ForeColor = Color.Red;
                    }
                }
            }else if (p == 6)
            {
                if (nr ==3||nr==5)
                {
                    if (nr == 3) r3.Text = V1.Text;
                    else if (nr == 5) r5.Text = V1.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Lime; corect = true;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V1.FillColor = Color.Green;

                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V1.FillColor = Color.Green;
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V1.FillColor = Color.Green;
                    }
                    else if (v == 5)
                    {
                        V1.FillColor = Color.Yellow; V1.ForeColor = Color.Red;
                    }
                }
                else if (nr ==1)
                {
                    r1.Text = V2.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V2.FillColor = Color.Green;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Lime; corect = true;


                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V2.FillColor = Color.Green;

                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V2.FillColor = Color.Green;


                    }
                    else if (v == 5)
                    {
                        V2.FillColor = Color.Yellow; V2.ForeColor = Color.Red;

                    }
                }
                else if (nr ==4)
                {
                    r4.Text = V3.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V3.FillColor = Color.Green;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V3.FillColor = Color.Green;
                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Lime; corect = true;
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V3.FillColor = Color.Green;
                    }
                    else if (v == 5)
                    {
                        V3.FillColor = Color.Yellow; V3.ForeColor = Color.Red;
                    }
                }
                else if (nr ==2||nr==6)
                {
                    if (nr == 2) r2.Text = V4.Text;
                    else if (nr == 6) r6.Text = V4.Text;
                    

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V4.FillColor = Color.Green;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V4.FillColor = Color.Green;
                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V4.FillColor = Color.Green;
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Lime; corect = true;

                    }
                    else if (v == 5)
                    {
                        V4.FillColor = Color.Yellow; V4.ForeColor = Color.Red;
                    }

                }
            }else if (p == 3) 
            {
                if (nr == 2)
                {
                    r2.Text = V1.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Lime; corect = true;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V1.FillColor = Color.Green;

                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V1.FillColor = Color.Green;
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V1.FillColor = Color.Green;
                    }
                    else if (v == 5)
                    {
                        V1.FillColor = Color.Yellow; V1.ForeColor = Color.Red;
                    }
                }
                else if (nr == 4)
                {
                    r4.Text = V2.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V2.FillColor = Color.Green;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Lime; corect = true;


                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V2.FillColor = Color.Green;

                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V2.FillColor = Color.Green;


                    }
                    else if (v == 5)
                    {
                        V2.FillColor = Color.Yellow; V2.ForeColor = Color.Red;

                    }
                }
                else if (nr == 3)
                {
                    r3.Text = V3.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V3.FillColor = Color.Green;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V3.FillColor = Color.Green;
                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Lime; corect = true;
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V3.FillColor = Color.Green;
                    }
                    else if (v == 5)
                    {
                        V3.FillColor = Color.Yellow; V3.ForeColor = Color.Red;
                    }
                }
                else if (nr == 1 || nr == 5)
                {
                    if (nr == 1) r1.Text = V4.Text;
                    else if (nr == 5) r5.Text = V4.Text;


                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V4.FillColor = Color.Green;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V4.FillColor = Color.Green;
                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V4.FillColor = Color.Green;
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Lime; corect = true;

                    }
                    else if (v == 5)
                    {
                        V4.FillColor = Color.Yellow; V4.ForeColor = Color.Red;
                    }

                }
            }else if (p == 7)
            {
                if (nr==1||nr == 2)
                {
                    if (nr == 1) r1.Text = V1.Text;
                    else if (nr == 2) r2.Text = V1.Text;


                    if (v == 1)
                    {
                        V1.FillColor = Color.Lime; corect = true;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V1.FillColor = Color.Green;

                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V1.FillColor = Color.Green;
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V1.FillColor = Color.Green;
                    }
                    else if (v == 5)
                    {
                        V1.FillColor = Color.Yellow; V1.ForeColor = Color.Red;
                    }
                }
                else if (nr == 3)
                {
                    r3.Text = V2.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V2.FillColor = Color.Green;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Lime; corect = true;


                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V2.FillColor = Color.Green;

                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V2.FillColor = Color.Green;


                    }
                    else if (v == 5)
                    {
                        V2.FillColor = Color.Yellow; V2.ForeColor = Color.Red;

                    }
                }
                else if (nr == 5||nr==6)
                {
                    if(nr==5)r5.Text = V3.Text;
                    else if(nr==6) r6.Text = V3.Text;

                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V3.FillColor = Color.Green;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V3.FillColor = Color.Green;
                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Lime; corect = true;
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Red; V3.FillColor = Color.Green;
                    }
                    else if (v == 5)
                    {
                        V3.FillColor = Color.Yellow; V3.ForeColor = Color.Red;
                    }
                }
                else if (nr==4)
                {
                    r4.Text = V4.Text;


                    if (v == 1)
                    {
                        V1.FillColor = Color.Red; V4.FillColor = Color.Green;
                    }
                    else if (v == 2)
                    {
                        V2.FillColor = Color.Red; V4.FillColor = Color.Green;
                    }
                    else if (v == 3)
                    {
                        V3.FillColor = Color.Red; V4.FillColor = Color.Green;
                    }
                    else if (v == 4)
                    {
                        V4.FillColor = Color.Lime; corect = true;

                    }
                    else if (v == 5)
                    {
                        V4.FillColor = Color.Yellow; V4.ForeColor = Color.Red;
                    }

                }
            }





            Color c = new Color();




            if (v == 5)
            {
                if (nr == 1) { rasp1.Text = "-"; rasp1.ForeColor = Color.Yellow; }
                else if (nr == 2) { rasp1.Text = "-"; rasp1.ForeColor = Color.Yellow; }
                else if (nr == 3) { rasp1.Text = "-"; rasp1.ForeColor = Color.Yellow; }
                else if (nr == 4) { rasp1.Text = "-"; rasp1.ForeColor = Color.Yellow; }
                else if (nr == 5) { rasp1.Text = "-"; rasp1.ForeColor = Color.Yellow; }
                else if (nr == 6) { rasp1.Text = "-"; rasp1.ForeColor = Color.Yellow; }
                else if (nr == 7) { rasp1.Text = "-"; rasp1.ForeColor = Color.Yellow; }
            }else
            {
                if (v == 1) { c = V1.FillColor;rasp = V1.Text; }
                else if (v == 2) { c = V2.FillColor; rasp = V2.Text; }
                else if (v == 3) { c = V3.FillColor;rasp = V3.Text; }
                else if (v == 4) { c = V4.FillColor;rasp = V4.Text; }

                if (nr == 1) { rasp1.ForeColor = c;rasp1.Text = rasp; }
                else if(nr==2) { rasp2.ForeColor = c; rasp2.Text = rasp; }
                else if (nr == 3) { rasp3.ForeColor = c; rasp3.Text = rasp; }
                else if (nr == 4) { rasp4.ForeColor = c; rasp4.Text = rasp; }
                else if (nr == 5) { rasp5.ForeColor = c; rasp5.Text = rasp; }
                else if (nr == 6) { rasp6.ForeColor = c; rasp6.Text = rasp; }
                else if (nr == 7) { rasp7.ForeColor = c; rasp7.Text = rasp; }

            }







            if (v == 5)
            {
                omise++;
                not1.BackColor = Color.Goldenrod;
                xulet.BackgroundImage = Properties.Resources.x_button__3_;
                shownicon.BackgroundImage = Properties.Resources.dece;
                lblMsg.Text = "Nici măcar nu ai încercat!";
            }
            else
            {
                if (corect == true)
                {
                    corecte++;
                    not1.BackColor = Color.Green;
                    xulet.BackgroundImage = Properties.Resources.x_button;
                    shownicon.BackgroundImage = Properties.Resources.approved;
                    lblMsg.Text = "Bravo!";
                }
                else if (corect == false)
                {
                    gresite++;
                    not1.BackColor = Color.DarkRed;
                  
                    xulet.BackgroundImage = Properties.Resources.x_button__1_;
                    shownicon.BackgroundImage = Properties.Resources.approved;
                    lblMsg.Text = "Mai încearcă!";
                }
            }
            not1.Visible = true;
            not1.Top = 0;
            not1.Left = 0;

        }

        void navigare()
        {
            V1.FillColor = V2.FillColor = V3.FillColor = V4.FillColor = Color.FromArgb(35, 60, 79);
            V1.ForeColor = V2.ForeColor = V3.ForeColor = V4.ForeColor = Color.White;
            aspect = true;
            Next.Visible = false;
            not1.Visible = false;
            V1.Animated = V2.Animated = V3.Animated = V4.Animated = true;
            merge_cronometrul = true;
            if (p == 1)
            {
                if (nr == 1)
                {
                    q1.Text=qlabel.Text = "In ce curent se incadreaza opera ,,Ultima noapte de dragoste,întâia noapte de război’’?";
                    V1.Text = "Realismul"; V2.Text = "Simbolismul"; V3.Text = "Modernismul"; V4.Text = "Traditionalismul";

                }else if (nr == 2)
                {
                    q2.Text=qlabel.Text = "Cum se numesc cei doi unchi ai lui Ştefan Gheorghidiu?";
                    V1.Text = "Lumânăraru si Grigoriade";V2.Text = "Tache si Lumânăraru";V3.Text = "Nae si Tache";V4.Text = "Grigoriade si Nae";

                }else if (nr == 3)
                {
                    q3.Text=qlabel.Text = "Care este tema dominanta in romanul .,,Ultima noapte de dragoste,întâia noapte război’’?";
                    V1.Text = "iubirea";V2.Text = "inadaptarea intelectualului la o lume a mediocrității";V3.Text = "pacea si razboiul";V4.Text = "tema trecerii timpului";

                }else if (nr == 4)
                {
                    q4.Text=qlabel.Text = "Ce tip de narator intalnim in opera ,,Ultima noapte de dragoste,întâia noapte de război’’ ?";
                    V1.Text = "narator-personaj"; V2.Text = "narator obiectiv";V3.Text = "narator martor";V4.Text = "alt raspuns";
                }else if (nr == 5)
                {
                    q5.Text=qlabel.Text = "Care este numele capitolului cu care debuteaza cartea?";
                    V1.Text = "ultima noapte de dragoste";V2.Text = "E tot filosofie";V3.Text = "Diagonalele unui testament";V4.Text = "La piatra Craiului, in munte";
                }else if (nr == 6)
                {
                    q6.Text=qlabel.Text = "Cum se numeste capitolul ce are rolul de deznodamant?";
                    V1.Text = "Intaia noapte de razboi"; V2.Text = "Wer kann rumanien retten?"; V3.Text = "Ne-a acoperit pamantul lui dumnezeu"; V4.Text = "Intamplari pe apa Oltului";
                }else if (nr == 7)
                {
                    merge_cronometrul = false;
                    panel_test.Visible = false;
                    punctaj=(double)Math.Round((double)(corecte * 100) /6);
                    afis_rezulatate();

                    if (corecte == 6)
                    {
                        motivator = "Puncataj : 100/100" + '\n' + "Meriti acest premiu!";

                        this.Alert("Final", Form_Alert.enmType.Perfect);
                    }
                    else
                    {
                        motivator = "Punctaj:" + Convert.ToString(corecte) + "/6";
                        this.Alert("Final", Form_Alert.enmType.Final);
                    }
                }

            }else if (p == 2)
            {
                if (nr == 1)
                {
                    q1.Text=qlabel.Text = "In ce an a fost publicata opera “Patul lui Procust?”";
                    V1.Text = "1930";V2.Text = "1931";V3.Text = "1932";V4.Text = "1933";
                }else if (nr == 2)
                {
                    q2.Text=qlabel.Text = "La ce face referie titlul operei “Patul lui Procust”?";
                    V1.Text = "o legenda din mitologia greaca";V2.Text = "o legenda din mitologia romana";V3.Text = "o legenda din mitologia romaneasca";V4.Text = "un mit";
                }else if (nr == 3)
                {
                    q3.Text=qlabel.Text = "Care este legatura dintre titlu si roman? ";
                    V1.Text = "o renastere a legendei din mitologia greaca";V2.Text = "ilustreaza o societate ca un spatiu limitat";V3.Text = "o metoda de tortura ";V4.Text = "alt raspuns";
                }else if (nr == 4)
                {
                    q4.Text=qlabel.Text = "Printre protaginisti se numara:";
                    V1.Text = "Emilia Răchitaru";V2.Text = "Fred Vasilescu";V3.Text = "George Demetriu Ladima";V4.Text = "toate raspunsurile sunt corecte";
                }else if (nr == 5)
                {
                    q5.Text=qlabel.Text = "Care este personajul absent din roman?";
                    V1.Text = "Emilia Răchitaru";V2.Text = "George Demetriu Ladima";V3.Text = "Fred Vasilescu";V4.Text = "niciun raspuns nu este correct";
                }else if (nr == 6)
                {
                   q6.Text= qlabel.Text = "Ce tip de personaj este Ladima?";
                  V1.Text = "avar";V2.Text = "ipocrit"; V3.Text = "intelectual lucid"; V4.Text = "demagog";
                }else if (nr == 7)
                {
                    merge_cronometrul = false;
                    panel_test.Visible = false;
                    punctaj = (double)Math.Round((double)(corecte * 100) / 6);
                    afis_rezulatate();

                    if (corecte == 6)
                    {
                        motivator = "Puncataj : 100/100" + '\n' + "Meriti acest premiu!";

                        this.Alert("Final", Form_Alert.enmType.Perfect);
                    }
                    else
                    {
                        motivator = "Punctaj:" + Convert.ToString(corecte) + "/6";
                        this.Alert("Final", Form_Alert.enmType.Final);
                    }
                }
            }else if (p == 4)
            {
                if (nr == 1)
                {
                    q1.Text=qlabel.Text = "Ce tip de roman este opera “Rascoala” scrisa de Liviu Rebreanu ?";
                    V1.Text = "roman traditional";V2.Text = "roman realist";V3.Text = "roman modernist";V4.Text = "roman de introspectia";
                }else if (nr == 2)
                {
                    q2.Text = qlabel.Text = "Din ce eveniment real s-a inspirit autorul Liviu Rebreanu?";
                    V1.Text = "Revolutiile Pasoptiste";V2.Text = "Revolutia Rusa din 1905-1907";V3.Text = "Răscoala Țărănească din 1907";V4.Text = "niciun raspuns nu este corect";
                }else if (nr == 3)
                {
                    q3.Text = qlabel.Text = "In romanul “Rascoala”, pamantul implica …";
                    V1.Text = "o sursa de venit";V2.Text = "un statut social";V3.Text = "stabilitatea si siguranta";V4.Text = "toate raspunsurile sunt corecte";
                }else if (nr == 4)
                {
                    q4.Text = qlabel.Text = "Ce se afla in nucleul romanului scris de Liviu Rebreanu";
                    V1.Text = "pamantul";V2.Text = "mosiile";V3.Text = "goana dupa avere";V4.Text = "relatiile dintre paturile sociale";
                }else if (nr == 5)
                {
                    q5.Text = qlabel.Text = "Care este planul/sunt planurile pe care universul romanului “Rascoala” evolueaza?";
                    V1.Text = "spatiul citadin ";V2.Text = "spatiul rural";V3.Text = "orașul-metropola si satul ";V4.Text = "niciun raspuns nu este corect";
                }else if (nr == 6)
                {
                    merge_cronometrul = false;
                    panel_test.Visible = false;
                    punctaj = (double)Math.Round((double)(corecte * 100) / 5);
                    afis_rezulatate();

                    if (corecte == 5)
                    {
                        motivator = "Puncataj : 100/100" + '\n' + "Meriti acest premiu!";

                        this.Alert("Final", Form_Alert.enmType.Perfect);
                    }
                    else
                    {
                        motivator = "Punctaj:" + Convert.ToString(corecte) + "/5";
                        this.Alert("Final", Form_Alert.enmType.Final);
                    }
                }
            }else if (p == 5)
            {
                if (nr == 1)
                {
                    q1.Text = qlabel.Text = "Care sunt cele doua curente literare prezente in opera ,,Enigma Otiliei”?";
                    V1.Text = "Realism si Traditionalism";V2.Text = "Modernism si Romantism";V3.Text = "Clasicism si Romantism";V4.Text = "Romantism si Traditionalism";
                }else if (nr == 2)
                {
                    q2.Text = qlabel.Text = "Al carui tip de roman  reprezinta o trasautra descrierea minutioasa a arhitecturii(ex: descriera strazii Antim,camera Otiliei ) ?";
                    V1.Text = "balzancian";V2.Text = "camilpetrescian";V3.Text = "de introspectia";V4.Text = "niciun raspuns nu este corect";
                }else if (nr == 3)
                {
                    q3.Text = qlabel.Text = "Ce tip de personaj este  Costache?";
                    V1.Text = "avarul";V2.Text = "avaristul";V3.Text = "maniacul";V4.Text = "maniacul in devenire";
                }else if (nr == 4)
                {
                    q4.Text = qlabel.Text = "Ce tip de personaj Stanica?";
                    V1.Text = "maniacul";  V2.Text = "avaristul"; V3.Text = "avarul"; V4.Text = "maniacul in devenire";

                }else if (nr == 5)
                {
                    q5.Text = qlabel.Text = "Ce tip de personaj este  Simion?";
                    V1.Text = "maniacul in devenire"; V2.Text = "avarul"; V3.Text = "avaristul"; V4.Text = "maniacul"; 

                }else if (nr == 6)
                {
                    q6.Text = qlabel.Text = "Ce tip de personaj este Titu?";
                    V1.Text = "avaristul"; V2.Text = "maniacul"; V3.Text = "avarul"; V4.Text = "maniacul in devenire";

                }else if (nr == 7)
                {
                    merge_cronometrul = false;
                    panel_test.Visible = false;
                    punctaj = (double)Math.Round((double)(corecte * 100) / 6);
                    afis_rezulatate();

                    if (corecte == 6)
                    {
                        motivator = "Puncataj : 100/100" + '\n' + "Meriti acest premiu!";

                        this.Alert("Final", Form_Alert.enmType.Perfect);
                    }
                    else
                    {
                        motivator = "Punctaj:" + Convert.ToString(corecte) + "/6";
                        this.Alert("Final", Form_Alert.enmType.Final);
                    }
                }
            
            
            }else if (p == 6)
            {
                if (nr == 1)
                {
                    q1.Text = qlabel.Text = "Ce tip de tehnica narativa este prezenta in opera “Maytrei” scrisa de Mircea Eliade?";
                    V1.Text = "tehnica narativa traditionala ";V2.Text = "tehnica narativa moderna";V3.Text = "tehnica narativa simbolista";V4.Text = "tehnica narativa realista";
                }else if (nr == 2)
                {
                    q2.Text = qlabel.Text = "Care este tema din opera “Maitreyi”?";
                    V1.Text = " iubirea ";V2.Text = "iubirea imposiblia";V3.Text = "conditia femeii";V4.Text = "toate variantele sunt corecte";
                }else if (nr == 3)
                {
                    q3.Text = qlabel.Text = "Ce tip de naratiune se regaseste in roman?";
                    V1.Text = "retrospectiva";V2.Text = "homodiegetica";V3.Text = "diegetica";V4.Text = "nicio varianta nu este corecta";
                }else if (nr == 4)
                {
                    q4.Text = qlabel.Text = "Care este spatiul in care actiunea se petrece in mod predominant?";
                    V1.Text = "Muntii Himalaya";V2.Text = "Singapore";V3.Text = "Caclcutta ";V4.Text = "New Delhi";
                }else if (nr == 5)
                {
                    q5.Text = qlabel.Text = "Cine este personajul-narator?";
                    V1.Text = "Allan ";V2.Text = "Maitreyi";V3.Text = "Domnul Sem ";V4.Text = "Doamna Sen";
                }else if (nr == 6)
                {
                    q6.Text = qlabel.Text = "Printre personajele secundare se numara?";
                    V1.Text = "Domnul si Doamna Sen";V2.Text = "Khokha ";V3.Text = "Chabbu";V4.Text = "toata variantele sunt corecte";
                }else if (nr == 7)
                {
                    merge_cronometrul = false;
                    panel_test.Visible = false;
                    punctaj = (double)Math.Round((double)(corecte * 100) / 6);
                    afis_rezulatate();

                    if (corecte == 6)
                    {
                        motivator = "Puncataj : 100/100" + '\n' + "Meriti acest premiu!";

                        this.Alert("Final", Form_Alert.enmType.Perfect);
                    }
                    else
                    {
                        motivator = "Punctaj:" + Convert.ToString(corecte) + "/6";
                        this.Alert("Final", Form_Alert.enmType.Final);
                    }
                }
            }else if (p == 3)
            {
                if (nr == 1)
                {
                    q1.Text = qlabel.Text = "Care este una dintre tematiciile romanului “Ion”?";
                    V1.Text = "iubirea";V2.Text = "societatea rurala";V3.Text = "tematica pamantului";V4.Text = "toate variantele sunt corecte";
                }else if (nr == 2)
                {
                    q2.Text = qlabel.Text = "In ce spatiu are rol actiunea din romanul “Ion” scris de Liviu Rebreanu?";
                    V1.Text = "mediul rural";V2.Text = "mediul citadin ";V3.Text = "atat in mediul rural, cat si in mediul citadin";V4.Text = "niciun raspuns nu este corect";
                }else if (nr == 3)
                {
                    q3.Text =qlabel.Text= "Ce include tehnica planurilor paralele?";
                    V1.Text = "aspecte din viata taranului";V2.Text = "aspecte din viata din mediul rural";V3.Text = "planul taranului si intelectualului";V4.Text = "niciun raspuns nu este corect";
                }else if (nr == 4)
                {
                    q4.Text = qlabel.Text = "In ce curent literar se incadreaza romanul “Ion”?";
                    V1.Text = "traditionalism";V2.Text = "realism";V3.Text = "modernism";V4.Text = "clasicism";

                }else if (nr == 5)
                {
                    q5.Text = qlabel.Text = "Ce scena formeaza miezul primului plan?";
                    V1.Text = "precum un țăran care săruta pământul";V2.Text = "o discuție despre pământ cu un vecin";V3.Text = "o relatare din care află că cea mai bogată fată din sat a păcătuit cu un fecior sărac";V4.Text = "toate variantele sunt corecte";
                    
                }else if (nr == 6)
                {
                    merge_cronometrul = false;
                    panel_test.Visible = false;
                    punctaj = (double)Math.Round((double)(corecte * 100) / 5);
                    afis_rezulatate();

                    if (corecte == 5)
                    {
                        motivator = "Puncataj : 100/100" + '\n' + "Meriti acest premiu!";

                        this.Alert("Final", Form_Alert.enmType.Perfect);
                    }
                    else
                    {
                        motivator = "Punctaj:" + Convert.ToString(corecte) + "/5";
                        this.Alert("Final", Form_Alert.enmType.Final);
                    }
                }
            
            
            
            
            }else if (p == 7)
            {
                if (nr == 1)
                {
                    q1.Text = qlabel.Text = "Care este modul de expunere predominat într-un roman?";
                    V1.Text = "narațiunea";V2.Text = "dialogul";V3.Text = "descrierea";V4.Text = "monologul";

                }else if (nr == 2)
                {
                    q2.Text = qlabel.Text = "Care este limba de proveniență a sensului actual al cuvântului ,,roman”?";
                    V1.Text = "engleza";V2.Text = "franceza";V3.Text = "latina";V4.Text = "alt raspuns";

                }else if (nr == 3)
                {
                    q3.Text = qlabel.Text = "Intr-un roman tradițional temele sunt generate de:";
                    V1.Text = "pamant";V2.Text = "existența social-istorică";V3.Text = "avere";V4.Text = "experiențe individuale";
                }else if (nr == 4)
                {
                    q4.Text = qlabel.Text = "Specific romanului este:";
                    V1.Text = "numărul mic de personaje";V2.Text = "întinderea spațială mică";V3.Text = "desfășurarea într-un singur plan narativ";V4.Text = "întinderea temporală mare";
                }else if (nr == 5)
                {
                    q5.Text = qlabel.Text = "Primul roman modern al literaturii române a fost:";
                    V1.Text = ",,Maitrey”";V2.Text = ",,Pădurea spânzuraților”";V3.Text = "„Ultima noapte de dragoste intaia noapte de razboi";V4.Text = ",,Moromeții”";
                }else if (nr == 6)
                {
                    q6.Text =qlabel.Text= "Acțiunea intr-un roman modern:";
                    V1.Text = "se înlănțuie logic si cronologic";V2.Text = "se intinde numai pe un fir narativ";V3.Text = "este discontinuă cu pauze descriptive și inserții";V4.Text = "alt raspuns";
                }else if (nr == 7)
                {
                    merge_cronometrul = false;
                    panel_test.Visible = false;
                    punctaj = (double)Math.Round((double)(corecte * 100) / 6);
                    afis_rezulatate();

                    if (corecte == 6)
                    {
                        motivator = "Puncataj : 100/100" + '\n' + "Meriti acest premiu!";

                        this.Alert("Final", Form_Alert.enmType.Perfect);
                    }
                    else
                    {
                        motivator = "Punctaj:" + Convert.ToString(corecte) + "/6";
                        this.Alert("Final", Form_Alert.enmType.Final);
                    }
                }
            } 
            
            quick = 1200;
        }

        private void panel_tabel_raspunsuri_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_tabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void home_rezultate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void raspunsuri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_rezultate.Visible = false;
        }

        private void exit_tabel_Click(object sender, EventArgs e)
        {
            panel_rezultate.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (merge_cronometrul == true)
            {
                if (quick > 0)
                {
                    quick--;
                    timp1.Text = Convert.ToString(quick / 60) + " secunde";
                    if (quick < 60) timp1.Text = "<o sucunda";
                    int nr;
                    nr = quick / 60;

                    //  timp.Text = Convert.ToString(nr + 1) + "s";
                    //    timp.Text = Convert.ToString(nr) + "s";
                    if (nr == 20||nr==19) timp1.ForeColor = Color.FromArgb(30, 208, 34);
                    else if (nr == 18||nr==17) timp1.ForeColor = Color.FromArgb(31, 208, 30);
                    else if (nr == 16||nr==15) timp1.ForeColor = Color.FromArgb(36, 208, 30);
                    else if (nr == 14) timp1.ForeColor = Color.FromArgb(42, 208, 30);
                    else if (nr == 13) timp1.ForeColor = Color.FromArgb(44, 208, 30);
                    else if (nr == 12||nr==11) timp1.ForeColor = Color.FromArgb(63, 208, 30);
                     else if (nr == 9 || nr == 10) timp1.ForeColor = Color.FromArgb(216, 196, 27);
                    else if (nr == 8 || nr == 7) timp1.ForeColor = Color.FromArgb(214, 194, 29);
                    else if (nr == 6 || nr == 5) timp1.ForeColor = Color.FromArgb(255, 131, 21);
                    else if (nr == 6 || nr == 4) timp1.ForeColor = Color.FromArgb(255, 92, 21);
                    else if (nr == 3) timp1.ForeColor = Color.FromArgb(255, 49, 21);
                    else if (nr == 2 || nr == 1) timp1.ForeColor = Color.FromArgb(255, 0, 0);

                }
                else if (quick == 0)
                {
                    timp1.Text = "TIMP EXPIRAT!";
                    v = 5;
                    corectare();
                }
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (nr == 1) panel_test.Visible = false;
            punctaj = 100.0;
        
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (nr == 1) panel_test.Visible = false;
            nr++;
        }

        private void V1_Click(object sender, EventArgs e)
        {

            if (aspect==true)
            {
                aspect = false;
                v = 1;
                corectare();
            }
        }

        private void V2_Click(object sender, EventArgs e)
        {
            if (aspect == true)
            {
                aspect = false;
                v = 2;
                corectare();
            }
        }

        private void V3_Click(object sender, EventArgs e)
        {
            if (aspect == true)
            {
                aspect = false;
                v = 3;
                corectare();
            }
        }

        private void V4_Click(object sender, EventArgs e)
        {
            if (aspect == true)
            {
                aspect = false;
                v = 4;
                corectare();
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            corecte = gresite = omise = 0;
            rasp1.ForeColor = rasp2.ForeColor = rasp3.ForeColor = rasp4.ForeColor = rasp5.ForeColor = rasp6.ForeColor = rasp7.ForeColor = rasp8.ForeColor = rasp9.ForeColor = rasp10.ForeColor = Color.FromArgb(27, 55, 82);


          
            panel_test.Visible = true;
            
            nr = 1;
            navigare();
        }

        private void panel_test_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_notificare1_Tick(object sender, EventArgs e)
        {
            if (not1.Location.X <= 550) this.not1.Left++;
            else if (not1.Location.X > 550)
            {
                this.not1.Left += 5;
            }

        }

        private void not1_Click(object sender, EventArgs e)
        {
            not1.Visible = false;
        }

        private void poza1_Click(object sender, EventArgs e)
        {
            corecte = gresite = omise = 0; rasp1.ForeColor = rasp2.ForeColor = rasp3.ForeColor = rasp4.ForeColor = rasp5.ForeColor = rasp6.ForeColor = rasp7.ForeColor = rasp8.ForeColor = rasp9.ForeColor = rasp10.ForeColor = Color.FromArgb(27, 55, 82);
            q7.Visible = rasp7.Visible = r7.Visible = q8.Visible = rasp8.Visible = r8.Visible = q9.Visible = rasp9.Visible = r9.Visible = q10.Visible = rasp10.Visible = r10.Visible = false;
            r6.Visible = rasp6.Visible = q6.Visible = true;
            aspect = true;
            coperta.BackgroundImage = Properties.Resources.coperta1;
            panel_romane.Visible = false;
            nr = 1; p = 1;
            navigare();
        }

        private void poza2_Click(object sender, EventArgs e)
        {
            corecte = gresite = omise = 0; 
            rasp1.ForeColor = rasp2.ForeColor = rasp3.ForeColor = rasp4.ForeColor = rasp5.ForeColor = rasp6.ForeColor = rasp7.ForeColor = rasp8.ForeColor = rasp9.ForeColor = rasp10.ForeColor = Color.FromArgb(27, 55, 82);
            rasp7.Visible = r7.Visible = q7.Visible = rasp8.Visible = q8.Visible = r8.Visible = rasp9.Visible = r9.Visible = q9.Visible = rasp10.Visible = r10.Visible = q10.Visible = false;
            r6.Visible = rasp6.Visible = q6.Visible = true;
            aspect = true;
            coperta.BackgroundImage = Properties.Resources.coperta2;
            panel_romane.Visible = false;
            nr = 1; p = 2;
            navigare();
        }

        private void poza3_Click(object sender, EventArgs e)
        {
            corecte = gresite = omise = 0; rasp1.ForeColor = rasp2.ForeColor = rasp3.ForeColor = rasp4.ForeColor = rasp5.ForeColor = rasp6.ForeColor = rasp7.ForeColor = rasp8.ForeColor = rasp9.ForeColor = rasp10.ForeColor = Color.FromArgb(27, 55, 82);
            r6.Visible = rasp6.Visible = q6.Visible = rasp7.Visible = r7.Visible = q7.Visible = rasp8.Visible = q8.Visible = r8.Visible = rasp9.Visible = r9.Visible = q9.Visible = rasp10.Visible = r10.Visible = q10.Visible = false;
            
            aspect = true;
            coperta.BackgroundImage = Properties.Resources.coperta3;
            panel_romane.Visible = false;
            nr = 1; p = 3;
            navigare();
        }

        private void poza4_Click(object sender, EventArgs e)
        {
            rasp6.Visible = q6.Visible = r6.Visible = rasp7.Visible = r7.Visible = q7.Visible = rasp8.Visible = q8.Visible = r8.Visible = rasp9.Visible = r9.Visible = q9.Visible = rasp10.Visible = r10.Visible = q10.Visible = false;

            corecte = gresite = omise = 0; rasp1.ForeColor = rasp2.ForeColor = rasp3.ForeColor = rasp4.ForeColor = rasp5.ForeColor = rasp6.ForeColor = rasp7.ForeColor = rasp8.ForeColor = rasp9.ForeColor = rasp10.ForeColor = Color.FromArgb(27, 55, 82);

            aspect = true;
            coperta.BackgroundImage = Properties.Resources.coperta4;
            panel_romane.Visible = false;
            nr = 1; p = 4;
            navigare();

        }

        private void poza5_Click(object sender, EventArgs e)
        {
            corecte = gresite = omise = 0; rasp1.ForeColor = rasp2.ForeColor = rasp3.ForeColor = rasp4.ForeColor = rasp5.ForeColor = rasp6.ForeColor = rasp7.ForeColor = rasp8.ForeColor = rasp9.ForeColor = rasp10.ForeColor = Color.FromArgb(27, 55, 82);
            rasp7.Visible = r7.Visible = q7.Visible = rasp8.Visible = q8.Visible = r8.Visible = rasp9.Visible = r9.Visible = q9.Visible = rasp10.Visible = r10.Visible = q10.Visible = false;
            r6.Visible = rasp6.Visible = q6.Visible = true;
            coperta.BackgroundImage = Properties.Resources.coperta5;
            panel_romane.Visible = false;
            nr = 1; p = 5;
            navigare();

        }

        private void intrebari_generale_Click(object sender, EventArgs e)
        {
            q7.Visible = rasp7.Visible = r7.Visible = q8.Visible = rasp8.Visible = r8.Visible = q9.Visible = rasp9.Visible = r9.Visible = q10.Visible = rasp10.Visible = r10.Visible = false;
            r6.Visible = rasp6.Visible = q6.Visible = true;
            coperta.Visible = false;
            
            p = 7;nr = 1;
            navigare();
            panel_choice.Visible = false;
            panel_romane.Visible = false;

        }

        private void intrebari_romane_Click(object sender, EventArgs e)
        {
            coperta.Visible = true;
            panel_choice.Visible = false;
        }

        private void exit_romane_Click(object sender, EventArgs e)
        {
            panel_choice.Visible = true;
        }

        private void poza6_Click(object sender, EventArgs e)
        {
            corecte = gresite = omise = 0; rasp1.ForeColor = rasp2.ForeColor = rasp3.ForeColor = rasp4.ForeColor = rasp5.ForeColor = rasp6.ForeColor = rasp7.ForeColor = rasp8.ForeColor = rasp9.ForeColor = rasp10.ForeColor = Color.FromArgb(27, 55, 82);
            rasp7.Visible = r7.Visible = q7.Visible = rasp8.Visible = q8.Visible = r8.Visible = rasp9.Visible = r9.Visible = q9.Visible = rasp10.Visible = r10.Visible = q10.Visible = false;
            r6.Visible = rasp6.Visible = q6.Visible = true;
            coperta.BackgroundImage = Properties.Resources.coperta6;
            panel_romane.Visible = false;
            nr = 1; p = 6;
            navigare();

        }

        private void Next_Click(object sender, EventArgs e)
        {
            nr++;
            navigare();
            
        }

        private void panel_romane_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
