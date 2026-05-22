	-- =====================================
	-- DATABASE
	-- =====================================

	CREATE DATABASE IF NOT EXISTS SQLJudgeSystem;

	USE SQLJudgeSystem;

	-- =====================================
	-- 1. ROLES
	-- =====================================

	CREATE TABLE Roles (
		RoleID INT AUTO_INCREMENT PRIMARY KEY,
		RoleName VARCHAR(50) UNIQUE NOT NULL
	);

	-- =====================================
	-- 2. USERS
	-- =====================================

CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL,
    IsActive BOOLEAN DEFAULT TRUE,
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP 
        ON UPDATE CURRENT_TIMESTAMP
);

	-- =====================================
	-- 3. USER ROLES
	-- =====================================

	CREATE TABLE UserRoles (
    UserID INT,
    RoleID INT,

    PRIMARY KEY (UserID, RoleID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID) ON DELETE CASCADE
);

	-- =====================================
	-- 4. SKILL LEVELS
	-- =====================================

	CREATE TABLE SkillLevels (
		SkillLevelID INT AUTO_INCREMENT PRIMARY KEY,
		LevelName VARCHAR(50) UNIQUE NOT NULL
	);

	-- =====================================
	-- 5. STUDENTS
	-- =====================================

	CREATE TABLE Students (
		StudentID INT AUTO_INCREMENT PRIMARY KEY,
		UserID INT UNIQUE NOT NULL,
		RegistrationNumber VARCHAR(50) UNIQUE NOT NULL,
		SkillLevelID INT,
		TotalScore INT DEFAULT 0,
		ProblemsSolved INT DEFAULT 0,
		
		FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE,
		FOREIGN KEY (SkillLevelID) REFERENCES SkillLevels(SkillLevelID) ON DELETE SET NULL,

		CONSTRAINT chk_total_score CHECK (TotalScore >= 0),
		CONSTRAINT chk_problems_solved CHECK (ProblemsSolved >= 0)
	);

	CREATE INDEX idx_students_skill ON Students(SkillLevelID);

	-- =====================================
	-- 6. PROBLEM DIFFICULTIES
	-- =====================================

	CREATE TABLE ProblemDifficulties (
		DifficultyID INT AUTO_INCREMENT PRIMARY KEY,
		DifficultyName VARCHAR(50) UNIQUE NOT NULL
	);

	-- =====================================
	-- 7. PROBLEM TAGS
	-- =====================================

	CREATE TABLE ProblemTags (
		TagID INT AUTO_INCREMENT PRIMARY KEY,
		TagName VARCHAR(50) UNIQUE NOT NULL
	);

	-- =====================================
	-- 8. PROBLEMS
	-- =====================================

	CREATE TABLE Problems (
    ProblemID INT AUTO_INCREMENT PRIMARY KEY,

    Title VARCHAR(150) UNIQUE NOT NULL,
    Description TEXT NOT NULL,

    DifficultyID INT NOT NULL,

    Points INT DEFAULT 10,

    CreatedBy INT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,

    UpdatedBy INT NOT NULL,
    UpdatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
			  ON UPDATE CURRENT_TIMESTAMP,

    IsActive BOOLEAN DEFAULT TRUE,

    FOREIGN KEY (DifficultyID)
        REFERENCES ProblemDifficulties(DifficultyID)
        ON DELETE RESTRICT,

    FOREIGN KEY (CreatedBy)
        REFERENCES Users(UserID),

    FOREIGN KEY (UpdatedBy)
        REFERENCES Users(UserID),

    CONSTRAINT chk_problem_points
        CHECK (Points > 0)
);
	CREATE INDEX idx_problems_difficulty ON Problems(DifficultyID);
	CREATE INDEX idx_problems_created ON Problems(CreatedAt);

	-- =====================================
	-- 9. PROBLEM TAG MAP
	-- =====================================

	CREATE TABLE ProblemTagMap (
		ProblemID INT,
		TagID INT,

		PRIMARY KEY (ProblemID, TagID),
		FOREIGN KEY (ProblemID) REFERENCES Problems(ProblemID) ON DELETE CASCADE,
		FOREIGN KEY (TagID)	REFERENCES ProblemTags(TagID) ON DELETE CASCADE
	);

	CREATE INDEX idx_ptm_tag ON ProblemTagMap(TagID);

	-- =====================================
	-- 10. TEST CASES
	-- =====================================

	CREATE TABLE TestCases (
    TestCaseID INT AUTO_INCREMENT PRIMARY KEY,
    TestCaseName VARCHAR(100),
    ProblemID INT NOT NULL,    

    SetupSQL TEXT NOT NULL,
    SolutionQuery TEXT NOT NULL,

    CreatedBy INT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,

    UpdatedBy INT NOT NULL,
    UpdatedAt DATETIME DEFAULT CURRENT_TIMESTAMP 
			  ON UPDATE CURRENT_TIMESTAMP,
    
     IsActive BOOLEAN DEFAULT TRUE,

    FOREIGN KEY (ProblemID)
        REFERENCES Problems(ProblemID)
        ON DELETE CASCADE,

    FOREIGN KEY (CreatedBy)
        REFERENCES Users(UserID),

    FOREIGN KEY (UpdatedBy)
        REFERENCES Users(UserID)
);
	CREATE INDEX idx_testcases_problem ON TestCases(ProblemID);

	-- =====================================
	-- 11. SUBMISSION STATUSES
	-- =====================================

	CREATE TABLE SubmissionStatuses (
		StatusID INT AUTO_INCREMENT PRIMARY KEY,
		StatusName VARCHAR(50) UNIQUE NOT NULL
	);

	-- =====================================
	-- 12. SUBMISSIONS
	-- =====================================

	CREATE TABLE Submissions (
		SubmissionID INT AUTO_INCREMENT PRIMARY KEY,
		StudentID INT NOT NULL,
		ProblemID INT NOT NULL,
		QueryText MEDIUMTEXT NOT NULL,
		StatusID INT NOT NULL,
		AttemptNumber INT DEFAULT 1,
		TotalScore INT DEFAULT 0,
		SubmittedAt DATETIME DEFAULT CURRENT_TIMESTAMP,

		FOREIGN KEY (StudentID) REFERENCES Students(StudentID) ON DELETE CASCADE,
		FOREIGN KEY (ProblemID) REFERENCES Problems(ProblemID) ON DELETE CASCADE,
		FOREIGN KEY (StatusID) REFERENCES SubmissionStatuses(StatusID),

		CONSTRAINT chk_attempt_number CHECK (AttemptNumber > 0),
		CONSTRAINT chk_submission_score	CHECK (TotalScore >= 0)
	);

	CREATE INDEX idx_submissions_student ON Submissions(StudentID);
	CREATE INDEX idx_submissions_problem ON Submissions(ProblemID);
	CREATE INDEX idx_submissions_status ON Submissions(StatusID);
	CREATE INDEX idx_submissions_time ON Submissions(SubmittedAt);

	-- =====================================
	-- 13. SUBMISSION RESULTS
	-- =====================================

	CREATE TABLE SubmissionResults (
		ResultID INT AUTO_INCREMENT PRIMARY KEY,
		SubmissionID INT NOT NULL,
		TestCaseID INT NOT NULL,
		ActualOutput TEXT,
		IsPassed BOOLEAN DEFAULT FALSE,
		ErrorMessage TEXT,
        
		UNIQUE (SubmissionID, TestCaseID),
		FOREIGN KEY (SubmissionID) REFERENCES Submissions(SubmissionID) ON DELETE CASCADE,
		FOREIGN KEY (TestCaseID) REFERENCES TestCases(TestCaseID) ON DELETE CASCADE
	);

	CREATE INDEX idx_results_testcase ON SubmissionResults(TestCaseID);

	-- =====================================
	-- 15. CONTESTS
	-- =====================================

	CREATE TABLE Contests (
    ContestID INT AUTO_INCREMENT PRIMARY KEY,

    Title VARCHAR(150) UNIQUE NOT NULL,
    Description TEXT,

    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,

    CreatedBy INT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,

    UpdatedBy INT NOT NULL,
    UpdatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
			  ON UPDATE CURRENT_TIMESTAMP,

    FOREIGN KEY (CreatedBy)
        REFERENCES Users(UserID),

    FOREIGN KEY (UpdatedBy)
        REFERENCES Users(UserID),

    CONSTRAINT chk_contest_dates
        CHECK (EndDate > StartDate)
);
	CREATE INDEX idx_contests_time ON Contests(StartDate, EndDate);

	-- =====================================
	-- 16. CONTEST PARTICIPANTS
	-- =====================================

	CREATE TABLE ContestParticipants (
		ContestID INT,
		StudentID INT,
		JoinedAt DATETIME DEFAULT CURRENT_TIMESTAMP,

		PRIMARY KEY (ContestID, StudentID),
		FOREIGN KEY (ContestID)	REFERENCES Contests(ContestID) ON DELETE CASCADE,
		FOREIGN KEY (StudentID)	REFERENCES Students(StudentID) ON DELETE CASCADE
	);
    
	CREATE INDEX idx_cp_student ON ContestParticipants(StudentID);

	-- =====================================
	-- 17. CONTEST PROBLEMS
	-- =====================================

	CREATE TABLE ContestProblems (
		ContestID INT,
		ProblemID INT,
		OrderNumber INT NOT NULL,
        
		PRIMARY KEY (ContestID, ProblemID),
		UNIQUE (ContestID, OrderNumber),
		FOREIGN KEY (ContestID)	REFERENCES Contests(ContestID) ON DELETE CASCADE,
		FOREIGN KEY (ProblemID)	REFERENCES Problems(ProblemID) ON DELETE CASCADE,

		CONSTRAINT chk_order_number	CHECK (OrderNumber > 0)
	);

	CREATE INDEX idx_cp_problem	ON ContestProblems(ProblemID);

	-- =====================================
	-- VIEWS
	-- =====================================

	-- ===================================== (1) =====================================
	CREATE OR REPLACE VIEW vw_users
	AS
	SELECT
		u.UserID,
		u.FullName,
		u.Email,
        r.RoleName,
		u.IsActive,
		u.CreatedAt
	FROM Users u
	JOIN UserRoles ur ON u.UserID = ur.UserID
	JOIN Roles r ON ur.RoleID = r.RoleID;

	-- ===================================== (2) =====================================
	CREATE OR REPLACE VIEW vw_StudentsForAdmin
	AS
	SELECT
		s.StudentID,
		s.UserID,
		u.FullName,
		s.RegistrationNumber,
		sk.LevelName,
		s.ProblemsSolved,
		s.TotalScore,
		u.IsActive,
		u.CreatedAt
	FROM Students s
	LEFT JOIN SkillLevels sk ON s.SkillLevelID = sk.SkillLevelID
	JOIN vw_Users u ON s.UserID = u.UserID;

	-- ===================================== (3) =====================================
	CREATE VIEW vw_StudentsLeaderboard	
	AS
	SELECT
		RANK() OVER (ORDER BY s.TotalScore DESC) AS GlobalRank,
		s.StudentID,
		u.FullName,
		s.RegistrationNumber,
		sk.LevelName,
		s.ProblemsSolved,
		s.TotalScore
	FROM Students s
	JOIN Users u ON s.UserID = u.UserID
	JOIN SkillLevels sk ON s.SkillLevelID = sk.SkillLevelID;
    
    -- ===================================== (4) =====================================
    CREATE OR REPLACE VIEW vw_problems
	AS
	SELECT p.ProblemID, 
		   p.Title, 
           d.DifficultyName, 
            p.Points,            
           p.IsActive,
           u1.FullName AS CreatedBy, 
           p.CreatedAt, 
           u2.FullName AS UpdatedBy,
		   p.UpdatedAt
	FROM problems p 
    LEFT JOIN problemdifficulties d ON p.DifficultyID = d.DifficultyID
    LEFT JOIN Users u1 ON p.CreatedBy = u1.UserID
    LEFT JOIN Users u2 ON p.UpdatedBy = u2.UserID;
    
    -- ===================================== (5) =====================================
    
 CREATE OR REPLACE VIEW vw_contests
	AS
	SELECT c.ContestID, 
		   c.Title,           
           c.StartDate,
		   c.EndDate,
           COUNT(cp.StudentID) AS TotalParticipants,
           u1.FullName AS CreatedBy, 
           DATE(c.CreatedAt) AS CreatedAt, 
           u2.FullName AS UpdatedBy,
		   DATE(c.UpdatedAt) AS UpdatedAt
	FROM contests c 
    LEFT JOIN contestparticipants cp ON c.ContestID = cp.ContestID
    LEFT JOIN Users u1 ON c.CreatedBy = u1.UserID
    LEFT JOIN Users u2 ON c.UpdatedBy = u2.UserID
    GROUP BY c.ContestID, c.Title;
    
    
       -- ===================================== (6) =====================================
   CREATE OR REPLACE VIEW vw_testcases AS
   SELECT
		t.TestCaseID,
		t.ProblemID,
		p.Title,
		
		CASE
			WHEN t.SetupSQL IS NULL THEN ''
			WHEN LENGTH(t.SetupSQL) > 30
				THEN CONCAT(LEFT(t.SetupSQL, 30), '...')
			ELSE t.SetupSQL
		END AS SetupSQLPreview,

		CASE
			WHEN t.SolutionQuery IS NULL THEN ''
			WHEN LENGTH(t.SolutionQuery) > 30
				THEN CONCAT(LEFT(t.SolutionQuery, 30), '...')
			ELSE t.SolutionQuery
		END AS SolutionQueryPreview,

		u1.FullName AS CreatedBy,
		t.CreatedAt,
        u2.FullName UpdatedBy,
        t.UpdatedAt,
		t.IsActive
	FROM testcases t
	LEFT JOIN Problems p ON t.ProblemID = p.ProblemID
    LEFT JOIN Users u1 ON p.CreatedBy = u1.UserID
    LEFT JOIN Users u2 ON p.UpdatedBy = u2.UserID;

  -- ===================================== (7) =====================================
	CREATE OR REPLACE VIEW vw_Submissions
	AS
	SELECT s.SubmissionID,
		   s.StudentID,
		   s.ProblemID,
		   ss.StatusName,
		   s.AttemptNumber,
           s.TotalScore,
          s.SubmittedAt
    FROM submissions s
    JOIN submissionstatuses ss ON s.StatusID = ss.StatusID;

	-- =====================================
	-- LOOKUP DATA
	-- =====================================

	INSERT INTO Roles (RoleName)
	VALUES
	('Student'),
	('Admin'),
	('SuperAdmin');

	INSERT INTO SkillLevels (LevelName)
	VALUES
	('Beginner'),
	('Intermediate'),
	('Advanced');

	INSERT INTO ProblemDifficulties (DifficultyName)
	VALUES
	('Easy'),
	('Medium'),
	('Hard');

	INSERT INTO SubmissionStatuses (StatusName)
	VALUES
	('Accepted'),
	('Wrong Answer'),
	('Runtime Error'),
	('Compilation Error'),
	('Pending');

	INSERT INTO ProblemTags (TagName)
	VALUES
	('Joins (Inner Join)'),
	('Joins (Left Join)'),
	('Joins (Right Join)'),
	('Self Join'),
	('Cross Join'),
	('Subqueries'),
	('Correlated Subqueries'),
	('Aggregate Functions'),
	('Group By'),
	('Having Clause'),
	('Order By'),
	('Limit'),
	('Union'),
	('Union All'),
	('Triggers');

