namespace KursyPKS
{
    partial class AutokaryKierowcyQuery
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
            this.components = new System.ComponentModel.Container();
            this.BckBtn3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.BindingSource(this.components);
            this.A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NR_REJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARKA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAZWISKO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).BeginInit();
            this.SuspendLayout();
            // 
            // BckBtn3
            // 
            this.BckBtn3.Location = new System.Drawing.Point(34, 363);
            this.BckBtn3.Margin = new System.Windows.Forms.Padding(4);
            this.BckBtn3.Name = "BckBtn3";
            this.BckBtn3.Size = new System.Drawing.Size(133, 59);
            this.BckBtn3.TabIndex = 12;
            this.BckBtn3.Text = "Powrót";
            this.BckBtn3.UseVisualStyleBackColor = true;
            this.BckBtn3.Click += new System.EventHandler(this.BckBtn3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A_ID,
            this.K_ID,
            this.NR_REJ,
            this.MARKA,
            this.MODEL,
            this.IMIE,
            this.NAZWISKO,
            this.PESEL});
            this.dataGridView1.DataSource = this.Source;
            this.dataGridView1.Location = new System.Drawing.Point(64, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(662, 271);
            this.dataGridView1.TabIndex = 13;
            // 
            // A_ID
            // 
            this.A_ID.DataPropertyName = "A_ID";
            this.A_ID.HeaderText = "Identyfikator Autokaru";
            this.A_ID.Name = "A_ID";
            // 
            // K_ID
            // 
            this.K_ID.DataPropertyName = "K_ID";
            this.K_ID.HeaderText = "Identyfikator Kierowcy";
            this.K_ID.Name = "K_ID";
            // 
            // NR_REJ
            // 
            this.NR_REJ.DataPropertyName = "NR_REJ";
            this.NR_REJ.HeaderText = "Numer rejestracyjny";
            this.NR_REJ.Name = "NR_REJ";
            // 
            // MARKA
            // 
            this.MARKA.DataPropertyName = "MARKA";
            this.MARKA.HeaderText = "Marka";
            this.MARKA.Name = "MARKA";
            // 
            // MODEL
            // 
            this.MODEL.DataPropertyName = "MODEL";
            this.MODEL.HeaderText = "Model";
            this.MODEL.Name = "MODEL";
            // 
            // IMIE
            // 
            this.IMIE.DataPropertyName = "IMIE";
            this.IMIE.HeaderText = "Imię Kierowcy";
            this.IMIE.Name = "IMIE";
            // 
            // NAZWISKO
            // 
            this.NAZWISKO.DataPropertyName = "NAZWISKO";
            this.NAZWISKO.HeaderText = "Nazwisko Kierowcy";
            this.NAZWISKO.Name = "NAZWISKO";
            // 
            // PESEL
            // 
            this.PESEL.DataPropertyName = "PESEL";
            this.PESEL.HeaderText = "PESEL";
            this.PESEL.Name = "PESEL";
            // 
            // AutokaryKierowcyQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BckBtn3);
            this.Name = "AutokaryKierowcyQuery";
            this.Text = "AutokaryKierowcyQuery";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BckBtn3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NR_REJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARKA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWISKO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESEL;
    }
}