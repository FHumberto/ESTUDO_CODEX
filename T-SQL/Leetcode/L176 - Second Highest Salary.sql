USE LEETCODE
GO

--CRIANDO

--BEGIN TRANSACTION
	--Create table Person (personId int, firstName varchar(255), lastName varchar(255))
	--Create table Address (addressId int, personId int, city varchar(255), state varchar(255))
	--Truncate table Person
	--insert into Person (personId, lastName, firstName) values ('1', 'Wang', 'Allen')
	--insert into Person (personId, lastName, firstName) values ('2', 'Alice', 'Bob')
	--Truncate table Address
	--insert into Address (addressId, personId, city, state) values ('1', '2', 'New York City', 'New York')
	--insert into Address (addressId, personId, city, state) values ('2', '3', 'Leetcode', 'California')
--ROLLBACK

--EXPLORACAO
SELECT * FROM dbo.Person
SELECT * FROM dbo.Address

--SOLUCAO
SELECT 
	p.firstName,
	p.lastName,
	a.city,
	a.state
FROM dbo.Person p
	LEFT JOIN dbo.Address a ON p.personId = a.personId