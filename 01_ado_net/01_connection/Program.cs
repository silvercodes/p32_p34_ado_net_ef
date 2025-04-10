

using System.Data.Common;
using Microsoft.Data.SqlClient;

string connString = @"Server=.\SQLEXPRESS;Database=p32_mystat_db;Trusted_Connection=True;Encrypt=False;";

#region Connection

using SqlConnection conn = new SqlConnection(connString);

try
{
    conn.Open();
    Console.WriteLine("Connection OPENED!");
    Console.WriteLine(conn.ConnectionString);
    Console.WriteLine(conn.State);
    Console.WriteLine(conn.ServerVersion);

    string query = @"
        CREATE TABLE pictures(
            id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
            link varchar(128) NOT NULL
        );
    ";

    SqlCommand cmd = new SqlCommand(query, conn);
    //
    //
    cmd.ExecuteNonQuery();
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


#endregion

// DbConnection
// SqlConnection




