using System;
using System.Collections.Generic;

namespace SQL_Judge_System.Models
{
    internal class Contest : AuditableEntity
    {
        private int contestID;
        private string title;
        private int duration;
        private string description;
        private DateTime startDate;
        private DateTime endDate;

        // =========================
        // Properties
        // =========================
        public int ContestID
        {
            get { return contestID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Contest ID.");

                contestID = value;
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Title cannot be empty.");

                title = value.Trim();
            }
        }
        public int Duration
        {
            get { return duration; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Contest Duration");
                duration = value;
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value?.Trim();
            }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set {  endDate = value; }
        }

        // =========================
        // Constructors
        // =========================

        // Default Constructer
        public Contest() { }

        // Constructer For Creating Contest
        public Contest(string title, string description, int duration, DateTime startDate, DateTime endDate, int createdBy)
        {
            Title = title;
            Description = description;
            Duration = duration;
            StartDate = startDate;
            EndDate = endDate;

            MarkCreated(createdBy);
        }

        // Constructer For Updating Contest
        public Contest(int contestID, string title, int duration, string description, DateTime startDate, DateTime endDate, int updatedBy)
        {
            ContestID = contestID;
            Title = title;
            Duration = duration;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;

            MarkUpdated(updatedBy);
        }

        // Full Constructer For DB Load
        public Contest(int contestID,string title, int duration, string description,  DateTime startDate, DateTime endDate, int createdBy, DateTime createdAt, int updatedBy, DateTime updatedAt)
        {
            ContestID = contestID;
            Title = title;
            Duration = duration;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;

            LoadAuditData(createdBy, createdAt, updatedBy, updatedAt);
        }
    }
}

