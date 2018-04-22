# ISTA420 SQL Chapter 5 Homework

### Ryan Oberlin

1. What is a table expression? Can you give a technical definition of a table expression?  
*a named queary that reepresents a valid relational table, its a virtual table*

2. In what SQL clause are derived tables (table valued subqueries) located?  
*the AS clause*

3. Why can you refer to column aliases in an outer query that you defined in an inner table valued subquery?  
*it's a referenced by its alias name*

4. What SQL key word defines a common table expression?  
*WITH*

5. When using common table expressions, can a subsequent derived table use a table alias declared in a preceding table expression?  
*YES*

6. Can a main query refer to a previously defined common table expression by multiple aliases?  
*YES*

7. In SQL, is a view a durable object?  
*Yes*

8. In a view, what does WITH CHECK OPTION do? Why is this important?  
*checks inserted rows against a view*

9. In a view, what does SCHEMABINDING do? Why is this important?  
*binds the schema to the database object it references, it can help prevent inadvertent changes*

10. What is a table valued function?  
*a function that returns a single result*

11. What does the APPLY operator do?  
*Invokes a table-valued function for each row returned by the outer table of a query*
12. What are the two forms of the APPLY operator? Give an example of each.  
*CROSS APPLY, OUTER APPLY*

```SQL
SELECT alias.column alias.column2
FROM mytable AS alias
CROSS APPLY myfunction(alias.column2) as NT;

SELECT * from table as aliases
(
  SELECT * from othertable as otheralias
  WHERE otheralias.column1 = alias.column1
)

```
