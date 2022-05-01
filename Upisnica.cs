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
    public partial class Upisnica : Form
    {
        DataTable dtOdeljenje, dtUpisnica;
        public Upisnica()
        {
            InitializeComponent();
        }

        private void comboGodinaPopulate()
        {
            SqlConnection veza = konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from skolska_godina", veza);
            DataTable dtGodina = new DataTable();
            adapter.Fill(dtGodina);
            comboBoxGodina.DataSource = dtGodina;
            comboBoxGodina.ValueMember = "id";
            comboBoxGodina.DisplayMember = "naziv";
            comboBoxGodina.SelectedValue = 2;

        }

        private void comboBoxGodina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxGodina.IsHandleCreated && comboBoxGodina.Focused)
            {
                comboOdeljenjePopulate();
                while (dataGridViewUpisnica.Rows.Count > 0)
                {
                    dataGridViewUpisnica.Rows.Remove(dataGridViewUpisnica.Rows[0]);
                }
                textBoxID.Text = "";
                comboBoxUcenik.SelectedIndex = -1;
                comboBoxUcenik.Enabled = false;
            }
        }

        private void comboOdeljenjePopulate()
        {
            string godina = comboBoxGodina.SelectedValue.ToString();
            SqlConnection veza = konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, str(razred) + '-' + indeks as naziv from odeljenje where godina_id = " + godina, veza);
            dtOdeljenje = new DataTable();
            adapter.Fill(dtOdeljenje);
            comboBoxOdeljenje.DataSource = dtOdeljenje;
            comboBoxOdeljenje.ValueMember = "id";
            comboBoxOdeljenje.DisplayMember = "naziv";
            comboBoxOdeljenje.SelectedIndex = -1;
        }

        private void comboBoxOdeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxOdeljenje.IsHandleCreated && comboBoxOdeljenje.Focused)
            {
                comboUcenikPopulate();
                comboBoxUcenik.Enabled = true;
                comboBoxUcenik.SelectedIndex = -1;
                textBoxID.Text = "";
                gridPopulate();
            }
        }

        private void gridPopulate()
        {
            SqlConnection veza = konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select upisnica.id, ime + ' ' + prezime as 'ime i prezime', osoba.id as ucenik from upisnica join osoba on osoba.id = osoba_id where odeljenje_id = " + comboBoxOdeljenje.SelectedValue.ToString(), veza); ;
            dtUpisnica = new DataTable();
            adapter.Fill(dtUpisnica);
            dataGridViewUpisnica.DataSource = dtUpisnica;
            dataGridViewUpisnica.AllowUserToAddRows = false;
            dataGridViewUpisnica.Columns["ucenik"].Visible = false;
        }

        private void comboUcenikPopulate()
        {
            SqlConnection veza = konekcija.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("select id, ime + ' ' + prezime as naziv from osoba where uloga = 1", veza);
            DataTable dtUcenik = new DataTable();
            adapter.Fill(dtUcenik);
            comboBoxUcenik.DataSource = dtUcenik;
            comboBoxUcenik.ValueMember = "id";
            comboBoxUcenik.DisplayMember = "naziv";
        }

        private void Upisnica_Load(object sender, EventArgs e)
        {
            comboGodinaPopulate();
            comboOdeljenjePopulate();
            comboBoxUcenik.Enabled = false;
            comboUcenikPopulate();

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("insert into upisnica (odeljenje_id, osoba_id) values('");
            naredba.Append(comboBoxOdeljenje.SelectedValue.ToString() + "', '");
            naredba.Append(comboBoxUcenik.SelectedValue.ToString() + "')");

            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                gridPopulate();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("update upisnica set ");
            naredba.Append("osoba_id = " + comboBoxUcenik.SelectedValue.ToString() + " ");
            naredba.Append("where id = " + textBoxID.Text);

            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                gridPopulate();

            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void buttonBrisi_Click(object sender, EventArgs e)
        {
            string naredba = "delete from upisnica where id = " + textBoxID.Text;

            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);

            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                gridPopulate();

            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void dataGridViewUpisnica_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridViewUpisnica.CurrentRow != null)
            {
                int brojSloga = dataGridViewUpisnica.CurrentRow.Index;
                if (dtUpisnica.Rows.Count != 0 && brojSloga >= 0)
                {
                    comboBoxUcenik.SelectedValue = dataGridViewUpisnica.Rows[brojSloga].Cells["Ucenik"].Value.ToString();
                    textBoxID.Text = dataGridViewUpisnica.Rows[brojSloga].Cells["id"].Value.ToString();
                }
            }
        }
    }
}
