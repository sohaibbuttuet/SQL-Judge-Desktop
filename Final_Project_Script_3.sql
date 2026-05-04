-- =====================================
-- DATABASE
-- =====================================
CREATE DATABASE IF NOT EXISTS SQLJudgeSystem;
USE SQLJudgeSystem;

-- =====================================
-- 1. ROLES (LOOKUP)
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
    PasswordHash VARCHAR(255) NOT NULL,
    IsActive BOOLEAN DEFAULT TRUE,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- =====================================
-- 3. USER ROLES (MANY TO MANY)
-- =====================================
CREATE TABLE UserRoles (
    UserID INT NOT NULL,
    RoleID INT NOT NULL,

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

-- =====================================
-- 6. PROBLEM DIFFICULTY
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

    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (DifficultyID) REFERENCES ProblemDifficulties(DifficultyID)
        ON DELETE RESTRICT
);

-- =====================================
-- 9. PROBLEM TAG MAP (MANY TO MANY)
-- =====================================
CREATE TABLE ProblemTagMap (
    ProblemID INT NOT NULL,
    TagID INT NOT NULL,

    PRIMARY KEY (ProblemID, TagID),

    FOREIGN KEY (ProblemID) REFERENCES Problems(ProblemID) ON DELETE CASCADE,
    FOREIGN KEY (TagID) REFERENCES ProblemTags(TagID) ON DELETE CASCADE
);

-- =====================================
-- 10. TEST CASES
-- =====================================
CREATE TABLE TestCases (
    TestCaseID INT AUTO_INCREMENT PRIMARY KEY,
    ProblemID INT NOT NULL,

    SetupSQL TEXT NOT NULL,
    ExpectedOutput TEXT NOT NULL,

    ScorePoints INT DEFAULT 10 CHECK (ScorePoints > 0),

    FOREIGN KEY (ProblemID) REFERENCES Problems(ProblemID)
        ON DELETE CASCADE
);

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
    QueryText TEXT NOT NULL,
    StatusID INT NOT NULL,

    SubmittedAt DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (StudentID) REFERENCES Students(StudentID) ON DELETE CASCADE,
    FOREIGN KEY (ProblemID) REFERENCES Problems(ProblemID) ON DELETE CASCADE,
    FOREIGN KEY (StatusID) REFERENCES SubmissionStatuses(StatusID) ON DELETE RESTRICT
);

-- =====================================
-- 13. SUBMISSION RESULTS
-- =====================================
CREATE TABLE SubmissionResults (
    ResultID INT AUTO_INCREMENT PRIMARY KEY,
    SubmissionID INT NOT NULL,
    Output TEXT,

    FOREIGN KEY (SubmissionID) REFERENCES Submissions(SubmissionID)
        ON DELETE CASCADE
);

-- =====================================
-- 14. CONTEST STATUS (LOOKUP)
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

    DurationMinutes INT CHECK (DurationMinutes > 0),

    StatusID INT NOT NULL,

    IsPublic BOOLEAN DEFAULT TRUE,
    CreatedBy INT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,

    MaxParticipants INT CHECK (MaxParticipants > 0),

    CHECK (EndDate > StartDate),

    FOREIGN KEY (StatusID) REFERENCES ContestStatus(StatusID),
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserID) ON DELETE RESTRICT
);

-- =====================================
-- 16. CONTEST PROBLEMS
-- =====================================
CREATE TABLE ContestProblems (
    ContestID INT NOT NULL,
    ProblemID INT NOT NULL,

    PRIMARY KEY (ContestID, ProblemID),

    FOREIGN KEY (ContestID) REFERENCES Contests(ContestID) ON DELETE CASCADE,
    FOREIGN KEY (ProblemID) REFERENCES Problems(ProblemID) ON DELETE CASCADE
);

-- =====================================
-- 17. LEADERBOARD
-- =====================================
CREATE TABLE Leaderboard (
    LeaderboardID INT AUTO_INCREMENT PRIMARY KEY,
    StudentID INT NOT NULL,
    ContestID INT NOT NULL,

    TotalSolved INT DEFAULT 0 CHECK (TotalSolved >= 0),
    TotalScore INT DEFAULT 0 CHECK (TotalScore >= 0),

    UNIQUE (StudentID, ContestID),

    FOREIGN KEY (StudentID) REFERENCES Students(StudentID) ON DELETE CASCADE,
    FOREIGN KEY (ContestID) REFERENCES Contests(ContestID) ON DELETE CASCADE
);

-- =====================================
-- INDEXES (OPTIMIZED)
-- =====================================
CREATE INDEX idx_users_email ON Users(Email);

CREATE INDEX idx_students_user ON Students(UserID);
CREATE INDEX idx_students_skill ON Students(SkillLevelID);

CREATE INDEX idx_problems_difficulty ON Problems(DifficultyID);
CREATE INDEX idx_problems_created ON Problems(CreatedAt);

CREATE INDEX idx_ptm_problem ON ProblemTagMap(ProblemID);
CREATE INDEX idx_ptm_tag ON ProblemTagMap(TagID);

CREATE INDEX idx_testcases_problem ON TestCases(ProblemID);

CREATE INDEX idx_submissions_student ON Submissions(StudentID);
CREATE INDEX idx_submissions_problem ON Submissions(ProblemID);
CREATE INDEX idx_submissions_status ON Submissions(StatusID);
CREATE INDEX idx_submissions_time ON Submissions(SubmittedAt);

CREATE INDEX idx_results_submission ON SubmissionResults(SubmissionID);

CREATE INDEX idx_contests_time ON Contests(StartDate, EndDate);

CREATE INDEX idx_cp_problem ON ContestProblems(ProblemID);

CREATE INDEX idx_leaderboard_student ON Leaderboard(StudentID);
CREATE INDEX idx_leaderboard_contest ON Leaderboard(ContestID);

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
('Syntax Error');

INSERT INTO ProblemTags (TagName) VALUES
('Joins'),
('Aggregation'),
('Subqueries'),
('Group By');

INSERT INTO ContestStatus (StatusName) VALUES
('Upcoming'),
('Active'),
('Ended'),
('Cancelled');