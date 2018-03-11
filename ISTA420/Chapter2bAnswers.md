# ISTA420 SQL Chapter 2b Homework

### Ryan Oberlin

1. List the order of execution of a SQL query.  
*Book: FROM, WHERE, GROUP BY, HAVING, SELECT, ORDER BY
   Complete Order: FROM, ON, OUTER, WHERE, GROUP BY, CUBE | ROLLUP, HAVING, SELECT, DISTRINCT, ORDER BY, TOP*

2. What does the from clause do?  
*The FROM clause is required in conjunction with select statements. It lists tables and views referenced columns. The from clause can be used in conjunction to join types.*

3. What does the where clause do?  
*The WHERE clause filters records, it only filters/extract records that within a specific condition.*

4. What does the group by clause do?  
*GROUP is used in conjunction with SELECT to combine data from multiple records into one or more columns*

5. What does the having clause do?  
*HAVING can only be used in with a SELECT statement. It is use to specify conditions for a group.*

6. What does the select clause do?  
*SELECT is used to select data from the database and store in a result-set*

7. What does the distinct keyword do?  
*DISTINCT removes duplicate results from a SELECT clause*

8. What does the order by clause do?  
*ORDER BY is used to sort the result-set in ascending/descending order.*

9. What does the limit clause do? This is not in the book.  
*LIMIT is used on conjunction with a select statement to restrict the number of records returned based on a limit value.*

10. What does the top clause do?  
*TOP limits the rose in a specific queary to the top N rows.*

11. What do the offset . . . fetch . . . clauses do?  
*OFFSET FETCH allows the user to begin fetching data at a pre-defined offset. i.e. you can skip the first ten rows.*
