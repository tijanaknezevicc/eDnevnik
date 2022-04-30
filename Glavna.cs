using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDnevnik
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void osobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            osoba formOsoba = new osoba();
            formOsoba.Show();
        }

        private void Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            string user = Program.userIme + " " + Program.userPrezime;
            labelUser.Text = user;
        }

        private void smeroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik formSifarnik = new Sifarnik("smer");
            formSifarnik.Show();
        }

        private void skolskeGodineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik formSifarnik = new Sifarnik("skolska_godina");
            formSifarnik.Show();
        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik formSifarnik = new Sifarnik("predmet");
            formSifarnik.Show();
        }

        private void osobeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sifarnik formSifarnik = new Sifarnik("osoba");
            formSifarnik.Show();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspodela formRaspodela = new Raspodela();
            formRaspodela.Show();
        }
    }
}
