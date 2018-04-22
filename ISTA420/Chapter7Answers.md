# ISTA420 SQL Chapter 7 Homework

### Ryan Oberlin

1. What is a window function?  
*a function that calculates across a set of related rows.*

2. What does PARTITION do?  
*restricts the window to a subset of rows that have the same values*

3. What does ORDER BY do?  
*defines the ordering*

4. What does ROWS BETWEEN do?  
*sets upper and lower bounds on the set*

5. What is a ranking window function? Why would you use it? Give an example.  
*the assign a value to each returned row, to compare rows*  
```SQL
SELECT t.colum1, t.column2, t.colum3,
RANK() OVER (ORDER BY colum2 DESC) AS rank
FROM table AS t;
```

6. What is an offset window function? Why would you use it? Give an example.  
*sets a limit for rows before or after a row*  
 ```SQL
SELECT colum1, colum2
FROM table
ORDER BY colum1
OFFSET 10 ROWS;
 ```
7. What do LEAD and LAG DO  
*access rows without using the JOIN clause*

8. What do FIRST VALUE and LAST VALUE do?  
*Returns the first or last value in a set*

9. What is an aggregate window function? Why would you use it? Give an example.  
*A function that performs a calculation over a group of rows, some built in functions are AVG, COUNT, MIN, and SUM*
10. What is a pivot table and what does it do?
*it turns unique values in a column into multiple columns* 
