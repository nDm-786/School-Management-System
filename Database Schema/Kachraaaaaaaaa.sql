CREATE VIEW TotalStudentsView AS
SELECT COUNT(*) AS TotalStudents
FROM Students;

SELECT * FROM TotalStudentsView;

CREATE VIEW TotalEmployeesView AS
SELECT COUNT(*) AS TotalEmployees
FROM Employees;
SELECT * FROM TotalEmployeesView;


create VIEW View_EnrollmentCountLast6Months AS
SELECT 
    COUNT(*) AS EnrollmentCount,
    CAST(DATEADD(month, -6, GETDATE()) AS DATE) AS StartDate,
    CAST(GETDATE() AS DATE) AS EndDate
FROM 
    Students
WHERE 
    dateofadmission >= CAST(DATEADD(month, -6, GETDATE()) AS DATE);

	SELECT * FROM View_EnrollmentCountLast6Months;

CREATE VIEW ClassWithMostAdmissions AS
SELECT c.ClassID, c.ClassName, COUNT(s.StudentID) AS Admissions
FROM Classes c
JOIN Students s ON c.ClassID = s.ClassID
GROUP BY c.ClassID, c.ClassName
HAVING COUNT(s.StudentID) = (
    SELECT MAX(AdmissionCount)
    FROM (
        SELECT ClassID, COUNT(StudentID) AS AdmissionCount
        FROM Students
        GROUP BY ClassID
    ) AS AdmissionCounts
)

select * from ClassWithMostAdmissions;

select * from Classes;

Select S.StudentID, S.Name, S.Phone, S.Address, S.ClassID from Students S inner join Classes C on S.ClassID = C.ClassID where C.ClassName = 'Class 1';

CREATE TABLE OnHoldStudents (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(50),
    Age INT,
    Phone VARCHAR(10),
    Address VARCHAR(20),
    Gender VARCHAR(10),
    Password INT,
    ClassID INT,
	dateofadmission date default getdate(),
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
	);

alter PROCEDURE AddStudentToOnHoldStudents
    @Name VARCHAR(50),
    @Age INT,
    @Phone VARCHAR(10),
    @Address VARCHAR(20),
    @Gender VARCHAR(10),
    @Password INT
AS
BEGIN
    INSERT INTO OnHoldStudents (Name, Age, Phone, Address, Gender, Password)
    VALUES (@Name, @Age, @Phone, @Address, @Gender, @Password);
END;

select * from OnHoldStudents;

CREATE PROCEDURE GetOnHoldStudents
AS
BEGIN
    SELECT * FROM OnHoldStudents;
END;


CREATE TRIGGER MoveStudents
ON OnHoldStudents
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE Name IS NOT NULL
            AND Age IS NOT NULL
            AND Phone IS NOT NULL
            AND Address IS NOT NULL
            AND Gender IS NOT NULL
            AND Password IS NOT NULL
            AND ClassID IS NOT NULL
    )
    BEGIN
        INSERT INTO Students (Name, Age, Phone, Address, Gender, Password, ClassID, dateofadmission)
        SELECT Name, Age, Phone, Address, Gender, Password, ClassID, dateofadmission
        FROM inserted
        WHERE Name IS NOT NULL
            AND Age IS NOT NULL
            AND Phone IS NOT NULL
            AND Address IS NOT NULL
            AND Gender IS NOT NULL
            AND Password IS NOT NULL
            AND ClassID IS NOT NULL;

        DELETE FROM OnHoldStudents
        WHERE StudentID IN (
            SELECT StudentID
            FROM inserted
            WHERE Name IS NOT NULL
                AND Age IS NOT NULL
                AND Phone IS NOT NULL
                AND Address IS NOT NULL
                AND Gender IS NOT NULL
                AND Password IS NOT NULL
                AND ClassID IS NOT NULL
        );
    END
END;

CREATE VIEW BestPerformingClass AS
SELECT ClassID, AVG(Marks) AS AverageMarks
FROM ExamResults
GROUP BY ClassID
HAVING AVG(Marks) = (
    SELECT MAX(AverageMarks)
    FROM (
        SELECT ClassID, AVG(Marks) AS AverageMarks
        FROM ExamResults
        GROUP BY ClassID
    ) AS Subquery
);

Update ExamResults set StudentID = 10001 where marks = 85; 


select * from ExamResults;
select * from BestPerformingClass;
Select ClassName from Classes where ClassID = (select ClassID from BestPerformingClass);

select * from OnHoldStudents;
update OnHoldStudents set ClassID = 1 where StudentID=3;

select * from Students;

INSERT INTO ExamResults (ExamID, StudentID, ClassID, SubjectID, Marks)
VALUES
    (1, 10000, 1, 1, 85),
    (1, 10001, 2, 1, 92),
    (1, 10002, 3, 1, 78),
    (1, 10003, 4, 1, 90),
    (1, 10004, 5, 1, 88),
    (1, 10005, 6, 1, 91),
    (1, 10006, 7, 2, 79),
    (1, 10007, 8, 2, 85),
    (1, 10008, 9, 2, 90),
    (1, 10009, 10, 2, 86);

update ExamResults set Marks = 91 where ClassID=6;


	truncate table Students 


CREATE VIEW GetOnHoldStudents1 AS
 SELECT COUNT(*) AS TotalOnHoldStudents
FROM OnHoldStudents;

select * from GetOnHoldStudents1;


alter TRIGGER UpdateStudents
ON OnHoldStudents
AFTER UPDATE
AS
BEGIN
    IF UPDATE(ClassID)
    BEGIN
        INSERT INTO Students (Name, Age, Phone, Address, Gender, Password, ClassID, dateofadmission)
        SELECT Name, Age, Phone, Address, Gender, Password, ClassID, dateofadmission
        FROM OnHoldStudents
        WHERE StudentID IN (SELECT StudentID FROM inserted);
		Delete from OnHoldStudents where StudentID IN (SELECT StudentID FROM inserted);
    END
END;

Update OnHoldStudents set ClassID = 7 where StudentID=4;

CREATE PROCEDURE InsertEmployee
    @EmployeeID INT,
    @Name VARCHAR(50),
    @Age INT,
    @Phone VARCHAR(10),
    @Address VARCHAR(20),
    @Gender VARCHAR(10),
    @RoleID INT,
    @Password INT
AS
BEGIN
    INSERT INTO Employees (EmployeeID, Name, Age, Phone, Adress, Gender, RoleID, Password)
    VALUES (@EmployeeID, @Name, @Age, @Phone, @Address, @Gender, @RoleID, @Password);
END

Alter PROCEDURE UpdateEmployee
    @EmployeeID INT,
    @Name VARCHAR(50),
    @Phone VARCHAR(10),
    @Address VARCHAR(20)
AS
BEGIN
    UPDATE Employees
    SET Name = @Name, Phone = @Phone, Adress = @Address 
    WHERE EmployeeID = @EmployeeID;
END

CREATE PROCEDURE DeleteEmployee
    @EmployeeID INT
AS
BEGIN
    DELETE FROM Employees
    WHERE EmployeeID = @EmployeeID;
END

CREATE PROCEDURE GetAllEmployees
AS
BEGIN
    SELECT *
    FROM Employees;
END


CREATE PROCEDURE GetAllTimeTables
AS
BEGIN
    SELECT * FROM TimeTables;
END;

CREATE PROCEDURE GetAllExams
AS
BEGIN
    SELECT * FROM Exams;
END;

insert into Admins (AdminID,Name,Password) Values (23, 'ARSALAN', 6969)


