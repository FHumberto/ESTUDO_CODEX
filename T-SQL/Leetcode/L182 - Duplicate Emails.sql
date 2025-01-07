USE LEETCODE
GO

--CRIANDO

	--BEGIN TRANSACTION
	--DROP TABLE IF EXISTS Employee;
	
	--CREATE TABLE Person (
	--    id INT,
	--    email VARCHAR(255)
	--);

	--TRUNCATE TABLE Person;

	--INSERT INTO Person (id, email) VALUES (1, 'a@b.com');
	--INSERT INTO Person (id, email) VALUES (2, 'c@d.com');
	--INSERT INTO Person (id, email) VALUES (3, 'a@b.com');
--ROLLBACK

--EXPLORACAO
WITH duplicate_emails AS
(
	SELECT email, COUNT(email) as duplicates
	FROM Person
	GROUP BY email
	HAVING COUNT(*) > 1
)

SELECT 
	email
FROM duplicate_emails