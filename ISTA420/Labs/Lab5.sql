#!/bin/sh

sqlite3 nw-150810.db >> EOF

.echo on
.headers on
.mode column

with USAcust as
(select customerid, country from customers where country like 'USA')
select customerid, count(orderid) from orders
group by customerid order by count(orderid) desc; 
