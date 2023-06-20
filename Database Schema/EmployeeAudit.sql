CREATE TABLE EmployeeAudit (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50),
    EmployeeID INT,
    ModifiedBy VARCHAR(128),
    ModifiedDate DATETIME,
    Operation VARCHAR(20)
);

CREATE TRIGGER TrEmployeeAudit
ON Employees
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @login_name VARCHAR(128)
 
    SELECT @login_name = login_name
    FROM sys.dm_exec_sessions
    WHERE session_id = @@SPID
 
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        IF EXISTS (SELECT * FROM inserted)
        BEGIN
            INSERT INTO EmployeeAudit
            (
                Name,
                EmployeeID,
                ModifiedBy,
                ModifiedDate,
                Operation
            )
            SELECT
                D.Name,
                D.EmployeeID,
                @login_name,
                GETDATE(),
                'UPDATION'
            FROM deleted D
        END
        ELSE
        BEGIN
            INSERT INTO EmployeeAudit
            (
                Name,
                EmployeeID,
                ModifiedBy,
                ModifiedDate,
                Operation
            )
            SELECT
                D.Name,
                D.EmployeeID,
                @login_name,
                GETDATE(),
                'DELETION'
            FROM deleted D
        END
    END
    ELSE
    BEGIN
        INSERT INTO EmployeeAudit
            (
                Name,
                EmployeeID,
                ModifiedBy,
                ModifiedDate,
                Operation
            )
        SELECT
            I.Name,
            I.EmployeeID,
            @login_name,
            GETDATE(),
            'INSERTION'
        FROM inserted I
    END
END;