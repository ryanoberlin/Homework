# ISTA220 C# Chapter 20 Homework

### Ryan Oberlin

1. What is a delegate? Explain delegates in terms of pointers and reference types.  
*A way to pass a function as an argument*

2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.  
*public delegate returntype MethodName(params);
3. How do you create instances of delegates and assign values to the instance? What are the values?  
```C#
Delegate name = MethodName;
```
4. How do you invoke a method that has been added to a delegate?  

5. What is an event? Why do we have events?  

6. How do you declare events?  
*public event MethoName Event;*
7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?  

8. How do you raise an event? How do you declare code that raises an event?  

9. Explain with specificity what happens when an event fires and that event has been attached to a delegate.
*it executes the declared code*
