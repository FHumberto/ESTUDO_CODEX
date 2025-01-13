USE LEETCODE
GO

--Create table orders (order_number int, customer_number int)
--Truncate table orders
--insert into orders (order_number, customer_number) values ('1', '1')
--insert into orders (order_number, customer_number) values ('2', '2')
--insert into orders (order_number, customer_number) values ('3', '3')
--insert into orders (order_number, customer_number) values ('4', '3')

--CONSULTA INÍCIAL
WITH total_numbers AS
(
	SELECT
		customer_number,
		COUNT(*) AS total_orders
	FROM dbo.orders
	GROUP BY customer_number
),
max_number AS
(
	SELECT
		MAX(total_orders) AS maxOrder
	FROM total_numbers
)
SELECT
	customer_number
FROM total_numbers 
WHERE total_orders = (SELECT maxOrder FROM max_number);



--CONSULTA MELHORADA
WITH total_numbers AS 
(
    SELECT
        customer_number,
        COUNT(*) AS total_orders
    FROM dbo.orders
    GROUP BY customer_number
)

SELECT 
	customer_number
FROM total_numbers
WHERE total_orders = (SELECT MAX(total_orders) FROM total_numbers)