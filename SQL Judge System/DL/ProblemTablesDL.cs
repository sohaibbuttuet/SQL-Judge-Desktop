using MySql.Data.MySqlClient;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.DL
{
    internal class ProblemTablesDL
    {
        public static int AddProblemTable(ProblemTable table)
        {
            string query = "INSERT INTO problemtables (ProblemID, TableName) VALUES (@ProblemID, @TableName); SELECT LAST_INSERT_ID();";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ProblemID", table.ProblemID),
                new MySqlParameter("@TableName", table.TableName)
            };

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters)); // Returns the new ProblemTableID
        }
        public static void DeleteAllByProblemID(int problemId)
        {
            string query = "DELETE FROM ProblemTables WHERE ProblemID = @ProblemID;";

            MySqlParameter[] parameters = {
                new MySqlParameter("@ProblemID", problemId)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static List<ProblemTable> GetTablesByProblemID(int problemId)
        {
            string query = "SELECT * FROM ProblemTables WHERE ProblemID = @ProblemID;";

            MySqlParameter[] parameters = 
            {
                 new MySqlParameter("@ProblemID", problemId)
            };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);

            List<ProblemTable> list = new List<ProblemTable>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ProblemTable
                {
                    TableID = Convert.ToInt32(row["TableID"]),
                    ProblemID = Convert.ToInt32(row["ProblemID"]),
                    TableName = row["TableName"].ToString()
                });
            }
            return list;
        }
    }
}
