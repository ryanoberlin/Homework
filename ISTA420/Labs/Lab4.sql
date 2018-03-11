#!/bin/sh

sqlite3 nw-150810.db >> EOF

.echo on
.headers on
.mode column

select o.orderid, o.employeeid from orders o where o.employeeid = 
	(select e.employeeid from employees e 
		where e.firstname like 'Janet');

select p.productname, p.categoryid from products p where p.categoryid =
	(select c.categoryid from categories c 
		where c.description like '%Fish%');

select o.orderid, o.employeeid from orders o where o.employeeid in
	(select e.employeeid from employees e
		where e.lastname like 'A%');

# product name, supplierid for all products supplied by exotic liquids
# grandma kellys homestead and tokyo traders

select p.productname, p.supplierid from products p where p.supplierid in 
	(select s.supplierid from suppliers s where s.companyname 
	       IN ('Exotic Liquids', "Grandma Kelly's Homestead", 'Tokyo Traders'));	

#create a report that shows ALL products supplied from the pacific ocean region

select p.productname, p.supplierid from products p where p.productid in
	(select s.supplierid from suppliers s where s.country in
		('Japan', 'Singapore', 'Australia'));

# a list of company names that have products in category 8

select 


line item report that contains a line for each product in order with the following:
order id, product id, the unit price, quantity sold, line item price and percent of the line item that constitutes the amount of the sale

