using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackGame.Model
{
    public class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }

        
        string value;
        string suit;

        public Card()
        {
        }

        public Card(string val, string Csuit)
        {
            value = val;
            suit = Csuit;

        }
        public List<Card.CardValue> getCard()
        {
            return Enum.GetValues(typeof(CardValue))
                            .Cast<CardValue>()
                            .ToList();
        }

        public enum CardValue
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
        }

        public enum CardSuit
        {
            Hearts = 1,
            Spades = 2,
            Clubs = 3,
            Diamonds = 4,
        }


    }
}
