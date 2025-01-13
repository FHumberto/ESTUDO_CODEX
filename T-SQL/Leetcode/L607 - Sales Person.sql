USE LEETCODE
GO

--CRIANDO
--Create table SalesPerson (sales_id int, name varchar(255), salary int, commission_rate int, hire_date date)
--Create table Company (com_id int, name varchar(255), city varchar(255))
--Create table Orders (order_id int, order_date date, com_id int, sales_id int, amount int)
--Truncate table SalesPerson
--insert into SalesPerson (sales_id, name, salary, commission_rate, hire_date) values ('1', 'John', '100000', '6', '4/1/2006')
--insert into SalesPerson (sales_id, name, salary, commission_rate, hire_date) values ('2', 'Amy', '12000', '5', '5/1/2010')
--insert into SalesPerson (sales_id, name, salary, commission_rate, hire_date) values ('3', 'Mark', '65000', '12', '12/25/2008')
--insert into SalesPerson (sales_id, name, salary, commission_rate, hire_date) values ('4', 'Pam', '25000', '25', '1/1/2005')
--insert into SalesPerson (sales_id, name, salary, commission_rate, hire_date) values ('5', 'Alex', '5000', '10', '2/3/2007')
--Truncate table Company
--insert into Company (com_id, name, city) values ('1', 'RED', 'Boston')
--insert into Company (com_id, name, city) values ('2', 'ORANGE', 'New York')
--insert into Company (com_id, name, city) values ('3', 'YELLOW', 'Boston')
--insert into Company (com_id, name, city) values ('4', 'GREEN', 'Austin')
--Truncate table Orders
--insert into Orders (order_id, order_date, com_id, sales_id, amount) values ('1', '1/1/2014', '3', '4', '10000')
--insert into Orders (order_id, order_date, com_id, sales_id, amount) values ('2', '2/1/2014', '4', '5', '5000')
--insert into Orders (order_id, order_date, com_id, sales_id, amount) values ('3', '3/1/2014', '1', '1', '50000')
--insert into Orders (order_id, order_date, com_id, sales_id, amount) values ('4', '4/1/2014', '1', '4', '25000')

SELECT * FROM dbo.orders

SELECT * FROM dbo.Company




--names of all the salespersons | who did not have any orders related to the company with the name "RED".
--Return the result table in any order.

SELECT *
FROM dbo.SalesPerson s
	INNER JOIN dbo.Orders o ON o.sales_id = s.sales_id
	INNER JOIN dbo.Company c ON c.com_id = o.com_id

SELECT * FROM dbo.SalesPerson

--SOLUTION
SELECT
	name
FROM dbo.SalesPerson
WHERE sales_id NOT IN
	(
		SELECT o.sales_id
		FROM dbo.orders o
			INNER JOIN dbo.Company c ON c.com_id = o.com_id
		WHERE c.name = 'RED'
	)