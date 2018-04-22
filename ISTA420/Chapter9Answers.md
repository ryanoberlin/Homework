# ISTA420 SQL Chapter 8 Homework

### Ryan Oberlin

1. What is a temporal table?  
*A table where entries are timestamped.*

2. Under what circumstances would you use a temporal table? Temporal tables are in widespread use in
certain kinds of businesses.
*Audits and banking*

3. What are the semantics of a temporal table? There are seven of them.

4. How do you search a history table?  
*Identify the sysstart and sysend time in your query.*

5. How do you modify a history table?
*using traditional DML*

6. How do you delete data from a history table? Why would you want to delete data from a history table?  
*You cannot delete data with the system versioning on. You would have to turn system No data is permanently deleted in a temporal table.
system_versioning = off must be set. The data may be no longer valid or incorrect.*

7. How do you search a history table?
```SQL
AS OF <date>
FROM <start> TO <stop>
BBETWEEN <start> AND <stop>
CONTAINED IN(<start>, <stop>)
ALL
```

8. How do you query all data from both a history file and the current data?
```SQL
SELECT * FROM table FOR SYSTEM_TIME ALL;
```

9. How do you drop a temporal table?
*Turn system versioning off then:
DROP table thing.table*