-- =====================================
-- FIRST SUPER ADMIN
-- =====================================

	INSERT INTO Users (
		FullName,
		Email,
		Password
	)
	VALUES (
		'Super Admin',
		'admin@sqljudge.com',
		'admin123'
	);

	INSERT INTO UserRoles (
		UserID,
		RoleID
	)
	VALUES (
		1,
		3
	);
    
    
    -- RAW DATA -- 
    -- =====================================
-- SAMPLE USERS
-- =====================================

INSERT INTO Users (FullName, Email, Password)
VALUES 
('Admin One', 'admin1@sqljudge.com', 'admin123'),
('Admin Two', 'admin2@sqljudge.com', 'admin123'),
('Ali Khan', 'ali@student.com', '12345'),
('Sara Ahmed', 'sara@student.com', '12345'),
('Usman Tariq', 'usman@student.com', '12345'),
('Ayesha Malik', 'ayesha@student.com', '12345'),
('Hassan Raza', 'hassan@student.com', '12345');
-- =====================================
-- USER ROLES
-- =====================================

-- Admins
INSERT INTO UserRoles VALUES (2,2), (3,2);

-- Students
INSERT INTO UserRoles VALUES 
(4,1),(5,1),(6,1),(7,1),(8,1);

-- =====================================
-- STUDENTS
-- =====================================

