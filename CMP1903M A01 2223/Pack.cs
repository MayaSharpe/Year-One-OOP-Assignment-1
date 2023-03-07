using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903M_A01_2223
{
    class Pack
    {
        //Create the 'cards_create' and 'current_card' variables
        static List<Card> cards_create;
        static Card current_card;
        static Card temp_Hold;
       
       


        //Create the 'Pack' constructor
        public Pack()
        {
            //Create the 'cards_create' array
            cards_create = new List<Card>();
           

            //Create the 'for' loop to create the cards
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int face = 1; face <= 13; face++)
                {
                    cards_create.Add(new Card(face, suit));
                }
            }
        }

       

        //Create the 'shuffleCardPack' method
        public static bool shuffleCardPack(int typeOfShuffle)
        {


            if (typeOfShuffle == 1) // Code for a Fisher - Yates shuffle
            {
                Random randomGen = new Random();

                for (int i = 0; i < cards_create.Count; i++)
                {
                    int randomIndex = randomGen.Next(0, cards_create.Count);
                    Card temp_Hold = cards_create[i];                 //temporarily holds the value at index i
                    cards_create[i] = cards_create[randomIndex];      // the takes the value held at index [i+26] and replaces [i] with it
                    cards_create[randomIndex] = temp_Hold;               // re places the value at [i + 26] with [i]

                }



            }
            else if (typeOfShuffle == 2) // Code for a Riffle shuffle
            {
                int halfWay = cards_create.Count / 2;
                List<Card> firstHalf = new List<Card>();
                List<Card> secondHalf = new List<Card>();
                List<Card> output = new List<Card>();

                for (int i = 0; i < halfWay; i++)
                {
                    firstHalf.Add(cards_create[i]);
                }
                for (int i = halfWay; i < cards_create.Count; i++)
                {
                    secondHalf.Add(cards_create[i]);
                }
                for (int i = 0; i < halfWay; i++)
                {
                    output.Add(firstHalf[i]);
                    output.Add(secondHalf[i]);
                }
                cards_create.Clear();
                cards_create.AddRange(output);

            }
            else if (typeOfShuffle == 3) // Code for no shuffle
            {
                Console.WriteLine("No shuffle");

            }
            else return false;
            return true;
        }




        //Create the 'dealCard' method
        public static List<Card> dealCard(int hand_size)
        {
            List<Card> dealt_cards = new List<Card>();
            //Create the 'for' loop to deal the cards
            for (int i = 0; i < hand_size; i++)
            {
                dealt_cards.Add(cards_create[i]);
            }
            return dealt_cards;        
        }


    }
}



