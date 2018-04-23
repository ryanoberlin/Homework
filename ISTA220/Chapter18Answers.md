# ISTA220 C# Chapter 18 Homework

### Ryan Oberlin

1. You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will  
be handled by the team. For example, a ticket submitted a week ago has a higher priority than a  
ticked just submitted. What kind of data structure would you use, and why?  
*use a queue collection class it uses a FIFO data structure*

2. You are building a tracking system for seasonal agricultural farm labor. The labor requirements vary  
widely, depending on the season. Your requirement is that the newest hires are terminated first, and  
that our more experienced hires are kept longer. What kind of data structure would you use, and why?    
*use a stack data structure, it uses a first in last out data structure*
3. You are building a transaction database. Your requirement is that the database adds data very quickly,  
and that deletions, updates, and searches happen infrequently. In other words, data is typically added  
in the order in which the transaction occurs. What kind of data structure would you use, and why?    
*A LinkedList, its a double ended ordered list that is optimized to support insertion or removal of data*

4. You are building an analytical database. Your requirement is that the database handle queries very  
quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind  
of data structure would you use, and why?  
*a hash structure, it's optimized for retrieval*

5. You are building a personnel directory, where searched are performed by last name, first name, middle  
name. What kind of data structure would you use, and why?  
*Dictionary, its indexed*

6. You are building a username/password database. Your requirement is that updates happen frequently  
(when users change their passwords) and that searches (to authenticate users) happen extremely  
quickly. What kind of data structure would you use, and why?    
*Sorted List, sorted lists require keys for data retrieval*   

7. What is a lambda expression? Give an example. Why would we use a lambda expression?  
*it's a method without a deceleration, n => n * n. Save time declaring a method*

8. What is the difference between lambda expressions and anonymous methods? What are the advantages
of each?  
*it's possible to have an anonymous method that is not a lambda function, i.e. a delegate, a delegate   
is similar to a C function pointer*
