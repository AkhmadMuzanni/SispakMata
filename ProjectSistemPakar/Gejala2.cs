using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSistemPakar
{
    public partial class Gejala2 : Form
    {
        Login parent;
        Model model;
        public Gejala2(Login parent)
        {
            this.parent = parent;
            this.model = new Model();
            InitializeComponent();
            this.cbGejala03.CheckedChanged += new System.EventHandler(this.cbGejala03_CheckedChanged);
            this.cbGejala08.CheckedChanged += new System.EventHandler(this.cbGejala03_CheckedChanged);
            this.cbGejala07.CheckedChanged += new System.EventHandler(this.cbGejala03_CheckedChanged);
            this.cbGejala04.CheckedChanged += new System.EventHandler(this.cbGejala03_CheckedChanged);            
            this.cbGejala27.CheckedChanged += new System.EventHandler(this.cbGejala03_CheckedChanged);
            this.cbGejala26.CheckedChanged += new System.EventHandler(this.cbGejala03_CheckedChanged);
            this.cbGejala25.CheckedChanged += new System.EventHandler(this.cbGejala03_CheckedChanged);
            this.cbGejala06.CheckedChanged += new System.EventHandler(this.cbGejala03_CheckedChanged);
        }

        private void Gejala2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            parent.gejala1.Visible = true;
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            parent.hasil.Visible = true;
            //parent.hasil.txtGejala.Text = "";
            //for (int i = 0; i < parent.data.getCekBox().Count; i++) 
            //{
            //    parent.hasil.txtGejala.Text += parent.data.getCekBox().ElementAt(i).Text + '\n';
            //}
            parent.hasil.txtGejala.Text = parent.data.forwardChaining(parent);
            List<string> penyakit = new List<string>();
            foreach (string gejala in parent.data.getCekBox())
            {
                List<string> tempPenyakit = model.selectPenyakitByGejala(gejala);
                foreach (string iteratorPenyakit in tempPenyakit)
                {
                    if (!penyakit.Contains(iteratorPenyakit))
                    {
                        penyakit.Add(iteratorPenyakit);
                        parent.hasil.txtKesimpulan.Text += iteratorPenyakit + Environment.NewLine;
                    }
                    
                }
            }
        }

        private void cbGejala03_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                parent.data.tambahCekBox(((CheckBox)sender));
            }
            else
            {
                parent.data.hapusCekBox(((CheckBox)sender));
            }
        }
    }
}
