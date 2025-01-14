USE LEETCODE
GO

--CRIANDO
--Create table Employee (id int, name varchar(255), salary int, managerId int)
--Truncate table Employee
--insert into Employee (id, name, salary, managerId) values ('1', 'Joe', '70000', '3')
--insert into Employee (id, name, salary, managerId) values ('2', 'Henry', '80000', '4')
--insert into Employee (id, name, salary, managerId) values ('3', 'Sam', '60000', NULL)
--insert into Employee (id, name, salary, managerId) values ('4', 'Max', '90000', NULL)

--SOLUCAO
SELECT
	name as Employee
FROM dbo.Employee
WHERE Employee.salary > (SELECT salary FROM Employee AS E2 WHERE Id = Employee.managerId);
