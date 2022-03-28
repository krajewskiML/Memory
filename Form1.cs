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
    public partial class Memory : Form
    {
        private String _name = "";
        private String _surname = "";
        WprowadzDane warning;
        public Memory()
        {   
            InitializeComponent();
        }

        private bool setCredentials()
        {
            if (NameTextBox.Text != "" && SurnameTextBox.Text != "")
            {
                Program.playerName = NameTextBox.Text;
                Program.playerSurname = SurnameTextBox.Text;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            bool areCredentialsSet = setCredentials();
            if (!areCredentialsSet)
            {
                warning = new WprowadzDane();
                warning.ShowDialog();
            }
            else
            {
                // otworz okno z grą
                Game game = new Game();
                game.Show();
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool areCredentialsSet = setCredentials();
            if (!areCredentialsSet)
            {
                warning = new WprowadzDane();
                warning.ShowDialog();
            }
            else
            {   
                Configure configure = new Configure();
                configure.ShowDialog();
            }
        }
    }
}
