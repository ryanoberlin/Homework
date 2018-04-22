# ISTA420 SQL Chapter 8 Homework

### Ryan Oberlin

1. The sales tax rate for a state just changed. How would you update the state sales tax table to reflect
the changes? Assume that this table has an ID column, an RATE column, and a STATE column.
```SQL
UPDATE dbo.StateSalesTax
SET RATE = newval
where STATE = whichstate;
```

2. The Revenue Division has requested that you provide a report on what the actual sales taxes would
have been for all orders in the past year, assuming the retroactivity of the new sales tax rate. How
would you calculate this?
*updated based on join*
```SQL
UPDATE ST
SET RATE = newval
FROM TAXES AS ST
JOIN orders as O
ON ST.orders = O.ordedrs
where STATE = whichstate;
```

3. Explain how the proprietary assignment update command works.  
*it combines the select and update statements. it allows columns to be maintained in an order list.*

4. What is one very important purpose of the MERGE SQL statement? What is ETL (not in book)?  
*ETL = Extract/Transform/Load*
5. What are the semantics of MERGE?
*performs insert, update or delete on a target table*

6. Write a typical INSERT OUTPUT statement.
```SQL
INSERT into mytable (My, list, of, stuff)
OUTPUT inserted.my, inserted.list, inserted.of, inserted.stuff into mytable2
```

7. Write a typical UPDATE OUTPUT statement.
```SQL
UPDATE mytable
set column1 = newstuff
output deleted.column1 into mytable2
where column1 = newstuff;
```
8. Write a typical DELETE OUTPUT statement.
```SQL
DELETE table1.mytable OUTPUT DELETED.*;
```
9. Write a typical MERGE OUTPUT statement.
```SQL
MERGE mystuff.mytable as target
USING (SELECT value FROM sourcetable) as source
ON (1=0)
WHEN NOT MATCHED THEN
INSERT (value)
VALUES (source.new)
OUTPUT INSERTED.new;
```

10. What is nested DML?  
*Data Manipulation Language*
