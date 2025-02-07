-- 1. Basic Transaction

BEGIN TRANSACTION;

INSERT INTO Accounts (AccountID, AccountName, Balance)
VALUES (1, 'John Doe', -100);

IF (SELECT Balance FROM Accounts WHERE AccountID = 1) < 0
BEGIN
    ROLLBACK TRANSACTION;
    PRINT 'Transaction rolled back due to negative balance.';
END
ELSE
BEGIN
    COMMIT TRANSACTION;
    PRINT 'Transaction committed successfully.';
END

-- 2. Transfer Funds Between Accounts

BEGIN TRANSACTION;

UPDATE Accounts
SET Balance = Balance - 500
WHERE AccountID = 1;

UPDATE Accounts
SET Balance = Balance + 500
WHERE AccountID = 2;

IF @@ERROR = 0
BEGIN
    COMMIT TRANSACTION;
    PRINT 'Funds transferred successfully.';
END
ELSE
BEGIN
    ROLLBACK TRANSACTION;
    PRINT 'Transaction rolled back due to an error.';
END

-- 3. Transaction with Error Handling

BEGIN TRANSACTION;

BEGIN TRY
    UPDATE Products
    SET Stock = Stock - 10
    WHERE ProductID = 1;

    COMMIT TRANSACTION;
    PRINT 'Stock updated successfully.';
END TRY

BEGIN CATCH
    ROLLBACK TRANSACTION;
    PRINT 'An error occurred. Transaction rolled back.';
END CATCH

-- 4. Savepoint Example

BEGIN TRANSACTION;

UPDATE Products
SET Quantity = Quantity - 5
WHERE ProductID = 1;

SAVE TRANSACTION Savepoint1;

UPDATE Products
SET Quantity = Quantity - 10
WHERE ProductID = 2;

IF @@ERROR > 0
BEGIN
    ROLLBACK TRANSACTION Savepoint1;
    PRINT 'Second update failed. Rolled back to savepoint.';
END
ELSE
BEGIN
    COMMIT TRANSACTION;
    PRINT 'Both updates completed successfully.';
END

-- 5. AFTER Trigger

CREATE TRIGGER trg_AfterInsertOrder
ON Orders
AFTER INSERT
AS
BEGIN
    INSERT INTO OrderLog (OrderID, LogDate)
    SELECT OrderID, GETDATE()
    FROM inserted;
END;

-- 6. INSTEAD OF Trigger

CREATE TRIGGER trg_InsteadOfDeleteEmployee
ON Employees
INSTEAD OF DELETE
AS
BEGIN
    INSERT INTO DeletedEmployees (EmployeeID, Name, Position, DeletedDate)
    SELECT EmployeeID, Name, Position, GETDATE()
    FROM deleted;
END;

-- 7. Trigger for Data Validation

CREATE TRIGGER trg_PreventNegativePrice
ON Products
FOR INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted WHERE Price < 0)
    BEGIN
        RAISERROR('Price cannot be negative.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

-- 8. Cascade Update with Trigger

CREATE TRIGGER trg_AfterUpdateDepartment
ON Departments
AFTER UPDATE
AS
BEGIN
    IF UPDATE(DepartmentName)
    BEGIN
        UPDATE Employees
        SET DepartmentName = i.DepartmentName
        FROM Employees e
        INNER JOIN inserted i ON e.DepartmentID = i.DepartmentID;
    END
END;

-- 9. Conditional Trigger

CREATE TRIGGER trg_AfterInsertHighValueOrder
ON Orders
AFTER INSERT
AS
BEGIN
    INSERT INTO HighValueOrders (OrderID, CustomerID, TotalAmount, RecordedDate)
    SELECT OrderID, CustomerID, TotalAmount, GETDATE()
    FROM inserted
    WHERE TotalAmount > 1000;
END;