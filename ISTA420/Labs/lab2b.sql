#!/bin/sh
echo Starting SQLite3 Commands

sqlite3 nw-150810.db << EOF

.echo on
.headers on
select CustomerID, CompanyName, Country, from customers;

select CustomerID, CompanyName, Country, from customers
	Where country in('USA','Canada','Mexico');

select OrderID, OrderDate from orders where OrderDate like '%-04-%';

select ProductID, ProductName from products 
	where ProductName like '%sauce%';

select ProductID, ProductName from products 
	where ProductName like '%dried%';

select EmployeeID, ShipCountry, ShippedDate from orders
	where ShipCountry like 'Germany' 
	and ShippedDate like '%-25-%';

select OrderID, ProductID, UnitPrice, Quantity, 
	(UnitPrice * Quantity) as total_price,
	(UnitPrice * Quantity) -
	(UnitPrice * Quantity * Discount) as net_price, Discount
       	from order_details 
	where ProductID = '19' and Discount > '0';

select TitleOfCourtesy|| FirstName|| LastName|| ' 
	'|| Title|| ' ' from employees;

select substr(contactname, 1, pos-1) as first_name, companyname
	from (select *, instr(contactname,'_' as pos from customers)
	order by first_name;

select julianday('now') - julianday('1984-04-06');
	

EOF
