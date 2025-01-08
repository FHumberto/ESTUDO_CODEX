USE LEETCODE
GO

--CRIANDO
--Create table Customers (id int, name varchar(255))
--Create table Orders (id int, customerId int)
--Truncate table Customers
--insert into Customers (id, name) values ('1', 'Joe')
--insert into Customers (id, name) values ('2', 'Henry')
--insert into Customers (id, name) values ('3', 'Sam')
--insert into Customers (id, name) values ('4', 'Max')
--Truncate table Orders
--insert into Orders (id, customerId) values ('1', '3')
--insert into Orders (id, customerId) values ('2', '1')

--EXPLORACAO
SELECT *
FROM customers

SELECT *
FROM orders

--Write a solution to find all customers who never order anything.
--Return the result table in any order.
--The result format is in the following example.

--SOLUCAO
SELECT
	c.name as customers
FROM customers c
	LEFT JOIN orders o ON c.id = o.customerId
WHERE o.customerId IS NULL