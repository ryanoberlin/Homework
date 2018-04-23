using System;
using System.Linq;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomRoll();
        }

        static void RandomRoll()
        {
            int[] red = { 0, 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 0, 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
           
            Random random = new Random();
            int bet = random.Next(0, 39);
            int landred;
            int landblack;
            int temp;
            int choice = random.Next(0, 2);
            int final;
            

            temp = random.Next(0, red.Length); 

            Console.WriteLine("The bet placed is:" + bet);

            landred = red[temp];

            temp = random.Next(0, black.Length);
            landblack = black[temp];

            final = (choice == 0) ? landblack : landred;

            if (landblack == 0)
            {
                Console.WriteLine("The Ball landed on 00");
            }
            else if (landred == 0)
            {
                Console.WriteLine("The Ball landed on 0");
            }
            else if (final == landblack)
            {
                Console.WriteLine("The Ball landed on Black " + landblack);

            }
            else if (final == landred)
            {
                Console.WriteLine("The Ball landed on Red " + landred);
            }

            if (bet == final)
            {
                Console.WriteLine("Winner Winner Chicken Dinner.");
            }
            
            if(final >= 19)
            {
                Console.WriteLine("High Bets Win");
            }
            else if(final <= 18)
            {
                Console.WriteLine("Low bets Win");
            }


            if (CheckArray(red, final) && final != 0)
            {
                Console.WriteLine("Bets on Red Win");
            }
            else if (CheckArray(black, final) && final != 0)
            {
                Console.WriteLine("Bets on Black Win");
            }

            if (CheckArray(red, bet) == true && final != 0)
            {
                Console.WriteLine("Your bet on Red Won");
            }
            else if (CheckArray(black, bet) == true && final != 0)
            {
                Console.WriteLine("Your bet on Black Won");
            }

            if (CheckOdd(final) == true && final != 0)
            {
                Console.WriteLine("Odd bets win");
            }
            else if(CheckOdd(final) == false && final != 0)
            {
                Console.WriteLine("Even bets win");
            }
        
        }

        static bool CheckArray(int[] arr, int x)
        {
            if (Array.Exists(arr, element => element == x))
            {
                return true;
            }
            else
                return false;
        }

        static bool CheckOdd(int num)
        {
            if (num % 2 == 0)
                return false;
            else
                return true;
        }
    }
}
