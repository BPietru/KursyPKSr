namespace KursyPKS
{
    partial class PolaczeniaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BckBtn4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 302);
            this.dataGridView1.TabIndex = 9;
            // 
            // BckBtn4
            // 
            this.BckBtn4.Location = new System.Drawing.Point(35, 382);
            this.BckBtn4.Name = "BckBtn4";
            this.BckBtn4.Size = new System.Drawing.Size(92, 42);
            this.BckBtn4.TabIndex = 10;
            this.BckBtn4.Text = "Powrót";
            this.BckBtn4.UseVisualStyleBackColor = true;
            this.BckBtn4.Click += new System.EventHandler(this.BckBtn4_Click);
            // 
            // PolaczeniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.BckBtn4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PolaczeniaForm";
            this.Text = "PolaczeniaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BckBtn4;
    }
}