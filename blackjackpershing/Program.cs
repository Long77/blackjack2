using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackpershing
{
    class Program
    {
        
        List<Card> playerOne = new List<Card>(); //add cards to list
        List<Card> playerTwo = new List<Card>();
        List<Card> cards = new List<Card>();
        int counter=0;

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.createDeck();
            myProgram.printDeck();

        }
        public void createDeck()
        {

            foreach (Ranks rank in Enum.GetValues(typeof(Ranks)))
            {
                Card Card = new Card(Suits.Hearts, rank);
                Card card2 = new Card(Suits.Clubs, rank);
                Card card3 = new Card(Suits.Spades, rank);
                Card card4 = new Card(Suits.Diamonds, rank);
                cards.Add(Card);
                cards.Add(card2);
                cards.Add(card3);
                cards.Add(card4);

            }
        }
         public void printDeck()
        {
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(cards.ElementAt(i).ranks);
                Console.WriteLine(cards.ElementAt(i).suits);
            }
            Console.ReadLine();
        }
        public void dealTwo()
        {
            Card card1 = cards.ElementAt(counter);
            Card card2 = cards.ElementAt(counter+1);
            counter = counter + 2;
        }      
        public void dealOne()
        {
            Card card1 = cards.ElementAt(counter);
            counter = counter + 1;
        }
        public void deal(int cardCount)
        {
            counter = cardCount;
            for (int i = 0; i < cardCount; i++)
            {
                cards.ElementAt(i);
                counter = counter + 1;
            }
    
    }
        }
        }


    }

 

