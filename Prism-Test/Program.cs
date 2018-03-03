using Cards;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int _numOfPlayers = 5;
            int _numOfCards = 5;
            Hand[] Players = new Hand[_numOfPlayers];
            Deck d = new Deck();
            d.Shuffle();
            for (int i = 0; i < _numOfPlayers; i++)
            {
                Players[i] = new Hand { PlayerName = $"Player #{i + 1}" };
            }
            for (int i = 0; i < _numOfCards; i++)
            {
                foreach (var Hand in Players)
                {
                    Hand.Cards.Add(d.Next());
                }
            }
            StringBuilder output = new StringBuilder();
            foreach (var Hand in Players)
            {
                output.AppendLine(Hand.ToString());
            }
            WriteOutput(output.ToString());

        }

        private static void WriteOutput(string output)
        {
            string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Prism");
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }

            File.WriteAllText(Path.Combine(outputPath, "output.txt"), output);
        }
    }
}
