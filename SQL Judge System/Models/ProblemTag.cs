using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ProblemTag
    {
        private int tagID;
        private string tagName;

        public int TagID
        {
            get { return tagID; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("value");
                tagID = value;
            }
        }
        public string TagName
        {
            get { return tagName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("value");
                tagName = value;
            }
        }

        public ProblemTag()
        {
        }
        public ProblemTag(int tagID, string tagName)
        {
            TagID = tagID;
            TagName = tagName;
        }
    }
}
