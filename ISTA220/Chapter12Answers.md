# ISTA220 C# Chapter 12 Homework

### Ryan Oberlin

1. How does inheritance promote the principle of don’t repeat yourself (DRY)?  
*yes, You don't have to write more lines of code to achieve similar results.*

2. What is the syntax of a derived class that inherits from a base class?
```C#
BaseClass : DerivedClass
```
3. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?  
*Yes (System.ValueType)*

4. What happens if you do not have a default constructor in a base class when creating a derived class?  
*It returns to default*

5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?  
*Yes, You are creating an instance of the derived class and assigning it as a type baseclase*

6. Can you assign a variable of a derived class to another variable of a derived class of its base class? Why or why not?  
*No, the behaviors don't interact*
7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?  
*Yes, You are creating an instance of the derived class and assigning it as a type baseclase*

8. Under what circumstances would you want to use the new keyword when defining a method in a derived class?  
*to hide inherited members*  

9. What is a virtual method? Why would you want to define a virtual method?  
*a modifier that ensures a method will be checked at runtime for override implementation*

10. What does override do? Why does it do it?  
*Provides new implementation of a base class*

11. How do you define an extension type?  
*define a class, use an access modifier. The code that is the user needs to have a using directive*

12. Why do you define an extension type?  
*You can add method calls, in support of the DRY principle*
