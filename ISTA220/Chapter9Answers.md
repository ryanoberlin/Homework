# ISTA220 C# Chapter 9 Homework

### Ryan Oberlin

1. Declare an enum for military ranks, either officer or enlisted. Name it Ranks.  
What are the symbols, like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?
```C#
public enum Rank {Private,SGT,1SG,2LT,CPT};
```

2. Using the Ranks enum, assign a rank to yourself or a friend.
```C#
int me = (int)Rank.CPT;
int friend = (int)Rank.SGT;
```

3. Determine the numeric index of particular ranks, using the Ranks enum.
```C#
foreach (Rank rank in Enum.GetValues(typeof(Rank)))
{
  Console.WriteLine(Rank);
}
```
4. How do you select the type of an enum?
*Through the name of the enum. rank.*

5. Are structs stored on the stack or on the heap? What about enums?  
*Structs and enums are both stored on the stack.*

6. Declare a struct named DOD with four branches.
```C#
public struct DoD
{
public string Army;
public string Navy;
Public string Marines;
public string AirForce;  
}
```
7. Why can't you create a default constructor for a struct?  
*The compiler generates the default constructor.*

8. What is CIL? What does the CLR do to the CIL?  
*Common Intermediate Language. Common Language Runtime.*
