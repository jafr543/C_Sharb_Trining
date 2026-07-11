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
            Employees.Rows.Add(3, "Hider Sadee", "Canada", 150000, DateTime.Now);
            Employees.Rows.Add(4, "Ahmed Safi", "China", 0.00, DateTime.Now);
            Employees.Rows.Add(5, "Fadi JAmeel", "Egypt", 800, DateTime.Now);


            int EmployeeCount = 0;
            double TotalSalaries = 0;
            double AverageSalaries = 0;
            double MaxSalary = 0;
            double MinSalary = 0;


            EmployeeCount = Employees.Rows.Count;
            TotalSalaries = Convert.ToDouble(Employees.Compute("SUM(Salary)", string.Empty));
            AverageSalaries = Convert.ToDouble(Employees.Compute("AVG(Salary)", string.Empty));
            MaxSalary = Convert.ToDouble(Employees.Compute("MAX(Salary)", string.Empty));
            MinSalary = Convert.ToDouble(Employees.Compute("MIN(Salary)", string.Empty));


            Console.WriteLine("Employees List");
            foreach (DataRow row in Employees.Rows)
            {
                Console.WriteLine("ID: {0} \tName: {1} \tCountry: {2} \t Salary: {3} \t Date: {4}",
                    row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            //-----------------------------------------------

            Employees.DefaultView.Sort = "ID Desc";
            Employees = Employees.DefaultView.ToTable();

            Console.WriteLine("\n\nEmployees List Sorted By ID Desc");
            foreach (DataRow row in Employees.Rows)
            {
                Console.WriteLine("ID: {0} \tName: {1} \tCountry: {2} \t Salary: {3} \t Date: {4}",
                    row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            //-----------------------------------------------

            Employees.DefaultView.Sort = "ID Asc";
            Employees = Employees.DefaultView.ToTable();

            Console.WriteLine("\n\nEmployees List Sorted By ID Asc");
            foreach (DataRow row in Employees.Rows)
            {
                Console.WriteLine("ID: {0} \tName: {1} \tCountry: {2} \t Salary: {3} \t Date: {4}",
                    row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            Console.ReadKey();
        }
    }
}
