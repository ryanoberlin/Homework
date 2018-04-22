using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace BinaryTreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstExample();

        }
        static void FirstExample()
        {
            Tree<int> tree1 = new Tree<int>(10);
            tree1.Insert(5);
            tree1.Insert(11);
            tree1.Insert(5);
            tree1.Insert(-12);
            tree1.Insert(15);
            tree1.Insert(0);
            tree1.Insert(14);
            tree1.Insert(-8);
            tree1.Insert(10);
            tree1.Insert(8);
            tree1.Insert(8);

            string sortedData = tree1.WalkTree();
            Console.WriteLine($"Sorted Data is: {sortedData}");

            Tree<string> tree2 = new Tree<string>("Hello");
            tree2.Insert("World");
            tree2.Insert("How");
            tree2.Insert("are");
            tree2.Insert("you");
            tree2.Insert("today");
            tree2.Insert("I");
            tree2.Insert("hope");
            tree2.Insert("you");
            tree2.Insert("are");
            tree2.Insert("feeling");
            tree2.Insert("well");
            tree2.Insert("!");

            sortedData = tree2.WalkTree();
            Console.WriteLine($"Sorted Data is: {sortedData}");
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }

        static void SwapTest()
        {
            int a = 1, b = 2;

            string s1 = "Hello", s2 = "World";
            Swap<string>(ref s1, ref s2);
        }
      
    }
}
