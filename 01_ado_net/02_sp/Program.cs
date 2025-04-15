
using System.Data;
using Microsoft.Data.SqlClient;

string connString = @"Server=.\SQLEXPRESS;Database=p32_insta_db;Trusted_Connection=True;Encrypt=False;";
string connStringWithoutPooling = @"Server=.\SQLEXPRESS;Database=p32_mystat_db;Trusted_Connection=True;Encrypt=False;Pooling=False;";



using SqlConnection conn = new SqlConnection(connString);

try
{
    conn.Open();
    Console.WriteLine("Connection OPENED!");

    //string query = @"
    //    CREATE PROCEDURE uspGetUsersOf2000
    //    AS
    //    BEGIN
    //     SELECT id, email
    //     FROM users
    //     WHERE YEAR(birthday) = 2000;
    //    END
    //";

    //SqlCommand cmd = new SqlCommand(query, conn);
    //cmd.ExecuteNonQuery();

    SqlDataReader reader = GetProcedureReader("uspGetUsersOf2000");
    RenderResult(reader);

}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
}
finally
{
    if (conn.State == System.Data.ConnectionState.Open)
    {
        Console.WriteLine("Connection CLOSED");
        conn.Close();
    }
}



SqlDataReader GetProcedureReader(string procName)
{
    SqlCommand cmd = new SqlCommand()
    {
        Connection = conn,
        CommandType = System.Data.CommandType.StoredProcedure,
        CommandText = procName,
    };

    return cmd.ExecuteReader();
}

void RenderResult(SqlDataReader reader)
{
    int columnCount = reader.FieldCount;

    DataTable table = new DataTable();
    table.Load(reader);

    foreach (DataColumn col in table.Columns)
        Console.Write($"{col.ColumnName}\t");
    Console.WriteLine("\n------------------------------------------------");

    foreach(DataRow row in table.Rows)
    {
        for (int i = 0; i < columnCount; ++i)
            Console.Write($"{row[i]}\t");

        Console.WriteLine();
    }

}