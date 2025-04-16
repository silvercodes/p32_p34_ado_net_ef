
using System.Data;
using Microsoft.Data.SqlClient;

string connString = @"Server=.\SQLEXPRESS;Database=p32_insta_db;Trusted_Connection=True;Encrypt=False;";
string connStringWithoutPooling = @"Server=.\SQLEXPRESS;Database=p32_mystat_db;Trusted_Connection=True;Encrypt=False;Pooling=False;";



//using SqlConnection conn = new SqlConnection(connString);

//try
//{
//    conn.Open();
//    Console.WriteLine("Connection OPENED!");

//    //string query = @"
//    //    CREATE PROCEDURE uspGetUsersOf2000
//    //    AS
//    //    BEGIN
//    //     SELECT id, email
//    //     FROM users
//    //     WHERE YEAR(birthday) = 2000;
//    //    END
//    //";

//    //SqlCommand cmd = new SqlCommand(query, conn);
//    //cmd.ExecuteNonQuery();

//    SqlDataReader reader = GetProcedureReader("uspGetUsersOf2000");
//    RenderResult(reader);

//}
//catch (Exception ex)
//{
//    Console.WriteLine($"ERROR: {ex.Message}");
//}
//finally
//{
//    if (conn.State == System.Data.ConnectionState.Open)
//    {
//        Console.WriteLine("Connection CLOSED");
//        conn.Close();
//    }
//}





using SqlConnection conn = new SqlConnection(connString);

string procQuery = @"
    CREATE PROCEDURE uspGetUsersCountByEmail
        @pattern nvarchar(50),
        @count int OUTPUT
    AS
    BEGIN
        SET @count = (
            SELECT COUNT(email)
            FROM users
            WHERE email LIKE @pattern
        );
    END
";



try
{
    conn.Open();
    Console.WriteLine("Connection OPENED!");

    // CreateProcedure(procQuery, conn);

    int count = CountByEmailPattern(conn, "a%");
    Console.WriteLine($"Emails count = {count}");
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

int CountByEmailPattern(SqlConnection conn, string pattern = "")
{
    string spName = "uspGetUsersCountByEmail";

    SqlCommand cmd = new SqlCommand(spName, conn)
    {
        CommandType = CommandType.StoredProcedure,
    };

    cmd.Parameters.Add(new SqlParameter()
    {
        ParameterName = "@pattern",
        SqlDbType = SqlDbType.NVarChar,
        Size = 50,
        Value = pattern
    });

    SqlParameter countPrm = new SqlParameter()
    { 
        ParameterName = "@count",
        SqlDbType = SqlDbType.Int,
        Direction = ParameterDirection.Output,
    };
    cmd.Parameters.Add(countPrm);

    cmd.ExecuteNonQuery();

    return (int)countPrm.Value;
}

void CreateProcedure(string procQuery, SqlConnection conn)
{
    SqlCommand cmd = new SqlCommand(procQuery, conn);
    cmd.ExecuteNonQuery();
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