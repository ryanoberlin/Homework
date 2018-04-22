#!/bin/sh
echo Starting SQLite Commands

sqlite3 family.db << EOF

create table family (
	id interger,
	name text,
	sex interger,
	role text,
	age interger
	);

insert into family values (1,'Ryan',1,'Human',33);
insert into family values (2,'Sheeba',0,'Dog',7);
insert into family values (3,'Sayaka',0,'Waifu',27);

.schema family

select * from family;
select * from family where sex = 1;
select * from family where role like 'dog';
select name from family;
select avg(age) from family;
select sum(age) from family;

EOF
