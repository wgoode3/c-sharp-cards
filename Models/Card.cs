using System;

namespace DojoCards.Models
{
    public class Card
    {
        public string Suit {get;}
        public string Value {get;}
        public int NumValue {get;}

        public Card(string suit, string value, int num)
        {
            Suit = suit;
            Value = value;
            NumValue = num;
        }

        public string Display() 
        {
            return $"The {Value} of {Suit}";
        }

    }
}