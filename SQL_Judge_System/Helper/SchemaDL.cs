using MySql.Data.MySqlClient;
using SQL_Judge_System.Models;
using SQL_Judge_System.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Helper
{
    internal class SchemaDL
    {
        // ==========================================
        // FETCH STRUCTURAL DATABASE SCHEMA DATA
        // ==========================================
        public static DataTable GetDatabaseSchema(string databaseName)
        {
            string query = @"CALL db_schema(@DatabaseName);"; // Call the stored procedure 

            MySqlParameter[] parameters = 
            {
                new MySqlParameter("@DatabaseName", databaseName)
            };

            return DatabaseHelper.Instance.GetDataTable(query, parameters);
        }

        // ==========================================
        // EXTRACT ALL EXISTING SCHEMA TABLE NAMES
        // ==========================================
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

        // ==========================================
        // EXTRACT SELECTED SCHEMA FOR STUDNETS
        // ==========================================
        public static DataTable GetSelectedSchema(string databaseName, List<string> allowedTables)
        {
            // CREATE AN EMPTY DATATABLE TO RETURN IF NEEDED
            DataTable dt = new DataTable();

            // SAFETY GUARD: If there are no allowed tables, don't query the database!
            if (allowedTables == null || allowedTables.Count == 0)
            {
                // Add matching columns so the UI TreeView loop doesn't throw a NullReferenceException
                dt.Columns.Add("TABLE_NAME");
                dt.Columns.Add("COLUMN_NAME");
                dt.Columns.Add("DATA_TYPE");
                return dt;
            }

            string query = @"SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = @DbName AND TABLE_NAME IN ({0}) ORDER BY TABLE_NAME, ORDINAL_POSITION;";

            // Generate list of parameter placeholders ["@t0", "@t1"]
            List<string> paramNames = new List<string>();
            for(int i = 0; i < allowedTables.Count; i++)
            {
                paramNames.Add($"@t{i}");
            }

            // Convert array into a single string ("@t0,@t1")
            string allParam = string.Join(",", paramNames);

            // Insert all parameters into query placeholder
            string formattedQuery = string.Format(query, allParam);

            // Create a list to hold all your parameters
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            // Add the database name parameter
            parameters.Add(new MySqlParameter("@DbName", databaseName));

            // Populate the table name parameters dynamically
            for (int i = 0; i < allowedTables.Count; i++)
            {
                parameters.Add(new MySqlParameter(paramNames[i], allowedTables[i]));
            }

            // Pass the array of parameters to your DatabaseHelper
            return DatabaseHelper.Instance.GetDataTable(formattedQuery, parameters.ToArray());
        }
    }
}
