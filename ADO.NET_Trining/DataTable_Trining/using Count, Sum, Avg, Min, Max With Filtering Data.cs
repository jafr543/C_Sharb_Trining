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
            Employees.Rows.Add(4, "Fadi JAmeel", "Egypt", 800, DateTime.Now);


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


            Console.WriteLine("Employees Table");
            foreach (DataRow row in Employees.Rows)
            {
                Console.WriteLine("ID: {0} \tName: {1} \tCountry: {2} \t Salary: {3} \t Date: {4}",
                    row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            Console.WriteLine("\nTotalEmployees: " + EmployeeCount);
            Console.WriteLine("TotalSalaries: " + TotalSalaries);
            Console.WriteLine("AverageSalary: " + AverageSalaries);
            Console.WriteLine("MaxSalary: " + MaxSalary);
            Console.WriteLine("MinSalary: " + MinSalary);


            int ResultCount = 0;
            DataRow[] ResultRows;

            //filter only Iraq Users.

            ResultRows = Employees.Select("Country = 'Iraq'");

            Console.WriteLine("\n\nFilter \"Iraq\" Employees\n");

            foreach(DataRow RecordRow in ResultRows)
            {
                //Using Index
                // Console.WriteLine("ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ", RecordRow[0], RecordRow[1], RecordRow[2], RecordRow[3], RecordRow[4]);

                //Using Field Name
                Console.WriteLine(" ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
            }

            ResultCount = ResultRows.Count();
            TotalSalaries = Convert.ToDouble(Employees.Compute("SUM(Salary)", "Country='Iraq'"));
            AverageSalaries = Convert.ToDouble(Employees.Compute("AVG(Salary)", "Country='Iraq'"));
            MinSalary = Convert.ToDouble(Employees.Compute("Min(Salary)", "Country='Iraq'"));
            MaxSalary = Convert.ToDouble(Employees.Compute("Max(Salary)", "Country='Iraq'"));

            Console.WriteLine("\nCount of Employees = " + ResultCount);
            Console.WriteLine("Total Employee Salaries = " + TotalSalaries);
            Console.WriteLine("Average Employee Salaries = " + AverageSalaries);
            Console.WriteLine("Minimum Salary = " + MinSalary);
            Console.WriteLine("Maximum Salary = " + MaxSalary);

            //-----------------------------------------
            Console.ReadKey();
        }
    }
}
