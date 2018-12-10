namespace KursyPKS
{
    partial class PsgForm
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
            this.LstBtn = new System.Windows.Forms.Button();
            this.ZndBtn = new System.Windows.Forms.Button();
            this.BckBtn2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstBtn
            // 
            this.LstBtn.Location = new System.Drawing.Point(312, 65);
            this.LstBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LstBtn.Name = "LstBtn";
            this.LstBtn.Size = new System.Drawing.Size(205, 86);
            this.LstBtn.TabIndex = 0;
            this.LstBtn.Text = "Lista połączeń";
            this.LstBtn.UseVisualStyleBackColor = true;
            this.LstBtn.Click += new System.EventHandler(this.LstBtn_Click);
            // 
            // ZndBtn
            // 
            this.ZndBtn.Location = new System.Drawing.Point(312, 331);
            this.ZndBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ZndBtn.Name = "ZndBtn";
            this.ZndBtn.Size = new System.Drawing.Size(205, 81);
            this.ZndBtn.TabIndex = 1;
            this.ZndBtn.Text = "Znajdź Połączenie";
            this.ZndBtn.UseVisualStyleBackColor = true;
            this.ZndBtn.Click += new System.EventHandler(this.ZndBtn_Click);
            // 
            // BckBtn2
            // 
            this.BckBtn2.Location = new System.Drawing.Point(47, 453);
            this.BckBtn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BckBtn2.Name = "BckBtn2";
            this.BckBtn2.Size = new System.Drawing.Size(140, 66);
            this.BckBtn2.TabIndex = 2;
            this.BckBtn2.Text = "Powrót";
            this.BckBtn2.UseVisualStyleBackColor = true;
            this.BckBtn2.Click += new System.EventHandler(this.BckBtn2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 86);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zobacz przebeig kursu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(849, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BckBtn2);
            this.Controls.Add(this.ZndBtn);
            this.Controls.Add(this.LstBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PsgForm";
            this.Text = "Panel Pasażera";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LstBtn;
        private System.Windows.Forms.Button ZndBtn;
        private System.Windows.Forms.Button BckBtn2;
        private System.Windows.Forms.Button button1;
    }
}