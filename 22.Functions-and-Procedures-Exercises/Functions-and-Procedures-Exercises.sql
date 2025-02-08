CREATE DATABASE PracticeDB;
GO

USE PracticeDB;
GO

CREATE TABLE Employees 
(
    EmployeeId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    DateOfBirth DATE,
    DepartmentId INT,
    Salary DECIMAL(10,2)
);

CREATE TABLE Departments 
(
    DepartmentId INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName NVARCHAR(50)
);

CREATE TABLE Products 
(
    ProductId INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(50),
    CategoryId INT,
    Price DECIMAL(10,2),
    Stock INT
);

CREATE TABLE Categories 
(
    CategoryId INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(50)
);

INSERT INTO Departments (DepartmentName) 
VALUES 
('HR'), ('IT'), ('Sales'), ('Marketing');

INSERT INTO Employees (Name, DateOfBirth, DepartmentId, Salary)
VALUES
('John Doe', '1990-06-15', 1, 50000),
('Jane Smith', '1985-12-22', 2, 70000),
('Alice Brown', '1992-03-10', 3, 45000),
('Bob Johnson', '1988-09-05', 4, 55000);

INSERT INTO Categories (CategoryName) 
VALUES 
('Electronics'), ('Clothing'), ('Home Appliances');

INSERT INTO Products (ProductName, CategoryId, Price, Stock)
VALUES
('Smartphone', 1, 699.99, 50),
('Laptop', 1, 1299.99, 30),
('T-Shirt', 2, 19.99, 100),
('Vacuum Cleaner', 3, 149.99, 20);

-- 2. Scalar Functions

CREATE FUNCTION GetFullYear(@Date DATE)
RETURNS INT
AS
BEGIN
    RETURN YEAR(@Date);
END;

SELECT dbo.GetFullYear(GETDATE());

CREATE FUNCTION GetAnnualSalary(@MonthlySalary DECIMAL(10,2))
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN @MonthlySalary * 12;
END;

SELECT dbo.GetAnnualSalary(5000);

CREATE FUNCTION IsInStock(@ProductId INT)
RETURNS BIT
AS
BEGIN
    DECLARE @Stock INT;
    SELECT @Stock = Stock FROM Products WHERE ProductId = @ProductId;
    RETURN CASE WHEN @Stock > 0 THEN 1 ELSE 0 END;
END;

SELECT dbo.IsInStock(1);

CREATE FUNCTION GetDiscountPrice(@Price DECIMAL(10,2), @Discount DECIMAL(5,2))
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN @Price * (1 - @Discount / 100);
END;

SELECT dbo.GetDiscountPrice(699.99, 10);

-- 3. Inline Table-Valued Functions

CREATE FUNCTION GetEmployeesByDepartment(@DepartmentId INT)
RETURNS TABLE
AS
RETURN 
(
    SELECT EmployeeId, Name, DepartmentId, Salary
    FROM Employees
    WHERE DepartmentId = @DepartmentId
);

SELECT * FROM dbo.GetEmployeesByDepartment(1);

CREATE FUNCTION GetProductsByCategory(@CategoryId INT)
RETURNS TABLE
AS
RETURN 
(
    SELECT ProductId, ProductName, CategoryId, Price, Stock
    FROM Products
    WHERE CategoryId = @CategoryId
);

SELECT * FROM dbo.GetProductsByCategory(1);

CREATE FUNCTION GetAffordableProducts(@MaxPrice DECIMAL(10,2))
RETURNS TABLE
AS
RETURN 
(
    SELECT ProductId, ProductName, Price
    FROM Products
    WHERE Price <= @MaxPrice
);

SELECT * FROM dbo.GetAffordableProducts(1000);

CREATE FUNCTION GetDepartmentsWithEmployees()
RETURNS TABLE
AS
RETURN 
(
    SELECT DISTINCT D.DepartmentId, D.DepartmentName
    FROM Departments D
    INNER JOIN Employees E ON D.DepartmentId = E.DepartmentId
);

