namespace KursyPKS
{
    partial class KierunkiUpForm
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
            this.ID_KIERUNKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAZWA_KIERUNKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).BeginInit();
            this.SuspendLayout();
            // 
            // BckBtn
            // 
            this.BckBtn.Location = new System.Drawing.Point(27, 470);
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
            this.RefreshBtn.Location = new System.Drawing.Point(647, 403);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(137, 48);
            this.RefreshBtn.TabIndex = 37;
            this.RefreshBtn.Text = "Odśwież";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(440, 403);
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
            this.EditBtn.Location = new System.Drawing.Point(224, 403);
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
            this.AddBtn.Location = new System.Drawing.Point(27, 403);
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
            this.ID_KIERUNKU,
            this.NAZWA_KIERUNKU});
            this.dataGridView1.DataSource = this.Source;
            this.dataGridView1.Location = new System.Drawing.Point(27, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 366);
            this.dataGridView1.TabIndex = 33;
            // 
            // ID_KIERUNKU
            // 
            this.ID_KIERUNKU.DataPropertyName = "ID_KIERUNKU";
            this.ID_KIERUNKU.HeaderText = "Identyfikator kierunku";
            this.ID_KIERUNKU.Name = "ID_KIERUNKU";
            // 
            // NAZWA_KIERUNKU
            // 
            this.NAZWA_KIERUNKU.DataPropertyName = "NAZWA_KIERUNKU";
            this.NAZWA_KIERUNKU.HeaderText = "Nazwa kierunku";
            this.NAZWA_KIERUNKU.Name = "NAZWA_KIERUNKU";
            // 
            // KierunkiUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(865, 528);
            this.Controls.Add(this.BckBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KierunkiUpForm";
            this.Text = "KierunkiUpForm";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_KIERUNKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWA_KIERUNKU;
        private System.Windows.Forms.BindingSource Source;
    }
}