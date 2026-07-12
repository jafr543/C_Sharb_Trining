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


            DataColumn[] PrimaryKeysColumns = new DataColumn[1];
            PrimaryKeysColumns[0] = Employees.Columns["ID"];
            Employees.PrimaryKey = PrimaryKeysColumns;



            Employees.Rows.Add(1, "Jafr Jaber", "Iraq", 600000, DateTime.Now);
            Employees.Rows.Add(2, "Noor Jaber", "Iraq", 1000000, DateTime.Now);
            Employees.Rows.Add(3, "Hider Sadee", "Canada", 150000, DateTime.Now);
            Employees.Rows.Add(4, "Ahmed Safi", "China", 0.00, DateTime.Now);
            Employees.Rows.Add(5, "Fadi Jameel", "Egypt", 800, DateTime.Now);


            
            Console.WriteLine("Employees List with ID as Primary Key");
            foreach (DataRow row in Employees.Rows)
            {
                Console.WriteLine("ID: {0} \tName: {1}\tCountry: {2}    \tSalary: {3}       \tDate: {4}",
                    row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            DataView EmployeesDataView1 = Employees.DefaultView;

            Console.WriteLine("\nEmployees List From Data View"); 

            for(int i = 0; i < EmployeesDataView1.Count; i++)
            {
                Console.WriteLine("{0}, {1}, {2}, ", EmployeesDataView1[i][0], EmployeesDataView1[i][1], EmployeesDataView1[i][2]);
            }


            EmployeesDataView1.RowFilter = "Country = 'Iraq'";

            Console.WriteLine("\nEmployees List From Data View after Filtering \"Iraq\" ");

            for (int i = 0; i < EmployeesDataView1.Count; i++)
            {
                Console.WriteLine("{0}, {1}, {2}, ", EmployeesDataView1[i][0], EmployeesDataView1[i][1], EmployeesDataView1[i][2]);
            }


            Console.ReadKey();
        }
    }
}
