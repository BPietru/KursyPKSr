namespace KursyPKS
{
    partial class ChwilowyForm
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
            this.ChwBtn = new System.Windows.Forms.Button();
            this.BckBtn4 = new System.Windows.Forms.Button();
            this.DataBox1 = new System.Windows.Forms.TextBox();
            this.TimeBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.BindingSource(this.components);
            this.K_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAZWISKO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYGNATURA_KURSU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NR_REJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).BeginInit();
            this.SuspendLayout();
            // 
            // ChwBtn
            // 
            this.ChwBtn.Location = new System.Drawing.Point(53, 281);
            this.ChwBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChwBtn.Name = "ChwBtn";
            this.ChwBtn.Size = new System.Drawing.Size(123, 60);
            this.ChwBtn.TabIndex = 1;
            this.ChwBtn.Text = "Wygeneruj Raport Chwilowy";
            this.ChwBtn.UseVisualStyleBackColor = true;
            this.ChwBtn.Click += new System.EventHandler(this.ChwBtn_Click);
            // 
            // BckBtn4
            // 
            this.BckBtn4.Location = new System.Drawing.Point(53, 463);
            this.BckBtn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BckBtn4.Name = "BckBtn4";
            this.BckBtn4.Size = new System.Drawing.Size(123, 52);
            this.BckBtn4.TabIndex = 2;
            this.BckBtn4.Text = "Powrót";
            this.BckBtn4.UseVisualStyleBackColor = true;
            this.BckBtn4.Click += new System.EventHandler(this.BckBtn4_Click);
            // 
            // DataBox1
            // 
            this.DataBox1.Location = new System.Drawing.Point(53, 80);
            this.DataBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataBox1.Name = "DataBox1";
            this.DataBox1.Size = new System.Drawing.Size(121, 22);
            this.DataBox1.TabIndex = 3;
            // 
            // TimeBox1
            // 
            this.TimeBox1.Location = new System.Drawing.Point(53, 180);
            this.TimeBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeBox1.Name = "TimeBox1";
            this.TimeBox1.Size = new System.Drawing.Size(121, 22);
            this.TimeBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "   Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = " Godzina";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K_ID,
            this.IMIE,
            this.NAZWISKO,
            this.SYGNATURA_KURSU,
            this.NR_REJ});
            this.dataGridView1.DataSource = this.Source;
            this.dataGridView1.Location = new System.Drawing.Point(223, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 366);
            this.dataGridView1.TabIndex = 7;
            // 
            // K_ID
            // 
            this.K_ID.DataPropertyName = "K_ID";
            this.K_ID.HeaderText = "Identyfikator Kierowcy";
            this.K_ID.Name = "K_ID";
            // 
            // IMIE
            // 
            this.IMIE.DataPropertyName = "IMIE";
            this.IMIE.HeaderText = "Imię";
            this.IMIE.Name = "IMIE";
            // 
            // NAZWISKO
            // 
            this.NAZWISKO.DataPropertyName = "NAZWISKO";
            this.NAZWISKO.HeaderText = "Nazwisko";
            this.NAZWISKO.Name = "NAZWISKO";
            // 
            // SYGNATURA_KURSU
            // 
            this.SYGNATURA_KURSU.DataPropertyName = "SYGNATURA_KURSU";
            this.SYGNATURA_KURSU.HeaderText = "Sygnatura Kursu";
            this.SYGNATURA_KURSU.Name = "SYGNATURA_KURSU";
            // 
            // NR_REJ
            // 
            this.NR_REJ.DataPropertyName = "NR_REJ";
            this.NR_REJ.HeaderText = "Numer Rejastracyjny Pojazdu";
            this.NR_REJ.Name = "NR_REJ";
            // 
            // ChwilowyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(937, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeBox1);
            this.Controls.Add(this.DataBox1);
            this.Controls.Add(this.BckBtn4);
            this.Controls.Add(this.ChwBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChwilowyForm";
            this.Text = "ChwilowyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChwBtn;
        private System.Windows.Forms.Button BckBtn4;
        private System.Windows.Forms.TextBox DataBox1;
        private System.Windows.Forms.TextBox TimeBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWISKO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYGNATURA_KURSU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NR_REJ;
    }
}