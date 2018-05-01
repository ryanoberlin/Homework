using System;
using System.Linq;

namespace SquareBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Function using Enum and concat");
            Square(4);
            Console.WriteLine("\nSecond Function using no additional libraries or helper methods");
            Square2(8);
        }

        static void Square(int n)
        {
            int x = n - 1;
            int count = 0;
            while (count < n)
            {
                count++;
                Console.Write(string.Concat(Enumerable.Repeat(" ", x)));
                Console.WriteLine(string.Concat(Enumerable.Repeat("#", count)));
                x--;
            }
        }
        static void Square2(int n)
        {
            int x = n - 1;
            int c = 0;
            char s = '\u0020';
            char p = '\u0023';
            while (c < n)
            {
                c++;
                Console.Write(new string(s, x));
                Console.WriteLine(new string(p, c));
                x--;
            }
        }
    }
}