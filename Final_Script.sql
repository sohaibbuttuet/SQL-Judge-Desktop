-- =====================================
-- DATABASE INITIALIZATION
-- =====================================
CREATE DATABASE IF NOT EXISTS SQLJudgeSystem;
USE SQLJudgeSystem;

-- =====================================
-- 1. ROLES & USERS
-- =====================================
CREATE TABLE Roles (
    RoleID INT AUTO_INCREMENT PRIMARY KEY,
    RoleName VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL,
    IsActive BOOLEAN DEFAULT TRUE,
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

CREATE TABLE UserRoles (
    UserID INT,
    RoleID INT,
    PRIMARY KEY (UserID, RoleID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID) ON DELETE CASCADE
);

-- =====================================
-- 2. STUDENTS & SKILLS
-- =====================================
CREATE TABLE SkillLevels (
    SkillLevelID INT AUTO_INCREMENT PRIMARY KEY,
    LevelName VARCHAR(50) UNIQUE NOT NULL
);

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
-- 3. PROBLEMS & SCHEMA CONFIGURATION
-- =====================================
CREATE TABLE ProblemDifficulties (
    DifficultyID INT AUTO_INCREMENT PRIMARY KEY,
    DifficultyName VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE ProblemTags (
    TagID INT AUTO_INCREMENT PRIMARY KEY,
    TagName VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE Problems (
    ProblemID INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(150) UNIQUE NOT NULL,
    Description TEXT NOT NULL,
    DifficultyID INT NOT NULL,
    Points INT DEFAULT 10,
    TargetDatabase VARCHAR(100) NOT NULL, -- (e.g. 'Northwind')
    MasterQuery TEXT NOT NULL,            -- solution query
    CreatedBy INT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdatedBy INT NOT NULL,
    UpdatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    IsActive BOOLEAN DEFAULT TRUE,

    FOREIGN KEY (DifficultyID) REFERENCES ProblemDifficulties(DifficultyID) ON DELETE RESTRICT,
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID),
    FOREIGN KEY (UpdatedBy) REFERENCES Users(UserID),
    CONSTRAINT chk_problem_points CHECK (Points > 0)
);
CREATE INDEX idx_problems_difficulty ON Problems(DifficultyID);
CREATE INDEX idx_problems_created ON Problems(CreatedAt);

-- Bridges problem requirements directly to TreeView definitions
CREATE TABLE ProblemTables (
    ProblemTableID INT AUTO_INCREMENT PRIMARY KEY,
    ProblemID INT NOT NULL,
    TableName VARCHAR(100) NOT NULL,
    FOREIGN KEY (ProblemID) REFERENCES Problems(ProblemID) ON DELETE CASCADE
);

CREATE TABLE ProblemColumns (
    ProblemColumnID INT AUTO_INCREMENT PRIMARY KEY,
    ProblemTableID INT NOT NULL,
    ColumnName VARCHAR(100) NOT NULL,
    FOREIGN KEY (ProblemTableID) REFERENCES ProblemTables(ProblemTableID) ON DELETE CASCADE
);

CREATE TABLE ProblemTagMap (
    ProblemID INT,
    TagID INT,
    PRIMARY KEY (ProblemID, TagID),
    FOREIGN KEY (ProblemID) REFERENCES Problems(ProblemID) ON DELETE CASCADE,
    FOREIGN KEY (TagID) REFERENCES ProblemTags(TagID) ON DELETE CASCADE
);
CREATE INDEX idx_ptm_tag ON ProblemTagMap(TagID);

-- =====================================
-- 4. EVALUATIONS & SUBMISSIONS
-- =====================================
CREATE TABLE SubmissionStatuses (
    StatusID INT AUTO_INCREMENT PRIMARY KEY,
    StatusName VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE Submissions (
    SubmissionID INT AUTO_INCREMENT PRIMARY KEY,
    StudentID INT NOT NULL,
    ProblemID INT NOT NULL,
    QueryText MEDIUMTEXT NOT NULL,
    StatusID INT NOT NULL DEFAULT 4, -- Defaults to Pending
    AttemptNumber INT DEFAULT 1,
    TotalScore INT DEFAULT 0,
    SubmittedAt DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (StudentID) REFERENCES Students(StudentID) ON DELETE CASCADE,
    FOREIGN KEY (ProblemID) REFERENCES Problems(ProblemID) ON DELETE CASCADE,
    FOREIGN KEY (StatusID) REFERENCES SubmissionStatuses(StatusID),
    CONSTRAINT chk_attempt_number CHECK (AttemptNumber > 0),
    CONSTRAINT chk_submission_score CHECK (TotalScore >= 0)
);
CREATE INDEX idx_submissions_student ON Submissions(StudentID);
CREATE INDEX idx_submissions_problem ON Submissions(ProblemID);
CREATE INDEX idx_submissions_status ON Submissions(StatusID);
CREATE INDEX idx_submissions_time ON Submissions(SubmittedAt);

CREATE TABLE SubmissionResults (
    ResultID INT AUTO_INCREMENT PRIMARY KEY,
    SubmissionID INT UNIQUE NOT NULL, -- Changed to UNIQUE to avoid duplicate result tracking per run
    ActualOutput LONGTEXT,
    IsPassed BOOLEAN DEFAULT FALSE,
    ErrorMessage TEXT,
    FOREIGN KEY (SubmissionID) REFERENCES Submissions(SubmissionID) ON DELETE CASCADE
);

-- =====================================
-- 5. CONTESTS SYSTEM
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
    UpdatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID),
    FOREIGN KEY (UpdatedBy) REFERENCES Users(UserID),
    CONSTRAINT chk_contest_dates CHECK (EndDate > StartDate)
);
CREATE INDEX idx_contests_time ON Contests(StartDate, EndDate);

CREATE TABLE ContestParticipants (
    ContestID INT,
    StudentID INT,
    JoinedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (ContestID, StudentID),
    FOREIGN KEY (ContestID) REFERENCES Contests(ContestID) ON DELETE CASCADE,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID) ON DELETE CASCADE
);
CREATE INDEX idx_cp_student ON ContestParticipants(StudentID);

