
-- Insert dummy data into Subjects table
INSERT INTO Subjects (SubjectID, Name)
VALUES (1, 'Mathematics'),
       (2, 'Science'),
       (3, 'English'),
       (4, 'History'),
       (5, 'Geography'),
       (6, 'Computer Science'),
       (7, 'Physics'),
       (8, 'Chemistry'),
       (9, 'Biology'),
       (10, 'Art');

-- Insert dummy data into Roles table
INSERT INTO Roles (RoleID, Name)
VALUES (1, 'Teacher'),
       (2, 'Student'),
       (3, 'Staff'),
       (4, 'Admin');

-- Insert dummy data into Employees table
INSERT INTO Employees (EmployeeID, Name, Age, Phone, Adress, Gender, RoleID, Password)
VALUES (1, 'John Doe', 30, '1234567890', '123 Main St', 'Male', 1, 123456),
       (2, 'Jane Smith', 35, '9876543210', '456 Elm St', 'Female', 1, 654321),
       (3, 'Michael Johnson', 25, '5555555555', '789 Oak St', 'Male', 3, 987654),
       (4, 'Emily Davis', 28, '1111111111', '321 Pine St', 'Female', 2, 456789),
       (5, 'David Wilson', 32, '9999999999', '654 Cedar St', 'Male', 2, 789456),
       (6, 'Sarah Thompson', 27, '2222222222', '987 Birch St', 'Female', 1, 987123),
       (7, 'Robert Anderson', 29, '3333333333', '741 Maple St', 'Male', 1, 321987),
       (8, 'Jessica Martinez', 31, '4444444444', '852 Walnut St', 'Female', 2, 654987),
       (9, 'Christopher Taylor', 26, '6666666666', '963 Pineapple St', 'Male', 2, 789123),
       (10, 'Amanda Hernandez', 33, '7777777777', '159 Orange St', 'Female', 3, 456123);

-- Insert dummy data into Teachers table
INSERT INTO Teachers (TeacherID, Name, EmployeeID, SubjectID)
VALUES (1, 'John Doe', 1, 1),
       (2, 'Jane Smith', 2, 2),
       (3, 'Michael Johnson', 3, 3),
       (4, 'Emily Davis', 4, 4),
       (5, 'David Wilson', 5, 5),
       (6, 'Sarah Thompson', 6, 6),
       (7, 'Robert Anderson', 7, 7),
       (8, 'Jessica Martinez', 8, 8),
       (9, 'Christopher Taylor', 9, 9),
       (10, 'Amanda Hernandez', 10, 10);

-- Insert dummy data into TimeTables table
INSERT INTO TimeTables (TimeTableID, DayOfWeek, StartTime, EndTime, SubjectID)
VALUES (1, 'Monday', '08:00:00', '09:30:00', 1),
       (2, 'Tuesday', '09:30:00', '11:00:00', 2),
       (3, 'Wednesday', '11:00:00', '12:30:00', 3),
       (4, 'Thursday', '13:30:00', '15:00:00', 4),
       (5, 'Friday', '15:00:00', '16:30:00', 5),
       (6, 'Monday', '08:00:00', '09:30:00', 6),
       (7, 'Tuesday', '09:30:00', '11:00:00', 7),
       (8, 'Wednesday', '11:00:00', '12:30:00', 8),
       (9, 'Thursday', '13:30:00', '15:00:00', 9),
       (10, 'Friday', '15:00:00', '16:30:00', 10);

-- Insert dummy data into Classes table
INSERT INTO Classes (ClassID, ClassName, TimeTableID, SubjectID, TeacherID)
VALUES (1, 'Class A', 1, 1, 1),
       (2, 'Class B', 2, 2, 2),
       (3, 'Class C', 3, 3, 3),
       (4, 'Class D', 4, 4, 4),
       (5, 'Class E', 5, 5, 5),
       (6, 'Class F', 6, 6, 6),
       (7, 'Class G', 7, 7, 7),
       (8, 'Class H', 8, 8, 8),
       (9, 'Class I', 9, 9, 9),
       (10, 'Class J', 10, 10, 10);

-- Insert dummy data into Students table
INSERT INTO Students (Name, Age, Phone, Address, Gender, Password, ClassID)
VALUES ('John Smith', 15, '1111111111', '123 Main St', 'Male', 123456, 1),
       ('Jane Johnson', 16, '2222222222', '456 Elm St', 'Female', 654321, 2),
       ('Michael Davis', 15, '3333333333', '789 Oak St', 'Male', 987654, 3),
       ('Emily Wilson', 16, '4444444444', '321 Pine St', 'Female', 456789, 4),
       ('David Thompson', 15, '5555555555', '654 Cedar St', 'Male', 789456, 5),
       ('Sarah Anderson', 16, '6666666666', '987 Birch St', 'Female', 987123, 6),
       ('Robert Martinez', 15, '7777777777', '741 Maple St', 'Male', 321987, 7),
       ('Jessica Taylor', 16, '8888888888', '852 Walnut St', 'Female', 654987, 8),
       ('Christopher Hernandez', 15, '9999999999', '963 Pineapple St', 'Male', 789123, 9),
       ('Amanda Smith', 16, '0000000000', '159 Orange St', 'Female', 456123, 10);

