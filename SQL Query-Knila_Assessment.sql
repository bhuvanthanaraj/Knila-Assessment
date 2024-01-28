
INSERT INTO [AssessmentDB].[dbo].[Books] ([Id],[Publisher], [Title], [AuthorFirstName], [AuthorLastName], [Price])
VALUES 
(NEWID(),'Publisher1', 'Book1', 'Bhuvaneshwaran', 'Thanaraj', 20.00),
(NEWID(),'Publisher2', 'Book2', 'Ram', 'Kumar', 50.00),
(NEWID(),'Publisher1', 'Book3', 'Jeeve', 'K', 30.00),
(NEWID(),'Publisher3', 'Book4', 'Bhuvaneshwaran', 'Thanaraj', 60.00);


SELECT * FROM [Books]

DELETE FROM [AssessmentDB].[dbo].[Books] WHERE [Id]='15020CF1-BDBE-4C53-8F31-28A166BC457B';

--Store procedure for orderbyauthor---

CREATE PROCEDURE Orderbyauthor
AS
BEGIN
    SELECT *
    FROM Books
    ORDER BY AuthorLastName, AuthorFirstName, Title;
END;



Exec Orderbyauthor


--Store procedure for orderbypublisher---

CREATE PROCEDURE Orderbypublisher
AS
BEGIN
SELECT *
FROM Books
ORDER BY Publisher,AuthorLastName,AuthorFirstName,Title;
END;



EXEC Orderbypublisher
