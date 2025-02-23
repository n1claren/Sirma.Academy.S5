-- 1. Create a Database and Tables

CREATE DATABASE SchoolDB;

USE SchoolDB;

CREATE TABLE Students 
(
    StudentID INT PRIMARY KEY,
    Name VARCHAR(100),
    Age INT
);

CREATE TABLE Courses 
(
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(100)
);

CREATE TABLE Enrollments 
(
    EnrollmentID INT PRIMARY KEY,
    StudentID INT,
    CourseID INT,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

-- 2. Insert Sample Data

INSERT INTO Students (StudentID, Name, Age) 
VALUES
(1, 'Alice', 20),
(2, 'Bob', 22),
(3, 'Charlie', 21);

INSERT INTO Courses (CourseID, CourseName) 
VALUES
(101, 'Mathematics'),
(102, 'Physics'),
(103, 'Computer Science');

INSERT INTO Enrollments (EnrollmentID, StudentID, CourseID) 
VALUES
(1, 1, 101),
(2, 1, 103),
(3, 2, 103),
(4, 3, 101),
(5, 3, 102),
(6, 3, 103);

-- 3. All Students and Their Courses

SELECT s.Name AS StudentName, c.CourseName
FROM Students s
JOIN Enrollments e ON s.StudentID = e.StudentID
JOIN Courses c ON e.CourseID = c.CourseID
ORDER BY s.Name;

-- 4. Count Students Per Course

SELECT c.CourseName, COUNT(e.StudentID) AS StudentCount
FROM Courses c
LEFT JOIN Enrollments e ON c.CourseID = e.CourseID
GROUP BY c.CourseName;

-- 5. Find Students Without Courses

SELECT s.Name AS StudentName
FROM Students s
LEFT JOIN Enrollments e ON s.StudentID = e.StudentID
WHERE e.CourseID IS NULL;

-- 6. List Employees and Their Projects

SELECT e.Name AS EmployeeName, p.ProjectName
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;

-- 7. Department with the Highest Total Salary

SELECT TOP 1 Department, SUM(Salary) AS TotalSalary
FROM Employees
GROUP BY Department
ORDER BY TotalSalary DESC

-- 8. Employees Working on More Than One Project

SELECT EmployeeID, COUNT(ProjectID) AS ProjectsCount
FROM EmployeeProjects
GROUP BY EmployeeID
HAVING COUNT(ProjectID) > 1;

-- 9. Budget Per Project

SELECT p.ProjectName, SUM(e.Salary) AS BudgetSpent
FROM Projects p
JOIN EmployeeProjects ep ON p.ProjectID = ep.ProjectID
JOIN Employees e ON ep.EmployeeID = e.EmployeeID
GROUP BY p.ProjectName;

-- 10. Employees Without Projects

SELECT e.Name AS EmployeeName
FROM Employees e
LEFT JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
WHERE ep.ProjectID IS NULL;

-- 11. Create a Stored Procedure

CREATE PROCEDURE GetEmployeesByDepartment @DepartmentName VARCHAR(50)
AS
BEGIN
    SELECT Name
    FROM Employees
    WHERE Department = @DepartmentName;
END;

EXEC GetEmployeesByDepartment @DepartmentName = 'IT';

-- 12. Implement a User-Defined Function

CREATE FUNCTION GetProjectBudget(@ProjectID INT)
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN (SELECT Budget FROM Projects WHERE ProjectID = @ProjectID);
END;

SELECT dbo.GetProjectBudget(101) AS ProjectBudget;

-- 13. Implement a Transaction

BEGIN TRANSACTION;

BEGIN TRY
    INSERT INTO Employees (EmployeeID, Name, Department, Salary) VALUES
    (12, 'Nikolay Ivanov', 'IT', 1500);

    INSERT INTO EmployeeProjects (EmployeeID, ProjectID, Role) VALUES
    (12, 101, 'Junior Developer');

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
END CATCH;

-- 15. Archive Completed Projects

CREATE TABLE ArchivedProjects 
(
ProjectID INT PRIMARY KEY,
ProjectName VARCHAR(100),
Budget DECIMAL(10,2)
);

INSERT INTO ArchivedProjects (ProjectID, ProjectName, Budget)
SELECT p.ProjectID, p.ProjectName, p.Budget
FROM Projects p
LEFT JOIN EmployeeProjects ep ON p.ProjectID = ep.ProjectID
WHERE ep.EmployeeID IS NULL;

DELETE p
FROM Projects p
LEFT JOIN EmployeeProjects ep ON p.ProjectID = ep.ProjectID
WHERE ep.EmployeeID IS NULL;