using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
	//unsafe is required to allow unmanaged memory
        private static unsafe void Main()
        {
            
            int[] numbers = { 42, 42, 42, 42, 42 };
            long[] numbers2 = { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            int[,] numbers3 = new int[,] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            double[] numbers4 = { 1, 22.7, 1839992.33223, 558322212, -10 };
            float[] numbers5 = { 1, 2, 99100, 4, 200 };
            string[] fun = { "strings", "are", "fun" };
            string a, b, c;
            a = "arrays";
            b = "are";
            c = "fun";

	    /* play with marshalling later
            foreach(string i in fun)
            {
                Marshal.PtrToStringBSTR
                Console.WriteLine(i);
            }*/

            System.Console.WriteLine("Single Dimension of type int array.\n");
            fixed (int* i1 = numbers)
            {
                for (int* i2 = i1; i2 < i1 + numbers.Length; i2++)
                {
                    System.Console.WriteLine("Value:{0} @ Address:{1}", *i2, (long)i2);
                }
            }
            System.Console.WriteLine("\nSingle Dimension of type long array.\n");

            fixed (long* l1 = numbers2)
            {

                for (long* l2 = l1; l2 < l1 + numbers2.Length; l2++)
                {
                    System.Console.WriteLine("Value:{0} @ Adress:{1}", *l2, (long)l2);
                }
            }       

            System.Console.WriteLine("\nSingle Dimension of type double array.\n");
            fixed (double* d1 = numbers4)
            {
                for (double* d2 = d1; d2 < d1 + numbers.Length; d2++)
                {
                    System.Console.WriteLine("Value:{0} @ Address:{1}", *d2, (long)d2);
                }
            }

            System.Console.WriteLine("\nSingle Dimension of type float array.\n");
            fixed (float* f1 = numbers5)
            {
                for (float* f2 = f1; f2 < f1 + numbers.Length; f2++)
                {
                    System.Console.WriteLine("Value:{0} @ Address:{1}", *f2, (long)f2);
                }
            }
            
		//The CLR manages these memory locations because its a string type.
            System.Console.WriteLine("\nThe .NET CLR Marshalling works differently for String types.\n");

            fixed (char* d = a)
                Console.WriteLine("Value:{0} @ Adress:{1}", a, ((long)d).ToString());

            fixed (char* e = b)
                Console.WriteLine("Value:{0} @ Address:{1}", b, ((long)e).ToString());

            fixed (char* f = c)
                Console.WriteLine("Value:{0} @ Address:{1}", c, ((long)f).ToString());

            System.Console.WriteLine("\nMultidimensional Array of the int type\n");
            fixed (int* m1 = numbers3)
            {
                for (int* m2 = m1; m2 < m1 + numbers3.Length; m2++)
                {
                    System.Console.WriteLine("Value:{0} @ Address:{1}", *m2, (long)m2);

                }
            }
            
            //arrays are poorly defined. being lazy just wanted to see how this was handled.
            System.Console.WriteLine("\nFlattened Multidimensional Array\n");
            int[] test = new int[15];
            int num;
            foreach (int i in numbers3)
            {
                num = i;
                test[i] = num;
            }

            foreach (int i in test)
            {
                System.Console.WriteLine("Value:{0}", i);
            }



		//cant remember why i was doing this, I think i was trying to see what the CLR would let me cast
            //fixed (int* test = numbers3)
            //int*[] test = new int*[] { };
            /*  fixed(int* nTest = numbers3)
              {
                  foreach (int i in numbers3)
                  {
                      System.Console.WriteLine("Value:{0}", i);
                  }

                  System.Console.WriteLine("3D Array");

                  var length = numbers3.Length;
                  for (int i = 0; i < numbers3.Rank; i++)
                  {
                      total *= numbers3.GetLength(i);
                      System.Console.WriteLine("Position:{0} Value:{1}", i, numbers3.Rank);
                  }

                  //System.Console.WriteLine(numbers3[1, 0]);
                  //System.Console.WriteLine(numbers3[1, 1]);
                  System.Console.WriteLine("{0} equals {1}", length, total);
                  */

        }
        }
    }
