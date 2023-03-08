using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            string shuffleType = Console.ReadLine();
            
            //If the user does not input a preset accepted value, loop until they do
            while (shuffleType != "1" && shuffleType != "2" && shuffleType != "3")
            {
                Console.WriteLine("You have not entered a valid input! please try again! ");
                Console.WriteLine("How would you like to shuffle the cards?: type '1' for Fisher-Yates, type '2' for riffle, or type '3' for No shuffle!: ");
                shuffleType = Console.ReadLine();
            }
            
            
             // convert string to int
             int typeOfShuffle = Convert.ToInt32(shuffleType);

            // shuffle the cards
             Pack.shuffleCardPack(typeOfShuffle);
             Console.WriteLine("The cards have been shuffled!");
   


            //ask user how many cards they would like dealt
            Console.WriteLine("How many cards would you like dealt?: ");
            string handSize = Console.ReadLine();

            
            //if handSize to int is not a whole integer between 0 and 52, loop until the user inputs a value that is
            while (Convert.ToInt32(handSize) < 0 || Convert.ToInt32(handSize) > 52 || Convert.ToInt32(handSize) % 1 != 0)
            {
                Console.WriteLine("You have not entered a valid input! please try again! ");
                Console.WriteLine("How many cards would you like dealt?: ");
                handSize = Console.ReadLine();
          
            }
            int hand_size = Convert.ToInt32(handSize);

            //deal a single crd
            Card single = Pack.deal();
            Console.WriteLine(single.ToString());

            // deal the cards
            var hand = Pack.dealCard(hand_size);
            Console.WriteLine("The cards have been dealt accordingly!");
            foreach (Card card in hand)
            {
                Console.WriteLine(card.ToString() + ",");
            }
            Console.ReadLine();
        }





    }
}
