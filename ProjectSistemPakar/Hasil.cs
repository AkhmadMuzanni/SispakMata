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
    public partial class Hasil : Form
    {
        Login parent;
        public Hasil(Login parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void Hasil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            parent.gejala2.Visible = true;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