-- Insert dummy data into Staff table
INSERT INTO Staff (StaffID, Name, EmployeeID)
VALUES (1, 'John Doe', 1),
       (2, 'Jane Smith', 2),
       (3, 'Michael Johnson', 3),
       (4, 'Emily Davis', 4),
       (5, 'David Wilson', 5),
       (6, 'Sarah Thompson', 6),
       (7, 'Robert Anderson', 7),
       (8, 'Jessica Martinez', 8),
       (9, 'Christopher Taylor', 9),
       (10, 'Amanda Hernandez', 10);

-- Insert dummy data into Admins table
INSERT INTO Admins (AdminID, Name, EmployeeID, Password)
VALUES (1, 'John Doe', 1, 123456),
       (2, 'Jane Smith', 2, 654321),
       (3, 'Michael Johnson', 3, 987654),
       (4, 'Emily Davis', 4, 456789),
       (5, 'David Wilson', 5, 789456),
       (6, 'Sarah Thompson', 6, 987123),
       (7, 'Robert Anderson', 7, 321987),
       (8, 'Jessica Martinez', 8, 654987),
       (9, 'Christopher Taylor', 9, 789123),
       (10, 'Amanda Hernandez', 10, 456123);

-- Insert dummy data into Exams table
INSERT INTO Exams (ExamID, Name, Date, ClassID)
VALUES (1, 'Midterm Exam', '2023-06-30', 1),
       (2, 'Midterm Exam', '2023-06-30', 2),
       (3, 'Midterm Exam', '2023-06-30', 3),
       (4, 'Midterm Exam', '2023-06-30', 4),
       (5, 'Midterm Exam', '2023-06-30', 5),
       (6, 'Midterm Exam', '2023-06-30', 6),
       (7, 'Midterm Exam', '2023-06-30', 7),
       (8, 'Midterm Exam', '2023-06-30', 8),
       (9, 'Midterm Exam', '2023-06-30', 9),
       (10, 'Midterm Exam', '2023-06-30', 10);

-- Insert dummy data into ExamResults table
INSERT INTO ExamResults (ExamID, StudentID, ClassID, SubjectID, Marks)
VALUES (1, 10001, 1, 1, 80),
       (2, 10002, 2, 2, 85),
       (3, 10003, 3, 3, 90),
       (4, 10004, 4, 4, 75),
       (5, 10005, 5, 5, 95),
       (6, 10006, 6, 6, 70),
       (7, 10007, 7, 7, 88),
       (8, 10008, 8, 8, 92),
       (9, 10009, 9, 9, 78),
       (10, 10010, 10, 10, 83);

-- Insert dummy data into Accounts table
INSERT INTO Accounts (AccountID, StudentID, Amount)
VALUES (1, 10001, 1000.00),
       (2, 10002, 1500.00),
       (3, 10003, 2000.00),
       (4, 10004, 1200.00),
       (5, 10005, 1800.00),
       (6, 10006, 900.00),
       (7, 10007, 1600.00),
       (8, 10008, 2200.00),
       (9, 10009, 1100.00),
       (10, 10010, 1700.00);

-- Insert dummy data into Std_Attendance table
INSERT INTO Std_Attendance (AttendanceID, StudentID, ClassID, Date, Status)
VALUES (1, 10001, 1, '2023-06-20', 'Present'),
       (2, 10002, 2, '2023-06-20', 'Present'),
       (3, 10003, 3, '2023-06-20', 'Present'),
       (4, 10004, 4, '2023-06-20', 'Present'),
       (5, 10005, 5, '2023-06-20', 'Present'),
       (6, 10006, 6, '2023-06-20', 'Present'),
       (7, 10007, 7, '2023-06-20', 'Present'),
       (8, 10008, 8, '2023-06-20', 'Present'),
       (9, 10009, 9, '2023-06-20', 'Present'),
       (10, 10010, 10, '2023-06-20', 'Present');

-- Insert dummy data into Emp_Attendance table
INSERT INTO Emp_Attendance (AttendanceID, EmployeeID, ClassID, Date, Status)
VALUES (1, 1, 1, '2023-06-20', 'Present'),
       (2, 2, 2, '2023-06-20', 'Present'),
       (3, 3, 3, '2023-06-20', 'Present'),
       (4, 4, 4, '2023-06-20', 'Present'),
       (5, 5, 5, '2023-06-20', 'Present'),
       (6, 6, 6, '2023-06-20', 'Present'),
       (7, 7, 7, '2023-06-20', 'Present'),
       (8, 8, 8, '2023-06-20', 'Present'),
       (9, 9, 9, '2023-06-20', 'Present'),
       (10, 10, 10, '2023-06-20','Present')