--1. AddSubject:
 
CREATE PROCEDURE AddSubject
    @SubjectID INT,
    @Name VARCHAR(50)
AS
BEGIN
    INSERT INTO Subjects (SubjectID, Name)
    VALUES (@SubjectID, @Name)
END
  

--2. UpdateSubject:
 
CREATE PROCEDURE UpdateSubject
    @SubjectID INT,
    @Name VARCHAR(50)
AS
BEGIN
    UPDATE Subjects
    SET Name = @Name
    WHERE SubjectID = @SubjectID
END
  

--3. DeleteSubject:
 
CREATE PROCEDURE DeleteSubject
    @SubjectID INT
AS
BEGIN
    DELETE FROM Subjects
    WHERE SubjectID = @SubjectID
END
  

--4. GetSubjectByID:
 
CREATE PROCEDURE GetSubjectByID
    @SubjectID INT
AS
BEGIN
    SELECT *
    FROM Subjects
    WHERE SubjectID = @SubjectID
END
  

--5. GetAllSubjects:
 
CREATE PROCEDURE GetAllSubjects
AS
BEGIN
    SELECT *
    FROM Subjects
END

--6. AddStudent:
 
alter PROCEDURE CreateStudent (
    @Name VARCHAR(50),
    @Phone VARCHAR(10),
    @Address VARCHAR(20)
)
AS
BEGIN
    INSERT INTO Students (Name,  Phone, Address)
    VALUES (@Name, @Phone, @Address);
END;

--7. UpdateStudent:
 
alter PROCEDURE UpdateStudent (
    @StudentID INT,
    @Name VARCHAR(50),
    @Phone VARCHAR(10),
    @Address VARCHAR(20)
    
)
AS
BEGIN
    UPDATE Students
    SET Name = @Name,  Phone = @Phone, Address = @Address 
    WHERE StudentID = @StudentID;
END;

--8. DeleteStudent:
 
CREATE PROCEDURE DeleteStudent (
    @StudentID INT
)
AS
BEGIN
    DELETE FROM Students
    WHERE StudentID = @StudentID;
END;
  

--9. GetStudentByID:
 
CREATE PROCEDURE GetStudentByID
    @StudentID INT
AS
BEGIN
    SELECT *
    FROM Students
    WHERE StudentID = @StudentID
END

alter Procedure getStudents
as
begin
select StudentID,Name,Phone,Address, ClassID from Students
end

-- DUMMY DATA OF 10 STUDENTS
INSERT INTO Students (Name, Age, Phone, Address, Gender, Password)
VALUES
    ('John Doe', 18, '1234567890', '123 Main St', 'Male', 1234),
    ('Jane Smith', 19, '9876543210', '456 Elm St', 'Female', 5678),
    ('Michael Johnson', 20, '5551234567', '789 Oak St', 'Male', 9012),
    ('Emily Davis', 18, '4445678901', '321 Pine St', 'Female', 3456),
    ('David Wilson', 19, '2229876543', '654 Cedar St', 'Male', 7890),
    ('Sarah Thompson', 20, '7775551234', '987 Birch St', 'Female', 2345),
    ('Daniel Anderson', 18, '6664445678', '159 Maple St', 'Male', 6789),
    ('Olivia Martinez', 19, '3332229876', '357 Walnut St', 'Female', 1234),
    ('Matthew Taylor', 20, '8887775551', '753 Oak St', 'Male', 5678),
    ('Sophia Hernandez', 18, '9996664445', '951 Elm St', 'Female', 9012);


	