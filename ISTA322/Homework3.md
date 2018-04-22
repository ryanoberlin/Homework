# ISTA322 Homework 3

### Ryan Oberlin

1. The book states, “Interactions with an MVC application follow a natural cycle of user actions and view updates, where the view is assumed to be stateless.” What does it mean for the view to be stateless?  
*No data is retained between the sender and receiver*

2. The book identifies two kinds of models. Briefly describe each of them.    
*View models that represent data being transfered between controllers. Domain models that contain data*

3. Give an example of separation of concerns from your own life experience. This should be a simple, everyday example.  
*I don't think about how to clean(); dishes while I am serving(); food on them*

4. What is a view engine?  
*It renders/generates html*

5. The book notes that the three-tier structure, or n-tier model, is “the most widely used pattern for business applications.” Why do you think that this is true? An answer like, “Because it works well,” is not a sufficient answer to this question.  
*It helps manage complexity by breaking problems into smaller pieces that can be distributed across a large team*

6. This question requires some outside research. When we study UWP, you will see that the UWP design pattern is the Model-View-ViewModel (MVVM). What is the difference between MVC and MVVM that makes the first good for ASP.NET MVC and the second good for UWP?  
*MVC is fast and models can be independently modified. MVVM provides clear separation of concerns*   

7. Describe the two parts of the dependency injection (DI) design pattern.  
*Break and Declare, where you build an interface that uses the implementation you need. Injection, where you decide where the interface gets used*

8. Give an example of loose coupling from your own life experience. This should be a simple, everyday example.  
*the batteries in my TV remote are loosely coupled with the function of the remote*  
9. What are the two types of testing discussed in the book?  
*unit testing and integration testing*

10. What are the seven steps of the test driven development (TDD) workflow, as stated in the book?
> determine that a new feature needs to be added  
Write the test to validate the feature when it's written  
Run the test and get a red light  
Write the code that implements the new feature  
Run the test again and correct the code until you get a green light   
Refactor the code if required  
Run the test to confirm code changes have not changed behavior
>
