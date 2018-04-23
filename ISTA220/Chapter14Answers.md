1. What is the difference between a managed resource and an unmanaged resource?    
*Managed resources are handle by the CLR. Unmanaged resources are handled through design.*  

2. When is memory for an object (reference type) allocated? When is the memory deallocated?  
*it is allocated on execution and is deallocated when the method is complete*
3. What is a destructor?  
*a method to destruct a class or release resources*

4. What is the difference in syntax between a constructor and a destructor?  
*destructors cannot be called and are invoked automatically*

5. Give some examples of scarce resources. Why would you want to manage scarce resources?  
*an IoT device*
6. What is exception-safe disposal?
*removal of allocated resources in the event of a exception*

7. How do you think that the using statement works for resource management? Give an informal, English  
language, explanation of how it works.
*the using statement is a try catch block that calls dispose in the event of an exception*

8. What ill effects could result from attempting to dispose of a resource more than once?
*You dispose of another resource you didn't want to*

9. We will look at threads later in the term. For now, what is your understanding of how threads interact  
with resource management? A good guess is a sufficient answer to this question.  
*it depends on the operating system, in general threads are a set of instructions for a process that is scheduled for execution*

10. Why does the book recommend not attempting to force the garbage collector? Are their any exceptions  
to this recommendation?  
*the machine generally knows best, however garbage collection cannot occur when an object*
