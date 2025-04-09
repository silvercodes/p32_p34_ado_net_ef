using Microsoft.Data.SqlClient;

string connString = @"Server=.\SQLEXPRESS;Database=company_db;Trusted_Connection=True;Encrypt=False;";

#region Connection

using SqlConnection conn = new SqlConnection(connString);

try
{
    conn.Open();
    Console.WriteLine("Connection opened!");

    Console.WriteLine(conn.ConnectionString);
    Console.WriteLine(conn.State);
    Console.WriteLine(conn.ServerVersion);

    string query = @"
        CREATE TABLE pictures(
            id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
            title varchar(64) NOT NULL
        );
    ";

    SqlCommand cmd = new SqlCommand(query, conn);
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
        conn.Close();
        Console.WriteLine("Connection closed!");
    }
}






#endregion



