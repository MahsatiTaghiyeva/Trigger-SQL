using Microsoft.EntityFrameworkCore;
using SchoolManagement.Data;
using SchoolManagement.Models;

var connectionString =
    "Server=(localdb)\\MSSQLLocalDB;" +
    "Database=SchoolDb;" +
    "Trusted_Connection=True;" +
    "TrustServerCertificate=True;";

var options = new DbContextOptionsBuilder<SchoolDbContext>()
    .UseSqlServer(connectionString)
    .Options;

await using var context = new SchoolDbContext(options);

Console.WriteLine("School Management System started!");

var connectionString =
    "Server=(localdb)\\MSSQLLocalDB;" +
    "Database=SchoolDb;" +
    "Trusted_Connection=True;" +
    "TrustServerCertificate=True;";

var options = new DbContextOptionsBuilder<SchoolDbContext>()
    .UseSqlServer(connectionString)
    .Options;

await using var context = new SchoolDbContext(options);

var student = new Student
{
    FirstName = "Ali",
    LastName = "Mammadov",
    Age = 20,
    Email = "ali@example.com"
};

context.Students.Add(student);

await context.SaveChangesAsync();

Console.WriteLine($"Student saved with ID: {student.Id}");