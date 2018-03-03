using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cards
{
    public class Hand
    {
        public Hand()
        {
            Cards = new List<Card>();

        }
        public string PlayerName { get; set; }
        public List<Card> Cards { get; private set; }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            Cards.Sort();
            result.Append(PlayerName);
            result.Append(": ");
            for (int i = 0; i < Cards.Count; i++)
            {
                result.Append(Cards.ElementAt(i).ToString());
                if (i < Cards.Count -1)
                {
                    result.Append("-");
                }
            }
            return result.ToString();
        }

    }

}
