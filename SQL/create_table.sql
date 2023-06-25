CREATE TABLE table_account(
id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
login TEXT NOT NULL,
password TEXT NOT NULL,
is_active INTEGER NOT NULL DEFAULT 1
);

insert into table_account (login, password) values ('admin','12345');
insert into table_account (login, password) values ('user','12345');