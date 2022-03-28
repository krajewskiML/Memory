using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Pause : Form
    {
        public Pause()
        {
            InitializeComponent();
            TimeOfVisibilityNumeric.Value = Program.timeToSeeReversed;
        }

        private bool SetSettings()
        {
            if (TimeOfVisibilityNumeric.Text != "")
            {
                Program.timeToSeeReversed = int.Parse(TimeOfVisibilityNumeric.Text);
                return true;
            }
            return false;
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {

            bool areSettingsSet = SetSettings();
            if (areSettingsSet)
            {
                this.Close();
            }
            else
            {
                WprowadzReversed error;
                error = new WprowadzReversed();
                error.ShowDialog();
            }
        }
    }
}
