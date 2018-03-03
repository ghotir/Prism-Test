using System;

namespace Cards
{
    public enum Suits
    {
        Hearts,
        Spades,
        Diamonds,
        Clubs,
    }

    public class Card: IComparable
    {
        private int _rank = 2;
        public Suits Suit { get; set; }
        public int Rank { get { return _rank; }  set { if (value >= 2 && value <= 14) _rank = value; } }

        public int CompareTo(object obj)
        {
            if (obj is Card)
            {
                return Rank.CompareTo((obj as Card).Rank);
            }
            return -1;
        }

        public override string ToString()
        {
            string result = string.Empty;
            if (Rank <= 10)
            {
                result = Rank.ToString();
            }
            else
            {
                switch (Rank)
                {
                    case (11):
                        {
                            result = "J";
                            break;
                        }
                    case (12):
                        {
                            result = "Q";
                            break;
                        }
                    case (13):
                        {
                            result = "K";
                            break;
                        }
                    case (14):
                        {
                            result = "A";
                            break;
                        }

                }
            }
            switch (Suit)
            {
                case Suits.Clubs:
                    result += "C";
                    break;
                case Suits.Diamonds:
                    result += "D";
                    break;
                case Suits.Hearts:
                    result += "H";
                    break;
                case Suits.Spades:
                    result += "S";
                    break;
            }
            return result;
        }
    }
}

