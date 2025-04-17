

using Microsoft.Data.SqlClient;

string connString = @"Server=.\SQLEXPRESS;Database=p32_mystat_db;Trusted_Connection=True;Encrypt=False;";



//using SqlConnection conn = new SqlConnection(connString);

//// string title = "'EF Core'";

//string title = "'my_title');INSERT INTO subjects(title) VALUES('admin looser!'";

//try
//{
//    conn.Open();
//    Console.WriteLine("Connection OPENED!");

//    string query = $@"INSERT INTO subjects(title) VALUES({title})";

//    SqlCommand cmd = new SqlCommand(query, conn);
//    cmd.ExecuteNonQuery();

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






//using SqlConnection conn = new SqlConnection(connString);

//// string title = "'EF Core'";

//string title = "'my_title');INSERT INTO subjects(title) VALUES('admin looser!'";

//try
//{
//    conn.Open();
//    Console.WriteLine("Connection OPENED!");

//    string query = $@"INSERT INTO subjects(title) VALUES(@title)";

//    SqlCommand cmd = new SqlCommand(query, conn);

//    SqlParameter prm = new SqlParameter("@title", title)
//    { 
//        SqlDbType = System.Data.SqlDbType.NVarChar,
//        Size = 256
//    };

//    cmd.Parameters.Add(prm);

//    cmd.ExecuteNonQuery();
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


string number = "203";
string title = "Robotics";
int branch_id = 1;


try
{
    conn.Open();
    Console.WriteLine("Connection OPENED!");

    string query = $@"
        INSERT INTO classrooms (number, title, branch_id)
            VALUES (@number, @title, @branch_id);
        SET @last_id = SCOPE_IDENTITY();
    ";

    SqlCommand cmd = new SqlCommand(query, conn);

    cmd.Parameters.Add(new SqlParameter("@number", number)
    {
        SqlDbType = System.Data.SqlDbType.NVarChar,
        Size = 32,
    });

    cmd.Parameters.Add(new SqlParameter("@title", title)
    {
        SqlDbType = System.Data.SqlDbType.NVarChar,
        Size = 64,
    });

    cmd.Parameters.Add(new SqlParameter("@branch_id", branch_id)
    {
        SqlDbType = System.Data.SqlDbType.Int,
    });

    SqlParameter id = new SqlParameter()
    {
        ParameterName = "@last_id",
        SqlDbType = System.Data.SqlDbType.Int,
        Direction = System.Data.ParameterDirection.Output,
    };
    cmd.Parameters.Add(id);

    cmd.ExecuteNonQuery();

    Console.WriteLine($"last_id = {id.Value}");
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