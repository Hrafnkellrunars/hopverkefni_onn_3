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
        Random random = new Random();
        List<int> Spilari = new List<int>();
        List<int> AI = new List<int>();
        List<int> Geyma = new List<int>();

        private void btStart_Click_1(object sender, EventArgs e)
        {
            int temp = 0;

            for (int i = 0; i < 2; i++)
            {
                temp = random.Next(0, 52);
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
                temp = random.Next(0, 52);
                if (!Spilari.Contains(temp) && !AI.Contains(temp))
                {
                    AI.Add(temp);
                }

                else
                {
                    i--;
                }
            }
            panelSpilari.BackgroundImage = spil.Images[Spilari[0]];
            btStart.Visible = false;
            


            btStart.Visible = false;
            btthyngd.Visible = true;
            btmjolk.Visible = true;
            btull.Visible = true;
            btafkvaemi.Visible = true;
            btlaeri.Visible = true;
            btfrjosemi.Visible = true;
            btgerd.Visible = true;
            btmalir.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btthyngd.Visible = false;
            btmjolk.Visible = false;
            btull.Visible = false;
            btafkvaemi.Visible = false;
            btlaeri.Visible = false;
            btfrjosemi.Visible = false;
            btgerd.Visible = false;
            btmalir.Visible = false;
        }

        private void btthyngd_Click(object sender, EventArgs e)
        {
            btthyngd.Visible = false;
            btmjolk.Visible = false;
            btull.Visible = false;
            btafkvaemi.Visible = false;
            btlaeri.Visible = false;
            btfrjosemi.Visible = false;
            btgerd.Visible = false;
            btmalir.Visible = false;

            panelAI.BackgroundImage = spil.Images[AI[0]];

        }
    }
}