INSERT INTO Students (UserID, RegistrationNumber, SkillLevelID, TotalScore, ProblemsSolved)
VALUES
(4,'REG-001',1,50,2),
(5,'REG-002',2,120,5),
(6,'REG-003',3,200,8),
(7,'REG-004',1,30,1),
(8,'REG-005',2,90,4);

-- =====================================
-- PROBLEMS
-- =====================================

INSERT INTO Problems 
(Title, Description, DifficultyID, Points, CreatedBy, UpdatedBy)
VALUES
('SELECT Basics',
 'Fetch all records from a table',
 1,10,1,1),

('WHERE Filtering',
 'Filter students with marks > 50',
 1,10,1,1),

('INNER JOIN Practice',
 'Join students and courses',
 2,20,1,1),

('LEFT JOIN Analysis',
 'Return all students even without courses',
 2,20,1,1),

('GROUP BY Aggregation',
 'Count students per department',
 2,25,1,1),

('Complex Subquery',
 'Find second highest salary',
 3,40,1,1);

-- =====================================
-- PROBLEM TAG MAP
-- =====================================

INSERT INTO ProblemTagMap VALUES
(1,1),(1,11),
(2,10),
(3,1),(3,6),
(4,2),
(5,9),
(6,6);
-- =====================================
-- TEST CASES
-- =====================================

