using System;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;
using static Program;
internal class Program
{

    static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=123456;";
    public struct stContactinfo
    {
        public int ID {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
    }

    static void AddNewRow(stContactinfo newcontactInfo)
    {

        SqlConnection connection = new SqlConnection(connectionString);

        string query = @"Insert into Contacts (FirstName, LastName, Email, Phone, Address, CountryID)
                        Values(@FirstName, @LastName, @Email, @Phone, @Address, @CountryID);
                         SELECT SCOPE_IDENTITY();";

        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@FirstName", newcontactInfo.FirstName);
        command.Parameters.AddWithValue("@LastName", newcontactInfo.LastName);
        command.Parameters.AddWithValue("@Email", newcontactInfo.Email);
        command.Parameters.AddWithValue("@Phone", newcontactInfo.PhoneNumber);
        command.Parameters.AddWithValue("@Address", newcontactInfo.Address);
        command.Parameters.AddWithValue("@CountryID", newcontactInfo.CountryID);

        try
        {
            connection.Open();

            object result = command.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int insertedID))
            {
                Console.WriteLine($"Newly inserted Id: {insertedID}");
            }
            else
            {
                Console.WriteLine("inserted failed");
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
        stContactinfo contactInfo = new stContactinfo();
        contactInfo.FirstName = "Noor";
        contactInfo.LastName = "Jaber";
        contactInfo.Email = "Noor@gmail.com";
        contactInfo.PhoneNumber = "4321";
        contactInfo.Address = "Raiy st1";
        contactInfo.CountryID = 1;

        AddNewRow(contactInfo);
        Console.ReadKey();
    }
}
