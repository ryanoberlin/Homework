using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int input;
            input = GetInt("Please Select 1-10");
            //BiSect();
            BiSectList(test, input);
        }

        private static int BiSectList(int[] test, int find)
        {
            int left = 0;
            int right = test.Length - 1;
            int middle = (left + right) / 2;

            while (test[middle] != find || (middle > 0 && test[middle -1] == find))
            {
                if (test[middle]<find)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
                middle = (left + right) / 2;
                Console.WriteLine("List Value:" + left + middle + right);

                if (right < left)
                {
                    return -1;
                }
            }
            Console.WriteLine(middle);
            return middle;
        }

        private static void BiSect()
        {

            double start;
            double end;
            double mid;
            double qal;

            start = GetDubs("Gimme da first number");
            end = GetDubs("Gimme da last number");
            qal = GetDubs("HOw goOd U wAnNa DoMaTh?/?/?");

            if (GetMid(start) * GetMid(end) > 0.0D)
            {
                Console.WriteLine("U broke me");
                return;
            }

            while (Math.Abs(start - end) > qal)
            {
                mid = (start + end) / 2.0D;
                Console.WriteLine("Middle X: " + mid);

                if (GetMid(start) * GetMid(mid) < 0.0D)
                {
                    end = mid;
                }
                else
                {
                    start = mid;
                }
            }


        }

        public static double GetMid(double x)
        {

            return x * (x + 2) - 1;

        }

        private static double GetDubs(string a)
        {
            Console.WriteLine(a);
            double getdub = Convert.ToDouble(Console.ReadLine());
            return getdub;
        }

        private static int GetInt(string a)
        {
            Console.WriteLine(a);
            int getint = Convert.ToInt16(Console.ReadLine());
            return getint;
        }


    }
}
