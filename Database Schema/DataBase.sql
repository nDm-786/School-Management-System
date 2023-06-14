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
	Phone varchar(10),
	Adress varchar(20),
    Gender VARCHAR(10),    
    RoleID INT,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

-- Table for teachers
CREATE TABLE Teachers (
    TeacherID INT PRIMARY KEY,
    Name VARCHAR(50),
	EmployeeID INT,    
    SubjectID int,     
	FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
-- Table for time table
CREATE TABLE TimeTables (
    TimeTableID INT PRIMARY KEY,
    DayOfWeek VARCHAR(20),
    StartTime TIME,
    EndTime TIME,
    SubjectID int,     
	FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
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
	Phone varchar(10),
	Adress varchar(20),
    Gender VARCHAR(10),
    ClassID INT,
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);

-- Table for staff
CREATE TABLE Staff (
    StaffID INT PRIMARY KEY,
    Name VARCHAR(50),
	EmployeeID INT,    
	FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)

);

-- Table for admins
CREATE TABLE Admins (
    AdminID INT PRIMARY KEY,
    Name VARCHAR(50),
	EmployeeID INT,   
	FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)

);



-- Table for exams
CREATE TABLE Exams (
    ExamID INT PRIMARY KEY,
    Name VARCHAR(50),
    Date DATE,
    ClassID INT,
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);

-- Table for examResults
create table ExamResults(
    ExamID int primary key,
    StudentID int,
    ClassID int,
    SubjectID int,
    Marks int
    foreign key (StudentID) references Students(StudentID),
    foreign key (ClassID) references Classes(ClassID),
    foreign key (SubjectID) references Subjects(SubjectID)
);



-- Table for accounts
CREATE TABLE Accounts (
    AccountID INT PRIMARY KEY,
    StudentID INT,
    Amount DECIMAL(10, 2),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);


-- Table for student attendance
CREATE TABLE Std_Attendance (
    AttendanceID INT PRIMARY KEY,
    StudentID INT,
    ClassID INT,
    Date DATE,
    Status VARCHAR(10),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);

-- Table for Emp attendance
CREATE TABLE Emp_Attendance (
    AttendanceID INT PRIMARY KEY,
    EmployeeID INT,
    ClassID INT,
    Date DATE,
    Status VARCHAR(10),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);


