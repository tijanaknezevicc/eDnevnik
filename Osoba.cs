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
    public partial class osoba : Form
    {
        int brojSloga = 0;
        DataTable tabela;

        public osoba()
        {
            InitializeComponent();
        }

        private void ucitaj()
        {
            SqlConnection veza = konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from osoba", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }

        private void osvezi()
        {
            if (tabela.Rows.Count == 0)
            {
                textBoxID.Text = "";
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxAdresa.Text = "";
                textBoxJMBG.Text = "";
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
                textBoxUloga.Text = "";
                buttonBrisi.Enabled = false;
            }
            else
            {
                textBoxID.Text = tabela.Rows[brojSloga]["id"].ToString();
                textBoxIme.Text = tabela.Rows[brojSloga]["ime"].ToString();
                textBoxPrezime.Text = tabela.Rows[brojSloga]["prezime"].ToString();
                textBoxAdresa.Text = tabela.Rows[brojSloga]["adresa"].ToString();
                textBoxJMBG.Text = tabela.Rows[brojSloga]["jmbg"].ToString();
                textBoxEmail.Text = tabela.Rows[brojSloga]["email"].ToString();
                textBoxPassword.Text = tabela.Rows[brojSloga]["pass"].ToString();
                textBoxUloga.Text = tabela.Rows[brojSloga]["uloga"].ToString();
                buttonBrisi.Enabled = true;
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

            if (brojSloga == tabela.Rows.Count - 1)
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

        private void osoba_Load(object sender, EventArgs e)
        {
            ucitaj();
            osvezi();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            brojSloga = 0;
            osvezi();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            brojSloga--;
            osvezi();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            brojSloga++;
            osvezi();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            brojSloga = tabela.Rows.Count - 1;
            osvezi();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            // insert into osoba (ime, prezime, adresa, jmbg, email, pass, uloga)
            // values('Marko','Lazic','Savska 10','123456791234', 'markol@gmail.com', '1234', '1')

            StringBuilder naredba = new StringBuilder("insert into osoba (ime, prezime, adresa, jmbg, email, pass, uloga) values('");
            naredba.Append(textBoxIme.Text + "', '");
            naredba.Append(textBoxPrezime.Text + "', '");
            naredba.Append(textBoxAdresa.Text + "', '");
            naredba.Append(textBoxJMBG.Text + "', '");
            naredba.Append(textBoxEmail.Text + "', '");
            naredba.Append(textBoxPassword.Text + "', '");
            naredba.Append(textBoxUloga.Text + "')");

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
            brojSloga = tabela.Rows.Count - 1;
            osvezi();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            //update osoba set ime = 'Marko', prezime = 'Peric', adresa = 'Studenac 8', jmbg = '123456',
            //email = 'markop@yahoo.com', pass = '1222', uloga = '1' where id = 3

            StringBuilder naredba = new StringBuilder("update osoba set ");
            naredba.Append("ime = '" + textBoxIme.Text + "', ");
            naredba.Append("prezime = '" + textBoxPrezime.Text + "', ");
            naredba.Append("adresa = '" + textBoxAdresa.Text + "', ");
            naredba.Append("jmbg = '" + textBoxJMBG.Text + "', ");
            naredba.Append("email = '" + textBoxEmail.Text + "', ");
            naredba.Append("pass = '" + textBoxPassword.Text + "', ");
            naredba.Append("uloga = '" + textBoxUloga.Text + "' ");
            naredba.Append("where id = " + textBoxID.Text);

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
            osvezi();
        }

        private void buttonBrisi_Click(object sender, EventArgs e)
        {
            string naredba = "delete from osoba where id = " + textBoxID.Text;

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
                    osvezi();
                }
            }
        }
    }
}
