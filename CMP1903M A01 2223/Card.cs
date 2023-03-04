using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation

        private int Suit;
        private int Value;

        public Card(int csuit, int cValue)
        {
            Suit = csuit;
            Value = cValue;
        }

        public int suit 
        {
            get { return Suit; }
            set 
            { 
          
                if (value == 1 || value == 2 || value == 3 || value == 4)
                {
                    Suit = value;
                }
                else
                {
                    Value = 0;
                }
            }
        }

        public int CValue 
        {
            get { }
            set { }
        }
        

    }
}
