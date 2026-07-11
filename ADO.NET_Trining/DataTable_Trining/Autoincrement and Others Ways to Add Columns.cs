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

            // Fast Way to Add Column

            //Employees.Columns.Add("ID", typeof(int));
            //Employees.Columns.Add("Name", typeof(string));
            //Employees.Columns.Add("Country", typeof(string));
            //Employees.Columns.Add("Salary", typeof(Double));
            //Employees.Columns.Add("Date", typeof(DateTime));


            // other way to Add Column with More Details

            DataColumn dtColumn = new DataColumn();

            dtColumn.ColumnName = "ID";
            dtColumn.DataType = typeof(int);
            dtColumn.AutoIncrement = true;
            dtColumn.AutoIncrementSeed = 1;
            dtColumn.AutoIncrementStep = 1;

            dtColumn.Caption = "Employee ID";
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            Employees.Columns.Add(dtColumn);


            dtColumn = new DataColumn();
            dtColumn.ColumnName = "Name";
            dtColumn.DataType = typeof(string);
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Employee Name";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            Employees.Columns.Add(dtColumn);


            dtColumn = new DataColumn();
            dtColumn.ColumnName = "Country";
            dtColumn.DataType = typeof(string);
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Employee Country";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            Employees.Columns.Add(dtColumn);


            dtColumn = new DataColumn();
            dtColumn.ColumnName = "Salary";
            dtColumn.DataType = typeof(Double);
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Employee Salary";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            Employees.Columns.Add(dtColumn);


            dtColumn = new DataColumn();
            dtColumn.ColumnName = "Date";
            dtColumn.DataType = typeof(string);
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Employee Date";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            Employees.Columns.Add(dtColumn);


            DataColumn[] PrimaryKeysColumns = new DataColumn[1];
            PrimaryKeysColumns[0] = Employees.Columns["ID"];
            Employees.PrimaryKey = PrimaryKeysColumns;



            Employees.Rows.Add(null, "Jafr Jaber", "Iraq", 600000, DateTime.Now);
            Employees.Rows.Add(null, "Noor Jaber", "Iraq", 1000000, DateTime.Now);
            Employees.Rows.Add(null, "Hider Sadee", "Canada", 150000, DateTime.Now);
            Employees.Rows.Add(null, "Ahmed Safi", "China", 0.00, DateTime.Now);
            Employees.Rows.Add(null, "Fadi Jameel", "Egypt", 800, DateTime.Now);


            
            Console.WriteLine("Employees List with ID as Primary Key");
            foreach (DataRow row in Employees.Rows)
            {
                Console.WriteLine("ID: {0} \tName: {1}\tCountry: {2}    \tSalary: {3}       \tDate: {4}",
                    row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

           

            Console.ReadKey();
        }
    }
}
