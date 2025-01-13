USE LEETCODE
GO

--CRIANDO
--Create table MyNumbers (num int)
--Truncate table MyNumbers
--insert into MyNumbers (num) values ('8')
--insert into MyNumbers (num) values ('8')
--insert into MyNumbers (num) values ('3')
--insert into MyNumbers (num) values ('3')
--insert into MyNumbers (num) values ('1')
--insert into MyNumbers (num) values ('4')
--insert into MyNumbers (num) values ('5')
--insert into MyNumbers (num) values ('6')

--CONSULTA A
SELECT *
FROM dbo.MyNumbers
WHERE num = 
	(
		SELECT MAX(num) AS num 
		FROM (
				SELECT num 
				FROM dbo.MyNumbers 
				GROUP BY num 
				HAVING COUNT(num) = 1) 
				grupamento
			  )

--CONSULTA B
SELECT COALESCE
(
    (SELECT TOP 1 num
     FROM dbo.MyNumbers
     WHERE num = 
         (SELECT MAX(num)
          FROM (
                  SELECT num
                  FROM dbo.MyNumbers
                  GROUP BY num
                  HAVING COUNT(num) = 1
               ) grupamento
         )
    ), NULL) AS num;
