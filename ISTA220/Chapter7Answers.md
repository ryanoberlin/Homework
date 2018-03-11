# ISTA220 C# Chapter 7 Homework

### Ryan Oberlin

1. What is a class? According to the book, what does a class "arrange"?  
*Classes is a custom type that determines the behaviors. Classes arrange variables, methods, and events*

2. What are the two purposes of encapsulation?  
*Provide abstraction and hide data*

3. How do you instantiate an instance of a class? How do you access that instance?  
*you create a new instance of the class*
```C#
Class Object = new Class();
```

4. What is the default access of the fields and methods of a class? How do you change the default?
*The default access is private (if nested) You can change it by specifying the access modifier*

5. What is the syntax for writing a constructor?  
*The constructor only has the method name and its parameters with no return type*

6. What is the difference between class fields and methods, and instance fields and methods? How do you create class fields and methods?  
*How the information stored in memory is handled and what methods or classes have access to that memory. Fields store data that any method or class in the program can access.  
Instanced fields and methods store data until the variables are out of scope*  

7. How do you bring a static class in scope? Why would you want to bring a static class in scope?  
*You use the name of the class and the . operator to reference the desired method*

8. Can you think of a good reason to create an anonymous class? What is it?
*Yes. To not use all the properties in a class or define new ones specific the current instance*

9. What is polymorphism as this term is used in computer science? This is not in the book.
*it lets you group related tasks into one function*

10. What is message passing as this term is used in computer science? This is not in the book.
*Message passing is copying portions of the message being sent into a new location in memory and sending that information to a desired function*

11. What was the first object-oriented programming language?
*Informally: Lisp Formally: Simula 67*
12. Consider this quote by Alexander Stepanov:

 >I find OOP technically unsound. It attempts to decompose the world in terms of interfaces  
 that vary on a single type. To deal with the real problems you need multisorted algebras   
 families of interfaces that span multiple types. I find OOP philosophically unsound. It   
 claims that everything is an object. Even if it is true it is not very interesting saying that  
 everything is an object is saying nothing at all.  
 >

 Who is Alexander Stephanov? What do you think about this quote?  
 *A computer programmer and advocate for generic programming. I believe his point to be that the idea of object oriented programming  
  using objects as conceptual models to solve problems that aren't necessarily ordered in a hierarchical structure,  
  cannot be categorized into a group, or they can be grouped into the same category but share no real similarities  
  i.e. sponges and humans are in the same biological kingdom but not very similar. And even if you do use an object in such a way  
  the machine or some programmer somewhere who created the object has to understanding the underpinnings of the language, the machine,  
  and the problem to effectively frame a solution.*   
