
namespace eDnevnik
{
    partial class Sifarnik
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
            this.dataGridViewTabela = new System.Windows.Forms.DataGridView();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTabela
            // 
            this.dataGridViewTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabela.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTabela.Name = "dataGridViewTabela";
            this.dataGridViewTabela.RowHeadersWidth = 51;
            this.dataGridViewTabela.RowTemplate.Height = 24;
            this.dataGridViewTabela.Size = new System.Drawing.Size(776, 295);
            this.dataGridViewTabela.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(366, 366);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Sifarnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridViewTabela);
            this.Name = "Sifarnik";
            this.Text = "Sifarnik";
            this.Load += new System.EventHandler(this.Sifarnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTabela;
        private System.Windows.Forms.Button buttonOK;
    }
}