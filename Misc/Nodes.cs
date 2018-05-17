using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    class Program
    {

        static void Main(string[] args)
        {
            /* Input: head = 1 -> 5 ->4 ->2 -> NULL, valueToCheck = 2.  Result: true
            Input: Head = 1 -> 5 ->4 ->2 -> NULL, valueToCheck = 3.  Result: false*/
            Node noid = new Node();
            bool checktwo = noid.IsValueInList(2, noid);
            bool checkthree = noid.IsValueInList(3, noid);
            bool checktwoagain = noid.CheckAgain(2, noid);
            bool checkthreeagain = noid.CheckAgain(3, noid);
            bool nullcheck = noid.CheckAgain(null, noid);
            bool lazynull = noid.IsValueInList(null, noid);
            //bool extratwo = noid.ExtraCheck(2, noid);
           // bool extrathree = noid.ExtraCheck(3, noid);

            //Check with .Conains method
            Console.WriteLine("Lazy mode");
            Console.WriteLine(checktwo);
            Console.WriteLine(checkthree);

            //write our own method with properties
            Console.WriteLine("Not as Lazy Mode");
            Console.WriteLine(checktwoagain);
            Console.WriteLine(checkthreeagain);

            Console.WriteLine("Check for Null Values");
            Console.WriteLine(lazynull);
            Console.WriteLine(nullcheck);

           
            Console.WriteLine("Extra Check");
            Console.WriteLine(noid.Next);
        //  Console.WriteLine(extratwo);
        //  Console.WriteLine(extrathree);
        }

    }

    /* Input: head = 1 -> 5 ->4 ->2 -> NULL, valueToCheck = 2.  Result: true
    Input: Head = 1 -> 5 ->4 ->2 -> NULL, valueToCheck = 3.  Result: false*/

    class Node
    {
        public int? StoredValue { get; set; }
        public Node Next { get; set; }
        List<int?> MyList = new List<int?>() { 1, 5, 4, 2, null };

        List<Node> head = new List<Node>()
        {
            new Node { StoredValue = 1, Next = new Node() },
            new Node { StoredValue = 3, Next = new Node() },
            new Node { StoredValue = 5, Next = new Node() },
            new Node { StoredValue = null, Next = new Node() }

        };


        
        public bool CheckAgain(int? valueToCheck, Node head)
        { 

            foreach (int? i in head.MyList)
            {
                if (valueToCheck == i)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsValueInList(int? valueToCheck, Node head)
        {

            if (head.MyList.Contains(valueToCheck))
            {
                return true;
            }
            else if (head.MyList.Contains(valueToCheck))
            {
                return false;
            }
            else
            {
                return false;
            }
        }


    }
}
