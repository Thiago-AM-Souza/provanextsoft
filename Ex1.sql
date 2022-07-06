--EXERCICIO 1

use master
go
create database ProvaNextSoft
go 
use ProvaNextSoft

create table Condominio (
	Id int not null identity,
	Nome varchar(30) not null,
	Bairro varchar(30) not null,
	constraint pk_condominio primary key(Id)
)

create table Apartamento (
	Id int not null identity,
	Numero int not null,
	CondominioId int not null,
	constraint pk_apartamento primary key(Id),
	constraint fk_condominio_apartamento foreign key(CondominioId)
		references Condominio(Id)
)

create table Familia(
	Id int not null identity,
	Nome varchar(30) not null,
	ApartamentoId int unique not null,
	constraint pk_familia primary key(Id),
	constraint fk_familia_apartamento foreign key(ApartamentoId)
		references Apartamento(Id)
)

create table Morador(
	Id int not null identity,
	Nome varchar(30) not null,
	Idade int not null,
	FamiliaId int not null,
	constraint pk_morador primary key(Id),
	constraint fk_familia_morador foreign key(FamiliaId)
		references Familia(Id)
)
--inserts condominio

insert into Condominio values ('Serra Negra', 'Vila Nova')
insert into Condominio values ('Casa Branca', 'Moema')
insert into Condominio values ('Bom Recanto', 'Vila Guarani')
insert into Condominio values ('Imaré', 'Capuava')
insert into Condominio values ('Andorinha', 'Jardim América')

--inserts Apartamento

insert into Apartamento values (10, 2)
insert into Apartamento values (45, 2)
insert into Apartamento values (110, 4)
insert into Apartamento values (712, 1)
insert into Apartamento values (715, 1)
insert into Apartamento values (640, 3)
insert into Apartamento values (301, 3)
insert into Apartamento values (507, 5)
insert into Apartamento values (530, 3)
insert into Apartamento values (507, 4)
insert into Apartamento values (310, 5)

-- inserts familia

insert into Familia values ('Silva', 1)
insert into Familia values ('Novaes', 2)
insert into Familia values ('Nobrega', 3)
insert into Familia values ('Campineli', 4)
insert into Familia values ('Souza', 5)
insert into Familia values ('Gonçalvez', 6)
insert into Familia values ('Camargo', 7)
insert into Familia values ('Brito', 8)
insert into Familia values ('Oliveira', 9)
insert into Familia values ('Jovanelli', 10)
insert into Familia values ('Vieira', 11)

--inserts morador

insert into Morador values ('Valmir', 65, 1)
insert into Morador values ('Lúcia', 27, 3)
insert into Morador values ('Marcelo', 35, 2)
insert into Morador values ('Irene', 78, 2)
insert into Morador values ('Marta', 31, 5)
insert into Morador values ('Alberto', 56, 11)
insert into Morador values ('Lucas', 10, 8)
insert into Morador values ('Maria', 25, 4)
insert into Morador values ('Mateus', 5, 9)
insert into Morador values ('Julia', 9, 10)
insert into Morador values ('Bernardo', 2, 5)
insert into Morador values ('Rosa', 18, 7)
insert into Morador values ('Helena', 23, 3)
insert into Morador values ('Willian', 15, 1)
insert into Morador values ('José', 42, 1)
insert into Morador values ('Priscila', 13, 3)
insert into Morador values ('Amanda', 29, 7)
insert into Morador values ('Guilherme', 22, 5)
insert into Morador values ('Roberta', 2, 4)
insert into Morador values ('Ricardo', 30, 4)
insert into Morador values ('Giovane', 81, 6)
insert into Morador values ('Flavia', 11, 6)
insert into Morador values ('Fabiana', 43, 11)
insert into Morador values ('Marcio', 20, 8)
insert into Morador values ('Roberto', 1, 7)
insert into Morador values ('Marcos', 4, 9)
insert into Morador values ('Rafael', 3, 4)
insert into Morador values ('Bruna', 1, 10)

-- PESSOAS 50 ANOS OU MAIS POR CONDOMINIO

select C.Nome as 'Condominio', COUNT(M.Idade) as 'Pessoas com 50 anos ou mais' 
	from Condominio as C 
	INNER JOIN Apartamento as A on A.CondominioId = C.Id
	INNER JOIN Familia as F on F.ApartamentoId = A.Id
	INNER JOIN Morador as M on M.FamiliaId = F.Id
	where M.Idade >= 50 
	group by C.Nome

-- PESSOAS, FAMILIA E CONDOMINIO

select M.Nome as 'Pessoa', F.Nome as 'Família', C.Nome as 'Condomínio' 
	from Morador as M 
	INNER JOIN Familia as F on M.FamiliaId = F.Id
	INNER JOIN Apartamento as A on A.Id = F.ApartamentoId
	Inner join Condominio as C on C.Id = A.CondominioId

-- MEDIA IDADE POR BAIRRO

select C.Bairro, AVG(M.Idade) as 'Média de idade por bairro' 
	from Condominio as C
	inner join Apartamento as A on A.CondominioId = c.Id
	inner join Familia as F on F.ApartamentoId = a.Id
	inner join Morador as M on M.FamiliaId = f.Id
	group by C.Bairro


-- Exercicio3 
alter table Condominio add AreaTotal float(53)
alter table Condominio add ValorIptu float(53)
go
update Condominio set AreaTotal = 0
update Condominio set ValorIptu = 0

alter table Apartamento add AreaTotal float(53)
alter table Apartamento add FracaoIdeal float(53)
alter table Apartamento add ValorProporcionalIptu float(53)
go
update Apartamento set AreaTotal = 0
update Apartamento set FracaoIdeal = 0
update Apartamento set ValorProporcionalIptu = 0