--1. AddSubject:
 
--CREATE PROCEDURE AddSubject
--    @SubjectID INT,
--    @Name VARCHAR(50)
--AS
--BEGIN
--    INSERT INTO Subjects (SubjectID, Name)
--    VALUES (@SubjectID, @Name)
--END
  

----2. UpdateSubject:
 
--CREATE PROCEDURE UpdateSubject
--    @SubjectID INT,
--    @Name VARCHAR(50)
--AS
--BEGIN
--    UPDATE Subjects
--    SET Name = @Name
--    WHERE SubjectID = @SubjectID
--END
  

----3. DeleteSubject:
 
--CREATE PROCEDURE DeleteSubject
--    @SubjectID INT
--AS
--BEGIN
--    DELETE FROM Subjects
--    WHERE SubjectID = @SubjectID
--END
  

----4. GetSubjectByID:
 
--CREATE PROCEDURE GetSubjectByID
--    @SubjectID INT
--AS
--BEGIN
--    SELECT *
--    FROM Subjects
--    WHERE SubjectID = @SubjectID
--END
  

----5. GetAllSubjects:
 
--CREATE PROCEDURE GetAllSubjects
--AS
--BEGIN
--    SELECT *
--    FROM Subjects
--END

----6. AddStudent:
 
--CREATE PROCEDURE CreateStudent (
--    @StudentID INT,
--    @Name VARCHAR(50),
--    @Phone VARCHAR(10),
--    @Address VARCHAR(20)
--)
--AS
--BEGIN
--    INSERT INTO Students (StudentID, Name,  Phone, Adress)
--    VALUES (@StudentID, @Name, @Phone, @Address);
--END;

----7. UpdateStudent:
 
--CREATE PROCEDURE UpdateStudent (
--    @StudentID INT,
--    @Name VARCHAR(50),
--    @Phone VARCHAR(10),
--    @Address VARCHAR(20)
    
--)
--AS
--BEGIN
--    UPDATE Students
--    SET Name = @Name,  Phone = @Phone, Adress = @Address 
--    WHERE StudentID = @StudentID;
--END;

----8. DeleteStudent:
 
--CREATE PROCEDURE DeleteStudent (
--    @StudentID INT
--)
--AS
--BEGIN
--    DELETE FROM Students
--    WHERE StudentID = @StudentID;
--END;
  

----9. GetStudentByID:
 
--CREATE PROCEDURE GetStudentByID
--    @StudentID INT
--AS
--BEGIN
--    SELECT *
--    FROM Students
--    WHERE StudentID = @StudentID
--END

