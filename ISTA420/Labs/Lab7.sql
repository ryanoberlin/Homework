
USE TSQLV4;

SELECT custid, orderid, qty,
  RANK() OVER(PARTITION BY custid ORDER BY qty) AS rnk,
  DENSE_RANK() OVER(PARTITION BY custid ORDER BY qty) AS drnk
FROM dbo.Orders;

SELECT val, ROW_NUMBER() OVER(ORDER BY val) AS rownum
FROM Sales.OrderValues
GROUP BY val;

WITH C AS
(
  SELECT DISTINCT val
  FROM Sales.OrderValues
)
SELECT val, ROW_NUMBER() OVER(ORDER BY val) AS rownum
FROM C;

SELECT custid, orderid, qty,
  qty - LAG(qty) OVER(PARTITION BY custid
                      ORDER BY orderdate, orderid) AS diffprev,
  qty - LEAD(qty) OVER(PARTITION BY custid
                       ORDER BY orderdate, orderid) AS diffnext
FROM dbo.Orders;

SELECT empid,
  COUNT(CASE WHEN orderyear = 2014 THEN orderyear END) AS cnt2014,
  COUNT(CASE WHEN orderyear = 2015 THEN orderyear END) AS cnt2015,
  COUNT(CASE WHEN orderyear = 2016 THEN orderyear END) AS cnt2016
FROM (SELECT empid, YEAR(orderdate) AS orderyear
      FROM dbo.Orders) AS D
GROUP BY empid;

SELECT empid, [2014] AS cnt2014, [2015] AS cnt2015, [2016] AS cnt2016
FROM (SELECT empid, YEAR(orderdate) AS orderyear
      FROM dbo.Orders) AS D
  PIVOT(COUNT(orderyear)
        FOR orderyear IN([2014], [2015], [2016])) AS P;

DROP TABLE IF EXISTS dbo.EmpYearOrders;

CREATE TABLE dbo.EmpYearOrders
(
  empid INT NOT NULL
    CONSTRAINT PK_EmpYearOrders PRIMARY KEY,
  cnt2014 INT NULL,
  cnt2015 INT NULL,
  cnt2016 INT NULL
);

INSERT INTO dbo.EmpYearOrders(empid, cnt2014, cnt2015, cnt2016)
  SELECT empid, [2014] AS cnt2014, [2015] AS cnt2015, [2016] AS cnt2016
  FROM (SELECT empid, YEAR(orderdate) AS orderyear
        FROM dbo.Orders) AS D
    PIVOT(COUNT(orderyear)
          FOR orderyear IN([2014], [2015], [2016])) AS P;

SELECT * FROM dbo.EmpYearOrders;

SELECT empid, orderyear, numorders
FROM dbo.EmpYearOrders
  CROSS APPLY (VALUES(2014, cnt2014),
                     (2015, cnt2015),
                     (2016, cnt2016)) AS A(orderyear, numorders)
WHERE numorders <> 0;

SELECT empid, CAST(RIGHT(orderyear, 4) AS INT) AS orderyear, numorders
FROM dbo.EmpYearOrders
  UNPIVOT(numorders FOR orderyear IN(cnt2014, cnt2015, cnt2016)) AS U
WHERE numorders <> 0;

SELECT
  GROUPING_ID(empid, custid, YEAR(Orderdate)) AS groupingset,
  empid, custid, YEAR(Orderdate) AS orderyear, SUM(qty) AS sumqty
FROM dbo.Orders
GROUP BY
  GROUPING SETS
  (
    (empid, custid, YEAR(orderdate)),
    (empid, YEAR(orderdate)),
    (custid, YEAR(orderdate))
  );
