namespace Memory
{
    partial class WprowadzDane
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
            this.nonEmptyNameWarning = new System.Windows.Forms.Label();
            this.AgreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nonEmptyNameWarning
            // 
            this.nonEmptyNameWarning.AutoSize = true;
            this.nonEmptyNameWarning.Location = new System.Drawing.Point(43, 9);
            this.nonEmptyNameWarning.Name = "nonEmptyNameWarning";
            this.nonEmptyNameWarning.Size = new System.Drawing.Size(208, 13);
            this.nonEmptyNameWarning.TabIndex = 0;
            this.nonEmptyNameWarning.Text = "Musisz wprowadzi niepuste imie i nazwisko";
            // 
            // AgreeButton
            // 
            this.AgreeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AgreeButton.Location = new System.Drawing.Point(102, 38);
            this.AgreeButton.Name = "AgreeButton";
            this.AgreeButton.Size = new System.Drawing.Size(75, 23);
            this.AgreeButton.TabIndex = 1;
            this.AgreeButton.Text = "OK";
            this.AgreeButton.UseVisualStyleBackColor = true;
            // 
            // WprowadzDane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 81);
            this.Controls.Add(this.AgreeButton);
            this.Controls.Add(this.nonEmptyNameWarning);
            this.Name = "WprowadzDane";
            this.Text = "WprowadzDane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nonEmptyNameWarning;
        private System.Windows.Forms.Button AgreeButton;
    }
}