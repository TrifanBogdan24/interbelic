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
    public partial class Form4 : Form
    {
        string sir;
        private int quick2 = 1200; //o secunda = 60
        bool merge_cronometrul2 = false;
        bool merge_notificarea = false;
        int q;
        int timp=0;
        int ce_fac;
        int punctaj;
        bool[] contor = new bool[200];
        bool[] rezolvate = new bool[200];
        string[] citat = new string[200];
        int[] raspunsuri = new int[200];
        int potrivirecit1, potrivirecit2, potrivirecit3, potrivirecit4,potrivirecit5, potrivireb1, potrivireb2, potrivireb3, potrivireb4;
        int[] rasp_cit = new int[20];
        int col1,col2;

        int nr1, nr2, nr3, nr4,nr5;
        //1(Otilia),2(Undd),3(Maytrei),4(Ion)

        public Form4()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.literature_icon;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            et1.Visible = et2.Visible = et3.Visible =et4.Visible= false;punctaj = 0;
            rezolvate[1] = rezolvate[2] = rezolvate[3] = rezolvate[4] = rezolvate[5] = rezolvate[6] = rezolvate[7] = rezolvate[8] = rezolvate[9] = rezolvate[10] = rezolvate[11] = rezolvate[12] = rezolvate[13] = rezolvate[14] = rezolvate[15] = rezolvate[16] = rezolvate[17] = rezolvate[18] = rezolvate[19] = rezolvate[20] = false;
            contor[1] = contor[2] = contor[3] = contor[4] = contor[5] = contor[6] = contor[7] = contor[8] = contor[9] = contor[10] = contor[11] = contor[12] = contor[13] = contor[14] = contor[15] = contor[16] = contor[17] = contor[18] = contor[19] = contor[20] = false;
            citat[1] = ",,Pentru o fată, reuşita în viaţă nu e o chestiune de studiu şi de energie. Rostul femeii este să placă, afară de asta nu poate fi fericire.”";raspunsuri[1] = 1;
            citat[2] = "„Dragostea nu ajunge în viaţă. Dragostea e numai adaosul. Altceva e temelia.”";raspunsuri[2] = 4;
            citat[3] = "„Azi, pe când îi povesteam destrăbălările fetelor din Europa, ea m-a întrebat dacă sunt pur, și numai gândul că s-ar putea să nu fiu a înspăimântat-o într-atât, încât a început să plângă”";raspunsuri[3] = 3;
            citat[4] = "„Inert, ca un manechin, și dezgustat, mă lăsam sărutat de buze fade, iar ei erau așa de plini de bucuria lor, că nici nu băgau de seamă dezgustul meu.”";raspunsuri[4] = 2;
            citat[5] = "„Iubirea are totdeauna un scop egoist. De aceea, în sfârşit, îţi lasă un gol în suflet.";raspunsuri[5] = 4;
            citat[6] = "„Tot ce s-a făcut mare în lumea asta, prin femei s-a făcut. Curtezane, nu femeile de treabă, au stimulat geniile.”";raspunsuri[6] = 1;
            citat[7]= "„Înțelesei pentru a suta oară că mă atrăgea altceva în Maitreyi: iraționalul ei, virginitatea ei barbară și, mai presus de toate, fascinul ei. Îmi lămurii perfect aceasta; că eram vrăjit, nu îndrăgostit.”";raspunsuri[7] = 3;
            citat[8] = "„ Mai plăcut e să-ţi aduci aminte fericiri trecute, decât ca după o tinereţe uscată să ai târziu ceea ce n-ai avut la vreme.”";raspunsuri[8] = 1;
            citat[9] = "„Îmi scria: „Cum te-aș putea eu pierde pe tine, când tu ești soarele meu, când razele tale mă încălzesc pe drumul acesta de țară? Cum să uit eu soarele?”";raspunsuri[9] = 3;
            citat[10] = "„O iubire mare e mai curând un proces de autosugestie, trebuie timp și trebuie complicitate pentru formarea ei.”";raspunsuri[10] = 2;

            restart.Cursor = home_rezultate.Cursor = carte1.Cursor =  carte1.Cursor = carte3.Cursor =carte2.Cursor=  carte4.Cursor = citat1.Cursor = citat2.Cursor = citat3.Cursor = citat4.Cursor = citat5.Cursor = volume_potriviri.Cursor = Cursors.Hand;
            panel_potriviri.BackgroundImage = Properties.Resources.back_portiviri;

          
            carte1.BackgroundImage = Properties.Resources.potrivire_roman5;
            carte2.BackgroundImage = Properties.Resources.potrivire_roman1;
            carte3.BackgroundImage = Properties.Resources.potrivire_roman6;
            carte4.BackgroundImage = Properties.Resources.potrivire_roman3;

            potrivireb1 = 1;potrivireb2 = 2;potrivireb3 = 3;potrivireb4 = 4;

            citat1.Text = citat[1];potrivirecit1 = raspunsuri[1];contor[1] = true;nr1 = 1;
            citat2.Text = citat[2];potrivirecit2 = raspunsuri[2];contor[2] = true;nr2 = 2;
            citat3.Text = citat[3];potrivirecit3 = raspunsuri[3];contor[3] = true;nr3 = 3;
            citat4.Text = citat[4];potrivirecit4 = raspunsuri[4];contor[4] = true;nr4 = 4;
            citat5.Text = citat[5]; potrivirecit5 = raspunsuri[5]; contor[5] = true;nr5 = 5;
            
            
            volume_potriviri.Visible = false;

            timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 1;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Enabled = true;


           //
            volume_potriviri.BackgroundImage = Properties.Resources.soundon;
            //


            restart.BackgroundImage = Properties.Resources.restart;
            home_rezultate.BackgroundImage = Properties.Resources.homepage;



            punctaj = 0;punctajpotriviri.Text = "0 puncte";

            timer_notificari_adauga = new System.Windows.Forms.Timer();
            timer_notificari_adauga.Interval = 1;
            timer_notificari_adauga.Tick += new EventHandler(timer_notificari_adauga_Tick);
            timer_notificari_adauga.Enabled = true;


            adauga.Visible = false;
            adauga.Top = 0;
            adauga.Left = 0-125;
            ce_fac = 1;




           

            merge_cronometrul2 = true;
            quick2 = 20 * 60;

        }

        int renew()
        {
            for (int i = 1; i <= 10; i++)
                if (contor[i] == false) return i;
            return -1;
        }
        void corectare()
        {
            if (col1 != 0 && col2 != 0)
            {
                

                if (col1 == col2)
                {
                    punctaj += 10;
                    if (punctaj >= 20) punctajpotriviri.Text = Convert.ToString(punctaj) + " de puncte";
                    else punctajpotriviri.Text = Convert.ToString(punctaj) + " puncte";
                    adauga.Visible = true;
                    adauga.Top = 0;
                    adauga.Left = 0 - 125;
                    ce_fac = 1;
                    quick2 += 10 * 60;

                    if (citat1.ForeColor != Color.Black)
                    {
                        contor[nr1] = true;
                        nr1 = renew();
                  //      MessageBox.Show(Convert.ToString(nr1));
                        if (nr1 == -1) citat1.Visible = false;
                        else
                        {
                            citat1.Text = citat[nr1]; potrivirecit1 = raspunsuri[nr1]; contor[nr1] = true;
                        }
                    }else if (citat2.ForeColor != Color.Black)
                    {
                        contor[nr2] = true;
                        nr2 = renew();
                        if (nr2 == -1) citat2.Visible = false;
                        else
                        {
                            citat2.Text = citat[nr2]; potrivirecit2 = raspunsuri[nr2]; contor[nr2] = true;
                        }
                    }
                    else if (citat3.ForeColor != Color.Black)
                    {
                        contor[nr3] = true;
                        nr3 = renew();
                        if (nr3 == -1) citat3.Visible = false;
                        else
                        {
                            citat3.Text = citat[nr3]; potrivirecit3 = raspunsuri[nr3]; contor[nr3] = true;
                        }

                    }
                    else if (citat4.ForeColor != Color.Black)
                    {
                        contor[nr4] = true;
                        nr4 = renew();
                        if (nr4 == -1) citat4.Visible = false;
                        else
                        {
                            citat4.Text = citat[nr4]; potrivirecit4 = raspunsuri[nr4]; contor[nr4] = true;
                        }
                    }
                    else if (citat5.ForeColor != Color.Black)
                    {
                        contor[nr5] = true;
                        contor[nr5] = true;
                        nr5 = renew();
                        if (nr5 == -1) citat5.Visible = false;
                        else
                        {
                            citat5.Text = citat[nr5]; potrivirecit5 = raspunsuri[nr5]; contor[nr5] = true;
                        }
                    }

                    if (punctaj == 100)
                    {
                        scor1.Visible = scorobt.Visible = trofeu.Visible = perc.Visible = false;
                        panel_potriviri.Visible = false;
                        perc.Visible = trofeu.Visible = true; panel_rezultate.BackgroundImage = Properties.Resources.podium; 
                             merge_cronometrul2 = false;
                    }


                }
                citat1.ForeColor = citat2.ForeColor = citat3.ForeColor = citat4.ForeColor = citat5.ForeColor = Color.Black;
                et1.Visible = et2.Visible = et3.Visible = et4.Visible = false;
                col1 = col2 = 0;
            }
        }

        private void citat2_Click(object sender, EventArgs e)
        {
            citat1.ForeColor = citat2.ForeColor = citat3.ForeColor = citat4.ForeColor = citat5.ForeColor = Color.Black;
            citat2.ForeColor = Color.FromArgb(22, 18, 126);
            col1 = potrivirecit2;
            corectare();
        }

        private void carte2_Click(object sender, EventArgs e)
        {
            et1.Visible = et2.Visible = et3.Visible = et4.Visible = false;
            et2.Visible = true;
            col2 = 2;
            corectare();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            panel_potriviri.Visible = true;
            et1.Visible = et2.Visible = et3.Visible = et4.Visible = false; punctaj = 0;
            rezolvate[1] = rezolvate[2] = rezolvate[3] = rezolvate[4] = rezolvate[5] = rezolvate[6] = rezolvate[7] = rezolvate[8] = rezolvate[9] = rezolvate[10] = rezolvate[11] = rezolvate[12] = rezolvate[13] = rezolvate[14] = rezolvate[15] = rezolvate[16] = rezolvate[17] = rezolvate[18] = rezolvate[19] = rezolvate[20] = false;
            contor[1] = contor[2] = contor[3] = contor[4] = contor[5] = contor[6] = contor[7] = contor[8] = contor[9] = contor[10] = contor[11] = contor[12] = contor[13] = contor[14] = contor[15] = contor[16] = contor[17] = contor[18] = contor[19] = contor[20] = false;
            citat1.Text = citat[1]; potrivirecit1 = raspunsuri[1]; contor[1] = true; nr1 = 1;
            citat2.Text = citat[2]; potrivirecit2 = raspunsuri[2]; contor[2] = true; nr2 = 2;
            citat3.Text = citat[3]; potrivirecit3 = raspunsuri[3]; contor[3] = true; nr3 = 3;
            citat4.Text = citat[4]; potrivirecit4 = raspunsuri[4]; contor[4] = true; nr4 = 4;
            citat5.Text = citat[5]; potrivirecit5 = raspunsuri[5]; contor[5] = true; nr5 = 5;
            citat1.Visible = citat2.Visible = citat3.Visible = citat4.Visible = citat5.Visible = true;
            punctaj = 0;punctajpotriviri.Text = "0 puncte";
            merge_cronometrul2 = true;
            
            quick2 = 20 * 60;
        }

        private void home_rezultate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void citat3_Click(object sender, EventArgs e)
        {
            citat1.ForeColor = citat2.ForeColor = citat3.ForeColor = citat4.ForeColor = citat5.ForeColor = Color.Black;
            citat3.ForeColor = Color.FromArgb(22, 18, 126);
            col1 = potrivirecit3;
            corectare();
        }

        private void citat4_Click(object sender, EventArgs e)
        {
            citat1.ForeColor = citat2.ForeColor = citat3.ForeColor = citat4.ForeColor = citat5.ForeColor = Color.Black;
            citat4.ForeColor = Color.FromArgb(22, 18, 126);
            col1 = potrivirecit4;
            corectare();
        }

        private void carte1_Click(object sender, EventArgs e)
        {
            et1.Visible = et2.Visible = et3.Visible = et4.Visible = false;
            et1.Visible = true;
            col2 = 1;
            corectare();
        }

        private void et2_Click(object sender, EventArgs e)
        {

        }

        private void carte3_Click(object sender, EventArgs e)
        {
            et1.Visible = et2.Visible = et3.Visible = et4.Visible = false;
            et3.Visible = true;
            col2 = 3;
            corectare();
        }

        private void carte4_Click(object sender, EventArgs e)
        {
            et1.Visible = et2.Visible = et3.Visible = et4.Visible = false;
            et4.Visible = true;
            col2 = 4;
            corectare();
        }

        private void citat5_Click(object sender, EventArgs e)
        {
            citat1.ForeColor = citat2.ForeColor = citat3.ForeColor = citat4.ForeColor = citat5.ForeColor = Color.Black;
            citat5.ForeColor = Color.FromArgb(22, 18, 126);
            col1 = potrivirecit5;
            corectare();
        }

        private void citat1_Click(object sender, EventArgs e)
        {

            citat1.ForeColor = citat2.ForeColor = citat3.ForeColor = citat4.ForeColor = citat5.ForeColor = Color.Black;
            citat1.ForeColor = Color.FromArgb(22, 18, 126);
            sir = citat1.Text;
            col1 = potrivirecit1;
            corectare();


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (merge_cronometrul2 == true)
            {
                if (quick2 > 0)
                {
                    quick2--;
                    timp2.Text = Convert.ToString(quick2 / 60) + " secunde";
                    if (quick2 < 60) timp2.Text = "<o sucunda";
                    int nr;
                    nr = quick2 / 60;

                    //  timp.Text = Convert.ToString(nr + 1) + "s";
                    //    timp.Text = Convert.ToString(nr) + "s";
                    if (nr == 20 || nr == 19||nr>20) timp2.ForeColor = Color.FromArgb(30, 208, 34);
                    else if (nr == 18 || nr == 17) timp2.ForeColor = Color.FromArgb(31, 208, 30);
                    else if (nr == 16 || nr == 15) timp2.ForeColor = Color.FromArgb(36, 208, 30);
                    else if (nr == 14) timp2.ForeColor = Color.FromArgb(42, 208, 30);
                    else if (nr == 13) timp2.ForeColor = Color.FromArgb(44, 208, 30);
                    else if (nr == 12 || nr == 11) timp2.ForeColor = Color.FromArgb(63, 208, 30);
                    else if (nr == 9 || nr == 10) timp2.ForeColor = Color.FromArgb(216, 196, 27);
                    else if (nr == 8 || nr == 7) timp2.ForeColor = Color.FromArgb(214, 194, 29);
                    else if (nr == 6 || nr == 5) timp2.ForeColor = Color.FromArgb(255, 131, 21);
                    else if (nr == 6 || nr == 4) timp2.ForeColor = Color.FromArgb(255, 92, 21);
                    else if (nr == 3) timp2.ForeColor = Color.FromArgb(255, 49, 21);
                    else if (nr == 2 || nr == 1) timp2.ForeColor = Color.FromArgb(255, 0, 0);

                }
                else if (quick2 == 0)
                {
                    timp2.Text = "TIMP EXPIRAT!";
                    scor1.Visible = scorobt.Visible = trofeu.Visible = perc.Visible = false;
                    panel_potriviri.Visible = false;

                    if (punctaj >= 20) scor1.Text = Convert.ToString(punctaj) + " de puncte";
                    else scor1.Text = Convert.ToString(punctaj) + " puncte";
                    scorobt.Visible = scor1.Visible = true; panel_rezultate.BackgroundImage = Properties.Resources.purple;
                    merge_cronometrul2 = false;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            et1.Visible = et2.Visible = et3.Visible = et4.Visible = false;
            et2.Visible = true;
            col2 = 2;
        }

        private void timer_notificari_adauga_Tick(object sender, EventArgs e)
        {

            if (ce_fac == 1)
            {
                if (adauga.Location.X <= 0) { this.adauga.Left++; timp = 2 * 60; }
                else ce_fac = 2;
            }else if (ce_fac == 2)
            {
                timp--;
                if (timp <= 0) { this.adauga.Left--; }
            }
          
            else
            {

                timp--;
                if(timp<=0) this.adauga.Left -= 5;
            }
            /**
            else if (adauga.Location.X > 160)
            {
                this.adauga.Left += 100;
               
            }
            **/

        }

        private void adaug_puncte_Click(object sender, EventArgs e)
        {

        }
    }
}
