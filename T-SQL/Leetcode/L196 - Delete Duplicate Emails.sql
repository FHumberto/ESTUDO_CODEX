USE LEETCODE
GO

--Create table Person (Id int, Email varchar(255))
--Truncate table Person
--insert into Person (id, email) values ('1', 'john@example.com')
--insert into Person (id, email) values ('2', 'bob@example.com')
--insert into Person (id, email) values ('3', 'john@example.com')

--EMAIL COM MENOR id no GRUPO de igual
SELECT MIN(id) as min_id
FROM dbo.Person
GROUP BY Email

--SELECT
SELECT *
FROM dbo.Person
WHERE Id NOT IN (SELECT MIN(id) as min_id
FROM dbo.Person
GROUP BY Email)

--RESPOSTA

BEGIN TRANSACTION

DELETE dbo.Person
WHERE Id NOT IN (SELECT MIN(id) as min_id
FROM dbo.Person
GROUP BY Email)

ROLLBACK