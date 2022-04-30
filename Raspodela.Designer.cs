
namespace eDnevnik
{
    partial class Raspodela
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
            this.comboBoxNastavnik = new System.Windows.Forms.ComboBox();
            this.comboBoxGodina = new System.Windows.Forms.ComboBox();
            this.comboBoxPredmet = new System.Windows.Forms.ComboBox();
            this.comboBoxOdeljenje = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelGodina = new System.Windows.Forms.Label();
            this.labelNastavnik = new System.Windows.Forms.Label();
            this.labelPredmet = new System.Windows.Forms.Label();
            this.labelOdeljenje = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonBrisi = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxNastavnik
            // 
            this.comboBoxNastavnik.FormattingEnabled = true;
            this.comboBoxNastavnik.Location = new System.Drawing.Point(375, 148);
            this.comboBoxNastavnik.Name = "comboBoxNastavnik";
            this.comboBoxNastavnik.Size = new System.Drawing.Size(221, 24);
            this.comboBoxNastavnik.TabIndex = 0;
            // 
            // comboBoxGodina
            // 
            this.comboBoxGodina.FormattingEnabled = true;
            this.comboBoxGodina.Location = new System.Drawing.Point(375, 109);
            this.comboBoxGodina.Name = "comboBoxGodina";
            this.comboBoxGodina.Size = new System.Drawing.Size(221, 24);
            this.comboBoxGodina.TabIndex = 1;
            // 
            // comboBoxPredmet
            // 
            this.comboBoxPredmet.FormattingEnabled = true;
            this.comboBoxPredmet.Location = new System.Drawing.Point(375, 187);
            this.comboBoxPredmet.Name = "comboBoxPredmet";
            this.comboBoxPredmet.Size = new System.Drawing.Size(221, 24);
            this.comboBoxPredmet.TabIndex = 2;
            // 
            // comboBoxOdeljenje
            // 
            this.comboBoxOdeljenje.FormattingEnabled = true;
            this.comboBoxOdeljenje.Location = new System.Drawing.Point(375, 226);
            this.comboBoxOdeljenje.Name = "comboBoxOdeljenje";
            this.comboBoxOdeljenje.Size = new System.Drawing.Size(221, 24);
            this.comboBoxOdeljenje.TabIndex = 3;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(214, 73);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID";
            // 
            // labelGodina
            // 
            this.labelGodina.AutoSize = true;
            this.labelGodina.Location = new System.Drawing.Point(214, 116);
            this.labelGodina.Name = "labelGodina";
            this.labelGodina.Size = new System.Drawing.Size(54, 17);
            this.labelGodina.TabIndex = 5;
            this.labelGodina.Text = "Godina";
            // 
            // labelNastavnik
            // 
            this.labelNastavnik.AutoSize = true;
            this.labelNastavnik.Location = new System.Drawing.Point(214, 155);
            this.labelNastavnik.Name = "labelNastavnik";
            this.labelNastavnik.Size = new System.Drawing.Size(70, 17);
            this.labelNastavnik.TabIndex = 6;
            this.labelNastavnik.Text = "Nastavnik";
            // 
            // labelPredmet
            // 
            this.labelPredmet.AutoSize = true;
            this.labelPredmet.Location = new System.Drawing.Point(214, 194);
            this.labelPredmet.Name = "labelPredmet";
            this.labelPredmet.Size = new System.Drawing.Size(61, 17);
            this.labelPredmet.TabIndex = 7;
            this.labelPredmet.Text = "Predmet";
            // 
            // labelOdeljenje
            // 
            this.labelOdeljenje.AutoSize = true;
            this.labelOdeljenje.Location = new System.Drawing.Point(214, 233);
            this.labelOdeljenje.Name = "labelOdeljenje";
            this.labelOdeljenje.Size = new System.Drawing.Size(68, 17);
            this.labelOdeljenje.TabIndex = 8;
            this.labelOdeljenje.Text = "Odeljenje";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(375, 68);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(221, 22);
            this.textBoxID.TabIndex = 9;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(132, 321);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 10;
            this.buttonFirst.Text = "|<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(213, 321);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 11;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(294, 321);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 12;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(375, 321);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmeni.TabIndex = 13;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonBrisi
            // 
            this.buttonBrisi.Location = new System.Drawing.Point(456, 321);
            this.buttonBrisi.Name = "buttonBrisi";
            this.buttonBrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonBrisi.TabIndex = 14;
            this.buttonBrisi.Text = "Brisi";
            this.buttonBrisi.UseVisualStyleBackColor = true;
            this.buttonBrisi.Click += new System.EventHandler(this.buttonBrisi_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(537, 321);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 15;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(618, 321);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 16;
            this.buttonLast.Text = ">>|";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // Raspodela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBrisi);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelOdeljenje);
            this.Controls.Add(this.labelPredmet);
            this.Controls.Add(this.labelNastavnik);
            this.Controls.Add(this.labelGodina);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.comboBoxOdeljenje);
            this.Controls.Add(this.comboBoxPredmet);
            this.Controls.Add(this.comboBoxGodina);
            this.Controls.Add(this.comboBoxNastavnik);
            this.Name = "Raspodela";
            this.Text = "Raspodela";
            this.Load += new System.EventHandler(this.Raspodela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNastavnik;
        private System.Windows.Forms.ComboBox comboBoxGodina;
        private System.Windows.Forms.ComboBox comboBoxPredmet;
        private System.Windows.Forms.ComboBox comboBoxOdeljenje;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelGodina;
        private System.Windows.Forms.Label labelNastavnik;
        private System.Windows.Forms.Label labelPredmet;
        private System.Windows.Forms.Label labelOdeljenje;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonBrisi;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
    }
}