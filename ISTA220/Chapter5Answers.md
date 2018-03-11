# ISTA220 C# Chapter 5 Homework

### Ryan Oberlin

1. What is a compound assignment operator? How does it work?  
*Compound assignment operators assign new values to variables. The variable is only evaluated once making code more efficient.*

2. List all the compound assignment operators.
 ```C#

 += -= *= /= %=

 ```

3. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by 50.  
*A while loop*
 ```C#

 while(number < 50)
	 number += 5;
 ```
*or a for loop*
 ```C#

 for(number = 0; number <= 50; number += 5)
 {
 Console.WriteLine($"{number}");
 }

 ```
4. How long does a while loop run?  
*until it evaluates false*

5. What happens if you don't change the loop variable in the body of the while loop block?  
*It continues to run*

6. How many parts does a for loop statement have? Can you omit any of them? Can you omit all of them? What happens if you omit all of them?  
*it has 3 parts, intilized variable, evaluated condition, and afterthought/clean up. Yes. If you omit all sections it will be evaluated as while(true)*

7. How do you guarantee that a loop runs at least once?  
 *You use a do while loop*
 ```C#

 do {
	 code_here();
    }while(condition);
 ```
8. What does the break statement do?  
*break; terminates the loop.*

9. What does the continue statement do?  
*passes control to the loop that it's enclosed in.*
