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
        public string selectGejalaPenyakit(string idPenyakit, string idGejala)
        {
            koneksi.Open();
            queri = "SELECT idGejalaPenyakit from gejalapenyakit where idPenyakit = '" + idPenyakit + "' AND idGejala = '" + idGejala + "'";
            command = new MySqlCommand(queri, koneksi);            
            Object result = command.ExecuteScalar();            
            koneksi.Close();
            return result.ToString();
        }
        public float selectPrior(string idPenyakit)
        {
            koneksi.Open();
            queri = "SELECT prior from penyakit where idPenyakit = '" + idPenyakit + "'";
            command = new MySqlCommand(queri, koneksi);
            Object result = command.ExecuteScalar();
            koneksi.Close();
            return (float)result;
        }
        public float selectLikelihood(string idPenyakit, string idGejala)
        {
            koneksi.Open();
            queri = "SELECT likelihood from gejalapenyakit where idPenyakit = '" + idPenyakit + "' AND idGejala = '" + idGejala + "'";
            command = new MySqlCommand(queri, koneksi);
            Object result = command.ExecuteScalar();
            koneksi.Close();
            return (float)result;
        }
        public string selectNamaPenyakit(string idPenyakit)
        {
            koneksi.Open();
            queri = "SELECT namaPenyakit from penyakit where idPenyakit = '" + idPenyakit + "'";
            command = new MySqlCommand(queri, koneksi);
            Object result = command.ExecuteScalar();
            koneksi.Close();
            return result.ToString();
        }
        public string selectNamaGejala(string idGejala)
        {
            koneksi.Open();
            queri = "SELECT namaGejala from gejala where idGejala = '" + idGejala + "'";
            command = new MySqlCommand(queri, koneksi);
            Object result = command.ExecuteScalar();
            koneksi.Close();
            return result.ToString();
        }
        //public List<float> selectLikelihoodByGP()
        //{
        //    return
        //}
        
    }
}