INSERT INTO TestCases 
(ProblemID, TestCaseName, SetupSQL, SolutionQuery, CreatedBy, UpdatedBy)
VALUES

(1,'TC1',
 'CREATE TABLE T(Name VARCHAR(50)); INSERT INTO T VALUES ("Ali"),("Sara");',
 'SELECT * FROM T;',
 1,1),

(2,'TC2',
 'CREATE TABLE S(Name VARCHAR(50), Marks INT); INSERT INTO S VALUES ("Ali",60),("Sara",40);',
 'SELECT * FROM S WHERE Marks > 50;',
 1,1),

(3,'TC3',
 'CREATE TABLE Stu(ID INT,Name VARCHAR(50)); CREATE TABLE Course(ID INT,StuID INT);',
 'SELECT * FROM Stu INNER JOIN Course ON Stu.ID = Course.StuID;',
 1,1),

(4,'TC4',
 'CREATE TABLE Stu(ID INT,Name VARCHAR(50)); CREATE TABLE Course(StuID INT,CourseName VARCHAR(50));',
 'SELECT * FROM Stu LEFT JOIN Course ON Stu.ID = Course.StuID;',
 1,1),

(5,'TC5',
 'CREATE TABLE Dept(ID INT); CREATE TABLE Emp(DeptID INT);',
 'SELECT DeptID, COUNT(*) FROM Emp GROUP BY DeptID;',
 1,1),

