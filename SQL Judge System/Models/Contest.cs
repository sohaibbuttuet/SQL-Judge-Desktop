using System;
using System.Collections.Generic;

namespace SQL_Judge_System.Models
{
    internal class Contest
    {
        private int contestID;
        private string title;
        private string description;
        private DateTime startDate;
        private DateTime endDate;

        private int createdBy;
        private DateTime createdAt;

        private int updatedBy;
        private DateTime updatedAt;

        // =====================================
        // Composition (1-to-many relationship) 
        // =====================================
        private List<ContestProblem> problems = new List<ContestProblem>();
        private List<ContestParticipant> participants = new List<ContestParticipant>();

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
            set
            {
                if (EndDate != default && value >= EndDate)
                    throw new Exception("Start Date must be before End Date.");

                startDate = value;
            }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set
            {
                if (StartDate != default && value <= StartDate)
                    throw new Exception("End Date must be after Start Date.");

                endDate = value;
            }
        }
        public int CreatedBy
        {
            get { return createdBy; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid CreatedBy ID.");

                createdBy = value;
            }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            private set
            {
                createdAt = value;
            }
        }
        public int UpdatedBy
        {
            get { return updatedBy; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid UpdatedBy ID.");

                updatedBy = value;
            }
        }
        public DateTime UpdatedAt
        {
            get { return updatedAt; }
            private set
            {
                updatedAt = value;
            }
        }

        // =========================
        // Computed Property
        // =========================
        public string Status
        {
            get
            {
                if (DateTime.Now < StartDate)
                    return "Upcoming";

                if (DateTime.Now > EndDate)
                    return "Ended";

                return "Running";
            }
        }

        // =========================
        // Safe Composition Exposure
        // =========================
        public IReadOnlyList<ContestProblem> Problems
        {
            get { return problems.AsReadOnly(); }
        }
        public IReadOnlyList<ContestParticipant> Participants
        {
            get { return participants.AsReadOnly(); }
        }

        // =========================
        // Constructors
        // =========================
        public Contest()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        public Contest(string title, string description, DateTime startDate, DateTime endDate, int createdBy)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            CreatedBy = createdBy;

            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        public Contest(int contestID, string title, string description, DateTime startDate, DateTime endDate, int createdBy, DateTime createdAt, int updatedBy, DateTime updatedAt)
        {
            ContestID = contestID;
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;

            CreatedBy = createdBy;
            CreatedAt = createdAt;

            UpdatedBy = updatedBy;
            UpdatedAt = updatedAt;
        }

        // =========================
        // Composition Management
        // =========================
        public void AddProblem(ContestProblem problem)
        {
            if (problem == null)
                throw new ArgumentNullException(nameof(problem));

            problems.Add(problem);
        }
        public void RemoveProblem(ContestProblem problem)
        {
            if (problem == null)
                throw new ArgumentNullException(nameof(problem));

            problems.Remove(problem);
        }

        public void AddParticipant(ContestParticipant participant)
        {
            if (participant == null)
                throw new ArgumentNullException(nameof(participant));

            participants.Add(participant);
        }
        public void RemoveParticipant(ContestParticipant participant)
        {
            if (participant == null)
                throw new ArgumentNullException(nameof(participant));

            participants.Remove(participant);
        }

        public void ClearProblems()
        {
            problems.Clear();
        }
        public void ClearParticipants()
        {
            participants.Clear();
        }

        // =========================
        // Audit Management
        // =========================
        public void MarkUpdated(int updatedBy)
        {
            UpdatedBy = updatedBy;
            UpdatedAt = DateTime.Now;
        }
    }
}