CREATE TABLE ContestProblems (
    ContestID INT,
    ProblemID INT,
    PRIMARY KEY (ContestID, ProblemID),
    FOREIGN KEY (ContestID) REFERENCES Contests(ContestID) ON DELETE CASCADE,
    FOREIGN KEY (ProblemID) REFERENCES Problems(ProblemID) ON DELETE CASCADE
);
CREATE INDEX idx_cp_problem ON ContestProblems(ProblemID);

-- =====================================
-- VIEWS
-- =====================================	
----------------------------------------- -- 1 -- -----------------------------
CREATE OR REPLACE VIEW vw_users AS
SELECT
    u.UserID, u.FullName, u.Email, r.RoleName, u.IsActive, DATE(u.CreatedAt) AS CreatedAt
FROM Users u
LEFT JOIN UserRoles ur ON u.UserID = ur.UserID
LEFT JOIN Roles r ON ur.RoleID = r.RoleID;

----------------------------------------- -- 2 -- -----------------------------
CREATE OR REPLACE VIEW vw_students AS
SELECT
    s.StudentID, s.UserID, u.FullName, s.RegistrationNumber, sk.LevelName,
    s.ProblemsSolved, s.TotalScore, u.IsActive, DATE(u.CreatedAt) AS CreatedAt
FROM Students s
LEFT JOIN SkillLevels sk ON s.SkillLevelID = sk.SkillLevelID
JOIN Users u ON s.UserID = u.UserID;

----------------------------------------- -- 3 -- -----------------------------
CREATE OR REPLACE VIEW vw_students_leaderboard AS
SELECT
    RANK() OVER (ORDER BY s.TotalScore DESC) AS GlobalRank,
    s.StudentID, u.FullName, s.RegistrationNumber, sk.LevelName, s.ProblemsSolved, s.TotalScore
FROM Students s
JOIN Users u ON s.UserID = u.UserID
LEFT JOIN SkillLevels sk ON s.SkillLevelID = sk.SkillLevelID;
    
----------------------------------------- -- 4 -- -----------------------------
CREATE OR REPLACE VIEW vw_problems AS
SELECT 
    p.ProblemID, p.Title, d.DifficultyName, p.Points, p.TargetDatabase, p.IsActive,
    u1.FullName AS CreatedBy, DATE(p.CreatedAt) AS CreatedAt, 
    u2.FullName AS UpdatedBy, DATE(p.UpdatedAt) AS UpdatedAt
FROM Problems p 
LEFT JOIN ProblemDifficulties d ON p.DifficultyID = d.DifficultyID
LEFT JOIN Users u1 ON p.CreatedBy = u1.UserID
LEFT JOIN Users u2 ON p.UpdatedBy = u2.UserID;
    
----------------------------------------- -- 5 -- -----------------------------
CREATE OR REPLACE VIEW vw_contests AS
SELECT 
    c.ContestID, c.Title, DATE(c.StartDate) AS StartDate, DATE(c.EndDate) AS EndDate,
    COALESCE(COUNT(cp.StudentID), 0) AS TotalParticipants,
    u1.FullName AS CreatedBy, DATE(c.CreatedAt) AS CreatedAt, 
    u2.FullName AS UpdatedBy, DATE(c.UpdatedAt) AS UpdatedAt,
    CASE 
        WHEN NOW() < c.StartDate THEN 'Upcoming'
        WHEN NOW() > c.EndDate THEN 'Ended'
        ELSE 'Running'
    END AS ContestStatus
