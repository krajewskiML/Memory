using Memory.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Collections;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Reflection;

namespace Memory
{
    public partial class Game : Form
    {
        TableLayoutPanel MemoryGrid;
        Pause pauza;
        Results results;
        private int milis = 0, secondsWrong = 0;
        private static Random rng = new Random();
        private PictureBox firstClick, secondClick;
        private List<List<Bitmap>> pathsToFilesPlaceholder;
        private TableLayoutPanelCellPosition firstPos, secondPos;
        private Bitmap Unnknown = Resources.question;
        private Bitmap Known = Resources.white;
        private bool arePreviousVisible, canPause;
        private int wrongChoices = 0, goodChoices = 0;


        public Game()
        {
            InitializeComponent();
            pathsToFilesPlaceholder = new List<List<Bitmap>>();
            setUpGrid();
            this.KeyPreview = true;
            Timer.Enabled = true;
            Timer.Start();
            firstClick = null; secondClick = null;
            canPause = false;
        }
 
        private void setUpGrid()
        {
            IList<DictionaryEntry> list = new List<DictionaryEntry>();
            
            ResourceManager MyRescourcesClass = new ResourceManager(typeof(Resources));
            ResourceSet rs = MyRescourcesClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            foreach(DictionaryEntry entry in rs)
            {
                if ((String)entry.Key == "white" || (String)entry.Key == "question")
                {
                    continue;
                }
                list.Add(entry);
            }

            //crop images to required number
            int numberOfCardsNeeded = Program.cardsX * Program.cardsY / 2;
            while(list.Count > numberOfCardsNeeded)
            {
                list.RemoveAt(list.Count - 1);
            }
            var shuffledList = (list.OrderBy(a=>rng.Next())).Concat(list.OrderBy(a => rng.Next())).ToList();

            MemoryGrid = new TableLayoutPanel();
            MemoryGrid.Dock = DockStyle.Fill;
            MemoryGrid.AutoSize = true;
            MemoryGrid.ColumnCount = Program.cardsX;
            MemoryGrid.RowCount = Program.cardsY;


            float widthPercent = 100 / Program.cardsX;
            float heigthPercent = 100 / Program.cardsY;

            for (int i = 0; i < MemoryGrid.ColumnCount; i++)
            {
                MemoryGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, widthPercent));
            }

            for (int i = 0; i < MemoryGrid.RowCount; i++)
            {
                MemoryGrid.RowStyles.Add(new RowStyle(SizeType.Percent, heigthPercent));
            }


            int xSize = MemoryGrid.Size.Width;
            int ySize = MemoryGrid.Size.Height;
            int picture_counter = 0;
            for (int x = 0; x < Program.cardsX; x++)
            {
                List<Bitmap> cards1D = new List<Bitmap>();
                for (int y = 0; y < Program.cardsY; y++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = xSize;
                    pictureBox.Height = ySize;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = (Bitmap)shuffledList[picture_counter].Value;
                    cards1D.Add((Bitmap)shuffledList[picture_counter].Value);
                    picture_counter++;

                    pictureBox.Click += new EventHandler(this.PictureBox_Click);

                    MemoryGrid.Controls.Add(pictureBox, y, x);
                }
                pathsToFilesPlaceholder.Add(cards1D);
            }
            this.Controls.Add(MemoryGrid);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape && canPause && !arePreviousVisible)
            {
                Timer.Stop();
                pauza = new Pause();
                pauza.ShowDialog();
            }
            Timer.Start();
            return true;
        }

        private void WrongTimer_Tick(object sender, EventArgs e)
        {
            secondsWrong += 1;
            if (arePreviousVisible && secondsWrong == Program.timeToSeeReversed)
            {
                firstClick.Image = Unnknown;
                secondClick.Image = Unnknown;
                firstClick = null;
                secondClick = null;
                arePreviousVisible = false;
                secondsWrong = 0;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            milis += 100;
            this.Text = "Memory, time: " + (milis/60000).ToString() + ":" + ((milis%60000)/1000).ToString() + ":" + (milis%1000).ToString();
            // if time of observing is passed then replace all tiles with question marks
            if(milis/1000 == Program.timeToSee && milis %1000 == 0)
            {
                for (int x = 0; x < Program.cardsX; x++)
                {
                    for (int y = 0; y < Program.cardsY; y++)
                    {
                        PictureBox currBox = (PictureBox)MemoryGrid.GetControlFromPosition(x, y);
                        currBox.Image = Unnknown;
                    }
                }
                canPause = true;
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // te przypadki ignorujemy
            if (!(sender is PictureBox) || ((sender as PictureBox).Image!=Unnknown && (sender as PictureBox)!= firstClick && (sender as PictureBox) != secondClick) || arePreviousVisible==true)
            {
                return;
            }

            if (firstClick == null && secondClick == null)
            {
                firstClick = sender as PictureBox;
                firstPos = MemoryGrid.GetCellPosition(firstClick);
                firstClick.Image = pathsToFilesPlaceholder[firstPos.Row][firstPos.Column];
            }
            else
            {
                if(firstClick != null && secondClick == null)
                {
                    secondClick = sender as PictureBox;
                    secondPos = MemoryGrid.GetCellPosition(secondClick);
                    // check if different tiles were clicked
                    if (secondPos == firstPos)
                    {
                        secondClick = null;
                        return;
                    }
                    secondClick.Image = pathsToFilesPlaceholder[secondPos.Row][secondPos.Column];
                    if (secondClick.Image == firstClick.Image)
                    {
                        firstClick.Image = Known;
                        secondClick.Image = Known;
                        firstClick = null;
                        secondClick = null;
                        goodChoices++;
                        // check if game is won
                        if (goodChoices * 2 == Program.cardsX * Program.cardsY)
                        {
                            int score = calculateScore();
                            addScoreToScores(score);
                            results = new Results();
                            results.ShowDialog();
                            Timer.Stop();
                            this.Close();
                        }
                    }
                    else
                    {
                        secondsWrong = 0;
                        arePreviousVisible = true;
                        wrongChoices++;
                    }
                }
            }

        }
        private int calculateScore() {
            return milis / 10 - wrongChoices*Program.wrongCardPickedPunishment; 
        }

        private void addScoreToScores(int calculatedScore)
        {
            
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            var filename = projectDirectory + "\\Memory\\" + Program.cardsX.ToString() + 'x' + Program.cardsY.ToString() + ".csv";
            List<string> names = new List<string>();
            List<string> surname = new List<string>();
            List<string> score = new List<string>();
            using (var reader = File.AppendText(filename))
            {
                var newRecord = Program.playerName +',' + Program.playerSurname + ',' + calculatedScore.ToString();
                reader.WriteLine(newRecord);
                reader.Close();
                
            }
        }
    }
}
