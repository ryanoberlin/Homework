#!/bin/sh

select distinct country from suppliers
union
select distinct country from customers;

select city, country from suppliers
union
select city, country from customers
order by country, city;

select country from customers
intersect
select country from suppliers
order by country;

select city, country from customers
intersect
select city, country from suppliers
order by country, city;

select country from customers
except
select country from suppliers
order by country;

select country from suppliers
except
select country from countries
order by country;
