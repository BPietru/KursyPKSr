namespace KursyPKS
{
    partial class TygodniowyForm
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
            this.TygBtn2 = new System.Windows.Forms.Button();
            this.BckBtn4 = new System.Windows.Forms.Button();
            this.DataBox1 = new System.Windows.Forms.TextBox();
            this.DtL = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.BindingSource(this.components);
            this.KU_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LLICZBA_PASAZEROW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).BeginInit();
            this.SuspendLayout();
            // 
            // TygBtn2
            // 
            this.TygBtn2.Location = new System.Drawing.Point(36, 251);
            this.TygBtn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TygBtn2.Name = "TygBtn2";
            this.TygBtn2.Size = new System.Drawing.Size(123, 60);
            this.TygBtn2.TabIndex = 0;
            this.TygBtn2.Text = "Wygeneruj Raport Tygodniowy";
            this.TygBtn2.UseVisualStyleBackColor = true;
            this.TygBtn2.Click += new System.EventHandler(this.TygBtn2_Click);
            // 
            // BckBtn4
            // 
            this.BckBtn4.Location = new System.Drawing.Point(36, 463);
            this.BckBtn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BckBtn4.Name = "BckBtn4";
            this.BckBtn4.Size = new System.Drawing.Size(123, 52);
            this.BckBtn4.TabIndex = 1;
            this.BckBtn4.Text = "Powrót";
            this.BckBtn4.UseVisualStyleBackColor = true;
            this.BckBtn4.Click += new System.EventHandler(this.BckBtn4_Click);
            // 
            // DataBox1
            // 
            this.DataBox1.Location = new System.Drawing.Point(36, 114);
            this.DataBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataBox1.Name = "DataBox1";
            this.DataBox1.Size = new System.Drawing.Size(121, 22);
            this.DataBox1.TabIndex = 2;
            // 
            // DtL
            // 
            this.DtL.AutoSize = true;
            this.DtL.Location = new System.Drawing.Point(16, 80);
            this.DtL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DtL.Name = "DtL";
            this.DtL.Size = new System.Drawing.Size(159, 17);
            this.DtL.TabIndex = 3;
            this.DtL.Text = "Wpisz Date Początkową";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KU_ID,
            this.LLICZBA_PASAZEROW});
            this.dataGridView1.DataSource = this.Source;
            this.dataGridView1.Location = new System.Drawing.Point(210, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 366);
            this.dataGridView1.TabIndex = 8;
            // 
            // KU_ID
            // 
            this.KU_ID.DataPropertyName = "KU_ID";
            this.KU_ID.HeaderText = "Identyfikator Kursu";
            this.KU_ID.Name = "KU_ID";
            // 
            // LLICZBA_PASAZEROW
            // 
            this.LLICZBA_PASAZEROW.DataPropertyName = "LLICZBA_PASAZEROW";
            this.LLICZBA_PASAZEROW.HeaderText = "Liczba Pasażerów";
            this.LLICZBA_PASAZEROW.Name = "LLICZBA_PASAZEROW";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 197);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Podaj Identyfikator Kursu";
            // 
            // TygodniowyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(841, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DtL);
            this.Controls.Add(this.DataBox1);
            this.Controls.Add(this.BckBtn4);
            this.Controls.Add(this.TygBtn2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TygodniowyForm";
            this.Text = "TygodniowyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TygBtn2;
        private System.Windows.Forms.Button BckBtn4;
        private System.Windows.Forms.TextBox DataBox1;
        private System.Windows.Forms.Label DtL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn KU_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LLICZBA_PASAZEROW;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}