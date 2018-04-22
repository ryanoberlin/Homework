# ISTA420 SQL Chapter 8 Homework

### Ryan Oberlin

1. When using INSERT, is the list of columns necessary? Why or why not?  
*No, as long as you have the right number of column values*

2. When using INSERT SELECT, do you use a subquery (derived table)? Under what circumstances do you not use a subquery?  
*not if you don't want to. You wouldn't use a subquery when you are adding records from one table into another*
3. What is the operand for the INSERT EXEC statement?  
```SQL
SET @thing = 'dostuff'
INSERT INTO table
    EXEC @thing
```
4. How would you use the INSERT INTO statement?  
```SQL
INSERT INTO table (column, other_column)
VALUES (thing1, thing2);
```
5. What are the parameters to the BULK INSERT statement?  
*The Table the data will be inserted into, a file path to read data from and a description of the format*

6. Does IDENTITY guarantee uniqueness? If not, how do you guarantee uniqueness?  
*yes, either as a primary key or a unique key constraint*

7. How do you create a SEQUENCE object?  
*the CREATE SEQUENCE command*

8. How do you use a SEQUENCE object?  
*CREATE SEQUENCE*
9. How do you alter a SEQUENCE object?  
*ALTER SQUENCE*

10. What is the difference between DELETE and TRUNCATE?  
*TRUNCATE deletes all the rows from a table. DELETE only deletes matching rows based on the query*
11. What is the difference between DELETE and DROP TABLE?  
*DROP removes a table from the database, DELETE removes rows*
