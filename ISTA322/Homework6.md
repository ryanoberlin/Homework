# ISTA322 Homework 6

### Ryan Oberlin

1. What is the primary idea that underlies Dependency Injection?  
*separate behavior from and dependencies, loose coupling*

2. Describe the role of interfaces in implementing a dependency injection container.  
*you can uncouple behaviors*  
3. List the three stages of building basic Ninject functionality, and briefly define each stage.  
*prepare ninject for use by creating a new instance of the ninject kernel. configure the ninject kernel so it understands the implementation objects for each interface.  
the last step is to use ninject to create the object using the kernel Get method.*

4. What is the purpose of a custom dependency resolver?  
*Ensure that the MVC framework uses ninject when it creates object including instances of controllers*

5. What is the purpose of conditional binding? Describe how it works.  
*You can specify what classes are used to respond to specific interfaces*

6. Why is setting the object scope important when using dependency injection?  
*how many objects are created to resolve a dependency*

7. Briefly describe the Test Driven Development approach in developing an application.  
*you create the test for the code before you create the code*

8. Consider the Assert class. How do you access the methods of that class?  
*with an access operator*
9. Why is it useful to mock objects when developing software?  
*it is possible to write tests before an application is complete*

10. Briefly describe the two main issues that arise when attempting to do Unit Tests without the aid of some sort of mocking library.  
*using pre-packaged tools reduce the amount of code required to write a test case. without a mocking library you will have to implement your own classes for unit testing* 
