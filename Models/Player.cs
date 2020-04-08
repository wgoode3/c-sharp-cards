using System;
using System.Collections.Generic;

namespace DojoCards.Models
{
    public class Player
    {

        public string Name;
        private List<Card> _hand;
        private Deck _deckInstance;

        /// <summary>
        /// The player needs to know about a deck!!!
        /// </summary>
        public Player(Deck deckInstance, string name = "Tom")
        {
            Name = name;
            _hand = new List<Card>();
            _deckInstance = deckInstance;
        }

        public void Draw(int num = 1) {
            List<Card> newCards = _deckInstance.Deal(num);
            foreach(Card card in newCards)
            {
                _hand.Add(card);
            }
        }

        public void Display()
        {
            Console.WriteLine($"{Name} is holding {_hand.Count} card(s)");
            foreach(Card card in _hand)
            {
                Console.WriteLine( card.Display() );
            }
        }

    }
}