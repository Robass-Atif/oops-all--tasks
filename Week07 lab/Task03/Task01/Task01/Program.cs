using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "0";
            bool gameRunning = true;
            while(option!="2")
            {
                Console.WriteLine("1.To play the game");
                Console.WriteLine("2.To Exit the game");
                option = (Console.ReadLine());
                if(option=="1")
                {

                
                    int score = 0;
                    Deck obj = new Deck();
                    obj.shufle();
                    Card cr = obj.dealCard();
                    while(gameRunning)
                    {
                        int remainCheck = obj.cardsLeft();
                        Card card2 = obj.dealCard();
                        Console.WriteLine("*******************************************");
                        Console.WriteLine(cr.toString());
                        Console.WriteLine("");
                        Console.WriteLine("*** Remaining Card ***");
                        Console.WriteLine("Press 1 if next card is higher");
                        Console.WriteLine("Press 2 if next card is lower");
                        int cardCheck = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if(cardCheck==1)
                        {

                            if(card2.getValue() >= cr.getValue())
                            {
                                score++;
                                cr = card2;
                            }
                            else
                            {
                                gameRunning = false;
                                Console.WriteLine("Sorry you lose the game  pres any key to continue!");
                                Console.WriteLine("The Card was"+ card2.toString());
                                Console.WriteLine("Your score was :" + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else if(cardCheck==2)
                        {
                            if(card2.getValue()<= cr.getValue())
                            {
                                score++;
                                cr = card2;
                            }
                            else
                            {
                                gameRunning = false;
                                Console.WriteLine("Sorry you lose the game  pres any key to continue!");
                                Console.WriteLine("The Card was " + card2.toString());
                                Console.WriteLine("Your score was :" + score);
                                Console.ReadKey();
                                Console.Clear();
                            }

                        }
                        if(obj.cardsLeft()==0 && card2==null)
                        {
                            gameRunning = false;
                            Console.WriteLine("You score maximum");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }


                    }

                }

            }
            Console.ReadKey();
        }
    }
}
