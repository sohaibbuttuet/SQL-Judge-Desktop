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
        public static List<string> GetColumnsOfTable(string databaseName, string tableName)
        {
            string query = @"CALL db_table_columns(@DatabaseName, @TableName);";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@DatabaseName", databaseName),
                new MySqlParameter("@TableName", tableName)
            };

            DataTable result = DatabaseHelper.Instance.GetDataTable(query, parameters);

            List<string> columns = new List<string>();
            foreach (DataRow row in result.Rows)
            {
                columns.Add(row["COLUMN_NAME"].ToString() + "(" + row["DATA_TYPE"].ToString() + ")");
            }

            return columns;
        }
        public static bool ColumnExists(string tableName, string columnName)
        {
            string query = @"SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = @TableName AND COLUMN_NAME = @ColumnName;";

            MySqlParameter[] parameters =
            {
                  new MySqlParameter("@TableName", tableName),
                  new MySqlParameter("@ColumnName", columnName)
            };

            return DatabaseHelper.Instance.ExecuteScalar(query, parameters) > 0;
        }
        public static bool TableExists(string tableName)
        {
            string query = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = @TableName;";

            MySqlParameter[] parameters = 
            {
                new MySqlParameter("@TableName", tableName)
            };

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters)) > 0;
        }
    }
}
