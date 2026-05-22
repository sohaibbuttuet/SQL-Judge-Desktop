using System;
using System.Collections.Generic;

namespace SQL_Judge_System.Models
{
    internal class Contest : AuditableEntity
    {
        private int contestID;
        private string title;
        private string description;
        private DateTime startDate;
        private DateTime endDate;

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
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set {  endDate = value; }
        }

        // Computed Property
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

        // Default Constructer
        public Contest() { }

        // Constructer For Creating Contest
        public Contest(string title, string description, DateTime startDate, DateTime endDate, int createdBy)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;

            MarkCreated(createdBy);
        }

        // Constructer For Updating Contest
        public Contest(int contestID, string title, string description, DateTime startDate, DateTime endDate, int updatedBy)
        {
            ContestID = contestID;
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;

            MarkUpdated(updatedBy);
        }

        // Full Constructer For DB Load
        public Contest(int contestID,string title, string description, DateTime startDate, DateTime endDate, int createdBy, DateTime createdAt, int updatedBy, DateTime updatedAt)
        {
            ContestID = contestID;
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;

            LoadAuditData(createdBy, createdAt, updatedBy, updatedAt);
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
    }
}

