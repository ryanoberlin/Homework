# ISTA420 SQL Chapter 1 Homework

### Ryan Oberlin

1. Give an informal definition of database as used in the expression relational database management system.  
*Collection of Information Organized into related sets that can be ordered logically and referenced.*

2.  Give an informal definition of database as used in the expression Human Resources database.  
*A collection of data sets relating to human resources.*   

3.  Give an informal definition of entity integrity.  
*A mechanism to maintain primary keys that requires the primary key row to be unique, and that it cannot be set to a null value.*  

4. Give an informal definition of referential integrity.  
*Referential Integrity is the mechanism that maintains foreign keys, a foreign key must always reference a primary key.*

5. What is a relation as defined in the textbook? A one word answer to this question is sufficient.  
*A Set*

6. Is this table in first normal form? Why or why not? If it is not, how would you change it?  
*No, the column facName and facCreds are not atomic and contain more than one value which can be subdivided. One solution would be to create additional  
columns for first and last names, as well as additional columns for credentials.*
```sql
create table faculty (
	facID int primary key,
	facName text,
	facCreds text,
	facCreds1 text,
	facCreds2 text
	facCreds3 text);
	```  
7. Is this table in second normal form? Why or why not? If it is not, how would you change it?   
*No, because the example contains a candidate keys that depend on the primary key. One solution would be to create two tables,  one for Owner ID and one for petID and relate them using a foreign key.*
```sql
create table owners (
	ownerID int primary key,
	ownerFirstName text,
	ownerLastName text);

	create table pets (
		petID int primary key,
		ownerID text,
		petName text,
		petType text,
		foreign key (ownerID) REFERENCES owners(ownerID));
```  	
8. Is this table in third normal form? Why or why not? If it is not, how would you change it?
 *No, in the example table friends, friendZip, friendCity, and friendState, rely on friendID. One solution would be to create two tables, using the friendZip as a foreign key.*
9. What is an OLTP database? What operations is it optimized for?
 *Online Transaction Processing, is optimized for Data Entry.*

10. What is a star schema? What operations is it optimized for?
 *A star schema is a style of schema that consists of one or more fact tables that reference dimension tables. It is optimized for simple queries*
