using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
            SetLabels();
        }

        private void SetLabels()
        {
            //read csv
            List<string> names = new List<string>();
            List<string> surnames = new List<string>();
            List<string> scores = new List<string>();
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            var filename = projectDirectory + "\\Memory\\" + Program.cardsX.ToString() + 'x' + Program.cardsY.ToString() + ".csv";
            using (var sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    var values = line.Split(',');
                    names.Add(values[0]);
                    surnames.Add(values[1]);
                    scores.Add(values[2]);
                }
            }
            List<int> indexUsed = new List<int>();
            int maxScore = 0, maxScoreIndex = -1;

            for (int i = 0; i < names.Count; i++)
            {
                if (int.Parse(scores[i]) > maxScore && !indexUsed.Contains(i))
                {
                    maxScore = int.Parse(scores[i]);
                    maxScoreIndex = i;
                }
            }
            indexUsed.Add(maxScoreIndex);
            pierwsze_imie.Text = names[maxScoreIndex] + " " + surnames[maxScoreIndex];
            pierwsze_score.Text = scores[maxScoreIndex];

            maxScore = 0; maxScoreIndex = -1;

            for (int i = 0; i < names.Count; i++)
            {
                if (int.Parse(scores[i]) > maxScore && !indexUsed.Contains(i))
                {
                    maxScore = int.Parse(scores[i]);
                    maxScoreIndex = i;
                }
            }
            indexUsed.Add(maxScoreIndex);
            drugie_imie.Text = names[maxScoreIndex] + " " + surnames[maxScoreIndex];
            
            drugie_score.Text = scores[maxScoreIndex];

            maxScore = 0; maxScoreIndex = -1;

            for (int i = 0; i < names.Count; i++)
            {
                if (int.Parse(scores[i]) > maxScore && !indexUsed.Contains(i))
                {
                    maxScore = int.Parse(scores[i]);
                    maxScoreIndex = i;
                }
            }
            indexUsed.Add(maxScoreIndex);
            trzecie_imie.Text = names[maxScoreIndex] + " " + surnames[maxScoreIndex];
            trzecie_score.Text = scores[maxScoreIndex];
        }
    }
}
