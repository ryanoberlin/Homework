# ISTA220 C# Chapter 16 Homework

### Ryan Oberlin

1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.  
>(OR) |  
(AND)&  
(XOR)^  
 ~(NOT)  
 (Left/Right Shift)>> <<  
>

```C#
static void Main(string[] args) {
        int a = 60;            
        int b = 3;            
        int c = 0;

        third = first & second;            
        Console.WriteLine("Line 1 - Value of c is {0}", c );

        c = a | b;             
        Console.WriteLine("Line 2 - Value of c is {0}", c);

        c = a ^ b;             
        Console.WriteLine("Line 3 - Value of c is {0}", c);

        c = ~a;                
        Console.WriteLine("Line 4 - Value of c is {0}", c);

        c = a << 2;      
        Console.WriteLine("Line 5 - Value of c is {0}", c);

        c = a >> 2;      
        Console.WriteLine("Line 6 - Value of c is {0}", c);
        Console.ReadLine();
     }
```
2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using value
C# code.  
*Yes.*

3. Explain in detail this code: bits & (1 << index);.

4. Explain in detail this code: bits |= (1 << index);.

5. Explain in detail this code: bits &= (1 << index);.

6. How does C# interpret this? bool peek = bits[n];

7. How does C# interpret this? bits[n] = true;

8. How does C# interpret this? bits[n] ^= true;

9. Assume that users were assigned read, write, and execute permissions according to this scheme: read
= 1, write = 2, execute = 4. How would you interpret the following user permissions:
>(a) permission = 0 nothing  
(b) permission = 1 execute  
(c) permission = 2 write  
(d) permission = 3 execute & write  
(e) permission = 4 read & write  
(f) permission = 5 execute & read  
(g) permission = 6 read & write  
(h) permission = 7 execute & read & write  
>

10. Answer the previous question by converting the decimal permissions into binary permissions. What
does this tell you about using this scheme of permissions?
*Permissions
