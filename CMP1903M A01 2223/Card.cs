using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// create a 'card' class
// each card has a face and a suit
// the face is an integer from 1 to 13
// the suit is an integer from 1 to 4

namespace CMP1903M_A01_2223
{
    class Card
    {
        // create the 'face' and 'suit' variables
        private int face;
        private int suit;

        // create the 'Card' constructor
        public Card(int face, int suit)
        {
            // set up the face and suit variables for this instance of a card
            this.face = face;
            this.suit = suit;
        }

        // create the method to get the face
        public int getFace()
        {
            return face;
        }

        // create the method to get the suit
        public int getSuit()
        {
            return suit;
        }

        //formats the values from the object into this string format
        public override string ToString()
        {
            return $"{face}-{suit}";
        }

    }
}