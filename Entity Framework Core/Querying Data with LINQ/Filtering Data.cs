/*
========================================================
Code Overview
--------------------------------------------------------
Purpose:
- Read connection string from appsettings.json
- Create AppDbContext manually
- Retrieve students
- Preview SQL using ToQueryString()
- Log actual executed SQL
- Compare ToQueryString() vs runtime SQL for Count()


Key Points:
- ToQueryString previews IQueryable shape
- Logging shows runtime SQL
- Count() final SQL differs from preview SQL
========================================================
*/


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TrainingCenter.Data;


// Build configuration
IConfiguration configuration =
    new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", false, true)
        .Build();


// Read connection string
string? connectionString =
    configuration.GetConnectionString("DefaultConnection");


if (string.IsNullOrWhiteSpace(connectionString))
{
    Console.WriteLine("Connection string not found.");
    return;
}


// Create options with logging
var options =
    new DbContextOptionsBuilder<AppDbContext>()
        .UseSqlServer(connectionString)
        //.LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .Options;


// Create context
using var context = new AppDbContext(options);


// Test connection
if (!context.Database.CanConnect())
{
    Console.WriteLine("Could not connect.");
    return;
}


Console.WriteLine("Connected successfully.");
Console.WriteLine();

PrintActiveStudents(context);

void PrintActiveStudents(AppDbContext context)
{
    var query = context.Students.Select(s => new { s.StudentId, s.FirstName, s.LastName, s.Status })
        .Where(s => s.Status == "Active").OrderBy(s => s.StudentId);

    Console.WriteLine("Generated SQL: ");
    Console.WriteLine("======================================");
    Console.WriteLine(query.ToQueryString());

    Console.WriteLine("Active Students:");
    Console.WriteLine("======================================");

    var students = query.ToList(); // This will execute the SQL and log it
    foreach (var student in students)
    {
        Console.WriteLine($"{student.StudentId} - {student.FirstName} {student.LastName}");
    }

    Console.WriteLine("\nTotal Active Students: {0}", students.Count);
}
