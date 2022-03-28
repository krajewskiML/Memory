using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    internal static class Program
    {
        //time to see the cards in seconds 
        public static int timeToSee = 10;
        public static int timeToSeeReversed = 10;
        public static int cardsX = 6;
        public static int cardsY = 8;
        public static int wrongCardPickedPunishment = 10;
        public static int timePunishmentMultiply = 5;
        public static String playerName;
        public static String playerSurname;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Memory());
        }
    }
}
