namespace KursyPKS
{
    partial class HarmonogramForm
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
            this.DtL = new System.Windows.Forms.Label();
            this.DataBox1 = new System.Windows.Forms.TextBox();
            this.TygBtn2 = new System.Windows.Forms.Button();
            this.BckBtn4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.BindingSource(this.components);
            this.A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KU_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAZWA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CZAS_PRZYBYCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).BeginInit();
            this.SuspendLayout();
            // 
            // DtL
            // 
            this.DtL.AutoSize = true;
            this.DtL.Location = new System.Drawing.Point(57, 70);
            this.DtL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DtL.Name = "DtL";
            this.DtL.Size = new System.Drawing.Size(114, 17);
            this.DtL.TabIndex = 4;
            this.DtL.Text = "   Podaj ID Kursu";
            // 
            // DataBox1
            // 
            this.DataBox1.Location = new System.Drawing.Point(61, 122);
            this.DataBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataBox1.Name = "DataBox1";
            this.DataBox1.Size = new System.Drawing.Size(121, 22);
            this.DataBox1.TabIndex = 5;
            // 
            // TygBtn2
            // 
            this.TygBtn2.Location = new System.Drawing.Point(61, 194);
            this.TygBtn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TygBtn2.Name = "TygBtn2";
            this.TygBtn2.Size = new System.Drawing.Size(123, 60);
            this.TygBtn2.TabIndex = 6;
            this.TygBtn2.Text = "Pokaż Harmonogram";
            this.TygBtn2.UseVisualStyleBackColor = true;
            this.TygBtn2.Click += new System.EventHandler(this.TygBtn2_Click);
            // 
            // BckBtn4
            // 
            this.BckBtn4.Location = new System.Drawing.Point(61, 465);
            this.BckBtn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BckBtn4.Name = "BckBtn4";
            this.BckBtn4.Size = new System.Drawing.Size(123, 52);
            this.BckBtn4.TabIndex = 7;
            this.BckBtn4.Text = "Powrót";
            this.BckBtn4.UseVisualStyleBackColor = true;
            this.BckBtn4.Click += new System.EventHandler(this.BckBtn4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A_ID,
            this.Marka,
            this.KU_ID,
            this.NAZWA,
            this.CZAS_PRZYBYCIA});
            this.dataGridView1.DataSource = this.Source;
            this.dataGridView1.Location = new System.Drawing.Point(248, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 366);
            this.dataGridView1.TabIndex = 8;
            // 
            // A_ID
            // 
            this.A_ID.DataPropertyName = "A_ID";
            this.A_ID.HeaderText = "Identyfikator Autokaru";
            this.A_ID.Name = "A_ID";
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "MARKA";
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            // 
            // KU_ID
            // 
            this.KU_ID.DataPropertyName = "KU_ID";
            this.KU_ID.HeaderText = "Identyfikator Kursu";
            this.KU_ID.Name = "KU_ID";
            // 
            // NAZWA
            // 
            this.NAZWA.DataPropertyName = "NAZWA";
            this.NAZWA.HeaderText = "Miejscowość";
            this.NAZWA.Name = "NAZWA";
            // 
            // CZAS_PRZYBYCIA
            // 
            this.CZAS_PRZYBYCIA.DataPropertyName = "CZAS_PRZYBYCIA";
            this.CZAS_PRZYBYCIA.HeaderText = "Czas Przybycia";
            this.CZAS_PRZYBYCIA.Name = "CZAS_PRZYBYCIA";
            // 
            // HarmonogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(892, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BckBtn4);
            this.Controls.Add(this.TygBtn2);
            this.Controls.Add(this.DataBox1);
            this.Controls.Add(this.DtL);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HarmonogramForm";
            this.Text = "HarmonogramForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DtL;
        private System.Windows.Forms.TextBox DataBox1;
        private System.Windows.Forms.Button TygBtn2;
        private System.Windows.Forms.Button BckBtn4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn KU_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CZAS_PRZYBYCIA;
    }
}