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
        public void Hledsla() // void til að endurhlaða gagnagrunninn sjálfkrafa
        {
            listView1.Clear(); // hreinsar listviewið

            listView1.Columns.Add("ID", 70); // sýnir nafn stökkvarans og plássið sem sá reitur fær
            listView1.Columns.Add("Nafn", 70); // sýnir stokk stökkvarans og plássið sem sá reitur fær
            listView1.Columns.Add("Sort", 70); // sýnir stokk stökkvarans og plássið sem sá reitur fær
            listView1.Columns.Add("Þyngd", 70); // sýnir stokk stökkvarans og plássið sem sá reitur fær
            listView1.Columns.Add("Mjólk", 70); // sýnir nafn stökkvarans og plássið sem sá reitur fær
            listView1.Columns.Add("ull", 70); // sýnir stokk stökkvarans og plássið sem sá reitur fær
            listView1.Columns.Add("afkvæmi", 70); // sýnir stokk stökkvarans og plássið sem sá reitur fær
            listView1.Columns.Add("einkunlæris", 70); // sýnir stokk stökkvarans og plássið sem sá reitur fær
            listView1.Columns.Add("frjósemi", 70); // sýnir nafn stökkvarans og plássið sem sá reitur fær
            listView1.Columns.Add("gerð", 70); // sýnir stokk stökkvarans og plássið sem sá reitur fær
            listView1.Columns.Add("einkunmalir", 70); // sýnir stokk stökkvarans og plássið sem sá reitur fær

            List<string> linur = new List<string>();

            string[] arr = new string[11];

            ListViewItem itm;

            try
            {
                linur = gagnagrunnur.LesautSQLToflu();

                foreach (string lin in linur)
                {
                    string[] linaUrLista = lin.Split(':');
                    string id = linaUrLista[0];
                    string nafn = linaUrLista[1];
                    string stokk = linaUrLista[2];
                    string thyngd = linaUrLista[3];
                    string mjolk = linaUrLista[4];
                    string ull = linaUrLista[5];
                    string afkvaemi = linaUrLista[6];
                    string einkunlaeris = linaUrLista[7];
                    string frjosemi = linaUrLista[8];
                    string gerd = linaUrLista[9];
                    string einkunmalir = linaUrLista[10];

                    arr[0] = id; // array fyrir nafn
                    arr[1] = nafn; // array fyrir stök
                    arr[2] = stokk; //
                    arr[3] = thyngd; //
                    arr[4] = mjolk; //
                    arr[5] = ull; //
                    arr[6] = afkvaemi; //
                    arr[7] = einkunlaeris; //
                    arr[8] = frjosemi; //
                    arr[9] = gerd; //
                    arr[10] = einkunmalir; //
                    


                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hledsla(); // endurhleður sig
        }
    }
}
