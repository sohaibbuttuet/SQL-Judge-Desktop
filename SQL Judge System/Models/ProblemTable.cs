using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ProblemTable
    {
        private int tableID;
        private int problemID;
        private string tableName;

        public int TableID
        {
            get { return tableID; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("TableID cannot be negative.");
                }
                tableID = value;
            }
        }
        public int ProblemID
        {
            get { return problemID; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("ProblemID cannot be negative.");
                }
                problemID = value;
            }
        }
        public string TableName
        {
            get { return tableName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("TableName cannot be null or empty.");
                }
                tableName = value;
            }
        }

        public ProblemTable()
        {
            // Default constructor
        }
        public ProblemTable(int problemID, string tableName)
        {
            ProblemID = problemID;
            TableName = tableName;
        }
        public ProblemTable(int tableID, int problemID, string tableName)
        {
            TableID = tableID;
            ProblemID = problemID;
            TableName = tableName;
        }

    }
}
