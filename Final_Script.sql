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
    Email VARCHAR(100) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL,
    IsActive BOOLEAN DEFAULT TRUE,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE INDEX idx_users_email ON Users(Email);

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
    FullName VARCHAR(100) NOT NULL,
    RegistrationNumber VARCHAR(50) UNIQUE NOT NULL,
    SkillLevelID INT,

    TotalScore INT DEFAULT 0 CHECK (TotalScore >= 0),
    ProblemsSolved INT DEFAULT 0 CHECK (ProblemsSolved >= 0),

    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE,
    FOREIGN KEY (SkillLevelID) REFERENCES SkillLevels(SkillLevelID) ON DELETE SET NULL
);

CREATE INDEX idx_students_user ON Students(UserID);
CREATE INDEX idx_students_skill ON Students(SkillLevelID);

-- =====================================
-- 6. DIFFICULTY
-- =====================================
CREATE TABLE ProblemDifficulties (
    DifficultyID INT AUTO_INCREMENT PRIMARY KEY,
    DifficultyName VARCHAR(50) UNIQUE NOT NULL
);

-- =====================================
-- 7. TAGS
-- =====================================
CREATE TABLE ProblemTags (
    TagID INT AUTO_INCREMENT PRIMARY KEY,
    TagName VARCHAR(50) UNIQUE NOT NULL
);

-- =====================================
-- 8. PROBLEMS (FIXED SCORE SYSTEM ⭐)
-- =====================================
CREATE TABLE Problems (
    ProblemID INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(150) NOT NULL,
    Description TEXT NOT NULL,
    DifficultyID INT,

    Score INT NOT NULL DEFAULT 100 CHECK (Score > 0),

    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (DifficultyID) REFERENCES ProblemDifficulties(DifficultyID)
        ON DELETE RESTRICT
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
    FOREIGN KEY (TagID) REFERENCES ProblemTags(TagID) ON DELETE CASCADE
);

CREATE INDEX idx_ptm_problem ON ProblemTagMap(ProblemID);
CREATE INDEX idx_ptm_tag ON ProblemTagMap(TagID);

-- =====================================
-- 10. TEST CASES (VALIDATION ONLY)
-- =====================================
CREATE TABLE TestCases (
    TestCaseID INT AUTO_INCREMENT PRIMARY KEY,
    ProblemID INT NOT NULL,

    SetupSQL TEXT NOT NULL,
    ExpectedOutput TEXT NOT NULL,

    FOREIGN KEY (ProblemID) REFERENCES Problems(ProblemID)
        ON DELETE CASCADE
);

CREATE INDEX idx_testcases_problem ON TestCases(ProblemID);

-- =====================================
-- 11. SUBMISSION STATUS
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

    QueryText TEXT NOT NULL,
    StatusID INT NOT NULL,

    IsAccepted BOOLEAN DEFAULT FALSE,
    TotalScore INT DEFAULT 0 CHECK (TotalScore >= 0),

    SubmittedAt DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (StudentID) REFERENCES Students(StudentID) ON DELETE CASCADE,
    FOREIGN KEY (ProblemID) REFERENCES Problems(ProblemID) ON DELETE CASCADE,
    FOREIGN KEY (StatusID) REFERENCES SubmissionStatuses(StatusID),

    UNIQUE (StudentID, ProblemID, SubmittedAt)
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

    UNIQUE (SubmissionID, TestCaseID),

    FOREIGN KEY (SubmissionID) REFERENCES Submissions(SubmissionID)
        ON DELETE CASCADE,
    FOREIGN KEY (TestCaseID) REFERENCES TestCases(TestCaseID)
        ON DELETE CASCADE
);

CREATE INDEX idx_results_submission ON SubmissionResults(SubmissionID);
CREATE INDEX idx_results_testcase ON SubmissionResults(TestCaseID);

-- =====================================
-- 14. CONTEST STATUS
-- =====================================
CREATE TABLE ContestStatus (
    StatusID INT AUTO_INCREMENT PRIMARY KEY,
    StatusName VARCHAR(50) UNIQUE NOT NULL
);

-- =====================================
-- 15. CONTESTS
-- =====================================
CREATE TABLE Contests (
    ContestID INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(150) NOT NULL,
    Description TEXT,

    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,

    StatusID INT NOT NULL,
    CreatedBy INT NOT NULL,

    CHECK (EndDate > StartDate),

    FOREIGN KEY (StatusID) REFERENCES ContestStatus(StatusID),
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID)
);

CREATE INDEX idx_contests_status ON Contests(StatusID);
CREATE INDEX idx_contests_time ON Contests(StartDate, EndDate);

-- =====================================
-- 16. CONTEST PROBLEMS
-- =====================================
CREATE TABLE ContestProblems (
    ContestID INT,
    ProblemID INT,

    OrderNumber INT NOT NULL,

    PRIMARY KEY (ContestID, ProblemID),
    UNIQUE (ContestID, OrderNumber),

    FOREIGN KEY (ContestID) REFERENCES Contests(ContestID)
        ON DELETE CASCADE,
    FOREIGN KEY (ProblemID) REFERENCES Problems(ProblemID)
        ON DELETE CASCADE
);

CREATE INDEX idx_cp_problem ON ContestProblems(ProblemID);

-- =====================================
-- 17. LEADERBOARD
-- =====================================
CREATE TABLE Leaderboard (
    LeaderboardID INT AUTO_INCREMENT PRIMARY KEY,
    StudentID INT NOT NULL,
    ContestID INT NOT NULL,

    TotalSolved INT DEFAULT 0,
    TotalScore INT DEFAULT 0,

    UNIQUE (StudentID, ContestID),

    FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
        ON DELETE CASCADE,
    FOREIGN KEY (ContestID) REFERENCES Contests(ContestID)
        ON DELETE CASCADE
);

CREATE INDEX idx_leaderboard_student ON Leaderboard(StudentID);
CREATE INDEX idx_leaderboard_contest ON Leaderboard(ContestID);
CREATE INDEX idx_leaderboard_contest_score ON Leaderboard(ContestID, TotalScore);

-- =====================================
-- If all test cases pass:
--    TotalScore = Problems.Score
--    IsAccepted = TRUE
-- Else:
--    TotalScore = 0
--    IsAccepted = FALSE 
-- =====================================

-- =====================================
-- LOOKUP DATA
-- =====================================
INSERT INTO Roles (RoleName) VALUES ('Student'), ('Admin');

INSERT INTO SkillLevels (LevelName) VALUES
('Beginner'), ('Intermediate'), ('Advanced');

INSERT INTO ProblemDifficulties (DifficultyName) VALUES
('Easy'), ('Medium'), ('Hard');

INSERT INTO SubmissionStatuses (StatusName) VALUES
('Accepted'),
('Wrong Answer'),
('Runtime Error'),
('Compilation Error'),
('Pending');

INSERT INTO ContestStatus (StatusName) VALUES
('Upcoming'),
('Active'),
('Ended');

INSERT INTO problemtags(TagName) VALUES
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