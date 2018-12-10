namespace KursyPKS
{
    partial class FindForm
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TygBtn2 = new System.Windows.Forms.Button();
            this.BckBtn4 = new System.Windows.Forms.Button();
            this.DtL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.BindingSource(this.components);
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CZAS_WYJAZDU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASAZEROWIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYGNATURA_KURSU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 220);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(44, 292);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 22);
            this.textBox3.TabIndex = 13;
            // 
            // TygBtn2
            // 
            this.TygBtn2.Location = new System.Drawing.Point(67, 358);
            this.TygBtn2.Margin = new System.Windows.Forms.Padding(4);
            this.TygBtn2.Name = "TygBtn2";
            this.TygBtn2.Size = new System.Drawing.Size(123, 60);
            this.TygBtn2.TabIndex = 14;
            this.TygBtn2.Text = "Znajdź Połączenie";
            this.TygBtn2.UseVisualStyleBackColor = true;
            this.TygBtn2.Click += new System.EventHandler(this.TygBtn2_Click);
            // 
            // BckBtn4
            // 
            this.BckBtn4.Location = new System.Drawing.Point(67, 471);
            this.BckBtn4.Margin = new System.Windows.Forms.Padding(4);
            this.BckBtn4.Name = "BckBtn4";
            this.BckBtn4.Size = new System.Drawing.Size(123, 52);
            this.BckBtn4.TabIndex = 15;
            this.BckBtn4.Text = "Powrót";
            this.BckBtn4.UseVisualStyleBackColor = true;
            this.BckBtn4.Click += new System.EventHandler(this.BckBtn4_Click);
            // 
            // DtL
            // 
            this.DtL.AutoSize = true;
            this.DtL.Location = new System.Drawing.Point(40, 42);
            this.DtL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DtL.Name = "DtL";
            this.DtL.Size = new System.Drawing.Size(165, 17);
            this.DtL.TabIndex = 16;
            this.DtL.Text = "Miejscowość Początkowa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "  Miejscowość Końcowa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "   Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Godzina";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MIASTKO",
            "RYBNIK",
            "GDYNIA",
            "KOSZALIN",
            "WARSZAWA",
            "WROCLAW",
            "BOZE POLE",
            "SIEMANOWICE",
            "POLANOW"});
            this.comboBox1.Location = new System.Drawing.Point(44, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "MIASTKO",
            "RYBNIK",
            "GDYNIA",
            "KOSZALIN",
            "WARSZAWA",
            "WROCLAW",
            "BOZE POLE",
            "SIEMANOWICE",
            "POLANOW"});
            this.comboBox2.Location = new System.Drawing.Point(43, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 24);
            this.comboBox2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATA,
            this.CZAS_WYJAZDU,
            this.PASAZEROWIE,
            this.SYGNATURA_KURSU});
            this.dataGridView1.DataSource = this.Source;
            this.dataGridView1.Location = new System.Drawing.Point(237, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 366);
            this.dataGridView1.TabIndex = 22;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA";
            this.DATA.HeaderText = "Data";
            this.DATA.Name = "DATA";
            // 
            // CZAS_WYJAZDU
            // 
            this.CZAS_WYJAZDU.DataPropertyName = "CZAS_WYJAZDU";
            this.CZAS_WYJAZDU.HeaderText = "Czas wyjazdu";
            this.CZAS_WYJAZDU.Name = "CZAS_WYJAZDU";
            // 
            // PASAZEROWIE
            // 
            this.PASAZEROWIE.DataPropertyName = "PASAZEROWIE";
            this.PASAZEROWIE.HeaderText = "Pasażerowie";
            this.PASAZEROWIE.Name = "PASAZEROWIE";
            // 
            // SYGNATURA_KURSU
            // 
            this.SYGNATURA_KURSU.DataPropertyName = "SYGNATURA_KURSU";
            this.SYGNATURA_KURSU.HeaderText = "Sygnatura kursu";
            this.SYGNATURA_KURSU.Name = "SYGNATURA_KURSU";
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(880, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtL);
            this.Controls.Add(this.BckBtn4);
            this.Controls.Add(this.TygBtn2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FindForm";
            this.Text = "FindForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button TygBtn2;
        private System.Windows.Forms.Button BckBtn4;
        private System.Windows.Forms.Label DtL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CZAS_WYJAZDU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASAZEROWIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYGNATURA_KURSU;
    }
}