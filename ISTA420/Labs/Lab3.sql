#!/bin/sh


sqlite3 nw-150810.db >> EOF

.echo on
.headers on

select e.lastname, e.firstname, e.employeeid, o.employeeid, o.orderdate, o.orderid 
	from orders o join employees e on e.employeeid = o.employeeid
	order by e.lastname, e.firstname, o.orderdate, o.orderid;


select t.territorydescription, t.regionid, r.regionid, r.regiondescription
	from region r join territories t on r.regionid = t.regionid 
	order by r.regiondescription, t.territorydescription;

select s.companyname, s.supplierid, s.contactname, p.productname, p.supplierid 
	from suppliers s join products p on s.suplierid = p.supplierid
	order by s.companyname;

select i.orderid, i.productid, i.unitprice, i.quantity, o.orderid, o.orderdate
	from orders o join order_details i on o.orderid = i.orderid 
	where o.orderdate = '1998-05-06';

# orders from 5 may 1998, quantity of items, name of items, and price.

select p.productname,i.orderid, i,productid, i.unitprice, i.quantity, 
	o.orderid, o.orderdate, p.productid 
	from orders o join order_details i on o.orderid = i.orderid
	join products p by products p on p.productid = i.productid 
	where o.orderdate = '1998-05-06' order by p.productname;

# orders from may with customer & shipper name

select o.orderid, o.shipperid, o.customerid, o.shipperid, c.customerid, c.customername,
	s.shpperid from customers c join orders o on c.customerid = o.customerid 
	join shippers s on s.shipperid = o.shipperid where o.orderdate = '1998-05-%'; 

#customer and employee name for orders shipped to france(territories)

select c.customerid, c.contactname, o.customerid, o.employeeid + ' ' e.employeeid,
	o.shipcountry, c.customerid, c.contactname, 
	e.firstname || + || e.lastname 
	from employees e
	join customers c on c.customerid  = o.customerid 
	join orders o on o.employeeid = e.employeeid where o.shipcountry = 'France';

#List products that were shipped to germany

select i.orderid, i.productid, o.orderid, o.shipcountry, p.productname
	from orders o 
	join order_details i on i.orderid = o.orderid 
	join products p on p.productid = i.productid
	where o.shipcountry = 'Germany' order by p.productid;

EOF
