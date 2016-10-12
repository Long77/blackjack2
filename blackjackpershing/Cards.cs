using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackpershing
{
    public enum Suits
    {
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
    public class Deck
    {
        public Card[] cards;
        public Deck()
        {
            
            cards = new Card[52];
            int i = 0; // 1
            foreach (Ranks r in Enum.GetValues(typeof(Ranks)))
            {
                int j = 0;
                foreach (Suits s in Enum.GetValues(typeof(Suits)))
                {
                    cards[i * 4 + j] = new Card(s, r);
                    j++;
                }
                i++;
            }
            randomize(cards);
        }
        //public override string ToString(Ranks r, Suits s)
        //{

        //}
        public Card[] randomize(Card[] shuffledDeck)
        {
            //Card[] shuffledDeck = new Card[52];
            Random x = new Random();
            Card temp;
            int a;

            for (int i = 0; i < 52; i++)
            {
                a = x.Next(0, 52);
                temp = shuffledDeck[a];
                shuffledDeck[i] = shuffledDeck[a];
                temp = shuffledDeck[0];
            }
            return shuffledDeck;

        }
    }

        


        //class Hand
        //{

        //}
    }
