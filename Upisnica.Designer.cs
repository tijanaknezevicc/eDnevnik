
namespace eDnevnik
{
    partial class Upisnica
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.comboBoxGodina = new System.Windows.Forms.ComboBox();
            this.comboBoxUcenik = new System.Windows.Forms.ComboBox();
            this.comboBoxOdeljenje = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelGodina = new System.Windows.Forms.Label();
            this.labelOdeljenje = new System.Windows.Forms.Label();
            this.labelUcenik = new System.Windows.Forms.Label();
            this.dataGridViewUpisnica = new System.Windows.Forms.DataGridView();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonBrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpisnica)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(58, 71);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(125, 22);
            this.textBoxID.TabIndex = 0;
            // 
            // comboBoxGodina
            // 
            this.comboBoxGodina.FormattingEnabled = true;
            this.comboBoxGodina.Location = new System.Drawing.Point(189, 71);
            this.comboBoxGodina.Name = "comboBoxGodina";
            this.comboBoxGodina.Size = new System.Drawing.Size(125, 24);
            this.comboBoxGodina.TabIndex = 1;
            this.comboBoxGodina.SelectedValueChanged += new System.EventHandler(this.comboBoxGodina_SelectedValueChanged);
            // 
            // comboBoxUcenik
            // 
            this.comboBoxUcenik.FormattingEnabled = true;
            this.comboBoxUcenik.Location = new System.Drawing.Point(451, 71);
            this.comboBoxUcenik.Name = "comboBoxUcenik";
            this.comboBoxUcenik.Size = new System.Drawing.Size(125, 24);
            this.comboBoxUcenik.TabIndex = 2;
            // 
            // comboBoxOdeljenje
            // 
            this.comboBoxOdeljenje.FormattingEnabled = true;
            this.comboBoxOdeljenje.Location = new System.Drawing.Point(320, 71);
            this.comboBoxOdeljenje.Name = "comboBoxOdeljenje";
            this.comboBoxOdeljenje.Size = new System.Drawing.Size(125, 24);
            this.comboBoxOdeljenje.TabIndex = 3;
            this.comboBoxOdeljenje.SelectedValueChanged += new System.EventHandler(this.comboBoxOdeljenje_SelectedValueChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(55, 44);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID";
            // 
            // labelGodina
            // 
            this.labelGodina.AutoSize = true;
            this.labelGodina.Location = new System.Drawing.Point(186, 44);
            this.labelGodina.Name = "labelGodina";
            this.labelGodina.Size = new System.Drawing.Size(54, 17);
            this.labelGodina.TabIndex = 5;
            this.labelGodina.Text = "Godina";
            // 
            // labelOdeljenje
            // 
            this.labelOdeljenje.AutoSize = true;
            this.labelOdeljenje.Location = new System.Drawing.Point(317, 44);
            this.labelOdeljenje.Name = "labelOdeljenje";
            this.labelOdeljenje.Size = new System.Drawing.Size(68, 17);
            this.labelOdeljenje.TabIndex = 6;
            this.labelOdeljenje.Text = "Odeljenje";
            // 
            // labelUcenik
            // 
            this.labelUcenik.AutoSize = true;
            this.labelUcenik.Location = new System.Drawing.Point(448, 44);
            this.labelUcenik.Name = "labelUcenik";
            this.labelUcenik.Size = new System.Drawing.Size(51, 17);
            this.labelUcenik.TabIndex = 7;
            this.labelUcenik.Text = "Ucenik";
            // 
            // dataGridViewUpisnica
            // 
            this.dataGridViewUpisnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpisnica.Location = new System.Drawing.Point(12, 155);
            this.dataGridViewUpisnica.Name = "dataGridViewUpisnica";
            this.dataGridViewUpisnica.RowHeadersWidth = 51;
            this.dataGridViewUpisnica.RowTemplate.Height = 24;
            this.dataGridViewUpisnica.Size = new System.Drawing.Size(621, 283);
            this.dataGridViewUpisnica.TabIndex = 8;
            this.dataGridViewUpisnica.CurrentCellChanged += new System.EventHandler(this.dataGridViewUpisnica_CurrentCellChanged);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(145, 118);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 9;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(282, 118);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmeni.TabIndex = 10;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonBrisi
            // 
            this.buttonBrisi.Location = new System.Drawing.Point(411, 118);
            this.buttonBrisi.Name = "buttonBrisi";
            this.buttonBrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonBrisi.TabIndex = 11;
            this.buttonBrisi.Text = "Brisi";
            this.buttonBrisi.UseVisualStyleBackColor = true;
            this.buttonBrisi.Click += new System.EventHandler(this.buttonBrisi_Click);
            // 
            // Upisnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.buttonBrisi);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridViewUpisnica);
            this.Controls.Add(this.labelUcenik);
            this.Controls.Add(this.labelOdeljenje);
            this.Controls.Add(this.labelGodina);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.comboBoxOdeljenje);
            this.Controls.Add(this.comboBoxUcenik);
            this.Controls.Add(this.comboBoxGodina);
            this.Controls.Add(this.textBoxID);
            this.Name = "Upisnica";
            this.Text = "Upisnica";
            this.Load += new System.EventHandler(this.Upisnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpisnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ComboBox comboBoxGodina;
        private System.Windows.Forms.ComboBox comboBoxUcenik;
        private System.Windows.Forms.ComboBox comboBoxOdeljenje;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelGodina;
        private System.Windows.Forms.Label labelOdeljenje;
        private System.Windows.Forms.Label labelUcenik;
        private System.Windows.Forms.DataGridView dataGridViewUpisnica;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonBrisi;
    }
}