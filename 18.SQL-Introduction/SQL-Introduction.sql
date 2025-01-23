/* 1. Creating a Database and Table */

CREATE DATABASE School;

USE School;

CREATE TABLE Students 
(
    StudentID INT NOT NULL PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Age INT,
    Grade VARCHAR(10)
);

/* 2. Inserting Data */

INSERT INTO Students (StudentID, FirstName, LastName, Age, Grade)
VALUES
    (1, 'John', 'Doe', 16, '10th'),
    (2, 'Jane', 'Smith', 15, '9th'),
    (3, 'Mike', 'Johnson', 17, '11th'),
    (4, 'Emily', 'Davis', 14, '8th'),
    (5, 'Chris', 'Brown', 18, '12th');

/* 3. Querying Data */

SELECT FirstName, Grade
FROM Students
WHERE Age > 14;

/* 4. Updating Data */

UPDATE Students
SET Grade = '12th'
WHERE StudentID = 3;

/* 5. Deleting Data */

DELETE Students WHERE StudentID = 3;

/* 6. Filtering Rows */

SELECT * 
FROM Students
WHERE Grade = '10th' AND Age BETWEEN 14 AND 16;

/* 7. Sorting Results */

SELECT * 
FROM Students
ORDER BY LastName ASC, Age DESC;

/* 8. Using Aliases */

SELECT CONCAT(FirstName, ' ', LastName) AS FullName, Grade
FROM Students;

/* 9. Advanced Insertion */

CREATE TABLE Graduates 
(
    StudentID INT NOT NULL PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Age INT,
    Grade VARCHAR(10)
);

INSERT INTO Graduates (StudentID, FirstName, LastName, Age, Grade)
SELECT StudentID, FirstName, LastName, Age, Grade
FROM Students
WHERE Grade = '12th';

/* 10. View Creation */

CREATE VIEW v_StudentsByGrade AS
SELECT CONCAT(FirstName, ' ', LastName) AS FullName, Grade
FROM Students;

