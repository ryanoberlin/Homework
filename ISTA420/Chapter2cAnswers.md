# ISTA420 SQL Chapter 2c Homework

### Ryan Oberlin

1. What is a data type? Why do we have data types?  
*A data type in regards to SQL defines the kind of value a column can contain.*

2.  What is a collation? Name four elements of a collation.  
*Collation is a property of data that encapsulates different aspects. These can include, language support, sort order, case sensitivity, accent sensitivity.*
3. How would you strip whitespace from a string? For example, suppose you had &nbsp;"&nbsp;&nbsp;&nbsp; Dave &nbsp;&nbsp;&nbsp; "&nbsp; but wanted only “Dave”.  
*You can strip whitespace using the TRIM function. (alternate: LTRIM and RTRIM)*  

4. Suppose you wanted to make a list of every college and university that was called an Institute from the college table. Write the query.  
```SQL
SELECT Name FROM colleges WHERE Name like 'Institute'
```
5. How would you find out the index of the first space in a string? For example, the index of the first space in “Barack Hussein Obama” would be 7.  
```SQL
SELECT CHARINDEX(' ', 'Barack Hussein Obama');
```
6. How would you select just the first name in a list of the presidents. First names can be an arbitrary length, from “Cal” to “Benjamin.”  
```SQL
SELECT name, LEFT(name,CHARINDEX(' ',name + ' ')-1 as FIRST from presidents
```

7. Payments are due exactly 30 days from the date of the last function. Write a select query that calculates the date of the next payment.  
Pretend we want to update a column in a database that contains the date of the next payment.  
```SQL
SELECT * FROM event where DATEDIFF(day,-30,getdate())
From Class Discussion: *DateAdd (day,30,Lesspayment);
```  
8. Suppose your son or daughter wants to run a query every day that tells them the number of days until their 16th birthday. Write a select query that does this.  
```SQL  
select birthday FROM children where DATEDIFF(day,now,birthday);
```
9. What function returns the current date? This is very useful in a table that maintains a log of events, such as user logins.  

 ```SQL
 GETDATE(), SYSDATETIME()
 ```
 *From Class: EOMONTH(input[,months_to_add]);*
