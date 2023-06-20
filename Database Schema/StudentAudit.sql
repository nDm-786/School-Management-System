create TABLE StudentAudit (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50),
    Age INT,
    Phone VARCHAR(10),
    Address VARCHAR(20),
    Gender VARCHAR(10),
    Password INT,
    ClassID INT,
    ModifiedBy VARCHAR(128),
    ModifiedDate DATETIME,
    Operation VARCHAR(20)
);


CREATE TRIGGER TrAuditStudents ON Students
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
            INSERT INTO StudentAudit
            (
                Name,
                Age,
                Phone,
                Address,
                Gender,
                Password,
                ClassID,
                ModifiedBy,
                ModifiedDate,
                Operation
            )
            SELECT
                D.Name,
                D.Age,
                D.Phone,
                D.Address,
                D.Gender,
                D.Password,
                D.ClassID,
                @login_name,
                GETDATE(),
                'UPDATION'
            FROM deleted D
        END
        ELSE
        BEGIN
            INSERT INTO StudentAudit
            (
                Name,
                Age,
                Phone,
                Address,
                Gender,
                Password,
                ClassID,
                ModifiedBy,
                ModifiedDate,
                Operation
            )
            SELECT
                D.Name,
                D.Age,
                D.Phone,
                D.Address,
                D.Gender,
                D.Password,
                D.ClassID,
                @login_name,
                GETDATE(),
                'DELETION'
            FROM deleted D
        END
    END
    ELSE
    BEGIN
        INSERT INTO StudentAudit
            (
                Name,
                Age,
                Phone,
                Address,
                Gender,
                Password,
                ClassID,
                ModifiedBy,
                ModifiedDate,
                Operation
            )
        SELECT
            I.Name,
            I.Age,
            I.Phone,
            I.Address,
            I.Gender,
            I.Password,
            I.ClassID,
            @login_name,
            GETDATE(),
            'INSERTION'
        FROM inserted I
    END
END