using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Hrafnkell Rúnarsson & Kristinn Þór Kristinsson
   04.04.2017
   Hópverkefni á 3 önn */

namespace Hópaverkefni_önn_3_Hrafnkell
{
    public partial class Form1 : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur(); // tenging við gagnagrunns classið
        public Form1()
        {
            InitializeComponent();

            try
            {
                gagnagrunnur.TengingVidGagnagrunn(); // tengist við gagnagrunninn
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        Random random = new Random(); // býr til randomizer
        List<int> Spilari = new List<int>();
        List<int> AI = new List<int>();
        List<int> Geyma = new List<int>();

        private void btStart_Click_1(object sender, EventArgs e) // þegar ýtt er á takkan á keyrast eftirfarandi skipanir
        {
            int temp = 0;

            for (int i = 0; i < 2; i++)
            {
                temp = random.Next(0, 52); // velur random tölu frá 0-52
                if (!Spilari.Contains(temp))
                {
                    Spilari.Add(temp);
                }

                else
                {
                    i--;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                temp = random.Next(0, 52); // velur random tölu frá 0-52
                if (!Spilari.Contains(temp) && !AI.Contains(temp))
                {
                    AI.Add(temp);
                }

                else
                {
                    i--;
                }
            }
            panelSpilari.BackgroundImage = spil.Images[Spilari[0]]; // birtir random mynd á panelinn hjá spilaranum
            btStart.Visible = false; // gerir takkann ósýnilegan
            


            btStart.Visible = false; // gerir takkann ósýnilegan
            btthyngd.Visible = true; // gerir takkann ósýnilegan
            btmjolk.Visible = true; // gerir takkann ósýnilegan
            btull.Visible = true; // gerir takkann ósýnilegan
            btafkvaemi.Visible = true; // gerir takkann ósýnilegan
            btlaeri.Visible = true; // gerir takkann ósýnilegan
            btfrjosemi.Visible = true; // gerir takkann ósýnilegan
            btgerd.Visible = true; // gerir takkann ósýnilegan
            btmalir.Visible = true; // gerir takkann ósýnilegan
        }

        private void Form1_Load(object sender, EventArgs e) // þegar forritið/formið loadast
        {
            btthyngd.Visible = false; // gerir takkann ósýnilegan
            btmjolk.Visible = false; // gerir takkann ósýnilegan
            btull.Visible = false; // gerir takkann ósýnilegan
            btafkvaemi.Visible = false; // gerir takkann ósýnilegan
            btlaeri.Visible = false; // gerir takkann ósýnilegan
            btfrjosemi.Visible = false; // gerir takkann ósýnilegan
            btgerd.Visible = false; // gerir takkann ósýnilegan
            btmalir.Visible = false; // gerir takkann ósýnilegan
        }

        private void btthyngd_Click(object sender, EventArgs e) // þegar ýtt er á takkan á keyrast eftirfarandi skipanir
        {
            btthyngd.Visible = false; // gerir takkann ósýnilegan
            btmjolk.Visible = false; // gerir takkann ósýnilegan
            btull.Visible = false; // gerir takkann ósýnilegan
            btafkvaemi.Visible = false;// gerir takkann ósýnilegan
            btlaeri.Visible = false;// gerir takkann ósýnilegan
            btfrjosemi.Visible = false; // gerir takkann ósýnilegan
            btgerd.Visible = false; // gerir takkann ósýnilegan
            btmalir.Visible = false; // gerir takkann ósýnilegan

            panelAI.BackgroundImage = spil.Images[AI[0]]; // birtir random mynd á panelinn hjá tölvunni

        }

        private void btmjolk_Click(object sender, EventArgs e) // þegar ýtt er á takkan á keyrast eftirfarandi skipanir
        {
            btthyngd.Visible = false; // gerir takkann ósýnilegan
            btmjolk.Visible = false; // gerir takkann ósýnilegan
            btull.Visible = false; // gerir takkann ósýnilegan
            btafkvaemi.Visible = false;// gerir takkann ósýnilegan
            btlaeri.Visible = false;// gerir takkann ósýnilegan
            btfrjosemi.Visible = false; // gerir takkann ósýnilegan
            btgerd.Visible = false; // gerir takkann ósýnilegan
            btmalir.Visible = false; // gerir takkann ósýnilegan
        }

        private void btull_Click(object sender, EventArgs e) // þegar ýtt er á takkan á keyrast eftirfarandi skipanir
        {
            btthyngd.Visible = false; // gerir takkann ósýnilegan
            btmjolk.Visible = false; // gerir takkann ósýnilegan
            btull.Visible = false; // gerir takkann ósýnilegan
            btafkvaemi.Visible = false;// gerir takkann ósýnilegan
            btlaeri.Visible = false;// gerir takkann ósýnilegan
            btfrjosemi.Visible = false; // gerir takkann ósýnilegan
            btgerd.Visible = false; // gerir takkann ósýnilegan
            btmalir.Visible = false; // gerir takkann ósýnilegan
        }

        private void btafkvaemi_Click(object sender, EventArgs e) // þegar ýtt er á takkan á keyrast eftirfarandi skipanir
        {
            btthyngd.Visible = false; // gerir takkann ósýnilegan
            btmjolk.Visible = false; // gerir takkann ósýnilegan
            btull.Visible = false; // gerir takkann ósýnilegan
            btafkvaemi.Visible = false;// gerir takkann ósýnilegan
            btlaeri.Visible = false;// gerir takkann ósýnilegan
            btfrjosemi.Visible = false; // gerir takkann ósýnilegan
            btgerd.Visible = false; // gerir takkann ósýnilegan
            btmalir.Visible = false; // gerir takkann ósýnilegan
        }

        private void btlaeri_Click(object sender, EventArgs e) // þegar ýtt er á takkan á keyrast eftirfarandi skipanir
        {
            btthyngd.Visible = false; // gerir takkann ósýnilegan
            btmjolk.Visible = false; // gerir takkann ósýnilegan
            btull.Visible = false; // gerir takkann ósýnilegan
            btafkvaemi.Visible = false;// gerir takkann ósýnilegan
            btlaeri.Visible = false;// gerir takkann ósýnilegan
            btfrjosemi.Visible = false; // gerir takkann ósýnilegan
            btgerd.Visible = false; // gerir takkann ósýnilegan
            btmalir.Visible = false; // gerir takkann ósýnilegan
        }

        private void btfrjosemi_Click(object sender, EventArgs e) // þegar ýtt er á takkan á keyrast eftirfarandi skipanir
        {
            btthyngd.Visible = false; // gerir takkann ósýnilegan
            btmjolk.Visible = false; // gerir takkann ósýnilegan
            btull.Visible = false; // gerir takkann ósýnilegan
            btafkvaemi.Visible = false;// gerir takkann ósýnilegan
            btlaeri.Visible = false;// gerir takkann ósýnilegan
            btfrjosemi.Visible = false; // gerir takkann ósýnilegan
            btgerd.Visible = false; // gerir takkann ósýnilegan
            btmalir.Visible = false; // gerir takkann ósýnilegan
        }

        private void btgerd_Click(object sender, EventArgs e) // þegar ýtt er á takkan á keyrast eftirfarandi skipanir
        {
            btthyngd.Visible = false; // gerir takkann ósýnilegan
            btmjolk.Visible = false; // gerir takkann ósýnilegan
            btull.Visible = false; // gerir takkann ósýnilegan
            btafkvaemi.Visible = false;// gerir takkann ósýnilegan
            btlaeri.Visible = false;// gerir takkann ósýnilegan
            btfrjosemi.Visible = false; // gerir takkann ósýnilegan
            btgerd.Visible = false; // gerir takkann ósýnilegan
            btmalir.Visible = false; // gerir takkann ósýnilegan
        }

        private void btmalir_Click(object sender, EventArgs e) // þegar ýtt er á takkan á keyrast eftirfarandi skipanir
        {
            btthyngd.Visible = false; // gerir takkann ósýnilegan
            btmjolk.Visible = false; // gerir takkann ósýnilegan
            btull.Visible = false; // gerir takkann ósýnilegan
            btafkvaemi.Visible = false;// gerir takkann ósýnilegan
            btlaeri.Visible = false;// gerir takkann ósýnilegan
            btfrjosemi.Visible = false; // gerir takkann ósýnilegan
            btgerd.Visible = false; // gerir takkann ósýnilegan
            btmalir.Visible = false; // gerir takkann ósýnilegan
        }
    }
}
