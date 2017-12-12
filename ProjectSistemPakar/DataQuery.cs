using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSistemPakar
{
    public class DataQuery : Sql
    {
        List<string> cekBox = new List<string>();
        //List<string> penyakit = new List<string>();
        public void tambahCekBox(CheckBox cekBox)
        {
            this.cekBox.Add(cekBox.Tag.ToString());
        }
        public void hapusCekBox(CheckBox cekBox)
        {
            this.cekBox.Remove(cekBox.Tag.ToString());
        }
        public List<string> getCekBox()
        {
            return cekBox;
        }
        public string forwardChaining(Login parent)
        {
            bool detected = false;
            string result = "";
            //if (cekBox.Contains(parent.gejala1.cbGejala01) &&
            //    cekBox.Contains(parent.gejala1.cbGejala02) &&
            //    cekBox.Contains(parent.gejala2.cbGejala03) &&
            //    cekBox.Contains(parent.gejala2.cbGejala04) &&
            //    cekBox.Contains(parent.gejala1.cbGejala05) &&
            //    cekBox.Contains(parent.gejala2.cbGejala06))
            //{
            //    detected = true;
            //    result = "Anda berpotensi terkena penyakit Degenerasi Makula";
            //} else if (cekBox.Contains(parent.gejala1.cbGejala01) &&
            //    cekBox.Contains(parent.gejala2.cbGejala07) &&
            //    cekBox.Contains(parent.gejala2.cbGejala08) &&
            //    cekBox.Contains(parent.gejala1.cbGejala09) &&                
            //    cekBox.Contains(parent.gejala1.cbGejala10))
            //{
            //    detected = true;
            //    result = "Anda berpotensi terkena penyakit Katarak";
            //} else if (cekBox.Contains(parent.gejala1.cbGejala11) &&
            //  cekBox.Contains(parent.gejala2.cbGejala03) &&              
            //  cekBox.Contains(parent.gejala1.cbGejala12))
            //{
            //    detected = true;
            //    result = "Anda berpotensi terkena penyakit Neuristik Optik";
            //} else if (cekBox.Contains(parent.gejala1.cbGejala13) &&
            //cekBox.Contains(parent.gejala1.cbGejala14) &&
            //cekBox.Contains(parent.gejala2.cbGejala07) &&
            //cekBox.Contains(parent.gejala1.cbGejala09) &&            
            //cekBox.Contains(parent.gejala1.cbGejala15))
            //{
            //    detected = true;
            //    result = "Anda berpotensi terkena penyakit Gluokoma";
            //} else if (cekBox.Contains(parent.gejala1.cbGejala16) &&
            //cekBox.Contains(parent.gejala1.cbGejala17) &&
            //cekBox.Contains(parent.gejala1.cbGejala18))
            //{
            //    detected = true;
            //    result = "Anda berpotensi terkena penyakit Ablasi";
            //} else if (cekBox.Contains(parent.gejala1.cbGejala19) &&           
            //cekBox.Contains(parent.gejala1.cbGejala20))
            //{
            //    detected = true;
            //    result = "Anda berpotensi terkena penyakit Strabismus (Juling)";
            //} else if (cekBox.Contains(parent.gejala1.cbGejala21) &&
            //    cekBox.Contains(parent.gejala1.cbGejala11) &&                
            //    cekBox.Contains(parent.gejala1.cbGejala15))
            //{
            //    detected = true;
            //    result = "Anda berpotensi terkena penyakit Herdeolum (Bintitan)";
            //} else if (cekBox.Contains(parent.gejala1.cbGejala15) &&
            //   cekBox.Contains(parent.gejala1.cbGejala22) &&
            //   cekBox.Contains(parent.gejala1.cbGejala23))
            //{
            //    detected = true;
            //    result = "Anda berpotensi terkena penyakit Iridosiklitis";
            //} else if (cekBox.Contains(parent.gejala1.cbGejala24))
            //{
            //    detected = true;
            //    result = "Anda berpotensi terkena penyakit Keratitis";
            //} else if (cekBox.Contains(parent.gejala2.cbGejala25))
            //{
            //    detected = true;
            //    result = "Anda berpotensi terkena penyakit Hipermetropi";
            //} else if (cekBox.Contains(parent.gejala2.cbGejala26))
            //{
            //    detected = true;
            //    result = "Anda berpotensi terkena penyakit Miopi";
            //} else if (cekBox.Contains(parent.gejala2.cbGejala27) &&
            //   cekBox.Contains(parent.gejala1.cbGejala28))
            //{
            //    detected = true;
            //    result = "Anda berpotensi terkena penyakit Presbiopi";
            //} else 
            //if (cekBox.Contains(parent.gejala2.cbGejala03) &&
            //  cekBox.Contains(parent.gejala1.cbGejala29))
            //{
                if (cekBox.Contains("G003") &&
                    cekBox.Contains("G029"))
                {
                    detected = true;
                result = ". Anda berpotensi terkena penyakit Buta Warna";
            }
            result += Environment.NewLine;
            if (detected)
            {
                result += "Gejala yang Anda masukkan : \n";
                for (int i = 0; i < cekBox.Count(); i++)
                {
                    result += cekBox.ElementAt(i) + Environment.NewLine;
                }
            } else
            {
                result = "Belum ada penyakit yang terdeteksi";
                result += "Gejala yang Anda masukkan : \n";
                for (int i = 0; i < cekBox.Count(); i++)
                {
                    result += cekBox.ElementAt(i) + Environment.NewLine;
                }
            }
            return result;
        }
    }
}
