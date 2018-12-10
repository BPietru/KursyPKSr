namespace KursyPKS
{
    partial class KursyUpForm
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
            this.A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POCZATEK_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KONIEC_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_KIERUNKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CZAS_WYJAZDU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASAZEROWIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYGNATURA_KURSU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).BeginInit();
            this.SuspendLayout();
            // 
            // BckBtn
            // 
            this.BckBtn.Location = new System.Drawing.Point(44, 483);
            this.BckBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(137, 48);
            this.BckBtn.TabIndex = 20;
            this.BckBtn.Text = "Powrót";
            this.BckBtn.UseVisualStyleBackColor = true;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(241, 483);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(137, 48);
            this.RefreshBtn.TabIndex = 19;
            this.RefreshBtn.Text = "Odśwież";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(457, 420);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(137, 48);
            this.DelBtn.TabIndex = 18;
            this.DelBtn.Text = "Usuń";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(241, 420);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(137, 48);
            this.EditBtn.TabIndex = 17;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(44, 420);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(137, 48);
            this.AddBtn.TabIndex = 16;
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
            this.A_ID,
            this.POCZATEK_ID,
            this.KONIEC_ID,
            this.ID_KIERUNKU,
            this.DATA,
            this.CZAS_WYJAZDU,
            this.PASAZEROWIE,
            this.SYGNATURA_KURSU});
            this.dataGridView1.DataSource = this.Source;
            this.dataGridView1.Location = new System.Drawing.Point(44, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 366);
            this.dataGridView1.TabIndex = 15;
            // 
            // KU_ID
            // 
            this.KU_ID.DataPropertyName = "KU_ID";
            this.KU_ID.HeaderText = "Identyfikator Kursu";
            this.KU_ID.Name = "KU_ID";
            // 
            // A_ID
            // 
            this.A_ID.DataPropertyName = "A_ID";
            this.A_ID.HeaderText = "Autokar";
            this.A_ID.Name = "A_ID";
            // 
            // POCZATEK_ID
            // 
            this.POCZATEK_ID.DataPropertyName = "POCZATEK_ID";
            this.POCZATEK_ID.HeaderText = "Miejscowość początkowa";
            this.POCZATEK_ID.Name = "POCZATEK_ID";
            // 
            // KONIEC_ID
            // 
            this.KONIEC_ID.DataPropertyName = "KONIEC_ID";
            this.KONIEC_ID.HeaderText = "Miejscowość końcowa";
            this.KONIEC_ID.Name = "KONIEC_ID";
            // 
            // ID_KIERUNKU
            // 
            this.ID_KIERUNKU.DataPropertyName = "ID_KIERUNKU";
            this.ID_KIERUNKU.HeaderText = "Numer kierunku";
            this.ID_KIERUNKU.Name = "ID_KIERUNKU";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Identyfikator Kursu",
            "Autokar",
            "Miejscowość początkowa",
            "Miejscowość końcowa",
            "Numer kierunku",
            "Data"});
            this.comboBox1.Location = new System.Drawing.Point(687, 416);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(687, 446);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 483);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 48);
            this.button1.TabIndex = 23;
            this.button1.Text = "Filtruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Filtrowanie";
            // 
            // KursyUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(871, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BckBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KursyUpForm";
            this.Text = "KursyUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BckBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KU_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn POCZATEK_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KONIEC_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_KIERUNKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CZAS_WYJAZDU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASAZEROWIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYGNATURA_KURSU;
        private System.Windows.Forms.BindingSource Source;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}