# ISTA420 SQL Chapter 3 Homework

### Ryan Oberlin

1. In your own words, what is a subquery?
*a query within a query*

2. In your own words, what is a self contained subquery?
*self contained queries are independent of the outer table*

3. In your own words, what is a correlated subquery?
*it depends on the objects in the outer table*

4. Give an example of a subquery that returns a single value. When would you use this kind of subquery?
```SQL
SELECT SUM (Sales) FROM Store_Information
WHERE Store_Name IN
(SELECT Store_Name FROM Geography
WHERE Region_Name = 'West');
```
5. Give an example of a subquery that returns multiple values. When would you use this kind of subquery?
```SQL
SELECT SUM (a1.Sales) FROM Store_Information a1
WHERE a1.Store_Name IN
(SELECT Store_Name FROM Geography a2
WHERE a2.Store_Name = a1.Store_Name);
```
6. Give an example of a subquery that returns table values. When would you use this kind of subquery?

7. What does the exists predicate do? Give an example.
*boolean for true that evaluates rows from a query*

8. What happens if we use the not operator before a predicate? Give an example.
*it negates the specified value*
9. When you use exists or not exists with respect to a row in a database, does it return two or three values? Explain your answer.

10. How would you a subquery to calculate aggregates? For example, you want to calculate yearly sales
of a product, and you also want to keep a running sum of total sales. Explain how you would use a subquery to do this.
