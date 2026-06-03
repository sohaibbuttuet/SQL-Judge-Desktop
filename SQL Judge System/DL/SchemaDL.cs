using MySql.Data.MySqlClient;
using SQL_Judge_System.Models;
using SQL_Judge_System.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.DL
{
    internal class SchemaDL
    {
        public static DataTable GetDatabaseSchema(string databaseName)
        {
            string query = @"CALL db_schema(@DatabaseName);"; // Call the stored procedure 

            MySqlParameter[] parameters = 
            {
                new MySqlParameter("@DatabaseName", databaseName)
            };

            return DatabaseHelper.Instance.GetDataTable(query, parameters);
        }
        public static List<string> GetAllTables(string databaseName)
        {
            string query = @"CALL db_tables(@DatabaseName);"; // Call the stored procedure 

            MySqlParameter[] parameters = 
            {
                new MySqlParameter("@DatabaseName", databaseName)
            };

            DataTable result = DatabaseHelper.Instance.GetDataTable(query, parameters);

            List<string> tables = new List<string>();
            foreach (DataRow row in result.Rows)
            {
                tables.Add(row["TABLE_NAME"].ToString());
            }

            return tables;
        }
    }
}
