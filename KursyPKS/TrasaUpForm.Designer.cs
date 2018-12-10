namespace KursyPKS
{
    partial class TrasaUpForm
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
            this.BckBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KU_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMER_PRZYSTANKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CZAS_PRZEJAZDU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CENA_BILETU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).BeginInit();
            this.SuspendLayout();
            // 
            // BckBtn
            // 
            this.BckBtn.Location = new System.Drawing.Point(37, 470);
            this.BckBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(137, 48);
            this.BckBtn.TabIndex = 38;
            this.BckBtn.Text = "Powrót";
            this.BckBtn.UseVisualStyleBackColor = true;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(657, 403);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(137, 48);
            this.RefreshBtn.TabIndex = 37;
            this.RefreshBtn.Text = "Odśwież";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(450, 403);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(137, 48);
            this.DelBtn.TabIndex = 36;
            this.DelBtn.Text = "Usuń";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(234, 403);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(137, 48);
            this.EditBtn.TabIndex = 35;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(37, 403);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(137, 48);
            this.AddBtn.TabIndex = 34;
            this.AddBtn.Text = "Dodaj";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KU_ID,
            this.M_ID,
            this.NUMER_PRZYSTANKU,
            this.CZAS_PRZEJAZDU,
            this.CENA_BILETU});
            this.dataGridView1.DataSource = this.Source;
            this.dataGridView1.Location = new System.Drawing.Point(37, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 366);
            this.dataGridView1.TabIndex = 33;
            // 
            // KU_ID
            // 
            this.KU_ID.DataPropertyName = "KU_ID";
            this.KU_ID.HeaderText = "Identyfikator Kursu";
            this.KU_ID.Name = "KU_ID";
            // 
            // M_ID
            // 
            this.M_ID.DataPropertyName = "M_ID";
            this.M_ID.HeaderText = "Identyfikator miasta";
            this.M_ID.Name = "M_ID";
            // 
            // NUMER_PRZYSTANKU
            // 
            this.NUMER_PRZYSTANKU.DataPropertyName = "NUMER_PRZYSTANKU";
            this.NUMER_PRZYSTANKU.HeaderText = "Numer przystanku";
            this.NUMER_PRZYSTANKU.Name = "NUMER_PRZYSTANKU";
            // 
            // CZAS_PRZEJAZDU
            // 
            this.CZAS_PRZEJAZDU.DataPropertyName = "CZAS_PRZEJAZDU";
            this.CZAS_PRZEJAZDU.HeaderText = "Czas przejazdu";
            this.CZAS_PRZEJAZDU.Name = "CZAS_PRZEJAZDU";
            // 
            // CENA_BILETU
            // 
            this.CENA_BILETU.DataPropertyName = "CENA_BILETU";
            this.CENA_BILETU.HeaderText = "Cena biletu";
            this.CENA_BILETU.Name = "CENA_BILETU";
            // 
            // TrasaUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.BckBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TrasaUpForm";
            this.Text = "TrasaUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BckBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KU_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMER_PRZYSTANKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CZAS_PRZEJAZDU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CENA_BILETU;
        private System.Windows.Forms.BindingSource Source;
    }
}