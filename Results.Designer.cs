namespace Memory
{
    partial class Results
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
            this.Miejsce_pierwsze = new System.Windows.Forms.Label();
            this.miejsce_drugie = new System.Windows.Forms.Label();
            this.Miejsce_trzecie = new System.Windows.Forms.Label();
            this.pierwsze_imie = new System.Windows.Forms.Label();
            this.drugie_imie = new System.Windows.Forms.Label();
            this.trzecie_imie = new System.Windows.Forms.Label();
            this.pierwsze_score = new System.Windows.Forms.Label();
            this.drugie_score = new System.Windows.Forms.Label();
            this.trzecie_score = new System.Windows.Forms.Label();
            this.Najlepsi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Miejsce_pierwsze
            // 
            this.Miejsce_pierwsze.AutoSize = true;
            this.Miejsce_pierwsze.Location = new System.Drawing.Point(83, 78);
            this.Miejsce_pierwsze.Name = "Miejsce_pierwsze";
            this.Miejsce_pierwsze.Size = new System.Drawing.Size(16, 13);
            this.Miejsce_pierwsze.TabIndex = 0;
            this.Miejsce_pierwsze.Text = "1.";
            // 
            // miejsce_drugie
            // 
            this.miejsce_drugie.AutoSize = true;
            this.miejsce_drugie.Location = new System.Drawing.Point(86, 147);
            this.miejsce_drugie.Name = "miejsce_drugie";
            this.miejsce_drugie.Size = new System.Drawing.Size(16, 13);
            this.miejsce_drugie.TabIndex = 1;
            this.miejsce_drugie.Text = "2.";
            // 
            // Miejsce_trzecie
            // 
            this.Miejsce_trzecie.AutoSize = true;
            this.Miejsce_trzecie.Location = new System.Drawing.Point(86, 207);
            this.Miejsce_trzecie.Name = "Miejsce_trzecie";
            this.Miejsce_trzecie.Size = new System.Drawing.Size(16, 13);
            this.Miejsce_trzecie.TabIndex = 2;
            this.Miejsce_trzecie.Text = "3.";
            // 
            // pierwsze_imie
            // 
            this.pierwsze_imie.AutoSize = true;
            this.pierwsze_imie.Location = new System.Drawing.Point(206, 78);
            this.pierwsze_imie.Name = "pierwsze_imie";
            this.pierwsze_imie.Size = new System.Drawing.Size(35, 13);
            this.pierwsze_imie.TabIndex = 3;
            this.pierwsze_imie.Text = "label4";
            // 
            // drugie_imie
            // 
            this.drugie_imie.AutoSize = true;
            this.drugie_imie.Location = new System.Drawing.Point(206, 147);
            this.drugie_imie.Name = "drugie_imie";
            this.drugie_imie.Size = new System.Drawing.Size(35, 13);
            this.drugie_imie.TabIndex = 4;
            this.drugie_imie.Text = "label5";
            // 
            // trzecie_imie
            // 
            this.trzecie_imie.AutoSize = true;
            this.trzecie_imie.Location = new System.Drawing.Point(206, 207);
            this.trzecie_imie.Name = "trzecie_imie";
            this.trzecie_imie.Size = new System.Drawing.Size(35, 13);
            this.trzecie_imie.TabIndex = 5;
            this.trzecie_imie.Text = "label6";
            // 
            // pierwsze_score
            // 
            this.pierwsze_score.AutoSize = true;
            this.pierwsze_score.Location = new System.Drawing.Point(394, 78);
            this.pierwsze_score.Name = "pierwsze_score";
            this.pierwsze_score.Size = new System.Drawing.Size(35, 13);
            this.pierwsze_score.TabIndex = 6;
            this.pierwsze_score.Text = "label7";
            // 
            // drugie_score
            // 
            this.drugie_score.AutoSize = true;
            this.drugie_score.Location = new System.Drawing.Point(397, 147);
            this.drugie_score.Name = "drugie_score";
            this.drugie_score.Size = new System.Drawing.Size(0, 13);
            this.drugie_score.TabIndex = 7;
            // 
            // trzecie_score
            // 
            this.trzecie_score.AutoSize = true;
            this.trzecie_score.Location = new System.Drawing.Point(394, 207);
            this.trzecie_score.Name = "trzecie_score";
            this.trzecie_score.Size = new System.Drawing.Size(35, 13);
            this.trzecie_score.TabIndex = 8;
            this.trzecie_score.Text = "label9";
            // 
            // Najlepsi
            // 
            this.Najlepsi.AutoSize = true;
            this.Najlepsi.Location = new System.Drawing.Point(167, 9);
            this.Najlepsi.Name = "Najlepsi";
            this.Najlepsi.Size = new System.Drawing.Size(215, 13);
            this.Najlepsi.TabIndex = 10;
            this.Najlepsi.Text = "3 najlepszch graczy dla wybranego trybu gry";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(240, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Najlepsi);
            this.Controls.Add(this.trzecie_score);
            this.Controls.Add(this.drugie_score);
            this.Controls.Add(this.pierwsze_score);
            this.Controls.Add(this.trzecie_imie);
            this.Controls.Add(this.drugie_imie);
            this.Controls.Add(this.pierwsze_imie);
            this.Controls.Add(this.Miejsce_trzecie);
            this.Controls.Add(this.miejsce_drugie);
            this.Controls.Add(this.Miejsce_pierwsze);
            this.Name = "Results";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Miejsce_pierwsze;
        private System.Windows.Forms.Label miejsce_drugie;
        private System.Windows.Forms.Label Miejsce_trzecie;
        private System.Windows.Forms.Label pierwsze_imie;
        private System.Windows.Forms.Label drugie_imie;
        private System.Windows.Forms.Label trzecie_imie;
        private System.Windows.Forms.Label pierwsze_score;
        private System.Windows.Forms.Label drugie_score;
        private System.Windows.Forms.Label trzecie_score;
        private System.Windows.Forms.Label Najlepsi;
        private System.Windows.Forms.Button button1;
    }
}