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
    public partial class Login : Form
    {
        public Gejala1 gejala1;
        public Gejala2 gejala2;
        public Hasil hasil;
        public DataQuery data;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                gejala1 = new Gejala1(this);
                gejala2 = new Gejala2(this);
                hasil = new Hasil(this);
                data = new DataQuery();
                this.Visible = false;
                gejala1.Visible = true;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
