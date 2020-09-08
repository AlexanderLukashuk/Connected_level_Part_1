using System;
using System.Data.SqlClient;
using System.Data;

namespace CreatingTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            string connectionString = "Server = localhost; Database = OnlineShopDatabase; Trusted_Connection = True;";
            connection.ConnectionString = connectionString;

            DataSet step = new DataSet("STEP");
            DataTable gruppa = new DataTable("gruppa");

            step.Tables.Add(gruppa);

            DataColumn idColumn = new DataColumn();
            idColumn.ColumnName = "Id";
            idColumn.DataType = typeof(int);
            idColumn.AllowDBNull = false;
            idColumn.AutoIncrement = true;
            idColumn.Unique = true;

            gruppa.Columns.Add(idColumn);

            DataColumn nameColumn = new DataColumn();
            nameColumn.ColumnName = "Name";
            nameColumn.DataType = typeof(string);
            nameColumn.AllowDBNull = false;
            nameColumn.Unique = true;
            nameColumn.MaxLength = 30;

            gruppa.Columns.Add(nameColumn);

            step.Tables.Add(gruppa);
        }
    }
}
