USE LEETCODE
GO

--CRIANDO
--Create table Employee (empId int, name varchar(255), supervisor int, salary int)
--Create table Bonus (empId int, bonus int)
--Truncate table Employee
--insert into Employee (empId, name, supervisor, salary) values ('3', 'Brad', NULL, '4000')
--insert into Employee (empId, name, supervisor, salary) values ('1', 'John', '3', '1000')
--insert into Employee (empId, name, supervisor, salary) values ('2', 'Dan', '3', '2000')
--insert into Employee (empId, name, supervisor, salary) values ('4', 'Thomas', '3', '4000')
--Truncate table Bonus
--insert into Bonus (empId, bonus) values ('2', '500')
--insert into Bonus (empId, bonus) values ('4', '2000')

--EXPLORANDO
SELECT *
FROM dbo.Employee

SELECT *
FROM dbo.Bonus

--SOLUCAO
SELECT
	name,
	bonus
FROM dbo.Employee e
	FULL OUTER JOIN dbo.Bonus b ON B.empId = e.empId
WHERE b.bonus < 1000 OR b.bonus IS NULL