FROM Contests c
LEFT JOIN ContestParticipants cp ON c.ContestID = cp.ContestID
LEFT JOIN Users u1 ON c.CreatedBy = u1.UserID
LEFT JOIN Users u2 ON c.UpdatedBy = u2.UserID
GROUP BY c.ContestID, c.Title, c.StartDate, c.EndDate, u1.FullName, u2.FullName, c.CreatedAt, c.UpdatedAt;
    
----------------------------------------- -- 6 -- -----------------------------
CREATE OR REPLACE VIEW vw_submissions AS
SELECT 
    s.SubmissionID, s.StudentID, u.FullName AS StudentName, s.ProblemID, p.Title AS ProblemTitle,
    s.TotalScore, s.AttemptNumber, DATE(s.SubmittedAt) AS SubmittedAt, ss.StatusName AS Status
FROM Submissions s
LEFT JOIN SubmissionStatuses ss ON s.StatusID = ss.StatusID
LEFT JOIN Students st ON s.StudentID = st.StudentID
LEFT JOIN Users u ON st.UserID = u.UserID
LEFT JOIN Problems p ON s.ProblemID = p.ProblemID;

-- =====================================
-- LOOKUP DATA
-- =====================================

INSERT INTO Roles (RoleName) VALUES ('Student'), ('Admin'), ('SuperAdmin');
INSERT INTO SkillLevels (LevelName) VALUES ('Beginner'), ('Intermediate'), ('Advanced');
INSERT INTO ProblemDifficulties (DifficultyName) VALUES ('Easy'), ('Medium'), ('Hard');
INSERT INTO SubmissionStatuses (StatusName) VALUES ('Accepted'), ('Wrong Answer'), ('Runtime Error'), ('Pending');

INSERT INTO ProblemTags (TagName) VALUES 
('Joins (Inner Join)'), ('Joins (Left Join)'), ('Joins (Right Join)'), ('Self Join'), ('Cross Join'),
('Subqueries'), ('Correlated Subqueries'), ('Aggregate Functions'), ('Group By'), ('Having Clause'),
('Order By'), ('Limit'), ('Union'), ('Union All'), ('Triggers');

-- =====================================
-- FIRST SUPER ADMIN
-- =====================================    
    
INSERT INTO Users (UserID, FullName, Email, Password, IsActive)
VALUES
(1, 'Super Admin', 'admin@sqljudge.com', 'admin123', 1),
(2, 'Ali Khan', 'ali@student.com', '123456', 1),
(3, 'Sara Ahmed', 'sara@student.com', '123456', 1),
(4, 'Hamza Developer', 'hamza@admin.com', 'admin456', 1);

INSERT INTO UserRoles (UserID, RoleID)
VALUES
(1, 3),  -- SuperAdmin
(2, 1),  -- Student
(3, 1),  -- Student
(4, 2);  -- Admin

INSERT INTO Students (StudentID, UserID, RegistrationNumber, SkillLevelID, TotalScore, ProblemsSolved)
VALUES
(1, 2, 'REG-2026-001', 1, 50, 1),
(2, 3, 'REG-2026-002', 2, 120, 2);

-- Sample problem showcasing how the system targets databases and tracks master queries natively
INSERT INTO Problems (ProblemID, Title, Description, DifficultyID, Points, TargetDatabase, MasterQuery, CreatedBy, UpdatedBy, IsActive)
VALUES (1, 'Select All Customers', 'Fetch all data records out of your client tracking dataset.', 1, 10, 'Northwind', 'SELECT * FROM Customers;', 1, 1, 1);

INSERT INTO ProblemTables (ProblemTableID, ProblemID, TableName) VALUES (1, 1, 'Customers');
INSERT INTO ProblemColumns (ProblemTableID, ColumnName) VALUES (1, 'CustomerID'), (1, 'CompanyName'), (1, 'ContactName');
INSERT INTO ProblemTagMap (ProblemID, TagID) VALUES (1, 11);

 INSERT INTO Submissions
(SubmissionID, StudentID, ProblemID, QueryText, StatusID, AttemptNumber, TotalScore)
VALUES
(1, 1, 1, 'SELECT * FROM Students;', 1, 1, 10);


INSERT INTO SubmissionResults
(ResultID, SubmissionID, ActualOutput, IsPassed, ErrorMessage)
VALUES
(1, 1, 'OK', 1, NULL);

INSERT INTO Contests
(ContestID, Title, Description, StartDate, EndDate, CreatedBy, UpdatedBy)
VALUES
(1, 'SQL Basics Contest', 'Beginner level SQL contest',
 '2026-06-01 10:00:00', '2026-06-02 10:00:00',
 1, 1);
 
 INSERT INTO ContestParticipants
(ContestID, StudentID)
VALUES
(1, 1),
(1, 2);

INSERT INTO ContestProblems
(ContestID, ProblemID)
VALUES
(1, 1);