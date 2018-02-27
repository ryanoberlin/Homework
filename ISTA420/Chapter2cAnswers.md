1. A data type in regards to SQL defines the kind of value a column can contain.

2. Collation is a property of data that encapsulates different aspects. These can include, language support, sort order, case sensitivity, accent sensitivity.

3. You can strip whitespace using the TRIM function. (alternate: LTRIM and RTRIM) 
 
4. SELECT Name FROM colleges WHERE Name = 'Institute' 

5. SELECT CHAIRINDEX(' ', 'Barack Hussein Obama');

6.  SELECT name, LEFT(name,CHAIRINDEX(' ',name + ' ')-1 as FIRST from presidents

7. SELCT * FROM event where DATEDIFF(day,-30,getdate())

8. select birthday FROM children where DATEDIFF(day,now,birthday);

9. GETDATE(), SYSDATETIME()
