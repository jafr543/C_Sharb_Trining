using System;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;
using static Program;
internal class Program
{

    static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=123456;";

    static void AddNewRow(string ContactID)
    {

        SqlConnection connection = new SqlConnection(connectionString);

        string query = @"Delete Contacts
                            Where ContactID in (" + @ContactID + ")";

        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@ContactID", ContactID);


        try
        {
            connection.Open();

            int result = command.ExecuteNonQuery();

            if (result > 0)
            {
                Console.WriteLine($"Record Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Record Delete failed");
            }

            
            connection.Close();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        
    } 

    static void Main(string[] args)
    { 
        AddNewRow("4,5,6");
        Console.ReadKey();
    }
}
