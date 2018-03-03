using System;
using System.Text;

namespace Cards
{
    public class Deck
    {
        private Random _random = new Random((int)DateTime.Now.Ticks);
        private Card[] _possibleCards =
        {
            new Card {Rank = 2, Suit = Suits.Clubs},new Card {Rank = 3, Suit = Suits.Clubs},new Card {Rank = 4, Suit = Suits.Clubs},new Card {Rank = 5, Suit = Suits.Clubs},new Card {Rank = 6, Suit = Suits.Clubs},new Card {Rank = 7, Suit = Suits.Clubs},new Card {Rank = 8, Suit = Suits.Clubs},new Card {Rank = 9, Suit = Suits.Clubs},new Card {Rank = 10, Suit = Suits.Clubs},new Card {Rank = 11, Suit = Suits.Clubs},new Card {Rank = 12, Suit = Suits.Clubs},new Card {Rank = 13, Suit = Suits.Clubs},new Card {Rank = 14, Suit = Suits.Clubs},
            new Card {Rank = 2, Suit = Suits.Hearts},new Card {Rank = 3, Suit = Suits.Hearts},new Card {Rank = 4, Suit = Suits.Hearts},new Card {Rank = 5, Suit = Suits.Hearts},new Card {Rank = 6, Suit = Suits.Hearts},new Card {Rank = 7, Suit = Suits.Hearts},new Card {Rank = 8, Suit = Suits.Hearts},new Card {Rank = 9, Suit = Suits.Hearts},new Card {Rank = 10, Suit = Suits.Hearts},new Card {Rank = 11, Suit = Suits.Hearts},new Card {Rank = 12, Suit = Suits.Hearts},new Card {Rank = 13, Suit = Suits.Hearts},new Card {Rank = 14, Suit = Suits.Hearts},
            new Card {Rank = 2, Suit = Suits.Diamonds},new Card {Rank = 3, Suit = Suits.Diamonds},new Card {Rank = 4, Suit = Suits.Diamonds},new Card {Rank = 5, Suit = Suits.Diamonds},new Card {Rank = 6, Suit = Suits.Diamonds},new Card {Rank = 7, Suit = Suits.Diamonds},new Card {Rank = 8, Suit = Suits.Diamonds},new Card {Rank = 9, Suit = Suits.Diamonds},new Card {Rank = 10, Suit = Suits.Diamonds},new Card {Rank = 11, Suit = Suits.Diamonds},new Card {Rank = 12, Suit = Suits.Diamonds},new Card {Rank = 13, Suit = Suits.Diamonds},new Card {Rank = 14, Suit = Suits.Diamonds},
            new Card {Rank = 2, Suit = Suits.Spades},new Card {Rank = 3, Suit = Suits.Spades},new Card {Rank = 4, Suit = Suits.Spades},new Card {Rank = 5, Suit = Suits.Spades},new Card {Rank = 6, Suit = Suits.Spades},new Card {Rank = 7, Suit = Suits.Spades},new Card {Rank = 8, Suit = Suits.Spades},new Card {Rank = 9, Suit = Suits.Spades},new Card {Rank = 10, Suit = Suits.Spades},new Card {Rank = 11, Suit = Suits.Spades},new Card {Rank = 12, Suit = Suits.Spades},new Card {Rank = 13, Suit = Suits.Spades},new Card {Rank = 14, Suit = Suits.Spades},
        };

        private int[] ShuffledDeck = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,
        14,15,16,17,18,19,20,21,22,23,24,25,26,
        27,28,29,30,31,32,33,34,35,36,37,38,39,
        40,41,42,43,44,45,46,47,48,49,50,51};

        private int _currentCard = 0;

        public void Shuffle()
        {
            Shuffle(ShuffledDeck);
            _currentCard = 0;
        }

        public Card Next()
        {
            if (_currentCard <= ShuffledDeck.Length)
            {
                _currentCard++;
                return _possibleCards[ShuffledDeck[_currentCard - 1]];
            }
            return null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in ShuffledDeck)
            {
                sb.Append(_possibleCards[item].ToString());
                sb.Append("-");
            }
            return sb.ToString();
        }

        void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + _random.Next(n - i);
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }


    }
}
