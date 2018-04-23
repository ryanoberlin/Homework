using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCrap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[] { 0, 2, 3, 4, 6, 8, 10 };
            int[] arrayB = new int[] { 1, 3, 5, 7, 9 };
            int[] arrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int[] test = new int[] { 2, 2, 2 };
            int[] byarrB = RevArray(arrayB);
            int[] left = LeftShift(arrayA, 2);
            int[] right = RightShift(arrayA, 2);

            Console.WriteLine("The sum of arrayA is: " + CountArray(arrayA));
            Console.WriteLine("The sum of arrayB is: " + CountArray(arrayB));
            Console.WriteLine("The sum of arrayC is: " + CountArray(arrayC));

            Console.Write("The contents of arrayB reversed are:\n");
            foreach (int i in byarrB)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Right shift of arrayA by 2:");
            foreach(int k in right)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Left Shift of arrayA by 2:");
            foreach (int j in left)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("Array C sorted output");
            SortArray(arrayC);
   
        }

        static int[] RevArray(int[] arr)
        {
            int[] arr2 = new int[arr.Length];

            int j = 0;
            
            for (int i = arr.Length - 1 ; i >=0; i--)
            {

                arr2[j] = arr[i];
                j++;
            }
            
            return arr2;
        }

        static int CountArray(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            
            return sum;
        }

        static int[] RightShift(int[] arr, int pos)
        {
            int[] output = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                output[(i + pos) % arr.Length] = arr[i];
            }

            return output;
        }

        static int[] LeftShift(int[] arr, int pos)
        {
            int[] output = new int[arr.Length];
            for (int i = 0; i < arr.Length -1; i++)
            {
                output[i] = arr[(i+pos) % arr.Length];
            }

            return output;
        }

        static void SortArray(int[] arr)
        {
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
