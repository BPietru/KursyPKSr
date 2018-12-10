namespace KursyPKS
{
    partial class LookUpForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Identyfikator_Autokaru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.K_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NR_REJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liczba_miejsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.BindingSource(this.components);
            this.AddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.BckBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identyfikator_Autokaru,
            this.K_ID,
            this.NR_REJ,
            this.Marka,
            this.Model,
            this.Liczba_miejsc});
            this.dataGridView1.DataSource = this.Source;
            this.dataGridView1.Location = new System.Drawing.Point(49, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 366);
            this.dataGridView1.TabIndex = 9;
            // 
            // Identyfikator_Autokaru
            // 
            this.Identyfikator_Autokaru.DataPropertyName = "A_ID";
            this.Identyfikator_Autokaru.HeaderText = "Identyfikator_Autokaru";
            this.Identyfikator_Autokaru.Name = "Identyfikator_Autokaru";
            // 
            // K_ID
            // 
            this.K_ID.DataPropertyName = "K_ID";
            this.K_ID.HeaderText = "Kierowca";
            this.K_ID.Name = "K_ID";
            // 
            // NR_REJ
            // 
            this.NR_REJ.DataPropertyName = "NR_REJ";
            this.NR_REJ.HeaderText = "Numer Rejestracji";
            this.NR_REJ.Name = "NR_REJ";
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "MARKA";
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            // 
            // Model
            // 
            this.Model.DataPropertyName = "MODEL";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // Liczba_miejsc
            // 
            this.Liczba_miejsc.DataPropertyName = "LICZBA_MIEJSC";
            this.Liczba_miejsc.HeaderText = "Liczba miejsc";
            this.Liczba_miejsc.Name = "Liczba_miejsc";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(49, 423);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(137, 48);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Dodaj";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(264, 423);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(137, 48);
            this.EditBtn.TabIndex = 11;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(485, 423);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(137, 48);
            this.DelBtn.TabIndex = 12;
            this.DelBtn.Text = "Usuń";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(713, 423);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(137, 48);
            this.RefreshBtn.TabIndex = 13;
            this.RefreshBtn.Text = "Odśwież";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // BckBtn
            // 
            this.BckBtn.Location = new System.Drawing.Point(49, 491);
            this.BckBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(137, 48);
            this.BckBtn.TabIndex = 14;
            this.BckBtn.Text = "Powrót";
            this.BckBtn.UseVisualStyleBackColor = true;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // LookUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(897, 554);
            this.Controls.Add(this.BckBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LookUpForm";
            this.Text = "LookUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button BckBtn;
        private System.Windows.Forms.BindingSource Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identyfikator_Autokaru;
        private System.Windows.Forms.DataGridViewTextBoxColumn K_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NR_REJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Liczba_miejsc;
    }
}