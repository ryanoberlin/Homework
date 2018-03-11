1.) a query within a query 

2.) self contained queries are independent of the outer table

3.) it depends on objects in the outer table 

4. 

SELECT SUM (Sales) FROM Store_Information
WHERE Store_Name IN
(SELECT Store_Name FROM Geography
WHERE Region_Name = 'West');

5.

SELECT SUM (a1.Sales) FROM Store_Information a1
WHERE a1.Store_Name IN
(SELECT Store_Name FROM Geography a2
WHERE a2.Store_Name = a1.Store_Name);

6. 

7.) boolean for true that evaluates rows from a query

8.) it negates that value

9.) 



