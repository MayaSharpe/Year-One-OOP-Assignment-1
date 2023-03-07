using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903M_A01_2223
{
    class Pack
    {
        //Create the 'cards_create' and 'current_card' variables
        static Card[] cards_create;
        static Card current_card;
        static Card temp_Hold;
       


        //Create the 'Pack' constructor
        public Pack()
        {
            //Create the 'cards_create' array
            cards_create = new Card[52];
           

            //Create the 'for' loop to create the cards
            for (int suit = 0; suit < 4; suit++)
            {
                for (int face = 0; face < 13; face++)
                {
                    current_card = new Card(face, suit);
                }
            }
        }

       

        //Create the 'shuffleCardPack' method
        public static bool shuffleCardPack(int typeOfShuffle)
        {


            if (typeOfShuffle == 1) // Code for a Fisher - Yates shuffle
            {

                for (int i = 0; i < 25; i++)
                {
                    temp_Hold = cards_create[i];                 //temporarily holds the value at index i
                    cards_create[i] = cards_create[i + 26];       // the takes the value held at index [i+26] and replaces [i] with it
                    cards_create[i + 26] = temp_Hold;             // replaces the value at [i + 26] with [i]

                }



            }
            else if (typeOfShuffle == 2) // Code for a Riffle shuffle
            {
                for (int i = 51; i > 0; i--)
                {
                    Random rnd = new Random();           //create the integer j, which is assigned a random value from zero to i
                    int j = rnd.Next(i);

                    temp_Hold = cards_create[i];         //Stores the value that is at index position i for later use

                    cards_create[i] = cards_create[j];  // replaces the value at index i with the value from index j
                    cards_create[j] = temp_Hold;        // replaces the value at index j with the value that was origionally at index i



                }

            }
            else if (typeOfShuffle == 3) // Code for no shuffle
            {
                Console.WriteLine("No shuffle");

            }
            else return false;
            return true;
        }




        //Create the 'dealCard' method
        public static Card dealCard()
        {
         

        }
       

        //Create the 'dealCard' method
        public static List<Card> dealCard(int amount)
        {
            //Create the 'dealCard' method
        }
    }
}



