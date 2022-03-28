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
    public partial class Configure : Form
    {
        public Configure()
        {
            InitializeComponent();
            Sizes.SetItemChecked(1, true);
            TimeToSeeNumeric.Value = Program.timeToSee;
            TimeOfVisibilityNumeric.Value = Program.timeToSeeReversed;
        }

        private bool SetSettings()
        {
            if (Sizes.CheckedItems.Count != 0 && TimeToSeeNumeric.Text !="" && TimeOfVisibilityNumeric.Text != "")
            {
                Program.timeToSee = int.Parse(TimeToSeeNumeric.Text);
                Program.timeToSeeReversed = int.Parse(TimeOfVisibilityNumeric.Text);
                if (Sizes.GetSelected(0))
                {
                    Program.cardsX = 6;
                    Program.cardsY = 8;
                }
                if (Sizes.GetSelected(1))
                {
                    Program.cardsX = 7;
                    Program.cardsY = 12;
                }
                if (Sizes.GetSelected(2))
                {
                    Program.cardsX = 10;
                    Program.cardsY = 12;
                }
                return true;
            }
            return false;
        }


        private void ConfigureSettingButton_Click(object sender, EventArgs e)
        {
            bool areSettingsSet = SetSettings();
            if (areSettingsSet)
            {
                this.Close();
            }
            else
            {
                WprowadzTrudnosc warning;
                warning = new WprowadzTrudnosc();
                warning.ShowDialog();
            }
        }

        private void Sizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Sizes.SelectedIndex;
            int count = Sizes.Items.Count;

            for(int i = 0; i < count; i++)
            {
                if(i != index)
                {
                    Sizes.SetItemChecked(i, false);
                }
            }
        }
    }
}
