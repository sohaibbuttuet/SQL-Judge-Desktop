using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidDb26_2025CS259;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.DL
{
    internal class ProblemDifficultyDL
    {
        public static List<ProblemDifficulty> GetAll()
        {
            string query = "SELECT * FROM ProblemDifficulty";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<ProblemDifficulty> difficulties = new List<ProblemDifficulty>();
            foreach(DataRow row in dt.Rows)
            {
                difficulties.Add(new ProblemDifficulty
                {
                    DifficultyID = Convert.ToInt32(row["DifficultyID"]),
                    DifficultyName = row["DifficultyName"].ToString()
                });
            }
            return difficulties;
        }
    }
}