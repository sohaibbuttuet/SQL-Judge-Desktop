using System;
using System.Collections.Generic;

namespace SQL_Judge_System.Models
{
    internal class Problem : AuditableEntity
    {
        private int problemID;
        private string title;
        private string description;
        private int difficultyID;
        private int points;
        private string targetDatabase;
        private string masterQuery;
        private bool isActive;

        // =========================
        // Properties
        // =========================
        public int ProblemID
        {
            get { return problemID; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid Problem ID.");

                problemID = value;
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title cannot be empty.");

                title = value;
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Description cannot be empty.");

                description = value;
            }
        }
        public int DifficultyID
        {
            get { return difficultyID; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid Difficulty ID"); 
                difficultyID = value;
            }
        }
        public int Points
        {
            get { return points; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Points must be greater than 0.");

                points = value;
            }
        }
        public string TargetDatabase
        {
            get { return targetDatabase; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Target Database cannot be empty.");
                targetDatabase = value;
            }
        }
        public string MasterQuery
        {
            get { return masterQuery; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Master Query cannot be empty.");
                masterQuery = value;
            }
        }
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        // =========================
        // Constructers
        // =========================
        public Problem()
        {
            Points = 10;
            IsActive = true;
        }

        // Constructor For Creating New Problem (without ID, CreatedBy)
        public Problem(string title, string description, int difficultyID, int points, string targetDatabase, string masterQuery, int createdBy)
        {
            Title = title;
            Description = description;
            DifficultyID = difficultyID;
            Points = points;
            TargetDatabase = targetDatabase;
            MasterQuery = masterQuery;

            IsActive = true;

            MarkCreated(createdBy);
        }

        // Constructor For Updating Existing Problem (with ID, UpdatedBy)
        public Problem(int problemID, string title, string description, int difficultyID, int points, string targetDatabase, string masterQuery, int updatedBy)
        {
            ProblemID = problemID;
            Title = title;
            Description = description;
            DifficultyID = difficultyID;
            Points = points;
            TargetDatabase = targetDatabase;
            MasterQuery = masterQuery;

            MarkUpdated(updatedBy);
        }

        // Full Constructer For Database Load
        public Problem(int problemID, string title, string description, int difficultyID, int points, string targetDatabase, string masterQuery, int createdBy, DateTime createdAt, int updatedBy, DateTime updatedAt, bool isActive)
        {
            ProblemID = problemID;
            Title = title;
            Description = description;
            DifficultyID = difficultyID;
            TargetDatabase = targetDatabase;
            MasterQuery = masterQuery;
            Points = points;
            IsActive = isActive;

            LoadAuditData(createdBy, createdAt, updatedBy, updatedAt);
        }
    }
}