SELECT * FROM dbo.GetDepartmentsWithEmployees();

-- 4. Multi-Statement Table-Valued Functions

CREATE FUNCTION GetTopPaidEmployees(@DepartmentId INT)
RETURNS @TopPaidEmployees TABLE 
(
    EmployeeId INT,
    Name NVARCHAR(50),
    Salary DECIMAL(10,2)
)
AS
BEGIN
    INSERT INTO @TopPaidEmployees
    SELECT TOP 3 EmployeeId, Name, Salary
    FROM Employees
    WHERE DepartmentId = @DepartmentId
    ORDER BY Salary DESC;
    RETURN;
END;

SELECT * FROM dbo.GetTopPaidEmployees(2);

CREATE FUNCTION GetEmployeeDetails()
RETURNS @EmployeeDetails TABLE 
(
    EmployeeId INT,
    Name NVARCHAR(50),
    DepartmentName NVARCHAR(50),
    Salary DECIMAL(10,2)
)
AS
BEGIN
    INSERT INTO @EmployeeDetails
    SELECT E.EmployeeId, E.Name, D.DepartmentName, E.Salary
    FROM Employees E
    INNER JOIN Departments D ON E.DepartmentId = D.DepartmentId;
    RETURN;
END;

SELECT * FROM dbo.GetEmployeeDetails();

CREATE FUNCTION GetOutOfStockProducts()
RETURNS @OutOfStockProducts TABLE 
(
    ProductId INT,
    ProductName NVARCHAR(50),
    CategoryId INT,
    Price DECIMAL(10,2)
)
AS
BEGIN
    INSERT INTO @OutOfStockProducts
    SELECT ProductId, ProductName, CategoryId, Price
    FROM Products
    WHERE Stock = 0;
    RETURN;
END;

SELECT * FROM dbo.GetOutOfStockProducts();

CREATE FUNCTION GetEmployeesByAgeRange(@MinAge INT, @MaxAge INT)
RETURNS @EmployeesByAge TABLE 
(
    EmployeeId INT,
    Name NVARCHAR(50),
    Age INT
)
AS
BEGIN
    INSERT INTO @EmployeesByAge
    SELECT EmployeeId, Name, DATEDIFF(YEAR, DateOfBirth, GETDATE()) AS Age
    FROM Employees
    WHERE DATEDIFF(YEAR, DateOfBirth, GETDATE()) BETWEEN @MinAge AND @MaxAge;
    RETURN;
END;

SELECT * FROM dbo.GetEmployeesByAgeRange(30, 35);

-- 5. Stored Procedures

CREATE PROCEDURE UpdateSalary
    @EmployeeId INT,
    @Percentage DECIMAL(5,2)
AS
BEGIN
    UPDATE Employees
    SET Salary = Salary * (1 + @Percentage / 100)
    WHERE EmployeeId = @EmployeeId;
END;

EXEC UpdateSalary 1, 10;

CREATE PROCEDURE AddNewProduct
    @ProductName NVARCHAR(50),
    @CategoryId INT,
    @Price DECIMAL(10,2),
    @Stock INT
AS
BEGIN
    INSERT INTO Products (ProductName, CategoryId, Price, Stock)
    VALUES (@ProductName, @CategoryId, @Price, @Stock);
END;

EXEC AddNewProduct 'Smartwatch', 1, 199.99, 100;

CREATE PROCEDURE DeleteLowStockProducts
AS
BEGIN
    DELETE FROM Products
    WHERE Stock < 5;
END;

EXEC DeleteLowStockProducts;

CREATE PROCEDURE TransferEmployee
    @EmployeeId INT,
    @DepartmentId INT
AS
BEGIN
    UPDATE Employees
    SET DepartmentId = @DepartmentId
    WHERE EmployeeId = @EmployeeId;
END;

EXEC TransferEmployee 4, 2;