using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Card
    {
        public int suit;
        public int value;
        public Card(int value, int suit)
        {
            this.suit = suit;
            this.value = value;
        }
        public string getSuitAsString()
        {
            if (this.suit == 1)
            {
                return "clubs";
            }
            else if (this.suit == 2)
            {
                return "diamonds";
            }
            else if (this.suit == 3)
            {
                return "spades";
            }
            else
            {
                return "hearts";
            }

        }
        public string getValueAsString()
        {
            if (this.value == 1)
            {
                return "Ace";
            }
            else if (this.value == 2)
            {
                return "2";
            }
            else if (this.value == 3)
            {
                return "3";
            }
            else if (this.value == 4)
            {
                return "4";
            }
            else if (this.value == 5)
            {
                return "5";
            }
            else if (this.value == 6)
            {
                return "6";
            }
            else if (this.value == 7)
            {
                return "7";
            }
            else if (this.value == 8)
            {
                return "8";
            }
            else if (this.value == 9)
            {
                return "9";
            }
            else if (this.value == 10)
            {
                return "10";
            }
            else if (this.value == 11)
            {
                return "Jack";
            }
            else if (this.value == 12)
            {
                return "Queen";
            }
            else
            {
                return "King";
            }

        }
        public string toString()
        {
            return getValueAsString() + " of " + getSuitAsString();
        }
    }
}
