using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSistemPakar
{
    public class Controller : Sql
    {
        Login parent;
        public Controller(Login parent)
        {
            this.parent = parent;
        }
        List<string> cekBox = new List<string>();
        Model model = new Model();
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
        public string forwardChaining()
        {
            bool detected = false;
            string result = "";
            if (cekBox.Contains("G001") &&
                cekBox.Contains("G002") &&
                cekBox.Contains("G003") &&
                cekBox.Contains("G004") &&
                cekBox.Contains("G005") &&
                cekBox.Contains("G006"))
            {
                detected = true;
                result = "Anda berpotensi terkena penyakit Degenerasi Makula";
            }
            else if (cekBox.Contains("G001") &&
              cekBox.Contains("G007") &&
              cekBox.Contains("G008") &&
              cekBox.Contains("G009") &&
              cekBox.Contains("G010"))
            {
                detected = true;
                result = "Anda berpotensi terkena penyakit Katarak";
            }
            else if (cekBox.Contains("G011") &&
            cekBox.Contains("G003") &&
            cekBox.Contains("G012"))
            {
                detected = true;
                result = "Anda berpotensi terkena penyakit Neuristik Optik";
            }
            else if (cekBox.Contains("G013") &&
          cekBox.Contains("G014") &&
          cekBox.Contains("G007") &&
          cekBox.Contains("G009") &&
          cekBox.Contains("G015"))
            {
                detected = true;
                result = "Anda berpotensi terkena penyakit Gluokoma";
            }
            else if (cekBox.Contains("G016") &&
          cekBox.Contains("G017") &&
          cekBox.Contains("G018"))
            {
                detected = true;
                result = "Anda berpotensi terkena penyakit Ablasi";
            }
            else if (cekBox.Contains("G019") &&
          cekBox.Contains("G020"))
            {
                detected = true;
                result = "Anda berpotensi terkena penyakit Strabismus (Juling)";
            }
            else if (cekBox.Contains("G021") &&
              cekBox.Contains("G011") &&
              cekBox.Contains("G015"))
            {
                detected = true;
                result = "Anda berpotensi terkena penyakit Herdeolum (Bintitan)";
            }
            else if (cekBox.Contains("G015") &&
             cekBox.Contains("G022") &&
             cekBox.Contains("G023"))
            {
                detected = true;
                result = "Anda berpotensi terkena penyakit Iridosiklitis";
            }
            else if (cekBox.Contains("G024"))
            {
                detected = true;
                result = "Anda berpotensi terkena penyakit Keratitis";
            }
            else if (cekBox.Contains("G025"))
            {
                detected = true;
                result = "Anda berpotensi terkena penyakit Hipermetropi";
            }
            else if (cekBox.Contains("G026"))
            {
                detected = true;
                result = "Anda berpotensi terkena penyakit Miopi";
            }
            else if (cekBox.Contains("G027") &&
             cekBox.Contains("G028"))
            {
                detected = true;
                result = "Anda berpotensi terkena penyakit Presbiopi";
            }
            else if (cekBox.Contains("G003") &&
                    cekBox.Contains("G029"))
                {
                    detected = true;
                result = "Anda berpotensi terkena penyakit Buta Warna";
            }
            result += Environment.NewLine;
            if (detected)
            {
                result += "Gejala yang Anda masukkan : " + Environment.NewLine;
                for (int i = 0; i < cekBox.Count(); i++)
                {
                    result += (i + 1) + ". " + model.selectNamaGejala(cekBox.ElementAt(i)) + Environment.NewLine;
                }
            } else
            {
                result = "Belum ada penyakit yang terdeteksi" + Environment.NewLine;
                result += "Gejala yang Anda masukkan : " + Environment.NewLine;
                for (int i = 0; i < cekBox.Count(); i++)
                {
                    result += (i + 1) + ". " + model.selectNamaGejala(cekBox.ElementAt(i)) + Environment.NewLine;
                }
            }
            result += Environment.NewLine;
            return result;
        }
        public void naiveBayes()
        {
            //string result = "";
            List<string> penyakit = new List<string>();
            foreach (string gejala in cekBox)
            {
                List<string> tempPenyakit = model.selectPenyakitByGejala(gejala);
                foreach (string iteratorPenyakit in tempPenyakit)
                {
                    if (!penyakit.Contains(iteratorPenyakit))
                    {
                        penyakit.Add(iteratorPenyakit);
                        //parent.hasil.txtKesimpulan.Text += iteratorPenyakit + Environment.NewLine;
                    }

                }
            }
            parent.hasil.txtGejala.Text += "Perhitungan Naive Bayes" + Environment.NewLine;
            float maxPosterior = float.MinValue;
            string resPenyakit = "Belum Dapat Ditentukan";
            //float resPosterior = 0;
            foreach (string idPenyakit in penyakit)
            {

                float prior = model.selectPrior(idPenyakit);
                float posterior = prior;
                foreach (string idGejala in parent.data.getCekBox())
                {
                    string idGejalaPenyakit = model.selectGejalaPenyakit(idPenyakit, idGejala);
                    float likelihood = model.selectLikelihood(idPenyakit, idGejala);
                    //parent.hasil.txtKesimpulan.Text += idGejalaPenyakit + " " + likelihood + Environment.NewLine;
                    posterior *= likelihood;
                }
                string namaPenyakit = model.selectNamaPenyakit(idPenyakit);
                if (posterior > maxPosterior)
                {
                    resPenyakit = namaPenyakit;
                    maxPosterior = posterior;
                }
                parent.hasil.txtGejala.Text += "Peluang penyakit " + namaPenyakit + " = " + posterior + Environment.NewLine;
            }
            parent.hasil.txtKesimpulan.Text += Environment.NewLine + "Peluang terbesar adalah " + resPenyakit + " dengan peluang sebesar " + maxPosterior + Environment.NewLine;
        }
    }
}
