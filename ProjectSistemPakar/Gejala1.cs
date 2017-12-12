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
    public partial class Gejala1 : Form
    {
        Login parent;
        //DataQuery query;
        public Gejala1(Login parent)
        {
            this.parent = parent;
            //this.query = new DataQuery();
            InitializeComponent();
            this.cbGejala02.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala23.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala18.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala17.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala16.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala12.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala10.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala09.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala05.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala01.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala29.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala28.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala19.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala14.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala13.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala24.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala21.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala22.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala20.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala15.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
            this.cbGejala11.CheckedChanged += new System.EventHandler(this.cbGejala02_CheckedChanged);
        }

        private void Gejala1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void cbGejala02_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                parent.data.tambahCekBox(((CheckBox)sender));
            } else
            {
                parent.data.hapusCekBox(((CheckBox)sender));
            }
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            parent.gejala2.Visible = true;
        }
    }
}
