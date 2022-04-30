using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace eDnevnik
{
    public partial class Raspodela : Form
    {
        DataTable raspodela;
        int brojSloga = 0;
        public Raspodela()
        {
            InitializeComponent();
        }

        private void ucitaj()
        {
            SqlConnection veza = konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from raspodela", veza);
            raspodela = new DataTable();
            adapter.Fill(raspodela);
        }

        private void Raspodela_Load(object sender, EventArgs e)
        {
            ucitaj();
            comboFill();
        }

        private void comboFill()
        {
            SqlConnection veza = konekcija.connect();
            SqlDataAdapter adapter;
            DataTable dtGodina, dtNastavnik, dtPredmet, dtOdeljenje;

            dtGodina = new DataTable();
            adapter = new SqlDataAdapter("select * from skolska_godina", veza);
            adapter.Fill(dtGodina);

            comboBoxGodina.DataSource = dtGodina;
            comboBoxGodina.ValueMember = "id";
            comboBoxGodina.DisplayMember = "naziv";

            dtNastavnik = new DataTable();
            adapter = new SqlDataAdapter("select id, ime + ' ' + prezime as naziv from osoba where uloga = 2", veza);
            adapter.Fill(dtNastavnik);

            comboBoxNastavnik.DataSource = dtNastavnik;
            comboBoxNastavnik.ValueMember = "id";
            comboBoxNastavnik.DisplayMember = "naziv";

            dtPredmet = new DataTable();
            adapter = new SqlDataAdapter("select id, naziv from predmet", veza);
            adapter.Fill(dtPredmet);

            comboBoxPredmet.DataSource = dtPredmet;
            comboBoxPredmet.ValueMember = "id";
            comboBoxPredmet.DisplayMember = "naziv";

            dtOdeljenje = new DataTable();
            adapter = new SqlDataAdapter("select id, str(razred) + '-' + indeks as naziv from odeljenje", veza);
            adapter.Fill(dtOdeljenje);

            comboBoxOdeljenje.DataSource = dtOdeljenje;
            comboBoxOdeljenje.ValueMember = "id";
            comboBoxOdeljenje.DisplayMember = "naziv";

            textBoxID.Text = raspodela.Rows[brojSloga]["id"].ToString();

            if (raspodela.Rows.Count == 0)
            {
                comboBoxGodina.SelectedValue = -1;
                comboBoxNastavnik.SelectedValue = -1;
                comboBoxPredmet.SelectedValue = -1;
                comboBoxOdeljenje.SelectedValue = -1;
            }
            else
            {
                comboBoxGodina.SelectedValue = raspodela.Rows[brojSloga]["godina_id"];
                comboBoxNastavnik.SelectedValue = raspodela.Rows[brojSloga]["nastavnik_id"];
                comboBoxPredmet.SelectedValue = raspodela.Rows[brojSloga]["predmet_id"];
                comboBoxOdeljenje.SelectedValue = raspodela.Rows[brojSloga]["odeljenje_id"];
            }

            if (brojSloga == 0)
            {
                buttonFirst.Enabled = false;
                buttonPrev.Enabled = false;
            }
            else
            {
                buttonFirst.Enabled = true;
                buttonPrev.Enabled = true;
            }

            if (brojSloga == raspodela.Rows.Count - 1)
            {
                buttonLast.Enabled = false;
                buttonNext.Enabled = false;
            }
            else
            {
                buttonLast.Enabled = true;
                buttonNext.Enabled = true;
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            brojSloga = 0;
            comboFill();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            brojSloga--;
            comboFill();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            brojSloga++;
            comboFill();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            brojSloga = raspodela.Rows.Count - 1;
            comboFill();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            // insert into raspodela (godina_id, nastavnik_id, predmet_id, odeljenje_id)
            // values(7, 2, 2, 1)

            StringBuilder naredba = new StringBuilder("insert into raspodela (godina_id, nastavnik_id, predmet_id, odeljenje_id) values('");
            naredba.Append(comboBoxGodina.SelectedValue + "', '");
            naredba.Append(comboBoxNastavnik.SelectedValue + "', '");
            naredba.Append(comboBoxPredmet.SelectedValue + "', '");
            naredba.Append(comboBoxOdeljenje.SelectedValue + "')");

            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            ucitaj();
            brojSloga = raspodela.Rows.Count - 1;
            comboFill();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            //update osoba set godina_id = 7, nastavnik_id = 2, predmet_id = 2, odeljenje_id = 1 where id = 3

            StringBuilder naredba = new StringBuilder("update raspodela set ");
            naredba.Append("godina_id = " + comboBoxGodina.SelectedValue + ", ");
            naredba.Append("nastavnik_id = " + comboBoxNastavnik.SelectedValue + ", ");
            naredba.Append("predmet_id = " + comboBoxPredmet.SelectedValue + ", ");
            naredba.Append("odeljenje_id = " + comboBoxOdeljenje.SelectedValue);
            naredba.Append(" where id = " + textBoxID.Text);

            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            ucitaj();
            comboFill();
        }

        private void buttonBrisi_Click(object sender, EventArgs e)
        {
            string naredba = "delete from raspodela where id = " + textBoxID.Text;

            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);

            bool brisano = false;

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                brisano = true;
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            if (brisano)
            {
                ucitaj();
                if (brojSloga > 0)
                {
                    brojSloga--;
                    comboFill();
                }
            }
        }
    }
}
