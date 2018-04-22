# ISTA322 Homework 5

### Ryan Oberlin

1. What is a view engine?  
*it processes content looking for instructions to insert dynamically into a browser*  

2. What is Razor?  
*Razor is the view engine for ASP.NET*

3. What do views do? List two specific things in your answer to this question.  
*views display data to the user and allow them to modify it*

4. How does Razor respond when it encounters statements that begin with the at character (@)? Be specific.  
*It allows you to pass C# code to be rendered by razor*
5. How does Razor respond when it encounters statements that begin with the at character followed by the colon (@:)? Be specific.  
*it renders the rest of the line in html*  

6. Describe how you implement a standard formatting for all pages in an ASP.NET application.  
*You create a new view for your Layout, and use it as a view start file*

7. What is the difference in using Razor to interpolate data values as stand-alone HTML elements and as attributes to HTML elements. What is the similarity?  
*It allows you to mix code and text, its contained in the same code block*

8. What is a view start file and where is it located?  
*~/Views/_ViewStart.cshtml*
9. What is a Razor code block? What is the syntax of a Razor code block?  
```
@{}
```
10. Describe the different roles of action methods and views.  
*action methods are controllers with restrictions*

11. Describe the use of the @using statement. Give an example of how you would use it.  
*it brings a namespace into context* 
