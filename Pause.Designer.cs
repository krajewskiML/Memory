namespace Memory
{
    partial class Pause
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
            this.PauzaLabel = new System.Windows.Forms.Label();
            this.ReversedCardLabel = new System.Windows.Forms.Label();
            this.TimeOfVisibilityNumeric = new System.Windows.Forms.NumericUpDown();
            this.ResumeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOfVisibilityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // PauzaLabel
            // 
            this.PauzaLabel.AutoSize = true;
            this.PauzaLabel.Location = new System.Drawing.Point(127, 9);
            this.PauzaLabel.Name = "PauzaLabel";
            this.PauzaLabel.Size = new System.Drawing.Size(112, 13);
            this.PauzaLabel.TabIndex = 1;
            this.PauzaLabel.Text = "Gra jest zapauzowana";
            // 
            // ReversedCardLabel
            // 
            this.ReversedCardLabel.AutoSize = true;
            this.ReversedCardLabel.Location = new System.Drawing.Point(12, 84);
            this.ReversedCardLabel.Name = "ReversedCardLabel";
            this.ReversedCardLabel.Size = new System.Drawing.Size(89, 26);
            this.ReversedCardLabel.TabIndex = 9;
            this.ReversedCardLabel.Text = "Czas widzialności\r\nodwróconej karty";
            // 
            // TimeOfVisibilityNumeric
            // 
            this.TimeOfVisibilityNumeric.Location = new System.Drawing.Point(230, 90);
            this.TimeOfVisibilityNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.TimeOfVisibilityNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.TimeOfVisibilityNumeric.Name = "TimeOfVisibilityNumeric";
            this.TimeOfVisibilityNumeric.Size = new System.Drawing.Size(120, 20);
            this.TimeOfVisibilityNumeric.TabIndex = 10;
            this.TimeOfVisibilityNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ResumeButton
            // 
            this.ResumeButton.Location = new System.Drawing.Point(148, 127);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(75, 23);
            this.ResumeButton.TabIndex = 11;
            this.ResumeButton.Text = "Wznów";
            this.ResumeButton.UseVisualStyleBackColor = true;
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // Pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 162);
            this.Controls.Add(this.ResumeButton);
            this.Controls.Add(this.TimeOfVisibilityNumeric);
            this.Controls.Add(this.ReversedCardLabel);
            this.Controls.Add(this.PauzaLabel);
            this.Name = "Pause";
            this.Text = "Pause";
            ((System.ComponentModel.ISupportInitialize)(this.TimeOfVisibilityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PauzaLabel;
        private System.Windows.Forms.Label ReversedCardLabel;
        private System.Windows.Forms.NumericUpDown TimeOfVisibilityNumeric;
        private System.Windows.Forms.Button ResumeButton;
    }
}