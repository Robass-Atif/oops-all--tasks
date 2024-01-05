using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
   public  class Deck
    {
        private int count;
        Card[] deck = new Card[52];
        public Deck()
        {
            count = 0;
            for(int x=1;x<=4;x++)
            {
                for(int y=1;y<=13;y++)
                {
                    deck[count] = new Card(y, x);
                    count++;
                }
            }
        }
        public void shufle()
        {
            System.Random rand = new Random();
            Card temp;
            for(int x=0;x<52;x++)
            {
                int num = rand.Next(0, 52);
                temp = deck[num];
                deck[x] = temp;
            }
            count = 52;
        }
        public Card dealCard()
        {
            if(count>0)
            {
                count--;
                return deck[count];
            }
            else
            {
                return null;
            }
        }
        public int cardsLeft()
        {
            return count;
        }
    }
}
