# ISTA220 C# Chapter 8 Homework

### Ryan Oberlin

1. What is the difference between deep copy and shallow copy?  
*shallow copies copy the minimum information required. Deep copies copy everything.*

2. What is the value of a reference after you declare and initialize it?  
*depends on the type, but generally speaking 0*
3. How do you declare a value type?  
*using the reserved keyword and a variable name*  

4. How do you declare a reference type?

5. Does C# allow you to assign NULL to a value type?  
*sorta, it requires a ? as an operator associated with the type*  

6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?  
*No, the CLR won't let you*     

7. What is the difference between the stack and the heap?  
*objects on the stack are allocated at compile time, and objects on the heap are dynamically allocated at run time*  

8. What does it mean when we say that all classes are specialized types?
*classes can be thought of as types whos values are determined by the programmer and interpreted by the CLR*  
9. What does ref do?  
*passes an argument by reference instead of value*  

10. What does out do?  
*passes an argument to a method by reference*  

11. Describe boxing and unboxing in your own words.  
*boxing passes the value of a type to an object, unboxing extracts the value that was passed*  

12. What does cast do?  
*Passes the value of one type to a different type*
