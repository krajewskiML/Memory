namespace Memory
{
    partial class Configure
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
            this.CardsNumberLabel = new System.Windows.Forms.Label();
            this.TimeToSeeLabel = new System.Windows.Forms.Label();
            this.ConfigureSettingButton = new System.Windows.Forms.Button();
            this.TimeToSeeNumeric = new System.Windows.Forms.NumericUpDown();
            this.Sizes = new System.Windows.Forms.CheckedListBox();
            this.ReversedCardLabel = new System.Windows.Forms.Label();
            this.TimeOfVisibilityNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TimeToSeeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOfVisibilityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // CardsNumberLabel
            // 
            this.CardsNumberLabel.AutoSize = true;
            this.CardsNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardsNumberLabel.Location = new System.Drawing.Point(3, 31);
            this.CardsNumberLabel.Name = "CardsNumberLabel";
            this.CardsNumberLabel.Size = new System.Drawing.Size(152, 32);
            this.CardsNumberLabel.TabIndex = 1;
            this.CardsNumberLabel.Text = "Wybierz rozmiar planszy\r\n\r\n";
            this.CardsNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeToSeeLabel
            // 
            this.TimeToSeeLabel.AutoSize = true;
            this.TimeToSeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeToSeeLabel.Location = new System.Drawing.Point(3, 101);
            this.TimeToSeeLabel.Name = "TimeToSeeLabel";
            this.TimeToSeeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeToSeeLabel.Size = new System.Drawing.Size(139, 48);
            this.TimeToSeeLabel.TabIndex = 2;
            this.TimeToSeeLabel.Text = "Czas na zapamiętanie\r\nkart  (0 - 120 sekund)\r\n\r\n";
            this.TimeToSeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfigureSettingButton
            // 
            this.ConfigureSettingButton.Location = new System.Drawing.Point(167, 248);
            this.ConfigureSettingButton.Name = "ConfigureSettingButton";
            this.ConfigureSettingButton.Size = new System.Drawing.Size(75, 23);
            this.ConfigureSettingButton.TabIndex = 4;
            this.ConfigureSettingButton.Text = "OK";
            this.ConfigureSettingButton.UseVisualStyleBackColor = true;
            this.ConfigureSettingButton.Click += new System.EventHandler(this.ConfigureSettingButton_Click);
            // 
            // TimeToSeeNumeric
            // 
            this.TimeToSeeNumeric.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.TimeToSeeNumeric.Location = new System.Drawing.Point(167, 112);
            this.TimeToSeeNumeric.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.TimeToSeeNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.TimeToSeeNumeric.Name = "TimeToSeeNumeric";
            this.TimeToSeeNumeric.Size = new System.Drawing.Size(120, 20);
            this.TimeToSeeNumeric.TabIndex = 6;
            this.TimeToSeeNumeric.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            // 
            // Sizes
            // 
            this.Sizes.CheckOnClick = true;
            this.Sizes.FormattingEnabled = true;
            this.Sizes.Items.AddRange(new object[] {
            "6 x 8",
            "7 x 12",
            "10 x 12"});
            this.Sizes.Location = new System.Drawing.Point(167, 22);
            this.Sizes.Name = "Sizes";
            this.Sizes.Size = new System.Drawing.Size(120, 49);
            this.Sizes.TabIndex = 7;
            this.Sizes.SelectedIndexChanged += new System.EventHandler(this.Sizes_SelectedIndexChanged);
            // 
            // ReversedCardLabel
            // 
            this.ReversedCardLabel.AutoSize = true;
            this.ReversedCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReversedCardLabel.Location = new System.Drawing.Point(3, 193);
            this.ReversedCardLabel.Name = "ReversedCardLabel";
            this.ReversedCardLabel.Size = new System.Drawing.Size(112, 32);
            this.ReversedCardLabel.TabIndex = 8;
            this.ReversedCardLabel.Text = "Czas widzialności\r\nodwróconej karty";
            // 
            // TimeOfVisibilityNumeric
            // 
            this.TimeOfVisibilityNumeric.Location = new System.Drawing.Point(167, 193);
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
            this.TimeOfVisibilityNumeric.TabIndex = 9;
            this.TimeOfVisibilityNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 299);
            this.Controls.Add(this.TimeOfVisibilityNumeric);
            this.Controls.Add(this.ReversedCardLabel);
            this.Controls.Add(this.Sizes);
            this.Controls.Add(this.TimeToSeeNumeric);
            this.Controls.Add(this.ConfigureSettingButton);
            this.Controls.Add(this.TimeToSeeLabel);
            this.Controls.Add(this.CardsNumberLabel);
            this.Name = "Configure";
            this.Text = "Configure";
            ((System.ComponentModel.ISupportInitialize)(this.TimeToSeeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOfVisibilityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CardsNumberLabel;
        private System.Windows.Forms.Label TimeToSeeLabel;
        private System.Windows.Forms.Button ConfigureSettingButton;
        private System.Windows.Forms.NumericUpDown TimeToSeeNumeric;
        private System.Windows.Forms.CheckedListBox Sizes;
        private System.Windows.Forms.Label ReversedCardLabel;
        private System.Windows.Forms.NumericUpDown TimeOfVisibilityNumeric;
    }
}