(6,'TC6',
 'CREATE TABLE Emp(Salary INT);',
 'SELECT MAX(Salary) FROM Emp;',
 1,1);
-- =====================================
-- CONTESTS
-- =====================================

INSERT INTO Contests 
(Title, Description, StartDate, EndDate, CreatedBy, UpdatedBy)
VALUES
('SQL Beginner Contest','Basics of SQL','2026-06-01 10:00:00','2026-06-01 18:00:00',1,1),
('SQL Advanced Contest','Subqueries & Joins','2026-06-10 10:00:00','2026-06-10 18:00:00',1,1);
-- =====================================
-- CONTEST PARTICIPANTS
-- =====================================

INSERT INTO ContestParticipants (ContestID, StudentID)
VALUES
(1,1),
(1,2),
(1,3),
(1,4),
(1,5);

-- =====================================
-- CONTEST PROBLEMS
-- =====================================

INSERT INTO ContestProblems VALUES
(1,1,1),
(1,2,2),
(1,3,3),
(2,4,1),
(2,5,2),
(2,6,3);
-- =====================================
-- SUBMISSIONS
-- =====================================

INSERT INTO Submissions 
(StudentID, ProblemID, QueryText, StatusID, AttemptNumber, TotalScore)
VALUES

(1,1,'SELECT * FROM T;',1,1,10),
(2,2,'SELECT * FROM S WHERE Marks > 50;',1,1,10),
(3,3,'SELECT * FROM Stu INNER JOIN Course ON Stu.ID=Course.StuID;',2,1,0),
(4,4,'SELECT * FROM Stu LEFT JOIN Course ON Stu.ID=Course.StuID;',1,1,20),
(5,5,'SELECT DeptID, COUNT(*) FROM Emp GROUP BY DeptID;',3,1,0);
-- =====================================
-- SUBMISSION RESULTS
-- =====================================

INSERT INTO SubmissionResults
(SubmissionID, TestCaseID, ActualOutput, IsPassed, ErrorMessage)
VALUES

(1,1,'Ali,Sara',TRUE,NULL),
(2,2,'Ali',TRUE,NULL),
(3,3,NULL,FALSE,'JOIN condition mismatch'),
(4,4,'All Students Returned',TRUE,NULL),
(5,5,NULL,FALSE,'GROUP BY missing column');