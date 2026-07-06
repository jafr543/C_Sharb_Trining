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

    static void updateRow(int ContactID,stContactinfo newcontactInfo)
    {

        SqlConnection connection = new SqlConnection(connectionString);

        string query = @"update Contacts
                        set FirstName = @FirstName,
                         LastName = @LastName,
                         Email = @Email,
                         Phone = @Phone,
                         Address = @Address,
                         CountryID = @CountryID
                         where ContactID = @ContactID";

        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@FirstName", newcontactInfo.FirstName);
        command.Parameters.AddWithValue("@LastName", newcontactInfo.LastName);
        command.Parameters.AddWithValue("@Email", newcontactInfo.Email);
        command.Parameters.AddWithValue("@Phone", newcontactInfo.PhoneNumber);
        command.Parameters.AddWithValue("@Address", newcontactInfo.Address);
        command.Parameters.AddWithValue("@CountryID", newcontactInfo.CountryID);
        command.Parameters.AddWithValue("@ContactID", ContactID);

        try
        {
            connection.Open();

            int result = command.ExecuteNonQuery();

            if (result > 0)
            {
                Console.WriteLine($"Record Updated successfully");
            }
            else
            {
                Console.WriteLine("update failed");
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
        contactInfo.FirstName = "hider";
        contactInfo.LastName = "sadee";
        contactInfo.Email = "hid@gm,ail.com";
        contactInfo.PhoneNumber = "4321";
        contactInfo.Address = "hmdani st1";
        contactInfo.CountryID = 1;

        updateRow(1,contactInfo);
        Console.ReadKey();
    }
}
