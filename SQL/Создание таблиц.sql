create table books(
	id_book serial primary key,
	name_book varchar(100),
	author varchar(100),
	start date,
	finish date,
	grade float,
	status status,
	note varchar(350)
)

create table films(
	id_film serial primary key,
	name_film varchar(100),
	director varchar(100),
	start date,
	finish date,
	status status,
	grade float,
	note varchar(350)
)

create table games(
	id_game serial primary key,
	name_game varchar(100),
	studio varchar(100),
	start date,
	finish date,
	status status,
	grade float,
	note varchar(350)
)

