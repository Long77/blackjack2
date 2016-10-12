using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackpershing
{
    public enum Suits {
        Hearts, Clubs, Spades, Diamonds
    }
    public enum Ranks
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }
    
    public class Card
    {
        public Suits suits;
        public Ranks ranks;
        public Card(Suits s, Ranks r)
        {
            suits = s;
            ranks = r;
        }
    }

    //public class Deck
    //{
    //    Cards deckCards = new Cards();
    //    for (int i = 0; i<deckCards; i++) 
    //}

    //class Hand
    //{

    //}
}
