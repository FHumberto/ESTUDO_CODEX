USE LEETCODE
GO

--Create table Courses (student varchar(255), class varchar(255))
--Truncate table Courses
--insert into Courses (student, class) values ('A', 'Math')
--insert into Courses (student, class) values ('B', 'English')
--insert into Courses (student, class) values ('C', 'Math')
--insert into Courses (student, class) values ('D', 'Biology')
--insert into Courses (student, class) values ('E', 'Math')
--insert into Courses (student, class) values ('F', 'Computer')
--insert into Courses (student, class) values ('G', 'Math')
--insert into Courses (student, class) values ('H', 'Math')
--insert into Courses (student, class) values ('I', 'Math')

SELECT *
FROM dbo.Courses 

--SOLU��O
SELECT 
	class
FROM 
	(SELECT class FROM dbo.Courses GROUP BY class HAVING COUNT(*) >= 5) total