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
    public partial class Ocena : Form
    {
        DataTable dtGrid;

        public Ocena()
        {
            InitializeComponent();
        }

        private void Ocena_Load(object sender, EventArgs e)
        {
            comboGodinaPopulate();
            comboBoxPredmet.Enabled = false;
            comboBoxOdeljenje.Enabled = false;
            comboBoxUcenik.Enabled = false;
            comboBoxOcena.Enabled = false;
            
            comboBoxOcena.Items.Add(1);
            comboBoxOcena.Items.Add(2);
            comboBoxOcena.Items.Add(3);
            comboBoxOcena.Items.Add(4);
            comboBoxOcena.Items.Add(5);

            comboProfesorPopulate();
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
                comboProfesorPopulate();

                comboBoxProfesor.SelectedIndex = -1;
                
                comboBoxOdeljenje.SelectedIndex = -1;
                comboBoxOdeljenje.Enabled = false;

                comboBoxUcenik.SelectedIndex = -1;
                comboBoxUcenik.Enabled = false;

                comboBoxOcena.SelectedIndex = -1;
                comboBoxOcena.Enabled = false;

                dtGrid = new DataTable();
                dataGridViewTabela.DataSource = dtGrid;
            }
        }

        private void comboProfesorPopulate()
        {
            SqlConnection veza = konekcija.connect();
            StringBuilder naredba = new StringBuilder("select distinct osoba.id as id, ime + ' ' + prezime as naziv from osoba ");
            naredba.Append("join raspodela on osoba.id = nastavnik_id ");
            naredba.Append("where godina_id = " + comboBoxGodina.SelectedValue.ToString());

            //textBoxSQL.Text = naredba.ToString();

            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dtProfesor = new DataTable();
            adapter.Fill(dtProfesor);
            comboBoxProfesor.DataSource = dtProfesor;
            comboBoxProfesor.ValueMember = "id";
            comboBoxProfesor.DisplayMember = "naziv";
            comboBoxProfesor.SelectedValue = -1;
        }

        private void comboBoxProfesor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxProfesor.IsHandleCreated && comboBoxProfesor.Focused)
            {               
                comboBoxPredmet.Enabled = true;
                comboPredmetPopulate();

                comboBoxOdeljenje.SelectedIndex = -1;
                comboBoxOdeljenje.Enabled = false;

                comboBoxUcenik.SelectedIndex = -1;
                comboBoxUcenik.Enabled = false;

                comboBoxOcena.SelectedIndex = -1;
                comboBoxOcena.Enabled = false;

                dtGrid = new DataTable();
                dataGridViewTabela.DataSource = dtGrid;
            }
        }

        private void comboPredmetPopulate()
        {
            SqlConnection veza = konekcija.connect();
            StringBuilder naredba = new StringBuilder("select distinct predmet.id as id, naziv from predmet ");
            naredba.Append("join raspodela on predmet.id = predmet_id ");
            naredba.Append("where godina_id = " + comboBoxGodina.SelectedValue.ToString());
            naredba.Append(" and nastavnik_id = " + comboBoxProfesor.SelectedValue.ToString());

            //textBoxSQL.Text = naredba.ToString();

            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dtPredmet = new DataTable();
            adapter.Fill(dtPredmet);
            comboBoxPredmet.DataSource = dtPredmet;
            comboBoxPredmet.ValueMember = "id";
            comboBoxPredmet.DisplayMember = "naziv";
            comboBoxPredmet.SelectedValue = -1;
        }

        private void comboBoxPredmet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxPredmet.IsHandleCreated && comboBoxPredmet.Focused)
            {
                comboBoxOdeljenje.Enabled = true;
                comboOdeljenjePopulate();

                comboBoxUcenik.SelectedIndex = -1;
                comboBoxUcenik.Enabled = false;

                comboBoxOcena.SelectedIndex = -1;
                comboBoxOcena.Enabled = false;

                dtGrid = new DataTable();
                dataGridViewTabela.DataSource = dtGrid;
            }
        }

        private void comboOdeljenjePopulate()
        {
            SqlConnection veza = konekcija.connect();
            StringBuilder naredba = new StringBuilder("select distinct odeljenje.id as id, str(razred) + ' ' + indeks as naziv from odeljenje ");
            naredba.Append("join raspodela on odeljenje.id = odeljenje_id ");
            naredba.Append("where raspodela.godina_id = " + comboBoxGodina.SelectedValue.ToString());
            naredba.Append(" and nastavnik_id = " + comboBoxProfesor.SelectedValue.ToString());
            naredba.Append(" and predmet_id = " + comboBoxPredmet.SelectedValue.ToString());

            //textBoxSQL.Text = naredba.ToString();

            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dtOdeljenje = new DataTable();
            adapter.Fill(dtOdeljenje);
            comboBoxOdeljenje.DataSource = dtOdeljenje;
            comboBoxOdeljenje.ValueMember = "id";
            comboBoxOdeljenje.DisplayMember = "naziv";
            comboBoxOdeljenje.SelectedValue = -1;
        }

        private void comboBoxOdeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxOdeljenje.IsHandleCreated && comboBoxOdeljenje.Focused)
            {
                comboBoxUcenik.Enabled = true;
                comboBoxOcena.Enabled = true;
                comboUcenikPopulate();
                DataGridPopulate();
            }
        }

        private void comboUcenikPopulate()
        {
            SqlConnection veza = konekcija.connect();
            StringBuilder naredba = new StringBuilder("select distinct osoba.id as id, ime + ' ' + prezime as naziv from osoba ");
            naredba.Append("join upisnica on osoba.id = osoba_id ");
            naredba.Append("where upisnica.odeljenje_id = " + comboBoxOdeljenje.SelectedValue.ToString());

            //textBoxSQL.Text = naredba.ToString();

            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dtUcenik = new DataTable();
            adapter.Fill(dtUcenik);
            comboBoxUcenik.DataSource = dtUcenik;
            comboBoxUcenik.ValueMember = "id";
            comboBoxUcenik.DisplayMember = "naziv";
            comboBoxUcenik.SelectedValue = -1;
        }

        private void DataGridPopulate()
        {
            SqlConnection veza = konekcija.connect();
            StringBuilder naredba = new StringBuilder("select ocena.id as id, ime + ' ' + prezime as naziv, ocena, ucenik_id, datum from osoba ");
            naredba.Append("join ocena on osoba.id = ucenik_id ");
            naredba.Append("join raspodela on raspodela.id = raspodela_id ");
            naredba.Append("where raspodela.id = " );
            naredba.Append("(select id from raspodela where godina_id =  " + comboBoxGodina.SelectedValue.ToString());
            naredba.Append(" and nastavnik_id = " + comboBoxProfesor.SelectedValue.ToString());
            naredba.Append(" and predmet_id = " + comboBoxPredmet.SelectedValue.ToString());
            naredba.Append(" and odeljenje_id = " + comboBoxOdeljenje.SelectedValue.ToString() + ")");

            //textBoxSQL.Text = naredba.ToString();

            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            dtGrid = new DataTable();
            adapter.Fill(dtGrid);
            dataGridViewTabela.DataSource = dtGrid;
            dataGridViewTabela.AllowUserToAddRows = false;
            dataGridViewTabela.Columns["ucenik_id"].Visible = false;

            ucenikOcenaIDSet(0);
        }

        private void dataGridViewTabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ucenikOcenaIDSet(e.RowIndex);
        }

        private void ucenikOcenaIDSet(int brojSloga)
        {
            if (brojSloga >= 0 && dtGrid.Rows.Count != 0)
            {
                comboBoxUcenik.SelectedValue = dtGrid.Rows[brojSloga]["ucenik_id"];
                comboBoxOcena.SelectedItem = dtGrid.Rows[brojSloga]["ocena"];
                textBoxID.Text = dtGrid.Rows[brojSloga]["id"].ToString();
            }
            
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("Select id from raspodela ");
            naredba.Append("where godina_id = " + comboBoxGodina.SelectedValue.ToString());
            naredba.Append(" and nastavnik_id = " + comboBoxProfesor.SelectedValue.ToString());
            naredba.Append(" and predmet_id = " + comboBoxPredmet.SelectedValue.ToString());
            naredba.Append(" and odeljenje_id = " + comboBoxOdeljenje.SelectedValue.ToString());

            SqlConnection veza = konekcija.connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            int raspodelaID = 0;

            try
            {
                veza.Open();
                raspodelaID = (int)komanda.ExecuteScalar();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
            if (raspodelaID > 0)
            {
                DateTime datum = dateTimePicker.Value;

                naredba = new StringBuilder("insert into ocena (datum,raspodela_id,ucenik_id,ocena) values ('");
                naredba.Append(datum.ToString("yyyy/MM/dd") + "', '" + raspodelaID.ToString() + "', '");
                naredba.Append(comboBoxUcenik.SelectedValue.ToString() + "', '" + comboBoxOcena.SelectedItem.ToString() + "')");
    
                komanda = new SqlCommand(naredba.ToString(), veza);

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
            }

            DataGridPopulate();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxID.Text) > 0)
            {
                DateTime datum = dateTimePicker.Value;

                StringBuilder naredba = new StringBuilder("update ocena set ");
                naredba.Append("ucenik_id = '" + comboBoxUcenik.SelectedValue.ToString() + "', ");
                naredba.Append("ocena = '" + comboBoxOcena.SelectedItem.ToString() + "', ");
                naredba.Append("datum = '" + datum.ToString("yyyy/MM/dd") + "' ");
                naredba.Append("where id = " + textBoxID.Text);

                SqlConnection veza = konekcija.connect();
                SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
                
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }

            DataGridPopulate();
        }

        private void buttonBrisi_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxID.Text) > 0)
            {
                string naredba = "delete from ocena where id = " + textBoxID.Text;
                SqlConnection veza = konekcija.connect();
                SqlCommand Komanda = new SqlCommand(naredba, veza);

                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                    DataGridPopulate();
                    ucenikOcenaIDSet(0);
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
