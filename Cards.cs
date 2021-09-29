using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Cards
    {
        public string suit;
        public string rank;
        public Cards(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank;
        }
    }
}
