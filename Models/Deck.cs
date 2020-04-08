using System;
using System.Collections.Generic;

namespace DojoCards.Models
{
    public class Deck
    {
    
        private static List<Card> _deck;

        public int Size {
            get {
                return _deck.Count;
            }
        }

        public Deck()
        {
            Reset();
            
        }

        public void Display()
        {
            foreach(Card card in _deck)
            {
                Console.WriteLine( card.Display() );
            }
        }

        public static void Reset()
        {
            _deck = new List<Card>();
            string[] suits = {"Spades", "Hearts", "Diamonds", "Clubs"};
            string[] values = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            for(int i=0; i<suits.Length; i++)
            {
                for(int j=0; j<values.Length; j++)
                {
                    _deck.Add(
                        new Card( suits[i], values[j], j+1)
                    );
                }
            }
        }

        public void Shuffle()
        {
            Random r = new Random();
            for(int i=0; i<_deck.Count; i++)
            {
                int rI = r.Next(_deck.Count);
                Card temp = _deck[i];
                _deck[i] = _deck[rI];
                _deck[rI] = temp;
            }
        }

        public Card Deal()
        {
            Card cardToReturn = _deck[0];
            _deck.Remove(cardToReturn);
            return cardToReturn;
        }

        public List<Card> Deal(int num)
        {
            List<Card> cards = new List<Card>();
            while(num > 0){
                Card cardToReturn = _deck[0];
                _deck.Remove(cardToReturn);
                cards.Add( cardToReturn );
                num--;
            }
            return cards;
        }


    }
}