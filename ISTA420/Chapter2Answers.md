# ISTA420 SQL Chapter 2a Homework

### Ryan Oberlin

1. What is a primary key constraint? What two other constraints is it equivalent to?  
 *A primary key constraint specifies that a primary key must have a unique non null value. It is equivalent to Unique and Null constraint*  

2. What is a nullability constraint? What does it prevent?  
*It determines if data entered into a column can be null or if it must be non-null. It prevents null data from being entered into a column*
3. What is a unique constraint? What does it prevent?  
*A unique constraint enforces uniqueness of a column without the need to make it a primary key. It prevents duplicate data from being entered.*  

4. What is a foreign key constraint? What does it allow?  
 *A foreign key constraint control the values that can be put into a column by checking a list of valid values associated with another table.*

5. What is a check constraint? What does it allow?  
*Check constraints limit the values that are accepted by one or more column.*

6. What is a default constraint? What does it allow?  
*The default constraint provides a default value for a column.*

7. What is domain integrity? This is not in your text book, but it’s important  
*Domain integrity ensures that a columns data is within a defined set of values.*
8. What is the difference between the where and the having clauses? How are they alike?  
*WHERE filters records from a result before grouping. HAVING filters values from a group.*

9. What SQL operator has the highest precedence? What SQL operator has the lowest precedence?  
*Parenthesis () have the highest precedence. Assignment = has the lowest.*

10. Yes or no: In the SQL standard, is NULL equal to NULL? Why or why not?  
*No, it is unknown. In SQL Null represents a missing value *
