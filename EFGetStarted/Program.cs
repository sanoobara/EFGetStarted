using EFGetStarted;
using System;
using System.Linq;



// Note: This sample requires the database to be created before running.
//Console.WriteLine($"Database path: {db.DbPath}.");

// Create
Console.WriteLine("Inserting a new blog");
using var db = new BloggingContext();
JsonWorker jsonWorker = new JsonWorker("C:\\Users\\sanek\\source\\repos\\EFGetStarted\\EFGetStarted\\dataemployee.json");
List<Employee> employees = jsonWorker.GetValuesFromJson();

foreach (Employee employee in employees)
{
    db.Add(employee);
}
db.SaveChanges();

var _employee = db.Employees
    .OrderBy(s => s.salary);
foreach(var e in _employee)
{
    Console.WriteLine($"{e.name}\t{e.salary}");
}

var employeesFromDb = db.Employees.ToList();

foreach (Employee employee in employeesFromDb)
{
    Console.WriteLine($"ID: {employee.id}, Name: {employee.name}, Position: {employee.position}");
}

Console.WriteLine("Querying for a blog");
//db.Add(new Employee 

//db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
//db.SaveChanges();

//// Read
//Console.WriteLine("Querying for a blog");
//var blog = db.Blogs
//    .OrderBy(b => b.BlogId)
//    .Last();
////.First();

//// Update
//Console.WriteLine("Updating the blog and adding a post");
//blog.Url = "https://devblogs.microsoft.com/dotnet";
//blog.Posts.Add(
//    new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
//db.SaveChanges();

//// Delete
////Console.WriteLine("Delete the blog");
////db.Remove(blog);
//db.SaveChanges();
