# ISTA220 C# Chapter 10 Homework

### Ryan Oberlin

1. What does an array look like in memory?
next to each other in sequence.
```C#
private static unsafe void Main()
       {

           int[] numbers = { 1, 2, 3, 4, 5 };

           fixed (int* p1 = numbers)
           {
               // Step through the array elements:
               for (int* p2 = p1; p2 < p1 + numbers.Length; p2++)
               {
                   System.Console.WriteLine("Value:{0} @ Address:{1}", *p2, (long)p2);
               }
           }
       }
```
2. Where is memory allocated to hold an array, on the stack or on the heap?
*allocated on the heap*
3. Where is memory allocated to hold an array reference, on the stack or on the heap?
*on the heap.*
4. Can an array hold values of different types? This is a trick question, the answer is, It depends.
*Sorta*
5. Describe the syntax of the condition or a foreach loop.
```C#
foreach(int i in numbers[i])
{
  doSomething();
}
```
6. How do you make a deep copy of a array?

7. What is the difference between a multi-dimensional array and an array of arrays?
*in theory the location of a multidimensional array will be sequential in memory and faster....*

8. How do you flatten a multidimensional array? In other words, take something that looks like a matrix  
[ 1 2 3 ]   
[ 4 5 6 ]  
[ 7 8 9 ]

 and turn it into an array [1, 2, 3, 4, 5, 6, 7, 8, 9]?
