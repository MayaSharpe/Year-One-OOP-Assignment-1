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
        //initialise variabes to be used within the class
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
                    cards_create[i] = cards_create[randomIndex];      // the takes the value held at index [i] and replaces it with the value at [randomindex]
                    cards_create[randomIndex] = temp_Hold;               // takes the card held in temp_Hold and places it at the random index

                }



            }
            else if (typeOfShuffle == 2) // Code for a Riffle shuffle
            {
                int halfWay = cards_create.Count / 2;        //finds the halfway point of the list
                List<Card> firstHalf = new List<Card>();     //creates two new lists to hold the first and second half of the list
                List<Card> secondHalf = new List<Card>(); 
                List<Card> output = new List<Card>();       //creates a new list to hold the output of the shuffle

                for (int i = 0; i < halfWay; i++)       //adds the first half of the list to the first half list and the second half to the second half list
                {
                    firstHalf.Add(cards_create[i]);
                }
                for (int i = halfWay; i < cards_create.Count; i++)
                {
                    secondHalf.Add(cards_create[i]);
                }
                for (int i = 0; i < halfWay; i++)          //adds the first half of the list to the output list then adds the second half of the list to the output list one at a time from each list until both are finished.
                {
                    output.Add(firstHalf[i]);      
                    output.Add(secondHalf[i]);
                }
                cards_create.Clear();                  //clears the original list
                cards_create.AddRange(output);        //adds the output list to the original list

            }
            else if (typeOfShuffle == 3) // Code for no shuffle
            {
                Console.WriteLine("You have Not selected a shuffle");

            }
            else return false;   //returns false if the user has not selected a shuffle
            return true;         //returns true if the user has selected a shuffle
        }

        //Creates a method to deal a single card
        public static Card deal()
        {
            //takes the first card 
            current_card = cards_create[0];
            //returns that card
            return current_card;
        }



        //Create the 'dealCard' method
        public static List<Card> dealCard(int hand_size)
        {
            List<Card> dealt_cards = new List<Card>();
            //Create the 'for' loop to deal the cards
            for (int i = 0; i < hand_size; i++)
            {
                dealt_cards.Add(cards_create[i]);    //adds the card at index i to the dealt cards list
            }
            return dealt_cards;       //returns that card    
        }


    }
}



