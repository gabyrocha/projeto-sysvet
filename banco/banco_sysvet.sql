CREATE DATABASE dbsysvet2023

USE dbsysvet2023;

CREATE TABLE tblEspecies(
	espid int not null PRIMARY KEY,
	espnome varchar(50)
	);

CREATE TABLE tblAnimais(
	aniid int not null PRIMARY KEY,
	aninome varchar(50),
	aniapelido varchar(25),
	anidatanasc date,
	aniobs varchar(500),
	espid int FOREIGN KEY REFERENCES tblEspecies(espid)
	);

CREATE TABLE tblClientes(
	cliid int PRIMARY KEY,
	clinome varchar(50),
	clicpf decimal(11),
	cliemail varchar(100),
	clidatacadastro date
	);

CREATE TABLE tblAnimaisClientes(
	cliid int not null,
	aniid int not null,
	PRIMARY KEY (cliid, aniid),
    FOREIGN KEY (cliid) REFERENCES tblClientes(cliid),
    FOREIGN KEY (aniid) REFERENCES tblAnimais(aniid)
	);

INSERT INTO tblEspecies(espid, espnome)
VALUES  (01, 'Cachorro'),
		(02, 'Gato'),
		(03, 'Hamster'),
		(04, 'Passaro');

INSERT INTO tblClientes(cliid, clinome, clicpf, cliemail, clidatacadastro)
VALUES  (001, 'Maria Santos', '87698543671', 'mariasantos@exemplo.com', '2023-08-21'),
		(002, 'Joao Leme', '84579532689', 'joaoleme@exemplo.com', '2023-08-22'),
		(003, 'Marcos Faria', '23479845673', 'marcosfaria@exemplo.com', '2023-08-23'),
		(004, 'Marco Silva', '18765487982', 'marcosilva@exemplo.com', '2023-08-24'),
		(005, 'Bernardo Fernandes', '09865478965', 'bfernandes@exemplo.com', '2023-08-25'),
		(006, 'Marcelo da Silva', '12578885342', 'marcelodsilva@exemplo.com', '2023-08-26'),
		(007, 'Thomas Rezende', '88876544342', 'thomasrezende@exemplo.com', '2023-08-27'),
		(008, 'Wiliam Souza', '33245675641', 'willsouza@exemplo.com', '2023-08-28'),
		(009, 'Gabriele Rocha', '44567823450', 'gabirocha@exemplo.com', '2023-08-29'),
		(010, 'Bruna Gomes', '03138789476', 'brunagomes@exemplo.com', '2023-08-30');

INSERT INTO tblAnimais(aniid, aninome, aniapelido, anidatanasc, aniobs, espid)
VALUES  (001, 'Luna Aika','Polenta', '2020-11-02', 'Golden Retriever','01'),
		(002, 'Klaus Torgal','Torgalzinho', '2022-05-22', 'Chow Chow','01'),
		(003, 'Haru Aika','Loba', '2021-02-17', 'Husky Siberiano','01'),
		(004, 'Snowbell','Snow', '2016-05-21', 'Albino','02'),
		(005, 'Luke Skywalker','Luke', '2020-11-02', 'Sem raca definida','01'),
		(006, 'Thor Loki','Thorzinho', '2018-07-17', 'Hamster Sirio','03'),
		(007, 'Pigeotto','Pidgey', '2014-03-29', 'Cacatua','04'),
		(008, 'Stuart','Stu', '2021-03-21', 'Hamster Chines','03'),
		(009, 'Twix Rezende','Caramelo', '2021-03-15', 'Chihuahua','01'),
		(010, 'Angel Rezende','Princesuda', '2021-01-07', 'Maltes','01'),
		(011, 'Luna Rezende','Gorda', '2021-02-24', 'Maltes','01'),
		(012, 'Ursula','Ursinha', '2023-04-18', 'Bengal','02'),
		(013, 'Drogon','Meia Noite', '2020-11-02', 'Sem raca definida','02'),
		(014, 'Agnes','Branca', '2018-06-30', 'Labrador','01'),
		(015, 'Spark Sonic','Sonic', '2020-11-02', 'Bernese','01');


INSERT INTO tblAnimaisClientes(cliid, aniid)
VALUES  (009, 001),
		(002, 002),
		(009, 003),
		(001, 004),
		(003, 005),
		(004, 006),
		(005, 007),
		(006, 008),
		(007, 009),
		(007, 010),
		(007, 011),
		(008, 012),
		(001, 013),
		(010, 014),
		(002, 015);