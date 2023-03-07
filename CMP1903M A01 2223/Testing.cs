using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Testing
    {

        public void code_test()
        {
            // create a new pack of cards
            Pack new_pack = new Pack();
            Console.WriteLine("The cards have been created!");

            //ask user how they would like the cards to be shuffled
            Console.WriteLine("How would you like to shuffle the cards?: type '1' for Fisher-Yates, type '2' for riffle, or type '3' for No shuffle!: ");
            int typeOfShuffle = Convert.ToInt32(Console.ReadLine());

            // shuffle the pack of cards
            Pack.shuffleCardPack(typeOfShuffle);
            Console.WriteLine("The cards have been shuffled!");

            //ask user how many cards they would like dealt
            Console.WriteLine("How many cards would you like dealt?: ");
            int hand_size = Convert.ToInt32(Console.ReadLine());

            // deal the cards
            var hand = Pack.dealCard(hand_size);
            Console.WriteLine("The cards have been dealt!");
            foreach (Card card in hand)
            {
                Console.WriteLine(card.ToString() + ",");
            }
            Console.ReadLine();
        }





    }
}
