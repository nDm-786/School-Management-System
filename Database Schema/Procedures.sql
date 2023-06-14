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
