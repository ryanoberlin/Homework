# ISTA420 SQL Chapter 3 Homework

### Ryan Oberlin

1. In general, why would you even want to join two (or more) tables together? This is a good time to think about the nature of relational algebra.  
*To see how tables with shared columns relate to each other.*

2. Describe in your own words the output from an inner join.  
*Returns records from tables that have matching values. An Intersection*

3. Describe in your own words the output from an outer join.  
*outer join matches rows from multiple tables*

4. Describe in your own words the output from an cross join.  
*Cross join is a union*

5. A convenient mnemonic for remembering the various joins is “Ohio.” Why is this true?  
*High on the ends Round in the Middle*

6. Give an example of a composite join.  
*Filter by multiple columns*

7. What is the difference between the following two queries? The business problem is “How many orders
do we have from each customer?”  
================first query===============  
```SQL
SELECT C.custid, COUNT(*) AS numorders
FROM Sales.Customers AS C
LEFT OUTER JOIN Sales.Orders AS O
ON C.custid = O.custid
GROUP BY C.custid;
```  
================second query===============
```SQL
SELECT C.custid, COUNT(O.orderid) AS numorders
FROM Sales.Customers AS C
LEFT OUTER JOIN Sales.Orders AS O
ON C.custid = O.custid
GROUP BY C.custid;
```  
*The number of items counted*

8. What might be one reason the following query does not return the column custID in this query?  
```SQL
SELECT C.custid, C.companyname, O.orderid, O.orderdate
FROM Sales.Customers AS C
LEFT OUTER JOIN Sales.Orders AS O
ON C.custid = O.custid
WHERE O.orderdate >= ’20160101’;
```
*No orderids on that date.*
