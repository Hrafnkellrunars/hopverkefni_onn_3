using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hópaverkefni_önn_3_Hrafnkell
{
    class Gagnagrunnur
    {
        private string server; // segir til um hvar serverinn er hýstur, hjá okkur er það localhost
        private string database; // nafnið á gagnagrunninum sem verið er að nota
        private string uid; // MySQL Notendanafnið
        private string password; // MySQLlykilorðið

        string spil = null;
        string tengistrengur = null; // tengir saman strenginn og databeisið
        string fyrirspurn = null; // inniheldur fyrirspurn

        MySqlConnection sqltenging; // opnar tengingu við gagnagrunn
        MySqlCommand nySQLskipun; // framkvæmir fyrirpurninar
        MySqlDataReader sqllesari = null; // les úr SQL gagnagrunninum

        public void TengingVidGagnagrunn()
        {
            server = "82.148.66.15"; // ip tala serversins
            database = "0701882449_hrutaspil"; // nafn databeisisins
            uid = "0701882449"; // kennitala
            password = "mypassword"; // lykilorð

            tengistrengur = "server=" + server + ";userid=" + uid + ";password=" + password + ";database=" + database;
            sqltenging = new MySqlConnection(tengistrengur);
        }

        private bool OpenConnection()
        {
            try
            {
                sqltenging.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        private bool Closeconnection()
        {
            try
            {
                sqltenging.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public List<string> LesautSQLToflu()
        {
            List<string> Faerslur = new List<string>();
            string lina = null;
            if (OpenConnection() == true) // ef næst er tengingu við gagnagrunn keyrist eftirfarandi kóði
            {
                fyrirspurn = "SELECT id, nafn, sort, thyngd, mjolk, ull, afkvaemi, einkunlaeris, frjosemi, gerd, einkunmalir FROM hrutar"; // Velur nafn og stokk úr gagnagrunninum
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);

                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString()) + ":";
                    }
                    Faerslur.Add(lina);
                    lina = null;
                }
                Closeconnection();
                return Faerslur;
            }
            return Faerslur;
        }

       

    }
}
