namespace KursyPKS
{
    partial class DsgForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TygBtn = new System.Windows.Forms.Button();
            this.AktBtn = new System.Windows.Forms.Button();
            this.HarBtn = new System.Windows.Forms.Button();
            this.BckBtn3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(390, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Raporty";
            // 
            // TygBtn
            // 
            this.TygBtn.Location = new System.Drawing.Point(241, 173);
            this.TygBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TygBtn.Name = "TygBtn";
            this.TygBtn.Size = new System.Drawing.Size(149, 62);
            this.TygBtn.TabIndex = 8;
            this.TygBtn.Text = "Tygodniowy";
            this.TygBtn.UseVisualStyleBackColor = true;
            this.TygBtn.Click += new System.EventHandler(this.TygBtn_Click);
            // 
            // AktBtn
            // 
            this.AktBtn.Location = new System.Drawing.Point(241, 289);
            this.AktBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AktBtn.Name = "AktBtn";
            this.AktBtn.Size = new System.Drawing.Size(149, 62);
            this.AktBtn.TabIndex = 9;
            this.AktBtn.Text = "Chwilowy";
            this.AktBtn.UseVisualStyleBackColor = true;
            this.AktBtn.Click += new System.EventHandler(this.AktBtn_Click);
            // 
            // HarBtn
            // 
            this.HarBtn.Location = new System.Drawing.Point(500, 173);
            this.HarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HarBtn.Name = "HarBtn";
            this.HarBtn.Size = new System.Drawing.Size(149, 62);
            this.HarBtn.TabIndex = 10;
            this.HarBtn.Text = "Harmonogram ruchu pojazdu";
            this.HarBtn.UseVisualStyleBackColor = true;
            this.HarBtn.Click += new System.EventHandler(this.HarBtn_Click);
            // 
            // BckBtn3
            // 
            this.BckBtn3.Location = new System.Drawing.Point(35, 480);
            this.BckBtn3.Margin = new System.Windows.Forms.Padding(4);
            this.BckBtn3.Name = "BckBtn3";
            this.BckBtn3.Size = new System.Drawing.Size(133, 59);
            this.BckBtn3.TabIndex = 11;
            this.BckBtn3.Text = "Powrót";
            this.BckBtn3.UseVisualStyleBackColor = true;
            this.BckBtn3.Click += new System.EventHandler(this.BckBtn3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 62);
            this.button1.TabIndex = 12;
            this.button1.Text = "Autokary - kierowcy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(901, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BckBtn3);
            this.Controls.Add(this.HarBtn);
            this.Controls.Add(this.AktBtn);
            this.Controls.Add(this.TygBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DsgForm";
            this.Text = "Panel Dyżurnego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TygBtn;
        private System.Windows.Forms.Button AktBtn;
        private System.Windows.Forms.Button HarBtn;
        private System.Windows.Forms.Button BckBtn3;
        private System.Windows.Forms.Button button1;
    }
}