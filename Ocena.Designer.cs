
namespace eDnevnik
{
    partial class Ocena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxGodina = new System.Windows.Forms.ComboBox();
            this.comboBoxProfesor = new System.Windows.Forms.ComboBox();
            this.comboBoxPredmet = new System.Windows.Forms.ComboBox();
            this.comboBoxOdeljenje = new System.Windows.Forms.ComboBox();
            this.comboBoxUcenik = new System.Windows.Forms.ComboBox();
            this.comboBoxOcena = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonBrisi = new System.Windows.Forms.Button();
            this.dataGridViewTabela = new System.Windows.Forms.DataGridView();
            this.labelGodina = new System.Windows.Forms.Label();
            this.labelProfesor = new System.Windows.Forms.Label();
            this.labelPredmet = new System.Windows.Forms.Label();
            this.labelOdeljenje = new System.Windows.Forms.Label();
            this.labelUcenik = new System.Windows.Forms.Label();
            this.labelOcena = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.textBoxSQL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGodina
            // 
            this.comboBoxGodina.FormattingEnabled = true;
            this.comboBoxGodina.Location = new System.Drawing.Point(38, 57);
            this.comboBoxGodina.Name = "comboBoxGodina";
            this.comboBoxGodina.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGodina.TabIndex = 0;
            this.comboBoxGodina.SelectedValueChanged += new System.EventHandler(this.comboBoxGodina_SelectedValueChanged);
            // 
            // comboBoxProfesor
            // 
            this.comboBoxProfesor.FormattingEnabled = true;
            this.comboBoxProfesor.Location = new System.Drawing.Point(165, 57);
            this.comboBoxProfesor.Name = "comboBoxProfesor";
            this.comboBoxProfesor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProfesor.TabIndex = 1;
            this.comboBoxProfesor.SelectedValueChanged += new System.EventHandler(this.comboBoxProfesor_SelectedValueChanged);
            // 
            // comboBoxPredmet
            // 
            this.comboBoxPredmet.FormattingEnabled = true;
            this.comboBoxPredmet.Location = new System.Drawing.Point(292, 57);
            this.comboBoxPredmet.Name = "comboBoxPredmet";
            this.comboBoxPredmet.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPredmet.TabIndex = 2;
            this.comboBoxPredmet.SelectedValueChanged += new System.EventHandler(this.comboBoxPredmet_SelectedValueChanged);
            // 
            // comboBoxOdeljenje
            // 
            this.comboBoxOdeljenje.FormattingEnabled = true;
            this.comboBoxOdeljenje.Location = new System.Drawing.Point(419, 57);
            this.comboBoxOdeljenje.Name = "comboBoxOdeljenje";
            this.comboBoxOdeljenje.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOdeljenje.TabIndex = 3;
            this.comboBoxOdeljenje.SelectedValueChanged += new System.EventHandler(this.comboBoxOdeljenje_SelectedValueChanged);
            // 
            // comboBoxUcenik
            // 
            this.comboBoxUcenik.FormattingEnabled = true;
            this.comboBoxUcenik.Location = new System.Drawing.Point(546, 57);
            this.comboBoxUcenik.Name = "comboBoxUcenik";
            this.comboBoxUcenik.Size = new System.Drawing.Size(121, 24);
            this.comboBoxUcenik.TabIndex = 4;
            // 
            // comboBoxOcena
            // 
            this.comboBoxOcena.FormattingEnabled = true;
            this.comboBoxOcena.Location = new System.Drawing.Point(673, 57);
            this.comboBoxOcena.Name = "comboBoxOcena";
            this.comboBoxOcena.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOcena.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(927, 58);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(91, 22);
            this.dateTimePicker.TabIndex = 6;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(800, 58);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(121, 22);
            this.textBoxID.TabIndex = 7;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(376, 104);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 8;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(506, 104);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmeni.TabIndex = 9;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonBrisi
            // 
            this.buttonBrisi.Location = new System.Drawing.Point(638, 104);
            this.buttonBrisi.Name = "buttonBrisi";
            this.buttonBrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonBrisi.TabIndex = 10;
            this.buttonBrisi.Text = "Brisi";
            this.buttonBrisi.UseVisualStyleBackColor = true;
            this.buttonBrisi.Click += new System.EventHandler(this.buttonBrisi_Click);
            // 
            // dataGridViewTabela
            // 
            this.dataGridViewTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabela.Location = new System.Drawing.Point(38, 187);
            this.dataGridViewTabela.Name = "dataGridViewTabela";
            this.dataGridViewTabela.RowHeadersWidth = 51;
            this.dataGridViewTabela.RowTemplate.Height = 24;
            this.dataGridViewTabela.Size = new System.Drawing.Size(980, 361);
            this.dataGridViewTabela.TabIndex = 11;
            this.dataGridViewTabela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTabela_CellClick);
            // 
            // labelGodina
            // 
            this.labelGodina.AutoSize = true;
            this.labelGodina.Location = new System.Drawing.Point(35, 30);
            this.labelGodina.Name = "labelGodina";
            this.labelGodina.Size = new System.Drawing.Size(54, 17);
            this.labelGodina.TabIndex = 12;
            this.labelGodina.Text = "Godina";
            // 
            // labelProfesor
            // 
            this.labelProfesor.AutoSize = true;
            this.labelProfesor.Location = new System.Drawing.Point(162, 30);
            this.labelProfesor.Name = "labelProfesor";
            this.labelProfesor.Size = new System.Drawing.Size(62, 17);
            this.labelProfesor.TabIndex = 13;
            this.labelProfesor.Text = "Profesor";
            // 
            // labelPredmet
            // 
            this.labelPredmet.AutoSize = true;
            this.labelPredmet.Location = new System.Drawing.Point(289, 30);
            this.labelPredmet.Name = "labelPredmet";
            this.labelPredmet.Size = new System.Drawing.Size(61, 17);
            this.labelPredmet.TabIndex = 14;
            this.labelPredmet.Text = "Predmet";
            // 
            // labelOdeljenje
            // 
            this.labelOdeljenje.AutoSize = true;
            this.labelOdeljenje.Location = new System.Drawing.Point(416, 30);
            this.labelOdeljenje.Name = "labelOdeljenje";
            this.labelOdeljenje.Size = new System.Drawing.Size(68, 17);
            this.labelOdeljenje.TabIndex = 15;
            this.labelOdeljenje.Text = "Odeljenje";
            // 
            // labelUcenik
            // 
            this.labelUcenik.AutoSize = true;
            this.labelUcenik.Location = new System.Drawing.Point(543, 30);
            this.labelUcenik.Name = "labelUcenik";
            this.labelUcenik.Size = new System.Drawing.Size(51, 17);
            this.labelUcenik.TabIndex = 16;
            this.labelUcenik.Text = "Ucenik";
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(670, 30);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(50, 17);
            this.labelOcena.TabIndex = 17;
            this.labelOcena.Text = "Ocena";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(797, 30);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "ID";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(924, 30);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(49, 17);
            this.labelDatum.TabIndex = 19;
            this.labelDatum.Text = "Datum";
            // 
            // textBoxSQL
            // 
            this.textBoxSQL.Location = new System.Drawing.Point(38, 149);
            this.textBoxSQL.Name = "textBoxSQL";
            this.textBoxSQL.Size = new System.Drawing.Size(980, 22);
            this.textBoxSQL.TabIndex = 20;
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 572);
            this.Controls.Add(this.textBoxSQL);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelOcena);
            this.Controls.Add(this.labelUcenik);
            this.Controls.Add(this.labelOdeljenje);
            this.Controls.Add(this.labelPredmet);
            this.Controls.Add(this.labelProfesor);
            this.Controls.Add(this.labelGodina);
            this.Controls.Add(this.dataGridViewTabela);
            this.Controls.Add(this.buttonBrisi);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxOcena);
            this.Controls.Add(this.comboBoxUcenik);
            this.Controls.Add(this.comboBoxOdeljenje);
            this.Controls.Add(this.comboBoxPredmet);
            this.Controls.Add(this.comboBoxProfesor);
            this.Controls.Add(this.comboBoxGodina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGodina;
        private System.Windows.Forms.ComboBox comboBoxProfesor;
        private System.Windows.Forms.ComboBox comboBoxPredmet;
        private System.Windows.Forms.ComboBox comboBoxOdeljenje;
        private System.Windows.Forms.ComboBox comboBoxUcenik;
        private System.Windows.Forms.ComboBox comboBoxOcena;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonBrisi;
        private System.Windows.Forms.DataGridView dataGridViewTabela;
        private System.Windows.Forms.Label labelGodina;
        private System.Windows.Forms.Label labelProfesor;
        private System.Windows.Forms.Label labelPredmet;
        private System.Windows.Forms.Label labelOdeljenje;
        private System.Windows.Forms.Label labelUcenik;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.TextBox textBoxSQL;
    }
}