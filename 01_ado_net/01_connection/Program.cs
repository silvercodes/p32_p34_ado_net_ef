

using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;

string connString = @"Server=.\SQLEXPRESS;Database=p32_insta_db;Trusted_Connection=True;Encrypt=False;";
string connStringWithoutPooling = @"Server=.\SQLEXPRESS;Database=p32_mystat_db;Trusted_Connection=True;Encrypt=False;Pooling=False;";

#region Connection

//using SqlConnection conn = new SqlConnection(connString);

//try
//{
//    conn.Open();
//    Console.WriteLine("Connection OPENED!");
//    Console.WriteLine(conn.ConnectionString);
//    Console.WriteLine(conn.State);
//    Console.WriteLine(conn.ServerVersion);

//    string query = @"
//        CREATE TABLE pictures(
//            id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
//            link varchar(128) NOT NULL
//        );
//    ";

//    SqlCommand cmd = new SqlCommand(query, conn);
//    //
//    //
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

//using (SqlConnection conn = new SqlConnection(connString))
//{
//    conn.Open();
//    Console.WriteLine(conn.ClientConnectionId);
//}

//using (SqlConnection conn = new SqlConnection(connString))
//{
//    conn.Open();
//    Console.WriteLine(conn.ClientConnectionId);
//}

//using (SqlConnection conn = new SqlConnection(connStringWithoutPooling))
//{
//    conn.Open();
//    Console.WriteLine(conn.ClientConnectionId);
//}

//using (SqlConnection conn = new SqlConnection(connStringWithoutPooling))
//{
//    conn.Open();
//    Console.WriteLine(conn.ClientConnectionId);
//}

#endregion


#region Command

// ===== ExecuteNonQuery()

//using SqlConnection conn = new SqlConnection(connString);

//try
//{
//    conn.Open();
//    Console.WriteLine("Connection OPENED!");

//    string query = @"
//        INSERT INTO pictures(link)
//        VALUES ('bali.png');
//    ";

//    SqlCommand cmd = new SqlCommand()
//    { 
//        Connection = conn,
//        CommandType = System.Data.CommandType.Text,
//        CommandText = query,
//    };

//    cmd.ExecuteNonQuery();

//    conn.ChangeDatabase("mystat_db");

//    cmd.CommandText = @"
//        INSERT INTO pictures(link)
//        VALUES ('spain.png');
//    ";

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




// ====== ExecuteReader() ======

//using SqlConnection conn = new SqlConnection(connString);

//try
//{
//    conn.Open();
//    Console.WriteLine("Connection OPENED!");

//    string query = @"
//       SELECT * FROM users;
//    ";

//    SqlCommand cmd = new SqlCommand(query, conn);

//    using (SqlDataReader reader = cmd.ExecuteReader())
//    {
//        Console.WriteLine($"{reader.GetName(0)}\t{reader.GetName(1)}\t{reader.GetName(2)}\t{reader.GetName(3)}\t");
//        Console.WriteLine("---------------------------------------------------------------");

//        //while(reader.Read())
//        //{
//        //    // int id = (int)reader[0];
//        //    // int id = (int)reader["id"];
//        //    // int id = reader.GetInt32(0);
//        //    // int id = reader.GetInt32(0);
//        //    // int id = (int)reader.GetValue(0);
//        //    int id = reader.GetFieldValue<int>(0);

//        //    string email = reader.GetFieldValue<string>(1);
//        //    string nickname = reader.GetFieldValue<string>(2);
//        //    string password = reader.GetFieldValue<string>(3);

//        //    Console.WriteLine($"{id}\t{email}\t{nickname}\t{password}");
//        //}


//        DataTable dt = new DataTable();
//        dt.Load(reader);

//        foreach(DataRow row in dt.Rows)
//            Console.WriteLine($"{row["id"]}\t{row["email"]}\t{row["nickname"]}\t{row["password"]}");
//    }
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




// ====== ExecuteScalar() ======

//using SqlConnection conn = new SqlConnection(connString);

//try
//{
//    conn.Open();
//    Console.WriteLine("Connection OPENED!");

//    string query = @"
//        SELECT MAX(id) FROM users;
//    ";

//    SqlCommand cmd = new SqlCommand(query, conn);

//    int id = (int)cmd.ExecuteScalar();

//    Console.WriteLine($"Max id = {id}");
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

#endregion

// DbConnection
// SqlConnection




