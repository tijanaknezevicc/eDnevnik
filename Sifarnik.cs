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
    public partial class Sifarnik : Form
    {
        DataTable tabela;
        SqlDataAdapter adapter;
        string imeTabele;
        public Sifarnik(string tabela)
        {
            imeTabele = tabela;
            InitializeComponent();
        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select * from " + imeTabele, konekcija.connect());
            tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridViewTabela.DataSource = tabela;
            dataGridViewTabela.Columns["id"].ReadOnly = true;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DataTable menjano = tabela.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (menjano != null)
            {
                adapter.Update(menjano);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
