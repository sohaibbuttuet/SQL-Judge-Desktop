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
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
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
		Title VARCHAR(150) NOT NULL,
		Description TEXT NOT NULL,
		DifficultyID INT,
		CreatedBy INT NOT NULL,
		Points INT DEFAULT 10,
		CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
		IsActive BOOLEAN DEFAULT TRUE,

		FOREIGN KEY (DifficultyID) REFERENCES ProblemDifficulties(DifficultyID) ON DELETE RESTRICT,
		FOREIGN KEY (CreatedBy) REFERENCES Users(UserID),
        
		CONSTRAINT chk_problem_points CHECK (Points > 0)
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
		ProblemID INT NOT NULL,
		SetupSQL TEXT NOT NULL,
		ExpectedOutput TEXT NOT NULL,
		IsActive BOOLEAN DEFAULT TRUE,
		CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,

		FOREIGN KEY (ProblemID)	REFERENCES Problems(ProblemID) ON DELETE CASCADE
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
		Title VARCHAR(150) NOT NULL,
		Description TEXT,
		StartDate DATETIME NOT NULL,
		EndDate DATETIME NOT NULL,
		CreatedBy INT NOT NULL,
        
		FOREIGN KEY (CreatedBy) REFERENCES Users(UserID),
        
		CONSTRAINT chk_contest_dates CHECK (EndDate > StartDate)
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
	CREATE VIEW vw_StudentsForAdmin
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
	JOIN SkillLevels sk ON s.SkillLevelID = sk.SkillLevelID
	JOIN vw_UserStudents u ON s.UserID = u.UserID;

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
    CREATE VIEW vw_problems
	AS
	SELECT p.ProblemID, 
		   p.Title, 
           d.DifficultyName, 
           p.CreatedBy, 
           p.Points, 
           p.CreatedAt, 
           p.IsActive
	FROM problems p 
    JOIN problemdifficulties d ON p.DifficultyID = d.DifficultyID;
    
    -- ===================================== (5) =====================================
    CREATE OR REPLACE VIEW vw_Contests AS
	SELECT
		c.ContestID,
		c.Title,
		c.StartDate,
		c.EndDate,
		c.CreatedBy,
        COUNT(cp.StudentID) TotalParticipants,
		CASE
			WHEN NOW() < c.StartDate THEN 'Upcoming'
			WHEN NOW() BETWEEN c.StartDate AND EndDate THEN 'Active'
			ELSE 'Ended'
		END AS ContestStatus
	FROM Contests c 
    LEFT JOIN contestparticipants cp ON c.ContestID = cp.ContestID
    GROUP BY c.ContestID, c.Title, c.StartDate, c.EndDate, c.CreatedBy, ContestStatus;
    
    -- ===================================== (6) =====================================
    CREATE OR REPLACE VIEW vw_testcases
    AS
    SELECT
    t.TestCaseID,
    t.ProblemID,
    p.Title,

    CASE
        WHEN t.SetupSQL IS NULL THEN ''
        WHEN LENGTH(t.SetupSQL) > 50
        THEN CONCAT(LEFT(t.SetupSQL, 50), '...')
        ELSE t.SetupSQL
    END AS SetupSQL,

    CASE
        WHEN t.ExpectedOutput IS NULL THEN ''
        WHEN LENGTH(t.ExpectedOutput) > 50
        THEN CONCAT(LEFT(t.ExpectedOutput, 50), '...')
        ELSE t.ExpectedOutput
    END AS ExpectedOutput,

	t.CreatedAt,
    t.IsActive
	FROM testcases t
	JOIN Problems p ON t.ProblemID = p.ProblemID;


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
