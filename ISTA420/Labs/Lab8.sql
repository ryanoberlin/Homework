#!/bin/sh


sqlite3 nw-150810.db >> EOF

.echo on
.headers on

create table presidents (
  name text,
  entered text,
  party text,
  state text,
);

.import presidents-short.csv presidents

delete from presidents where name like 'Pres%';
alter table presidents add column id integer;
update presidents set id = (rowid - 1);

  select * from presidents;
