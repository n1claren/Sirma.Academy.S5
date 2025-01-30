CREATE DATABASE Workplace

USE Workplace

CREATE TABLE Departments 
(
    ID INT PRIMARY KEY IDENTITY(1, 1),
    Name VARCHAR(100) NOT NULL,
    ManagerID INT
);

CREATE TABLE Employees 
(
    ID INT PRIMARY KEY IDENTITY(1, 1),
    Name VARCHAR(100) NOT NULL,
    JobTitle VARCHAR(100),
    Email VARCHAR(100),
    DepartmentID INT,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(ID)
);

CREATE TABLE Projects 
(
    ID INT PRIMARY KEY IDENTITY(1, 1),
    Name VARCHAR(100) NOT NULL,
    ProjectDescription TEXT,
    Deadline DATE
);

CREATE TABLE EmployeeProjects 
(
    EmployeeID INT,
    ProjectID INT,
    PRIMARY KEY (EmployeeID, ProjectID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(ID),
    FOREIGN KEY (ProjectID) REFERENCES Projects(ID)
);

ALTER TABLE Employees
ADD CONSTRAINT fk_department
FOREIGN KEY (DepartmentID) REFERENCES Departments(ID)
ON DELETE CASCADE;

ALTER TABLE Employees
ADD CONSTRAINT fk_department_update
FOREIGN KEY (DepartmentID) REFERENCES Departments(ID)
ON UPDATE CASCADE;

-- Insert data into Departments
INSERT INTO Departments (Name, ManagerID) VALUES
('IT', NULL),
('Human Resources', NULL),
('Sales', NULL);

-- Insert data into Employees
INSERT INTO Employees (Name, JobTitle, Email, DepartmentID) VALUES
('Alice Brown', 'Software Engineer', 'alice.brown@sirma.com', 1),
('Bob Smith', 'HR Specialist', 'bob.smith@sirma.com', 2),
('Charlie Davis', 'Sales Manager', 'charlie.davis@sirma.com', 3),
('Dana White', 'DevOps Engineer', 'dana.white@sirma.com', 1),
('Eve Black', 'Intern', 'eve.black@sirma.com', 2),
('Frank Green', 'Product Manager', 'frank.green@sirma.com', 3),
('Grace Hall', 'Data Analyst', 'grace.hall@sirma.com', 1),
('Hank Jones', 'Marketing Specialist', 'hank.jones@sirma.com', 2),
('Ivy King', 'Software Developer', 'ivy.king@sirma.com', 3),
('Jack Lewis', 'System Administrator', 'jack.lewis@sirma.com', 1),
('Kara Moore', 'HR Manager', 'kara.moore@sirma.com', 2),
('Liam Nelson', 'Sales Executive', 'liam.nelson@sirma.com', 3),
('Mia Owens', 'Network Engineer', 'mia.owens@sirma.com', 1),
('Noah Parker', 'UX Designer', 'noah.parker@sirma.com', 2),
('Olivia Quinn', 'Project Manager', 'olivia.quinn@sirma.com', 3);

-- Retrieve all employees working on a specific project
SELECT e.Name, e.JobTitle
FROM Employees e
JOIN EmployeeProjects ep ON e.ID = ep.EmployeeID
WHERE ep.ProjectID = 1;

-- List all projects assigned to employees in a specific department
SELECT p.Name, p.ProjectDescription
FROM Projects p
JOIN EmployeeProjects ep ON p.ID = ep.ProjectID
JOIN Employees e ON ep.EmployeeID = e.ID
WHERE e.DepartmentID = 1;

-- Display all departments along with the names of their employees
SELECT d.Name AS DepartmentName, e.Name AS EmployeeName
FROM Departments d
LEFT JOIN Employees e ON d.ID = e.DepartmentID;

-- Employees by Department
SELECT e.Name AS EmployeeName, d.Name AS DepartmentName
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.ID;

-- Departments and Their Managers
SELECT d.Name AS DepartmentName, e.Name AS ManagerName
FROM Departments d
JOIN Employees e ON d.ManagerID = e.ID;
