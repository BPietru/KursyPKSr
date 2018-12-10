namespace KursyPKS
{
    partial class PrzebiegForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BckBtn4 = new System.Windows.Forms.Button();
            this.TygBtn2 = new System.Windows.Forms.Button();
            this.NAZWA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMER_PRZYSTANKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Podaj Identyfikator Kursu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAZWA,
            this.NUMER_PRZYSTANKU});
            this.dataGridView1.DataSource = this.Source;
            this.dataGridView1.Location = new System.Drawing.Point(214, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 366);
            this.dataGridView1.TabIndex = 15;
            // 
            // BckBtn4
            // 
            this.BckBtn4.Location = new System.Drawing.Point(40, 415);
            this.BckBtn4.Margin = new System.Windows.Forms.Padding(4);
            this.BckBtn4.Name = "BckBtn4";
            this.BckBtn4.Size = new System.Drawing.Size(123, 52);
            this.BckBtn4.TabIndex = 12;
            this.BckBtn4.Text = "Powrót";
            this.BckBtn4.UseVisualStyleBackColor = true;
            this.BckBtn4.Click += new System.EventHandler(this.BckBtn4_Click);
            // 
            // TygBtn2
            // 
            this.TygBtn2.Location = new System.Drawing.Point(40, 115);
            this.TygBtn2.Margin = new System.Windows.Forms.Padding(4);
            this.TygBtn2.Name = "TygBtn2";
            this.TygBtn2.Size = new System.Drawing.Size(123, 60);
            this.TygBtn2.TabIndex = 11;
            this.TygBtn2.Text = "Sprawdz Przebieg Trasy";
            this.TygBtn2.UseVisualStyleBackColor = true;
            this.TygBtn2.Click += new System.EventHandler(this.TygBtn2_Click);
            // 
            // NAZWA
            // 
            this.NAZWA.DataPropertyName = "NAZWA";
            this.NAZWA.HeaderText = "Miejscowosc";
            this.NAZWA.Name = "NAZWA";
            // 
            // NUMER_PRZYSTANKU
            // 
            this.NUMER_PRZYSTANKU.DataPropertyName = "NUMER_PRZYSTANKU";
            this.NUMER_PRZYSTANKU.HeaderText = "Numer na trasie";
            this.NUMER_PRZYSTANKU.Name = "NUMER_PRZYSTANKU";
            // 
            // PrzebiegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(918, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BckBtn4);
            this.Controls.Add(this.TygBtn2);
            this.Name = "PrzebiegForm";
            this.Text = "PrzebiegForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BckBtn4;
        private System.Windows.Forms.Button TygBtn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMER_PRZYSTANKU;
        private System.Windows.Forms.BindingSource Source;
    }
}