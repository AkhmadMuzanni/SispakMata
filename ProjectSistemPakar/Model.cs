using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProjectSistemPakar
{
    class Model:Sql
    {
        string queri;
        public List<string> selectPenyakitByGejala(string idGejala)
        {
            koneksi.Open();
            queri = "SELECT DISTINCT * from gejalapenyakit where idGejala = '"+ idGejala +"'";
            command = new MySqlCommand(queri, koneksi);
            reader = command.ExecuteReader();
            List<string> arrayPenyakit = new List<string>();

            while (reader.Read())
            {
                //Fungsi.kelas.Add(reader.GetString("kode_penyakit"));
                if (reader.GetFloat(reader.GetOrdinal("likelihood")) > 0.5) {
                    arrayPenyakit.Add(reader.GetString("idPenyakit"));
                }
            }
            koneksi.Close();
            return arrayPenyakit;
        }
        //public string selectPenyakitbyIdGejala()
        //{

        //}
    }
}
