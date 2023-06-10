Create database SMS

-- Table for subjects
CREATE TABLE Subjects (
    SubjectID INT PRIMARY KEY,
    Name VARCHAR(50)
);

 --Table for roles
CREATE TABLE Roles (
    RoleID INT PRIMARY KEY,
    Name VARCHAR(50)
);

-- Table for employees
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(50),
    Age INT,
    Gender VARCHAR(10),
    Position VARCHAR(50),
    RoleID INT,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

-- Table for teachers
CREATE TABLE Teachers (
    TeacherID INT PRIMARY KEY,
    Name VARCHAR(50),
	EmployeeID INT,
    Age INT,
    Gender VARCHAR(10),
    Subject VARCHAR(50),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
-- Table for time table
CREATE TABLE TimeTables (
    TimeTableID INT PRIMARY KEY,
    DayOfWeek VARCHAR(20),
    StartTime TIME,
    EndTime TIME,
    Subject VARCHAR(50),
    
);
-- Table for classes
CREATE TABLE Classes (
    ClassID INT PRIMARY KEY,
    ClassName VARCHAR(50),
	TimeTableID int,
	SubjectID int,
    TeacherID INT,
    FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID),
    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
    FOREIGN KEY (TimeTableID) REFERENCES TimeTables(TimeTableID),
);

-- Table for students
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50),
    Age INT,
    Gender VARCHAR(10),
    ClassID INT,
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);

-- Table for staff
CREATE TABLE Staff (
    StaffID INT PRIMARY KEY,
    Name VARCHAR(50),
	EmployeeID INT,
    Age INT,
    Gender VARCHAR(10),
    Position VARCHAR(50),
	FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)

);

-- Table for admins
CREATE TABLE Admins (
    AdminID INT PRIMARY KEY,
    Name VARCHAR(50),
	EmployeeID INT,
    Age INT,
    Gender VARCHAR(10),
    Role VARCHAR(50),
	FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)

);



-- Table for exams
CREATE TABLE Exams (
    ExamID INT PRIMARY KEY,
    Name VARCHAR(50),
    Date DATE,
    ClassID INT,
    Subject VARCHAR(50),
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);



-- Table for accounts
CREATE TABLE Accounts (
    AccountID INT PRIMARY KEY,
    StudentID INT,
    Amount DECIMAL(10, 2),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);


-- Table for attendance
CREATE TABLE Std_Attendance (
    AttendanceID INT PRIMARY KEY,
    StudentID INT,
    ClassID INT,
    Date DATE,
    Status VARCHAR(10),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);

-- Table for attendance
CREATE TABLE Emp_Attendance (
    AttendanceID INT PRIMARY KEY,
    EmployeeID INT,
    ClassID INT,
    Date DATE,
    Status VARCHAR(10),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
