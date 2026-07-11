using System;
using System.Data;
using System.Linq;

namespace Trining
{
    internal class Program
    {
        public static void Main()
        {
            DataTable Employees = new DataTable();

            Employees.Columns.Add("ID", typeof(int));
            Employees.Columns.Add("Name", typeof(string));
            Employees.Columns.Add("Country", typeof(string));
            Employees.Columns.Add("Salary", typeof(Double));
            Employees.Columns.Add("Date", typeof(DateTime));


            Employees.Rows.Add(1, "Jafr Jaber", "Iraq", 600000, DateTime.Now);
            Employees.Rows.Add(2, "Noor Jaber", "Iraq", 1000000, DateTime.Now);
            Employees.Rows.Add(3, "Hider Sadee", "Iraq", 150000, DateTime.Now);
            Employees.Rows.Add(4, "Ahmed Safi", "Iraq", 0.00, DateTime.Now);


            foreach(DataRow row in Employees.Rows)
            {
                Console.WriteLine("ID: {0} \tName: {1} \tCountry: {2} \t Salary: {3} \t Date: {4}",
                    row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            Console.ReadKey();
        }
    }
}
