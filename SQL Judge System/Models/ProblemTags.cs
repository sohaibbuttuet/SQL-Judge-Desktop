using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ProblemTags
    {
        public int TagID { get; set; }
        public string TagName { get; set; }

        public ProblemTags(int tagID, string tagName)
        {
            TagID = tagID;
            TagName = tagName;
        }
    }
}
