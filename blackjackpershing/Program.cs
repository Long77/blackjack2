using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackpershing
{
    class Program
    {

        static void Main(string[] args)
        {
            //List<Card> playerOne = new List<Card>(); //add cards to list
            //List<Card> playerTwo = new List<Card>();

            //int counter = 0;

            //Program myProgram = new Program();
            //myProgram.createDeck();
            //myProgram.printDeck();
            //myProgram.randomize();
            //myProgram.dealOne();
            Deck firstDeck = new Deck();
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(firstDeck.cards[i].ranks.ToString());
                Console.WriteLine(firstDeck.cards[i].suits.ToString());
            
            }
            Console.ReadLine();
        }
        //}
        
        //public void swap()
        //{
        //    List<Card> swapper = new List<Card>();
        //}

        //public void printDeck()
        //{
        //    for (int i = 0; i < 52; i++)
        //    {
        //Console.WriteLine(cards.ElementAt(i).ranks);
        //Console.WriteLine(cards.ElementAt(i).suits);
        //    }
        //    Console.ReadLine();
        //}
        //public void dealTwo()
        //{
        //    Card card1 = cards.ElementAt(counter);
        //    Card card2 = cards.ElementAt(counter + 1);
        //    counter = counter + 2;
        //}
        //public void dealOne()
        //{
          
        //    Console.WriteLine(cards[0].ranks);
        //    Console.WriteLine(cards[0].suits);
        //    counter = counter + 1;
        //    Console.ReadLine();
        //}
        //public void deal(int cardCount)
        //{
        //    counter = cardCount;
        //    for (int i = 0; i < cardCount; i++)
        //    {
        //        cards.ElementAt(i);
        //        counter = counter + 1;
        //    }

        //}
    }
}


    


    

 

