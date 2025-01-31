-- 1. Orders with Customer Names and Countries
SELECT o.OrderID, o.OrderDate, c.CustomerName, c.Country
FROM Orders o
JOIN Customers c ON o.CustomerID = c.CustomerID;

-- 2. Order Details with Product Names and Prices
SELECT od.OrderID, p.ProductName, p.Price, od.Quantity
FROM OrderDetails od
JOIN Products p ON od.ProductID = p.ProductID;

-- 3. Orders with Shipper Information
SELECT o.OrderID, o.OrderDate, s.ShipperName
FROM Orders o
JOIN Shippers s ON o.ShipperID = s.ShipperID;

-- 4. Products by Category with Prices
SELECT p.ProductName, c.CategoryName, p.Price
FROM Products p
JOIN Categories c ON p.CategoryID = c.CategoryID;

-- 5. Supplier and Product List with Quantities Available
SELECT s.SupplierName, p.ProductName, p.Price
FROM Products p
JOIN Suppliers s ON p.SupplierID = s.SupplierID;

-- 6. Orders with Total Quantity and Total Price
SELECT 
    o.OrderID,
    c.CustomerName,
    SUM(od.Quantity) AS TotalQuantity,
    SUM(od.Quantity * p.Price) AS TotalPrice
FROM Orders o
JOIN Customers c ON o.CustomerID = c.CustomerID
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
GROUP BY o.OrderID, c.CustomerName;

-- 7. Products Ordered by Customer Names
SELECT c.CustomerName, p.ProductName, od.Quantity
FROM Orders o
JOIN Customers c ON o.CustomerID = c.CustomerID
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID;

-- 8. Shipped Orders with Shipper and Employee Names
SELECT o.OrderID, o.OrderDate, s.ShipperName, e.FirstName, e.LastName
FROM Orders o
JOIN Shippers s ON o.ShipperID = s.ShipperID
JOIN Employees e ON o.EmployeeID = e.EmployeeID;

-- 9. Orders by Category with Total Quantities
SELECT o.OrderID, c.CategoryName, SUM(od.Quantity) AS TotalQuantity
FROM Orders o
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
JOIN Categories c ON p.CategoryID = c.CategoryID
GROUP BY o.OrderID, c.CategoryName;

-- 10. Customers Who Ordered Specific Products
SELECT c.CustomerName, o.OrderID
FROM Orders o
JOIN Customers c ON o.CustomerID = c.CustomerID
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
WHERE p.ProductName = 'Tofu';

-- 11. Suppliers for Products in Each Category
SELECT c.CategoryName, s.SupplierName, p.ProductName
FROM Products p
JOIN Categories c ON p.CategoryID = c.CategoryID
JOIN Suppliers s ON p.SupplierID = s.SupplierID;

-- 12. Orders Grouped by Employee with Total Sales
SELECT e.FirstName, e.LastName, SUM(od.Quantity * p.Price) AS TotalSales
FROM Orders o
JOIN Employees e ON o.EmployeeID = e.EmployeeID
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
GROUP BY e.FirstName, e.LastName;

-- 13. List of Products That Have Never Been Ordered
SELECT p.ProductName
FROM Products p
LEFT JOIN OrderDetails od ON p.ProductID = od.ProductID
WHERE od.OrderID IS NULL;

-- 14. List All Orders Shipped by a Specific Shipper
SELECT o.OrderID, o.OrderDate, c.CustomerName
FROM Orders o
JOIN Customers c ON o.CustomerID = c.CustomerID
JOIN Shippers s ON o.ShipperID = s.ShipperID
WHERE s.ShipperName = 'Speedy Express';

-- 15. Find Customers Who Have Placed Orders in a Specific Month
SELECT c.CustomerName, o.OrderID
FROM Orders o
JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE MONTH(o.OrderDate) = 7;

-- 16. Products with Prices Higher Than the Average Price per Category
SELECT p.ProductName, p.Price
FROM Products p
JOIN Categories c ON p.CategoryID = c.CategoryID
WHERE p.Price > (SELECT AVG(Price) FROM Products WHERE CategoryID = p.CategoryID);

-- 17. Orders Containing Products from Multiple Categories
SELECT o.OrderID
FROM Orders o
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
GROUP BY o.OrderID
HAVING COUNT(DISTINCT p.CategoryID) > 1;

-- 18. Customers and Employees Linked by Orders
SELECT c.CustomerName, e.FirstName AS EmployeeFirstName, e.LastName AS EmployeeLastName, o.OrderID
FROM Orders o
JOIN Customers c ON o.CustomerID = c.CustomerID
JOIN Employees e ON o.EmployeeID = e.EmployeeID;

-- 19. Suppliers That Provide Products Ordered by a Specific Customer
SELECT s.SupplierName, p.ProductName
FROM Orders o
JOIN Customers c ON o.CustomerID = c.CustomerID
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
JOIN Suppliers s ON p.SupplierID = s.SupplierID
WHERE c.CustomerName = 'Wilman Kala';